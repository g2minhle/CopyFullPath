using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;//file edit
using Microsoft.Win32;//registry 
using Microsoft.VisualBasic;
namespace Install
{
    public partial class Install : Form
    {
        #region Init
        #region var
        string tenfile;
        string tenct;
        bool ied;
        #endregion
        public Install()
        {
            InitializeComponent();
            ///init name of the program , which will be shown in the context menu
            tenct = "Copy full path";
            ///init name of the file , which is the main program
            tenfile = "Copyfullpath";
            ///init the title of the install program
            this.Text = "Install " + tenct;
            ///this variable is used to determine the install condition of the program
            ied = false;
        }
        #endregion


        #region Button click
        /// <summary>
        /// Click the Browse button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd_Browse_Click(object sender, EventArgs e)
        {
            ///enable the new folder button
            fbd_Dialog1.ShowNewFolderButton = true;
            /// show the dialog
            fbd_Dialog1.ShowDialog();
            //get the selected directory
            txt_Path.Text = fbd_Dialog1.SelectedPath;
            //Mes
        }
        /// <summary>
        /// Click the Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Click the Install button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd_Install_Click(object sender, EventArgs e)
        {
            ///if seclected a directory
            if (txt_Path.Text == "")
            {
                MessageBox.Show("You must choose the directory", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ///copy the main program into the instal directory
            File.Copy(tenfile + ".exe", txt_Path.Text + "\\" + tenfile + ".exe", true);
            ///get the full info of the copied file
            FileInfo f = new FileInfo(txt_Path.Text + "\\" + tenfile + ".exe");
            ///set the context menu
            SetContextMenu(tenct, f.FullName);
            ///notice that the installation has completed 
            MessageBox.Show("Setup complete", "Setup complete", MessageBoxButtons.OK, MessageBoxIcon.None);
            ///set the flag that the installation has completed
            ied = true;
            ///close program
            this.Close();

        }
        /// <summary>
        /// when click the x button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Install_FormClosing(object sender, FormClosingEventArgs e)
        {
            ///if the program has not been installed yet , then ake the users if they want to exit or not
            if (!ied)
            {
                ///confirm the exit
                DialogResult dr = MessageBox.Show("Do you really want to exit ?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ///if no then
                if (dr.ToString() == "No")
                {
                    ///the program's closing process will be canceled
                    e.Cancel = true;
                }
            }
        }
        #endregion


        #region Edit registry
        /// <summary>
        /// set context menu by editing the registry 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="command"></param>
        private void SetContextMenu(string name, string command)
        {
            ///set for all file
            Registry.SetValue("HKEY_CLASSES_ROOT\\*\\Shell\\" + name + "\\Command", "", command + " %1");
            ///set for directory
            Registry.SetValue("HKEY_CLASSES_ROOT\\Directory\\Shell\\" + name + "\\Command", "", command + " %1");
        }
        #endregion
    }
}