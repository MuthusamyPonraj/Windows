#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Drawing;
namespace PivotChart_Demo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pivotChart1 = new Syncfusion.Windows.Forms.PivotChart.PivotChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OtherArea = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.EntirePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.OtherArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntirePanel
            // 
            this.EntirePanel.Controls.Add(this.panel2);
            this.EntirePanel.Controls.Add(this.panel1);
            this.EntirePanel.Controls.Add(this.OtherArea);
            this.EntirePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntirePanel.Location = new System.Drawing.Point(0, 0);
            this.EntirePanel.Name = "EntirePanel";
            this.EntirePanel.Size = new System.Drawing.Size(956, 492);
            this.EntirePanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pivotChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 434);
            this.panel2.TabIndex = 3;
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
            this.pivotChart1.Size = new System.Drawing.Size(743, 434);
            this.pivotChart1.TabIndex = 0;
            this.pivotChart1.Text = "pivotChart1";
            this.pivotChart1.ZoomCancel = System.Windows.Forms.Keys.Escape;
            this.pivotChart1.ZoomIn = System.Windows.Forms.Keys.Add;
            this.pivotChart1.ZoomLeft = System.Windows.Forms.Keys.Left;
            this.pivotChart1.ZoomOut = System.Windows.Forms.Keys.Subtract;
            this.pivotChart1.ZoomRight = System.Windows.Forms.Keys.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(743, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 434);
            this.panel1.TabIndex = 2;
            // 
            // OtherArea
            // 
            this.OtherArea.Controls.Add(this.label2);
            this.OtherArea.Controls.Add(this.label1);
            this.OtherArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.OtherArea.Location = new System.Drawing.Point(0, 0);
            this.OtherArea.Name = "OtherArea";
            this.OtherArea.Size = new System.Drawing.Size(956, 58);
            this.OtherArea.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PivotChart";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 47);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 280);
            this.label4.TabIndex = 1;
            this.label4.Text = "The PivotChart control will allow users to visualize aggregated relational data w" +
                "ith chart labels.\n\n" +
            "This demo demostrates the data raise and fall in Bike sale in different countries and their states between FY2008 to FY2012.";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(11, 385);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show BackGroundImage";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.EntirePanel);
            this.Name = "Form1";
            this.MinimumSize = new Size(1050, 600);
            this.Text = "PivotChart";
            this.EntirePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OtherArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EntirePanel;
        private System.Windows.Forms.Panel OtherArea;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
    }
}

