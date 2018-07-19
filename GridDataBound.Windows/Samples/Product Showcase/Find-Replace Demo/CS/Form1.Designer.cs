namespace FindReplaceDemo_2005
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
            this.grpBoxFindReplace = new System.Windows.Forms.GroupBox();
            this.btnReset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cmbBoxReplace = new System.Windows.Forms.ComboBox();
            this.cmbBoxSearch = new System.Windows.Forms.ComboBox();
            this.cmbBoxOptions = new System.Windows.Forms.ComboBox();
            this.btnFindAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkBoxSearchUp = new System.Windows.Forms.CheckBox();
            this.chkBoxMatchWholeCell = new System.Windows.Forms.CheckBox();
            this.chkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this.btnReplaceAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnReplace = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblReplaceWith = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFindNext = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.grpBoxFindReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.GridLineColor = System.Drawing.SystemColors.GrayText;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(671, 331);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            this.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = true;
            // 
            // grpBoxFindReplace
            // 
            this.grpBoxFindReplace.AutoSize = true;
            this.grpBoxFindReplace.BackColor = System.Drawing.Color.LightBlue;
            this.grpBoxFindReplace.Controls.Add(this.btnReset);
            this.grpBoxFindReplace.Controls.Add(this.cmbBoxReplace);
            this.grpBoxFindReplace.Controls.Add(this.cmbBoxSearch);
            this.grpBoxFindReplace.Controls.Add(this.cmbBoxOptions);
            this.grpBoxFindReplace.Controls.Add(this.btnFindAll);
            this.grpBoxFindReplace.Controls.Add(this.chkBoxSearchUp);
            this.grpBoxFindReplace.Controls.Add(this.chkBoxMatchWholeCell);
            this.grpBoxFindReplace.Controls.Add(this.chkBoxMatchCase);
            this.grpBoxFindReplace.Controls.Add(this.btnReplaceAll);
            this.grpBoxFindReplace.Controls.Add(this.btnReplace);
            this.grpBoxFindReplace.Controls.Add(this.lblReplaceWith);
            this.grpBoxFindReplace.Controls.Add(this.label5);
            this.grpBoxFindReplace.Controls.Add(this.btnFindNext);
            this.grpBoxFindReplace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBoxFindReplace.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFindReplace.Location = new System.Drawing.Point(6, 337);
            this.grpBoxFindReplace.Name = "grpBoxFindReplace";
            this.grpBoxFindReplace.Size = new System.Drawing.Size(662, 94);
            this.grpBoxFindReplace.TabIndex = 4;
            this.grpBoxFindReplace.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnReset.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(606, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 54);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyle = true;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbBoxReplace
            // 
            this.cmbBoxReplace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBoxReplace.FormattingEnabled = true;
            this.cmbBoxReplace.Location = new System.Drawing.Point(85, 49);
            this.cmbBoxReplace.Name = "cmbBoxReplace";
            this.cmbBoxReplace.Size = new System.Drawing.Size(123, 22);
            this.cmbBoxReplace.TabIndex = 13;
            // 
            // cmbBoxSearch
            // 
            this.cmbBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBoxSearch.FormattingEnabled = true;
            this.cmbBoxSearch.Location = new System.Drawing.Point(85, 21);
            this.cmbBoxSearch.Name = "cmbBoxSearch";
            this.cmbBoxSearch.Size = new System.Drawing.Size(123, 22);
            this.cmbBoxSearch.TabIndex = 12;
            // 
            // cmbBoxOptions
            // 
            this.cmbBoxOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBoxOptions.FormattingEnabled = true;
            this.cmbBoxOptions.Items.AddRange(new object[] {
            "ColumnOnly",
            "SelectionOnly",
            "WholeTable"});
            this.cmbBoxOptions.Location = new System.Drawing.Point(294, 52);
            this.cmbBoxOptions.Name = "cmbBoxOptions";
            this.cmbBoxOptions.Size = new System.Drawing.Size(123, 22);
            this.cmbBoxOptions.TabIndex = 11;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnFindAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnFindAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAll.Location = new System.Drawing.Point(521, 20);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(81, 23);
            this.btnFindAll.TabIndex = 10;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyle = true;
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // chkBoxSearchUp
            // 
            this.chkBoxSearchUp.AutoSize = true;
            this.chkBoxSearchUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxSearchUp.Location = new System.Drawing.Point(221, 54);
            this.chkBoxSearchUp.Name = "chkBoxSearchUp";
            this.chkBoxSearchUp.Size = new System.Drawing.Size(87, 19);
            this.chkBoxSearchUp.TabIndex = 9;
            this.chkBoxSearchUp.Text = "Search Up";
            this.chkBoxSearchUp.UseVisualStyleBackColor = true;
            // 
            // chkBoxMatchWholeCell
            // 
            this.chkBoxMatchWholeCell.AutoSize = true;
            this.chkBoxMatchWholeCell.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxMatchWholeCell.Location = new System.Drawing.Point(310, 20);
            this.chkBoxMatchWholeCell.Name = "chkBoxMatchWholeCell";
            this.chkBoxMatchWholeCell.Size = new System.Drawing.Size(126, 19);
            this.chkBoxMatchWholeCell.TabIndex = 8;
            this.chkBoxMatchWholeCell.Text = "Match Whole Cell";
            this.chkBoxMatchWholeCell.UseVisualStyleBackColor = true;
            // 
            // chkBoxMatchCase
            // 
            this.chkBoxMatchCase.AutoSize = true;
            this.chkBoxMatchCase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxMatchCase.Location = new System.Drawing.Point(221, 20);
            this.chkBoxMatchCase.Name = "chkBoxMatchCase";
            this.chkBoxMatchCase.Size = new System.Drawing.Size(96, 19);
            this.chkBoxMatchCase.TabIndex = 7;
            this.chkBoxMatchCase.Text = "Match Case";
            this.chkBoxMatchCase.UseVisualStyleBackColor = true;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnReplaceAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnReplaceAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceAll.Location = new System.Drawing.Point(521, 52);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(81, 23);
            this.btnReplaceAll.TabIndex = 6;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyle = true;
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnReplace.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(437, 52);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(74, 23);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyle = true;
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // lblReplaceWith
            // 
            this.lblReplaceWith.AutoSize = true;
            this.lblReplaceWith.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblReplaceWith.Location = new System.Drawing.Point(8, 52);
            this.lblReplaceWith.Name = "lblReplaceWith";
            this.lblReplaceWith.Size = new System.Drawing.Size(77, 14);
            this.lblReplaceWith.TabIndex = 3;
            this.lblReplaceWith.Text = "Replace With";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search For";
            // 
            // btnFindNext
            // 
            this.btnFindNext.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnFindNext.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnFindNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindNext.Location = new System.Drawing.Point(437, 20);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(74, 23);
            this.btnFindNext.TabIndex = 1;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyle = true;
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 443);
            this.Controls.Add(this.grpBoxFindReplace);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Name = "Form1";
            this.Text = "Find and Replace Demo";
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.grpBoxFindReplace.ResumeLayout(false);
            this.grpBoxFindReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
        private System.Windows.Forms.GroupBox grpBoxFindReplace;
        private System.Windows.Forms.ComboBox cmbBoxReplace;
        private System.Windows.Forms.ComboBox cmbBoxSearch;
        private System.Windows.Forms.ComboBox cmbBoxOptions;
        private Syncfusion.Windows.Forms.ButtonAdv btnFindAll;
        private System.Windows.Forms.CheckBox chkBoxSearchUp;
        private System.Windows.Forms.CheckBox chkBoxMatchWholeCell;
        private System.Windows.Forms.CheckBox chkBoxMatchCase;
        private Syncfusion.Windows.Forms.ButtonAdv btnReplaceAll;
        private Syncfusion.Windows.Forms.ButtonAdv btnReplace;
        private System.Windows.Forms.Label lblReplaceWith;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.ButtonAdv btnFindNext;
        private Syncfusion.Windows.Forms.ButtonAdv btnReset;
    }
}

