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
namespace Export_Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.OtherArea = new System.Windows.Forms.Panel();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.EntirePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.OtherArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pivotChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 345);
            this.panel2.TabIndex = 3;
            // 
            // pivotChart1
            // 
            this.pivotChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotChart1.Location = new System.Drawing.Point(0, 0);
            this.pivotChart1.MinimumSize = new System.Drawing.Size(300, 250);
            this.pivotChart1.Name = "pivotChart1";
            this.pivotChart1.Size = new System.Drawing.Size(836, 345);
            this.pivotChart1.TabIndex = 0;
            this.pivotChart1.Text = "pivotChart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 53);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PivotChart Export Demo";
            // 
            // OtherArea
            // 
            this.OtherArea.Controls.Add(this.button1);
            this.OtherArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OtherArea.Location = new System.Drawing.Point(0, 398);
            this.OtherArea.Name = "OtherArea";
            this.OtherArea.Size = new System.Drawing.Size(836, 49);
            this.OtherArea.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BeforeTouchSize = new System.Drawing.Size(108, 27);
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(707, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export to Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 41);
            this.label2.TabIndex = 1;
            // 
            // EntirePanel
            // 
            this.EntirePanel.Controls.Add(this.panel2);
            this.EntirePanel.Controls.Add(this.panel1);
            this.EntirePanel.Controls.Add(this.OtherArea);
            this.EntirePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntirePanel.Location = new System.Drawing.Point(0, 0);
            this.EntirePanel.Name = "EntirePanel";
            this.EntirePanel.Size = new System.Drawing.Size(836, 447);
            this.EntirePanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.button1.BorderStyleAdv = ButtonAdvBorderStyle.Dotted;
            this.BorderColor = Color.FromArgb(39, 170, 225);
            this.BorderThickness = 3;
            this.button1.UseVisualStyle = true;
            this.button1.Appearance = ButtonAppearance.Metro;
            this.button1.MetroColor = Color.FromArgb(39, 170, 225);
            this.MinimumSize = new Size(800, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.EntirePanel);
            this.Name = "Form1";
            this.Text = "PivotChart Export";
            this.EntirePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.OtherArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EntirePanel;
        private System.Windows.Forms.Panel OtherArea;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private ButtonAdv button1;
        private Label label2;
    }
}

