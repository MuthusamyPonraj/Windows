#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ToolTipDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnable = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSummary = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkColHeader = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkSumHeader = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkRowHeader = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkValue = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSumHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRowHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkEnable);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(781, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ToolTip Properties";
            // 
            // chkEnable
            // 
            this.chkEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnable.DrawFocusRectangle = false;
            this.chkEnable.Location = new System.Drawing.Point(21, 21);
            this.chkEnable.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(173, 28);
            this.chkEnable.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkEnable.DrawFocusRectangle = true;
            this.chkEnable.TabIndex = 9;
            this.chkEnable.Text = "Enable ToolTip";
            this.chkEnable.ThemesEnabled = false;
            this.chkEnable.CheckStateChanged += new System.EventHandler(this.chkEnable_CheckStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkSummary);
            this.groupBox2.Controls.Add(this.chkColHeader);
            this.groupBox2.Controls.Add(this.chkSumHeader);
            this.groupBox2.Controls.Add(this.chkRowHeader);
            this.groupBox2.Controls.Add(this.chkValue);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(781, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enable ToolTip";
            // 
            // chkSummary
            // 
            this.chkSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSummary.DrawFocusRectangle = false;
            this.chkSummary.Location = new System.Drawing.Point(21, 166);
            this.chkSummary.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkSummary.Name = "chkSummary";
            this.chkSummary.Size = new System.Drawing.Size(173, 28);
            this.chkSummary.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkSummary.DrawFocusRectangle = true;
            this.chkSummary.TabIndex = 8;
            this.chkSummary.Text = "Summary Cell";
            this.chkSummary.ThemesEnabled = false;
            // 
            // chkColHeader
            // 
            this.chkColHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkColHeader.DrawFocusRectangle = false;
            this.chkColHeader.Location = new System.Drawing.Point(21, 35);
            this.chkColHeader.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkColHeader.Name = "chkColHeader";
            this.chkColHeader.Size = new System.Drawing.Size(162, 28);
            this.chkColHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkColHeader.DrawFocusRectangle = true;
            this.chkColHeader.TabIndex = 4;
            this.chkColHeader.Text = "ColumnHeader";
            this.chkColHeader.ThemesEnabled = false;
            // 
            // chkSumHeader
            // 
            this.chkSumHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSumHeader.DrawFocusRectangle = false;
            this.chkSumHeader.Location = new System.Drawing.Point(21, 133);
            this.chkSumHeader.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkSumHeader.Name = "chkSumHeader";
            this.chkSumHeader.Size = new System.Drawing.Size(173, 28);
            this.chkSumHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkSumHeader.DrawFocusRectangle = true;
            this.chkSumHeader.TabIndex = 7;
            this.chkSumHeader.Text = "Summary Header";
            this.chkSumHeader.ThemesEnabled = false;
            // 
            // chkRowHeader
            // 
            this.chkRowHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRowHeader.DrawFocusRectangle = false;
            this.chkRowHeader.Location = new System.Drawing.Point(21, 66);
            this.chkRowHeader.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkRowHeader.Name = "chkRowHeader";
            this.chkRowHeader.Size = new System.Drawing.Size(173, 28);
            this.chkRowHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkRowHeader.DrawFocusRectangle = true;
            this.chkRowHeader.TabIndex = 5;
            this.chkRowHeader.Text = "RowHeader";
            this.chkRowHeader.ThemesEnabled = false;
            // 
            // chkValue
            // 
            this.chkValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkValue.DrawFocusRectangle = false;
            this.chkValue.Location = new System.Drawing.Point(21, 99);
            this.chkValue.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkValue.Name = "chkValue";
            this.chkValue.Size = new System.Drawing.Size(173, 28);
            this.chkValue.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkValue.DrawFocusRectangle = true;
            this.chkValue.TabIndex = 6;
            this.chkValue.Text = "Value Cell";
            this.chkValue.ThemesEnabled = false;
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
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 12);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.ShowGrandTotals = true;
            this.pivotGridControl1.ShowGroupBar = false;
            this.pivotGridControl1.ShowSubTotals = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(746, 465);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(993, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pivotGridControl1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "ToolTip";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSumHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRowHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkValue;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkRowHeader;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkColHeader;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSummary;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSumHeader;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkEnable;

    }
}

