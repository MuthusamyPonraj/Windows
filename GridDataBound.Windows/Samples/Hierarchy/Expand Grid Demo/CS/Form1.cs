#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlServerCe;
using System.Xml;

using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;


// TODO: SHould also handle double click on resize line (covered cells behavior)
// TODO: ScrollTipFeedback
namespace GDBGMultiHeader
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl gridRecordNavigationControl1;
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
        private Syncfusion.Windows.Forms.ButtonAdv expandAllbutton;
        private Syncfusion.Windows.Forms.ButtonAdv collapseAllButton;
        private Syncfusion.Windows.Forms.ButtonAdv okButton;
		private System.Windows.Forms.Panel panel1;
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
			//Listen to the IBindingList.ListChanged events instead of the
			//CurrencyManager events.
			this.gridDataBoundGrid1.UseListChangedEvent = true;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            this.gridDataBoundGrid1.Model.Properties.BackgroundColor = SystemColors.Window;
            GridStyleInfo style = gridDataBoundGrid1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;
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
            this.gridRecordNavigationControl1 = new Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl();
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.expandAllbutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.collapseAllButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.okButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridRecordNavigationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridRecordNavigationControl1
            // 
            this.gridRecordNavigationControl1.AllowAddNew = false;
            this.gridRecordNavigationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRecordNavigationControl1.Controls.Add(this.gridDataBoundGrid1);
            this.gridRecordNavigationControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gridRecordNavigationControl1.Location = new System.Drawing.Point(24, 24);
            this.gridRecordNavigationControl1.MaxRecord = 0;
            this.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1";
            this.gridRecordNavigationControl1.ShowToolTips = true;
            this.gridRecordNavigationControl1.Size = new System.Drawing.Size(624, 272);
            this.gridRecordNavigationControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.gridRecordNavigationControl1.TabIndex = 0;
            this.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1";
            this.gridRecordNavigationControl1.ThemesEnabled = true;
            this.gridRecordNavigationControl1.PaneClosing += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.gridRecordNavigationControl1_PaneClosing);
            this.gridRecordNavigationControl1.PaneCreated += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.gridRecordNavigationControl1_PaneCreated);
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid1.DefaultColWidth = 70;
            this.gridDataBoundGrid1.DefaultRowHeight = 18;
            this.gridDataBoundGrid1.FillSplitterPane = true;
            this.gridDataBoundGrid1.HorizontalThumbTrack = true;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(603, 251);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.VerticalThumbTrack = true;
            // 
            // expandAllbutton
            // 
            this.expandAllbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expandAllbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.expandAllbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandAllbutton.Location = new System.Drawing.Point(24, 306);
            this.expandAllbutton.Name = "expandAllbutton";
            this.expandAllbutton.Size = new System.Drawing.Size(104, 24);
            this.expandAllbutton.TabIndex = 1;
            this.expandAllbutton.Text = "Expand All";
            this.expandAllbutton.UseVisualStyle = true;
            this.expandAllbutton.Click += new System.EventHandler(this.expandAllbutton_Click);
            // 
            // collapseAllButton
            // 
            this.collapseAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.collapseAllButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.collapseAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collapseAllButton.Location = new System.Drawing.Point(133, 306);
            this.collapseAllButton.Name = "collapseAllButton";
            this.collapseAllButton.Size = new System.Drawing.Size(96, 24);
            this.collapseAllButton.TabIndex = 1;
            this.collapseAllButton.Text = "Collapse All";
            this.collapseAllButton.UseVisualStyle = true;
            this.collapseAllButton.Click += new System.EventHandler(this.collapseAllButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(562, 306);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(88, 24);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyle = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 342);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(672, 342);
            this.Controls.Add(this.expandAllbutton);
            this.Controls.Add(this.gridRecordNavigationControl1);
            this.Controls.Add(this.collapseAllButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expand Grid Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.gridRecordNavigationControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		Hashtable checkBoxValues = new Hashtable();
		Hashtable unboundValues = new Hashtable();
		GridModel gridModel = null;
		GridModelDataBinder gridBinder = null;

		void ReadXml(DataSet ds, string xmlFileName)
		{
			for (int n = 0; n < 10; n++)
			{
				if (File.Exists(xmlFileName))
				{
					ds.ReadXml(xmlFileName);
					break;
				}
				xmlFileName = @"..\" + xmlFileName;
			}
		}

        internal static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// cache grid model and binder
			this.gridModel = this.gridDataBoundGrid1.Model;
			this.gridBinder = this.gridDataBoundGrid1.Binder;

			// Reduce flicker
			this.gridDataBoundGrid1.BeginUpdate();


			gridModel.Options.AllowSelection = GridSelectionFlags.AlphaBlend|GridSelectionFlags.Row|GridSelectionFlags.Column|GridSelectionFlags.Keyboard|GridSelectionFlags.Shift;
			gridModel.Options.AllowDragSelectedCols = false;
			this.gridDataBoundGrid1.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(gridDataBoundGrid1_PrepareViewStyleInfo);
			GridStyleInfo standard = gridModel.BaseStylesMap["Standard"].StyleInfo;
			standard.ShowButtons = GridShowButtons.ShowCurrentRow;

			DelayedStatusDialog progressDialog = new DelayedStatusDialog(gridModel);
			gridModel.OperationFeedbackListener = progressDialog;

			DataSet ds = new DataSet();

			// we'll read the data from a local XML file
			// set loadfromSqlServer if you want to access your SQLserver
			bool loadfromSqlServer = true;
			if (loadfromSqlServer)
			{
                String commandstring1 = "select * from Categories";
                String commandstring2 = "select * from Products";
                String commandstring3 = "select * from [Order Details]";
                String commandstring4 = "select * from Suppliers";
                 String connectionstring = "Data Source=" + FindFile("NorthwindwithImage.sdf");
                SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connectionstring);
                SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connectionstring);
                SqlCeDataAdapter da3 = new SqlCeDataAdapter(commandstring3, connectionstring);
                SqlCeDataAdapter da4 = new SqlCeDataAdapter(commandstring4, connectionstring);

                try
                {
                    da1.Fill(ds, "Categories");
                    da2.Fill(ds, "Products");
                    da3.Fill(ds, "Order Details");
                    da4.Fill(ds, "Suppliers");
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show(ex.Message);
                }

			}
			else
				ReadXml(ds, @"Common\Data\Expand.xml");

			ds.Tables[1].TableName = "Products";
			ds.Tables[2].TableName = "OrderDetails";
			ds.Tables[3].TableName = "Suppliers";

			ds.Relations.Add(
				ds.Tables[0].Columns["CategoryID"],
				ds.Tables[1].Columns["CategoryID"]);
			ds.Relations[0].RelationName = "Category_Products";

			ds.Relations.Add(
				ds.Tables[1].Columns["ProductID"],
				ds.Tables[2].Columns["ProductID"]);
			ds.Relations[1].RelationName = "Products_OrderDetails";

			this.gridDataBoundGrid1.DataMember = "Categories";
			this.gridDataBoundGrid1.DataSource = ds;

			GridHierarchyLevel hlCategory_Products = gridBinder.AddRelation("Category_Products");
			GridHierarchyLevel hlProducts_OrderDetails = gridBinder.AddRelation("Products_OrderDetails");
			// "-" indicates a covered cell
			// "." indicates a new row

			GridHierarchyLevel hlCategories = gridBinder.RootHierarchyLevel;
			hlCategories.LayoutColumns(
				new string[] {
								 "CategoryID", "CategoryName", "-", "Description", "-", "-", "-", "-"
							 });
			hlCategory_Products.LayoutColumns(
				new string[] {
								 "", "ProductID", "ProductName", "-", "-", "SupplierID", "-", "-", /*"CategoryID", */
								 ".", // show subsequent fields in a 2nd row
								 "",
								 "QuantityPerUnit",
								 "UnitPrice",
								 "UnitsInStock",
								 "UnitsOnOrder",
								 "ReorderLevel",
								 "Discontinued",
			});
			hlProducts_OrderDetails.LayoutColumns(
				new string[] {
								 "", "-", "OrderID", /*"ProductID", */"UnitPrice", "Quantity", "Discount"
							 });

			GridStyleInfo supplierIDStyle = hlCategory_Products.InternalColumns["SupplierID"].StyleInfo;
			supplierIDStyle.CellType = "GridListControl";
			supplierIDStyle.DataSource = ds.Tables["Suppliers"];
			supplierIDStyle.DisplayMember = "CompanyName";
			supplierIDStyle.ValueMember = "SupplierID";
			supplierIDStyle.HorizontalAlignment = GridHorizontalAlignment.Left;

			GridStyleInfo discontinuedStyle = hlCategory_Products.InternalColumns["Discontinued"].StyleInfo;
			discontinuedStyle.CellType = "CheckBox";
			discontinuedStyle.HorizontalAlignment = GridHorizontalAlignment.Center;

            hlCategories.RowStyle.BackColor = Color.FromArgb( 248, 251, 255 ); 
		
			hlCategory_Products.RowStyle.BackColor = Color.FromArgb( 250, 240, 230 ); 
		
            hlProducts_OrderDetails.RowStyle.BackColor = Color.FromArgb( 102, 110, 152 ); 
		

			this.gridDataBoundGrid1.HighlightCurrentColumnHeader = true;

			// Copy over bound columns and add one unbound extra column at the end
			GridBoundColumnsCollection columns = (GridBoundColumnsCollection) this.gridBinder.InternalColumns.Clone();
			this.gridBinder.GridBoundColumns = columns;

			// Enable SelectAll mode for current cell (looks better)
			gridModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.WhenGridActive;
			gridModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.SelectAll;

			// Move current cell to top-left corner.
			this.gridDataBoundGrid1.CurrentCell.MoveTo(gridModel.Rows.HeaderCount+1, gridModel.Cols.HeaderCount+1);

			// Increase with of navigation record so that " of ###" can be shown
			this.gridRecordNavigationControl1.NavigationBarWidth += 20;
			this.gridRecordNavigationControl1.Font = this.gridDataBoundGrid1.Font;
			this.gridRecordNavigationControl1.BackColor = Color.FromArgb( 192, 201, 219 );
			this.gridRecordNavigationControl1.NavigationBarBackColor = Color.FromArgb( 237, 240, 246 );

			// Resize rows option
			gridModel.Options.ResizeRowsBehavior = GridResizeCellsBehavior.ResizeSingle|GridResizeCellsBehavior.OutlineBounds|GridResizeCellsBehavior.OutlineHeaders;
			gridModel.Options.ResizeColsBehavior = GridResizeCellsBehavior.ResizeSingle|GridResizeCellsBehavior.AllowDragOutside|GridResizeCellsBehavior.OutlineBounds|GridResizeCellsBehavior.OutlineHeaders;

			// Set fond bold for standard column headers
			GridStyleInfo gsiHeader = gridModel.BaseStylesMap["Header"].StyleInfo ;
			gsiHeader.Font.Bold = true;
			gsiHeader.Enabled = true;

			

			this.gridDataBoundGrid1.VerticalThumbTrack = true;

			int lastRow = this.gridDataBoundGrid1.ViewLayout.LastVisibleRow;

			//gridModel.ResetVolatileData();
			gridModel.ColWidths.ResizeToFit(GridRangeInfo.Cells(2, 0, gridModel.ColCount, lastRow), GridResizeToFitOptions.IncludeHeaders|GridResizeToFitOptions.NoShrinkSize|GridResizeToFitOptions.ResizeCoveredCells);
			this.gridDataBoundGrid1.AllowResizeToFit = false;

			// Grid will repaint ittself later.
			this.gridDataBoundGrid1.EndUpdate();

			// Wire events
			this.gridDataBoundGrid1.ScrollInfoChanged += new System.EventHandler(this.gridDataBoundGrid1_ScrollInfoChanged);
     		this.gridDataBoundGrid1.DefaultRowHeight = 18;
			this.gridDataBoundGrid1.DefaultColWidth = 70;			
			

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

	

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// You should call Update if you want changes made in the DataGrid be committed
			// to the datasource.
			// Just uncomment the line below.
			// this.sqlDataAdapter1.Update(this.dataSet11);
		}

		private void gridDataBoundGrid1_ScrollInfoChanged(object sender, System.EventArgs e)
		{
			GridDataBoundGrid grid = sender as GridDataBoundGrid;
			int recordCount = grid.Binder.RecordCount;
			if (recordCount > 0)
				this.gridRecordNavigationControl1.MaxLabel = " of " + recordCount;
			else
				this.gridRecordNavigationControl1.MaxLabel = "";

			Syncfusion.Diagnostics.TraceUtil.TraceCurrentMethodInfo(this.gridRecordNavigationControl1.MaxLabel);
		}

		private void gridRecordNavigationControl1_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridDataBoundGrid grid = e.Control as GridDataBoundGrid;
			grid.ScrollInfoChanged += new System.EventHandler(this.gridDataBoundGrid1_ScrollInfoChanged);
			grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(gridDataBoundGrid1_PrepareViewStyleInfo);
		}

		private void gridRecordNavigationControl1_PaneClosing(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridDataBoundGrid grid = e.Control as GridDataBoundGrid;
			grid.ScrollInfoChanged -= new System.EventHandler(this.gridDataBoundGrid1_ScrollInfoChanged);
			grid.PrepareViewStyleInfo -= new GridPrepareViewStyleInfoEventHandler(gridDataBoundGrid1_PrepareViewStyleInfo);
		}

		private void gridDataBoundGrid1_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
		{
			GridDataBoundGrid grid = sender as GridDataBoundGrid;
			if (grid != null && e.ColIndex > 0)
			{
				if (grid.IsShowCurrentRow(e.RowIndex) && !grid.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex))
				{
					e.Style.BackColor = SystemColors.Highlight;
					e.Style.TextColor = SystemColors.HighlightText;
				}
			}			
		}

		private void expandAllbutton_Click(object sender, System.EventArgs e)
		{
			this.gridDataBoundGrid1.ExpandAll();
		}

		private void collapseAllButton_Click(object sender, System.EventArgs e)
		{
			this.gridDataBoundGrid1.CollapseAll();
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
			Close();
		}


	}
}
