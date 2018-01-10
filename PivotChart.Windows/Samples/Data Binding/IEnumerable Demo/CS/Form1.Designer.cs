#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using System.Drawing;
namespace IEnumerable_Demo
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
            this.pivotChart1 = new Syncfusion.Windows.Forms.PivotChart.PivotChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EntirePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntirePanel
            // 
            this.EntirePanel.Controls.Add(this.panel2);
            this.EntirePanel.Controls.Add(this.panel1);
            this.EntirePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntirePanel.Location = new System.Drawing.Point(0, 0);
            this.EntirePanel.Name = "EntirePanel";
            this.EntirePanel.Size = new System.Drawing.Size(1136, 514);
            this.EntirePanel.TabIndex = 0;
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
            this.pivotChart1.Size = new System.Drawing.Size(929, 473);
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
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(929, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 514);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 514);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 41);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pivotChart1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(929, 473);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(392, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "IEnumerable";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 78);
            this.label3.TabIndex = 2;
            this.label3.Text = "This demo illustrates the data binding using IEnumerable.";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Property";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 163);
            this.label5.TabIndex = 4;
            this.label5.Text = "PivotChart.ItemSource property is used to get the IEnumerable list.\r\nIn this samp" +
                "le DataCollection class consist of the IEnumerable list.";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(3, 169);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 277);
            this.panel5.TabIndex = 5;
            // 
            // Form1
            // 
            this.MinimumSize = new Size(1100, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.EntirePanel);
            this.Name = "Form1";
            this.Text = "IEnumerable";
            this.CaptionForeColor = Color.White;
            this.EntirePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EntirePanel;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel5;
        private Label label4;
        private Label label5;
        private Label label3;
    }
}

