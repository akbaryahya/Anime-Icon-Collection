
namespace Rebuild_Icon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.folder_url = new System.Windows.Forms.TextBox();
            this.folder_icon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeIcon = new System.Windows.Forms.ComboBox();
            this.is_remove_icon_found = new System.Windows.Forms.CheckBox();
            this.bt_clear_cache = new System.Windows.Forms.Button();
            this.is_remove_config = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(423, 300);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(53, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(12, 12);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(468, 212);
            this.Log.TabIndex = 1;
            // 
            // folder_url
            // 
            this.folder_url.Location = new System.Drawing.Point(12, 251);
            this.folder_url.Name = "folder_url";
            this.folder_url.Size = new System.Drawing.Size(231, 23);
            this.folder_url.TabIndex = 2;
            this.folder_url.Text = "D:\\tes";
            // 
            // folder_icon
            // 
            this.folder_icon.Location = new System.Drawing.Point(249, 251);
            this.folder_icon.Name = "folder_icon";
            this.folder_icon.Size = new System.Drawing.Size(231, 23);
            this.folder_icon.TabIndex = 3;
            this.folder_icon.Text = "i.ico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(249, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base Icon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type Folder";
            // 
            // TypeIcon
            // 
            this.TypeIcon.FormattingEnabled = true;
            this.TypeIcon.Items.AddRange(new object[] {
            "Videos",
            "Pictures",
            "Music",
            "Documents",
            "Generic"});
            this.TypeIcon.Location = new System.Drawing.Point(12, 301);
            this.TypeIcon.Name = "TypeIcon";
            this.TypeIcon.Size = new System.Drawing.Size(231, 23);
            this.TypeIcon.TabIndex = 7;
            // 
            // is_remove_icon_found
            // 
            this.is_remove_icon_found.AutoSize = true;
            this.is_remove_icon_found.Location = new System.Drawing.Point(12, 330);
            this.is_remove_icon_found.Name = "is_remove_icon_found";
            this.is_remove_icon_found.Size = new System.Drawing.Size(95, 19);
            this.is_remove_icon_found.TabIndex = 8;
            this.is_remove_icon_found.Text = "Remove Icon";
            this.is_remove_icon_found.UseVisualStyleBackColor = true;
            // 
            // bt_clear_cache
            // 
            this.bt_clear_cache.Location = new System.Drawing.Point(338, 300);
            this.bt_clear_cache.Name = "bt_clear_cache";
            this.bt_clear_cache.Size = new System.Drawing.Size(79, 23);
            this.bt_clear_cache.TabIndex = 9;
            this.bt_clear_cache.Text = "Clear Cache";
            this.bt_clear_cache.UseVisualStyleBackColor = true;
            this.bt_clear_cache.Click += new System.EventHandler(this.bt_clear_cache_Click);
            // 
            // is_remove_config
            // 
            this.is_remove_config.AutoSize = true;
            this.is_remove_config.Location = new System.Drawing.Point(113, 330);
            this.is_remove_config.Name = "is_remove_config";
            this.is_remove_config.Size = new System.Drawing.Size(108, 19);
            this.is_remove_config.TabIndex = 10;
            this.is_remove_config.Text = "Remove Config";
            this.is_remove_config.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 356);
            this.Controls.Add(this.is_remove_config);
            this.Controls.Add(this.bt_clear_cache);
            this.Controls.Add(this.is_remove_icon_found);
            this.Controls.Add(this.TypeIcon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folder_icon);
            this.Controls.Add(this.folder_url);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Rebuild Icon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox folder_url;
        private System.Windows.Forms.TextBox folder_icon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeIcon;
        private System.Windows.Forms.CheckBox is_remove_icon_found;
        private System.Windows.Forms.Button bt_clear_cache;
        private System.Windows.Forms.CheckBox is_remove_config;
    }
}

