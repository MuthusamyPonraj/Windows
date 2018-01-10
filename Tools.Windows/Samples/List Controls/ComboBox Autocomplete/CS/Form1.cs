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
using System.Data;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace ComboBoxAutoCompleteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private ArrayList itemsList = new ArrayList();
		private ArrayList alphaList = new ArrayList();
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.GroupBox groupBox1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete comboBoxAutoComplete1;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.Resize += new EventHandler(Form1_Resize);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.MinimumSize = this.Size;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.comboBoxAutoComplete1.Location = new Point(550, 350);
            }
            else
            {
                this.comboBoxAutoComplete1.Location = new Point(125, 177);
            }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxAutoComplete1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAutoComplete1.AutoCompleteControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAutoComplete1
            // 
            // 
            // 
            // 
            this.comboBoxAutoComplete1.AutoCompleteControl.ChangeDataManagerPosition = true;
            this.comboBoxAutoComplete1.AutoCompleteControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.comboBoxAutoComplete1.AutoCompleteControl.OverrideCombo = true;
            this.comboBoxAutoComplete1.AutoCompleteControl.ParentForm = this.groupBox1;
            this.comboBoxAutoComplete1.AutoCompleteControl.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.comboBoxAutoComplete1.DropDownWidth = this.comboBoxAutoComplete1.Width;
            this.comboBoxAutoComplete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAutoComplete1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxAutoComplete1.ItemHeight = 15;
            this.comboBoxAutoComplete1.Location = new System.Drawing.Point(125, 177);
            this.comboBoxAutoComplete1.Name = "comboBoxAutoComplete1";
            this.comboBoxAutoComplete1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.comboBoxAutoComplete1.ParentForm = this.groupBox1;
            this.comboBoxAutoComplete1.Size = new System.Drawing.Size(240, 21);
            this.comboBoxAutoComplete1.TabIndex = 4;
            this.comboBoxAutoComplete1.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2007;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAutoComplete1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 334);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "The ComboBoxAutoComplete control combines a combo box control with an AutoComplet" +
                "e control to provide autocompletion for that instance of the combo box.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(552, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox AutoComplete";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAutoComplete1.AutoCompleteControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			#region DataSource 
			this.alphaList.AddRange(new String[]{"A",
												"B",
												"C",
												"D",
												"E",
												"F",
												"G",
												"H",
												"I",
												"J",
												"K",
												"L",
												"M",
												"N",
												"O",
												"P",
												"Q",
												"R",
												"S",
												"T",
												"U",
												"V",
												"W",
												"X",
												"Y",
												"Z"
			});

			foreach(string s in this.alphaList)
			{
				for(int i = 0; i < 15; i++)
				{
					this.itemsList.Add(s + i.ToString());
				}
			}

			this.comboBoxAutoComplete1.AutoCompleteControl.DataSource = this.itemsList;
            this.comboBoxAutoComplete1.DropDownWidth = this.comboBoxAutoComplete1.Width;
			#endregion
		}

		

	}
}
