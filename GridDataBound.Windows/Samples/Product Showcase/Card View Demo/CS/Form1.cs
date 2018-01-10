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
using Syncfusion.Windows.Forms.Grid;
using System.IO;
using Syncfusion.GridHelperClasses;

namespace CardViewDemo
{
    public partial class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        DataSet ds;
        GridCardView card = new GridCardView();
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.gridDataBoundGrid1.DefaultRowHeight = 18;
            this.gridDataBoundGrid1.DefaultColWidth = 70;
            ds = new DataSet();
            ReadXml(ds, @"Common\Data\GDBDdata.XML");
            this.gridDataBoundGrid1.DataSource = ds.Tables["Products"];
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridDataBoundGrid1.BackColor = Color.White;
            this.comboBoxAdv2.SelectedIndex = 1;
            this.ComboBoxAdv1.SelectedIndex = 0;

            #region [ CardView... ]

            card.CaptionField = "ProductName";
            card.CardSpacingWidth = 10;
            card.CardSpacingHeight = 10;
            card.MaxCardCols = 5;
            card.CaptionHeight = 35;
            card.CardBackColor = Color.Lavender;
            card.WireGrid(this.gridDataBoundGrid1);
       
            Settings();
            #endregion
        }
     
        private void Settings()
        {
            card.ShowCardCellBorders = checkBox1.Checked ? true : false;
            card.ApplyRoundedCorner = checkBox3.Checked ? true : false;
            card.BrowseOnly = checkBox4.Checked ? true : false;
            card.ShowCaption = checkBox2.Checked ? true : false;
            AutoFit();
        }
        private void AutoFit()
        {
            this.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Table());
            this.gridDataBoundGrid1.Refresh();
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

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.ComboBoxAdv1.SelectedItem.ToString())
            {
                case "Office2010Blue":
                    card.VisualStyle = CardVisualStyles.Office2010Blue;
                    break;
                case "Office2010Black":
                    card.VisualStyle = CardVisualStyles.Office2010Black;
                    break;
                case "Office2010Silver":
                    card.VisualStyle = CardVisualStyles.Office2010Silver;
                    break;
                case "Office2007Blue":
                    card.VisualStyle = CardVisualStyles.Office2007Blue;
                    break;
                case "Office2007Black":
                    card.VisualStyle = CardVisualStyles.Office2007Black;
                    break;
                case "Office2007Silver":
                    card.VisualStyle = CardVisualStyles.Office2007Silver;
                    break;
                case "Metro":
                    card.VisualStyle = CardVisualStyles.Metro;
                    break;
                case "System":
                    card.VisualStyle = CardVisualStyles.System;
                    break;
                default:
                    card.VisualStyle = CardVisualStyles.None;
                    break;
            }
            AutoFit();
        }

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv2.SelectedItem.ToString())
            {
                case "MergedLabels":
                    card.CardStyle = CardStyle.MergedLabels;
                    break;
                case "StandardLabels":
                    card.CardStyle = CardStyle.StandardLabels;
                    this.gridDataBoundGrid1.Model.ColWidths[2] = 25;
                    break;
            }
            AutoFit();
        }

        private void CheckChanged(object sender,  EventArgs e)
        {
            Settings();
        }

    }
}