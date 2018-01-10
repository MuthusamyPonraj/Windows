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

namespace IEnumerable_Demo
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
            this.LoadOtherSettings();
            this.PivotChartSettings();
        }
        #endregion

        #region "PivotChart Settings"

        private void PivotChartSettings()
        {
            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = new DataCollection();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Sex" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Profession" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "City", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Salary", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });
            this.pivotChart1.EnableXZooming = true;
            this.pivotChart1.PrimaryXAxis.ZoomFactor = .7;
            this.pivotChart1.AllowDrillDown = true;
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
                Random r = new Random(123345345);

                string[] sexes = new string[] { "Male", "Female" };
                string[] jobs = new string[] { "Doctor", "Teacher", "Engineer", "Programmer" };
                string[] states = new string[] { "NC", "SC", "GA", "VA" };
                string[] NCcities = new string[] { "Raleigh", "Charlotte"};
                string[] GAcities = new string[] { "Augusta" };
                string[] VAcities = new string[] { "Norfolk"};
                string[] SCcities = new string[] { "Clemson"};

                for (int i = 0; i < nRows; ++i)
                {
                    Data dataObj = new Data();
                    dataObj.City = sexes[r.Next(sexes.GetLength(0))];
                    dataObj.Sex = sexes[r.Next(sexes.GetLength(0))];
                    dataObj.Age = r.Next(45) + 20;
                    dataObj.Profession = jobs[r.Next(jobs.GetLength(0))];
                    dataObj.Salary = 15000 + (int)(r.NextDouble() * 100000);
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

                    dataObj.CCDebt = ((int)(r.NextDouble() * 2000000)) / 100d;

                    this.Add(dataObj);
                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region "OTHERSETTINGS"

        private void LoadOtherSettings()
        {
            this.panel1.Paint += new PaintEventHandler(panel1_Paint);
            this.panel3.Paint += new PaintEventHandler(panel3_Paint);
            this.panel1.Resize += new EventHandler(panel1_Resize);
            this.panel3.Resize += new EventHandler(panel3_Resize);
            this.panel1.Padding = new Padding(2);
            this.panel3.Padding = new Padding(2);
            this.label2.BackColor = Color.FromArgb(17, 150, 205);
            this.label4.BackColor = Color.FromArgb(17, 150, 205);
            this.panel3.BackColor = Color.FromArgb(17, 150, 205);
            this.label2.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label1.ForeColor = Color.White;
            this.BorderColor = Color.FromArgb(17, 150, 205);
            this.BorderThickness = 2;
            this.label4.TextAlign = ContentAlignment.MiddleLeft;
        }

        void panel3_Resize(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.Invalidate();            
        }

        void panel1_Resize(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.Invalidate();
        }

        void panel3_Paint(object sender, PaintEventArgs e)
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

        #endregion
    }
}
