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
using System.Text.RegularExpressions;

namespace Radial
{
    public partial class Form1 : MetroForm
    {
        #region Initialization
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.radialSlider1.RangeStyle = Syncfusion.Windows.Forms.Tools.RangeStyles.Solid;
            this.radialSlider1.ValueChanged += new Syncfusion.Windows.Forms.Tools.RadialSlider.ValueChangedEventHandler(radialSlider1_ValueChanged);
            ScrollersFrame Sframe = new ScrollersFrame();
            Sframe.VisualStyle = ScrollBarCustomDrawStyles.Metro;
            Sframe.AttachedTo = this.richTextBox1;
        }
        #endregion
        #region Form Icon
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
        #endregion
        #region events
        #region Customize value

        Char[] unallowedchar = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+' };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < unallowedchar.Length; i++)
                {
                    {
                        if (textBox1.Text.Contains(unallowedchar[i]))
                        {
                            textBox1.Text = String.Empty;
                            MessageBoxAdv.Show("No special characters allowed","Invalid Input");
                        }
                    }
                }

                if (textBox1.Text != string.Empty)
                    this.radialSlider1.SliderDivision = Convert.ToInt32(this.textBox1.Text);
            }
            catch (Exception)
            {
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < unallowedchar.Length; i++)
                {
                    {
                        if (textBox2.Text.Contains(unallowedchar[i]))
                        {
                            textBox2.Text = String.Empty;
                            MessageBoxAdv.Show("No special characters allowed", "Invalid Input");
                        }
                    }
                }
                if (textBox2.Text != string.Empty)
                    this.radialSlider1.MaximumValue = Convert.ToInt32(this.textBox2.Text);
            }
            catch (Exception)
            {
            }
        }
        #endregion
        #region OuterCircle
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.radialSlider1.ShowOuterCircle = this.checkBox1.Checked;
        }

        #endregion
        #region SliderValueChanged
        private void radialSlider1_ValueChanged(object sender, Syncfusion.Windows.Forms.Tools.RadialSlider.ValueChangedEventArgs args)
        {
            if (this.richTextBox1.SelectedText.Length == 0)
            {
                this.richTextBox1.SelectAll();
            }
            if (this.radialSlider1.Value > 0)
            {
                this.richTextBox1.SelectionFont = new System.Drawing.Font(Font.Name, (float)this.radialSlider1.Value);//
                this.Refresh();
            }
        }
        #endregion
        #region SliderFrame
        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv1.Checked)
            {
                this.radialSlider1.SliderStyle = Syncfusion.Windows.Forms.Tools.SliderStyles.Default;
                radioButtonAdv3.Enabled = radioButtonAdv4.Enabled = true;
                checkBoxAdv1.Enabled = true;
                colorPickerButton1.Enabled = colorPickerButton2.Enabled = colorPickerButton3.Enabled = colorPickerButton4.Enabled = true;
                this.groupBox1.Enabled = true;
            }
        }

        private void radioButtonAdv2_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv2.Checked)
            {
                this.radialSlider1.SliderStyle = Syncfusion.Windows.Forms.Tools.SliderStyles.Frame;
                radioButtonAdv3.Enabled = radioButtonAdv4.Enabled = false;
                checkBoxAdv1.Enabled = false;
                colorPickerButton1.Enabled = colorPickerButton2.Enabled = colorPickerButton3.Enabled = colorPickerButton4.Enabled = false;
                this.groupBox1.Enabled = false;
            }
        }
        #endregion
        #region SliderCustomization
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.radialSlider1.ShowOuterCircle = checkBoxAdv1.Checked;
        }
        private void radioButtonAdv3_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv3.Checked)
                this.radialSlider1.NeedleType = Syncfusion.Windows.Forms.Tools.SliderNeedleType.StraightLine;
        }

        private void radioButtonAdv4_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv4.Checked)
                this.radialSlider1.NeedleType = Syncfusion.Windows.Forms.Tools.SliderNeedleType.DottedLine;
        }

        private void colorPickerButton3_ColorSelected_1(object sender, EventArgs e)
        {
            this.radialSlider1.InnerCircleColor = colorPickerButton3.SelectedColor;
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.radialSlider1.SliderNeedleColor = colorPickerButton1.SelectedColor;
        }

        private void colorPickerButton4_ColorSelected(object sender, EventArgs e)
        {
            this.radialSlider1.LinesColor = colorPickerButton4.SelectedColor;
        }

        private void colorPickerButton5_ColorSelected(object sender, EventArgs e)
        {
            this.radialSlider1.ForeColor = colorPickerButton5.SelectedColor;
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.radialSlider1.OuterCircleColor = colorPickerButton2.SelectedColor;
        }
        #endregion
      
        #endregion
        #region Overrides
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.panel2.Width = this.Width - this.panel3.Width;
            this.gradientPanelExt2.Width = this.panel2.Width - 5;
            this.gradientPanelExt2.Height = this.Height - 75;
            this.panel3.Location = new Point(this.Width - this.gradientPanelExt1.Width, this.panel3.Location.Y);
            this.richTextBox1.Width = (this.Width - this.panel3.Width - 100);
            this.richTextBox1.Height = (this.Height - 200);
        }
        #endregion
    }
}
