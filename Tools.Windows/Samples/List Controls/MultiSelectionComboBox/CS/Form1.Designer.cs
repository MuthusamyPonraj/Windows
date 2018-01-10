#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
using Syncfusion.Windows.Forms.Tools;
namespace MultiSelectionComboBoxDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
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
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxAdv5 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.comboBoxAdv4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAdv3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.groupBar2 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MultiSelectionComboBox1 = new Syncfusion.Windows.Forms.Tools.MultiSelectionComboBox();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar2)).BeginInit();
            this.groupBar2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultiSelectionComboBox1)).BeginInit();
            this.MultiSelectionComboBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(100, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.AnimatedSelection = false;
            this.groupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(569, 632);
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.Controls.Add(this.panel4);
            this.groupBar1.Controls.Add(this.panel5);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.FlatLook = true;
            this.groupBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBar1.ForeColor = System.Drawing.Color.White;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItemHeight = 40;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 0;
            this.groupBar1.Size = new System.Drawing.Size(416, 632);
            this.groupBar1.TabIndex = 4;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.comboBoxAdv5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboBoxAdv1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.colorPickerButton3);
            this.panel4.Controls.Add(this.colorPickerButton2);
            this.panel4.Controls.Add(this.colorPickerButton1);
            this.panel4.Controls.Add(this.comboBoxAdv4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBoxAdv3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboBoxAdv2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 592);
            this.panel4.TabIndex = 3;
            // 
            // comboBoxAdv5
            // 
            this.comboBoxAdv5.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv5.BeforeTouchSize = new System.Drawing.Size(178, 25);
            this.comboBoxAdv5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxAdv5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.comboBoxAdv5.Items.AddRange(new object[] {
            "Visual Item",
            "Delimiter Mode",
            "Normal Mode"});
            this.comboBoxAdv5.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv5, "VisualMode"));
            this.comboBoxAdv5.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv5, "DelimiterMode"));
            this.comboBoxAdv5.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv5, "NormalMode"));
            this.comboBoxAdv5.Location = new System.Drawing.Point(183, 176);
            this.comboBoxAdv5.Name = "comboBoxAdv5";
            this.comboBoxAdv5.Size = new System.Drawing.Size(178, 25);
            this.comboBoxAdv5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv5.TabIndex = 15;
            this.comboBoxAdv5.Text = "Visual Item";
            this.comboBoxAdv5.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv5_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(39, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Display Mode";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(177, 25);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "True"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "False"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(182, 305);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(177, 25);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 13;
            this.comboBoxAdv1.Text = "True";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(38, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Show Groups";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(38, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 38);
            this.label6.TabIndex = 11;
            this.label6.Text = "GroupHeader\r\nSeparatorColor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(38, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "GroupHeader\r\nForeColor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(38, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "GroupHeader\r\nBackColor";
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.colorPickerButton3.BeforeTouchSize = new System.Drawing.Size(178, 29);
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colorPickerButton3.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton3.IsBackStageButton = false;
            this.colorPickerButton3.Location = new System.Drawing.Point(182, 513);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.Size = new System.Drawing.Size(178, 29);
            this.colorPickerButton3.TabIndex = 8;
            this.colorPickerButton3.UseVisualStyle = false;
            this.colorPickerButton3.ColorSelected += new System.EventHandler(this.colorPickerButton3_ColorSelected);
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.colorPickerButton2.BeforeTouchSize = new System.Drawing.Size(178, 29);
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colorPickerButton2.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton2.IsBackStageButton = false;
            this.colorPickerButton2.Location = new System.Drawing.Point(182, 443);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.Size = new System.Drawing.Size(178, 29);
            this.colorPickerButton2.TabIndex = 7;
            this.colorPickerButton2.UseVisualStyle = false;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton1.BackColor = System.Drawing.Color.DimGray;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(178, 29);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colorPickerButton1.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(182, 373);
            this.colorPickerButton1.MetroColor = System.Drawing.Color.DarkGray;
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.DarkGray;
            this.colorPickerButton1.Size = new System.Drawing.Size(178, 29);
            this.colorPickerButton1.TabIndex = 6;
            this.colorPickerButton1.UseVisualStyle = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // comboBoxAdv4
            // 
            this.comboBoxAdv4.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv4.BeforeTouchSize = new System.Drawing.Size(177, 25);
            this.comboBoxAdv4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxAdv4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.comboBoxAdv4.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxAdv4.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv4, "True"));
            this.comboBoxAdv4.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv4, "False"));
            this.comboBoxAdv4.Location = new System.Drawing.Point(183, 243);
            this.comboBoxAdv4.Name = "comboBoxAdv4";
            this.comboBoxAdv4.Size = new System.Drawing.Size(177, 25);
            this.comboBoxAdv4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv4.TabIndex = 5;
            this.comboBoxAdv4.Text = "True";
            this.comboBoxAdv4.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv4_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(39, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Show CheckBox";
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv3.BeforeTouchSize = new System.Drawing.Size(178, 25);
            this.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.comboBoxAdv3.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal",
            "None"});
            this.comboBoxAdv3.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv3, "Vertical"));
            this.comboBoxAdv3.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv3, "Horizontal"));
            this.comboBoxAdv3.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv3, "ScrollBar"));
            this.comboBoxAdv3.Location = new System.Drawing.Point(182, 43);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Size = new System.Drawing.Size(178, 25);
            this.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv3.TabIndex = 3;
            this.comboBoxAdv3.Text = "Vertical";
            this.comboBoxAdv3.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(38, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "AutoSize Mode";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(178, 25);
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "Begin",
            "Match",
            "Disabled"});
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Begin"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Match"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Disabled"));
            this.comboBoxAdv2.Location = new System.Drawing.Point(183, 103);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(178, 25);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 1;
            this.comboBoxAdv2.Text = "Begin";
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(39, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Suggest\r\nMode";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 209);
            this.panel5.TabIndex = 2;
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem1.Client = this.panel4;
            this.groupBarItem1.Text = "Properties";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBar2);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.groupBar1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(996, 634);
            this.splitContainerAdv1.SplitterDistance = 571;
            this.splitContainerAdv1.TabIndex = 5;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // groupBar2
            // 
            this.groupBar2.AllowDrop = true;
            this.groupBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBar2.BeforeTouchSize = new System.Drawing.Size(569, 632);
            this.groupBar2.BorderColor = System.Drawing.Color.White;
            this.groupBar2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar2.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar2.CollapseImage")));
            this.groupBar2.Controls.Add(this.panel2);
            this.groupBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar2.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar2.ExpandImage")));
            this.groupBar2.FlatLook = true;
            this.groupBar2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBar2.ForeColor = System.Drawing.Color.White;
            this.groupBar2.GroupBarItemHeight = 40;
            this.groupBar2.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem2});
            this.groupBar2.IndexOnVisibleItems = true;
            this.groupBar2.Location = new System.Drawing.Point(0, 0);
            this.groupBar2.Name = "groupBar2";
            this.groupBar2.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar2.SelectedItem = 0;
            this.groupBar2.Size = new System.Drawing.Size(569, 632);
            this.groupBar2.TabIndex = 0;
            this.groupBar2.Text = "groupBar2";
            this.groupBar2.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.groupBar2.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.MultiSelectionComboBox1);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 592);
            this.panel2.TabIndex = 0;
            // 
            // MultiSelectionComboBox1
            // 
            this.MultiSelectionComboBox1.BeforeTouchSize = new System.Drawing.Size(234, 28);
            this.MultiSelectionComboBox1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.MultiSelectionComboBox1.Controls.Add(this.textBoxExt2);
            this.MultiSelectionComboBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiSelectionComboBox1.Location = new System.Drawing.Point(184, 250);
            this.MultiSelectionComboBox1.MetroColor = System.Drawing.Color.Gray;
            this.MultiSelectionComboBox1.Name = "MultiSelectionComboBox1";
            this.MultiSelectionComboBox1.ShowCheckBox = true;
            this.MultiSelectionComboBox1.Size = new System.Drawing.Size(234, 28);
            this.MultiSelectionComboBox1.TabIndex = 0;
            this.MultiSelectionComboBox1.UseVisualStyle = true;
            this.MultiSelectionComboBox1.VisualItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(97, 20);
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt2.Location = new System.Drawing.Point(3, 4);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Size = new System.Drawing.Size(97, 20);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt2.TabIndex = 0;
            this.textBoxExt2.Text = "autoCompleteEdit2";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem2.Client = this.panel2;
            this.groupBarItem2.Text = "MultiSelectionComboBox Demo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 497);
            this.panel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarHeight = 10;
            this.CaptionForeColor = System.Drawing.Color.White;
            captionImage1.BackColor = System.Drawing.Color.White;
            captionImage1.Location = new System.Drawing.Point(0, 0);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(36, 36);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(996, 634);
            this.Controls.Add(this.splitContainerAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiSelectionComboBox";
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar2)).EndInit();
            this.groupBar2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MultiSelectionComboBox1)).EndInit();
            this.MultiSelectionComboBox1.ResumeLayout(false);
            this.MultiSelectionComboBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MultiSelectionComboBox MultiSelectionComboBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private System.Windows.Forms.Panel panel5;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar2;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv3;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton3;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.Label label7;
        private ComboBoxAdv comboBoxAdv5;
        private System.Windows.Forms.Label label8;
    }
}