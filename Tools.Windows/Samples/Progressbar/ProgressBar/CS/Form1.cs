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
using Syncfusion.Windows.Forms;

namespace ProgressBarAdvProperties
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt1;
        private System.ComponentModel.IContainer components;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv4;
        private Label label5;
        bool Start;
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
            //this.comboBoxAdv1.DataSource = Enum.GetValues(typeof (Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles)); 
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAdv4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxAdv2);
            this.groupBox2.Controls.Add(this.colorPickerButton1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDownExt1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxAdv1);
            this.groupBox2.Controls.Add(this.checkBoxAdv1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxAdv4);
            this.groupBox2.Controls.Add(this.checkBoxAdv3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(334, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 395);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Properties";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv2.DrawFocusRectangle = false;
            this.checkBoxAdv2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.Location = new System.Drawing.Point(136, 144);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.DarkGray;
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(52, 17);
            this.checkBoxAdv2.StretchImage = false;
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 10;
            this.checkBoxAdv2.Text = "Yes";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton1.BackColor = System.Drawing.Color.Silver;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(152, 23);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(136, 104);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.Size = new System.Drawing.Size(152, 23);
            this.colorPickerButton1.TabIndex = 9;
            this.colorPickerButton1.Text = "Pick the text color";
            this.colorPickerButton1.UseVisualStyle = true;
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Segment Width";
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt1.BeforeTouchSize = new System.Drawing.Size(152, 20);
            this.numericUpDownExt1.BorderColor = System.Drawing.Color.DarkGray;
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.Enabled = false;
            this.numericUpDownExt1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownExt1.Location = new System.Drawing.Point(136, 248);
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.DarkGray;
            this.numericUpDownExt1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownExt1.TabIndex = 0;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Font Color";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(152, 22);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Percentage",
            "Value"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(136, 64);
            this.comboBoxAdv1.MetroColor = System.Drawing.Color.DarkGray;
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(152, 22);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 6;
            this.comboBoxAdv1.Text = "Percentage";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(136, 24);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.DarkGray;
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(52, 17);
            this.checkBoxAdv1.StretchImage = false;
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 5;
            this.checkBoxAdv1.Text = "Yes";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text Shadow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Visible";
            // 
            // checkBoxAdv4
            // 
            this.checkBoxAdv4.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv4.DrawFocusRectangle = false;
            this.checkBoxAdv4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv4.Location = new System.Drawing.Point(136, 180);
            this.checkBoxAdv4.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv4.Name = "checkBoxAdv4";
            this.checkBoxAdv4.Size = new System.Drawing.Size(52, 17);
            this.checkBoxAdv4.StretchImage = false;
            this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv4.TabIndex = 12;
            this.checkBoxAdv4.Text = "Yes";
            this.checkBoxAdv4.ThemesEnabled = false;
            this.checkBoxAdv4.CheckStateChanged += new System.EventHandler(this.checkBoxForeSeg_CheckStateChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv3.DrawFocusRectangle = false;
            this.checkBoxAdv3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv3.Location = new System.Drawing.Point(136, 217);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(52, 17);
            this.checkBoxAdv3.StretchImage = false;
            this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv3.TabIndex = 12;
            this.checkBoxAdv3.Text = "Yes";
            this.checkBoxAdv3.ThemesEnabled = false;
            this.checkBoxAdv3.CheckStateChanged += new System.EventHandler(this.checkBoxAdv3_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fore Segments";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Back Segments";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.progressBarAdv1);
            this.groupBox5.Controls.Add(this.buttonAdv1);
            this.groupBox5.Controls.Add(this.buttonAdv2);
            this.groupBox5.Location = new System.Drawing.Point(10, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 307);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Demo";
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackGradientStartColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackgroundFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.White;
            this.progressBarAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(101)))), ((int)(((byte)(91)))));
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv1.CustomText = null;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.FontColor = System.Drawing.Color.Black;
            this.progressBarAdv1.ForeColor = System.Drawing.Color.White;
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.ForeSegments = false;
            this.progressBarAdv1.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv1.GradientStartColor = System.Drawing.Color.RosyBrown;
            this.progressBarAdv1.Location = new System.Drawing.Point(29, 90);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Blue,
        System.Drawing.Color.Magenta};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.progressBarAdv1.SegmentWidth = 2;
            this.progressBarAdv1.Size = new System.Drawing.Size(248, 24);
            this.progressBarAdv1.TabIndex = 0;
            this.progressBarAdv1.Text = "progressBarAdv1";
            this.progressBarAdv1.TextShadow = false;
            this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.progressBarAdv1.ThemesEnabled = true;
            this.progressBarAdv1.TubeEndColor = System.Drawing.Color.RosyBrown;
            this.progressBarAdv1.TubeStartColor = System.Drawing.Color.Lime;
            this.progressBarAdv1.Value = 100;
            this.progressBarAdv1.WaitingGradientInterval = 1;
            this.progressBarAdv1.WaitingGradientWidth = 9000;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(64, 160);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.buttonAdv1.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv1.TabIndex = 1;
            this.buttonAdv1.Text = "START";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.Silver;
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(160, 160);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.buttonAdv2.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv2.TabIndex = 2;
            this.buttonAdv2.Text = "STOP";
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(656, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar Features";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
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

        void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxAdv1.SelectedIndex = 1;
            checkBoxAdv1.Checked = true;
            checkBoxAdv2.Checked = false;
			this.numericUpDownExt1.Value = 4;
        }

        #region Start
        private void buttonAdv2_Click(object sender, System.EventArgs e)
        {
            Start = false;
        }

        private void buttonAdv1_Click(object sender, System.EventArgs e)
        {
            Start = true;
        }
        #endregion

        #region BackSegments
        private void checkBoxAdv3_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.progressBarAdv1.BackSegments = this.checkBoxAdv3.Checked;
        }
        #endregion

        #region TextShadow
        private void checkBoxAdv2_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.progressBarAdv1.TextShadow = this.checkBoxAdv2.Checked;
        }
        #endregion

        #region TextVisible
        private void checkBoxAdv1_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.progressBarAdv1.TextVisible = this.checkBoxAdv1.Checked;
        }
        #endregion

        #region SegmentWidth
        private void numericUpDownExt1_ValueChanged(object sender, System.EventArgs e)
        {
            this.progressBarAdv1.SegmentWidth = Convert.ToInt32(this.numericUpDownExt1.Value);
        }
        #endregion
        #region TextStyle
        private void comboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == 0)
            {
                this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Percentage;
            }
            if (this.comboBoxAdv1.SelectedIndex == 1)
            {
                this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            }
        }
        #endregion

        #region FontColor
        private void colorPickerButton1_ColorSelected(object sender, System.EventArgs e)
        {
            this.progressBarAdv1.FontColor = this.colorPickerButton1.ColorUI.SelectedColor;
        }
        #endregion

        #region timer
        private void timer2_Tick(object sender, System.EventArgs e)
        {
            
            if (Start)
            {
                Random r = new Random();
                int no= r.Next(0, 5);

                if (this.progressBarAdv1.Value < 100)
                    this.progressBarAdv1.Value++;
                else
                {
                    this.progressBarAdv1.Value = 0;
                    switch (no)
                    {
                        case 2:
                            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
                            break;
                        case 3:
                            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
                            break;
                        case 4:
                            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.MultipleGradient;
                            break;
                        case 5:
                            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System;
                            break;
                        case 1:
                            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
                            break;
                        case 0:
                            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
                            this.progressBarAdv1.WaitingGradientEnabled = true;
                            break;
                    }
                }
            }
        }
        #endregion

        private void checkBoxForeSeg_CheckStateChanged(object sender, EventArgs e)
        {
            this.progressBarAdv1.ForeSegments = checkBoxAdv4.Checked;
            this.numericUpDownExt1.Enabled = checkBoxAdv4.Checked;
        }


    }
}
