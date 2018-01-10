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
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;

namespace PivotChartStyles_Demo
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
            //this.Load += new EventHandler(Form1_Load);
            this.Settings();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.LoadPivotChart();

            this.LoadComboItems(this.comboBox1);
            this.LoadComboItems(this.comboBox3);
            this.LoadComboItems(this.comboBox4);
            this.LoadComboItems(this.comboBox6);

            this.LoadCombo(this.comboBox2);
            this.LoadCombo(this.comboBox5);
            this.comboBox2.SelectedIndex = this.comboBox5.SelectedIndex = 4;

            //Used to provide metro skin to PivotChart.
            this.pivotChart1.Skins = Skins.Metro;
        }

        #endregion

        #region "PivotChart Settings"

        private void LoadPivotChart()
        {
            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = ProductSales.GetSalesData();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
        }

        #endregion

        #region "Sample Properties Customization"

        /// <summary>
        /// Load the combobox items.
        /// </summary>
        private void LoadCombo(ComboBoxAdv combo)
        {
            combo.Items.Add(DashStyle.Dash);
            combo.Items.Add(DashStyle.DashDot);
            combo.Items.Add(DashStyle.DashDotDot);
            combo.Items.Add(DashStyle.Dot);
            combo.Items.Add(DashStyle.Solid);
            combo.SelectedValueChanged+=new EventHandler(combo_SelectedValueChanged1);
        }
        
        /// <summary>
        /// used to change the dashstyle of the pivotchart.
        /// </summary>
        void combo_SelectedValueChanged1(object sender, EventArgs e)
        {
            ComboBoxAdv combo = sender as ComboBoxAdv;
            Syncfusion.Windows.Forms.PivotChart.PivotChartAxisStyles.PivotChartAxis axis;
            axis = (combo == this.comboBox2) ? this.pivotChart1.PrimaryXAxis : this.pivotChart1.PrimaryYAxis;

            if (combo.SelectedItem.ToString() == DashStyle.Dash.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.Dash;
            }
            else if (combo.SelectedItem.ToString() == DashStyle.DashDot.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.DashDot;
            }
            else if (combo.SelectedItem.ToString() == DashStyle.DashDotDot.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.DashDotDot;
            }
            else if (combo.SelectedItem.ToString() == DashStyle.Dot.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.Dot;
            }
            else if (combo.SelectedItem.ToString() == DashStyle.Solid.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.Solid;
            }
        }

        /// <summary>
        /// used to load the combo box color items.
        /// </summary>
        /// <param name="combo"></param>
        private void LoadComboItems(ComboBoxAdv combo)
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    combo.Items.Add(prop.Name);
            }
            combo.SelectedValueChanged += new EventHandler(combo_SelectedValueChanged);
        }

        /// <summary>
        ///  Selected Axis style changes customization.
        /// </summary>
        void combo_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxAdv combo = sender as ComboBoxAdv;
            if (combo == this.comboBox1)
            {
                Color color = Color.FromName(combo.SelectedItem.ToString());
                this.pivotChart1.PrimaryXAxis.GridLineType.ForeColor = color;
            }
            else if (combo == this.comboBox3)
            {
                Color color = Color.FromName(combo.SelectedItem.ToString());
                this.pivotChart1.PrimaryXAxis.InterlacedGridInterior = new Syncfusion.Drawing.BrushInfo(color);
            }
            else if (combo == this.comboBox4)
            {
                Color color = Color.FromName(combo.SelectedItem.ToString());
                this.pivotChart1.PrimaryYAxis.InterlacedGridInterior = new Syncfusion.Drawing.BrushInfo(color);
            }
            else if (combo == this.comboBox6)
            {
                Color color = Color.FromName(combo.SelectedItem.ToString());
                this.pivotChart1.PrimaryYAxis.GridLineType.ForeColor = color;
            }
        }

        /// <summary>
        /// used to change the interlaced grid settings of primary x-axis.
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.pivotChart1.PrimaryXAxis.InterlacedGrid = this.checkBox1.Checked;
        }

        /// <summary>
        /// used to change the interlaced grid settings of primary y-axis.
        /// </summary>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.pivotChart1.PrimaryYAxis.InterlacedGrid = this.checkBox2.Checked;
        }

        /// <summary>
        /// Basic form settings
        /// </summary>
        private void Settings()
        {
            this.MinimumSize = new Size(1000, 660);
            this.BorderColor = Color.FromArgb(17, 150, 205);
            this.CaptionBarColor = Color.FromArgb(17, 150, 205);
            this.BorderThickness = 6;
            this.CaptionBarHeight = 50;
            this.CaptionFont = new Font("Segoe UI", 14f, FontStyle.Bold);
            this.CaptionForeColor = Color.White;
            this.CaptionButtonColor = Color.White;
            this.CaptionButtonHoverColor = Color.LightGray;
            this.Text = "PivotChart Styles";
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
                string[] countries = new string[] { "Canada", "France", "Germany", "United Kingdom" };
                string[] ausStates = new string[] { "New South Wales", "Queensland", "Tasmania", "Victoria" };
                string[] canadaStates = new string[] { "British Columbia", "Brunswick"};
                string[] franceStates = new string[] { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers", };
                string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg" };
                string[] ukStates = new string[] { "England" };
                string[] ussStates = new string[] { "North Carolina", "Alabama", "California", "Colorado" };

                /// Time
                string[] dates = new string[] { "FY 2006", "FY 2007", "FY 2008" };

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
                    double discount = (300 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
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
        
    }
}
