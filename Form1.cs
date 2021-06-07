using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rebuild_Icon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string url = folder_url.Text;
            string bas = folder_icon.Text;
            string type = TypeIcon.Text;

            if (Directory.Exists(url))
            {
                log($"~ Found Folder {url} and Set to {type}");
                int all = 0;
                int found = 0;
                int error = 0;
                int remove_icon = 0;
                int noremove_icon = 0;
                int remove_config = 0;
                DirectoryInfo info = new DirectoryInfo(url);
                foreach (DirectoryInfo file in info.GetDirectories())
                {
                    var dir = file.FullName;

                    var ico = @$"{dir}\{bas}";
                    var ini = @$"{dir}\desktop.ini";
                    var hid = @$"{dir}\.hidden";

                    all++;
                    //log(ico);
                    //Thread.Sleep(600);

                    if (is_remove_config.Checked)
                    {
                        var tes = RetIcon(dir, bas,is_remove_icon_found.Checked);
                        if (!tes)
                        {
                            log($"Faild - {ico} : Remove Config False - Remove Icon {is_remove_icon_found.Checked}");
                        }
                        else
                        {
                            if (is_remove_icon_found.Checked)
                            {
                                log($"Remove - {ico} : Remove Config {tes} - Remove Icon True");
                            }
                        }
                        
                        remove_config++;
                    }
                    else
                    {
                        // check file icon
                        if (File.Exists(ico))
                        {
                            try
                            {
                                // Making file ini
                                string[] lines = { "[.ShellClassInfo]", $"IconResource={bas},0", "[ViewState]", "Mode=", "Vid=", $"FolderType={type}" };
                                File.WriteAllLines(ini, lines);

                                // Making file hide            
                                string[] linesLinux = { "desktop.ini", bas };
                                File.WriteAllLines(dir + @"\.hidden", linesLinux);

                                // Making system files and hidden
                                File.SetAttributes(ini, File.GetAttributes(ini) | FileAttributes.Hidden | FileAttributes.System);
                                File.SetAttributes(ico, File.GetAttributes(ico) | FileAttributes.Hidden);
                                File.SetAttributes(hid, File.GetAttributes(hid) | FileAttributes.Hidden | FileAttributes.System);

                                // Making folder Read Only?
                                //File.SetAttributes(dir, File.GetAttributes(dir) | FileAttributes.ReadOnly);

                                //var tes = RandomNumber(0, 999);
                                // Attempt 01 
                                //Directory.Move(dir, dir + $"_Processing_{tes}");
                                //Directory.Move(dir + $"_Processing_{tes}", dir);

                                found++;
                            }
                            catch (Exception ee)
                            {
                                log($"Error - {ico} : {ee.Message}");
                                error++;
                            }
                        }
                        else
                        {
                            log($"{ico} : No Icon Found?");
                            error++;
                        }
                    }
                }

                // Reset Icon
                if (auto_clear.Checked)
                {
                    RefreshIcons();
                }                

                log($"All Folder {all} | Icon OK {found} - Icon Error {error} | Remove Config {remove_config}");
            }
            else
            {
                log("~ No Found Folder");
            }
        }

        public void log(string send)
        {
            Log.AppendText(send);
            Log.AppendText(Environment.NewLine);
        }

        public bool RefreshIcons()
        {
            // Attempt 02
            string localIconCachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\IconCache.db";
            if (File.Exists(localIconCachePath))
            {
                File.Delete(localIconCachePath);
            }
            // Attempt 03
            string dirCachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Windows\Explorer\";
            DirectoryInfo di = new DirectoryInfo(dirCachePath);
            FileInfo[] files = di.GetFiles("iconcache*.db");
            foreach (FileInfo file in files)
            {
                File.Delete(file.FullName);
            }
            // Attempt 04.01
            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C ie4uinit.exe -ClearIconCache";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo = startInfo;
                process.Start();
            }
            // Attempt 04.02
            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C ie4uinit.exe -ClearIconCache";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo = startInfo;
                process.Start();
            }
            // Attempt 05
            /*
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainModule.ModuleName.Contains("explorer") == true)
                {
                    p.Kill();
                }
            }
            Process.Start("explorer.exe");
            */

            // Attempt 06
            // Copied from stackoverflow.com
            SHChangeNotify(0x08000000, 0x0000, (IntPtr)null, (IntPtr)null);//SHCNE_ASSOCCHANGED SHCNF_IDLIST

            return true;
        }

        public void Restart()
        {
            // find all the explorer processes and kill them
            Process[] explorer = Process.GetProcessesByName("explorer");
            foreach (Process process in explorer)
            {
                process.Kill();
            }

            // start a new explorer process
            Process.Start("explorer.exe");
        }

        public bool RetIcon(string dir, string icon,bool remove=false)
        {
            try
            {
                // desktop.ini
                if (File.Exists(dir + @"\desktop.ini"))
                {
                    File.SetAttributes(dir + @"\desktop.ini", File.GetAttributes(dir + @"\desktop.ini") | FileAttributes.Normal); //Normal file
                    FileInfo fileInfo = new FileInfo(dir + @"\desktop.ini")
                    {
                        IsReadOnly = false
                    };
                    File.Delete(dir + @"\desktop.ini");
                }                
                // .hidden
                if (File.Exists(dir + @"\.hidden"))
                {
                    File.SetAttributes(dir + @"\.hidden", File.GetAttributes(dir + @"\.hidden") | FileAttributes.Normal); //Normal file
                    FileInfo fileInfo = new FileInfo(dir + @"\.hidden")
                    {
                        IsReadOnly = false
                    };
                    File.Delete(dir + @"\.hidden");
                }
                // Icon.ico
                if (File.Exists(dir + @"\" + icon))
                {
                    File.SetAttributes(dir + @"\" + icon, File.GetAttributes(dir + @"\" + icon) | FileAttributes.Normal); //Normal file
                    FileInfo fileInfo = new FileInfo(dir + @"\" + icon)
                    {
                        IsReadOnly = false
                    };
                    if (remove)
                    {
                        File.Delete(dir + @"\" + icon);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Instantiate random number generator.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        // Copied from stackoverflow.com
        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify(int wEventId, int uFlags, IntPtr dwItem1, IntPtr dwItem2);

        private void Form1_Load(object sender, EventArgs e)
        {
            TypeIcon.SelectedIndex = 0;
        }

        private void bt_clear_cache_Click(object sender, EventArgs e)
        {
            RefreshIcons();
        }

        private void bt_restart_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
