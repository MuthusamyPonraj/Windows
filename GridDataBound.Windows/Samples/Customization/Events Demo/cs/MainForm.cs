using System;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Diagnostics;

namespace DataBoundGridEvents
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class MainForm
	{
		Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
		Syncfusion.Windows.Forms.SplitterControl splitterControl1;
		
		Form1 form;

		public MainForm(Form1 form)
		{
			this.form = form;
			this.gridDataBoundGrid1 = form.gridDataBoundGrid1;
			this.splitterControl1 = form.splitterControl1;
			InitializeForm();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
			Form1 form = new Form1();
			MainForm main = new MainForm(form);
			Application.Run(form);
		}

		void InitializeForm()
		{
            form.Text = "Data Bound Grid Events Demo";

			gridDataBoundGrid1.BeginUpdate();
			gridDataBoundGrid1.TableStyle.FloatCell = true;
			gridDataBoundGrid1.EndUpdate(true);
			gridDataBoundGrid1.ForceCurrentCellMoveTo = true;
			
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

			

		

