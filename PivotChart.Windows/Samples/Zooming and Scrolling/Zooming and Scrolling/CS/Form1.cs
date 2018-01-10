#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;

namespace ZoomingandScrolling_Demo
{
    public partial class Form1 : MetroForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.PivotChart.PivotChart pivotChart1;

        #endregion

        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.PivotChartSettings();
            this.LoadOtherSettings();
        }

        #endregion

        #region "PivotChart Settings"

        private void PivotChartSettings()
        {
            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = ProductSales.GetSalesData();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });            
        }

        #endregion

        #region "ICON FILE"

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

        #endregion

        #region "DATASOURCE"

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
                string[] countries = new string[] { "Australia", "Canada" };
                string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
                string[] canadaStates = new string[] { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
                string[] franceStates = new string[] { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers", };
                string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland" };
                string[] ukStates = new string[] { "England" };
                string[] ussStates = new string[] { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

                /// Time
                string[] dates = new string[] { "FY 2005", "FY 2006", "FY 2007"};

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

            public class ProductSalesCollection : List<ProductSales>
            {
            }
        }
        #endregion

        #region "OTHER SETTINGS"

        private void LoadOtherSettings()
        {
            this.label1.BackColor = this.label2.BackColor = this.panel2.BackColor = Color.FromArgb(17, 150, 205);
            this.label1.TextAlign = ContentAlignment.MiddleLeft;
            this.label1.ForeColor = this.label2.ForeColor = this.label5.ForeColor = Color.White;
            this.label2.TextAlign = ContentAlignment.MiddleLeft;
            //events
            this.panel2.Paint += new PaintEventHandler(panel2_Paint);
            this.OtherArea.Paint += new PaintEventHandler(OtherArea_Paint);
            this.panel2.Resize += new EventHandler(panel2_Resize);
            this.OtherArea.Resize += new EventHandler(OtherArea_Resize);
            this.OtherArea.Padding = new Padding(1);
            this.checkBox1.Checked = this.checkBox2.Checked = true;
            this.comboBox1.SelectedItem = "0.5";
            this.comboBox2.SelectedItem = "1.0";
        }

        #region "Panel customization"

        void OtherArea_Resize(object sender, EventArgs e)
        {
            (sender as Panel).Invalidate();            
        }
        void panel2_Resize(object sender, EventArgs e)
        {
            (sender as Panel).Invalidate();
        }
        void OtherArea_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int thickness = 1;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.LightGray, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panel.ClientSize.Width - thickness ,
                                                          panel.ClientSize.Height - thickness));
            }
        }
        void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int thickness = 1;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.LightGray, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panel.ClientSize.Width - thickness ,
                                                          panel.ClientSize.Height - thickness));
            }
        }
        #endregion

        #endregion

        #region "Zoom Option"

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //enables the zooming option for pivotchart(for respective axis)
            this.pivotChart1.EnableXZooming = this.checkBox1.Checked;
            this.pivotChart1.EnableYZooming = this.checkBox2.Checked;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            if (combo.SelectedItem != null)
            {
                if (this.pivotChart1.EnableXZooming)
                {
                    if (combo == this.comboBox1)
                    {
                        double result;
                        double.TryParse(combo.SelectedItem.ToString(),out result);
                        //zoom factor level customization for respectiver axis
                        this.pivotChart1.PrimaryXAxis.ZoomFactor = result;
                    }
                }
                if (this.pivotChart1.EnableYZooming)
                {
                    if (combo == this.comboBox2)
                    {
                        double result;
                        double.TryParse(combo.SelectedItem.ToString(), out result);
                        this.pivotChart1.PrimaryYAxis.ZoomFactor = result;
                    }
                }
            }
        }

        #endregion
    }
}
