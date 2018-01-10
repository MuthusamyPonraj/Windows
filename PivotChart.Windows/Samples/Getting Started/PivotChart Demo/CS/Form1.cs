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
using System.Drawing.Printing;
using System.Reflection;

namespace PivotChart_Demo
{
    public partial class Form1 : MetroForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.PivotChart.PivotChart pivotChart1;

        #endregion

        #region  "Constructor"

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
        }

        #endregion

        #region "PivotChart Settings"

        private void PivotChartSettings()
        {
            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = ProductSales.GetSalesData();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
            this.Settings();
            this.checkBox1.Anchor = AnchorStyles.Bottom;
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
                string[] countries = new string[] { "Australia", "Germany", "Canada", "United States" };
                string[] ausStates = new string[] { "New South Wales", "Queensland", };
                string[] canadaStates = new string[] { "Ontario", "Quebec" };
                string[] germanyStates = new string[] { "Bayern", "Brandenburg" };
                string[] ussStates = new string[] { "New York", "Colorado", "New Mexico" };

                /// Time
                string[] dates = new string[] { "FY 2008", "FY 2009", "FY 2010" , "FY 2011", "FY 20012"};

                /// Products
                string[] products = new string[] { "Bike" };
                Random r = new Random(123345);

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
                        case "Germany":
                            {
                                sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
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

        private void Settings()
        {
            this.panel1.Resize += new EventHandler(panel1_Resize);
            this.OtherArea.Resize += new EventHandler(OtherArea_Resize);
            this.panel1.Paint += new PaintEventHandler(panel1_Paint);
            this.OtherArea.Paint += new PaintEventHandler(OtherArea_Paint);

            typeof(Panel).GetProperty("DoubleBuffered",
                       BindingFlags.NonPublic | BindingFlags.Instance)
          .SetValue(panel1, true, null);
            typeof(Panel).GetProperty("DoubleBuffered",
                         BindingFlags.NonPublic | BindingFlags.Instance)
            .SetValue(panel2, true, null);
            this.panel1.Padding = new Padding(4);
            this.OtherArea.Padding = new Padding(4);

            //Form settings.
            this.BorderColor = Color.FromArgb(17, 150, 205);
            this.BorderThickness = 4;
            this.OtherArea.BackColor = Color.FromArgb(17, 150, 205);
            this.panel1.BackColor = Color.WhiteSmoke;
            this.checkBox1.Visible = false;
            this.label1.ForeColor = Color.White;
            this.Text = "PivotChart Print Demo";
            this.CaptionForeColor = Color.White;
        }

        #region "Panel Customization"

        void OtherArea_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int thickness = 2;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.LightGray, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panel.ClientSize.Width - thickness,
                                                          panel.ClientSize.Height - thickness));
            }
        }
        void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int thickness = 2;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.LightGray, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panel.ClientSize.Width - thickness,
                                                          panel.ClientSize.Height - thickness));
            }
        }
        void OtherArea_Resize(object sender, EventArgs e)
        {
            (sender as Panel).Invalidate();     
        }
        void panel1_Resize(object sender, EventArgs e)
        {
            (sender as Panel).Invalidate();            
        }

        #endregion

        //used to show backdrop image
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
                this.pivotChart1.ChartArea.InteriorBackImage = global::PivotChart_Demo.Properties.Resources._abstract;
            else
                this.pivotChart1.ChartArea.InteriorBackImage = null;
        }

        #endregion
               
    }
}
