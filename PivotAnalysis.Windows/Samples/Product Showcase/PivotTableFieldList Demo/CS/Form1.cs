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
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.PivotAnalysis;
using DemoCommon.Grid;

namespace WindowsFormsApplication11
{
    public partial class Form1 : GridDemoForm
    {
        #region Window Updates
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);
        #endregion

        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            this.GridSetting();    
        }

        #region "Grid Setting"

        private void GridSetting()
        {
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

            // Other settings
            this.checkBox1.Checked = true;
            try
            {
                this.pivotGridControl1.TableControl.MetroStyle.PivotTable.PivotFieldList.FieldImages.Add(Image.FromFile(GetIconFile(@"..\\..\\images\filter.png")));
                this.pivotGridControl1.TableControl.MetroStyle.PivotTable.PivotFieldList.FieldImages.Add(Image.FromFile(GetIconFile(@"..\\..\\images\col.png")));
                this.pivotGridControl1.TableControl.MetroStyle.PivotTable.PivotFieldList.FieldImages.Add(Image.FromFile(GetIconFile(@"..\\..\\images\row.png")));
                this.pivotGridControl1.TableControl.MetroStyle.PivotTable.PivotFieldList.FieldImages.Add(Image.FromFile(GetIconFile(@"..\\..\\images\val.png")));

            }
            catch
            {
            }
            this.pivotGridControl1.ShowPivotTableFieldList = true;

            //  Selection
            this.pivotGridControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Any;

            this.WindowState = FormWindowState.Maximized;

            this.pivotGridControl1.TableControl.CurrentCell.InternalHide = true;
            this.MinimumSize = new Size(1000, 400);


            //  Chart Control customization
            this.LoadChart();

            this.EntireCustomization();

            this.EventsCustomization();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.pivotGridControl1.TableControl.MetroColorTable.ThumbPushed = Color.FromArgb(70, 70, 70);
            GridRangeInfo selRange = GridRangeInfo.Cells(5, 5, 6, 6);
            this.pivotGridControl1.TableModel.Selections.Add(selRange);
            GridSelectionChangedEventArgs e = new GridSelectionChangedEventArgs(selRange, null, GridSelectionReason.MouseUp);
            this.pivotGridControl1.TableModel.RaiseSelectionChanged(e);
        }

        #endregion

        #endregion

        #region "Sample Customization"

        //Sample customized by event
        void EventsCustomization()
        {
            //  Events
            this.pivotGridControl1.TableModel.QueryCellInfo += new Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventHandler(TableModel_QueryCellInfo);

            this.pivotGridControl1.TableControl.GroupDropArea.QueryCellText += new GridCellTextEventHandler(GroupDropArea_QueryCellText);

            this.pivotGridControl1.TableControl.GroupDropArea.QueryRowHeight += new GridRowColSizeEventHandler(GroupDropArea_QueryRowHeight);
            this.pivotGridControl1.TableControl.GroupDropArea.DrawCell += new GridDrawCellEventHandler(GroupDropArea_DrawCell);
            this.pivotGridControl1.TableControl.GroupDropArea.QueryCellInfo += new GridQueryCellInfoEventHandler(GroupDropArea_QueryCellInfo);
           
            controls = new List<Control>();
            controls.Add(this.pivotGridControl1.TableControl.GridColumnList);
            controls.Add(this.pivotGridControl1.TableControl.GridFilterList);
            controls.Add(this.pivotGridControl1.TableControl.GridRowList);
            controls.Add(this.pivotGridControl1.TableControl.GridValueList);
            controls.Add(this.pivotGridControl1.TableControl.PivotTableFieldList);

            foreach (GridControl ctrl in this.controls)
            {
                ctrl.QueryCellText += new GridCellTextEventHandler(ctrl_QueryCellText);
                ctrl.DrawCellButton += new GridDrawCellButtonEventHandler(ctrl_DrawCellButton);
            }            
        }

        //Entire customization for grid
        void EntireCustomization()
        {
            this.pivotGridControl1.TableControl.CustomizeSystemTheme = true;
            this.pivotGridControl1.GridVisualStyles = GridVisualStyles.Custom;
            this.pivotGridControl1.TableControl.GroupDropArea.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridControl1.TableControl.RowGroupDropArea.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridControl1.TableControl.FilterArea.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridControl1.TableControl.GridRowList.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridControl1.TableControl.GridColumnList.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridControl1.TableControl.GridFilterList.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridControl1.TableControl.GridValueList.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridControl1.TableControl.PivotTableFieldList.GridVisualStyles = GridVisualStyles.Metro;

            this.GridScrollMetroStyle();
            this.pivotGridControl1.TableModel.TableStyle.BackColor = Color.FromArgb(23, 23, 23);
            this.pivotGridControl1.TableModel.TableStyle.TextColor = Color.FromArgb(230, 231, 232);

         
            this.pivotGridControl1.Refresh();
            this.pivotGridControl1.PivotSchemaDesigner.RefreshGridSchemaLayout();
            this.pivotGridControl1.PivotSchemaDesigner.Refresh();
            this.pivotGridControl1.TableControl.Refresh();
            this.pivotGridControl1.TableControl.PivotTableFieldList.GridVisualStyles = GridVisualStyles.Custom;
            this.pivotGridControl1.TableControl.PivotTableFieldList.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.pivotGridControl1.TableControl.PivotTableFieldList.MetroColorTable.ScrollerBackground = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.PivotTableFieldList.MetroColorTable.ThumbChecked = ColorTranslator.FromHtml("#989898");
            this.pivotGridControl1.TableControl.PivotTableFieldList.MetroColorTable.ThumbNormal = ColorTranslator.FromHtml("#989898");
            this.pivotGridControl1.TableControl.PivotTableFieldList.MetroColorTable.ArrowChecked = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.PivotTableFieldList.MetroColorTable.ArrowPushed = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.PivotTableFieldList.MetroColorTable.ArrowNormal = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.PivotTableFieldList.MetroColorTable.ArrowInActive = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.PivotTableFieldList.Properties.BackgroundColor = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.PivotTableFieldList.TableStyle.TextColor = Color.FromArgb(205, 204, 204);
            this.pivotGridControl1.TableControl.PivotTableFieldList.QueryCellText += new GridCellTextEventHandler(PivotTableFieldList_QueryCellText);
            this.pivotGridControl1.TableControl.PivotTableFieldList.Refresh();
            
            GridMetroColors color = new GridMetroColors();
            color.HeaderColor.NormalColor = ColorTranslator.FromHtml("#232323");
            color.HeaderTextColor.NormalTextColor = Color.FromArgb(230, 231, 232);
            color.HeaderColor.HoverColor = Color.FromArgb(79, 79, 79);
            color.HeaderColor.PressedColor = Color.FromArgb(79, 79, 79);
            color.HeaderBottomBorderColor = Color.FromArgb(23, 23, 23);
            this.pivotGridControl1.TableControl.GroupDropArea.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.RowGroupDropArea.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.FilterArea.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.FilterArea.BackColor = ColorTranslator.FromHtml("#232323");
            this.pivotGridControl1.TableControl.GroupDropArea.BackColor = Color.FromArgb(79, 80, 80);
            this.pivotGridControl1.TableControl.GridRowList.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.GridColumnList.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.GridFilterList.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.BorderStyle = BorderStyle.FixedSingle;
            this.pivotGridControl1.TableControl.SelectionChanged += new SelectionChanged(TableControl_SelectionChanged);
           
            this.SchemaCustomization();
            this.pivotGridControl1.TableControl.MetroStyle.PivotItems.BorderColor = Color.Gray;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.Transparent;

            this.pivotGridControl1.TableControl.MetroColorTable.ThumbPushed = Color.FromArgb(70, 70, 70);
            this.pivotGridControl1.TableControl.PivotTableFieldList.MetroColorTable.ThumbPushed = Color.FromArgb(70, 70, 70);
        }

        //Customized pivot table
        void SchemaCustomization()
        {
            this.pivotGridControl1.TableControl.BorderStyle = BorderStyle.None;
            this.pivotGridControl1.TableControl.GridColumnList.BorderStyle = BorderStyle.None;
            this.pivotGridControl1.TableControl.GridRowList.BorderStyle = BorderStyle.None;
            this.pivotGridControl1.TableControl.GridValueList.BorderStyle = BorderStyle.None;
            this.pivotGridControl1.TableControl.GridFilterList.BorderStyle = BorderStyle.None;
            this.pivotGridControl1.TableControl.PivotTableFieldList.BorderStyle = BorderStyle.None;
            this.pivotGridControl1.TableControl.PivotTableFieldList.Paint += new PaintEventHandler(PivotTableFieldList_Paint);
            this.pivotGridControl1.TableControl.GridFilterList.Paint += new PaintEventHandler(GridFilterList_Paint);
            this.pivotGridControl1.TableControl.GridColumnList.Paint += new PaintEventHandler(GridColumnList_Paint);
            this.pivotGridControl1.TableControl.GridValueList.Paint += new PaintEventHandler(GridValueList_Paint);
            this.pivotGridControl1.TableControl.GridRowList.Paint += new PaintEventHandler(GridRowList_Paint);
        }

        /// <summary>
        /// Set the Control for pivot control  
        /// </summary>
        void PivotTableFieldList_Paint(object sender, PaintEventArgs e)
        {
            Control cont = this.pivotGridControl1.TableControl.PivotTableFieldList;
            Rectangle rect = cont.ClientRectangle;
            //e.Graphics.DrawRectangle(new Pen(Color.FromArgb(50, 50, 50)), rect.X, rect.Y, cont.Width + 20, cont.Height - 1);
        }

        //Drae the line for Grid Row List
        void GridRowList_Paint(object sender, PaintEventArgs e)
        {
            Control cont = this.pivotGridControl1.TableControl.GridRowList;
            Rectangle rect = cont.ClientRectangle;
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(50, 50, 50)), rect.X, rect.Y, cont.Width - 1, cont.Height - 1);
            if (this.pivotGridControl1.PivotRows.Count > 0)
            {
                for (int i = 1; i <= this.pivotGridControl1.PivotRows.Count; i++)
                {
                    if (isRowChanged)
                        e.Graphics.DrawLine(new Pen(Color.FromArgb(35, 35, 35), 5f), cont.Width - 17, rect.Y - 17, cont.Width - 17, rect.Height);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(50, 50, 50), 2f), rect.X, 20 * i, cont.Width - 1, 20 * i);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(35, 35, 35), 1f), rect.X, 20 * i, cont.Width - 1, 20 * i);
                }
            }
            if (this.pivotGridControl1.PivotRows.Count >= 5 && !isRowChanged)
            {
                MetroColorsCustomization(this.pivotGridControl1.TableControl.GridRowList);
                isRowChanged = true;
            }
            if (this.pivotGridControl1.Filters.Count < 5)
            {
                isRowChanged = false;
            }
        }

        //Draw the line for pivot calculation
        void GridValueList_Paint(object sender, PaintEventArgs e)
        {
            Control cont = this.pivotGridControl1.TableControl.GridValueList;
            Rectangle rect = cont.ClientRectangle;
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(50, 50, 50)), rect.X, rect.Y, cont.Width - 1, cont.Height - 1);
            if (this.pivotGridControl1.PivotCalculations.Count > 0)
            {
                for (int i = 1; i <= this.pivotGridControl1.PivotCalculations.Count; i++)
                {
                    if (isValueChanged)
                        e.Graphics.DrawLine(new Pen(Color.FromArgb(35, 35, 35), 5f), cont.Width - 17, rect.Y - 17, cont.Width - 17, rect.Height);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(50, 50, 50), 2f), rect.X, 20 * i, cont.Width - 1, 20 * i);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(35, 35, 35), 1f), rect.X, 20 * i, cont.Width - 1, 20 * i);
                }
            }
            if (this.pivotGridControl1.PivotCalculations.Count >= 5 && !isValueChanged)
            {
                MetroColorsCustomization(this.pivotGridControl1.TableControl.GridValueList);
                isValueChanged = true;
            }
            if (this.pivotGridControl1.PivotCalculations.Count < 5)
            {
                isValueChanged = false;
            }
        }

        //Paint for Grid Filter List
        void GridFilterList_Paint(object sender, PaintEventArgs e)
        {
            Control cont = this.pivotGridControl1.TableControl.GridFilterList;
            Rectangle rect = cont.ClientRectangle;
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(50, 50, 50)), rect.X, rect.Y, cont.Width - 1, cont.Height - 1);
            if (this.pivotGridControl1.Filters.Count > 0)
            {
                for (int i = 1; i <= this.pivotGridControl1.Filters.Count; i++)
                {
                    if (isFilterChanged)
                        e.Graphics.DrawLine(new Pen(Color.FromArgb(35, 35, 35), 5f), cont.Width - 17, rect.Y - 17, cont.Width - 17, rect.Height);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(50, 50, 50), 2f), rect.X, 20 * i, cont.Width - 1, 20 * i);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(35, 35, 35), 1f), rect.X, 20 * i, cont.Width - 1, 20 * i);
                }
            }
            if (this.pivotGridControl1.Filters.Count >= 5 && !isFilterChanged)
            {
                MetroColorsCustomization(this.pivotGridControl1.TableControl.GridFilterList);
                isFilterChanged = true;
            }
            if (this.pivotGridControl1.Filters.Count < 5)
            {
                isFilterChanged = false;
            }
        }

        //Paint for Grid column list
        void GridColumnList_Paint(object sender, PaintEventArgs e)
        {
            Control cont = this.pivotGridControl1.TableControl.GridColumnList;
            Rectangle rect =cont.ClientRectangle;
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(50, 50, 50)), rect.X, rect.Y, cont.Width - 1, cont.Height - 1);
            if (this.pivotGridControl1.PivotColumns.Count > 0)
            {
                for (int i = 1; i <= this.pivotGridControl1.PivotColumns.Count; i++)
                {
                    if (isColChanged)
                        e.Graphics.DrawLine(new Pen(Color.FromArgb(35, 35, 35), 5f), cont.Width - 17, rect.Y - 17, cont.Width - 17, rect.Height);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(50, 50, 50), 2f), rect.X, 20 * i, cont.Width - 1, 20 * i);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(35, 35, 35), 1f), rect.X, 20 * i, cont.Width - 1, 20 * i);
                }
            }
            if (this.pivotGridControl1.PivotColumns.Count >= 5 && !isColChanged)
            {
                MetroColorsCustomization(this.pivotGridControl1.TableControl.GridColumnList);
                isColChanged = true;
            }
            if (this.pivotGridControl1.PivotColumns.Count < 5)
            {
                isColChanged = false;
            }
        }
        bool isColChanged, isFilterChanged, isRowChanged, isValueChanged = false;

        //Draw the Metro style for Button
        void ctrl_DrawCellButton(object sender, GridDrawCellButtonEventArgs e)
        {
            //e.Button.DrawMetroButtonStyle(e.Graphics, e.Button.Bounds, ButtonState.Flat, "1", true);
        }

        //Apply the Style for all borders
        void ctrl_QueryCellText(object sender, GridCellTextEventArgs e)
        {
            e.Style.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(23, 23, 23));            
        }

        List<Control> controls;

        //Apply the border style for specified row index
        void GroupDropArea_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex == 2)
            {
                if (e.Style.CellType == "PivotGridHeaderCell")
                {
                    e.Style.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(23, 23, 23));
                }
            }
        }

        //Apply the border for Group Drop Area
        void GroupDropArea_DrawCell(object sender, GridDrawCellEventArgs e)
        {
            if(e.RowIndex==2)
            {
                if (e.Style.CellType == "PivotGridHeaderCell")
                {
                    e.Style.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(23, 23, 23));
                }
            }
        }

        //Handling the row height for specified index
        void GroupDropArea_QueryRowHeight(object sender, GridRowColSizeEventArgs e)
        {
            if (e.Index == 2)
            {
                e.Size = 25;
                e.Handled = true;
            }
        }

        //Set the fore color for for Grid Line
        void TableControl_SelectionChanged(object sender, PivotGridSelectionChangedEventArgs e)
        {
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.Transparent;
        }

        //set the text color and border style
        void GroupDropArea_QueryCellText(object sender, GridCellTextEventArgs e)
        {
            e.Style.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(23, 23, 23));
            e.Style.TextColor = Color.FromArgb(205, 204, 204);
        }

        //set the text color
        void PivotTableFieldList_QueryCellText(object sender, GridCellTextEventArgs e)
        {
            e.Style.TextColor = Color.FromArgb(205, 204, 204);
        }

        /// <summary>
        /// Apply the chart styles
        /// </summary>
        public void ApplyChartStyles(ChartControl chart)
        {
            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.PathRectangle, new Color[] { Color.FromArgb(23, 23, 23)});//, Color.White });
            chart.ChartArea.BackInterior = new BrushInfo(Color.FromArgb(23, 23, 23));//GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.SkyBlue;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.Transparent;
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(182, 183, 184);
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(182, 183, 184);
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 80, 20);
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(1998, 2005, 1);

            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 270;

            chart.PrimaryYAxis.Title = "Product sold (Millions)";
            chart.PrimaryXAxis.Title = "Year";
            chart.Title.Text = "Product Sales";
            chart.Title.ForeColor = Color.FromArgb(205, 204, 204);
            #endregion

            #region Legend Customization

            chart.Legend.Visible = false;

            #endregion
        }

        //Load the chart
        private void LoadChart()
        {
            chartControl1 = new ChartControl();
            chartControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            PivotGridChartHelper helper = new PivotGridChartHelper();
            helper.WireGrid(this.pivotGridControl1, this.chartControl1);

            this.chartControl1.CustomPalette = new Color[] { Color.FromArgb(12, 128, 64), Color.FromArgb(237,31,36), Color.FromArgb(243,236,25), Color.FromArgb(126,40,126), Color.FromArgb(56,83,164),
             Color.Cyan,Color.BlueViolet,Color.Brown ,Color.Chocolate,Color.RoyalBlue};

            this.chartControl1.Palette = ChartColorPalette.Custom;
            this.chartControl1.PrimaryYAxis.TitleFont = new Font("Segoe UI", 12f, FontStyle.Regular);
            this.chartControl1.PrimaryYAxis.TitleColor = Color.FromArgb(205, 205, 205);
            this.chartControl1.PrimaryXAxis.TitleFont = new Font("Segoe UI", 12f, FontStyle.Regular);
            this.chartControl1.PrimaryXAxis.TitleColor = Color.FromArgb(205, 205, 205);

            this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.RelativeWidthMode;
            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(1, 100, 10);
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, 6, 1);
            this.panel3.Controls.Add(chartControl1);

            this.chartControl1.AddRandomSeries = false;
            this.chartControl1.Legend.ShowSymbol = true;
            this.chartControl1.Indexed = true;
            this.chartControl1.Legend.Visible = true;
            this.chartControl1.SpacingBetweenSeries = 30;
            this.chartControl1.ColumnDrawMode = ChartColumnDrawMode.PlaneMode;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            this.chartControl1.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            this.chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.ElementsSpacing = 5;
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;
            this.chartControl1.Text = "Product category";
            this.chartControl1.Font = new Font("segoe ui", 22f, FontStyle.Regular);
            this.chartControl1.ForeColor = Color.FromArgb(205, 204, 204);
            this.chartControl1.BorderAppearance.FrameThickness = new ChartThickness(2f);
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Size = new System.Drawing.Size(this.chartPanel.Width - 26, this.chartPanel.Height - 36);
            this.chartPanel.Controls.Add(this.chartControl1);
            chartControl1.PrimaryXAxis.LineType.BackColor = Color.FromArgb(49, 49, 49);
            ApplyChartStyles(this.chartControl1);
            this.InitializeChart();
            this.RowHeightOnScaling();
            this.chartControl1.ShowLegend = (this.isHigherResol) ? false : true;
        }
        /// <summary>
        /// When DPI is greater than 100 then the DefaultRowHeight will be set based on the font size.
        /// </summary>
        internal void RowHeightOnScaling()
        {
            if (this.pivotGridControl1.TableModel.ActiveGridView != null)
                using (Graphics graph = this.pivotGridControl1.TableModel.ActiveGridView.CreateGraphics())
                {
                    if (graph.DpiY > 100)
                    {
                        isHigherResol = true;
                    }
                }
        }
        private bool isHigherResol = false;

        /// <summary>
        /// Intialize the chart value
        /// </summary>
        private void InitializeChart()
        {
            Color[] colors = new Color[] { Color.FromArgb(12, 128, 64), Color.FromArgb(237,31,36), Color.FromArgb(243,236,25), Color.FromArgb(126,40,126), Color.FromArgb(56,83,164) };
            ChartSeries series = new ChartSeries("Series", ChartSeriesType.Column);

            for (int i = 0; i < colors.Length; i++)
               series.Styles[i].Interior = new BrushInfo(colors[i]);

            this.chartControl1.PrimaryXAxis.ForeColor = Color.White;
            this.chartControl1.PrimaryYAxis.ForeColor = Color.White;
            this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;
            this.chartControl1.PrimaryXAxis.LabelRotate = false;
            this.chartControl1.PrimaryXAxis.LabelRotateAngle = 45;
            this.chartControl1.ChartInterior = new BrushInfo(Color.FromArgb(15,15,16));
            this.chartControl1.ShowLegend = false;
            this.chartControl1.TextAlignment = StringAlignment.Near;
            this.chartControl1.ForeColor = Color.White;
            this.chartControl1.ChartToolTip ="Quantity" ;
            this.chartControl1.ChartArea.BorderColor = Color.FromArgb(41, 41, 41);
            this.chartControl1.ChartArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartControl1.ChartArea.BorderWidth = 1;
        }
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;

        //set the backcolor and forecolor based on CellType
        void TableModel_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {
            if (e.Style.CellType == "PivotGridHeaderCell")
            {
                e.Style.BackColor = ColorTranslator.FromHtml("#6D6D6D");
                e.Style.TextColor = ColorTranslator.FromHtml("#E6E7E8");
                e.Handled = true;
            }
            if (e.Style.CellType == "PivotGridExpandCell")
            {
                e.Style.BackColor = ColorTranslator.FromHtml("#6D6D6D");
                e.Style.TextColor = ColorTranslator.FromHtml("#E6E7E8");
                e.Handled = true;
            }
            if (e.Style.CellType == "PivotGridTotalValueCell")
            {
                e.Style.BackColor = Color.FromArgb(35, 35, 35);
                e.Style.TextColor = ColorTranslator.FromHtml("#C4C4C4");
                e.Handled = true;
            }
            if (e.Style.CellType == "ColumnHeaderCell")
            {
                e.Style.BackColor = ColorTranslator.FromHtml("#171717");
                e.Style.TextColor = ColorTranslator.FromHtml("#C4C4C4");
                e.Handled = true;
            }
            if (e.Style.CellType == "PivotGridExpandCell" || e.Style.CellType == "PivotGridHeaderCell")
            {
                e.Style.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(130, 130, 130));
                e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(130, 130, 130));
            }
            else
            {
                e.Style.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(93, 93, 93));
                e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(93, 93, 93));
            }

        }

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

        //Make a Metro Style for Scroll
        private void GridScrollMetroStyle()
        {
            this.pivotGridControl1.TableControl.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.pivotGridControl1.TableControl.MetroColorTable.ScrollerBackground = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.MetroColorTable.ThumbChecked = ColorTranslator.FromHtml("#989898");
            this.pivotGridControl1.TableControl.MetroColorTable.ThumbNormal = ColorTranslator.FromHtml("#989898");
            this.pivotGridControl1.TableControl.MetroColorTable.ThumbPushed = ColorTranslator.FromHtml("#989898");
            this.pivotGridControl1.TableControl.MetroColorTable.ArrowChecked = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.MetroColorTable.ArrowPushed = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.MetroColorTable.ArrowNormal = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.MetroColorTable.ArrowInActive = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableModel.Properties.BackgroundColor = ColorTranslator.FromHtml("#171717");
            
            this.InitializeMetroTheme(this.pivotGridControl1.TableControl.GridRowList);
            this.InitializeMetroTheme(this.pivotGridControl1.TableControl.GridValueList);
            this.InitializeMetroTheme(this.pivotGridControl1.TableControl.PivotTableFieldList);
            this.InitializeMetroTheme(this.pivotGridControl1.TableControl.GridColumnList);
            this.InitializeMetroTheme(this.pivotGridControl1.TableControl.GridFilterList);

        }

        //Initialize the Metro theme
        private void InitializeMetroTheme(GridList gridlist)
        {
            gridlist.MetroColorTable.ScrollerBackground = ColorTranslator.FromHtml("#171717");
            gridlist.MetroColorTable.ThumbChecked = ColorTranslator.FromHtml("#989898");
            gridlist.MetroColorTable.ThumbNormal = ColorTranslator.FromHtml("#989898");
            gridlist.MetroColorTable.ArrowChecked = ColorTranslator.FromHtml("#171717");
            gridlist.MetroColorTable.ArrowPushed = ColorTranslator.FromHtml("#171717");
            gridlist.MetroColorTable.ArrowNormal = ColorTranslator.FromHtml("#171717");
            gridlist.MetroColorTable.ArrowInActive = ColorTranslator.FromHtml("#171717");
            gridlist.Properties.BackgroundColor = ColorTranslator.FromHtml("#171717");
            
            this.pivotGridControl1.ShowPivotTableFieldList = false;
            this.pivotGridControl1.ShowPivotTableFieldList = true;

            this.pivotGridControl1.TableControl.MetroStyle.PivotTable.Heading.BackColor = ColorTranslator.FromHtml("#232323");
            this.pivotGridControl1.TableControl.MetroStyle.PivotTable.Heading.ForeColor = ColorTranslator.FromHtml("#CDCCCC");
            this.pivotGridControl1.TableControl.MetroStyle.GroupBar.BackColor = ColorTranslator.FromHtml("#4F4F4F");
            this.pivotGridControl1.TableControl.MetroStyle.FilterBar.BackColor = ColorTranslator.FromHtml("#232323");
            this.pivotGridControl1.TableControl.MetroStyle.FilterBar.ForeColor = ColorTranslator.FromHtml("#CDCCCC");
            this.pivotGridControl1.TableControl.MetroStyle.RowGroupBar.BackColor = ColorTranslator.FromHtml("#4F4F4F");
            this.pivotGridControl1.TableControl.MetroStyle.PivotTable.PivotFieldList.BackColor = ColorTranslator.FromHtml("#171717");
            this.pivotGridControl1.TableControl.MetroStyle.PivotTable.PivotFieldList.ForeColor = ColorTranslator.FromHtml("#CDCCCC");
            this.pivotGridControl1.TableControl.MetroStyle.PivotTable.Button.BackColor = ColorTranslator.FromHtml("#2F6C9C");
            this.pivotGridControl1.TableControl.MetroStyle.PivotTable.Button.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.pivotGridControl1.TableControl.MetroStyle.PivotItems.BackColor = ColorTranslator.FromHtml("#2F6C9C");
            this.pivotGridControl1.TableControl.MetroStyle.PivotItems.ForeColor = Color.Red;// ColorTranslator.FromHtml("#FFFFFF");


            GridMetroColors color = new GridMetroColors();
            color.HeaderColor.NormalColor = ColorTranslator.FromHtml("#232323");
            color.HeaderTextColor.NormalTextColor = Color.FromArgb(210, 211, 212);
            color.HeaderTextColor.HoverTextColor = Color.FromArgb(210, 211, 212);
            color.HeaderColor.HoverColor = Color.FromArgb(70, 70, 70);
            color.HeaderColor.PressedColor = Color.FromArgb(109, 109, 109);
            color.HeaderBottomBorderColor = Color.FromArgb(79, 79, 79);

            this.pivotGridControl1.TableControl.RowGroupDropArea.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.FilterArea.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.FilterArea.BackColor = ColorTranslator.FromHtml("#232323");
            this.pivotGridControl1.TableControl.GroupDropArea.BackColor = ColorTranslator.FromHtml("#232323");
            this.pivotGridControl1.TableControl.GroupDropArea.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.GridRowList.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.GridColumnList.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.GridFilterList.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.GridValueList.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.PivotTableFieldList.SetMetroStyle(color);
            this.pivotGridControl1.TableControl.GridColumnList.DrawCell += new GridDrawCellEventHandler(GridColumnList_DrawCell);
            this.pivotGridControl1.TableControl.GridRowList.DrawCell += new GridDrawCellEventHandler(GridRowList_DrawCell);
            this.pivotGridControl1.TableControl.GridValueList.DrawCell += new GridDrawCellEventHandler(GridValueList_DrawCell);
            this.pivotGridControl1.TableControl.GridFilterList.DrawCell += new GridDrawCellEventHandler(GridFilterList_DrawCell);
        }

        void MetroColorsCustomization(GridList gridlist)
        {
            gridlist.MetroColorTable.ScrollerBackground = ColorTranslator.FromHtml("#171717");
            gridlist.MetroColorTable.ThumbChecked = ColorTranslator.FromHtml("#989898");
            gridlist.MetroColorTable.ThumbNormal = ColorTranslator.FromHtml("#989898");
            gridlist.MetroColorTable.ArrowChecked = ColorTranslator.FromHtml("#171717");
            gridlist.MetroColorTable.ArrowPushed = ColorTranslator.FromHtml("#171717");
            gridlist.MetroColorTable.ArrowNormal = ColorTranslator.FromHtml("#171717");
            gridlist.MetroColorTable.ArrowInActive = ColorTranslator.FromHtml("#171717");
            gridlist.Properties.BackgroundColor = ColorTranslator.FromHtml("#171717");
        }

        #endregion

        void GridFilterList_DrawCell(object sender, GridDrawCellEventArgs e)
        {
            e.Style.TextColor = Color.FromArgb(196, 196, 196);
        }

        void GridValueList_DrawCell(object sender, GridDrawCellEventArgs e)
        {
            e.Style.TextColor = Color.FromArgb(196, 196, 196);            
        }

        void GridRowList_DrawCell(object sender, GridDrawCellEventArgs e)
        {
            e.Style.TextColor = Color.FromArgb(196, 196, 196);     
        }

        void GridColumnList_DrawCell(object sender, GridDrawCellEventArgs e)
        {
            e.Style.TextColor = Color.FromArgb(196, 196, 196);
        }

        #region DataSource

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

            //Generate the data for DataSource
            public static ProductSalesCollection GetSalesData()
            {
                /// Geography
                string[] countries = new string[] { "Australia", "Canada", "France"/*, "Germany", "United Kingdom", "United States"*/ };
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowGroupBar = !this.pivotGridControl1.ShowGroupBar;
        }



        #endregion

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowGroupBar = checkBox1.Checked;
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowSubTotals = checkBox2.Checked;
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowGrandTotals = checkBox3.Checked;
        }

        
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            this.pivotGridControl1.SuspendLayout();
            this.pivotGridControl1.ShowPivotTableFieldList = checkBoxAdv1.Checked;
            if (checkBoxAdv1.Checked)
                this.EntireCustomization();
            this.pivotGridControl1.ResumeLayout(true);
            this.pivotGridControl1.Refresh();
            LockWindowUpdate(IntPtr.Zero);
            this.pivotGridControl1.TableControl.Refresh();
            this.pivotGridControl1.PivotSchemaDesigner.Refresh();
            this.pivotGridControl1.Refresh();
        }
        bool isChecked = false;
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            if (this.checkBoxAdv2.Checked)
            {
                this.pivotGridControl1.RightToLeft = RightToLeft.Yes;
            }
            else
                this.pivotGridControl1.RightToLeft = RightToLeft.No;
            this.EntireCustomization();
            LockWindowUpdate(IntPtr.Zero);
            this.pivotGridControl1.TableControl.Refresh();
            this.pivotGridControl1.PivotSchemaDesigner.Refresh();
            this.pivotGridControl1.Refresh();
        }
    }
}
