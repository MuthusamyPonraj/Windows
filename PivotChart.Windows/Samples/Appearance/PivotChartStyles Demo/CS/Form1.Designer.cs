#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
namespace PivotChartStyles_Demo
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
            this.EntirePanel = new System.Windows.Forms.Panel();
            this.ChartArea = new System.Windows.Forms.Panel();
            this.pivotChart1 = new Syncfusion.Windows.Forms.PivotChart.PivotChart();
            this.OtherArea = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new ComboBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox5 = new ComboBoxAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox6 = new ComboBoxAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EntirePanel.SuspendLayout();
            this.ChartArea.SuspendLayout();
            this.OtherArea.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // ChartArea
            // 
            this.ChartArea.Controls.Add(this.pivotChart1);
            this.ChartArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartArea.Location = new System.Drawing.Point(0, 0);
            this.ChartArea.Name = "ChartArea";
            this.ChartArea.Size = new System.Drawing.Size(591, 607);
            this.ChartArea.TabIndex = 0;
            // 
            // pivotChart1
            // 
            this.pivotChart1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))))};
            this.pivotChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotChart1.Location = new System.Drawing.Point(0, 0);
            this.pivotChart1.MinimumSize = new System.Drawing.Size(300, 250);
            this.pivotChart1.Name = "pivotChart1";
            this.pivotChart1.Size = new System.Drawing.Size(591, 607);
            this.pivotChart1.TabIndex = 0;
            this.pivotChart1.Text = "pivotChart1";
            this.pivotChart1.ZoomCancel = System.Windows.Forms.Keys.Escape;
            this.pivotChart1.ZoomIn = System.Windows.Forms.Keys.Add;
            this.pivotChart1.ZoomLeft = System.Windows.Forms.Keys.Left;
            this.pivotChart1.ZoomOut = System.Windows.Forms.Keys.Subtract;
            this.pivotChart1.ZoomRight = System.Windows.Forms.Keys.Right;
            // 
            // OtherArea
            // 
            this.OtherArea.Controls.Add(this.groupBox1);
            this.OtherArea.Controls.Add(this.groupBox2);
            this.OtherArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.OtherArea.Location = new System.Drawing.Point(591, 0);
            this.OtherArea.Name = "OtherArea";
            this.OtherArea.Size = new System.Drawing.Size(245, 607);
            this.OtherArea.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PrimaryXAxis";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoComplete = true;
            this.comboBox3.AllowNewText = false;
            this.comboBox3.Location = new System.Drawing.Point(136, 251);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(97, 27);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Interior";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 209);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 23);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Enable/Disable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "2.InterlacedGrid";
            // 
            // comboBox2
            // 

            this.comboBox2.AutoComplete = true;
            this.comboBox2.AllowNewText = false;
            this.comboBox2.Location = new System.Drawing.Point(136, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 27);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "DashStyle";
            // 
            // comboBox1
            // 

            this.comboBox1.AutoComplete = true;
            this.comboBox1.AllowNewText = false;
            this.comboBox1.Location = new System.Drawing.Point(136, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ForeColor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.GridLineType";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PrimaryYAxis";
            // 
            // comboBox4
            // 

            this.comboBox4.AutoComplete = true;
            this.comboBox4.AllowNewText = false;
            this.comboBox4.Location = new System.Drawing.Point(139, 249);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(97, 27);
            this.comboBox4.TabIndex = 17;
            this.comboBox4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox4.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Interior";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(31, 208);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(127, 23);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Enable/Disable";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "2.InterlacedGrid";
            // 
            // comboBox5
            // 

            this.comboBox5.AutoComplete = true;
            this.comboBox5.AllowNewText = false;
            this.comboBox5.Location = new System.Drawing.Point(139, 127);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(97, 27);
            this.comboBox5.TabIndex = 13;
            this.comboBox5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox5.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "DashStyle";
            // 
            // comboBox6
            // 

            this.comboBox6.AutoComplete = true;
            this.comboBox6.AllowNewText = false;
            this.comboBox6.Location = new System.Drawing.Point(139, 74);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(97, 27);
            this.comboBox6.TabIndex = 11;
            this.comboBox6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox6.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "ForeColor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "1.GridLineType";
            // 
            // EntirePanel
            // 
            this.EntirePanel.Controls.Add(this.ChartArea);
            this.EntirePanel.Controls.Add(this.OtherArea);
            this.EntirePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntirePanel.Location = new System.Drawing.Point(0, 0);
            this.EntirePanel.Name = "EntirePanel";
            this.EntirePanel.Size = new System.Drawing.Size(836, 607);
            this.EntirePanel.TabIndex = 0;
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.EntirePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.EntirePanel.ResumeLayout(false);
            this.ChartArea.ResumeLayout(false);
            this.OtherArea.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EntirePanel;
        private System.Windows.Forms.Panel ChartArea;
        private System.Windows.Forms.Panel OtherArea;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBoxAdv comboBox3;
        private Label label5;
        private CheckBox checkBox1;
        private Label label4;
        private ComboBoxAdv comboBox2;
        private Label label3;
        private ComboBoxAdv comboBox1;
        private Label label2;
        private Label label1;
        private ComboBoxAdv comboBox4;
        private Label label6;
        private CheckBox checkBox2;
        private Label label7;
        private ComboBoxAdv comboBox5;
        private Label label8;
        private ComboBoxAdv comboBox6;
        private Label label9;
        private Label label10;
    }
}

