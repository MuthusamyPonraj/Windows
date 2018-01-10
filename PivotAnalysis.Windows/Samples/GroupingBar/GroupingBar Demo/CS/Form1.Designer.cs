#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace GroupbarDemo
{
    partial class Form1
    {
        #region "API Definitions"

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv2;     

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        #endregion

        #region "Dispose"

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
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pivotGridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 488);
            this.panel1.TabIndex = 0;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.AllowFiltering = true;
            this.pivotGridControl1.AllowSorting = true;
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.DeferLayoutUpdate = false;
            this.pivotGridControl1.EditManager = null;
            this.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.ShowGrandTotals = true;
            this.pivotGridControl1.ShowGroupBar = false;
            this.pivotGridControl1.ShowSubTotals = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(699, 488);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(699, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 488);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAdv1);
            this.groupBox1.Controls.Add(this.checkBoxAdv3);
            this.groupBox1.Controls.Add(this.checkBoxAdv2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(25, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupBar";
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.Location = new System.Drawing.Point(38, 86);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(110, 28);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.DrawFocusRectangle = true;
            this.checkBoxAdv1.TabIndex = 6;
            this.checkBoxAdv1.Text = "Allow Sorting";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv3.Checked = true;
            this.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv3.Location = new System.Drawing.Point(38, 22);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(184, 28);
            this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv3.DrawFocusRectangle = true;
            this.checkBoxAdv3.TabIndex = 4;
            this.checkBoxAdv3.Text = "Enable/Disable GroupBar";
            this.checkBoxAdv3.ThemesEnabled = false;
            this.checkBoxAdv3.CheckStateChanged += new System.EventHandler(this.checkBoxAdv3_CheckStateChanged);
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv2.Checked = true;
            this.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv2.Location = new System.Drawing.Point(38, 53);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(110, 28);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.DrawFocusRectangle = true;
            this.checkBoxAdv2.TabIndex = 5;
            this.checkBoxAdv2.Text = "Allow Filtering";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1012, 493);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = " GroupBar";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
      

    }
}

