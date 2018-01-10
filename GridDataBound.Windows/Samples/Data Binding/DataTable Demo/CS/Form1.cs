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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System.IO;

namespace TooltipDemo_2005
{
    public partial class Form1 : Form
    {
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }

            this.gridDataBoundGrid1.DefaultRowHeight = 18;
            this.gridDataBoundGrid1.DefaultColWidth = 70;
            ds = new DataSet();
            ReadXml(ds, @"\common\Data\GDBDdata.XML");
            this.gridDataBoundGrid1.DataSource = ds.Tables["Products"];
            this.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0), GridResizeToFitOptions.NoShrinkSize);
            this.gridDataBoundGrid1.Model.EnableLegacyStyle = false;
            this.gridDataBoundGrid1.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Blue;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        void ReadXml(DataSet ds, string xmlFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }

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
    }
}