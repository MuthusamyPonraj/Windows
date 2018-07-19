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
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using System.IO;

namespace DBGPdfCoverter_2005
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
            ds = new DataSet();
            ReadXml(ds, @"Common\Data\GDBDdata.XML");
            this.gridDataBoundGrid1.DataSource = ds.Tables["Customers"];
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

        // <summary>
        // Loads the 'northwindDataSet.Customers' table into the form1.
        // </summary>        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Export the grid contents to Pdf file.
        /// </summary>
        private void btn_Export(object sender, EventArgs e)
        {

            GridPDFConverter converter = new GridPDFConverter();
            converter.ShowFooter = true;
            converter.ShowHeader = true;
            converter.DrawPDFFooter += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(converter_DrawPDFFooter);
            converter.DrawPDFHeader += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(converter_DrawPDFHeader);
            converter.ExportToPdf("sample.Pdf", gridDataBoundGrid1);
            System.Diagnostics.Process.Start("sample.pdf");
        }

        /// <summary>
        /// Header Event to create an header that will display on each page.
        /// </summary>
        void converter_DrawPDFHeader(object sender, PDFHeaderFooterEventArgs e)
        {
            PdfPageTemplateElement header = e.HeaderFooterTemplate;

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 24);
            float doubleHeight = font.Height * 2;
            Color activeColor = Color.FromArgb(44, 71, 120);
            SizeF imageSize = new SizeF(110f, 35f);
            //Locating the logo on the right corner of the Drawing Surface
            PointF imageLocation = new PointF(e.HeaderFooterTemplate.Width - imageSize.Width - 20, 5);

            PdfImage img = new PdfBitmap(@"../../Icon/logo.png");
            //Draw the image in the Header.
            header.Graphics.DrawImage(img, imageLocation, imageSize);

            PdfSolidBrush brush = new PdfSolidBrush(activeColor);

            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);

            //Set formattings for the text
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;

            //Draw title
            header.Graphics.DrawString("PDF Export Demo", font, brush, new RectangleF(0, 0, header.Width, header.Height), format);
            brush = new PdfSolidBrush(Color.Gray);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);

            format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Left;
            format.LineAlignment = PdfVerticalAlignment.Bottom;

            //Draw description
            header.Graphics.DrawString("Syncfusion Inc.", font, brush, new RectangleF(0, 0, header.Width, header.Height - 8), format);

            //Draw some lines in the header
            pen = new PdfPen(Color.DarkBlue, 0.7f);
            header.Graphics.DrawLine(pen, 0, 0, header.Width, 0);
            pen = new PdfPen(Color.DarkBlue, 2f);
            header.Graphics.DrawLine(pen, 0, 03, header.Width + 3, 03);
            pen = new PdfPen(Color.DarkBlue, 2f);
            header.Graphics.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3);
            header.Graphics.DrawLine(pen, 0, header.Height, header.Width, header.Height);
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
        /// Footer Event to create a footer that will display on each page.
        /// </summary>
        void converter_DrawPDFFooter(object sender, PDFHeaderFooterEventArgs e)
        {
            PdfPageTemplateElement footer = e.HeaderFooterTemplate;

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 8);

            PdfSolidBrush brush = new PdfSolidBrush(Color.Gray);

            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;
            footer.Graphics.DrawString("@Copyright 2008", font, brush, new RectangleF(0, footer.Height - 40, footer.Width, footer.Height), format);

            format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Right;
            format.LineAlignment = PdfVerticalAlignment.Bottom;

            //Create page number field
            PdfPageNumberField pageNumber = new PdfPageNumberField(font, brush);

            //Create page count field
            PdfPageCountField count = new PdfPageCountField(font, brush);

            PdfCompositeField compositeField = new PdfCompositeField(font, brush, "Page {0} of {1}", pageNumber, count);
            compositeField.Bounds = footer.Bounds;
            compositeField.Draw(footer.Graphics, new PointF(470, footer.Height - 10));
        }
    }
}