#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;

namespace TabSplitterContainer_2005
{
    partial class Main
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
            this.SuspendLayout();
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(700, 529);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IsMdiContainer = true;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VS2008 Style TabSplitter ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosing += Main_FormClosing;
            this.ResumeLayout(false);

        }

        private void Main_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            foreach (Form splitWindow in this.tabbedMDIManager1.MdiChildren)
            {
                if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text == splitWindow.Text)
                {
                    splitWindow.Close();
                }
            }
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDIManager1;

    }
}