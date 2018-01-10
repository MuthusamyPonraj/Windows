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
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Reflection;
using Syncfusion.Windows.Forms.PivotChart;

namespace Grouping_Demo
{
    public partial class Form1 : MetroForm
    {
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
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Gender" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Profession" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Salary", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Age", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });

            this.pivotChart1.PivotFilters.Add(new FilterExpression { DimensionHeader = "City", DimensionName = "City" });

            this.OtherSettings();
            this.pivotChart1.AllowDrillDown = true;
            this.pivotChart1.PrimaryXAxis.ZoomFactor = .7;
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

        #region  "Combobx Items"

        private void LoadComboItems(ComboBox combo)
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    if (prop.Name != "Transparent")
                        combo.Items.Add(prop.Name);
                }
            }
            combo.SelectedValueChanged += new EventHandler(combo_SelectedValueChanged);
        }

        #endregion

        #region "Selection Changes"

        PivotFieldsSection section;
        void combo_SelectedValueChanged(object sender, EventArgs e)
        { 
            ComboBox combo = sender as ComboBox;
            if (combo == this.comboBox2)
            {
                Color color = Color.FromName(combo.SelectedItem.ToString());
                section.BackInterior = color;
            }
            else if (combo == this.comboBox5)
            {
                Color color = Color.FromName(combo.SelectedItem.ToString());
                section.ItemBackColor = color;
            }
            else if (combo == this.comboBox6)
            {
                Color color = Color.FromName(combo.SelectedItem.ToString());
                section.ItemForeColor = color;
            }
        }
        #endregion

        #region "Panel Settings"

        void panel2_Paint(object sender, PaintEventArgs e)
        {
            int thickness = 2;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.LightGray, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panel2.ClientSize.Width - thickness-4,
                                                          panel2.ClientSize.Height - thickness));
            }
        }
        void panel1_Resize(object sender, EventArgs e)
        {
            this.panel1.Invalidate();
        }
        void panel3_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        void panel3_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Rectangle rect = panel.ClientRectangle;
            Pen blackPen = new Pen(Color.Gray, 1);
            float[] dashValues = { 2, 2, 2, 2 };
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(0, 2), new Point(rect.Width, 2));
            e.Graphics.DrawLine(blackPen, new Point(0, rect.Height - 2), new Point(rect.Width, rect.Height - 2));
            e.Graphics.DrawLine(blackPen, new Point(0, 2), new Point(0, rect.Height - 3));
            e.Graphics.DrawLine(blackPen, new Point(rect.Width - 2, 2), new Point(rect.Width - 2, rect.Height - 4));
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

            public string Gender { get; set; }

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
                string[] jobs = new string[] { "Doctor", "Teacher", "Engineer"};
                string[] states = new string[] { "New York", "Virginia", "Alaska", "Texas" };
                string[] NCcities = new string[] { "Raleigh", "Charlotte" };
                string[] GAcities = new string[] { "Augusta" };
                string[] VAcities = new string[] { "Norfolk" };
                string[] SCcities = new string[] { "Clemson" };

                for (int i = 0; i < nRows; ++i)
                {
                    Data dataObj = new Data();
                    dataObj.City = sexes[r.Next(sexes.GetLength(0))];
                    dataObj.Gender = sexes[r.Next(sexes.GetLength(0))];
                    dataObj.Age = r.Next(45) + 20;
                    dataObj.Profession = jobs[r.Next(jobs.GetLength(0))];
                    dataObj.Salary = 15000 + (int)(r.NextDouble() * 1000);
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

        #region "Other Settings"

        private void OtherSettings()
        {
            typeof(Panel).GetProperty("DoubleBuffered",
                          BindingFlags.NonPublic | BindingFlags.Instance)
             .SetValue(panel1, true, null);
            typeof(Panel).GetProperty("DoubleBuffered",
                         BindingFlags.NonPublic | BindingFlags.Instance)
            .SetValue(panel2, true, null);
            this.panel2.Paint += new PaintEventHandler(panel2_Paint);
            this.pivotChart1.AxisFieldSection.Visible = this.pivotChart1.LegendFieldSection.Visible = this.pivotChart1.ValueFieldSection.Visible =
            this.pivotChart1.FilterFieldSection.Visible = true;
            this.pivotChart1.ChartArea.BorderWidth = 1;
            this.panel1.Padding = new Padding(6);
            this.Legend.Image = global::Grouping_Demo.Properties.Resources.axis18;
            this.Filter.Image = global::Grouping_Demo.Properties.Resources.filter18;
            this.Values.Image = global::Grouping_Demo.Properties.Resources.values18;
            this.Axis.Image = global::Grouping_Demo.Properties.Resources.legend18;
            this.LoadComboItems(this.comboBox2);
            this.LoadComboItems(this.comboBox5);
            this.LoadComboItems(this.comboBox6);
            section = this.pivotChart1.AxisFieldSection;
            this.panel1.Visible = false;
            this.comboBox2.SelectedItem = this.comboBox6.SelectedItem = "White";
            this.panel3.BackColor = Color.WhiteSmoke;
            this.panel3.Resize += new EventHandler(panel3_Resize);
            this.panel2.Paint += new PaintEventHandler(panel2_Paint);
            this.panel1.Paint += new PaintEventHandler(panel1_Paint);
            this.panel1.Resize += new EventHandler(panel1_Resize);
        }
        #endregion
    }
}
