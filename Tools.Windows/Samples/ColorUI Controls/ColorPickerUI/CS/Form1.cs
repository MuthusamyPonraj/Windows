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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbOffice2007Theme;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkUseOffice2007Theme;
        private Syncfusion.Windows.Forms.ButtonAdv btnShowColorGroups;
		private System.Windows.Forms.Label label19;
		private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt1;
		private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt2;
		private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt3;
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        private Panel panel3;
        private SplitContainerAdv splitContainerAdv1;
        private Label label3;
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

            this.SizeChanged += Form1_SizeChanged;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.colorPickerUIAdv1.Location = new Point((this.splitContainerAdv1.Panel1.Width / 2 - this.colorPickerUIAdv1.Width / 2), (this.splitContainerAdv1.Panel1.Height / 2 - this.colorPickerUIAdv1.Height / 2)); 
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
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownExt3 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownExt2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label19 = new System.Windows.Forms.Label();
            this.btnShowColorGroups = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cmbOffice2007Theme = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkUseOffice2007Theme = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectedColorGroup = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbSelectedColorGroup1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUseOffice2007Theme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.HorizontalItemsSpacing = 9;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(38, 46);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(217, 211);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Metro;
            this.colorPickerUIAdv1.TabIndex = 4;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.VerticalItemsSpacing = 4;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(622, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "The new ColorPickerUIAdv is an advanced color palette control that shows custom g" +
    "roup color palettes, Office2007 theme settings and an easy to use UI for color s" +
    "election.";
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
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(20, 389);
            this.textBox1.Metrocolor = System.Drawing.Color.Empty;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(624, 116);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownExt3);
            this.panel1.Controls.Add(this.numericUpDownExt2);
            this.panel1.Controls.Add(this.numericUpDownExt1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.btnShowColorGroups);
            this.panel1.Controls.Add(this.cmbOffice2007Theme);
            this.panel1.Controls.Add(this.chkUseOffice2007Theme);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 289);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDownExt3
            // 
            this.numericUpDownExt3.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt3.Location = new System.Drawing.Point(164, 154);
            this.numericUpDownExt3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt3.Name = "numericUpDownExt3";
            this.numericUpDownExt3.Size = new System.Drawing.Size(117, 22);
            this.numericUpDownExt3.TabIndex = 12;
            this.numericUpDownExt3.ThemedBorder = false;
            this.numericUpDownExt3.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownExt3.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt3.ValueChanged += new System.EventHandler(this.numericUpDownExt3_ValueChanged);
            // 
            // numericUpDownExt2
            // 
            this.numericUpDownExt2.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt2.Location = new System.Drawing.Point(165, 118);
            this.numericUpDownExt2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt2.Name = "numericUpDownExt2";
            this.numericUpDownExt2.Size = new System.Drawing.Size(116, 22);
            this.numericUpDownExt2.TabIndex = 11;
            this.numericUpDownExt2.ThemedBorder = false;
            this.numericUpDownExt2.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt2.ValueChanged += new System.EventHandler(this.numericUpDownExt2_ValueChanged);
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.Location = new System.Drawing.Point(166, 82);
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(115, 22);
            this.numericUpDownExt1.TabIndex = 10;
            this.numericUpDownExt1.ThemedBorder = false;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(59, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Button Height";
            // 
            // btnShowColorGroups
            // 
            this.btnShowColorGroups.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnShowColorGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnShowColorGroups.KeepFocusRectangle = false;
            this.btnShowColorGroups.Location = new System.Drawing.Point(164, 31);
            this.btnShowColorGroups.Name = "btnShowColorGroups";
            this.btnShowColorGroups.Size = new System.Drawing.Size(117, 23);
            this.btnShowColorGroups.TabIndex = 8;
            this.btnShowColorGroups.Text = "Show Color Groups";
            this.btnShowColorGroups.UseVisualStyle = true;
            this.btnShowColorGroups.Click += new System.EventHandler(this.btnShowColorGroups_Click);
            // 
            // cmbOffice2007Theme
            // 
            this.cmbOffice2007Theme.BackColor = System.Drawing.Color.White;
            this.cmbOffice2007Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOffice2007Theme.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Silver"});
            this.cmbOffice2007Theme.Location = new System.Drawing.Point(165, 191);
            this.cmbOffice2007Theme.Name = "cmbOffice2007Theme";
            this.cmbOffice2007Theme.Size = new System.Drawing.Size(116, 21);
            this.cmbOffice2007Theme.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbOffice2007Theme.TabIndex = 7;
            this.cmbOffice2007Theme.Text = "Blue";
            this.cmbOffice2007Theme.SelectedIndexChanged += new System.EventHandler(this.cmbOffice2007Theme_SelectedIndexChanged);
            this.cmbOffice2007Theme.Enabled = false;
            // 
            // chkUseOffice2007Theme
            // 
            this.chkUseOffice2007Theme.Checked = true;
            this.chkUseOffice2007Theme.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkUseOffice2007Theme.DrawFocusRectangle = false;
            this.chkUseOffice2007Theme.Location = new System.Drawing.Point(61, 231);
            this.chkUseOffice2007Theme.MetroColor = System.Drawing.Color.Gray;
            this.chkUseOffice2007Theme.Name = "chkUseOffice2007Theme";
            this.chkUseOffice2007Theme.Size = new System.Drawing.Size(156, 24);
            this.chkUseOffice2007Theme.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkUseOffice2007Theme.TabIndex = 4;
            this.chkUseOffice2007Theme.Text = "Use Office 2007 Theme";
            this.chkUseOffice2007Theme.ThemesEnabled = false;
            this.chkUseOffice2007Theme.CheckedChanged += new System.EventHandler(this.chkUseOffice2007Theme_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Office 2007 Theme";
            this.label16.Enabled = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Vertical Spacing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Horizontal Spacing";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Essential Properties";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // cmbSelectedColorGroup1
            // 
            this.cmbSelectedColorGroup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbSelectedColorGroup1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectedColorGroup1.Location = new System.Drawing.Point(168, 176);
            this.cmbSelectedColorGroup1.Name = "cmbSelectedColorGroup1";
            this.cmbSelectedColorGroup1.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbSelectedColorGroup1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 57);
            this.panel3.TabIndex = 5;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Location = new System.Drawing.Point(20, 92);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.label3);
            this.splitContainerAdv1.Panel1.Controls.Add(this.colorPickerUIAdv1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.panel1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(621, 291);
            this.splitContainerAdv1.SplitterDistance = 295;
            this.splitContainerAdv1.TabIndex = 6;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sample";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(664, 525);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(676, 562);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorPickerUIAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUseOffice2007Theme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).EndInit();
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
			this.cmbOffice2007Theme.SelectedIndex=0;
		}

		#endregion

		#region EventLog

		private void Addlog(string logText)
		{
			this.textBox1.Text += logText +"\r\n";
		}
		#endregion

		#region ColorPickerUIAdv properties


		private void cmbOffice2007Theme_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(this.cmbOffice2007Theme.Text)
			{
				case "Blue":
					this.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
					break;
				case "Black":
					this.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Black;
					break;
				case "Silver":
					this.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
					break;
			}
			Addlog("ColorPickerUIAdv's Office2007Theme set to "+this.colorPickerUIAdv1.Office2007Theme.ToString());
		}

		private void chkUseOffice2007Theme_CheckedChanged(object sender, System.EventArgs e)
		{
            if (this.chkUseOffice2007Theme.Checked)
            {
                this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2007;
                this.colorPickerUIAdv1.UseOffice2007Style = this.chkUseOffice2007Theme.Checked;
                this.cmbOffice2007Theme.Enabled = true;
                this.label16.Enabled = true;
            }
            else
            {
                this.colorPickerUIAdv1.UseOffice2007Style = this.chkUseOffice2007Theme.Checked;
                this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Metro;
                this.cmbOffice2007Theme.Enabled = false;
                this.label16.Enabled = false;
            }

			Addlog("ColorPickerUIAdv's UseOffice2007Style is set to "+this.chkUseOffice2007Theme.Checked.ToString());
		}

		private void btnShowColorGroups_Click(object sender, System.EventArgs e)
		{
			new ColorGroup(this.colorPickerUIAdv1).ShowDialog();
            this.Refresh();
		}


		private void numericUpDownExt1_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.HorizontalItemsSpacing = (int)this.numericUpDownExt1.Value;
			Addlog("ColorPickerUIAdv's HorizontalItemsSpacing set to "+this.numericUpDownExt1.Value.ToString());
		}

		private void numericUpDownExt2_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.VerticalItemsSpacing = (int)this.numericUpDownExt2.Value;
			Addlog("ColorPickerUIAdv's VerticalItemsSpacing set to "+this.numericUpDownExt2.Value.ToString());
		}

		private void numericUpDownExt3_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.ButtonsHeight = (int)this.numericUpDownExt3.Value;
			Addlog("ColorPickerUIAdv's ButtonsHeight set to "+this.numericUpDownExt3.Value.ToString());
		}

		private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
		{
			this.splitContainerAdv1.Panel1.BackColor = this.colorPickerUIAdv1.SelectedItem.Color;
			Addlog("ColorPickerUIAdv is Setting TabPage BackColor to "+this.colorPickerUIAdv1.SelectedItem.Color.ToString());
		}

        #endregion
    }
}
