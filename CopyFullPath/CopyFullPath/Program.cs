using System;
using System.Collections.Generic;
using System.IO;
namespace CopyFullPath
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string path = "";
            ///combine  them together
            foreach (string s in args) path = path + s + " ";
            FileInfo f = new FileInfo(path);
            ///then put it into the clipbroad
            System.Windows.Forms.Clipboard.SetText(f.FullName, System.Windows.Forms.TextDataFormat.UnicodeText);
        }
    }
}