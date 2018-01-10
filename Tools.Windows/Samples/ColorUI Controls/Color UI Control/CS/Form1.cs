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
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace ColorUIDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
        private TextBox textBox1;
        private Syncfusion.Windows.Forms.ColorUIControl colorUIControl1;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsersTabName1;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSystemTabName1;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStandardTabName1;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCustomTabName1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkUserColorsStretchOnResize;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbOffice2007Theme;
        private Panel panel3;
        private SplitContainerAdv splitContainerAdv1;
        private Label label2;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTabel1 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkUserColorsStretchOnResize = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.txtUsersTabName1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSystemTabName1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtStandardTabName1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtCustomTabName1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cmbSelectedColorGroup1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.cmbSelectedColorGroup = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbOffice2007Theme = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkUserColorsStretchOnResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsersTabName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSystemTabName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardTabName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomTabName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(687, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(20, 420);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(687, 116);
            this.textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkUserColorsStretchOnResize);
            this.panel2.Controls.Add(this.txtUsersTabName1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtSystemTabName1);
            this.panel2.Controls.Add(this.txtStandardTabName1);
            this.panel2.Controls.Add(this.txtCustomTabName1);
            this.panel2.Controls.Add(this.cmbSelectedColorGroup1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 329);
            this.panel2.TabIndex = 2;
            // 
            // chkUserColorsStretchOnResize
            // 
            this.chkUserColorsStretchOnResize.DrawFocusRectangle = false;
            this.chkUserColorsStretchOnResize.Location = new System.Drawing.Point(96, 247);
            this.chkUserColorsStretchOnResize.MetroColor = System.Drawing.Color.Gray;
            this.chkUserColorsStretchOnResize.Name = "chkUserColorsStretchOnResize";
            this.chkUserColorsStretchOnResize.Size = new System.Drawing.Size(227, 24);
            this.chkUserColorsStretchOnResize.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkUserColorsStretchOnResize.TabIndex = 23;
            this.chkUserColorsStretchOnResize.Text = "Users Color Stretch On Resize";
            this.chkUserColorsStretchOnResize.ThemesEnabled = false;
            this.chkUserColorsStretchOnResize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtUsersTabName1
            // 
            this.txtUsersTabName1.BorderColor = System.Drawing.Color.Gray;
            this.txtUsersTabName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsersTabName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsersTabName1.Location = new System.Drawing.Point(221, 188);
            this.txtUsersTabName1.Metrocolor = System.Drawing.Color.Gray;
            this.txtUsersTabName1.Name = "txtUsersTabName1";
            this.txtUsersTabName1.Size = new System.Drawing.Size(120, 22);
            this.txtUsersTabName1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtUsersTabName1.TabIndex = 22;
            this.txtUsersTabName1.Text = "User Colors";
            this.txtUsersTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsersTabName1_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Users Tab Name";
            // 
            // txtSystemTabName1
            // 
            this.txtSystemTabName1.BorderColor = System.Drawing.Color.Gray;
            this.txtSystemTabName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSystemTabName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSystemTabName1.Location = new System.Drawing.Point(221, 156);
            this.txtSystemTabName1.Metrocolor = System.Drawing.Color.Gray;
            this.txtSystemTabName1.Name = "txtSystemTabName1";
            this.txtSystemTabName1.Size = new System.Drawing.Size(120, 22);
            this.txtSystemTabName1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSystemTabName1.TabIndex = 20;
            this.txtSystemTabName1.Text = "System";
            this.txtSystemTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSystemTabName1_KeyDown);
            // 
            // txtStandardTabName1
            // 
            this.txtStandardTabName1.BorderColor = System.Drawing.Color.Gray;
            this.txtStandardTabName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStandardTabName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStandardTabName1.Location = new System.Drawing.Point(221, 124);
            this.txtStandardTabName1.Metrocolor = System.Drawing.Color.Gray;
            this.txtStandardTabName1.Name = "txtStandardTabName1";
            this.txtStandardTabName1.Size = new System.Drawing.Size(120, 22);
            this.txtStandardTabName1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtStandardTabName1.TabIndex = 19;
            this.txtStandardTabName1.Text = "Web";
            this.txtStandardTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStandardTabName1_KeyDown);
            // 
            // txtCustomTabName1
            // 
            this.txtCustomTabName1.BorderColor = System.Drawing.Color.Gray;
            this.txtCustomTabName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomTabName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomTabName1.Location = new System.Drawing.Point(221, 92);
            this.txtCustomTabName1.Metrocolor = System.Drawing.Color.Gray;
            this.txtCustomTabName1.Name = "txtCustomTabName1";
            this.txtCustomTabName1.Size = new System.Drawing.Size(120, 22);
            this.txtCustomTabName1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtCustomTabName1.TabIndex = 18;
            this.txtCustomTabName1.Text = "Palette";
            this.txtCustomTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomTabName1_KeyDown);
            // 
            // cmbSelectedColorGroup1
            // 
            this.cmbSelectedColorGroup1.BackColor = System.Drawing.Color.White;
            this.cmbSelectedColorGroup1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectedColorGroup1.Items.AddRange(new object[] {
            "None",
            "CustomColors",
            "StandardColors",
            "SystemColors",
            "UserColors"});
            this.cmbSelectedColorGroup1.Location = new System.Drawing.Point(221, 220);
            this.cmbSelectedColorGroup1.Name = "cmbSelectedColorGroup1";
            this.cmbSelectedColorGroup1.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbSelectedColorGroup1.TabIndex = 17;
            this.cmbSelectedColorGroup1.Text = "None";
            this.cmbSelectedColorGroup1.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedColorGroup1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Selected Color Group";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "System Tab Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Standard Tab Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Custom Tab Name";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Essential Properties";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorUIControl1
            // 
            this.colorUIControl1.ColorGroups = ((Syncfusion.Windows.Forms.ColorUIGroups)((((Syncfusion.Windows.Forms.ColorUIGroups.CustomColors | Syncfusion.Windows.Forms.ColorUIGroups.StandardColors) 
            | Syncfusion.Windows.Forms.ColorUIGroups.SystemColors) 
            | Syncfusion.Windows.Forms.ColorUIGroups.UserColors)));
            this.colorUIControl1.Flag = false;
            this.colorUIControl1.Location = new System.Drawing.Point(59, 69);
            this.colorUIControl1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.colorUIControl1.MetroForeColor = System.Drawing.Color.White;
            this.colorUIControl1.Name = "colorUIControl1";
            metroColorTabel1.ArrowChecked = System.Drawing.Color.Black;            
            metroColorTabel1.ArrowNormal = System.Drawing.Color.Gray;
            metroColorTabel1.ArrowPushed = System.Drawing.Color.Black;
            metroColorTabel1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTabel1.ThumbChecked = System.Drawing.Color.Black;           
            metroColorTabel1.ThumbNormal = System.Drawing.Color.Gray;
            metroColorTabel1.ThumbPushed = System.Drawing.Color.Black;
            this.colorUIControl1.ScrollMetroColorTable = metroColorTabel1;
            this.colorUIControl1.SelectedColor = System.Drawing.SystemColors.ControlDarkDark;
            this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorUIControl1.Size = new System.Drawing.Size(211, 228);
            this.colorUIControl1.TabIndex = 0;
            this.colorUIControl1.Text = "colorUIControl1";
            this.colorUIControl1.VisualStyle = Syncfusion.Windows.Forms.ColorUIStyle.Metro;
            this.colorUIControl1.ColorSelected += new System.EventHandler(this.colorUIControl1_ColorSelected);
            // 
            // cmbSelectedColorGroup
            // 
            this.cmbSelectedColorGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbSelectedColorGroup.Location = new System.Drawing.Point(164, 251);
            this.cmbSelectedColorGroup.Name = "cmbSelectedColorGroup";
            this.cmbSelectedColorGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbSelectedColorGroup.TabIndex = 9;
            // 
            // cmbOffice2007Theme
            // 
            this.cmbOffice2007Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbOffice2007Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOffice2007Theme.Location = new System.Drawing.Point(164, 150);
            this.cmbOffice2007Theme.Name = "cmbOffice2007Theme";
            this.cmbOffice2007Theme.Size = new System.Drawing.Size(98, 21);
            this.cmbOffice2007Theme.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbOffice2007Theme.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 57);
            this.panel3.TabIndex = 5;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Location = new System.Drawing.Point(20, 83);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.label2);
            this.splitContainerAdv1.Panel1.Controls.Add(this.colorUIControl1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.panel2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(687, 331);
            this.splitContainerAdv1.SplitterDistance = 289;
            this.splitContainerAdv1.TabIndex = 6;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 33);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sample";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(727, 556);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(739, 593);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color UI Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkUserColorsStretchOnResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsersTabName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSystemTabName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardTabName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomTabName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).EndInit();
            this.panel3.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

		#region FormLoad

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.cmbSelectedColorGroup1.SelectedIndex=0;
		}

		#endregion

		#region EventLog

		private void Addlog(string logText)
		{
			this.textBox1.Text += logText +"\r\n";
		}
		#endregion

		#region ColorUIControl Properties

		private void colorUIControl1_ColorSelected(object sender, System.EventArgs e)
		{
			this.splitContainerAdv1.Panel1.BackColor = this.colorUIControl1.SelectedColor;
			Addlog("ColorUIControl sets TabPage BackColor to "+this.colorUIControl1.SelectedColor.ToString());
		}

		private void cmbSelectedColorGroup1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(this.cmbSelectedColorGroup1.Text)
			{
				case "None":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
					break;
				case "CustomColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
					break;
				case "StandardColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
					break;
				case "SystemColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.SystemColors;
					break;
				case "UserColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.UserColors;
					break;
			}
			Addlog("ColorUIControl's Selected Color Group changed to "+this.cmbSelectedColorGroup1.Text);
		}

		private void txtCustomTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.CustomTabName = this.txtCustomTabName1.Text;
				Addlog("ColorUIControl's Custom Tab Name changed to "+this.txtCustomTabName1.Text);
			}
		}

		private void txtStandardTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.StandardTabName = this.txtStandardTabName1.Text;
				Addlog("ColorUIControl's Standard Tab Name changed to "+this.txtStandardTabName1.Text);
			}
		}

		private void txtSystemTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.SystemTabName = this.txtSystemTabName1.Text;
				Addlog("ColorUIControl's System Tab Name changed to "+this.txtSystemTabName1.Text);
			}
		}

		private void txtUsersTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.UserTabName = this.txtUsersTabName1.Text;
				Addlog("ColorUIControl's User Tab Name changed to "+this.txtUsersTabName1.Text);
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
            this.colorUIControl1.CustomColorsStretchOnResize = this.chkUserColorsStretchOnResize.Checked;
			this.colorUIControl1.UserColorsStretchOnResize = this.chkUserColorsStretchOnResize.Checked;
		}

		#endregion
    }
}
