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

namespace FilterBarGrid
{
	/// <summary>
	/// Summary description for MyFilterDialog.
	/// </summary>
	public class MyFilterDialog : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button showDefaultButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridDataBoundGrid grid = null;
		public DataTable table = null;

		public MyFilterDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.showDefaultButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textBox1.Location = new System.Drawing.Point(24, 24);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(296, 136);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// OkButton
			// 
			this.OkButton.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.OkButton.Location = new System.Drawing.Point(336, 40);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(96, 23);
			this.OkButton.TabIndex = 1;
			this.OkButton.Text = "OK";
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.cancelButton.Location = new System.Drawing.Point(336, 72);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(96, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// showDefaultButton
			// 
			this.showDefaultButton.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.showDefaultButton.Location = new System.Drawing.Point(336, 104);
			this.showDefaultButton.Name = "showDefaultButton";
			this.showDefaultButton.Size = new System.Drawing.Size(96, 23);
			this.showDefaultButton.TabIndex = 3;
			this.showDefaultButton.Text = "Default Dialog";
			this.showDefaultButton.Click += new System.EventHandler(this.showDefaultButton_Click);
			// 
			// MyFilterDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 174);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.showDefaultButton,
																		  this.cancelButton,
																		  this.OkButton,
																		  this.textBox1});
			this.Name = "MyFilterDialog";
			this.Text = "MyFilterDialog";
			this.ResumeLayout(false);

		}
		#endregion

		private void OkButton_Click(object sender, System.EventArgs e)
		{
			//need to test the filter string for validity some how
			//we added a methos that just tries the filter string...
			if(!this.IsFilterStringValid(this.textBox1.Text))
			{
				return;
			}

			this.DialogResult = DialogResult.OK;

			//test the filter

			this.Close();
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void showDefaultButton_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Ignore;
			this.Close();
		}

		protected bool IsFilterStringValid(string filterString)
		{
			string filter = "";
			try
			{
				this.grid.BeginUpdate();
				filter = this.table.DefaultView.RowFilter;
				this.table.DefaultView.RowFilter = filterString;
			}
			catch(Exception ex)
			{
				this.table.DefaultView.RowFilter = filter;
				this.grid.CancelUpdate();
				MessageBox.Show("Improper filter: " + ex.Message);
				return false;
			}
						
			this.table.DefaultView.RowFilter = filter;
			this.grid.CancelUpdate();
			return true;
		}
	}
}
