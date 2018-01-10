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

namespace AutoCompleteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        private System.Windows.Forms.ImageList imageList1;
        public TextBoxExt textBox1;
		private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete1;
		private System.Windows.Forms.Label label3;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.ImageList imageList2;
		private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete2;
		internal System.Windows.Forms.Label label5;
        public TextBoxExt textBox4;
        private TextBoxExt textBox5;
		private System.Windows.Forms.ImageList imageList3;
		private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo1;
		private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo2;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo3;
        private ComboBoxAdv comboBoxAdv2;
        private Label label6;
        private Label label2;
        private Label label10;
        private Label label4;
        private GradientPanel gradientPanel2;
        private Label label15;
        private GradientPanel gradientPanel1;
        private Label label40;
        private ToolTip toolTip1;
        internal Label label9;
        private TextBoxExt textBox6;
        private AutoLabel autoLabel1;
        private SplitContainerAdv splitContainerAdv1;
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoComplete1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.textBox5 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox4 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox6 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.autoCompleteDataColumnInfo1 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("URL", 100, true);
            this.autoCompleteDataColumnInfo2 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Name", 100, true);
            this.autoCompleteDataColumnInfo3 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("ImageIndex", 100, true);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.autoComplete2 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Disabled",
            "AutoSuggest",
            "AutoAppend",
            "Both"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Disabled"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "AutoSuggest"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "AutoAppend"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Both"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(169, 142);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(133, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 10;
            this.comboBoxAdv1.Text = "Disabled";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set AutoComplete Mode:";
            // 
            // textBox1
            // 
            this.autoComplete1.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(492, 142);
            this.textBox1.Metrocolor = System.Drawing.Color.Gray;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox1.TabIndex = 6;
            // 
            // autoComplete1
            // 
            this.autoComplete1.AutoAddItem = true;
            this.autoComplete1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete1.ParentForm = this;
            this.autoComplete1.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoComplete1.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemSelected);
            this.autoComplete1.AutoCompleteItemBrowsed += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemBrowsed);
            // 
            // textBox5
            // 
            this.textBox5.BorderColor = System.Drawing.Color.Gray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox5.Location = new System.Drawing.Point(0, 233);
            this.textBox5.Metrocolor = System.Drawing.Color.Empty;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(831, 97);
            this.textBox5.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            this.autoComplete2.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.textBox4.BorderColor = System.Drawing.Color.Gray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(172, 161);
            this.textBox4.Metrocolor = System.Drawing.Color.Gray;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(467, 22);
            this.textBox4.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox4.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.BorderColor = System.Drawing.Color.Gray;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(169, 174);
            this.textBox6.Metrocolor = System.Drawing.Color.Gray;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(73, 22);
            this.textBox6.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox6.TabIndex = 35;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "MultiSuggest",
            "MultiSuggestExtended"});
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "MultiSuggest"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "MultiSuggestExtended"));
            this.comboBoxAdv2.Location = new System.Drawing.Point(172, 133);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(134, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 13;
            this.comboBoxAdv2.Text = "MultiSuggestExtended";
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(439, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "TextBox";
            // 
            // autoCompleteDataColumnInfo1
            // 
            this.autoCompleteDataColumnInfo1.ColumnHeaderText = "URL";
            this.autoCompleteDataColumnInfo1.ImageColumn = false;
            this.autoCompleteDataColumnInfo1.MatchingColumn = true;
            this.autoCompleteDataColumnInfo1.Visible = true;
            // 
            // autoCompleteDataColumnInfo2
            // 
            this.autoCompleteDataColumnInfo2.ColumnHeaderText = "Name";
            this.autoCompleteDataColumnInfo2.ImageColumn = false;
            this.autoCompleteDataColumnInfo2.MatchingColumn = false;
            this.autoCompleteDataColumnInfo2.Visible = true;
            // 
            // autoCompleteDataColumnInfo3
            // 
            this.autoCompleteDataColumnInfo3.ColumnHeaderText = "ImageIndex";
            this.autoCompleteDataColumnInfo3.ImageColumn = true;
            this.autoCompleteDataColumnInfo3.MatchingColumn = false;
            this.autoCompleteDataColumnInfo3.Visible = true;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            this.imageList3.Images.SetKeyName(2, "");
            this.imageList3.Images.SetKeyName(3, "");
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(4, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "UnBounded DataSource";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(4, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bounded DataSource";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Set AutoComplete Mode:";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label40);
            this.gradientPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(152, 27);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(595, 82);
            this.gradientPanel1.TabIndex = 26;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(0, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(593, 80);
            this.label40.TabIndex = 1;
            this.label40.Text = resources.GetString("label40.Text");
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel2.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.label15);
            this.gradientPanel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel2.Location = new System.Drawing.Point(152, 18);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(594, 76);
            this.gradientPanel2.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(592, 74);
            this.label15.TabIndex = 1;
            this.label15.Text = "The DataSource for this AutoComplete control is set to an XML Datasource. Enter h" +
                " to view the autocomplete. ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(4, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Event Log";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(26, 181);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(137, 13);
            this.autoLabel1.TabIndex = 34;
            this.autoLabel1.Text = "Number Of Suggestions :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "TextBox";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.Location = new System.Drawing.Point(10, 10);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            this.splitContainerAdv1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.label10);
            this.splitContainerAdv1.Panel1.Controls.Add(this.textBox6);
            this.splitContainerAdv1.Panel1.Controls.Add(this.label3);
            this.splitContainerAdv1.Panel1.Controls.Add(this.autoLabel1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.comboBoxAdv1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.textBox1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.label5);
            this.splitContainerAdv1.Panel1.Controls.Add(this.gradientPanel1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.label2);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label9);
            this.splitContainerAdv1.Panel2.Controls.Add(this.textBox5);
            this.splitContainerAdv1.Panel2.Controls.Add(this.textBox4);
            this.splitContainerAdv1.Panel2.Controls.Add(this.comboBoxAdv2);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label4);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label6);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(833, 568);
            this.splitContainerAdv1.SplitterDistance = 229;
            this.splitContainerAdv1.TabIndex = 36;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // autoComplete2
            // 
            this.autoComplete2.AdjustHeightToItemCount = false;
            this.autoComplete2.Columns.Add(this.autoCompleteDataColumnInfo1);
            this.autoComplete2.Columns.Add(this.autoCompleteDataColumnInfo2);
            this.autoComplete2.Columns.Add(this.autoCompleteDataColumnInfo3);
            this.autoComplete2.ImageList = this.imageList3;
            this.autoComplete2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete2.ParentForm = this;
            this.autoComplete2.ShowColumnHeader = true;
            this.autoComplete2.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoComplete2.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemSelected);
            this.autoComplete2.AutoCompleteItemBrowsed += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemBrowsed);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 588);
            this.Controls.Add(this.splitContainerAdv1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(865, 620);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autocomplete Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.PerformLayout();
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete2)).EndInit();
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

		private void comboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetAutoCompleteMode(this.comboBoxAdv1.Text);
			AddLog("AutoCompleteMode set to "+this.comboBoxAdv1.Text);
		}
        private AutoCompleteDemo.Websites websites1;
		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.websites1 = new AutoCompleteDemo.Websites();
            // 
            // websites1
            // 
            this.websites1.DataSetName = "Websites";
            this.websites1.EnforceConstraints = false;
            this.websites1.Locale = new System.Globalization.CultureInfo("en-US");
            this.autoComplete2.DataSource = this.websites1.Website;
			this.comboBoxAdv1.SelectedIndex = 3;
            this.comboBoxAdv2.SelectedIndex = 1;

            string filename = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\websites.xml";
            this.websites1.ReadXml(filename);

            if (this.autoComplete2.TableData.Rows.Count <= 0)
                this.autoComplete2.SetTableData();
            else
                this.autoComplete2.DataSource = null;
            
		}

       

		private void SetAutoCompleteMode(string mode)
		{
			if(mode !="")
			{
				switch(mode)
				{
					case "Disabled":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
						break;
					case "AutoSuggest":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
						break;
					case "AutoAppend":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoAppend);
						break;
					case "Both":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both);
						break;                 

				}
			}
		}


		private void AddLog(string message)
		{
			this.textBox5.Text += message +"\r\n";
		}

		private void autoComplete_AutoCompleteItemBrowsed(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
		{
			string itemText = args.ItemArray[0].ToString();
			string eventlogmessage = String.Format("Event: {0} Item: {1}", "AutoCompleteItemBrowsed", itemText);
			AddLog(eventlogmessage);
		}

		private void autoComplete_AutoCompleteItemSelected(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
		{
			string itemText = args.ItemArray[0].ToString();
			string eventlogmessage = String.Format("Event: {0} Item: {1}", "AutoCompleteItemSelected", itemText);
			AddLog(eventlogmessage);
		}

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv2.Text)
            {
                case "MultiSuggest":
                    this.autoComplete2.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggest);
                    
                    break;
                case "MultiSuggestExtended":
                    this.autoComplete2.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
                    break;
            }
            AddLog("AutoCompleteMode set to " + this.comboBoxAdv2.Text);      
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autoComplete1.MaxNumberofSuggestion = this.autoComplete2.MaxNumberofSuggestion = Convert.ToInt16(textBox6.Text);
            }
            catch (Exception) { }
        }
      



	}
}
