#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Windows.Forms;
using Syncfusion.ProjIO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace EssentialProjectIOSamples
{
    public partial class InsertingResources : Form
    {
        #region Constants
        private const string outputFileName = "NewResources.xml";
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\..\Common\Data\ProjIO\{0}";
		private string CurrentDirectory=string.Empty;
        #endregion

        #region Constructor
        public InsertingResources()
        {
            InitializeComponent();
			CurrentDirectory= Environment.CurrentDirectory;
        }
        #endregion

        #region Events
        /// <summary>
        /// Creates Project with tasks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsertResources_Click(object sender, EventArgs e)
        {
            // Create an instance of the Project
            Project project = new Project();

            //Get the path of the input file
            string inputPath = GetFullTemplatePath("NewTasks.xml");
            project = ProjectReader.Open(inputPath );
            //Create Resources
            Resource managerResource = new Resource();
            managerResource.Name = "Product Manager";

            Resource managerResource1 = new Resource();
            managerResource1.Name = "Resource Manager";

            Resource leaderResource = new Resource();
            leaderResource.Name = "Team Leader";

            //Add resources to project
            project.Resources.Add(managerResource);
            project.Resources.Add(managerResource1);
            project.Resources.Add(leaderResource);

            //Invoke method to calculate Resource ID
            project.CalculateResourceIDs();

            //Create Assignments
            Assignment scopeAssign = new Assignment();
            scopeAssign.Task = project.GetTaskByUID(2);
            scopeAssign.Resource = managerResource;

            Assignment sponsorAssign = new Assignment();
            sponsorAssign.Task = project.GetTaskByUID(3);
            sponsorAssign.Resource = managerResource;

            Assignment taskAssign = new Assignment();
            taskAssign.Task = project.GetTaskByUID(4);
            taskAssign.Resource = managerResource1;

            Assignment taskAssign1 = new Assignment();
            taskAssign1.Task = project.GetTaskByUID(5);
            taskAssign1.Resource = leaderResource;

            Assignment taskAssign2 = new Assignment();
            taskAssign2.Task = project.GetTaskByUID(6);
            taskAssign2.Resource = leaderResource;

            //Add assignments to project
            project.Assignments.Add(scopeAssign);
            project.Assignments.Add(sponsorAssign);
            project.Assignments.Add(taskAssign);
            project.Assignments.Add(taskAssign1);
            project.Assignments.Add(taskAssign2);

            // Save the project
            project.Save(outputFileName);

            project = ProjectReader.Open(outputFileName);

            //Message box confirmation to view the created project.
            if (MessageBox.Show("Do you want to view the Project file?", "Project file has been created",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information)
               == DialogResult.Yes)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo("WINPROJ.exe");
                    startInfo.Arguments = "\"" + CurrentDirectory + "\\" + outputFileName + "\"";
                    Process.Start(startInfo);

                    //Exit
                    this.Close();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("MS Project is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
                // Exit
                this.Close();
        }

        #endregion

        #region HelperMethods
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion
    }
}
