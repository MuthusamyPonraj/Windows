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
            this.gridDataBoundGrid1.DataSource = ds.Tables["customers"];
            this.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0), GridResizeToFitOptions.NoShrinkSize);
            this.gridDataBoundGrid1.Model.EnableLegacyStyle = false;
            this.gridDataBoundGrid1.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Blue;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.gridDataBoundGrid1.SortBehavior = GridSortBehavior.SingleClick;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.gridDataBoundGrid1.SortColumn(this.gridDataBoundGrid1.Binder.InternalColumns["CompanyName"].Position );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gridDataBoundGrid1.SortColumn(this.gridDataBoundGrid1.Binder.InternalColumns["ContactName"].Position);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.gridDataBoundGrid1.SortColumn(this.gridDataBoundGrid1.Binder.InternalColumns["ContactTitle"].Position);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.gridDataBoundGrid1.SortBehavior = GridSortBehavior.DoubleClick;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.gridDataBoundGrid1.SortBehavior = GridSortBehavior.SingleClick;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.gridDataBoundGrid1.SortBehavior = GridSortBehavior.None;
        }
    }
}