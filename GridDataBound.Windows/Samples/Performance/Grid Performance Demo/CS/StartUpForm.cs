#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
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

namespace GridPerf
{
	/// <summary>
	/// Summary description for StartUpForm.
	/// </summary>
	public class StartUpForm : System.Windows.Forms.Form
	{
        private Syncfusion.Windows.Forms.ButtonAdv GDBGbutton;
        private Syncfusion.Windows.Forms.ButtonAdv DGbutton;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StartUpForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;
            //System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            //this.Icon = ico ;	
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
            this.GDBGbutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.DGbutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GDBGbutton
            // 
            this.GDBGbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.GDBGbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.GDBGbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDBGbutton.Location = new System.Drawing.Point(76, 22);
            this.GDBGbutton.Name = "GDBGbutton";
            this.GDBGbutton.Size = new System.Drawing.Size(144, 40);
            this.GDBGbutton.TabIndex = 0;
            this.GDBGbutton.Text = "GridDataBoundGrid";
            this.GDBGbutton.UseVisualStyle = true;
            this.GDBGbutton.Click += new System.EventHandler(this.GDBGbutton_Click);
            // 
            // DGbutton
            // 
            this.DGbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.DGbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.DGbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGbutton.Location = new System.Drawing.Point(76, 144);
            this.DGbutton.Name = "DGbutton";
            this.DGbutton.Size = new System.Drawing.Size(144, 40);
            this.DGbutton.TabIndex = 1;
            this.DGbutton.Text = "DataGrid";
            this.DGbutton.UseVisualStyle = true;
            this.DGbutton.Click += new System.EventHandler(this.DGbutton_Click);
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Virtual GridControl";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DGbutton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.GDBGbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 198);
            this.panel1.TabIndex = 4;
            // 
            // StartUpForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(304, 198);
            this.Controls.Add(this.panel1);
            this.Name = "StartUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grid Performance Demo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif		
			Application.Run(new StartUpForm());
		}

		private void GGCbutton_Click(object sender, System.EventArgs e)
		{
			//GroupingPerf.GridGroupingControlForm f = new GroupingPerf.GridGroupingControlForm();
			//f.Show();
		}

		private void GDBGbutton_Click(object sender, System.EventArgs e)
		{
			GridDataBoundGridPerf.GridDataBoundGridForm f = new GridDataBoundGridPerf.GridDataBoundGridForm();
			f.Show();
		}

		private void DGbutton_Click(object sender, System.EventArgs e)
		{
			DataGridPerf.DataGridForm f = new DataGridPerf.DataGridForm();
			f.Show();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			VirtualGridControlPerf.VirtualGridControlForm f = new VirtualGridControlPerf.VirtualGridControlForm();
			f.Show();
		}
	}
}
