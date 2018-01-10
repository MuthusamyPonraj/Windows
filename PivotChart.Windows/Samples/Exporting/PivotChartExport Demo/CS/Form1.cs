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
using System.Reflection;
using System.Diagnostics;
using Syncfusion.PivotConverter;

namespace Export_Demo
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
            this.LoadSettings();
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
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });                      
        }

        #endregion

        #region "PAINT"

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int thickness = 1;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.LightGray, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panel.ClientSize.Width - thickness,
                                                          panel.ClientSize.Height - thickness));
            }
        }


        void OtherArea_Paint(object sender, PaintEventArgs e)
        {
            int thickness = 1;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.LightGray, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          OtherArea.ClientSize.Width - thickness,
                                                          OtherArea.ClientSize.Height - thickness));
            }
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
                string[] countries = new string[] { "Canada", "France", "Germany", "United Kingdom"};
                string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
                string[] canadaStates = new string[] { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
                string[] franceStates = new string[] { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers", };
                string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg" };
                string[] ukStates = new string[] { "England" };
                string[] ussStates = new string[] { "North Carolina", "Alabama", "California", "Colorado"};

                /// Time
                string[] dates = new string[] { "FY 2006", "FY 2007", "FY 2008", "FY 2009" };

                /// Products
                string[] products = new string[] { "Bike", "Car" };
                Random r = new Random(1233);

                int numberOfRecords = 2000;
                ProductSalesCollection listOfProductSales = new ProductSalesCollection();
                for (int i = 0; i < numberOfRecords; i++)
                {
                    ProductSales sales = new ProductSales();
                    sales.Country = countries[r.Next(1, countries.GetLength(0))];
                    sales.Quantity = r.Next(1, 12);
                    /// 1 percent discount for 1 quantity
                    double discount = (30 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
                    sales.Amount = (300 * sales.Quantity) - discount;
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

        #region "EXPORT"

        void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.AddExtension = true;
            savedialog.FileName = "Sample";
            savedialog.DefaultExt = "xlsx";
            savedialog.Filter = "Excel file (.xlsx)|*.xlsx";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                ExcelExport excelExport = new ExcelExport(this.pivotChart1, Syncfusion.XlsIO.ExcelVersion.Excel2010,  Syncfusion.XlsIO.ExcelChartType.Column_Clustered);
                excelExport.Export(savedialog.FileName);

                if (MessageBox.Show("Export Success! Do you want to open the exported file?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start(savedialog.FileName);
                }
            }
        }

        #endregion

        #region "OTHER SETTINGS"
        
        private void LoadSettings()
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.EntirePanel.Padding = new Padding(6);
            typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(OtherArea, true, null);
            typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(panel2, true, null);
            //paint events of the panel
            this.OtherArea.Paint += new PaintEventHandler(OtherArea_Paint);
            this.panel1.Paint += new PaintEventHandler(panel1_Paint);
            this.panel1.BackColor = Color.LightGray;
            this.label1.ForeColor = Color.White;
            this.panel1.BackColor = Color.FromArgb(0, 175, 240);
            this.button1.Click += new EventHandler(button1_Click);
            this.label2.Image = global::Export_Demo.Properties.Resources.PivotChart;

            //used to set the custom color options for the pivotchart
            this.pivotChart1.CustomPalette = new Color[]{    
                Color.FromArgb(68, 114, 196),
                Color.FromArgb(56, 83, 164),
                Color.FromArgb(112, 173, 71),            
                Color.FromArgb(243, 236, 25),
                Color.FromArgb(165,165,165),
            };
        }

        #endregion

    }
}
