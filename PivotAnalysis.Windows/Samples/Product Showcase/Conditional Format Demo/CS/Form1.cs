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
using Syncfusion.Windows.Forms.PivotAnalysis;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;

namespace ConditionalFormattingDemo
{
    public partial class Form1 : GridDemoForm
    {
        #region "API Definition"

        bool load = true;

        #endregion

        #region "Constructor"

        public Form1()
        {
            InitializeComponent();

            this.settings();
            this.GridSetting();
        }

        #endregion

        #region "GridSettings"

        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSetting()
        {
            this.Load += new EventHandler(Form1_Load);
            this.grdRuleType.Grid.SupportsPrepareViewStyleInfo = false;
            this.grdRuleType.Grid.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.grdDropDown.Grid.Click += new EventHandler(Grid_Click);
            this.grdRuleType.Grid.Click += new EventHandler(Grid1_Click);
            CommonCombobox();

            //tab key navigation set as false to move the next control
            this.pivotGridControl1.TableControl.WantTabKey = false;
        }

        #endregion

        #region "GridList - Data Table"

        /// <summary>
        /// Generate a Data Table for DataSource
        /// </summary>
        private DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");

            dt.Rows.Add(0, "3-Triangle");
            dt.Rows.Add(1, "3-TrafficLightsUnrimmed");
            dt.Rows.Add(2, "3-TrafficLightsrimmed");
            dt.Rows.Add(3, "3-SymbolsUnCircled");
            dt.Rows.Add(4, "3-Symbols");
            dt.Rows.Add(5, "3-Stars");
            dt.Rows.Add(6, "3-Signs");
            dt.Rows.Add(7, "RedToBlack");
            dt.Rows.Add(8, "4-Rating");
            dt.Rows.Add(9, "4-ArrowsGray");
            dt.Rows.Add(10, "4-TrafficLight");
            dt.Rows.Add(11, "4-ArrowsColored");
            dt.Rows.Add(12, "5-ArrowsColored");
            dt.Rows.Add(13, "5-ArrowsGray");
            dt.Rows.Add(14, "5-Boxes");
            dt.Rows.Add(15, "5-Quarters");
            dt.Rows.Add(16, "5-Ratings");
            return dt;
        }

        #endregion

        #region "DataSource"

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
            /// Make a data Data Source
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
                string[] dates = new string[] { "FY 2005", "FY 2006", "FY 2007", "FY 2008", "FY 2009" };

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

        #region "Setup-PivotGrid"

        /// <summary>
        /// Add the Rows and Columns for pivotGrid
        /// </summary>
        private void settings()
        {
            pivotGridControl1.TableModel.BeginUpdate();
            // Adding ItemSource to the Control
            this.pivotGridControl1.ItemSource = ProductSales.GetSalesData();

            // Adding PivotRows to the Control
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotColumns to the Control
            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
            pivotGridControl1.TableModel.EndUpdate(true);
        }
        #endregion

        #region "Conditonal Formatting Customization"

        #region "Bitmap Image"

        /// <summary>
        /// Set the BitmapImage
        /// </summary>
        private BitMapImageName SetImageName(string str)
        {
            switch (str)
            {
                case "3-Flag":
                    return BitMapImageName.ThreeFlags;
                case "3-Triangle":
                    return BitMapImageName.ThreeTriangle;
                case "3-ArrowsColored":
                    return BitMapImageName.ThreeArrowsColored;
                case "3-TrafficLightsUnrimmed":
                    return BitMapImageName.ThreeTrafficLightsUnrimmed;
                case "3-TrafficLightsrimmed":
                    return BitMapImageName.ThreeTrafficLightsRimmed;
                case "3-SymbolsUnCircled":
                    return BitMapImageName.ThreeSymbolsUnCircled;
                case "3-Symbols":
                    return BitMapImageName.ThreeSymbols;
                case "3-Stars":
                    return BitMapImageName.ThreeStars;
                case "3-Signs":
                    return BitMapImageName.ThreeSigns;
                case "3-ArrowsGray":
                    return BitMapImageName.ThreeArrowsGray;
                case "RedToBlack":
                    return BitMapImageName.RedToBlack;
                case "4-Rating":
                    return BitMapImageName.FourRating;
                case "4-ArrowsGray":
                    return BitMapImageName.FourArrowsGray;
                case "4-TrafficLight":
                    return BitMapImageName.FourTrafficLight;
                case "4-ArrowsColored":
                    return BitMapImageName.FourArrowsColored;
                case "5-ArrowsColored":
                    return BitMapImageName.FiveArrowsColored;
                case "5-ArrowsGray":
                    return BitMapImageName.FiveArrowsGray;
                case "5-Boxes":
                    return BitMapImageName.FiveBoxes;
                case "5-Quarters":
                    return BitMapImageName.FiveQuarters;
                case "5-Ratings":
                    return BitMapImageName.FiveRatings;
                default:
                    return BitMapImageName.ThreeTrafficLightsUnrimmed;
            }
        }

        #endregion

        /// <summary>
        /// Enable the label and text based on the type
        /// </summary>
        private void SetConditionalValue(string type)
        {
            if (type.Equals("Between"))
            {
                lblRule2And.Enabled = true;
                txtRule2EndValue.Enabled = true;
            }
            else
            {
                lblRule2And.Enabled = false;
                txtRule2EndValue.Enabled = false;
            }
        }

        /// <summary>
        /// Set the Default value based on the getting Values
        /// </summary>
        private void SetDefaultValue(string type)
        {
            switch (type)
            {
                case "Three":
                    txtValue1.Text = "67";
                    txtValue2.Text = "33";

                    txtValue3.Text = string.Empty;
                    txtValue4.Text = string.Empty;
                    cboValueType3.SelectedIndex = -1;
                    cboValueType4.SelectedIndex = -1;

                    txtValue3.Enabled = false;
                    txtValue4.Enabled = false;
                    cboValueType3.Enabled = false;
                    cboValueType4.Enabled = false;
                    break;
                case "Four":
                    txtValue1.Text = "75";
                    txtValue2.Text = "50";
                    txtValue3.Text = "25";

                    txtValue3.Enabled = true;
                    cboValueType3.Enabled = true;

                    txtValue4.Text = string.Empty;
                    cboValueType4.SelectedIndex = -1;
                    txtValue4.Enabled = false;
                    cboValueType4.Enabled = false;
                    break;
                case "Five":
                    txtValue1.Text = "80";
                    txtValue2.Text = "60";
                    txtValue3.Text = "40";
                    txtValue4.Text = "20";
                    cboValueType3.SelectedIndex = 0;
                    cboValueType4.SelectedIndex = 0;
                    txtValue3.Enabled = true;
                    txtValue4.Enabled = true;
                    cboValueType3.Enabled = true;
                    cboValueType4.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// Select the Image
        /// </summary>
        /// <param name="val"></param>
        private void imageSelection(int val)
        {
            if (!load)
                this.cboRule1ImageName.TextBox.Text = this.grdDropDown.SelectedItem.ToString();
            load = false;
            if (val <= 7)
                SetDefaultValue("Three");
            if (val <= 12 && val > 7)
                SetDefaultValue("Four");
            if (val > 12)
                SetDefaultValue("Five");
        }

        /// <summary>
        /// Set the Format based on getting value
        /// </summary>>
        private RuleType SetRuleType(string str)
        {
            switch (str)
            {
                case "Format Only Cells That Contain":
                    return RuleType.FormatOnlyCellsThatContain;
                case "Format Top Or Bottom Ranked Values":
                    return RuleType.FormatTopOrBottomRankedValues;
                case "Format Only Values That Are Above Or Below Average":
                    return RuleType.FormatOnlyValuesThatAreAboveOrBelowAverage;
                case "Format Only Unique Or Duplicate Values":
                    return RuleType.FormatOnlyUniqueOrDuplicateValues;
                default:
                    return RuleType.FormatAllCellsBasedOnTheirValues;
            }
        }

        /// <summary>
        /// Set the predicate type
        /// </summary>
        private PredicateType SetPredicateType(string predicate)
        {
            switch (predicate)
            {
                case "Or":
                    return PredicateType.Or;
                default:
                    return PredicateType.And;
            }
        }

        /// <summary>
        /// set the format value based on Rank type
        /// </summary>
        private FormateValuesRankType SetFormateValuesRankType(string FormateRankType)
        {
            switch (FormateRankType)
            {
                case "Bottom":
                    return FormateValuesRankType.Bottom;
                default:
                    return FormateValuesRankType.Top;
            }
        }

        /// <summary>
        /// Set the ConditionalType
        /// </summary>
        private PivotGridDataConditionType SetConditionalType(string conditional)
        {
            switch (conditional)
            {                
                case "NotEquals":
                    return PivotGridDataConditionType.NotEquals;
                case "LessThan":
                    return PivotGridDataConditionType.LessThan;
                case "LessThanOrEqual":
                    return PivotGridDataConditionType.LessThanOrEqual;
                case "GreaterThan":
                    return PivotGridDataConditionType.GreaterThan;
                case "GreaterThanOrEqual":
                    return PivotGridDataConditionType.GreaterThanOrEqual;
                case "Between":
                    return PivotGridDataConditionType.Between;
                default:
                    return PivotGridDataConditionType.Equals;
            }
        }

        /// <summary>
        /// Set the Format to Selected Average Value Type
        /// </summary>
        private FormateSelectedAverageValueType SetFormateSelectedAverageValueType(string FormateSelectedAverageValue)
        {
            switch (FormateSelectedAverageValue)
            {
                case "Above":
                    return FormateSelectedAverageValueType.Above;
                case "Below":
                    return FormateSelectedAverageValueType.Below;
                case "EqualOrBelow":
                    return FormateSelectedAverageValueType.EqualOrBelow;
                default:
                    return FormateSelectedAverageValueType.EqualOrAbove;
            }
        }

        /// <summary>
        /// Set the format for all type
        /// </summary>
        private FormatAllType SetFormatAllType(string FormatType)
        {
            switch (FormatType)
            {
                case "Duplicate":
                    return FormatAllType.Duplicate;
                default:
                    return FormatAllType.Unique;
            }
        }

        #endregion

        #region "Events"

        /// <summary>
        /// Load the Combobox based RowIndex
        /// </summary>
        void Grid1_Click(object sender, EventArgs e)
        {
            switch (this.grdRuleType.Grid.CurrentCell.RowIndex)
            {
                case 1:
                    loadRule1Combobox();
                    break;
                case 2:
                    loadRule2Combobox();
                    break;
                case 3:
                    loadRule3Combobox();
                    break;
                case 4:
                    loadRule4Combobox();
                    break;
                case 5:
                    loadRule5Combobox();
                    break;
            }
        }

        /// <summary>
        /// Make the image selection based on rowindex
        /// </summary>
        void Grid_Click(object sender, EventArgs e)
        {
            GridCurrentCell cc = this.grdDropDown.Grid.CurrentCell;
            if (this.grdDropDown.SelectedIndex != -1)
            {
                imageSelection(cc.RowIndex);
            }
            else
                this.cboRule1ImageName.TextBox.Text = String.Empty;

            this.cboRule1ImageName.PopupContainer.HidePopup(PopupCloseType.Done);
        }

        /// <summary>
        /// Load the form for Setting the Grid
        /// </summary>
        void Form1_Load(object sender, EventArgs e)
        {
            this.grdDropDown.BeginUpdate();
            this.grdDropDown.DataSource = CreateTable();
            this.grdDropDown.DisplayMember = "Name";
            this.grdDropDown.ValueMember = "Id";
            this.grdDropDown.SelectionMode = SelectionMode.One;
            this.grdDropDown.ShowColumnHeader = false;
            this.grdDropDown.ThemesEnabled = true;
            this.grdDropDown.Grid.VerticalThumbTrack = true;

            this.grdDropDown.Grid.DrawCellDisplayText += new Syncfusion.Windows.Forms.Grid.GridDrawCellDisplayTextEventHandler(Grid_DrawCellDisplayText);
            this.grdDropDown.FillLastColumn = true;
            this.grdDropDown.EndUpdate();
            this.grdDropDown.Grid.QueryCellInfo += new Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventHandler(Grid_QueryCellInfo);


            DataTable dtRuleType = new DataTable();
            dtRuleType.Columns.Add("RuleType");
            dtRuleType.Rows.Add("Format All Cells Based On Their Values");
            dtRuleType.Rows.Add("Format Only Cells That Contain");
            dtRuleType.Rows.Add("Format Top Or Bottom Ranked Values");
            dtRuleType.Rows.Add("Format Only Values That Are Above Or Below Average");
            dtRuleType.Rows.Add("Format Only Unique Or Duplicate Values");

            this.grdRuleType.DisplayMember = "RuleType";
            this.grdRuleType.SelectionMode = SelectionMode.One;
            this.grdRuleType.ShowColumnHeader = false;
            this.grdRuleType.ThemesEnabled = true;
            this.grdRuleType.Grid.VerticalThumbTrack = true;
            this.grdRuleType.DataSource = dtRuleType;
            this.grdRuleType.FillLastColumn = true;

            this.grdRuleType.BorderStyle = BorderStyle.FixedSingle;
            this.grdDropDown.BorderStyle = BorderStyle.FixedSingle;
            this.grdDropDown.ThemesEnabled = false;
            this.grdRuleType.ThemesEnabled = false;

            // default selection
            this.grdRuleType.Grid.Model.Selections.Add(GridRangeInfo.Cell(1, 1));
            loadRule1Combobox();
            imageSelection(5);

            bool isNeedColor = false;
            NewRuleConditionalFormat newRule1 = new NewRuleConditionalFormat();
            string RuleType = this.grdRuleType.Text;
            newRule1.RuleType = SetRuleType(RuleType);
            ConditionalFormat form = new ConditionalFormat();
            cboRule2ConditionType.SelectedIndex = 0;
            form.ConditionType = SetConditionalType(cboRule2ConditionType.SelectedItem.ToString());
            form.PredicateType = SetPredicateType(cboRule2ConditionType.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(txtRule2StartValue.Text))
                form.StartValue = Convert.ToDouble(txtRule2StartValue.Text);
            if (!string.IsNullOrEmpty(txtRule2EndValue.Text))
                form.EndValue = Convert.ToDouble(txtRule2EndValue.Text);
            newRule1.Conditions.Add(form);
            cboRule2SummaryElement.SelectedIndex = 0;
            this.cboRule1ImageName.TextBox.Text = "3-Flag";
            newRule1.Image = SetImageName(this.cboRule1ImageName.TextBox.Text);
            newRule1.SummaryElement = cboRule2SummaryElement.SelectedItem.ToString();
            isNeedColor = true;
            PivotGridNewRuleConditionalFormat newRuleFormat1 = new PivotGridNewRuleConditionalFormat();
            newRuleFormat1.NewRuleCollections.Add(newRule1);
            if (isNeedColor)
            {
                newRuleFormat1.PivotCellStyle.BackColor = Color.Red;
                newRuleFormat1.PivotCellStyle.TextColor = Color.White;
            }
            this.pivotGridControl1.TableControl.NewRuleConditionalFormat.Add(newRuleFormat1);
            this.pivotGridControl1.TableControl.Refresh(true);

        }

        /// <summary>
        /// Set the Background image based on the index
        /// </summary>
        void Grid_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex == 1)
                e.Style.BackgroundImage = this.imageList1.Images[0];
            else if (e.RowIndex == 2)
                e.Style.BackgroundImage = this.imageList1.Images[1];
            else if (e.RowIndex == 3)
                e.Style.BackgroundImage = this.imageList1.Images[2];
            else if (e.RowIndex == 4)
                e.Style.BackgroundImage = this.imageList1.Images[3];
            else if (e.RowIndex == 5)
                e.Style.BackgroundImage = this.imageList1.Images[4];
            else if (e.RowIndex == 6)
                e.Style.BackgroundImage = this.imageList1.Images[5];
            else if (e.RowIndex == 7)
                e.Style.BackgroundImage = this.imageList1.Images[6];
            else if (e.RowIndex == 8)
                e.Style.BackgroundImage = this.imageList1.Images[7];
            else if (e.RowIndex == 9)
                e.Style.BackgroundImage = this.imageList1.Images[8];
            else if (e.RowIndex == 10)
                e.Style.BackgroundImage = this.imageList1.Images[9];
            else if (e.RowIndex == 11)
                e.Style.BackgroundImage = this.imageList1.Images[10];
            else if (e.RowIndex == 12)
                e.Style.BackgroundImage = this.imageList1.Images[11];
            else if (e.RowIndex == 13)
                e.Style.BackgroundImage = this.imageList1.Images[12];
            else if (e.RowIndex == 14)
                e.Style.BackgroundImage = this.imageList1.Images[13];
            else if (e.RowIndex == 15)
                e.Style.BackgroundImage = this.imageList1.Images[14];
            else if (e.RowIndex == 16)
                e.Style.BackgroundImage = this.imageList1.Images[15];

            e.Style.BackgroundImageMode = Syncfusion.Windows.Forms.Grid.GridBackgroundImageMode.Normal;

        }

        /// <summary>
        /// Set the Display text
        /// </summary>
        void Grid_DrawCellDisplayText(object sender, Syncfusion.Windows.Forms.Grid.GridDrawCellDisplayTextEventArgs e)
        {
            e.DisplayText = string.Empty;
        }

        /// <summary>
        /// Set the  value to SelectedIndex for All the combobox1
        /// </summary>
        private void loadRule1Combobox()
        {
            cboRule2predicateType.SelectedIndex = -1;
            cboRule2ConditionType.SelectedIndex = -1;
            cboRule2SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = -1;
            cboRule3SummaryElement.SelectedIndex = -1;
            cboRule4FormatValueType.SelectedIndex = -1;
            cboRule4SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = -1;
            cboRule5SummaryElement.SelectedIndex = -1;
            cboRule1FormatStyle.SelectedIndex = 0;
            cboRule1SummaryElement.SelectedIndex = 0;

            pnlRule5.Visible = false;
            pnlRule4.Visible = false;
            pnlRule3.Visible = false;
            PnlRule2.Visible = false;
            pnlRule2Value.Visible = false;
            PnlRule1.Visible = true;
            pnlRule1Value.Visible = true;
        }

        /// <summary>
        /// Set the  value to SelectedIndex for All the combobox2
        /// </summary>
        private void loadRule2Combobox()
        {
            cboRule1FormatStyle.SelectedIndex = -1;
            cboRule1SummaryElement.SelectedIndex = -1;
            cboRule4FormatValueType.SelectedIndex = -1;
            cboRule4SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = -1;
            cboRule5SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = -1;
            cboRule3SummaryElement.SelectedIndex = -1;
            cboRule2predicateType.SelectedIndex = 0;
            cboRule2ConditionType.SelectedIndex = 0;
            cboRule2SummaryElement.SelectedIndex = 0;

            pnlRule5.Visible = false;
            pnlRule4.Visible = false;
            pnlRule3.Visible = false;
            PnlRule2.Visible = true;
            pnlRule2Value.Visible = true;
            PnlRule1.Visible = false;
            pnlRule1Value.Visible = false;
        }

        /// <summary>
        /// Set the  value to SelectedIndex for All the combobox3
        /// </summary>
        private void loadRule3Combobox()
        {
            cboRule1FormatStyle.SelectedIndex = -1;
            cboRule1SummaryElement.SelectedIndex = -1;
            cboRule2predicateType.SelectedIndex = -1;
            cboRule2ConditionType.SelectedIndex = -1;
            cboRule2SummaryElement.SelectedIndex = -1;
            cboRule4FormatValueType.SelectedIndex = -1;
            cboRule4SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = -1;
            cboRule5SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = 0;
            cboRule3SummaryElement.SelectedIndex = 0;

            pnlRule5.Visible = false;
            pnlRule4.Visible = false;
            pnlRule3.Visible = true;
            PnlRule2.Visible = false;
            pnlRule2Value.Visible = false;
            PnlRule1.Visible = false;
            pnlRule1Value.Visible = false;
        }

        /// <summary>
        /// Set the  value to SelectedIndex for All the combobox5
        /// </summary>
        private void loadRule5Combobox()
        {
            cboRule1FormatStyle.SelectedIndex = -1;
            cboRule1SummaryElement.SelectedIndex = -1;
            cboRule2predicateType.SelectedIndex = -1;
            cboRule2ConditionType.SelectedIndex = -1;
            cboRule2SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = -1;
            cboRule3SummaryElement.SelectedIndex = -1;
            cboRule4FormatValueType.SelectedIndex = -1;
            cboRule4SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = 0;
            cboRule5SummaryElement.SelectedIndex = 0;

            pnlRule5.Visible = true;
            pnlRule4.Visible = false;
            pnlRule3.Visible = false;
            PnlRule2.Visible = false;
            pnlRule2Value.Visible = false;
            PnlRule1.Visible = false;
            pnlRule1Value.Visible = false;
        }

        /// <summary>
        /// Set the value to SelectedIndex for All the combobox4
        /// </summary>
        private void loadRule4Combobox()
        {
            cboRule4FormatValueType.SelectedIndex = 0;
            cboRule4SummaryElement.SelectedIndex = 0;
            cboRule1FormatStyle.SelectedIndex = -1;
            cboRule1SummaryElement.SelectedIndex = -1;
            cboRule2predicateType.SelectedIndex = -1;
            cboRule2ConditionType.SelectedIndex = -1;
            cboRule2SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = -1;
            cboRule5SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = -1;
            cboRule3SummaryElement.SelectedIndex = -1;


            pnlRule5.Visible = false;
            pnlRule4.Visible = true;
            pnlRule3.Visible = false;
            PnlRule2.Visible = false;
            pnlRule2Value.Visible = false;
            PnlRule1.Visible = false;
            pnlRule1Value.Visible = false;
        }

        /// <summary>
        /// Unload the combobox 
        /// </summary>
        private void unLoadRule1Combobox()
        {
            cboRule1FormatStyle.SelectedIndex = -1;
            cboRule1SummaryElement.SelectedIndex = -1;
        }

        /// <summary>
        /// Intialize the Combobox index value
        /// </summary>
        private void CommonCombobox()
        {
            cboValueType1.SelectedIndex = 0;
            cboValueType2.SelectedIndex = 0;
            cboValueType3.SelectedIndex = 0;
            cboValueType4.SelectedIndex = 0;
        }      

        /// <summary>
        /// Set the values for all the cell
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {  
            bool isNeedColor = false;
            NewRuleConditionalFormat newRule1 = new NewRuleConditionalFormat();
            string RuleType = this.grdRuleType.Text;
            newRule1.RuleType = SetRuleType(RuleType);
            double number = 0;
            switch (RuleType)
            {
                case "Format Only Cells That Contain":
                    ConditionalFormat form = new ConditionalFormat();
                    form.ConditionType = SetConditionalType(cboRule2ConditionType.SelectedItem.ToString());
                    form.PredicateType = SetPredicateType(cboRule2ConditionType.SelectedItem.ToString());
                    if (!string.IsNullOrEmpty(txtRule2StartValue.Text)
                        && double.TryParse(txtRule2StartValue.Text, out number))
                        form.StartValue = Convert.ToDouble(txtRule2StartValue.Text);
                    if (!string.IsNullOrEmpty(txtRule2EndValue.Text)
                        && double.TryParse(txtRule2EndValue.Text, out number))
                        form.EndValue = Convert.ToDouble(txtRule2EndValue.Text);
                    newRule1.Conditions.Add(form);
                    newRule1.SummaryElement = cboRule2SummaryElement.SelectedItem.ToString();
                    isNeedColor = true;
                    break;
                case "Format Top Or Bottom Ranked Values":
                    newRule1.FormateValuesRankType = SetFormateValuesRankType(cboRule3FormatRankType.SelectedItem.ToString());
                    if (!string.IsNullOrEmpty(txtRule3RankValue.Text)
                        && double.TryParse(txtRule3RankValue.Text, out number))
                        newRule1.RankValue = Convert.ToInt32(Convert.ToDouble(txtRule3RankValue.Text.ToString()));
                    if (cboRule3SummaryElement.SelectedItem != null)
                        newRule1.SummaryElement = cboRule3SummaryElement.SelectedItem.ToString();
                    isNeedColor = true;
                    break;
                case "Format Only Values That Are Above Or Below Average":
                    newRule1.FormateSelectedAverageValueType = SetFormateSelectedAverageValueType(cboRule4FormatValueType.SelectedItem.ToString());
                    if (cboRule4SummaryElement.SelectedItem != null)
                        newRule1.SummaryElement = cboRule4SummaryElement.SelectedItem.ToString();
                    isNeedColor = true;
                    break;
                case "Format Only Unique Or Duplicate Values":
                    newRule1.FormatAllType = SetFormatAllType(cboRule5FormatAllType.SelectedItem.ToString());
                    if (cboRule5SummaryElement.SelectedItem != null)
                        newRule1.SummaryElement = cboRule5SummaryElement.SelectedItem.ToString().Trim();
                    isNeedColor = true;
                    break;
                default:
                    if (cboRule1FormatStyle.SelectedIndex == 0)
                        newRule1.FormatStyle = FormatStyle.IconSets;
                    if (cboRule1SummaryElement.SelectedItem != null)
                        newRule1.SummaryElement = cboRule1SummaryElement.SelectedItem.ToString();
                    newRule1.Image = SetImageName(cboRule1ImageName.Text);                   
                    isNeedColor = false;
                    if (cboValueType1.SelectedIndex == 0)
                        newRule1.ValueType1 = Syncfusion.Windows.Forms.PivotAnalysis.ValueType.Percent;
                    else
                    {
                        newRule1.ValueType1 = Syncfusion.Windows.Forms.PivotAnalysis.ValueType.Number;                      
                    }
                    if (cboValueType2.SelectedIndex == 0)
                        newRule1.ValueType2 = Syncfusion.Windows.Forms.PivotAnalysis.ValueType.Percent;
                    else
                    {
                        newRule1.ValueType2 = Syncfusion.Windows.Forms.PivotAnalysis.ValueType.Number;
                    }
                    if (cboValueType3.SelectedIndex == 0)
                        newRule1.ValueType3 = Syncfusion.Windows.Forms.PivotAnalysis.ValueType.Percent;
                    else
                    {
                        newRule1.ValueType3 = Syncfusion.Windows.Forms.PivotAnalysis.ValueType.Number;
                    }
                    if (cboValueType4.SelectedIndex == 0)
                        newRule1.ValueType4 = Syncfusion.Windows.Forms.PivotAnalysis.ValueType.Percent;
                    else
                    {
                        newRule1.ValueType4 = Syncfusion.Windows.Forms.PivotAnalysis.ValueType.Number;
                    }    
                    break;
            }          
            PivotGridNewRuleConditionalFormat newRuleFormat1 = new PivotGridNewRuleConditionalFormat();
            newRuleFormat1.NewRuleCollections.Add(newRule1);
            if (isNeedColor)
            {
                newRuleFormat1.PivotCellStyle.BackColor = Color.Red;
                newRuleFormat1.PivotCellStyle.TextColor = Color.White;
            }
            this.pivotGridControl1.TableControl.NewRuleConditionalFormat.Add(newRuleFormat1);
            this.pivotGridControl1.TableControl.Refresh(true);
        }

        /// <summary>
        /// Clear the conditional format and refresh the table control
        /// </summary>
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.pivotGridControl1.TableControl.NewRuleConditionalFormat.Clear();
            this.pivotGridControl1.TableControl.Refresh(true);
        }

        #endregion
    }
}
