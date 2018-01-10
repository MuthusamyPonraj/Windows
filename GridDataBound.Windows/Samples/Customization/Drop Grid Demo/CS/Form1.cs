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

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

namespace GDBGwithDropGrids
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private GDBGwithDropGrids.DataSet1 dataSet11;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private GridHierarchicalDataBoundGrid customerGrid1;
		private GridHierarchicalDataBoundGrid orderGrid2;
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid order_DetailsGrid3;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter3;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter4;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter5;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
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
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSet11 = new GDBGwithDropGrids.DataSet1();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter3 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter4 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter5 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," +
                " PostalCode, Country, Phone, Fax FROM Customers";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" +
                "es;persist security info=True;user id=sa;packet size=4096;Pooling=true";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" +
                "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" +
                "Country FROM Orders";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter3
            // 
            this.sqlDataAdapter3.SelectCommand = this.sqlSelectCommand3;
            this.sqlDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCourtesy"),
                        new System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"),
                        new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"),
                        new System.Data.Common.DataColumnMapping("Extension", "Extension"),
                        new System.Data.Common.DataColumnMapping("Photo", "Photo"),
                        new System.Data.Common.DataColumnMapping("Notes", "Notes"),
                        new System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo"),
                        new System.Data.Common.DataColumnMapping("PhotoPath", "PhotoPath")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDa" +
                "te, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Not" +
                "es, ReportsTo, PhotoPath FROM Employees";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter4
            // 
            this.sqlDataAdapter4.SelectCommand = this.sqlSelectCommand4;
            this.sqlDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Order Details", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("Discount", "Discount")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
            this.sqlSelectCommand4.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter5
            // 
            this.sqlDataAdapter5.SelectCommand = this.sqlSelectCommand5;
            this.sqlDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
                        new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnO" +
                "rder FROM Products";
            this.sqlSelectCommand5.Connection = this.sqlConnection1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 310);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(592, 310);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDBG Drop Grid Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
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

		void ReadXml(string xmlFileName)
		{
			for (int n = 0; n < 10; n++)
			{
				if (File.Exists(xmlFileName))
				{
					this.dataSet11.ReadXml(xmlFileName);
					break;
				}
				xmlFileName = @"..\" + xmlFileName;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//we'll read the data from a local XML file
			//comment this line if you want to access your SQLserver
			try
			{

				//we'll read the data from a local XML file
				//comment this line if you want to access your SQLserver
				ReadXml(@"Common\Data\GDBDdata.XML");

				//uncomment these DataAdapter1.Fill lines if you want to access your SQLserver
            	//load the dataset with the tables we use
				//this.sqlDataAdapter1.Fill(this.dataSet11); // customers table - used for the main grid
				//this.sqlDataAdapter2.Fill(this.dataSet11); // order's table - used for first dropdown grid
				//this.sqlDataAdapter3.Fill(this.dataSet11); // employee's table - used for foreign key combo
				//this.sqlDataAdapter4.Fill(this.dataSet11); // order details - used for the second dropdown grid
				//this.sqlDataAdapter5.Fill(this.dataSet11); // products - used for foreign key griddropdownlist
			

				//inner most grid ... does not contain dropdowns - so it is a GridDataBoundGrid
				// will be shown in dropdown
				this.order_DetailsGrid3 =  new GridHierarchicalDataBoundGrid(this, this.dataSet11.Order_Details,
					null, null, null, null, false);
				//setorder_DetailsGridLooks(this, EventArgs.Empty); //force the first setting...
				//this.order_DetailsGrid3.Model.DataProviderChanged += new EventHandler(setorder_DetailsGridLooks);
				//this.order_DetailsGrid3.Model.DataProviderChanged += new EventHandler(setorder_DetailsGridLooks);
			
				//in code, create a grid for the orders table - uses GridHierDataBoundGrid class
				// - will be shown in dropdown
				this.orderGrid2 =  new GridHierarchicalDataBoundGrid(this, this.dataSet11.Orders,
					this.dataSet11.Order_Details, this.order_DetailsGrid3, new QueryFilterStringEventHandler(ProvideOrder_DetailsFilterStrings),
					new QueryFormatGridEventHandler(ProvideOrder_DetailsFormat), true);
				//setOrderGridLooks(this, EventArgs.Empty);//force the first setting...
				//this.orderGrid2.Model.DataProviderChanged += new EventHandler(setOrderGridLooks);

				//create the outer most grid for the customers table - uses GridHierDataBoundGrid class
				this.customerGrid1 = new GridHierarchicalDataBoundGrid(this, this.dataSet11.Customers,
					this.dataSet11.Orders, this.orderGrid2, new QueryFilterStringEventHandler(ProvideOrdersFilterStrings), 
					new QueryFormatGridEventHandler(ProvideOrderFormat), true);
			
				//set its properties....
				this.customerGrid1.Location = new Point(20,20);
				this.customerGrid1.ThemesEnabled = true;
				this.customerGrid1.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 40);
				this.customerGrid1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
				this.customerGrid1.BorderStyle = BorderStyle.FixedSingle;
				this.panel1.Controls.Add(this.customerGrid1);

				//this.customerGrid1.Model.HideCols[0] = true;
			

				this.customerGrid1.CurrentCell.Deactivate(true);
				//this.customerGrid1.Model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.SetCurrent;
				this.customerGrid1.CurrentCell.Activate(1, 2, GridSetCurrentCellOptions.SetFocus);
				
				//Listen to the IBindingList.ListChanged events instead of the 
				//CurrencyManager events.
				this.customerGrid1.UseListChangedEvent = true;

				//Listen to the IBindingList.ListChanged events instead of the 
				//CurrencyManager events.
				this.orderGrid2.UseListChangedEvent = true;

				//Listen to the IBindingList.ListChanged events instead of the 
				//CurrencyManager events.
				this.order_DetailsGrid3.UseListChangedEvent = true;
                this.customerGrid1.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(customerGrid1_PrepareViewStyleInfo);
				this.customerGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
				this.customerGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver;
				this.customerGrid1.DefaultColWidth = 70;
				this.customerGrid1.DefaultRowHeight = 18;
                this.customerGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
                this.customerGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
                this.customerGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
                GridStyleInfo style = customerGrid1.BaseStylesMap["Header"].StyleInfo;
                style.TextColor = Color.MidnightBlue;
                style.Font.Facename = "Verdana";

                this.orderGrid2.GridVisualStyles = GridVisualStyles.Office2007Blue;
                this.orderGrid2.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
                this.orderGrid2.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
                style = orderGrid2.BaseStylesMap["Header"].StyleInfo;
                style.TextColor = Color.MidnightBlue;
                style.Font.Facename = "Verdana";
			}
			catch(Exception ex)
			{
				MessageBox.Show("This sample needs to access SQL server. Please recheck the connection string.");	
				MessageBox.Show(ex.ToString());
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

		private void ProvideOrderFormat(object sender, QueryFormatGridEventArgs e)
		{			
			e.Grid.Model.BaseStylesMap["Header"].StyleInfo.BackColor = Color.FromArgb(100, 100, 255);
			e.Grid.Model.BaseStylesMap["Header"].StyleInfo.TextColor = Color.FromArgb( 0xff, 0xbf, 0x34 );
			e.Grid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
			e.Grid.Model.Properties.GridLineColor = System.Drawing.Color.Silver;
			e.Grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(OrderFormat_PrepareViewStyleInfo);
	
			//set up the EmployeeID column as a foreign key combo column
			GridStyleInfo style = ((GridDataBoundGrid)e.Grid).GridBoundColumns["EmployeeID"].StyleInfo;
			style.CellType = "ComboBox";
			style.DataSource = this.dataSet11.Employees;
			style.ValueMember = "EmployeeID";
			style.DisplayMember = "LastName";
			style.ExclusiveChoiceList = true;
			
		}
		private void ProvideOrder_DetailsFormat(object sender, QueryFormatGridEventArgs e)
		{
			e.Grid.Model.BaseStylesMap["Header"].StyleInfo.BackColor = Color.FromArgb(100, 255, 100);
			e.Grid.Model.BaseStylesMap["Header"].StyleInfo.TextColor = Color.FromArgb( 0x85, 0xbf, 0x75 );		
			e.Grid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
			e.Grid.Model.Properties.GridLineColor = System.Drawing.Color.Silver;
			e.Grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(DetailsFormat_PrepareViewStyleInfo);

			//set up the ProductID columns as a foreign key griddroplist column
			GridStyleInfo style = ((GridDataBoundGrid)e.Grid).GridBoundColumns["ProductID"].StyleInfo;
			style.CellType = "GridListControl";
			style.DataSource = this.dataSet11.Products;
			style.ValueMember = "ProductID";
			style.DisplayMember = "ProductName";
			style.ExclusiveChoiceList = true;
			
		}

		private void ProvideOrdersFilterStrings(object sender, QueryFilterStringEventArgs e)
		{
			if (this.customerGrid1.Model[e.Row, e.Column + 1].Text != "")
				e.FilterString = string.Format("CustomerID = '{0}'", this.customerGrid1.Model[e.Row, e.Column + 1].Text); //add 1 to get to customerID
		}

		private void ProvideOrder_DetailsFilterStrings(object sender, QueryFilterStringEventArgs e)
		{
			if (this.orderGrid2.Model[e.Row, e.Column + 1].Text != "")
				e.FilterString = string.Format("OrderID = '{0}'", this.orderGrid2.Model[e.Row, e.Column + 1].Text); 			
		}

		private void customerGrid1_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
		{	
			if(e.RowIndex %2 ==0 && e.ColIndex > 0)
				e.Style.BackColor = Color.FromArgb( 218, 229, 245 );//Color.FromArgb( 237, 240, 246 );			
		}

		private void OrderFormat_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
		{
			if(e.RowIndex >0 && e.RowIndex%2 == 0 && e.ColIndex > 0)
				e.Style.BackColor =  Color.FromArgb( 0xff, 0xbf, 0x34 );
		}

		private void DetailsFormat_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
		{
			if(e.RowIndex%2 == 0 && e.ColIndex > 0)
				e.Style.BackColor =  Color.FromArgb( 0x85, 0xbf, 0x75 );
		}

	}
}
