#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.ComponentModel;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSample
{
    public class Filters : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        string[] filterType = { "Custom Filter", "Text Filter", "DateTime Filter", "Dynamic Filter","Advanced Filter" };
        ExcelEngine excelEngine;
        private PictureBox pictureBox3;
        private Button btnViewTemplate;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilterData;
        private Label label2;
        private ComboBox cmbFirst;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rdbFilterInPlace;
        private RadioButton rdbFilterCopy;
        private CheckBox cbisUnique;
        private Label label1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        #region Initialize
        public Filters()
        {
            InitializeComponent();
            excelEngine = new ExcelEngine();
            foreach (string filter in filterType)
            {
                cmbFirst.Items.Add(filter);
            }
            cmbFirst.SelectedIndex = 0;
        }
        #endregion
        

        #region View the Input file
        private void btnViewTemplate_Click(object sender, EventArgs e)
        {
            string inputPath;
            //Get the path of the input file

            if (cmbFirst.SelectedIndex == 4)
            {
                inputPath = GetFullTemplatePath("AdvancedFilterData.xlsx");
            }
            else
            {
                inputPath = GetFullTemplatePath("FilterData.xlsx");
            }
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion

        #region Filter Data

        private void btnFilterData_Click(object sender, EventArgs e)
        {
            string fileName;
            if (cmbFirst.SelectedIndex == 4)
            {
                fileName = "AdvancedFilterData.xlsx";
            }
            else
            {
                fileName = "FilterData.xlsx";
            }
            FilterData(fileName);
            OpenOutput(fileName);
        }

        #region Dispose the Excel Engine
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            excelEngine.Dispose();
        }
        #endregion
        #endregion

        #region HelperMethods

        #region Get File Path
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion
                
        #region Method for Sorting using Values
        private void FilterData(string outFileName)
        {
            #region Workbook Initialize
            //Get the path of the input file
            string inputPath = GetFullTemplatePath(outFileName);
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            IWorksheet sheet = workbook.Worksheets[0];

            #endregion

            int columnIndex = cmbFirst.SelectedIndex;
            if (columnIndex != 4)
            {
                sheet.AutoFilters.FilterRange = sheet.Range[1, 1, 49, 3];

            }
            switch (columnIndex)
            {
                case 0:
                    IAutoFilter filter1 = sheet.AutoFilters[0];
                    filter1.IsAnd = false;
                    filter1.FirstCondition.ConditionOperator = ExcelFilterCondition.Equal;
                    filter1.FirstCondition.DataType = ExcelFilterDataType.String;
                    filter1.FirstCondition.String = "Owner";

                    filter1.SecondCondition.ConditionOperator = ExcelFilterCondition.Equal;
                    filter1.SecondCondition.DataType = ExcelFilterDataType.String;
                    filter1.SecondCondition.String = "Sales Representative";
                    break;

                case 1:
                    IAutoFilter filter2 = sheet.AutoFilters[0];
                    filter2.AddTextFilter(new string[] { "Owner", "Sales Representative", "Sales Associate" });
                    break;

                case 2:
                    IAutoFilter filter3 = sheet.AutoFilters[1];
                    filter3.AddDateFilter(new DateTime(2004, 9, 1, 1, 0, 0, 0), DateTimeGroupingType.month);
                    filter3.AddDateFilter(new DateTime(2011, 1, 1, 1, 0, 0, 0), DateTimeGroupingType.year);
                    break;
                case 4:
                    #region AdvancedFilter

                    IRange filterRange = sheet.Range["A8:G51"];
                    IRange criteriaRange = sheet.Range["A2:B5"];
                    if (rdbFilterInPlace.Checked)
                    {
                        sheet.AdvancedFilter(ExcelFilterAction.FilterInPlace, filterRange, criteriaRange, null, cbisUnique.Checked);
                    }
                    else if (rdbFilterCopy.Checked)
                    {
                        IRange range = sheet.Range["I7:O7"];
                        range.Merge();
                        range.Text = "FilterCopy";
                        range.CellStyle.Font.RGBColor = Color.FromArgb(0, 112, 192);
                        range.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        range.CellStyle.Font.Bold = true;
                        IRange copyRange = sheet.Range["I8"];
                        sheet.AdvancedFilter(ExcelFilterAction.FilterCopy, filterRange, criteriaRange, copyRange, cbisUnique.Checked);
                    }
                    #endregion

                    break;

                default:
                case 3:
                    IAutoFilter filter4 = sheet.AutoFilters[1];
                    filter4.AddDynamicFilter(DynamicFilterType.Quarter1);
                    break;
            }

            #region Workbook Save and Close
            workbook.SaveAs(outFileName);
            workbook.Close();
            #endregion
        }
        #endregion

        #region Open the Output File
        private void OpenOutput(string fileName)
        {
            // Message box confirmation to view the created document.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            == DialogResult.Yes)
            {
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(fileName);

                    //Exit
                    this.Close();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("Excel 2007 is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
                this.Close();
        }
        #endregion

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filters));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbisUnique = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbFilterCopy = new System.Windows.Forms.RadioButton();
            this.rdbFilterInPlace = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFirst = new System.Windows.Forms.ComboBox();
            this.btnViewTemplate = new System.Windows.Forms.Button();
            this.btnFilterData = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbFirst);
            this.groupBox1.Controls.Add(this.btnViewTemplate);
            this.groupBox1.Controls.Add(this.btnFilterData);
            this.groupBox1.Location = new System.Drawing.Point(4, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(473, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbisUnique);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(45, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(381, 129);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced Filter";
            // 
            // cbisUnique
            // 
            this.cbisUnique.AutoSize = true;
            this.cbisUnique.Location = new System.Drawing.Point(225, 87);
            this.cbisUnique.Name = "cbisUnique";
            this.cbisUnique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbisUnique.Size = new System.Drawing.Size(150, 24);
            this.cbisUnique.TabIndex = 1;
            this.cbisUnique.Text = "Unique Records";
            this.cbisUnique.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbFilterCopy);
            this.groupBox3.Controls.Add(this.rdbFilterInPlace);
            this.groupBox3.Location = new System.Drawing.Point(17, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(192, 86);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Action";
            // 
            // rdbFilterCopy
            // 
            this.rdbFilterCopy.AutoSize = true;
            this.rdbFilterCopy.Location = new System.Drawing.Point(36, 55);
            this.rdbFilterCopy.Name = "rdbFilterCopy";
            this.rdbFilterCopy.Size = new System.Drawing.Size(109, 24);
            this.rdbFilterCopy.TabIndex = 1;
            this.rdbFilterCopy.TabStop = true;
            this.rdbFilterCopy.Text = "Filter Copy";
            this.rdbFilterCopy.UseVisualStyleBackColor = true;
            // 
            // rdbFilterInPlace
            // 
            this.rdbFilterInPlace.AutoSize = true;
            this.rdbFilterInPlace.Location = new System.Drawing.Point(36, 25);
            this.rdbFilterInPlace.Name = "rdbFilterInPlace";
            this.rdbFilterInPlace.Size = new System.Drawing.Size(130, 24);
            this.rdbFilterInPlace.TabIndex = 0;
            this.rdbFilterInPlace.TabStop = true;
            this.rdbFilterInPlace.Text = "Filter In Place";
            this.rdbFilterInPlace.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose the filter type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFirst
            // 
            this.cmbFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFirst.FormattingEnabled = true;
            this.cmbFirst.Location = new System.Drawing.Point(260, 36);
            this.cmbFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFirst.Name = "cmbFirst";
            this.cmbFirst.Size = new System.Drawing.Size(166, 29);
            this.cmbFirst.TabIndex = 10;
            this.cmbFirst.SelectedIndexChanged += new System.EventHandler(this.cmbFirst_SelectedIndexChanged);
            // 
            // btnViewTemplate
            // 
            this.btnViewTemplate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTemplate.Location = new System.Drawing.Point(45, 233);
            this.btnViewTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewTemplate.Name = "btnViewTemplate";
            this.btnViewTemplate.Size = new System.Drawing.Size(171, 38);
            this.btnViewTemplate.TabIndex = 4;
            this.btnViewTemplate.Text = "Input Template";
            this.btnViewTemplate.UseVisualStyleBackColor = true;
            this.btnViewTemplate.Click += new System.EventHandler(this.btnViewTemplate_Click);
            // 
            // btnFilterData
            // 
            this.btnFilterData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterData.Location = new System.Drawing.Point(255, 233);
            this.btnFilterData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilterData.Name = "btnFilterData";
            this.btnFilterData.Size = new System.Drawing.Size(171, 38);
            this.btnFilterData.TabIndex = 2;
            this.btnFilterData.Text = "Filter Data";
            this.btnFilterData.UseVisualStyleBackColor = true;
            this.btnFilterData.Click += new System.EventHandler(this.btnFilterData_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(473, 110);
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 86);
            this.label1.TabIndex = 74;
            this.label1.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
    "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
    "nt.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Filters";
            this.Text = "Filters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region Dispose
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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Filters());
        }
        #endregion

        private void cmbFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFirst.SelectedIndex == 4)
            {
                //this.groupBox1.Size = new System.Drawing.Size(636, 290);
                this.groupBox2.Enabled = true;
            }
            else
                this.groupBox2.Enabled = false;
                this.rdbFilterInPlace.Checked = true;
                this.rdbFilterCopy.Checked = false;
                this.cbisUnique.Checked = false;
        }
    }
}
