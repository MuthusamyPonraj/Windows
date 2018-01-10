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
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Presentation;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.OfficeChart;

namespace Images
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Button btnCreatePresn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
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
            this.btnCreatePresn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(272, 152);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(93, 22);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Create Chart";
            this.btnCreatePresn.UseVisualStyleBackColor = true;
            this.btnCreatePresn.Click += new System.EventHandler(this.btnCreatePresn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view a created Chart in generated Presentation.This"
                + "\r\nsample demonstrates how to add a chart into Presentation.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Creation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [STAThread]
        static void Main()
        {
           
            Application.Run(new Form1());
        }

        #endregion

        private void btnCreatePresn_Click(object sender, EventArgs e)
        {
            try
            {
                IPresentation presentation = Presentation.Create();
                //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

                //Method call to edit slides
                CreateSlide1(presentation);
                presentation.Save("ChartCreationSample.pptx");

                if (MessageBox.Show("Do you want to view the created PowerPoint presentation?", "PowerPoint presentation Created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start("ChartCreationSample.pptx");
                    this.Close();

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("This file could not be created , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);

            }
        }
        # region Slide1
        private void CreateSlide1(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides.Add(SlideLayoutType.Blank);
            IPresentationChart chart = slide1.Shapes.AddChart(1.93 * 72, 0.31 * 72, 9.48 * 72, 6.89 * 72);


            chart.ChartData.SetValue(1, 1, "Crescent City, CA");

            chart.ChartData.SetValue(3,2, "Precipitation,in.");
            chart.ChartData.SetValue(3, 3, "Temperature,deg.F");

            chart.ChartData.SetValue(4, 1, "Jan");
            chart.ChartData.SetValue(5, 1, "Feb");
            chart.ChartData.SetValue(6, 1, "March");
            chart.ChartData.SetValue(7, 1, "Apr");
            chart.ChartData.SetValue(8, 1, "May");
            chart.ChartData.SetValue(9, 1, "June");
            chart.ChartData.SetValue(10, 1, "July");
            chart.ChartData.SetValue(11, 1, "Aug");
            chart.ChartData.SetValue(12, 1, "Sept");
            chart.ChartData.SetValue(13, 1, "Oct");
            chart.ChartData.SetValue(14,1, "Nov");
            chart.ChartData.SetValue(15, 1, "Dec");

            chart.ChartData.SetValue(4, 2, 10.9);
            chart.ChartData.SetValue(5, 2, 8.9);
            chart.ChartData.SetValue(6, 2, 8.6);
            chart.ChartData.SetValue(7, 2, 4.8);
            chart.ChartData.SetValue(8, 2, 3.2);
            chart.ChartData.SetValue(9, 2, 1.4);
            chart.ChartData.SetValue(10, 2, 0.6);
            chart.ChartData.SetValue(11, 2, 0.7);
            chart.ChartData.SetValue(12, 2, 1.7);
            chart.ChartData.SetValue(13, 2, 5.4);
            chart.ChartData.SetValue(14, 2, 9.0);
            chart.ChartData.SetValue(15, 2, 10.4);

            chart.ChartData.SetValue(4, 3, 47.5);
            chart.ChartData.SetValue(5, 3, 48.7);
            chart.ChartData.SetValue(6, 3, 48.9);
            chart.ChartData.SetValue(7, 3, 50.2);
            chart.ChartData.SetValue(8, 3, 53.1);
            chart.ChartData.SetValue(9, 3, 56.3);
            chart.ChartData.SetValue(10, 3, 58.1);
            chart.ChartData.SetValue(11, 3, 59.0);
            chart.ChartData.SetValue(12, 3, 58.5);
            chart.ChartData.SetValue(13, 3, 55.4);
            chart.ChartData.SetValue(14, 3, 51.1);
            chart.ChartData.SetValue(15, 3, 47.8);

            chart.DataRange = chart.ChartData[3, 1, 15, 3];
            chart.ChartTitle = "Crescent City, CA";
            chart.PrimaryValueAxis.Title = "Precipitation,in.";
            chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90;
            chart.PrimaryValueAxis.MaximumValue = 14.0;
            chart.PrimaryValueAxis.NumberFormat = "0.0";

            #region Format Series
            // Format serie
            IOfficeChartSerie serieOne = chart.Series[0];
            serieOne.Name = "Precipitation,in.";
            serieOne.SerieFormat.Fill.FillType = OfficeFillType.Gradient;
            serieOne.SerieFormat.Fill.TwoColorGradient(OfficeGradientStyle.Vertical, OfficeGradientVariants.ShadingVariants_2);
            serieOne.SerieFormat.Fill.GradientColorType = OfficeGradientColor.TwoColor;
            serieOne.SerieFormat.Fill.ForeColor = Color.Plum;

            //Show value as data labels
            serieOne.DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            serieOne.DataPoints.DefaultDataPoint.DataLabels.Position = OfficeDataLabelPosition.Outside;

            //Format the second serie
            IOfficeChartSerie serieTwo = chart.Series[1];
            serieTwo.SerieType = OfficeChartType.Line_Markers;
            serieTwo.Name = "Temperature,deg.F";

            //Format marker
            serieTwo.SerieFormat.MarkerStyle = OfficeChartMarkerType.Diamond;
            serieTwo.SerieFormat.MarkerSize = 8;
            serieTwo.SerieFormat.MarkerBackgroundColor = Color.DarkGreen;
            serieTwo.SerieFormat.MarkerForegroundColor = Color.DarkGreen;
            serieTwo.SerieFormat.LineProperties.LineColor = Color.DarkGreen;

            //Use Secondary Axis
            serieTwo.UsePrimaryAxis = false;
            #endregion

            #region Set the Secondary Axis for Second Serie.
            //Display secondary axis for the series.
            chart.SecondaryCategoryAxis.IsMaxCross = true;
            chart.SecondaryValueAxis.IsMaxCross = true;

            //Set the title
            chart.SecondaryValueAxis.Title = "Temperature,deg.F";
            chart.SecondaryValueAxis.TitleArea.TextRotationAngle = 90;

            //Hide the secondary category axis
            chart.SecondaryCategoryAxis.Border.LineColor = Color.Transparent;
            chart.SecondaryCategoryAxis.MajorTickMark = OfficeTickMark.TickMark_None;
            chart.SecondaryCategoryAxis.TickLabelPosition = OfficeTickLabelPosition.TickLabelPosition_None;
            #endregion

            #region Legend setting
            chart.Legend.Position = OfficeLegendPosition.Bottom;
            chart.Legend.IsVerticalLegend = false;
            #endregion


        }
        #endregion

    }
}
