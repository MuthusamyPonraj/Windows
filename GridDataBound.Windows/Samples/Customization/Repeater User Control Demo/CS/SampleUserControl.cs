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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SampleUserControl
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class SampleUserControl : GridRepeaterControl.CellUserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox zipTextBox;
		private System.Windows.Forms.Label titleLabel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SampleUserControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.zipTextBox = new System.Windows.Forms.TextBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Name :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(72, 40);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(272, 20);
			this.nameTextBox.TabIndex = 0;
			this.nameTextBox.Text = "name";
			this.nameTextBox.TextChanged += new System.EventHandler(this.userControl_ItemChanged);
			// 
			// label2
			// 
			this.label2.Enabled = false;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "City :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Enabled = false;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(227, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Zip  :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(71, 72);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(152, 20);
			this.cityTextBox.TabIndex = 1;
			this.cityTextBox.Text = "city";
			this.cityTextBox.TextChanged += new System.EventHandler(this.userControl_ItemChanged);
			// 
			// zipTextBox
			// 
			this.zipTextBox.Location = new System.Drawing.Point(264, 72);
			this.zipTextBox.Name = "zipTextBox";
			this.zipTextBox.Size = new System.Drawing.Size(80, 20);
			this.zipTextBox.TabIndex = 2;
			this.zipTextBox.Text = "zip";
			this.zipTextBox.TextChanged += new System.EventHandler(this.userControl_ItemChanged);
			// 
			// titleLabel
			// 
			this.titleLabel.Enabled = false;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(32, 8);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(272, 24);
			this.titleLabel.TabIndex = 6;
			this.titleLabel.Text = "Title";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SampleUserControl
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(201)), ((System.Byte)(219)));
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label3,
																		  this.titleLabel,
																		  this.label2,
																		  this.cityTextBox,
																		  this.label1,
																		  this.nameTextBox,
																		  this.zipTextBox});
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "SampleUserControl";
			this.Size = new System.Drawing.Size(352, 104);
			this.ResumeLayout(false);

		}
		#endregion

		#region Implementation of ICellUserControl

		// Assumes knowledge of the DataTable and where these
		// fields are linked on this usercontrol.
		//dt.Columns.Add(new DataColumn("Name")) - nameTextBox;
		//dt.Columns.Add(new DataColumn("City")) - cityTextBox;
		//dt.Columns.Add(new DataColumn("Zip")) - zipTextBox;

		public override bool UserControlIsModified()
		{
			return modified;
		}

		//set values into this user control
		public override void UserControlSetValues(DataRowView drv)
		{
			modified = false;
			try
			{
				//Console.WriteLine("UserControlSetValues");
				this.nameTextBox.Text = (string)drv["Name"];
				this.cityTextBox.Text = (string)drv["City"];
				this.zipTextBox.Text = (string)drv["Zip"];
			}
			catch{}

			SetTitleLabel();
		}

		//get values from this user control
		public override void UserControlGetValues(DataRowView drv)
		{
			//Console.WriteLine("UserControlGetValues");
			drv["Name"] = this.nameTextBox.Text;
			drv["City"] = this.cityTextBox.Text;
			drv["Zip"] = this.zipTextBox.Text;

		}
		#endregion

		private bool modified = false;
		private void userControl_ItemChanged(object sender, System.EventArgs e)
		{
			modified = true;
			SetTitleLabel();
		}

		//tileLable is being treatedas an expression field that depend upon the bound entries
		//in a readonly way...
		private void SetTitleLabel()
		{
			this.titleLabel.Text = this.nameTextBox.Text + ", " + this.cityTextBox.Text;
		}
		
	}
}
