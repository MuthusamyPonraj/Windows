#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette
            chart.Skins = Skins.Metro;
            #endregion

            #region Chart Appearance Customization

            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes Customization

            
            chart.PrimaryXAxis.Title = "Month";
            chart.PrimaryYAxis.Title = "Sales";
            chart.Text = "Sales per Month";
            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[0].ConfigItems.ColumnItem.CornerRadius = new SizeF(10, 10);        
            chart.PrimaryXAxis.TitleSpacing = 2;
            chart.Series3D = false;

            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Legend.BackColor = Color.Transparent;
            chart.Legend.Border.ForeColor = Color.Transparent;
            chart.Legend.ItemsSize = new Size(13, 13);
            chart.Legend.Items[0].Spacing = 2;
            
            #endregion
        }

      public static void ApplyChartStyles1(ChartControl chart)
        {
            #region ApplyCustomPalette
            chart.Skins = Skins.Metro;
            #endregion

            #region Chart Appearance Customization
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes Customization
             chart.PrimaryXAxis.Title = "Month";
            chart.PrimaryYAxis.Title = "Sales";
            chart.Text = "Sales per Month";
            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[0].ConfigItems.ColumnItem.CornerRadius = new SizeF(2, 2);        
            chart.PrimaryXAxis.TitleSpacing = 2;
            chart.Series3D = false;

            chart.Legend.Visible = false;
            
            #endregion
        }
    }

}
