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
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using Syncfusion.OCRProcessor;
using Syncfusion.Windows.Forms;
using System.IO;


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
        private TextBox textBox1;
        private Button button2;
        private string filePath = string.Empty;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        
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
            Application.EnableVisualStyles();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            filePath = GetFullTemplatePath("image.tif",true);
            this.textBox1.Text = "image.tif";
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(457, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process OCR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 110);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button below to generate a searchable PDF, OCRed using the Tesseract en" +
    "gine. Please note that PDF Viewer or its equivalent to view the resultant docume" +
    "nt.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 130);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 26);
            this.textBox1.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 32);
            this.button2.TabIndex = 26;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 272);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 24);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Save as Text";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(225, 272);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 24);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Save as PDF";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 313);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

            // Create a new instance of PdfDocument class.
            PdfDocument document = new PdfDocument();

            //// Add a page to the document.
            PdfPage page = document.Pages.Add();

            //Initialize the OCR processor by providing the path of the tesseract binaries
            using (OCRProcessor processor = new OCRProcessor(GetFullTemplatePath(@"OCR\Tesseract binaries")))
            {
                //Language to process the OCR
                processor.Settings.Language = Languages.English;
                if (this.radioButton2.Checked)
                {
                    //loading the input image
                    PdfBitmap bitmap = new PdfBitmap(filePath);
                    document.Pages[0].Graphics.DrawImage(bitmap, new RectangleF(0, 0, page.Graphics.ClientSize.Width, page.Graphics.ClientSize.Height));
                    MemoryStream stream = new MemoryStream();
                    document.Save(stream);
                    //Load the PDF document 
                    PdfLoadedDocument lDoc = new PdfLoadedDocument(stream);
                    //Process OCR by providing loaded PDF document, Data dictionary and language
                    processor.PerformOCR(lDoc, GetFullTemplatePath(@"OCR/Tessdata/"));
                    lDoc.Save("Output.pdf");
                    lDoc.Close();
                    lDoc.Dispose();
                    stream.Close();
                    stream.Dispose();
                }
                else
                {
                    //loading the input image
                    Bitmap bitmap = new Bitmap(filePath);
                    string ocrText = processor.PerformOCR(bitmap, GetFullTemplatePath(@"OCR/Tessdata/"));
                    StreamWriter fileStream = new StreamWriter("Output.txt");
                    fileStream.WriteLine(ocrText);
                    fileStream.Dispose();
                }
            }

             //Message box confirmation to view the created PDF document.
                if (MessageBox.Show("Do you want to view the file?", "File Created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.Yes)
                {
                    
                    //Launching the PDF file using the default Application.[Acrobat Reader]
                    if(this.radioButton2.Checked)
                        System.Diagnostics.Process.Start("Output.pdf");
                    else
                        System.Diagnostics.Process.Start("Output.txt");

                }

                this.Close();
          
        }
        # endregion
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
    
        private void button2_Click(object sender, EventArgs e)
        {
            FileDialog file = new OpenFileDialog();
            file.Filter = "(*.bmp, *.jpg, *.tif, *.tiff,*.bmp,*.png)|*.bmp;*.jpg;*.tif;*.tiff;*.bmp;*.png";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Get file extension
                filePath = file.FileName;
                this.textBox1.Text = filePath;
            }
        }
       
    }
}