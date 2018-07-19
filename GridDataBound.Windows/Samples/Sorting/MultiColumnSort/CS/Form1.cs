using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;


namespace MultiColumnSortInGridDataBoundGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDataBoundGrid1.GridLineColor = System.Drawing.SystemColors.GrayText;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 64);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(573, 380);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sort using API";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "To do UI sorting, click a column header. To retain the current sorts and add a ne" +
                "w one, ctl+click a column header.";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(573, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Column Sort";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
			Application.Run(new Form1());
		}


		private GridMultiColSortHelper.GridMultiColSortHelper sortHelper = null;
		private void Form1_Load(object sender, System.EventArgs e)
		{
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
			DataTable dt = new DataTable("MyTable");

			int nCols = 12;
			int nRows = 20;

			Random r = new Random();
			for(int i = 0; i < nCols; i++)
				dt.Columns.Add(new DataColumn(string.Format("Col{0}", i)));

			for(int i = 0; i < nRows; ++i)
			{
				DataRow dr = dt.NewRow();
				for(int j = 0; j < nCols; j++)
					dr[j] = string.Format("val{0}", r.Next(1000) % (2*j + 1));
				dt.Rows.Add(dr);
			}

			this.gridDataBoundGrid1.DataSource = dt;

            gridDataBoundGrid1.SortColumn(gridDataBoundGrid1.Binder.NameToColIndex("Col1"));
            gridDataBoundGrid1.Model.Cols.Hidden[gridDataBoundGrid1.Binder.NameToColIndex("Col1")] = true;

			//set some properties...
			this.gridDataBoundGrid1.SortBehavior = GridSortBehavior.SingleClick;
			this.gridDataBoundGrid1.AllowDragSelectedCols = false;
			this.gridDataBoundGrid1.AllowSelection = this.gridDataBoundGrid1.AllowSelection & ~GridSelectionFlags.Column;
			
			//create and wire the sorthelper object
			sortHelper = new GridMultiColSortHelper.GridMultiColSortHelper();
			sortHelper.WireGrid(this.gridDataBoundGrid1, true); //true indicate the helper will resize to fit column headers
            this.sortHelper.DefaultSortColumn = "Col1";

            this.BackColor = Color.LightBlue ;
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.Model.EnableLegacyStyle = false;
            this.gridDataBoundGrid1.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Blue;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.sortHelper.SortColumn("Col7", ListSortDirection.Ascending, true, false); //clear - dont show
			this.sortHelper.SortColumn("Col6", ListSortDirection.Descending, false, false); //dont clear - dont show
			this.sortHelper.SortColumn("Col5", ListSortDirection.Ascending, false, false); //dont clear - dont show
			this.sortHelper.SortColumn("Col4", ListSortDirection.Descending, false, true);//dont clear - show
		}

	}
	
	/// <summary>
	/// Represents a class that is used to find the licensing file for Syncfusion controls.
	/// </summary>
	public class DemoCommon
	{

		/// <summary>
		/// Finds the license key from the Common folder.
		/// </summary>
		/// <returns>Returns the license key.</returns>
		public static string FindLicenseKey()
		{
			string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
			for (int n = 0; n < 20; n++)
			{
				if (!System.IO.File.Exists(licenseKeyFile))
				{
					licenseKeyFile = @"..\" + licenseKeyFile;
					continue;
				}
				return System.IO.File.ReadAllText(licenseKeyFile);
			}
			return string.Empty;
		}
	}
}
