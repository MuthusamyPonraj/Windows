#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using System.Drawing;
namespace ZoomingandScrolling_Demo
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pivotChart1 = new Syncfusion.Windows.Forms.PivotChart.PivotChart();
            this.OtherArea = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.EntirePanel.SuspendLayout();
            this.OtherArea.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(18, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(167, 25);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Enable Y-Axis Zoom";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(21, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Enable X-Axis Zoom";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "ZoomFactor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ZoomFactor";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "PrimaryYAxis";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PrimaryXAxis";
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
            this.pivotChart1.Size = new System.Drawing.Size(591, 409);
            this.pivotChart1.TabIndex = 0;
            this.pivotChart1.Text = "pivotChart1";
            // 
            // OtherArea
            // 
            this.OtherArea.Controls.Add(this.comboBox1);
            this.OtherArea.Controls.Add(this.panel1);
            this.OtherArea.Controls.Add(this.label1);
            this.OtherArea.Controls.Add(this.checkBox1);
            this.OtherArea.Controls.Add(this.label3);
            this.OtherArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.OtherArea.Location = new System.Drawing.Point(591, 0);
            this.OtherArea.Name = "OtherArea";
            this.OtherArea.Size = new System.Drawing.Size(245, 447);
            this.OtherArea.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Location = new System.Drawing.Point(3, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 145);
            this.panel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.0",
            "0.9",
            "0.8",
            "0.7",
            "0.5",
            "0.4",
            "0.3",
            "0.2",
            "0.1"});
            this.comboBox1.Location = new System.Drawing.Point(134, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1.0",
            "0.9",
            "0.8",
            "0.7",
            "0.5",
            "0.4",
            "0.3",
            "0.2",
            "0.1"});
            this.comboBox2.Location = new System.Drawing.Point(131, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(85, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 38);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pivotChart1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 409);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Zooming and Scrolling";
            // 
            // EntirePanel
            // 
            this.EntirePanel.Controls.Add(this.panel3);
            this.EntirePanel.Controls.Add(this.panel2);
            this.EntirePanel.Controls.Add(this.OtherArea);
            this.EntirePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntirePanel.Location = new System.Drawing.Point(0, 0);
            this.EntirePanel.Name = "EntirePanel";
            this.EntirePanel.Size = new System.Drawing.Size(836, 447);
            this.EntirePanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.Padding = new Padding(10);
            this.BorderColor = Color.FromArgb(17, 150, 205);
            this.BorderThickness = 2;
            this.CaptionForeColor = Color.White;
            this.MinimumSize = new Size(800, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.EntirePanel);
            this.Name = "Form1";
            this.Text = "Zoom and Scrolling";
            this.EntirePanel.ResumeLayout(false);
            this.OtherArea.ResumeLayout(false);
            this.OtherArea.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EntirePanel;
        private System.Windows.Forms.Panel OtherArea;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Panel panel1;
        private ComboBox comboBox2;
        private Panel panel3;
        private Panel panel2;
        private Label label5;
    }
}

