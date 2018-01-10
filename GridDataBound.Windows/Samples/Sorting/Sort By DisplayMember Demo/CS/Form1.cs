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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace DataBoundSortByDisplayMember
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
	{
		private DataBoundGrid gridDataBoundGrid1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private DataBoundSortByDisplayMember.DataSet1 dataSet11;
		private System.Data.SqlClient.SqlConnection sqlConnection1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		// manually added 
		private System.Data.SqlClient.SqlCommand sqlInsertProductCommand;
		private System.Data.SqlClient.SqlCommand sqlUpdateProductCommand;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter3;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn productIdColumn;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn productNameColumn;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn categoryColumn;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn supplierColumn;
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn supplierColumn1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteProductCommand;


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
            GridStyleInfo style = gridDataBoundGrid1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;
			this.gridDataBoundGrid1.SortBehavior = GridSortBehavior.SingleClick;
			this.gridDataBoundGrid1.AllowSelection = GridSelectionFlags.Row|GridSelectionFlags.Multiple|GridSelectionFlags.Shift|GridSelectionFlags.AlphaBlend;
			this.gridDataBoundGrid1.ControllerOptions &= ~(GridControllerOptions.OleDataSource|GridControllerOptions.OleDropTarget);
			this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            style = gridDataBoundGrid1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridDataBoundGrid1.Office2007ScrollBars = true;
			this.gridDataBoundGrid1.Model.QueryCellInfo += new GridQueryCellInfoEventHandler(Model_QueryCellInfo);

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			// Need to manually configure these commands because of designer limitation
			// not understanding Category table join is not needed for updating underlying
			// datatable.

			this.sqlInsertProductCommand = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateProductCommand = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteProductCommand = new System.Data.SqlClient.SqlCommand();

			// 
			// sqlInsertProductCommand
			// 
			this.sqlInsertProductCommand.CommandText = @"INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued); SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE (ProductID = @@IDENTITY)";
			this.sqlInsertProductCommand.Connection = this.sqlConnection1;
			this.sqlInsertProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"));
			this.sqlInsertProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			this.sqlInsertProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"));
			this.sqlInsertProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"));
			this.sqlInsertProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"));
			this.sqlInsertProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"));
			this.sqlInsertProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"));
			this.sqlInsertProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"));
			this.sqlInsertProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"));
			// 
			// sqlUpdateProductCommand
			// 
			this.sqlUpdateProductCommand.CommandText = @"UPDATE Products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID, QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, UnitsOnOrder = @UnitsOnOrder, ReorderLevel = @ReorderLevel, Discontinued = @Discontinued WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (Discontinued = @Original_Discontinued) AND (ProductName = @Original_ProductName) AND (QuantityPerUnit = @Original_QuantityPerUnit OR @Original_QuantityPerUnit IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = @Original_ReorderLevel OR @Original_ReorderLevel IS NULL AND ReorderLevel IS NULL) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL) AND (UnitPrice = @Original_UnitPrice OR @Original_UnitPrice IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = @Original_UnitsInStock OR @Original_UnitsInStock IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = @Original_UnitsOnOrder OR @Original_UnitsOnOrder IS NULL AND UnitsOnOrder IS NULL); SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE (ProductID = @ProductID)";
			this.sqlUpdateProductCommand.Connection = this.sqlConnection1;
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"));
			// 
			// sqlDeleteProductCommand
			// 
			this.sqlDeleteProductCommand.CommandText = @"DELETE FROM Products WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (Discontinued = @Original_Discontinued) AND (ProductName = @Original_ProductName) AND (QuantityPerUnit = @Original_QuantityPerUnit OR @Original_QuantityPerUnit IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = @Original_ReorderLevel OR @Original_ReorderLevel IS NULL AND ReorderLevel IS NULL) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL) AND (UnitPrice = @Original_UnitPrice OR @Original_UnitPrice IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = @Original_UnitsInStock OR @Original_UnitsInStock IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = @Original_UnitsOnOrder OR @Original_UnitsOnOrder IS NULL AND UnitsOnOrder IS NULL)";
			this.sqlDeleteProductCommand.Connection = this.sqlConnection1;
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteProductCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));

			// Comment this lines out to load from SQL database
//			this.sqlDataAdapter1.Fill(this.dataSet11);
//			this.sqlDataAdapter2.Fill(this.dataSet11);
//			this.sqlDataAdapter3.Fill(this.dataSet11);
//			this.gridDataBoundGrid1.DataSource = this.dataSet11.Products;

			// and comment this lines (they will load and initialize grid from xml file)
			DataSet ds = new DataSet();
			ds.ReadXmlSchema(FindXmlFile("SortDataSchema.xml"));
			ds.ReadXml(FindXmlFile("SortData.xml"));
			this.gridDataBoundGrid1.DataSource = ds.Tables["Products"];
			this.supplierColumn.StyleInfo.DataSource = ds.Tables["Suppliers"];
			this.categoryColumn.StyleInfo.DataSource = ds.Tables["Categories"];
			// end loading xml

			this.gridDataBoundGrid1.AllowResizeToFit = false;
		}

		string FindXmlFile(string xmlFileName)
		{
			for (int n = 0; n < 7; n++)
			{
				if (File.Exists(xmlFileName))
				{
					return xmlFileName;
				}
				xmlFileName = @"..\" + xmlFileName;
			}
			return "";
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
			this.gridDataBoundGrid1 = new DataBoundSortByDisplayMember.DataBoundGrid();
			this.dataSet11 = new DataBoundSortByDisplayMember.DataSet1();
			this.productIdColumn = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
			this.productNameColumn = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
			this.categoryColumn = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
			this.supplierColumn = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.supplierColumn1 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter3 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// gridDataBoundGrid1
			// 
			this.gridDataBoundGrid1.AllowDragSelectedCols = true;
			this.gridDataBoundGrid1.DataSource = this.dataSet11.Products;
            
			this.gridDataBoundGrid1.GridBoundColumns.AddRange(new Syncfusion.Windows.Forms.Grid.GridBoundColumn[] {
																													  this.productIdColumn,
																													  this.productNameColumn,
																													  this.categoryColumn,
																													  this.supplierColumn, 
                                                                                                                      this.supplierColumn1});
			this.gridDataBoundGrid1.Location = new System.Drawing.Point(8, 48);
			this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
			this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
			this.gridDataBoundGrid1.Size = new System.Drawing.Size(272, 152);
			this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
			this.gridDataBoundGrid1.TabIndex = 0;
			this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
			this.gridDataBoundGrid1.CellClick += new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(this.gridDataBoundGrid1_CellClick);
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
			// 
			// productIdColumn
			// 
			this.productIdColumn.MappingName = "ProductID";
			this.productIdColumn.StyleInfo.CellValueType = typeof(int);
			this.productIdColumn.StyleInfo.Format = "G";
			this.productIdColumn.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right;
			// 
			// productNameColumn
			// 
			this.productNameColumn.MappingName = "ProductName";
			this.productNameColumn.StyleInfo.CellValueType = typeof(string);
			// 
			// categoryColumn
			// 
			this.categoryColumn.HeaderText = "Category";
			this.categoryColumn.MappingName = "CategoryID";
			this.categoryColumn.StyleInfo.CellType = "ComboBox";
			this.categoryColumn.StyleInfo.DataSource = this.dataSet11.Categories;
			this.categoryColumn.StyleInfo.DisplayMember = "CategoryName";
			this.categoryColumn.StyleInfo.ValueMember = "CategoryID";
			// 
			// supplierColumn
			// 
			this.supplierColumn.HeaderText = "Supplier";
			this.supplierColumn.MappingName = "SupplierID";
			this.supplierColumn.StyleInfo.CellType = "ComboBox";
			this.supplierColumn.StyleInfo.DataSource = this.dataSet11.Suppliers;
			this.supplierColumn.StyleInfo.DisplayMember = "CompanyName";
			this.supplierColumn.StyleInfo.ValueMember = "SupplierID";
            
            //Adding the column that will be sorted internally through the supplier id

            //
            // suppliercolumn1
            //
            this.supplierColumn1.MappingName = "CompanyName";
            this.supplierColumn1.StyleInfo.CellValueType = typeof(string);
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
																																																				  new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																				  new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
																																																				  new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
																																																				  new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
																																																				  new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
																																																				  new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
																																																				  new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
																																																				  new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
																																																				  new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
																																																				  new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"),
																																																				  new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = @"SELECT Categories.CategoryName, Products.ProductID, Products.ProductName, Products.SupplierID, Products.CategoryID, Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, Products.Discontinued, Suppliers.CompanyName FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_samples;persist security info=True;user id=sa;packet size=4096;Pooling=true";
			// 
			// sqlDataAdapter2
			// 
			this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
																																																					new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName")})});
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT CategoryID, CategoryName FROM Categories";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlDataAdapter3
			// 
			this.sqlDataAdapter3.SelectCommand = this.sqlSelectCommand3;
			this.sqlDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Suppliers", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
																																																				   new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
																																																				   new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
																																																				   new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
																																																				   new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																				   new System.Data.Common.DataColumnMapping("City", "City"),
																																																				   new System.Data.Common.DataColumnMapping("Region", "Region"),
																																																				   new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
																																																				   new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																				   new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																				   new System.Data.Common.DataColumnMapping("Fax", "Fax"),
																																																				   new System.Data.Common.DataColumnMapping("HomePage", "HomePage")})});
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region," +
				" PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
			this.sqlSelectCommand3.Connection = this.sqlConnection1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 262);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gridDataBoundGrid1});
			this.Name = "Form1";
            this.Text = "Sort By DisplayMember Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			# region [ Enabling VisualStyles... ]
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			# endregion
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// following workaround ensures that combobox has valid binding context before we we try resizetofit
			this.gridDataBoundGrid1.Model.CellModels["ComboBox"].BindingContext = this.BindingContext;
			this.gridDataBoundGrid1.Model.CellModels["GridListControl"].BindingContext = this.BindingContext;

			// Now resize all columns to fit contents.
			this.gridDataBoundGrid1.AllowResizeToFit = false;
			this.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(this.gridDataBoundGrid1.ViewLayout.VisibleCellsRange, Syncfusion.Windows.Forms.Grid.GridResizeToFitOptions.IncludeHeaders);

			// Let's also size parent form large enough to hold this grid with horizontal scrollbars
			this.SuspendLayout();

			this.AdjustGridBounds();

			GridDataBoundGrid grid = this.gridDataBoundGrid1;
			Form parentForm = this;

			Size optimalClientSize = grid.Size; // Grid size has been calculated in HawksImpGrid_Load

			// Add frame border, caption and 2 pixels for the borders of the parent container border.
			Size optimalParentSize = new Size(
				optimalClientSize.Width +  System.Windows.Forms.SystemInformation.VerticalScrollBarWidth + System.Windows.Forms.SystemInformation.FrameBorderSize.Width * 2, 
				optimalClientSize.Height + System.Windows.Forms.SystemInformation.CaptionHeight + 2
				);
         
            this.Text = "Sort By DisplayMember Demo";
			this.gridDataBoundGrid1.DefaultRowHeight = 18;
			this.gridDataBoundGrid1.DefaultColWidth = 70;			

			this.Size = optimalParentSize;
			this.gridDataBoundGrid1.Dock = DockStyle.Fill;

            //Hiding the column that will be updated internally
            this.gridDataBoundGrid1.Model.HideCols[5] = true;

            grid.CurrentCellEditingComplete += new EventHandler(grid_CurrentCellEditingComplete);
			this.ResumeLayout();
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

		
        // Updating the text according to the supplier ID so that it will be sorted accordingly
        void grid_CurrentCellEditingComplete(object sender, EventArgs e)
        {
            if (gridDataBoundGrid1.CurrentCell.ColIndex == 4)
            {
                gridDataBoundGrid1.Model[gridDataBoundGrid1.CurrentCell.RowIndex, gridDataBoundGrid1.CurrentCell.ColIndex + 1].Text = gridDataBoundGrid1.Model[gridDataBoundGrid1.CurrentCell.RowIndex, gridDataBoundGrid1.CurrentCell.ColIndex].FormattedText;
                Console.WriteLine(gridDataBoundGrid1.Model[gridDataBoundGrid1.CurrentCell.RowIndex, gridDataBoundGrid1.CurrentCell.ColIndex].Text + ":" + gridDataBoundGrid1.Model[gridDataBoundGrid1.CurrentCell.RowIndex, gridDataBoundGrid1.CurrentCell.ColIndex].FormattedText);
            }
        }

		void AdjustGridBounds()
		{
			GridDataBoundGrid grid = this.gridDataBoundGrid1;
			int gridWidth = grid.Model.ColWidths.GetTotal(0, grid.Model.ColCount);
			int gridHeight = this.ClientSize.Height; // this.grid.Model.RowHeights.GetTotal(0, this.grid.Model.RowCount);

			grid.HScrollBehavior = GridScrollbarMode.Automatic;
			grid.VScrollBehavior = GridScrollbarMode.Automatic;

			// Make sure no scrollbars are shown. A little trick here is to fist make the grid 
			// a bit larger so that we are sure no scrollbars are needed 
			grid.Bounds = new Rectangle(
				0, 
				0, 
				gridWidth+System.Windows.Forms.SystemInformation.VerticalScrollBarWidth, 
				gridHeight+System.Windows.Forms.SystemInformation.HorizontalScrollBarHeight);

			// and then set the bounds of the grid - again no scrollbars are necessary
			grid.Bounds = new Rectangle(0, 0, gridWidth, gridHeight);

			// - Or - 
			// we could force turning off scrollbars temporary ...
			//			this.grid.HScrollBehavior = GridScrollbarMode.Disabled;
			//			this.grid.VScrollBehavior = GridScrollbarMode.Disabled;
			//			grid.VScroll = false;
			//			grid.HScroll = false;
			//			grid.Bounds = new Rectangle(0, 0, gridWidth, gridHeight);
			//			this.grid.HScrollBehavior = GridScrollbarMode.Automatic;
			//			this.grid.VScrollBehavior = GridScrollbarMode.Automatic;
		}


		private void gridDataBoundGrid1_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
		{
			bool VersionGreater1618 = false;
			if (VersionGreater1618)
			{
				GridDataBoundGrid grid = sender as GridDataBoundGrid;
				if (grid != null && e.RowIndex == 0 && e.ColIndex > 0)
				{
					GridModelDataBinder binder = grid.Binder;
					int field = binder.ColIndexToField(e.ColIndex);
					if (field >= 0)
					{
						GridBoundColumn column = binder.InternalColumns[field];
						string sortName = column.MappingName;
						if (column.MappingName == "SupplierID")
							sortName = "CompanyName";
						else if (column.MappingName == "CategoryID")
							sortName = "CategoryName";

						CurrencyManager cm = BindingContext[grid.DataSource, grid.DataMember] as CurrencyManager;
						DataView dv =  cm.List as DataView;
						ListSortDirection sortDir = ListSortDirection.Ascending;
						if (dv.Sort == sortName)
						{
							dv.Sort = sortName + " DESC";
							sortDir = ListSortDirection.Descending;
						}
						else 
							dv.Sort = sortName;

						grid.Model[0, e.ColIndex].Tag = sortDir;

						e.Cancel = true; // do not continue with default behavior 
						// e.Cancel will only work with 1.6.1.8 or higher 
						// (othwerwise you need to derive GridDataBoundGrid and override OnCellClick)
					}
				}
			}
		}

		private void Model_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
		{
			// Set style.Tag for the sorted column

			if (e.RowIndex == 0 && e.ColIndex > 0)
			{
				GridDataBoundGridModel grid = (GridDataBoundGridModel) sender;
				GridModelDataBinder binder = grid.Binder;
				int field = binder.ColIndexToField(e.ColIndex);
				if (field >= 0)
				{
					GridBoundColumn column = binder.InternalColumns[field];
					string sortName = column.MappingName;
					if (column.MappingName == "SupplierID")
						sortName = "CompanyName";
					else if (column.MappingName == "CategoryID")
						sortName = "CategoryName";

					CurrencyManager cm = BindingContext[binder.DataSource, binder.DataMember] as CurrencyManager;
					DataView dv =  cm.List as DataView;

					if (dv.Sort == sortName)
						e.Style.Tag = ListSortDirection.Ascending;
					else if (dv.Sort == sortName + " DESC")
						e.Style.Tag = ListSortDirection.Descending;
				}
			}
			else if(e.RowIndex > 0 && e.ColIndex > 0)
			{			
				if(e.ColIndex == 4 )
					e.Style.BackColor = Color.FromArgb( 0xff, 0xbf, 0x34 ); 
			}
		}
	}


	// Deriving DataBoundGrid is only needed ie e.Cancel for CellClick does not work (1.6.1.7 or earlier)

	public class DataBoundGrid : GridDataBoundGrid
	{
		protected override void OnCellClick(GridCellClickEventArgs e)
		{
			GridDataBoundGrid grid = this;
			if (grid != null && e.RowIndex == 0 && e.ColIndex > 0)
			{
                this.CurrentCell.EndEdit();
                this.Binder.EndEdit();
				GridModelDataBinder binder = grid.Binder;
				int field = binder.ColIndexToField(e.ColIndex);
				if (field >= 0)
				{
					GridBoundColumn column = binder.InternalColumns[field];
					string sortName = column.MappingName;
					if (column.MappingName == "SupplierID")
						sortName = "CompanyName";
					else if (column.MappingName == "CategoryID")
						sortName = "CategoryName";

					CurrencyManager cm = BindingContext[grid.DataSource, grid.DataMember] as CurrencyManager;
					DataView dv =  cm.List as DataView;
					ListSortDirection sortDir = ListSortDirection.Ascending;
					if (dv.Sort == sortName)
					{
						dv.Sort = sortName + " DESC";
						sortDir = ListSortDirection.Descending;
					}
					else 
						dv.Sort = sortName;
					
					grid.Model[0, e.ColIndex].Tag = sortDir;

					e.Cancel = true; // do not continue with default behavior 
				}
			}

			if (e.Cancel)
				return;

			base.OnCellClick (e);
		}

	}
}
