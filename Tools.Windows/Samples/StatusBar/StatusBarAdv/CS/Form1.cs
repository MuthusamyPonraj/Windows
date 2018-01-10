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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace StatusBarAdvDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv3;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel11;
		private TextBoxExt textBox1;
		private ButtonAdv button1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel timePanel;
		private RadioButtonAdv radioButton1;
        private RadioButtonAdv radioButton2;
        private RadioButtonAdv radioButton3;
        private RadioButtonAdv radioButton4;
        private RadioButtonAdv radioButton5;
        private RadioButtonAdv radioButton6;
        private RadioButtonAdv radioButton7;
        private TextBoxExt textBox2;
        private ButtonAdv button2;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel customPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel keyPanel;
        private TabControlAdv tabControlAdv1;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv2;
        private TabPageAdv tabPageAdv3;
        private TabPageAdv tabPageAdv4;
        private GradientPanel gradientPanel1;
        private IContainer components;
        private Label label1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel datePanel;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.MinimumSize = this.Size;
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
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarAdv3 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.customPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdvPanel11 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.timePanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.keyPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.datePanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.radioButton3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton7 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv3)).BeginInit();
            this.statusBarAdv3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // statusBarAdv3
            // 
            this.statusBarAdv3.BeforeTouchSize = new System.Drawing.Size(707, 33);
            this.statusBarAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.statusBarAdv3.BorderColor = System.Drawing.Color.DarkGray;
            this.statusBarAdv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdv3.Controls.Add(this.customPanel);
            this.statusBarAdv3.Controls.Add(this.statusBarAdvPanel11);
            this.statusBarAdv3.Controls.Add(this.timePanel);
            this.statusBarAdv3.Controls.Add(this.keyPanel);
            this.statusBarAdv3.Controls.Add(this.datePanel);
            this.statusBarAdv3.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv3.Location = new System.Drawing.Point(10, 371);
            this.statusBarAdv3.Name = "statusBarAdv3";
            this.statusBarAdv3.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv3.Size = new System.Drawing.Size(707, 33);
            this.statusBarAdv3.SizingGrip = false;
            this.statusBarAdv3.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv3.TabIndex = 2;
            // 
            // customPanel
            // 
            this.customPanel.AnimationDirection = Syncfusion.Windows.Forms.Tools.MarqueeDirection.Right;
            this.customPanel.AnimationStyle = Syncfusion.Windows.Forms.Tools.MarqueeStyle.Slide;
            this.customPanel.BackColor = System.Drawing.Color.DarkGray;
            this.customPanel.BeforeTouchSize = new System.Drawing.Size(148, 27);
            this.customPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.customPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customPanel.IsMarquee = true;
            this.customPanel.Location = new System.Drawing.Point(0, 2);
            this.customPanel.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel.Name = "customPanel";
            this.customPanel.Size = new System.Drawing.Size(148, 27);
            this.customPanel.TabIndex = 4;
            this.customPanel.Text = "Custom Panel";
            // 
            // statusBarAdvPanel11
            // 
            this.statusBarAdvPanel11.BackColor = System.Drawing.Color.DarkGray;
            this.statusBarAdvPanel11.BeforeTouchSize = new System.Drawing.Size(119, 27);
            this.statusBarAdvPanel11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBarAdvPanel11.Location = new System.Drawing.Point(150, 2);
            this.statusBarAdvPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel11.Name = "statusBarAdvPanel11";
            this.statusBarAdvPanel11.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CurrentCulture;
            this.statusBarAdvPanel11.Size = new System.Drawing.Size(119, 27);
            this.statusBarAdvPanel11.TabIndex = 0;
            this.statusBarAdvPanel11.Text = "statusBarAdvPanel11";
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.DarkGray;
            this.timePanel.BeforeTouchSize = new System.Drawing.Size(116, 27);
            this.timePanel.Location = new System.Drawing.Point(271, 2);
            this.timePanel.Margin = new System.Windows.Forms.Padding(0);
            this.timePanel.Name = "timePanel";
            this.timePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortTime;
            this.timePanel.Size = new System.Drawing.Size(116, 27);
            this.timePanel.TabIndex = 3;
            this.timePanel.Text = "statusBarAdvPanel1";
            // 
            // keyPanel
            // 
            this.keyPanel.BackColor = System.Drawing.Color.Transparent;
            this.keyPanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.DarkGray);
            this.keyPanel.BeforeTouchSize = new System.Drawing.Size(159, 27);
            this.keyPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyPanel.Location = new System.Drawing.Point(389, 2);
            this.keyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.keyPanel.Name = "keyPanel";
            this.keyPanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CapsLockState;
            this.keyPanel.Size = new System.Drawing.Size(159, 27);
            this.keyPanel.TabIndex = 2;
            this.keyPanel.Text = "statusBarAdvPanel13";
            // 
            // datePanel
            // 
            this.datePanel.BackColor = System.Drawing.Color.DarkGray;
            this.datePanel.BeforeTouchSize = new System.Drawing.Size(148, 27);
            this.datePanel.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.datePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datePanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify;
            this.datePanel.Location = new System.Drawing.Point(550, 2);
            this.datePanel.Margin = new System.Windows.Forms.Padding(0);
            this.datePanel.Name = "datePanel";
            this.datePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortDate;
            this.datePanel.PreferredSize = new System.Drawing.Size(65, 18);
            this.datePanel.Size = new System.Drawing.Size(148, 27);
            this.datePanel.TabIndex = 1;
            this.datePanel.Text = "statusBarAdvPanel12";
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(56, 27);
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(100, 20);
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(58, 2);
            this.textBox1.Metrocolor = System.Drawing.Color.Empty;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 27);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "textBox";
            // 
            // radioButton3
            // 
            this.radioButton3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton3.DrawFocusRectangle = false;
            this.radioButton3.Location = new System.Drawing.Point(118, 177);
            this.radioButton3.MetroColor = System.Drawing.Color.Gray;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = false;
            this.radioButton3.Text = "Scroll Lock";
            this.radioButton3.ThemesEnabled = false;
            this.radioButton3.CheckChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.Location = new System.Drawing.Point(118, 121);
            this.radioButton2.MetroColor = System.Drawing.Color.Gray;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Num Lock";
            this.radioButton2.ThemesEnabled = false;
            this.radioButton2.CheckChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton1.Checked = true;
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.Location = new System.Drawing.Point(118, 72);
            this.radioButton1.MetroColor = System.Drawing.Color.Gray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Caps Lock";
            this.radioButton1.ThemesEnabled = false;
            this.radioButton1.CheckChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton5.DrawFocusRectangle = false;
            this.radioButton5.Location = new System.Drawing.Point(127, 133);
            this.radioButton5.MetroColor = System.Drawing.Color.Gray;
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(104, 24);
            this.radioButton5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = false;
            this.radioButton5.Text = "Long Date";
            this.radioButton5.ThemesEnabled = false;
            this.radioButton5.CheckChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton4.Checked = true;
            this.radioButton4.DrawFocusRectangle = false;
            this.radioButton4.Location = new System.Drawing.Point(127, 79);
            this.radioButton4.MetroColor = System.Drawing.Color.Gray;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 24);
            this.radioButton4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "Short Date";
            this.radioButton4.ThemesEnabled = false;
            this.radioButton4.CheckChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton6.Checked = true;
            this.radioButton6.DrawFocusRectangle = false;
            this.radioButton6.Location = new System.Drawing.Point(128, 81);
            this.radioButton6.MetroColor = System.Drawing.Color.Gray;
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(104, 24);
            this.radioButton6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "Short Time";
            this.radioButton6.ThemesEnabled = false;
            this.radioButton6.CheckChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton7.DrawFocusRectangle = false;
            this.radioButton7.Location = new System.Drawing.Point(128, 142);
            this.radioButton7.MetroColor = System.Drawing.Color.Gray;
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(104, 24);
            this.radioButton7.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = false;
            this.radioButton7.Text = "Long Time";
            this.radioButton7.ThemesEnabled = false;
            this.radioButton7.CheckChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(147, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Set Text";
            this.button2.UseVisualStyle = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BeforeTouchSize = new System.Drawing.Size(100, 20);
            this.textBox2.BorderColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(135, 75);
            this.textBox2.Metrocolor = System.Drawing.Color.Gray;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Custom Panel";
            this.textBox2.ThemesEnabled = false;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(363, 279);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(363, 279);
            this.tabControlAdv1.TabIndex = 10;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.radioButton3);
            this.tabPageAdv1.Controls.Add(this.radioButton1);
            this.tabPageAdv1.Controls.Add(this.radioButton2);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(360, 255);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "KeyStatePanels";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.radioButton5);
            this.tabPageAdv2.Controls.Add(this.radioButton4);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(360, 255);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "DatePanels";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.radioButton7);
            this.tabPageAdv3.Controls.Add(this.radioButton6);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(360, 255);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "TimePanels";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Controls.Add(this.textBox2);
            this.tabPageAdv4.Controls.Add(this.button2);
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(360, 255);
            this.tabPageAdv4.TabIndex = 4;
            this.tabPageAdv4.Text = "CustomPanels";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.tabControlAdv1);
            this.gradientPanel1.Location = new System.Drawing.Point(183, 84);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(365, 281);
            this.gradientPanel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "The StatusBarAdv is an advanced status bar control that can display status-bar pa" +
    "nels with enhanced backgrounds and appearances.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(727, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.statusBarAdv3);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusBarAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv3)).EndInit();
            this.statusBarAdv3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
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

		}

		#region keyPanel
		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked) this.keyPanel.PanelType = StatusBarAdvPanelType.CapsLockState;
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton2.Checked) this.keyPanel.PanelType = StatusBarAdvPanelType.NumLockState;
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked) this.keyPanel.PanelType = StatusBarAdvPanelType.ScrollLockState;
		}
		#endregion
		#region TimePanel
		private void radioButton6_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton6.Checked) this.timePanel.PanelType = StatusBarAdvPanelType.ShortTime;
		}

		private void radioButton7_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton7.Checked) this.timePanel.PanelType = StatusBarAdvPanelType.LongTime;
		}
		#endregion
		#region DatePanel
		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton4.Checked) this.datePanel.PanelType = StatusBarAdvPanelType.ShortDate;
		}

		private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton5.Checked) this.datePanel.PanelType = StatusBarAdvPanelType.LongDate;
		}
		#endregion
		#region customPanel

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.customPanel.Text = this.textBox2.Text;
		}
		#endregion
	}
}
