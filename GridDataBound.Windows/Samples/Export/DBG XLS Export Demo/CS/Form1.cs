#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.GridExcelConverter;
using Syncfusion.XlsIO;
namespace ExcelExport_DataBoundGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
        private Syncfusion.Windows.Forms.ButtonAdv Export;
        private ButtonAdv SelectedExport;
        private ButtonAdv RangeExport;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
			DataSet dataSet = new DataSet();
            dataSet.ReadXml(GetFile("Datasource.xml"));

			gridDataBoundGrid1.DataSource = dataSet.Tables[0];
            
			this.gridDataBoundGrid1.DefaultRowHeight = 18;
			this.gridDataBoundGrid1.DefaultColWidth = 70;

            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridDataBoundGrid1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen; ;
		}
		
		private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }


        private string GetFile(string fileName)
        {
            string dataFileName = @"Common\Data\Grid\" + fileName;            
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                dataFileName = @"..\" + dataFileName;
            }
            return dataFileName;
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.Export = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SelectedExport = new Syncfusion.Windows.Forms.ButtonAdv();
            this.RangeExport = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(32, 32);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(552, 288);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            // 
            // Export
            // 
            this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Export.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.Export.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.Location = new System.Drawing.Point(425, 331);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(160, 24);
            this.Export.TabIndex = 0;
            this.Export.Text = "Export";
            this.Export.UseVisualStyle = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // SelectedExport
            // 
            this.SelectedExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedExport.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.SelectedExport.Location = new System.Drawing.Point(253, 331);
            this.SelectedExport.Name = "SelectedExport";
            this.SelectedExport.Size = new System.Drawing.Size(139, 24);
            this.SelectedExport.TabIndex = 1;
            this.SelectedExport.Text = "SelectedExport";
            this.SelectedExport.UseVisualStyle = true;
            this.SelectedExport.Click += new System.EventHandler(this.SelectedExport_Click);
            // 
            // RangeExport
            // 
            this.RangeExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RangeExport.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.RangeExport.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.RangeExport.Location = new System.Drawing.Point(84, 331);
            this.RangeExport.Name = "RangeExport";
            this.RangeExport.Size = new System.Drawing.Size(143, 24);
            this.RangeExport.TabIndex = 2;
            this.RangeExport.Text = "RangeExport";
            this.RangeExport.UseVisualStyle = true;
            this.RangeExport.Click += new System.EventHandler(this.RangeExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(616, 366);
            this.Controls.Add(this.RangeExport);
            this.Controls.Add(this.SelectedExport);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBG XLS Export Demo";
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
		}

		private void Export_Click(object sender, System.EventArgs e)
		{
			Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Files(*.xls)|*.xls";
			saveFileDialog.DefaultExt = ".xls";

			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				gecc.GridToExcel(this.gridDataBoundGrid1.Model, saveFileDialog.FileName,
					Syncfusion.GridExcelConverter.ConverterOptions.RowHeaders);            
			
				if(MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Process proc = new Process();
					proc.StartInfo.FileName = saveFileDialog.FileName;
					proc.Start();
				}
			}
		}

        private void SelectedExport_Click(object sender, EventArgs e)
        {
            GridExcelConverterControl ExcelAdv = new GridExcelConverterControl();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Files(*.xls)|*.xls";
            saveFileDialog.DefaultExt = ".xls";

            if (this.gridDataBoundGrid1.Selections.Count > 0 && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelAdv.SelectedExport(this.gridDataBoundGrid1.Model, saveFileDialog.FileName, ConverterOptions.ColumnHeaders);

                if (File.Exists(saveFileDialog.FileName))
                {
                    if (MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process proc = new Process();
                        proc.StartInfo.FileName = saveFileDialog.FileName;
                        proc.Start();
                    }
                }
            }     
        }

        private void RangeExport_Click(object sender, EventArgs e)
        {
            ExcelEngine engine = new ExcelEngine();
            IApplication app = engine.Excel.Application;
            IWorkbook book = app.Workbooks.Create(1);

            Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Files(*.xls)|*.xls";
            saveFileDialog.DefaultExt = ".xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GridRangeInfo range = GridRangeInfo.Rows(this.gridDataBoundGrid1.TopRowIndex, this.gridDataBoundGrid1.TopRowIndex + 5);
                gecc.ExportRange(range, this.gridDataBoundGrid1.Model, book.Worksheets[0], ConverterOptions.ColumnHeaders);
                book.SaveAs(saveFileDialog.FileName);
                if (MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = saveFileDialog.FileName;
                    proc.Start();
                }
            }
        }
	}
}
