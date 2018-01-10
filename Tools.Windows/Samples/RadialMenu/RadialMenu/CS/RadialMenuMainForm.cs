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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms.Tools;

namespace RadialMenuDemo
{
    public partial class RadialMenuMainForm : MetroForm
    {
        ColorCollection colorCollection = new ColorCollection();
        #region Initialize

        public RadialMenuMainForm()
        {
            InitializeComponent();
            this.radialMenuItem15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem5_MouseUp);
            this.radialMenuItem13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem5_MouseUp);
            this.radialMenu1.BeforeCloseUp += new CancelEventHandler(radialMenu1_BeforeCloseUp);           
            this.Deactivate += new EventHandler(RadialMenuMainForm_Deactivate);
            this.Load += new EventHandler(RadialMenuMainForm_Load);           
            this.richTextBox1.MouseEnter += new EventHandler(richTextBox1_MouseEnter);          
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.radialMenu1.ParentControl = this.richTextBox1;
            this.radialMenu1.MenuVisibility = true;
            this.MinimumSize = this.Size;
            this.richTextBox1.TextChanged += new EventHandler(richTextBox1_TextChanged);
            this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.TextAboveImage;
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if (File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.radialMenu1.MinimumSize = this.radialMenu1.Size;
            this.richTextBox1.MouseDown += richTextBox1_MouseDown;
            this.richTextBox1.GotFocus += richTextBox1_GotFocus;
        }

        void richTextBox1_GotFocus(object sender, EventArgs e)
        {
            this.radialMenu1.ShowRadialMenu();
        }

        void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.radialMenu1.MenuVisibility)
            {
                this.radialMenu1.ItemOnLoad = null;
                this.radialMenu1.MenuVisibility = false;
                this.radialMenu1.Refresh();
            }
        }

        void richTextBox1_TextChanged(object sender, EventArgs e)
        {
         
            RichTextBox r = new RichTextBox();
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            r.LoadFile(path, RichTextBoxStreamType.RichText);
            this.radialMenuItem15.Enabled = this.radialMenuItem5.Enabled = this.radialMenuItem13.Enabled = !this.richTextBox1.Text.Equals(r.Text);
            this.radialMenu1.Refresh();
        }

      

        #region SetEnable/Disable

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.radialMenu1.Items)
            {
                if ((sender as CheckBox).Text == ctrl.Text)
                {
                    ctrl.Enabled = !(sender as CheckBox).Checked;
                }
                if (ctrl is RadialMenuItem)
                {
                    if ((ctrl as RadialMenuItem).Items.Count > 0)
                    {
                        setEnabledForSubItems((ctrl as RadialMenuItem), (sender as CheckBox).Text, !(sender as CheckBox).Checked);
                    }
                }
            }
            this.radialMenu1.Refresh();
        }
        private void setEnabledForSubItems(RadialMenuItem item, string testString, bool checkedState)
        {
            foreach (Control ctrl in item.Items)
            {
                if (testString == ctrl.Text)
                {
                    ctrl.Enabled = checkedState;
                }
            }
        }

        #endregion

        void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

       
        void RadialMenuMainForm_Deactivate(object sender, EventArgs e)
        {
        }

        void RadialMenuMainForm_Load(object sender, EventArgs e)
        {
            this.radialMenu1.ShowRadialMenu(new Point(200, 200));
        }       
        
        #endregion

        #region  GetIconFile

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

        #region PopUp Customization

        void radialMenu1_BeforeCloseUp(object sender, CancelEventArgs e)
        {
           
            if (this.radialMenu1.MenuVisibility)
            {
                this.radialMenu1.MenuVisibility = false;
                this.radialMenu1.ItemOnLoad = null;
                this.radialMenu1.Refresh();
            }
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
           
        }
        private void setRadialMenuLocation()
        {
            int locationX = 0;
            int locationY = 0;
            locationX = (Cursor.Position.X + this.radialMenu1.Width / 8);
            if (locationX + this.radialMenu1.Width> Screen.PrimaryScreen.Bounds.Width)
            {
                locationX = Screen.PrimaryScreen.Bounds.Width - this.radialMenu1.Width;
            }
            locationY = Cursor.Position.Y - this.radialMenu1.Height / 2;
            if (locationY + this.radialMenu1.Height > Screen.PrimaryScreen.Bounds.Height)
                locationY = Screen.PrimaryScreen.Bounds.Height - this.radialMenu1.Height;
            Point location = new Point(locationX, locationY);
            this.radialMenu1.ShowRadialMenu(location);
            this.radialMenu1.PopupHost.Location = location;
            if (this.radialMenu1.PopupHost.Location.Y < 0)
                this.radialMenu1.PopupHost.Location = new Point(this.radialMenu1.PopupHost.Location.X, 0);
        }
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
          
            setRadialMenuLocation();
        }

        #endregion

        #region RadialMenu Customization      
        private void checkBoxAdv7_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv7.Checked)
            {
                this.radialMenu1.UseIndexBasedOrder = true;
            }
            else
            {
                this.radialMenu1.UseIndexBasedOrder = false;
            }
        }
        private void checkBoxAdv8_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv8.Checked)
            {
                this.radialMenu1.PersistPreviousState = true;
            }
            else
            {
                this.radialMenu1.PersistPreviousState = false;
            }
        }
        private void checkBoxAdv9_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv9.Checked)
            {
                this.radialMenu1.EnableTransition = true;
            }
            else
            {
                this.radialMenu1.EnableTransition = false;
            }
        }

       private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv10.Checked)
            {
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Edit")
                {
                   
                    this.radialMenu1.ItemOnLoad = this.radialMenuItem1;
                }
                else
                {
                    this.radialMenu1.ItemOnLoad = null;
                }
            }
            this.radialMenu1.Refresh();
        }
        private void radialMenuSlider1_SliderValueChanged(object sender, Syncfusion.Windows.Forms.Tools.RadialMenuSliderValueChangedEventArgs e)
        {
            if (this.richTextBox1.SelectedText == "")
            {
                this.richTextBox1.Font = new Font(this.richTextBox1.Font.Name, (float)e.Value, this.richTextBox1.Font.Style);
            }
            else
            {
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.Name, (float)e.Value, this.richTextBox1.Font.Style);
            }
            this.richTextBox1.Refresh();
        }
        private void radialFontListBox1_RadialFontChanged(object sender, Syncfusion.Windows.Forms.Tools.SlectedIndexChangedEventArgs e)
        {
            if (this.richTextBox1.SelectedText == "")
            {
                this.richTextBox1.Font = new Font(e.SelectedFontName, this.richTextBox1.Font.Size, this.richTextBox1.Font.Style);
            }
            else
            {
                this.richTextBox1.SelectionFont = new Font(e.SelectedFontName, this.richTextBox1.Font.Size, this.richTextBox1.Font.Style);
            }
        }
        private void radialColorPalette1_ColorPaletteColorChanged(object sender, Syncfusion.Windows.Forms.Tools.SelctedColorChangedEventArgs e)
        {
            if (this.richTextBox1.SelectedText == "")
            {
                this.richTextBox1.ForeColor = e.SelectedColor;
            }
            else
            {
                this.richTextBox1.SelectionColor = e.SelectedColor;
            }
        }
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.RimBackground = colorPickerButton1.SelectedColor;
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.HighlightedArcColor = colorPickerButton2.SelectedColor;
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.OuterArcColor = colorPickerButton3.SelectedColor;
        }

        private void colorPickerButton4_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.OuterArcHighLightedColor = colorPickerButton4.SelectedColor;
        }

        private void colorPickerButton5_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.DrillDownArrowColor = colorPickerButton5.SelectedColor;
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenu1.WedgeCount = (int)this.numericUpDown4.Value;
        }

        #endregion

        #region Slider Customization

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenuSlider1.MaximumValue = (int)this.numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenuSlider1.MinimumValue = (int)this.numericUpDown1.Value;
        }

        #endregion

        #region FontListBox Customization

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.radialFontListBox1.ItemHeight = (int)this.numericUpDown3.Value;
        }

        #endregion

        #region Edit

        private void radialMenuItem2_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Cut();
        }
        private void radialMenuItem3_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void radialMenuItem4_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void radialMenuItem5_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Undo();
        }

        #endregion

       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.radialMenu1.ShowToolTip = true;
            }
            else
            {
                this.radialMenu1.ShowToolTip = false;
            }
        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedItem.ToString() == "TextAboveImage")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.TextAboveImage;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "ImageAboveText")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.ImageAboveText;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "Text")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.Text;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "Image")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.Image;
            }
            this.radialMenu1.Refresh();
        }     

        private void colorPickerButton6_ColorSelected_1(object sender, EventArgs e)
        {
            
            colorCollection.Color1 = colorPickerButton6.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton7_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color2 = colorPickerButton7.SelectedColor;
            this.radialMenu1.Refresh();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.WindowState != FormWindowState.Minimized)
                this.radialMenu1.ShowRadialMenu(new  Point(700,100));
        }
        private void colorPickerButton8_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color3= colorPickerButton8.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton9_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color4 = colorPickerButton9.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton10_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color5 = colorPickerButton10.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton12_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color6 = colorPickerButton12.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton13_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color7 = colorPickerButton13.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton14_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color8= colorPickerButton14.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void buttonAdv1_Click_1(object sender, EventArgs e)
        {
            if (!this.radialColorPalette1.ColorPaletteItemCollection.Contains(colorCollection))
                this.radialColorPalette1.ColorPaletteItemCollection.Add(colorCollection);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.radialMenuItem2.CheckMode = CheckMode.Check;
            }
            else if (radioButton2.Checked)
            {
                this.radialMenuItem2.CheckMode = CheckMode.Option;
                this.radialMenuItem2.GroupName = "group1";
            }
            else if (radioButton3.Checked)
            {
                this.radialMenuItem2.CheckMode = CheckMode.None;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                this.radialMenuItem3.CheckMode = CheckMode.Check;
            }
            else if (radioButton2.Checked)
            {
                this.radialMenuItem3.CheckMode = CheckMode.Option;
                this.radialMenuItem3.GroupName = "group1";
            }
            else if (radioButton3.Checked)
            {
                this.radialMenuItem3.CheckMode = CheckMode.None;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.radialMenuItem4.CheckMode = CheckMode.Check;
         
            }
            else if (radioButton2.Checked)
            {
                this.radialMenuItem4.CheckMode = CheckMode.Option;
                this.radialMenuItem4.GroupName = "group1";
                
            }
            else if (radioButton3.Checked)
            {
                this.radialMenuItem4.CheckMode = CheckMode.None;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.radialMenuItem5.CheckMode = CheckMode.Check;
            }
            else if (radioButton2.Checked)
            {
                this.radialMenuItem5.CheckMode = CheckMode.Option;
                this.radialMenuItem5.GroupName = "group1";
            }
            else if (radioButton3.Checked)
            {
                this.radialMenuItem5.CheckMode = CheckMode.None;
            }
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.panel9.Visible = true;
            this.radialMenuItem2.Checked = false;
            this.radialMenuItem3.Checked = false;
            this.radialMenuItem4.Checked = false;
            this.radialMenuItem5.Checked = false;
            this.radialMenu1.Refresh();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.radialMenuItem2.Checked = false;
            this.radialMenuItem3.Checked = false;
            this.radialMenuItem4.Checked = false;
            this.radialMenuItem5.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.radialMenu1.Refresh();
            this.panel9.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            this.panel9.Visible = true;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.radialMenuItem2.Checked = false;
            this.radialMenuItem3.Checked = false;
            this.radialMenuItem4.Checked = false;
            this.radialMenuItem5.Checked = false;
            this.radialMenu1.Refresh();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenu1.StartAngle((int)numericUpDown5.Value);
            this.radialMenu1.Refresh();
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.radialMenu1.Items.Clear();
            this.radialMenu1.UseIndexBasedOrder = true;
            this.radialMenu1.WedgeCount = 8;
            this.numericUpDown4.Value = 8;
            this.radialMenu1.Items.Add(this.radialMenuItem1);
            this.radialMenu1.Items.Add(this.radialMenuSlider1);
            this.radialMenu1.Items.Add(this.radialColorPalette1);
            this.radialMenu1.Items.Add(this.radialFontListBox1);
            this.radialMenu1.ItemOnLoad = null;
            this.radialMenu1.Refresh();
        }

        
        
          
       
    }
}