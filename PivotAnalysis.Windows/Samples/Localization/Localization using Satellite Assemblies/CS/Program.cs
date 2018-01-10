#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string targetPath = Application.StartupPath + "\\";
            string sourceFile = System.IO.Path.GetFullPath("..\\..\\de-DE\\run.bat");
            if (!System.IO.File.Exists(targetPath + "\\run.bat"))
            {
                System.IO.File.Copy(sourceFile, targetPath + "\\run.bat");
            }
            ProcessStartInfo pstart = new ProcessStartInfo("run.bat");
            pstart.UseShellExecute = false;
            //Hide DOS window
            pstart.CreateNoWindow = true;
            Process.Start(pstart);
                        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
