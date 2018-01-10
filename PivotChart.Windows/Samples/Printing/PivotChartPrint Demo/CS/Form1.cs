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

namespace PivotChartPrint_Demo
{
    public partial class Form1 : MetroForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.PivotChart.PivotChart pivotChart1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private PrintDocument printPreviewDocument;
        private System.Windows.Forms.PrintDialog printDialog1;

        #endregion

        #region  "constructor"

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

            printPreviewDialog1.MouseWheel += new MouseEventHandler(printPreviewDialog1_MouseWheel);
        }

        void printPreviewDialog1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                SendKeys.Send("{UP}");
            }
            else
            {
                SendKeys.Send("{DOWN}");
            }
        }

        #endregion

        #region "PivotChartSettings"

        private void PivotChartSettings()
        {

            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = ProductSales.GetSalesData();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });         

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });

            Settings();
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
                string[] countries = new string[] { "Australia", "Canada", "France", "Germany", "United States" };
                string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
                string[] canadaStates = new string[] { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
                string[] franceStates = new string[] { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers", };
                string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland" };
                string[] ukStates = new string[] { "England" };
                string[] ussStates = new string[] { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

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

        #region "Printing Settings"

        /// <summary>
        /// used to preview the pivotchart.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDocument = this.pivotChart1.PrintDocument;
                this.printPreviewDialog1.Document = printPreviewDocument;
                this.printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
            }
        }

        /// <summary>
        /// used to print the pivotchart.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = this.pivotChart1.PrintDocument;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pivotChart1.PrintDocument.Print();
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
            this.OtherArea.BackColor = Color.FromArgb(17, 150, 205); //Color.FromArgb(77, 130, 184);
            //this.panel1.BackColor = Color.FromArgb(177, 214, 240);
            this.label1.ForeColor = Color.White;
            this.Text = "PivotChart Print Demo";
            this.label1.Text = "PivotChart Printing";
            this.CaptionForeColor = Color.White;
            this.button1.UseVisualStyle = this.button2.UseVisualStyle = true;
            this.button1.Appearance = this.button2.Appearance = ButtonAppearance.Metro;
            this.button1.MetroColor = this.button2.MetroColor = Color.FromArgb(112, 173, 71);
            this.button1.BackColor = this.button2.BackColor = Color.FromArgb(112, 173, 71);//77, 130, 184);

            //printpreviewdialog
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            printPreviewDocument = new PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pivotChart1.PrintDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            
            //  
            // label
            // 
            this.label = new Label();
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(10, 10);
            this.label.Name = "label1";
            this.label.Size = new System.Drawing.Size(this.button1.Location.X, this.button1.Location.Y-100);
            this.label.TabIndex = 0;
            this.label.TextAlign = ContentAlignment.BottomCenter;
            this.label.ImageAlign = ContentAlignment.TopCenter;
            this.label.ForeColor = Color.White;
            //this.label.Image = global::PivotChartStyles_Demo.Properties.Resources.PrintPreview;
            this.panel1.Controls.Add(this.label);

            this.printView = new Label();
            //this.printView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printView.Location = new System.Drawing.Point(0, 2);
            this.printView.Name = "printView";
            this.printView.Size = new System.Drawing.Size(90, 55);
            this.printView.TextAlign = ContentAlignment.BottomCenter;
            this.printView.ImageAlign = ContentAlignment.TopCenter;
            this.printView.TabIndex = 0;
            this.printView.Text = "";
            this.printView.ForeColor = Color.White;
            this.printView.Image = global::PivotChartPrint_Demo.Properties.Resources.Printing;
            this.OtherArea.Controls.Add(this.printView);
            this.panel1.BackColor = Color.WhiteSmoke;// Color.FromArgb(177, 177, 177);
            this.printView.Click += new EventHandler(printView_Click);
            this.label.Click += new EventHandler(label_Click);
        }

        void label_Click(object sender, EventArgs e)
        {
            
        }

        void printView_Click(object sender, EventArgs e)
        {
        }
        Label label;
        Label printView;
        void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            
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
                                                          panel.ClientSize.Width - thickness,
                                                          panel.ClientSize.Height - thickness));
            }
        }

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

        void OtherArea_Resize(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.Invalidate();
        }

        void panel1_Resize(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.Invalidate();            
        }

        #endregion
    }
}
