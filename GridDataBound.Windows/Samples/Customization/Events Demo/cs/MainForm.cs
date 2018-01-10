#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
}

			

		

