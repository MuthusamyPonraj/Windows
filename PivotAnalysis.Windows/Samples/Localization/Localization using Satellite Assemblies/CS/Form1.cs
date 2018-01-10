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
using System.Runtime.InteropServices;
using System.Threading;
using Syncfusion.Windows.Forms.PivotAnalysis;
using DemoCommon.Grid;

namespace WindowsFormsApplication11
{
    public partial class Form1 : GridDemoForm
    {
        #region "Window Updates"

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);

        #endregion

        #region "Constructor"

        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
            InitializeComponent();
            GridSettings();           
        }

        #endregion

        #region "GridSettings"

        //// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            LocalizationProvider.Provider = new Localizer();

            this.pivotGridControl1.ItemSource = ProductSales.GetSalesData();

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", FieldHeader = "Menge", TotalHeader = "Total" });

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", FieldHeader = "land", TotalHeader = "Total" });

            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", FieldHeader = "Menge", Format = "C", SummaryType = SummaryType.DoubleTotalSum });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", FieldHeader = "Quantitie", Format = "#,##0" });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "UnitPrice", FieldHeader = "Einzelpreis" });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "TotalPrice", FieldHeader = "Gesamtpreis" });
            this.pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridControl1.ShowPivotTableFieldList = true;

            //tab key navigation set as false to move the next control
            this.pivotGridControl1.TableControl.WantTabKey = false;
            this.pivotGridControl1.TableControl.PivotTableFieldList.WantTabKey = false;
            this.pivotGridControl1.TableControl.GridColumnList.WantTabKey = false;
            this.pivotGridControl1.TableControl.GridFilterList.WantTabKey = false;
            this.pivotGridControl1.TableControl.GridRowList.WantTabKey = false;
            this.pivotGridControl1.TableControl.GridValueList.WantTabKey = false;
            this.pivotGridControl1.PivotSchemaDesigner.TabStop = false;
            this.pivotGridControl1.TabStop = false;

            label1.Text = "Der Ort ist durch Satelliten-Assemblies in dieser Probe erreicht.Die Saiten sind aus den Satelliten assemly DLLs erhalten.\n";
            label1.Text += "können unsere eigenen Ressourcen-Datei mit den Änderungen und erstellen die Satelliten-DLL, durch die wir die Saiten zu lokalisieren.";
            label1.BorderStyle = BorderStyle.None;
            label1.ForeColor = Color.Blue;

            string targetPath = Application.StartupPath + "\\" + "de-DE";
            string sourceFile = System.IO.Path.GetFullPath("..\\..\\de-DE\\Syncfusion.PivotAnalysis.Windows.resources.dll");
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
                System.IO.File.Copy(sourceFile, targetPath + "\\Syncfusion.PivotAnalysis.Windows.resources.dll");

                sourceFile = System.IO.Path.GetFullPath("..\\..\\de-DE\\run.bat");
                System.IO.File.Copy(sourceFile, targetPath + "\\run.bat");
            }
            LocalizationProvider.Provider = new Localizer();
            Localizer loc = new Localizer();
            LocalizationProvider.Provider = loc;
        }

        #endregion

        #region "DataSource"

        #region "product sales class"

        public class ProductSales
        {
            #region "API Definition"

            public string Product { get; set; }

            public string Date { get; set; }

            public string Country { get; set; }

            public string State { get; set; }

            public int Quantity { get; set; }

            public double Amount { get; set; }

            public double UnitPrice { get; set; }

            public double TotalPrice { get; set; }

            #endregion

            /// <summary>
            /// Data collections for Data Source
            /// </summary>
            /// <returns></returns>
            public static ProductSalesCollection GetSalesData()
            {

                /// Geography
                string[] countries = new string[] { "Australien", "Kanada", "Frankreich", "Deutschland", "Vereinigtes Königreich", "Vereinigte Staaten" };
                string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
                string[] canadaStates = new string[] { "Albertaien", "Britisch-Kolumbien", "Braunschweig", "Manitoba", "Ontario", "Quebec" };
                string[] franceStates = new string[] { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers", };
                string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland" };
                string[] ukStates = new string[] { "England" };
                string[] ussStates = new string[] { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

                /// Time
                string[] dates = new string[] { "Geschäf 2005", "Geschäf  2006", "Geschäf  2007", "Geschäf  2008", "Geschäf  2009" };

                /// Products

                string[] products = new string[] { "Fahrrad", "Auto" };

                Random r = new Random(123345345);

                int numberOfRecords = 2000;

                ProductSalesCollection listOfProductSales = new ProductSalesCollection();

                for (int i = 0; i < numberOfRecords; i++)
                {

                    ProductSales sales = new ProductSales();
                    sales.Country = countries[r.Next(1, countries.GetLength(0))];
                    sales.Quantity = r.Next(1, 12);

                    /// 1 percent discount for 1 quantity
                    double discount = (3000 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
                    sales.Amount = (3000 * sales.Quantity) - discount;
                    sales.TotalPrice = sales.Amount * sales.Quantity;
                    sales.UnitPrice = sales.Amount / sales.Quantity;
                    sales.Date = dates[r.Next(r.Next(dates.GetLength(0) + 1))];
                    sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                    switch (sales.Country)
                    {
                        case "Australien":
                            {
                                sales.State = ausStates[r.Next(ausStates.GetLength(0))];
                                break;
                            }
                        case "Kanada":
                            {
                                sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                                break;
                            }
                        case "Frankreich":
                            {
                                sales.State = franceStates[r.Next(franceStates.GetLength(0))];
                                break;
                            }
                        case "Deutschland":
                            {
                                sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                                break;
                            }
                        case "Vereinigtes Königreich":
                            {
                                sales.State = ukStates[r.Next(ukStates.GetLength(0))];
                                break;
                            }
                        case "Vereinigte Staaten":
                            {
                                sales.State = ussStates[r.Next(ussStates.GetLength(0))];
                                break;
                            }
                    }
                    listOfProductSales.Add(sales);
                }

                return listOfProductSales;
            }

            /// <summary>
            /// return the string format 
            /// </summary>
            public override string ToString()
            {
                return string.Format("{0}-{1}-{2}", this.Country, this.State, this.Product);
            }

            public class ProductSalesCollection : List<ProductSales>
            {

            }

        }
        #endregion

        #endregion

        #region "Events"

        /// <summary>
        /// Suspand,Resume the pivotgrid
        /// </summary>
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.SuspendLayout();
            this.pivotGridControl1.ResumeLayout(true);
            this.pivotGridControl1.Refresh();
        }

        /// <summary>
        /// Handling the PivoGrig RightTOLeft
        /// </summary>
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            if (this.checkBoxAdv2.Checked)
            {
                this.pivotGridControl1.RightToLeft = RightToLeft.Yes;
            }
            else
                this.pivotGridControl1.RightToLeft = RightToLeft.No;
            LockWindowUpdate(IntPtr.Zero);
            this.pivotGridControl1.TableControl.Refresh();
            this.pivotGridControl1.PivotSchemaDesigner.Refresh();
            this.pivotGridControl1.Refresh();
        }

        #endregion
    }
}
