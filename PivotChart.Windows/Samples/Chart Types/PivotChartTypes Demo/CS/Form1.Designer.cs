#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using System.Drawing;
namespace PivotChartTypes_Demo
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
            this.EntirePanel = new System.Windows.Forms.Panel();
            this.ChartArea = new System.Windows.Forms.Panel();
            this.pivotChart1 = new Syncfusion.Windows.Forms.PivotChart.PivotChart();
            this.OtherArea = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StepArea = new System.Windows.Forms.RadioButton();
            this.StepLine = new System.Windows.Forms.RadioButton();
            this.StackingColumn100 = new System.Windows.Forms.RadioButton();
            this.StackingArea100 = new System.Windows.Forms.RadioButton();
            this.StackingColumn = new System.Windows.Forms.RadioButton();
            this.StackingArea = new System.Windows.Forms.RadioButton();
            this.SplineArea = new System.Windows.Forms.RadioButton();
            this.Area = new System.Windows.Forms.RadioButton();
            this.Column = new System.Windows.Forms.RadioButton();
            this.Spline = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.ThreeLineBreak = new System.Windows.Forms.RadioButton();
            this.EntirePanel.SuspendLayout();
            this.ChartArea.SuspendLayout();
            this.OtherArea.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartArea
            // 
            this.ChartArea.Controls.Add(this.pivotChart1);
            this.ChartArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartArea.Location = new System.Drawing.Point(0, 0);
            this.ChartArea.Name = "ChartArea";
            this.ChartArea.Size = new System.Drawing.Size(674, 648);
            this.ChartArea.TabIndex = 1;
            // 
            // pivotChart1
            // 
            this.pivotChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotChart1.Location = new System.Drawing.Point(0, 0);
            this.pivotChart1.MinimumSize = new System.Drawing.Size(300, 250);
            this.pivotChart1.Name = "pivotChart1";
            this.pivotChart1.Size = new System.Drawing.Size(674, 648);
            this.pivotChart1.TabIndex = 0;
            this.pivotChart1.Text = "pivotChart1";
            // 
            // OtherArea
            // 
            this.OtherArea.Controls.Add(this.groupBox1);
            this.OtherArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.OtherArea.Location = new System.Drawing.Point(674, 0);
            this.OtherArea.Name = "OtherArea";
            this.OtherArea.Size = new System.Drawing.Size(267, 648);
            this.OtherArea.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StepArea);
            this.groupBox1.Controls.Add(this.StepLine);
            this.groupBox1.Controls.Add(this.StackingColumn100);
            this.groupBox1.Controls.Add(this.StackingArea100);
            this.groupBox1.Controls.Add(this.StackingColumn);
            this.groupBox1.Controls.Add(this.StackingArea);
            this.groupBox1.Controls.Add(this.SplineArea);
            this.groupBox1.Controls.Add(this.Area);
            this.groupBox1.Controls.Add(this.Column);
            this.groupBox1.Controls.Add(this.Spline);
            this.groupBox1.Controls.Add(this.Line);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 648);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PivotChart Types";
            // 
            // StepArea
            // 
            this.StepArea.AutoSize = true;
            this.StepArea.Location = new System.Drawing.Point(30, 400);
            this.StepArea.Name = "StepArea";
            this.StepArea.Size = new System.Drawing.Size(98, 27);
            this.StepArea.TabIndex = 8;
            this.StepArea.TabStop = true;
            this.StepArea.Text = "StepArea";
            this.StepArea.UseVisualStyleBackColor = true;
            this.StepArea.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // StepLine
            // 
            this.StepLine.AutoSize = true;
            this.StepLine.Location = new System.Drawing.Point(30, 300);
            this.StepLine.Name = "StepLine";
            this.StepLine.Size = new System.Drawing.Size(93, 27);
            this.StepLine.TabIndex = 6;
            this.StepLine.TabStop = true;
            this.StepLine.Text = "StepLine";
            this.StepLine.UseVisualStyleBackColor = true;
            this.StepLine.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // StackingColumn100
            // 
            this.StackingColumn100.AutoSize = true;
            this.StackingColumn100.Location = new System.Drawing.Point(30, 150);
            this.StackingColumn100.Name = "StackingColumn100";
            this.StackingColumn100.Size = new System.Drawing.Size(181, 27);
            this.StackingColumn100.TabIndex = 3;
            this.StackingColumn100.TabStop = true;
            this.StackingColumn100.Text = "StackingColumn100";
            this.StackingColumn100.UseVisualStyleBackColor = true;
            this.StackingColumn100.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // StackingArea100
            // 
            this.StackingArea100.AutoSize = true;
            this.StackingArea100.Location = new System.Drawing.Point(30, 550);
            this.StackingArea100.Name = "StackingArea100";
            this.StackingArea100.Size = new System.Drawing.Size(158, 27);
            this.StackingArea100.TabIndex = 11;
            this.StackingArea100.TabStop = true;
            this.StackingArea100.Text = "StackingArea100";
            this.StackingArea100.UseVisualStyleBackColor = true;
            this.StackingArea100.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // StackingColumn
            // 
            this.StackingColumn.AutoSize = true;
            this.StackingColumn.Location = new System.Drawing.Point(30, 100);
            this.StackingColumn.Name = "StackingColumn";
            this.StackingColumn.Size = new System.Drawing.Size(151, 27);
            this.StackingColumn.TabIndex = 2;
            this.StackingColumn.TabStop = true;
            this.StackingColumn.Text = "StackingColumn";
            this.StackingColumn.UseVisualStyleBackColor = true;
            this.StackingColumn.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // StackingArea
            // 
            this.StackingArea.AutoSize = true;
            this.StackingArea.Location = new System.Drawing.Point(30, 500);
            this.StackingArea.Name = "StackingArea";
            this.StackingArea.Size = new System.Drawing.Size(128, 27);
            this.StackingArea.TabIndex = 10;
            this.StackingArea.TabStop = true;
            this.StackingArea.Text = "StackingArea";
            this.StackingArea.UseVisualStyleBackColor = true;
            this.StackingArea.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // SplineArea
            // 
            this.SplineArea.AutoSize = true;
            this.SplineArea.Location = new System.Drawing.Point(30, 450);
            this.SplineArea.Name = "SplineArea";
            this.SplineArea.Size = new System.Drawing.Size(110, 27);
            this.SplineArea.TabIndex = 9;
            this.SplineArea.TabStop = true;
            this.SplineArea.Text = "SplineArea";
            this.SplineArea.UseVisualStyleBackColor = true;
            this.SplineArea.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(30, 350);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(64, 27);
            this.Area.TabIndex = 7;
            this.Area.TabStop = true;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // Column
            // 
            this.Column.AutoSize = true;
            this.Column.Location = new System.Drawing.Point(30, 50);
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(87, 27);
            this.Column.TabIndex = 1;
            this.Column.TabStop = true;
            this.Column.Text = "Column";
            this.Column.UseVisualStyleBackColor = true;
            this.Column.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // Spline
            // 
            this.Spline.AutoSize = true;
            this.Spline.Location = new System.Drawing.Point(30, 250);
            this.Spline.Name = "Spline";
            this.Spline.Size = new System.Drawing.Size(74, 27);
            this.Spline.TabIndex = 5;
            this.Spline.TabStop = true;
            this.Spline.Text = "Spline";
            this.Spline.UseVisualStyleBackColor = true;
            this.Spline.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(30, 200);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(59, 27);
            this.Line.TabIndex = 4;
            this.Line.TabStop = true;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // ThreeLineBreak
            // 
            this.ThreeLineBreak.AutoSize = true;
            this.ThreeLineBreak.Location = new System.Drawing.Point(30, 586);
            this.ThreeLineBreak.Name = "ThreeLineBreak";
            this.ThreeLineBreak.Size = new System.Drawing.Size(147, 27);
            this.ThreeLineBreak.TabIndex = 11;
            this.ThreeLineBreak.TabStop = true;
            this.ThreeLineBreak.Text = "ThreeLineBreak";
            this.ThreeLineBreak.UseVisualStyleBackColor = true;
            this.ThreeLineBreak.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // EntirePanel
            // 
            this.EntirePanel.Controls.Add(this.ChartArea);
            this.EntirePanel.Controls.Add(this.OtherArea);
            this.EntirePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntirePanel.Location = new System.Drawing.Point(0, 0);
            this.EntirePanel.Name = "EntirePanel";
            this.EntirePanel.Size = new System.Drawing.Size(941, 648);
            this.EntirePanel.TabIndex = 0;
            // 
            // Form1
            // 
           
            this.MinimumSize = new Size(1140, 600);
            this.Text = "PivotChart Types";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 660);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.EntirePanel);
            this.CaptionBarHeight += 20;
            this.CaptionForeColor = Color.White;
            this.CaptionButtonColor = Color.White;
            this.CaptionButtonHoverColor = Color.LightGray;
            this.CaptionFont = new Font("Segoe UI", 14f, FontStyle.Bold);
            this.CaptionBarColor = Color.FromArgb(17, 150, 205);
            this.Name = "Form1";
            this.EntirePanel.ResumeLayout(false);
            this.ChartArea.ResumeLayout(false);
            this.OtherArea.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EntirePanel;
        private System.Windows.Forms.Panel ChartArea;
        private System.Windows.Forms.Panel OtherArea;
        private GroupBox groupBox1;
        private RadioButton ThreeLineBreak;
        private RadioButton StepArea;
        private RadioButton StepLine;
        private RadioButton StackingColumn100;
        private RadioButton StackingArea100;
        private RadioButton StackingColumn;
        private RadioButton StackingArea;
        private RadioButton SplineArea;
        private RadioButton Area;
        private RadioButton Column;
        private RadioButton Spline;
        private RadioButton Line;
    }
}

