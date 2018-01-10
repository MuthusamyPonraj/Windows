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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace RatingCustomizationDemo
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panel5.Enabled = false;
            this.panel4.Visible = false;
            this.checkBoxAdv2.Enabled = false;
            this.ratingControl7.ResetButtonSettings.MouseEnter += new EventHandler(ResetButton_MouseEnter);
            this.ratingControl7.ResetButtonSettings.MouseLeave += new EventHandler(ResetButton_MouseLeave);
            this.ratingControl7.ResetButtonSettings.Paint += new PaintEventHandler(ResetButton_Paint);
            this.ratingControl7.ResetButtonSettings.Click += new EventHandler(ResetButton_Click);
            this.ratingControl7.ValueChanging+=new Syncfusion.Windows.Forms.Tools.ValueChangingEventHandler(ratingControl7_ValueChanging);
            using (Graphics g = CreateGraphics())
            {
                if (g.DpiX > 96)
                {
                    this.ratingControl7.Size = new Size(497, 28);
                    this.ratingControl7.ResetButtonSettings.Size = new Size(24, 16);
                }
            }
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }
        void ResetButton_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(br, e.ClipRectangle);
            if (ismouseover)
            {
                e.Graphics.DrawImage(this.ratingControl7.ResetButtonSettings.BackgroundImage, e.ClipRectangle);
            }
            else
            {
                e.Graphics.DrawImage(this.ratingControl7.ResetButtonSettings.BackgroundImage, e.ClipRectangle);
            }

            br.Dispose();

        }
        bool ismouseover = false;
        void ResetButton_MouseLeave(object sender, EventArgs e)
        {
            ismouseover = false;
            this.ratingControl7.ResetButtonSettings.BackgroundImage = global::RatingCustomizationDemo.Properties.Resources._02;
            this.textBoxExt4.Text = this.textBoxExt4.Text + Environment.NewLine + "MouseLeaved on Reset Button";
        }

        void ResetButton_MouseEnter(object sender, EventArgs e)
        {
            ismouseover = true;
            this.ratingControl7.ResetButtonSettings.BackgroundImage = global::RatingCustomizationDemo.Properties.Resources._01;
            this.textBoxExt4.Text = this.textBoxExt4.Text + Environment.NewLine + "MouseEntered on Reset Button";
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
        void ResetButton_Click(object sender, EventArgs e)
        {
            this.textBoxExt4.Text = this.textBoxExt4.Text + Environment.NewLine + "Reset Button Clicked";
        }

        void ratingControl7_ValueChanging(object sender, Syncfusion.Windows.Forms.Tools.ValueChangingEventArgs args)
        {
            this.textBoxExt4.Text =this.textBoxExt4.Text +Environment.NewLine+ "Rating Control value changed to :" + args.Value;
        }
        private void buttonAdv7_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv7.BackColor;
        }

        private void buttonAdv8_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv8.BackColor;
        }

        private void buttonAdv9_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv9.BackColor;
        }

        private void buttonAdv10_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv10.BackColor;
        }

        private void buttonAdv11_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv11.BackColor;
        }

        private void buttonAdv12_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv12.BackColor;
        }

        private void buttonAdv6_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv6.BackColor;
        }

        private void buttonAdv5_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv5.BackColor;
        }

        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv4.BackColor;
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv3.BackColor;
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv2.BackColor;
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv1.BackColor;
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.ratingControl7.ReadOnly = this.checkBoxAdv1.Checked;
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            this.ratingControl7.ApplyGradientColors = this.checkBoxAdv2.Checked;
            this.panel4.Visible = !this.checkBoxAdv2.Checked;
        }

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.panel4.Visible = false;
            this.panel5.Enabled = false;
            this.checkBoxAdv2.Enabled = false;
            switch (comboBoxAdv2.SelectedIndex)
            {
                case 0:
                    {
                        this.checkBoxAdv2.Enabled =true;
                        this.ratingControl7.ResetButton.BackColor = SystemColors.Control;
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Default;
                        this.panel4.Visible = true;
                    }
                    break;
                case 1:
                    {
                        this.ratingControl7.ResetButton.BackColor = Color.FromArgb(22,165,220);
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Metro;
                    }
                    break;
                case 2:
                    {
                        this.panel5.Enabled = true;
                        this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Blue;
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2007;
                    }
                    break;
                case 3:
                    {
                        this.panel5.Enabled = true;
                        this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Blue;
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2010;
                    }
                    break;
            }
        }

        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv3.SelectedIndex)
            {
                case 0:
                    this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Blue;
                    break;
                case 1:
                    this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Silver;
                    break;
                case 2:
                    this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Black;
                    break;
                case 3:
                    this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Managed;
                    break;
            }
        }
        private void comboBoxAdv4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv4.SelectedIndex)
            {
                case 0:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Star;
                    break;
                case 1:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Diamond;
                    break;
                case 2:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Circle;
                    break;
                case 3:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Triangle;
                    break;
                case 4:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Kite;
                    break;
                case 5:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Heart;
                    break;
            }
        }

        private void comboBoxAdv5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv5.SelectedIndex)
            {
                case 0:
                    this.ratingControl7.ItemsCount = 1;
                    break;
                case 1:
                    this.ratingControl7.ItemsCount = 2;
                    break;
                case 2:
                    this.ratingControl7.ItemsCount = 3;
                    break;
                case 3:
                    this.ratingControl7.ItemsCount = 4;
                    break;
                case 4:
                    this.ratingControl7.ItemsCount = 5;
                    break;
                case 5:
                    this.ratingControl7.ItemsCount = 6;
                    break;
                case 6:
                    this.ratingControl7.ItemsCount = 7;
                    break;
                case 7:
                    this.ratingControl7.ItemsCount = 8;
                    break;
                case 8:
                    this.ratingControl7.ItemsCount = 9;
                    break;
            }
        }

        private void comboBoxAdv6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxAdv6.SelectedIndex)
            {
                case 0:
                    this.ratingControl7.ItemBorderWeight = 1;
                    break;
                case 1:
                    this.ratingControl7.ItemBorderWeight = 2;
                    break;
                case 2:
                    this.ratingControl7.ItemBorderWeight = 3;
                    break;
            }
        }
    }
}
