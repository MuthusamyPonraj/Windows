#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
namespace RepeaterUserControlSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
			/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridRepeaterUserControl1 = new GridRepeaterControl.GridRepeaterUserControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gridRepeaterUserControl1
            // 
            this.gridRepeaterUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRepeaterUserControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridRepeaterUserControl1.Location = new System.Drawing.Point(40, 26);
            this.gridRepeaterUserControl1.Name = "gridRepeaterUserControl1";
            this.gridRepeaterUserControl1.Padding = new System.Windows.Forms.Padding(2);
            this.gridRepeaterUserControl1.Size = new System.Drawing.Size(392, 320);
            this.gridRepeaterUserControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 374);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(448, 374);
            this.Controls.Add(this.gridRepeaterUserControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Repeater User Control Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());	
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
		}

		private GridRepeaterControl.GridRepeaterUserControl gridRepeaterUserControl1;
		private System.Windows.Forms.Panel panel1;

		private DataTable dt;
		private void Form1_Load(object sender, System.EventArgs e)
		{
            
			//create two instances of your user control that defines the control to be repeated.
			// SampleUserControl must derive from GridRepeaterControl.CellUserControl which
			// is derived from UserControl and ICellUserControl. The ICellUserControl support 
			// is what binds the grid cells to your UserControl.
			SampleUserControl.SampleUserControl activeControl = new SampleUserControl.SampleUserControl();
			SampleUserControl.SampleUserControl staticControl = new SampleUserControl.SampleUserControl();

			this.gridRepeaterUserControl1.AddUserControls(activeControl, staticControl, 3);

			//set the binding on the repeater control
			dt = GetTable();
			this.gridRepeaterUserControl1.SetDataBinding(dt);

			//display a second form showing the data in a grid (just as a check)
			//Form2 f = new Form2();
			//f.gridDataBoundGrid1.DataSource = dt;
			//f.gridDataBoundGrid1.CurrentCell.MoveTo(-1, -1);//no current cell
			//f.Show();
			
			//this.ActiveControl = gridRepeaterUserControl1.Grid;
			//gridRepeaterUserControl1.Grid.CurrentCell.MoveTo(1, 1);
			//gridRepeaterUserControl1.Grid.CurrentCell.BeginEdit();

			// Handle the SaveCellInfo and set e.Handled to true so that
			// values are not saved to GridData
			this.gridRepeaterUserControl1.Grid.SaveCellInfo += new GridSaveCellInfoEventHandler(Grid_SaveCellInfo);
			this.gridRepeaterUserControl1.Grid.TopRowChanging += new GridRowColIndexChangingEventHandler(Grid_TopRowChanging);
		}

		private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

		
		void Grid_TopRowChanging(object sender, GridRowColIndexChangingEventArgs e)
        {
            if (gridRepeaterUserControl1.Grid.ViewLayout.HasPartialVisibleRows && gridRepeaterUserControl1.Grid.CurrentCell.RowIndex == gridRepeaterUserControl1.Grid.ViewLayout.LastVisibleRow)
            {
                gridRepeaterUserControl1.Grid.CurrentCell.MoveTo(-1, -1);
            }
        }
		#region Sample Data
		private DataTable GetTable()
		{
			DataTable dt = new DataTable("Table");
			dt.Columns.Add(new DataColumn("Name"));
			dt.Columns.Add(new DataColumn("City"));
			dt.Columns.Add(new DataColumn("Zip"));

			for(int i = 0; i < 50; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[0] = string.Format("Name{0}", i);
				dr[1] = string.Format("City{0}", i);
				dr[2] = string.Format("Zip{0}", i);
				dt.Rows.Add(dr);
			}
			return dt;
		}
		#endregion

		private void Grid_SaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
		{
			e.Handled = true;
		}
	}
	
	/// <summary>
	/// Represents a class that is used to find the licensing file for Syncfusion controls.
	/// </summary>
	public class DemoCommon
	{

		/// <summary>
		/// Finds the license key from the Common folder.
		/// </summary>
		/// <returns>Returns the license key.</returns>
		public static string FindLicenseKey()
		{
			string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
			for (int n = 0; n < 20; n++)
			{
				if (!System.IO.File.Exists(licenseKeyFile))
				{
					licenseKeyFile = @"..\" + licenseKeyFile;
					continue;
				}
				return System.IO.File.ReadAllText(licenseKeyFile);
			}
			return string.Empty;
		}
	}
}
