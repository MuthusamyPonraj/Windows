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
using System.Text;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace PivotGridDemo
{
    public partial class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Timer timer;
        SolidBrush leftRectBrush = new SolidBrush(ColorTranslator.FromHtml("#1BA1E2"));
        private Label headerLabel1;
        private Label headerLabel2;
        SolidBrush grayBrush = new SolidBrush(Color.LightGray);
        private int colorBrushNo = 0;
        private bool sizeIncreased = false;
        Button button;

        #endregion

        #region "Constructor"
        public Form1()
        {
            InitializeComponent();
            GridSettings();
        }

        #endregion

        #region "Grid Settings"
        /// <summary>
        /// Add the Calculations and Rows for pivot Grid
        /// </summary>
        private void GridSettings()
        {
            // Adding ItemSource to the Control
            this.pivotGridControl1.ItemSource = ProductSales.GetSalesData();

            this.pivotGridControl1.RowPivotsOnly = true;

            // Adding PivotRows to the Control
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Country" });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0", AllowSort = true });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "UnitPrice", FieldHeader = "Unit Price" });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "TotalPrice" ,FieldHeader = "Total Price" });
            this.pivotGridControl1.TableControl.DefaultColWidth = 100;
            this.RowPivotsOnlyApperance();

            //tab key navigation set as false to move the next control
            this.pivotGridControl1.TableControl.WantTabKey = false;
            this.pivotGridControl1.TableControl.PivotTableFieldList.WantTabKey = false;
            this.pivotGridControl1.TableControl.GridColumnList.WantTabKey = false;
            this.pivotGridControl1.TableControl.GridFilterList.WantTabKey = false;
            this.pivotGridControl1.TableControl.GridRowList.WantTabKey = false;
            this.pivotGridControl1.TableControl.GridValueList.WantTabKey = false;
            this.pivotGridControl1.PivotSchemaDesigner.TabStop = false;
            this.pivotGridControl1.TabStop = false;

        }
        #endregion

        #region "Sample Appearance"

        /// <summary>
        /// Set the Apperance for rows
        /// </summary>
        private void RowPivotsOnlyApperance()
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.checkBox1.Visible = true;
            this.checkBox2.Visible = true;
            this.checkBox3.Visible = true;
            this.checkBox4.Visible = true;
            this.checkBox5.Visible = true;
            this.button1.Image = Image.FromFile(GetIconFile(@"..\\..\\sortasc.png"));
            this.button2.Image = Image.FromFile(GetIconFile(@"..\\..\\filter2010.png"));
            this.button3.Image = Image.FromFile(GetIconFile(@"..\\..\\ReloadData.png"));
            this.button4.Image = Image.FromFile(GetIconFile(@"..\\..\\ShowFieldList.png"));
            this.button5.Image = Image.FromFile(GetIconFile(@"..\\..\\col.png"));

            for (int i = 0; i < this.groupBox1.Controls.Count;i++ )
            {
                if (this.groupBox1.Controls[i] is Button)
                {
                    Button button = this.groupBox1.Controls[i] as Button;
                    button.MouseLeave += new EventHandler(button_MouseLeave);
                    button.MouseEnter += new EventHandler(button_MouseEnter);
                }
                if (this.groupBox1.Controls[i] is CheckBox)
                {
                    CheckBox checkBox = this.groupBox1.Controls[i] as CheckBox;
                    checkBox.MouseLeave += new EventHandler(checkBox_MouseLeave);
                    checkBox.MouseEnter += new EventHandler(checkBox_MouseEnter);
                }
                if (this.groupBox1.Controls[i] is Label)
                {
                    Label label = this.groupBox1.Controls[i] as Label;
                    label.MouseEnter += new EventHandler(label_MouseEnter);
                }
            }            
            this.timer = new Timer();
            this.timer.Interval = 1000000;
            this.timer.Enabled = true;
            this.animationPanel.Paint += new PaintEventHandler(animationPanel_Paint);
            headerLabel1 =new Label();
            headerLabel2 =new Label();
            headerLabel1.AutoSize = false;
            headerLabel2.AutoSize = false;
            headerLabel1.Location = new Point(this.animationPanel.Location.X + 20, this.animationPanel.Location.Y - 8 );
            headerLabel2.Location = new Point(this.animationPanel.Location.X + 20, this.animationPanel.Location.Y - 8 );
            headerLabel1.Size = new Size(135, 30);
            this.animationPanel.Controls.Add(headerLabel1);
            this.animationPanel.Controls.Add(headerLabel2);
            this.headerLabel1.Text = "RowPivots Only Mode";
            this.headerLabel1.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.animationPanel.MouseClick += new MouseEventHandler(animationPanel_MouseClick);
            this.animationPanel.MouseMove += new MouseEventHandler(animationPanel_MouseMove);
            this.checkBox1.CheckState = CheckState.Checked;
            this.checkBox2.CheckState = CheckState.Checked;
            this.checkBox3.CheckState = CheckState.Checked;
            this.checkBox4.CheckState = CheckState.Checked;
            this.checkBox5.CheckState = CheckState.Checked;
            this.MaximizeBox = true;
        }

        /// <summary>
        /// Set the Text for Context Label
        /// </summary>
        void label_MouseEnter(object sender, EventArgs e)
        {
            Control control = this.groupBox1.GetChildAtPoint(new Point(((Label)sender).Location.X - 10, ((Label)sender).Location.Y));
            this.animateText();
            //if (control is Button)
            {
                this.headerLabel1.Text = ((Label)sender).Text;
                if (((Label)sender) == this.label1)
                {
                    colorBrushNo = 1;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#5CBB00");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#Sorting support can be enabled or disabled in RowPivotsOnly mode by using the AllowSort property";
                }
                else if (((Label)sender) == this.label2)
                {
                    colorBrushNo = 2;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#00A4E5");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#Filtering support can be enabled or disbaled in the PivotCalculation columns of the PivotGrid by using the AllowFilter property";
                }
                else if (((Label)sender) == this.label3)
                {
                    colorBrushNo = 3;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#FF4815");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#The PivotCalculation headers has been supported with drag drop operation in RowPivotsOnly mode";
                }
                else if (((Label)sender) == this.label4)
                {
                    colorBrushNo = 4;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#FFB800");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#PivotSchemaDesginer has been customized as per the RowPivotsOnly mode, i.e: PivotColumns and ReportFilter field will not be customizable";
                }
                else if (((Label)sender) == this.label5)
                {
                    colorBrushNo = 5;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#6BD4E7");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#PivotValueChooser will display the PivotCalculation columns in a popup, where the necessary columns can be made shown/hidden";
                }
                this.animationPanel.Refresh();
            }
        }

        /// <summary>
        /// Handling the Mouse Cursor
        /// </summary>
        void animationPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point loc = this.animationPanel.Location;
            if (new Rectangle(loc.X + 40, loc.Y + 220, 50, 8).Contains(e.Location))
            {
                this.Cursor = Cursors.Hand;
            }
            else
                this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Animate the text
        /// </summary>
        private void animateText()
        {
            for (int x = 0; x < 120; x++)
            {
                this.contextLabel1.Location = new Point(this.animationPanel.Location.X + 10 + x, this.animationPanel.Location.Y + 40);
            }
            for (int x = 0; x < 110; x += 3)
            {
                this.contextLabel1.Location = new Point(this.animationPanel.Location.X + 120 - x, this.animationPanel.Location.Y + 40);
            }
        }

        /// <summary>
        ///  Animate the text by Mouse
        /// </summary>
        void animationPanel_MouseClick(object sender, MouseEventArgs e)
        {
            
            Point loc = this.animationPanel.Location;
            if (new Rectangle(loc.X + 40, loc.Y + 220, 8, 8).Contains(e.Location))
            {
                this.animateText();
                colorBrushNo = 1;
                this.headerLabel1.Text = this.checkBox1.Text;
                leftRectBrush.Color = ColorTranslator.FromHtml("#5CBB00");
                this.contextLabel1.Text = "#Sorting support can be enabled or disabled in RowPivotsOnly mode by using the AllowSort property";     
            }
            else if (new Rectangle(loc.X + 50, loc.Y + 220, 8, 8).Contains(e.Location))
            {
                this.animateText();
                colorBrushNo = 2;
                this.headerLabel1.Text = this.checkBox2.Text;
                leftRectBrush.Color = ColorTranslator.FromHtml("#00A4E5");
                this.contextLabel1.Text = "#Filtering support can be enabled or disbaled in the PivotCalculation columns of the PivotGrid by using the AllowFilter property";
            }
            else if (new Rectangle(loc.X + 60, loc.Y + 220, 8, 8).Contains(e.Location))
            {
                this.animateText();
                colorBrushNo = 3;
                this.headerLabel1.Text = this.checkBox3.Text;
                leftRectBrush.Color = ColorTranslator.FromHtml("#FF4815");
                this.contextLabel1.Text = "#The PivotCalculation headers has been suppoerted with drag drop operation in RowPivotsOnly mode";
            }
            else if (new Rectangle(loc.X + 70, loc.Y + 220, 8, 8).Contains(e.Location))
            {
                this.animateText();
                colorBrushNo = 4;
                this.headerLabel1.Text = this.checkBox4.Text;
                leftRectBrush.Color = ColorTranslator.FromHtml("#FFB800");
                this.contextLabel1.Text = "#PivotSchemaDesginer has been customized as per the RowPivotsOnly mode, i.e: PivotColumns and ReportFilter field will not be customizable";            
            }
            else if (new Rectangle(loc.X + 80, loc.Y + 220, 8, 8).Contains(e.Location))
            {
                this.animateText();
                colorBrushNo = 5;
                this.headerLabel1.Text = this.checkBox5.Text;
                leftRectBrush.Color = ColorTranslator.FromHtml("#6BD4E7");
                this.contextLabel1.Text = "#PivotValueChooser will display the PivotCalculation columns in a popup, where the necessary columns can be made shown/hidden";
            }
            this.animationPanel.Refresh();
        }

        /// <summary>
        /// Animate the pivot panel
        /// </summary>
        void animationPanel_Paint(object sender, PaintEventArgs e)
        {
            Point loc = this.animationPanel.Location;
            Pen rectPen = new Pen(Color.LightGray);
            Rectangle rect = new Rectangle(loc.X + 5, loc.Y - 15, loc.X + 150, loc.Y + 20);
            e.Graphics.DrawRectangle(rectPen, rect);

            Rectangle leftRectBorder = new Rectangle(loc.X + 5, loc.Y - 15, 7, loc.Y + 21);
            e.Graphics.FillRectangle(leftRectBrush, leftRectBorder);

            e.Graphics.FillEllipse(colorBrushNo == 1 ? leftRectBrush : grayBrush, loc.X + 40, loc.Y + 220, 8, 8);
            e.Graphics.FillEllipse(colorBrushNo == 2 ? leftRectBrush : grayBrush, loc.X + 50, loc.Y + 220, 8, 8);
            e.Graphics.FillEllipse(colorBrushNo == 3 ? leftRectBrush : grayBrush, loc.X + 60, loc.Y + 220, 8, 8);
            e.Graphics.FillEllipse(colorBrushNo == 4 ? leftRectBrush : grayBrush, loc.X + 70, loc.Y + 220, 8, 8);
            e.Graphics.FillEllipse(colorBrushNo == 5 ? leftRectBrush : grayBrush, loc.X + 80, loc.Y + 220, 8, 8);
        }

        /// <summary>
        /// Animate the pivot when Mouse Enter
        /// </summary>
        void checkBox_MouseEnter(object sender, EventArgs e)
        {
            Control control = this.groupBox1.GetChildAtPoint(new Point(((CheckBox)sender).Location.X - 10, ((CheckBox)sender).Location.Y));
            this.animateText();
            //if (control is Button)
            {
                this.headerLabel1.Text = ((CheckBox)sender).Text;
                if (((CheckBox)sender) == this.checkBox1)
                {
                    colorBrushNo = 1;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#5CBB00");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#Sorting support can be enabled or disabled in RowPivotsOnly mode by using the AllowSort property";
                }
                else if (((CheckBox)sender) == this.checkBox2)
                {
                    colorBrushNo = 2;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#00A4E5");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#Filtering support can be enabled or disbaled in the PivotCalculation columns of the PivotGrid by using the AllowFilter property";
                }
                else if (((CheckBox)sender) == this.checkBox3)
                {
                    colorBrushNo = 3;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#FF4815");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#The PivotCalculation headers has been supported with drag drop operation in RowPivotsOnly mode";
                }
                else if (((CheckBox)sender) == this.checkBox4)
                {
                    colorBrushNo = 4;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#FFB800");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#PivotSchemaDesginer has been customized as per the RowPivotsOnly mode, i.e: PivotColumns and ReportFilter field will not be customizable";
                }
                else if (((CheckBox)sender) == this.checkBox5)
                {
                    colorBrushNo = 5;
                    leftRectBrush.Color = ColorTranslator.FromHtml("#6BD4E7");
                    this.contextLabel1.ForeColor = Color.Black;
                    this.contextLabel1.Text = "#PivotValueChooser will display the PivotCalculation columns in a popup, where the necessary columns can be made shown/hidden";
                }
                this.animationPanel.Refresh();
            }
        }

        /// <summary>
        /// Handling the size
        /// </summary>
        void checkBox_MouseLeave(object sender, EventArgs e)
        {
            if (!sizeIncreased)
            {
                //button.Size = new Size(button.Size.Width + 4, button.Height + 4);
                //button.Location = new Point(button.Location.X - 2, button.Location.Y - 2);
                sizeIncreased = true;
            }
            else
            {
                //button.Size = new Size(button.Size.Width - 4, button.Size.Height - 4);
                //button.Location = new Point(button.Location.X + 2, button.Location.Y + 2);
                sizeIncreased = false;
            }
        }

        /// <summary>
        /// Handling size When Mouse enter
        /// </summary>
        void button_MouseEnter(object sender, EventArgs e)
        {
            button = sender as Button; 
            if (!sizeIncreased)
            {
                //button.Size = new Size(button.Size.Width + 4, button.Height + 4);
                //button.Location = new Point(button.Location.X - 2, button.Location.Y - 2);
                sizeIncreased = true;
            }
            timer.Start();           
        }

        /// <summary>
        /// Handling When mouse leave
        /// </summary>
        void button_MouseLeave(object sender, EventArgs e)
        {
            timer.Stop();
            if (sizeIncreased)
            {
                //button.Size = new Size(button.Size.Width - 4, button.Size.Height - 4);
                //button.Location = new Point(button.Location.X + 2, button.Location.Y + 2);
                sizeIncreased = false;
            }
        }

        #endregion

        #region "Icon"

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

        #region "DataSource"

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

            /// <summary>
            /// Generate a data for DataSource
            /// </summary>
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
                string[] dates = new string[] { "FY 2005", "FY 2007", "FY 2006", "FY 2009", "FY 2008" };

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

        #region "Events"

        //Handling the sorting for pivot grid 
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.pivotGridControl1.AllowSorting = true;
            }
            else
            {
                this.pivotGridControl1.AllowSorting = false;
            }
        }

        //Handling the Filter for pivot
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.TableControl.AllowRowPivotFiltering = this.checkBox2.Checked;
            this.pivotGridControl1.TableControl.Refresh();
        }

        //Handling the pivot Drag
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.AllowRowPivotDrag = this.checkBox3.Checked;          
        }

        //Handling the Table field list display
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowPivotTableFieldList = this.checkBox4.Checked;
        }

        //Handling the pivot vale chooser
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowPivotValueChooser = this.checkBox5.Checked;
        }

        #endregion
    }
}
