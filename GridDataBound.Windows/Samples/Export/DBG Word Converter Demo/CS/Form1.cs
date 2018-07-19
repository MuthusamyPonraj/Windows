#region Copyright Syncfusion Inc. 2001 - 2008
//
//  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.GridHelperClasses;

namespace DBGWordConverter_2005
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        private DataSet ds;
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            
            try
            {
                Icon ico = new Icon(GetIconFile(@"Common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch
            { }
        }

        /// <summary>
        /// Get the path of the icon file.
        /// </summary>
        /// <param name="bitmapName">IconFile name.</param>
        /// <returns>Icon file location.</returns>
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
		
        /// <summary>
        /// Loads the 'northwindDataSet.Customers' table into the form1.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            ReadXml(ds, @"Common\Data\GDBDdata.XML");
            this.gridDataBoundGrid1.DataSource = ds.Tables["Customers"];
        }


        /// <summary>
        /// Export the grid contents to word file.
        /// </summary>
        private void btn_Export(object sender, EventArgs e)
        {
            GridWordConverter converter = new GridWordConverter(true,true);
            converter.DrawFooter += new GridWordConverterBase.DrawDocHeaderFooterEventHandler(converter_DrawFooter);
            converter.DrawHeader += new GridWordConverterBase.DrawDocHeaderFooterEventHandler(converter_DrawHeader);
            converter.GridToWord("Sample.doc", gridDataBoundGrid1);
            System.Diagnostics.Process.Start("Sample.doc");
        }

        /// <summary>
        /// Get the path of xml file.
        /// </summary>
        /// <param name="bitmapName">XmlFile name.</param>
        /// <returns>XmlFile location.</returns>
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

        /// <summary>
        /// Header Event to create an header that will display on each page.
        /// </summary>
        void converter_DrawHeader(object sender, DocHeaderFooterEventArgs e)
        {
            e.Header.AddParagraph().AppendText("Syncfusion Inc.");
        }

        /// <summary>
        /// Footer Event to create a footer that will display on each page.
        /// </summary>
        void converter_DrawFooter(object sender, DocHeaderFooterEventArgs e)
        {
            e.Footer.AddParagraph().AppendText("Copyright 2001-2008");
        }
    }
}