#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace GroupbarDemo
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            this.PivotGridSettings();
        }

        #endregion
      
        #region "DataSource"
        /// <summary>
        /// Creating the DataSource
        /// </summary>
        
        #region product sales class
        public class ProductSales
        {
            public string Product { get; set; }

            public string Year { get; set; }

            public string Country { get; set; }

            public string State { get; set; }

            public int Quantity { get; set; }

            public double Amount { get; set; }

            public static ProductSalesCollection GetSalesData()
            {
                /// Geography
                string[] countries = new string[] { "Canada" };

                string[] canadaStates = new string[] { "Alberta", "British Columbia", "Ontario" };

                /// Time

                string[] dates = new string[] { "FY 2005", "FY 2006", "FY 2007" };

                /// Products

                string[] products = new string[] { "Bike", "Car" };

                Random r = new Random(123345345);

                int numberOfRecords = 2000;

                ProductSalesCollection listOfProductSales = new ProductSalesCollection();

                for (int i = 0; i < numberOfRecords; i++)
                {
                    ProductSales sales = new ProductSales();

                    sales.Country = countries[r.Next(0, countries.GetLength(0))];

                    sales.Quantity = r.Next(1, 12);

                    /// 1 percent discount for 1 quantity

                    double discount = (30000 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);

                    sales.Amount = (30000 * sales.Quantity) - discount;

                    sales.Year = dates[r.Next(r.Next(dates.GetLength(0) + 1))];

                    sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];

                    sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];

                    listOfProductSales.Add(sales);

                }
                return listOfProductSales;
            }
            
            public override string ToString()
            {
                return string.Format("{0}-{1}-{2}", this.Country, this.State, this.Product);
            }

            //Retrieve the itemsource from the ProductSalesCollection
            public class ProductSalesCollection : List<ProductSales>
            {

            }
        }
        #endregion

        #endregion

        #region "Pivot Grid Settings"
        /// <summary>
        /// The grid settings can be customized
        /// </summary>
        private void PivotGridSettings()
        {
            this.pivotGridControl1.ItemSource = ProductSales.GetSalesData();
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Year", TotalHeader = "Total" });
            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });
            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Quantity", TotalHeader = "Total" });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Year", Format = "#,##0" });

            //enables to display the groupbar
            this.pivotGridControl1.ShowGroupBar = true;

            this.pivotGridControl1.AllowFiltering = true;
            this.pivotGridControl1.AllowSorting = true;

            //tab key navigation set as false to move the next control
            this.pivotGridControl1.TableControl.WantTabKey = false;
        }

        #region "Events"

        //enables the allowsorting
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.AllowSorting = !this.pivotGridControl1.AllowSorting;
            this.pivotGridControl1.Refresh();
            this.Refresh();
        }

        //enables the filtering
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.AllowFiltering = !this.pivotGridControl1.AllowFiltering;
            this.pivotGridControl1.Refresh();
            this.Refresh();
        }

        //enables the showgroupbar
        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowGroupBar = !this.pivotGridControl1.ShowGroupBar;
        }
        #endregion

        #endregion
       
    }
}
