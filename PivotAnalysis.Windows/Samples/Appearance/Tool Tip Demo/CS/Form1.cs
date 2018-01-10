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
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;

namespace ToolTipDemo
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

        #region "Pivot Grid Settings"

        /// <summary>
        /// The Grid settings can be customized
        /// </summary>
        private void PivotGridSettings()
        {
            // Adding ItemSource to the Control
            this.pivotGridControl1.ItemSource = ProductSales.GetSalesData();

            // Adding PivotRows to the Control
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotColumns to the Control
            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            this.pivotGridControl1.TableModel.QueryCellInfo += new Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventHandler(TableModel_QueryCellInfo);
            groupBox2.Enabled = chkEnable.Checked = true;

            //tab key navigation set as false to move the next control
            this.pivotGridControl1.TableControl.WantTabKey = false;
        }

        #endregion

        #region "DataSource"
        /// <summary>
        /// Craeting the DataSource
        /// </summary>

        public class ProductSales
        {
            public string Product { get; set; }

            public string Date { get; set; }

            public string Country { get; set; }

            public string State { get; set; }

            public int Quantity { get; set; }

            public double Amount { get; set; }

            public double UnitPrice { get; set; }

            public double TotalPrice { get; set; }

            public static ProductSalesCollection GetSalesData()
            {
                /// Geography
                string[] countries = new string[] { "Australia", "Canada", "France", "Germany", "United Kingdom", "United States" };
                string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
                string[] canadaStates = new string[] { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
                string[] franceStates = new string[] { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers", };
                string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland" };
                string[] ukStates = new string[] { "England" };
                string[] ussStates = new string[] { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

                /// Time
                string[] dates = new string[] { "FY 2005", "FY 2006", "FY 2007", "FY 2008", "FY 2009" };

                /// Products
                string[] products = new string[] { "Bike", "Car" };
                Random r = new Random(123345345);

                int numberOfRecords = 2000;
                ProductSalesCollection listOfProductSales = new ProductSalesCollection();
                for (int i = 0; i < numberOfRecords; i++)
                {
                    ProductSales sales = new ProductSales();
                    sales.Country = countries[r.Next(1, countries.GetLength(0))];
                    sales.Quantity = r.Next(1, 12);
                    /// 1 percent discount for 1 quantity
                    double discount = (30000 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
                    sales.Amount = (30000 * sales.Quantity) - discount;
                    sales.TotalPrice = sales.Amount * sales.Quantity;
                    sales.UnitPrice = sales.Amount / sales.Quantity;
                    sales.Date = dates[r.Next(r.Next(dates.GetLength(0) + 1))];
                    sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                    switch (sales.Country)
                    {
                        case "Australia":
                            {
                                sales.State = ausStates[r.Next(ausStates.GetLength(0))];
                                break;
                            }
                        case "Canada":
                            {
                                sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                                break;
                            }
                        case "France":
                            {
                                sales.State = franceStates[r.Next(franceStates.GetLength(0))];
                                break;
                            }
                        case "Germany":
                            {
                                sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                                break;
                            }
                        case "United Kingdom":
                            {
                                sales.State = ukStates[r.Next(ukStates.GetLength(0))];
                                break;
                            }
                        case "United States":
                            {
                                sales.State = ussStates[r.Next(ussStates.GetLength(0))];
                                break;
                            }
                    }
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

        #region "Sample Customization"

        //The cell style settings can be customized
        void TableModel_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {
            if (allowTooltip && e.RowIndex > 0 && e.ColIndex > 0)
            {
                PivotCellInfo cellinfo = this.pivotGridControl1.PivotEngine[e.RowIndex - 1, e.ColIndex - 1];
                string tooltip = "Value: " + e.Style.Text;
                if (e.Style.Text == string.Empty)
                    tooltip = "Value: (No Value)";
                else
                {
                    PivotCellInfo colParent = this.pivotGridControl1.PivotEngine[0, e.ColIndex - 1].ParentCell;
                    PivotCellInfo rowParent = this.pivotGridControl1.PivotEngine[e.RowIndex - 1, 0].ParentCell;
                    if (colParent != null)
                    {
                        tooltip += "\nColumn: " + colParent.Value;
                    }
                    else
                    {
                        if (this.pivotGridControl1.PivotEngine[0, e.ColIndex - 1].Value != null)
                            tooltip += "\nColumn: " + this.pivotGridControl1.PivotEngine[0, e.ColIndex - 1].Value;
                        else if (this.pivotGridControl1.PivotEngine[0, e.ColIndex - 1].Value == null && e.ColIndex > 1)
                            tooltip += "\nColumn: " + this.pivotGridControl1.PivotEngine[0, e.ColIndex - 2].Value;
                    }
                    object subRow = this.pivotGridControl1.PivotEngine[e.RowIndex - 1, 1].Value;
                    if (rowParent != null)
                    {
                        tooltip += "\nRow: " + rowParent.Value + " - " + subRow;
                    }
                    else
                        tooltip += "\nRow: " + this.pivotGridControl1.PivotEngine[e.RowIndex - 1, 0].Value + " - " + subRow;
                    if (e.Style.Tag != null)
                        tooltip = "Value: " + e.Style.Text;
                }
                if ((!chkColHeader.Checked && (cellinfo.CellType == (PivotCellType.ColumnHeaderCell | PivotCellType.ExpanderCell)
                    || cellinfo.CellType == (PivotCellType.ColumnHeaderCell | PivotCellType.HeaderCell)
                    || cellinfo.CellType == (PivotCellType.ColumnHeaderCell | PivotCellType.CalculationHeaderCell)))
                    || (!chkRowHeader.Checked && (cellinfo.CellType == (PivotCellType.RowHeaderCell | PivotCellType.ExpanderCell)
                    || cellinfo.CellType == (PivotCellType.RowHeaderCell | PivotCellType.HeaderCell)))
                    || (!chkSummary.Checked && (cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.ValueCell)
                    || cellinfo.CellType == (PivotCellType.TotalCell | PivotCellType.ValueCell)))
                    || (!chkValue.Checked && cellinfo.CellType == PivotCellType.ValueCell)
                    || (!chkSumHeader.Checked && (cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.RowHeaderCell)
                    || cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.ColumnHeaderCell)
                    || cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.ColumnHeaderCell | PivotCellType.HeaderCell)
                    || cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.RowHeaderCell | PivotCellType.HeaderCell)
                    || cellinfo.CellType == (PivotCellType.TotalCell | PivotCellType.RowHeaderCell)
                    || cellinfo.CellType == (PivotCellType.TotalCell | PivotCellType.ColumnHeaderCell))))
                {
                    tooltip = string.Empty;
                }
                e.Style.CellTipText = tooltip;
            }
        }

        bool allowTooltip = false;
        private void chkEnable_CheckStateChanged(object sender, EventArgs e)
        {
            allowTooltip = chkEnable.Checked;
            groupBox2.Enabled = chkEnable.Checked;
            chkColHeader.Checked = chkRowHeader.Checked = chkSumHeader.Checked = chkValue.Checked = chkSummary.Checked = allowTooltip;
            this.pivotGridControl1.Refresh();
            this.pivotGridControl1.TableControl.RefreshRange(GridRangeInfo.Table());
        }

        #endregion
    }
}
