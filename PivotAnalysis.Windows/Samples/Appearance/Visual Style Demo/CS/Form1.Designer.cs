#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace VisualstyleDemo
{
    partial class Form1
    {
        #region API Definition

        private Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Office2010Silver;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Office2010Black;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Office2010Blue;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Office2007Silver;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Office2007Black;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Office2007Blue;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Metro;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #endregion

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
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Metro = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Office2010Silver = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Office2010Black = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Office2010Blue = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Office2007Silver = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Office2007Black = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Office2007Blue = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Metro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Silver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2007Silver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2007Black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2007Blue)).BeginInit();
            this.SuspendLayout();
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
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 16);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.ShowGrandTotals = true;
            this.pivotGridControl1.ShowGroupBar = false;
            this.pivotGridControl1.ShowSubTotals = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(798, 495);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Metro);
            this.groupBox2.Controls.Add(this.Office2010Silver);
            this.groupBox2.Controls.Add(this.Office2010Black);
            this.groupBox2.Controls.Add(this.Office2010Blue);
            this.groupBox2.Controls.Add(this.Office2007Silver);
            this.groupBox2.Controls.Add(this.Office2007Black);
            this.groupBox2.Controls.Add(this.Office2007Blue);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(824, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 270);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VisualStyle";
            // 
            // Metro
            // 
            this.Metro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Metro.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Metro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Metro.Checked = true;
            this.Metro.Location = new System.Drawing.Point(25, 236);
            this.Metro.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Metro.Name = "Metro";
            this.Metro.Size = new System.Drawing.Size(125, 22);
            this.Metro.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Metro.DrawFocusRectangle = true;
            this.Metro.TabIndex = 6;
            this.Metro.Text = "Metro";
            this.Metro.ThemesEnabled = false;
            this.Metro.CheckChanged += new System.EventHandler(this.Metro_CheckChanged);
            // 
            // Office2010Silver
            // 
            this.Office2010Silver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Office2010Silver.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Office2010Silver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2010Silver.DrawFocusRectangle = false;
            this.Office2010Silver.Location = new System.Drawing.Point(25, 204);
            this.Office2010Silver.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2010Silver.Name = "Office2010Silver";
            this.Office2010Silver.Size = new System.Drawing.Size(125, 22);
            this.Office2010Silver.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Office2010Silver.TabIndex = 5;
            this.Office2010Silver.TabStop = false;
            this.Office2010Silver.Text = "Office2010Silver";
            this.Office2010Silver.ThemesEnabled = false;
            this.Office2010Silver.CheckChanged += new System.EventHandler(this.Office2010Silver_CheckedChanged);
            // 
            // Office2010Black
            // 
            this.Office2010Black.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Office2010Black.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Office2010Black.Location = new System.Drawing.Point(25, 165);
            this.Office2010Black.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2010Black.Name = "Office2010Black";
            this.Office2010Black.Size = new System.Drawing.Size(125, 28);
            this.Office2010Black.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Office2010Black.DrawFocusRectangle = true;
            this.Office2010Black.TabIndex = 4;
            this.Office2010Black.TabStop = false;
            this.Office2010Black.Text = "Office2010Black";
            this.Office2010Black.ThemesEnabled = false;
            this.Office2010Black.CheckChanged += new System.EventHandler(this.Office2010Black_CheckedChanged);
            // 
            // Office2010Blue
            // 
            this.Office2010Blue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Office2010Blue.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Office2010Blue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2010Blue.Location = new System.Drawing.Point(25, 131);
            this.Office2010Blue.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2010Blue.Name = "Office2010Blue";
            this.Office2010Blue.Size = new System.Drawing.Size(119, 21);
            this.Office2010Blue.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Office2010Blue.DrawFocusRectangle = true;
            this.Office2010Blue.TabIndex = 3;
            this.Office2010Blue.TabStop = false;
            this.Office2010Blue.Text = "Office2010Blue";
            this.Office2010Blue.ThemesEnabled = false;
            this.Office2010Blue.CheckChanged += new System.EventHandler(this.Office2010Blue_CheckedChanged);
            // 
            // Office2007Silver
            // 
            this.Office2007Silver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Office2007Silver.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Office2007Silver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2007Silver.Location = new System.Drawing.Point(25, 97);
            this.Office2007Silver.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2007Silver.Name = "Office2007Silver";
            this.Office2007Silver.Size = new System.Drawing.Size(125, 19);
            this.Office2007Silver.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Office2007Silver.DrawFocusRectangle = true;
            this.Office2007Silver.TabIndex = 2;
            this.Office2007Silver.TabStop = false;
            this.Office2007Silver.Text = "Office2007Silver";
            this.Office2007Silver.ThemesEnabled = false;
            this.Office2007Silver.CheckChanged += new System.EventHandler(this.Office2007Silver_CheckedChanged);
            // 
            // Office2007Black
            // 
            this.Office2007Black.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Office2007Black.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Office2007Black.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2007Black.Location = new System.Drawing.Point(24, 63);
            this.Office2007Black.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2007Black.Name = "Office2007Black";
            this.Office2007Black.Size = new System.Drawing.Size(123, 18);
            this.Office2007Black.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Office2007Black.DrawFocusRectangle = true;
            this.Office2007Black.TabIndex = 1;
            this.Office2007Black.TabStop = false;
            this.Office2007Black.Text = "Office2007Black";
            this.Office2007Black.ThemesEnabled = false;
            this.Office2007Black.CheckChanged += new System.EventHandler(this.Office2007Black_CheckedChanged);
            // 
            // Office2007Blue
            // 
            this.Office2007Blue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Office2007Blue.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Office2007Blue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2007Blue.DrawFocusRectangle = false;
            this.Office2007Blue.Location = new System.Drawing.Point(24, 28);
            this.Office2007Blue.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2007Blue.Name = "Office2007Blue";
            this.Office2007Blue.Size = new System.Drawing.Size(123, 21);
            this.Office2007Blue.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Office2007Blue.DrawFocusRectangle = true;
            this.Office2007Blue.TabIndex = 0;
            this.Office2007Blue.TabStop = false;
            this.Office2007Blue.Text = "Office2007Blue";
            this.Office2007Blue.ThemesEnabled = false;
            this.Office2007Blue.CheckChanged += new System.EventHandler(this.Office2007Blue_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1012, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pivotGridControl1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "Visual Style ";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Metro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Silver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2007Silver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2007Black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2007Blue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion       

    }
}

