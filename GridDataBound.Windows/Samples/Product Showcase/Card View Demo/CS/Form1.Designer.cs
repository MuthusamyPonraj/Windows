#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace CardViewDemo
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
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.ComboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDataBoundGrid1.BackColor = System.Drawing.Color.White;
            this.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(12, 19);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(698, 362);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            this.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(716, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 362);
            this.panel1.TabIndex = 2;
            // 
            // checkBox4
            // 
            this.checkBox4.Checked = false;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.DrawFocusRectangle = false;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(15, 121);
            this.checkBox4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(141, 21);
            this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "BrowseOnly";
            this.checkBox4.ThemesEnabled = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(CheckChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = false;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.checkBox3.DrawFocusRectangle = false;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(15, 85);
            this.checkBox3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(141, 18);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "ApplyRoundedCorner";
            this.checkBox3.ThemesEnabled = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(CheckChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DrawFocusRectangle = false;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(15, 50);
            this.checkBox2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(141, 17);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "ShowCaption";
            this.checkBox2.ThemesEnabled = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(CheckChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(15, 12);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 18);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "ShowCardCellBorders";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(CheckChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxAdv2);
            this.groupBox1.Controls.Add(this.ComboBoxAdv1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CardStyle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visual Style";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "StandardLabels",
            "MergedLabels"});
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "StandardLabels"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "MergedLabels"));
            this.comboBoxAdv2.Location = new System.Drawing.Point(30, 95);
            this.comboBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 1;
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // ComboBoxAdv1
            // 
            this.ComboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.ComboBoxAdv1.Items.AddRange(new object[] {
            "Office2010Blue",
            "Office2010Black",
            "Office2010Silver",
            "Office2007Blue",
            "Office2007Black",
            "Office2007Silver",
            "Metro",
            "System",
            "None"});
            this.ComboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.ComboBoxAdv1, "Office2010Blue"));
            this.ComboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.ComboBoxAdv1, "Office2010Black"));
            this.ComboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.ComboBoxAdv1, "Office2010Silver"));
            this.ComboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.ComboBoxAdv1, "Office2007Blue"));
            this.ComboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.ComboBoxAdv1, "Office2007Black"));
            this.ComboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.ComboBoxAdv1, "Office2007Silver"));
            this.ComboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.ComboBoxAdv1, "Metro"));
            this.ComboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.ComboBoxAdv1, "System"));
            this.ComboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.ComboBoxAdv1, "None"));
            this.ComboBoxAdv1.Location = new System.Drawing.Point(30, 42);
            this.ComboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ComboBoxAdv1.Name = "ComboBoxAdv1";
            this.ComboBoxAdv1.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.ComboBoxAdv1.TabIndex = 0;
            this.ComboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAdv1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(902, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Card View Demo";
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox4;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv ComboBoxAdv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
    }
}

