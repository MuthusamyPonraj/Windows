#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace GDBGFieldChooserDemo
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
            this.GridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid ();
            ((System.ComponentModel.ISupportInitialize)(this.GridDataBoundGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.GridDataBoundGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.GridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.GridDataBoundGrid1.Name = "GridDataBoundGrid1";
            this.GridDataBoundGrid1.Size = new System.Drawing.Size(659, 439);
            this.GridDataBoundGrid1.TabIndex = 0;
            this.GridDataBoundGrid1.Text = "GridDataBoundGrid1";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 439);
            this.Controls.Add(this.GridDataBoundGrid1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDBG FieldChooser Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDataBoundGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid GridDataBoundGrid1;
    }
}

