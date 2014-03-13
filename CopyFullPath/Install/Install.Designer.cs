namespace Install
{
    partial class Install
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Install));
            this.cmd_Install = new System.Windows.Forms.Button();
            this.cmd_Cancel = new System.Windows.Forms.Button();
            this.cmd_Browse = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbd_Dialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // cmd_Install
            // 
            this.cmd_Install.Location = new System.Drawing.Point(330, 50);
            this.cmd_Install.Name = "cmd_Install";
            this.cmd_Install.Size = new System.Drawing.Size(75, 23);
            this.cmd_Install.TabIndex = 0;
            this.cmd_Install.Text = "Install";
            this.cmd_Install.UseVisualStyleBackColor = true;
            this.cmd_Install.Click += new System.EventHandler(this.cmd_Install_Click);
            // 
            // cmd_Cancel
            // 
            this.cmd_Cancel.Location = new System.Drawing.Point(411, 50);
            this.cmd_Cancel.Name = "cmd_Cancel";
            this.cmd_Cancel.Size = new System.Drawing.Size(75, 23);
            this.cmd_Cancel.TabIndex = 1;
            this.cmd_Cancel.Text = "Cancel";
            this.cmd_Cancel.UseVisualStyleBackColor = true;
            this.cmd_Cancel.Click += new System.EventHandler(this.cmd_Cancel_Click);
            // 
            // cmd_Browse
            // 
            this.cmd_Browse.Location = new System.Drawing.Point(411, 21);
            this.cmd_Browse.Name = "cmd_Browse";
            this.cmd_Browse.Size = new System.Drawing.Size(75, 23);
            this.cmd_Browse.TabIndex = 2;
            this.cmd_Browse.Text = "Browse...";
            this.cmd_Browse.UseVisualStyleBackColor = true;
            this.cmd_Browse.Click += new System.EventHandler(this.cmd_Browse_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(12, 23);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.ReadOnly = true;
            this.txt_Path.Size = new System.Drawing.Size(393, 20);
            this.txt_Path.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Programs will be intalled at :";
            // 
            // Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 81);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.cmd_Browse);
            this.Controls.Add(this.cmd_Cancel);
            this.Controls.Add(this.cmd_Install);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Install";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Copy Full Path";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Install_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Install;
        private System.Windows.Forms.Button cmd_Cancel;
        private System.Windows.Forms.Button cmd_Browse;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbd_Dialog1;
    }
}

