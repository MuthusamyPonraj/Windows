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

namespace DrillDown_Demo
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
        }

        #endregion

        #region "PivotChart Settings"

        private void PivotChartSettings()
        {
            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = new DataCollection();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Sex", TotalHeader = "Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Profession", TotalHeader = "Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotLegend to the Control
            //this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Children", TotalHeader = "Total" });
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Age", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Salary", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });

            this.Settings();
            this.label2.Image = global::DrillDown_Demo.Properties.Resources.PivotChart;

            //allows to perform drill down option in pivotchart
            this.pivotChart1.AllowDrillDown = true;
            this.pivotChart1.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
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
        /// <summary>
        /// Custom Data class
        /// </summary>
        public class Data
        {
            #region Constructor
            public Data()
            {
            }
            #endregion

            #region Properties
            public string City { get; set; }

            public string Sex { get; set; }

            public int Age { get; set; }

            public string Profession { get; set; }

            public int Salary { get; set; }

            public string State { get; set; }

            public bool Married { get; set; }

            public int Children { get; set; }

            public int Siblings { get; set; }

            public double CCDebt { get; set; }
            #endregion
        }

        /// <summary>
        /// Custom DataCollection
        /// </summary>
        public class DataCollection : List<Data>
        {
            #region Constructor
            public DataCollection()
            {
                this.GetDataObjects(2000);
            }
            #endregion

            #region GetDataObject
            private void GetDataObjects(int items)
            {
                #region Get the DataSource
                int nRows = items;
                Random r = new Random(1235);

                string[] sexes = new string[] { "Male", "Female" };
                string[] jobs = new string[] { "Doctor", "Engineer"};
                string[] states = new string[] { "Phoenix", "Denver" };
                string[] NCcities = new string[] { "Raleigh", "Charlotte", "Colorado", "New Mexico" };
                string[] GAcities = new string[] { "Augusta", "Albany", "Atlanta" };
                string[] VAcities = new string[] { "Norfolk", "Richmond" ,"Colorado", "New Mexico"};
                string[] SCcities = new string[] { "Clemson", "Colorado", "New Mexico" };

                for (int i = 0; i < nRows; ++i)
                {
                    Data dataObj = new Data();
                    dataObj.City = sexes[r.Next(sexes.GetLength(0))];
                    dataObj.Sex = sexes[r.Next(sexes.GetLength(0))];
                    dataObj.Age = 45 + (i % 2 == 0 ? (i % 6 == 0 ? 3 : 6) : 2);
                    dataObj.Profession = jobs[r.Next(jobs.GetLength(0))];
                    dataObj.Salary = 150 + (int)(r.NextDouble() * 100);
                    dataObj.State = states[r.Next(states.GetLength(0))];
                    int k = "NCSCVAGA".IndexOf(dataObj.State);
                    switch (k)
                    {
                        case 0:
                            dataObj.City = NCcities[r.Next(NCcities.GetLength(0))];
                            break;
                        case 2:
                            dataObj.City = SCcities[r.Next(SCcities.GetLength(0))]; ;
                            break;
                        case 6:
                            dataObj.City = GAcities[r.Next(GAcities.GetLength(0))];
                            break;
                        case 4:
                            dataObj.City = VAcities[r.Next(VAcities.GetLength(0))];
                            break;
                    }
                    dataObj.Married = r.Next(3) == 1;

                    dataObj.Children = (bool)dataObj.Married ? r.Next(6) : 0;

                    dataObj.Siblings = r.Next(7); ;

                    dataObj.CCDebt = ((int)(r.NextDouble() * 2000)) / 100d;

                    this.Add(dataObj);
                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region "OTHER SETTINGS"

        private void Settings()
        {
            this.panel1.Resize += new EventHandler(panel1_Resize);
            this.OtherArea.Resize += new EventHandler(OtherArea_Resize);
            this.panel1.Paint += new PaintEventHandler(panel1_Paint);
            this.OtherArea.Paint += new PaintEventHandler(OtherArea_Paint);

            typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(panel1, true, null);
            typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(panel2, true, null);
            this.checkBox1.Visible = false;
            this.panel1.Padding = new Padding(4);
            this.OtherArea.Padding = new Padding(4);
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

        #endregion
    }
}
