#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Graphics;
using Syncfusion.OCRProcessor;
using Syncfusion.Pdf.Parsing;
using System.Collections.Generic;

namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        # region Private Members
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Panel panelRegion;
        private GroupBox groupRegion;
        private Label lblXCoordinate;
        private Label lblHeight;
        private Label lblYCoordinate;
        private Label lblWidth;
        private NumericUpDown txtXCoordinate;
        private NumericUpDown txtWidth;
        private NumericUpDown txtYCoordinate;
        private NumericUpDown txtHeight;
        private RadioButton rbtnFullDocument;
        private RadioButton rbtnRegion;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        # endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRegion = new System.Windows.Forms.Panel();
            this.groupRegion = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.NumericUpDown();
            this.txtYCoordinate = new System.Windows.Forms.NumericUpDown();
            this.txtWidth = new System.Windows.Forms.NumericUpDown();
            this.txtXCoordinate = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblYCoordinate = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblXCoordinate = new System.Windows.Forms.Label();
            this.rbtnFullDocument = new System.Windows.Forms.RadioButton();
            this.rbtnRegion = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRegion.SuspendLayout();
            this.groupRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYCoordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXCoordinate)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
           //
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(254, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button below to generate a searchable PDF, OCRed using the Tesseract en" +
                "gine. Please note that PDF Viewer or its equivalent to view the resultant docume" +
                "nt.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 89);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panelRegion
            // 
            this.panelRegion.Controls.Add(this.groupRegion);
            this.panelRegion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRegion.Location = new System.Drawing.Point(0, 188);
            this.panelRegion.Name = "panelRegion";
            this.panelRegion.Size = new System.Drawing.Size(372, 106);
            this.panelRegion.TabIndex = 26;
            this.panelRegion.Visible = false;
            // 
            // groupRegion
            // 
            this.groupRegion.Controls.Add(this.txtHeight);
            this.groupRegion.Controls.Add(this.txtYCoordinate);
            this.groupRegion.Controls.Add(this.txtWidth);
            this.groupRegion.Controls.Add(this.txtXCoordinate);
            this.groupRegion.Controls.Add(this.lblHeight);
            this.groupRegion.Controls.Add(this.lblYCoordinate);
            this.groupRegion.Controls.Add(this.lblWidth);
            this.groupRegion.Controls.Add(this.lblXCoordinate);
            this.groupRegion.Location = new System.Drawing.Point(22, 12);
            this.groupRegion.Name = "groupRegion";
            this.groupRegion.Size = new System.Drawing.Size(307, 82);
            this.groupRegion.TabIndex = 0;
            this.groupRegion.TabStop = false;
            this.groupRegion.Text = "Region";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(229, 58);
            this.txtHeight.Maximum = new decimal(new int[] {
            1684,
            0,
            0,
            0});
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(40, 20);
            this.txtHeight.TabIndex = 30;
            // 
            // txtYCoordinate
            // 
            this.txtYCoordinate.Location = new System.Drawing.Point(229, 21);
            this.txtYCoordinate.Maximum = new decimal(new int[] {
            1684,
            0,
            0,
            0});
            this.txtYCoordinate.Name = "txtYCoordinate";
            this.txtYCoordinate.Size = new System.Drawing.Size(40, 20);
            this.txtYCoordinate.TabIndex = 29;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(73, 58);
            this.txtWidth.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(40, 20);
            this.txtWidth.TabIndex = 28;
            // 
            // txtXCoordinate
            // 
            this.txtXCoordinate.Location = new System.Drawing.Point(73, 18);
            this.txtXCoordinate.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.txtXCoordinate.Name = "txtXCoordinate";
            this.txtXCoordinate.Size = new System.Drawing.Size(42, 20);
            this.txtXCoordinate.TabIndex = 27;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(182, 58);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(44, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height :";
            // 
            // lblYCoordinate
            // 
            this.lblYCoordinate.AutoSize = true;
            this.lblYCoordinate.Location = new System.Drawing.Point(182, 21);
            this.lblYCoordinate.Name = "lblYCoordinate";
            this.lblYCoordinate.Size = new System.Drawing.Size(44, 13);
            this.lblYCoordinate.TabIndex = 4;
            this.lblYCoordinate.Text = "Y         :";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(32, 57);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width :";
            // 
            // lblXCoordinate
            // 
            this.lblXCoordinate.AutoSize = true;
            this.lblXCoordinate.Location = new System.Drawing.Point(32, 20);
            this.lblXCoordinate.Name = "lblXCoordinate";
            this.lblXCoordinate.Size = new System.Drawing.Size(41, 13);
            this.lblXCoordinate.TabIndex = 0;
            this.lblXCoordinate.Text = "X        :";
            // 
            // rbtnFullDocument
            // 
            this.rbtnFullDocument.AutoSize = true;
            this.rbtnFullDocument.Checked = true;
            this.rbtnFullDocument.Location = new System.Drawing.Point(22, 149);
            this.rbtnFullDocument.Name = "rbtnFullDocument";
            this.rbtnFullDocument.Size = new System.Drawing.Size(121, 17);
            this.rbtnFullDocument.TabIndex = 27;
            this.rbtnFullDocument.TabStop = true;
            this.rbtnFullDocument.Text = "Complete Document";
            this.rbtnFullDocument.UseVisualStyleBackColor = true;
            // 
            // rbtnRegion
            // 
            this.rbtnRegion.AutoSize = true;
            this.rbtnRegion.Location = new System.Drawing.Point(152, 149);
            this.rbtnRegion.Name = "rbtnRegion";
            this.rbtnRegion.Size = new System.Drawing.Size(59, 17);
            this.rbtnRegion.TabIndex = 28;
            this.rbtnRegion.TabStop = true;
            this.rbtnRegion.Text = "Region";
            this.rbtnRegion.UseVisualStyleBackColor = true;
            this.rbtnRegion.CheckedChanged += new System.EventHandler(this.rbtnRegion_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 294);
            this.Controls.Add(this.rbtnRegion);
            this.Controls.Add(this.rbtnFullDocument);
            this.Controls.Add(this.panelRegion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRegion.ResumeLayout(false);
            this.groupRegion.ResumeLayout(false);
            this.groupRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYCoordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXCoordinate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());

        }
        #endregion

        # region Events
        private void button1_Click(object sender, System.EventArgs e)
        {
            //Initialize the OCR processor
            using (OCRProcessor processor = new OCRProcessor(GetFullTemplatePath(@"OCR\Tesseract binaries")))
            {
                //Load the PDF document 
                PdfLoadedDocument lDoc = new PdfLoadedDocument(GetFullTemplatePath("Region.pdf"));
                //Language to process the OCR
                processor.Settings.Language = Languages.English;
                if (rbtnRegion.Checked)
                {
                    int x = 0;
                    int y = 0;
                    int width = 0;
                    int height = 0;
                    int.TryParse(txtXCoordinate.Text, out x);
                    int.TryParse(txtYCoordinate.Text, out y);
                    int.TryParse(txtWidth.Text, out width);
                    int.TryParse(txtHeight.Text, out height);
                    RectangleF rect = new RectangleF(x, y, width, height);
                    //Assign the rectangles to the page
                    PageRegion region = new PageRegion();
                    List<PageRegion> pageRegions = new List<PageRegion>();
                    region.PageIndex = 0;
                    region.PageRegions = new RectangleF[] { rect };
                    pageRegions.Add(region);
                    processor.Settings.Regions = pageRegions;
                }
                //Process OCR by providing loaded PDF document, Data dictionary and language
                processor.PerformOCR(lDoc, GetFullTemplatePath(@"OCR/Tessdata/"));
                //Save the OCR processed PDF document in the disk
                lDoc.Save("Sample.pdf");
                lDoc.Close(true);
            }
            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }
        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName)
        {
            string fullPath = @"..\..\..\..\..\..\..\..\Common\";
            string folder = "Data\\PDF";

            return string.Format(@"{0}{1}\{2}", fullPath, folder, fileName);
        }
		 /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
            string fullPath = @"..\..\..\..\..\..\..\..\Common\";
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }
        # endregion

        private void rbtnRegion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRegion.Checked)
            {
                this.Height = 328;
                panelRegion.Visible = true;
            }
            else
            {
                this.Height = 218;
                panelRegion.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 218;
        }
    }
}