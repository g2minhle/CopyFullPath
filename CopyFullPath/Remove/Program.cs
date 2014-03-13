using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;//File
using Microsoft.Win32;//registry
namespace Remove
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ///init the name of the program
			string tenct="Copy full path";
            ///confirm uninstall
            DialogResult dr = MessageBox.Show("Do you want to remove "+tenct+"?", "Uninstall", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ///if yes then
            if (dr.ToString() == "Yes")
            {
                ///get the cur path of the program
               string path=Registry.GetValue("HKEY_CLASSES_ROOT\\*\\Shell\\"+tenct+"\\Command","",null).ToString();
                ///if the path is found  
               if (path != null)
               {
                   ///erase the argument
                   path = path.Substring(0, path.Length - 3);
                   ///then the delete the file
                   File.Delete(path);
                   ///then reedit the registry
                   Registry.ClassesRoot.DeleteSubKeyTree("*\\Shell\\" + tenct);
                   Registry.ClassesRoot.DeleteSubKeyTree("Directory\\Shell\\" + tenct);
                   ///notice to users that the uninstallation has completed
                   MessageBox.Show("Uninstall complete", "Uninstall complete", MessageBoxButtons.OK, MessageBoxIcon.None);
               }
               
               
            }
           }
    }
}