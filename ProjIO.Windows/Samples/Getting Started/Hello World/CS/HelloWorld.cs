using System;
using System.Windows.Forms;
using Syncfusion.ProjIO;
using System.Diagnostics;
using System.ComponentModel;

namespace EssentialProjectIOSamples
{
    public partial class HelloWorld : Form
    {
        #region Fields
        private const string outputFileName = "NewProject.xml";
        private string CurrentDirectory = string.Empty;
        #endregion

        #region Construtor
        public HelloWorld()
        {
            InitializeComponent();
            CurrentDirectory = Environment.CurrentDirectory;
        }
        #endregion

        #region Events
        /// <summary>
        /// Creates Project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create an instance of Project
            Project project = new Project();

            //creating a new task
            Task task = new Task("Hello World task");

            //specifying the start date and duration for the task
            task.Start = DateTime.Now;
            task.Duration = TimeSpan.FromHours(16);

            //Add the task to the project
            project.RootTask.Children.Add(task);

            //Invoking this method to recalculate IDs of the task present in the project
            project.CalculateTaskIDs();

            // Save the project
            project.Save(outputFileName);

            //Message box confirmation to view the created project.
            if (MessageBox.Show("Do you want to view the Project file?", "Project file has been created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
    }
}
