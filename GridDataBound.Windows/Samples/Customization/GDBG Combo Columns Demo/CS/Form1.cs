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

namespace GDBGcombos
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms;
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlDataAdapter sqlorderAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter sqlcustomerAdapter;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlemployeeAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private GDBGcombos.DataSet1 dataSet12;
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid2;
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid3;
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid4;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn1;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn2;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Panel panel1;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn4;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn5;
		private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn6;
		
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

			//Listen to the IBindingList.ListChanged events instead of the 
			//CurrencyManager events.
			this.gridDataBoundGrid2.UseListChangedEvent = true;

			//Listen to the IBindingList.ListChanged events instead of the 
			//CurrencyManager events.
			this.gridDataBoundGrid3.UseListChangedEvent = true;

			//Listen to the IBindingList.ListChanged events instead of the 
			//CurrencyManager events.
			this.gridDataBoundGrid4.UseListChangedEvent = true;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridDataBoundGrid1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";

            this.gridDataBoundGrid2.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid2.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid2.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            style = gridDataBoundGrid2.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";

            this.gridDataBoundGrid3.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid3.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid3.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            style = gridDataBoundGrid3.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";

            this.gridDataBoundGrid4.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid4.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid4.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            style = gridDataBoundGrid4.BaseStylesMap["Header"].StyleInfo;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Grid.GridStyleInfo gridStyleInfo1 = new Syncfusion.Windows.Forms.Grid.GridStyleInfo();
            Syncfusion.Windows.Forms.Grid.GridStyleInfo gridStyleInfo2 = new Syncfusion.Windows.Forms.Grid.GridStyleInfo();
            this.dataSet12 = new GDBGcombos.DataSet1();
            this.sqlorderAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlcustomerAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlemployeeAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.gridBoundColumn4 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gridBoundColumn5 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gridBoundColumn6 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gridBoundColumn1 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gridBoundColumn2 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gridBoundColumn3 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gridDataBoundGrid2 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.gridDataBoundGrid3 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.gridDataBoundGrid4 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlorderAdapter1
            // 
            this.sqlorderAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlorderAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlorderAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlorderAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
                        new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
                        new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"),
                        new System.Data.Common.DataColumnMapping("Freight", "Freight"),
                        new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
                        new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
                        new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
                        new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
                        new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
                        new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})});
            this.sqlorderAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Freight", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" +
                "es;persist security info=True;user id=sa;packet size=4096;Pooling=true";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"),
            new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"),
            new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"),
            new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"),
            new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"),
            new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"),
            new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"),
            new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"),
            new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"),
            new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"),
            new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"),
            new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" +
                "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" +
                "Country FROM Orders";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"),
            new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"),
            new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"),
            new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"),
            new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"),
            new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"),
            new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"),
            new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"),
            new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"),
            new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"),
            new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"),
            new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"),
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Freight", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID")});
            // 
            // sqlcustomerAdapter
            // 
            this.sqlcustomerAdapter.SelectCommand = this.sqlSelectCommand2;
            this.sqlcustomerAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlemployeeAdapter1
            // 
            this.sqlemployeeAdapter1.SelectCommand = this.sqlSelectCommand3;
            this.sqlemployeeAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT EmployeeID, LastName FROM Employees";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid1.DataSource = this.dataSet12.Orders;
            this.gridDataBoundGrid1.GridBoundColumns.AddRange(new Syncfusion.Windows.Forms.Grid.GridBoundColumn[] {
            this.gridBoundColumn4,
            this.gridBoundColumn5,
            this.gridBoundColumn6});
            this.gridDataBoundGrid1.HorizontalThumbTrack = true;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(16, 37);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(336, 160);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.VerticalThumbTrack = true;
            // 
            // gridBoundColumn4
            // 
            this.gridBoundColumn4.HeaderText = "OrderID";
            this.gridBoundColumn4.MappingName = "OrderID";
            // 
            // gridBoundColumn5
            // 
            this.gridBoundColumn5.HeaderText = "Customer";
            this.gridBoundColumn5.MappingName = "CustomerID";
            this.gridBoundColumn5.StyleInfo.CellType = "ComboBox";
            this.gridBoundColumn5.StyleInfo.DataSource = this.dataSet12.Customers;
            this.gridBoundColumn5.StyleInfo.DisplayMember = "CompanyName";
            this.gridBoundColumn5.StyleInfo.ValueMember = "CustomerID";
            // 
            // gridBoundColumn6
            // 
            this.gridBoundColumn6.HeaderText = "Employee";
            this.gridBoundColumn6.MappingName = "EmployeeID";
            this.gridBoundColumn6.StyleInfo.CellType = "ComboBox";
            this.gridBoundColumn6.StyleInfo.DataSource = this.dataSet12.Employees;
            this.gridBoundColumn6.StyleInfo.DisplayMember = "LastName";
            this.gridBoundColumn6.StyleInfo.ValueMember = "EmployeeID";
            // 
            // gridBoundColumn1
            // 
            this.gridBoundColumn1.HeaderText = "OrderID";
            this.gridBoundColumn1.MappingName = "OrderID";
            // 
            // gridBoundColumn2
            // 
            this.gridBoundColumn2.HeaderText = "Customer";
            this.gridBoundColumn2.MappingName = "CustomerID";
            this.gridBoundColumn2.StyleInfo.CellType = "ComboBox";
            this.gridBoundColumn2.StyleInfo.DisplayMember = "CompanyName";
            this.gridBoundColumn2.StyleInfo.ValueMember = "CustomerID";
            // 
            // gridBoundColumn3
            // 
            this.gridBoundColumn3.HeaderText = "Employee";
            this.gridBoundColumn3.MappingName = "EmployeeID";
            this.gridBoundColumn3.StyleInfo.CellType = "ComboBox";
            this.gridBoundColumn3.StyleInfo.DisplayMember = "LastName";
            this.gridBoundColumn3.StyleInfo.ValueMember = "EmployeeID";
            // 
            // gridDataBoundGrid2
            // 
            this.gridDataBoundGrid2.AllowDragSelectedCols = true;
            this.gridDataBoundGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid2.DataSource = this.dataSet12.Orders;
            this.gridDataBoundGrid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridDataBoundGrid2.HorizontalThumbTrack = true;
            this.gridDataBoundGrid2.Location = new System.Drawing.Point(16, 234);
            this.gridDataBoundGrid2.Name = "gridDataBoundGrid2";
            this.gridDataBoundGrid2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible;
            this.gridDataBoundGrid2.Size = new System.Drawing.Size(896, 144);
            this.gridDataBoundGrid2.SmartSizeBox = false;
            this.gridDataBoundGrid2.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid2.TabIndex = 1;
            gridStyleInfo1.Font.Bold = false;
            gridStyleInfo1.Font.Facename = "Microsoft Sans Serif";
            gridStyleInfo1.Font.Italic = false;
            gridStyleInfo1.Font.Size = 8.25F;
            gridStyleInfo1.Font.Strikeout = false;
            gridStyleInfo1.Font.Underline = false;
            this.gridDataBoundGrid2.TableStyle = gridStyleInfo1;
            this.gridDataBoundGrid2.Text = "gridDataBoundGrid2";
            this.gridDataBoundGrid2.ThemesEnabled = true;
            this.gridDataBoundGrid2.VerticalThumbTrack = true;
            this.gridDataBoundGrid2.CurrentCellActivated += new System.EventHandler(this.gridDataBoundGrid2_CurrentCellActivated);
            // 
            // gridDataBoundGrid3
            // 
            this.gridDataBoundGrid3.AllowDragSelectedCols = true;
            this.gridDataBoundGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid3.DataSource = this.dataSet12.Customers;
            this.gridDataBoundGrid3.HorizontalThumbTrack = true;
            this.gridDataBoundGrid3.Location = new System.Drawing.Point(368, 69);
            this.gridDataBoundGrid3.Name = "gridDataBoundGrid3";
            this.gridDataBoundGrid3.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible;
            this.gridDataBoundGrid3.Size = new System.Drawing.Size(320, 128);
            this.gridDataBoundGrid3.SmartSizeBox = false;
            this.gridDataBoundGrid3.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid3.TabIndex = 2;
            this.gridDataBoundGrid3.Text = "gridDataBoundGrid3";
            this.gridDataBoundGrid3.ThemesEnabled = true;
            this.gridDataBoundGrid3.VerticalThumbTrack = true;
            this.gridDataBoundGrid3.CurrentCellActivated += new System.EventHandler(this.gridDataBoundGrid3_CurrentCellActivated);
            // 
            // gridDataBoundGrid4
            // 
            this.gridDataBoundGrid4.AllowDragSelectedCols = true;
            this.gridDataBoundGrid4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid4.DataSource = this.dataSet12.Employees;
            this.gridDataBoundGrid4.Font = new System.Drawing.Font("Arial", 8.25F);
            this.gridDataBoundGrid4.HorizontalThumbTrack = true;
            this.gridDataBoundGrid4.Location = new System.Drawing.Point(704, 69);
            this.gridDataBoundGrid4.Name = "gridDataBoundGrid4";
            this.gridDataBoundGrid4.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible;
            this.gridDataBoundGrid4.Size = new System.Drawing.Size(208, 128);
            this.gridDataBoundGrid4.SmartSizeBox = false;
            this.gridDataBoundGrid4.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid4.TabIndex = 3;
            gridStyleInfo2.Font.Bold = false;
            gridStyleInfo2.Font.Facename = "Arial";
            gridStyleInfo2.Font.Italic = false;
            gridStyleInfo2.Font.Size = 8.25F;
            gridStyleInfo2.Font.Strikeout = false;
            gridStyleInfo2.Font.Underline = false;
            this.gridDataBoundGrid4.TableStyle = gridStyleInfo2;
            this.gridDataBoundGrid4.Text = "gridDataBoundGrid4";
            this.gridDataBoundGrid4.ThemesEnabled = true;
            this.gridDataBoundGrid4.VerticalThumbTrack = true;
            this.gridDataBoundGrid4.CurrentCellActivated += new System.EventHandler(this.gridDataBoundGrid4_CurrentCellActivated);
            // 
            // Label4
            // 
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 214);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(320, 16);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "Orders Table Showing Raw Data";
            // 
            // Label3
            // 
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(704, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(200, 16);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "EmployeeTable with Key && Value";
            // 
            // Label2
            // 
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(368, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(200, 16);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Customer Table with Key && Value";
            // 
            // Label1
            // 
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(352, 16);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Orders Grid with Foreign Key Combo Columns";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 390);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(928, 390);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.gridDataBoundGrid4);
            this.Controls.Add(this.gridDataBoundGrid3);
            this.Controls.Add(this.gridDataBoundGrid2);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDBG Combo Box Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid4)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif			
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			try
			{	
				//we'll read the data from a local XML file
				//comment this line if you want to access your SQLserver
				ReadXml(this.dataSet12, "Common\\Data\\GDBDdata.XML");

				//uncomment these 3 lines if you want to access your SQLserver
				//this.sqlcustomerAdapter.Fill(this.dataSet12);
				//this.sqlemployeeAdapter1.Fill(this.dataSet12);
				//this.sqlorderAdapter1.Fill(this.dataSet12);


				this.gridDataBoundGrid1.AllowResizeToFit = false;

				//'manually size columns in first grid
				this.gridDataBoundGrid1.Model.ColWidths[1] = 50;
				this.gridDataBoundGrid1.Model.ColWidths[2] = 144;
				this.gridDataBoundGrid1.Model.ColWidths[3] = 88;

				//color columns from code...
				this.gridDataBoundGrid1.Model.ColStyles[2].BackColor = Color.FromArgb( 218, 229, 245 );
				this.gridDataBoundGrid1.Model.ColStyles[3].BackColor = Color.FromArgb( 204, 212, 230 );
				this.gridDataBoundGrid2.Model.ColStyles[2].BackColor = Color.FromArgb( 218, 229, 245 );
				this.gridDataBoundGrid3.Model.ColStyles[1].BackColor = Color.FromArgb( 218, 229, 245 );
				this.gridDataBoundGrid2.Model.ColStyles[3].BackColor = Color.FromArgb( 204, 212, 230 );
				this.gridDataBoundGrid4.Model.ColStyles[1].BackColor = Color.FromArgb( 204, 212, 230 );

				this.gridDataBoundGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver;
				this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
				this.gridDataBoundGrid2.Model.Properties.GridLineColor = System.Drawing.Color.Silver;
				this.gridDataBoundGrid2.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
				this.gridDataBoundGrid3.Model.Properties.GridLineColor = System.Drawing.Color.Silver;
				this.gridDataBoundGrid3.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
				this.gridDataBoundGrid4.Model.Properties.GridLineColor = System.Drawing.Color.Silver;
				this.gridDataBoundGrid4.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;

		}
			catch(Exception ex)
			{
				MessageBox.Show("Problem reading the XML data:\r\n" + ex.ToString());
				this.Close();
			}
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


		//hunt the folder tree for the data\*.xml file..
		void ReadXml(DataSet ds, string xmlFileName)
		{
			for (int n = 0; n < 10; n++)
			{
				if (System.IO.File.Exists(xmlFileName))
				{
					ds.ReadXml(xmlFileName);
					break;
				}
				xmlFileName = @"..\" + xmlFileName;
			}
		}

		private void gridDataBoundGrid3_CurrentCellActivated(object sender, System.EventArgs e)
		{
			//force scroll into view
			this.gridDataBoundGrid3.CurrentCell.ScrollInView();
		}

		private void gridDataBoundGrid4_CurrentCellActivated(object sender, System.EventArgs e)
		{
			//force scroll into view
			this.gridDataBoundGrid4.CurrentCell.ScrollInView();
		}

		private void gridDataBoundGrid2_CurrentCellActivated(object sender, System.EventArgs e)
		{
			//force scroll into view
			this.gridDataBoundGrid2.CurrentCell.ScrollInView();
		}
	}
}
