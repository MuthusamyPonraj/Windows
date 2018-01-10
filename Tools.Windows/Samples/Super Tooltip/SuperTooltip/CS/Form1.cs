#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace SuperToolTipDemo_2005
{
	public partial class Form1 : MetroForm
	{
		public Form1 ( )
		{
			InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


            this.colorPickerUIAdv1.MoreColorsButton.Visible = false;
            this.colorPickerUIAdv1.StateButton.Visible = false;
            comboBox1.SelectedIndex = 0;
		}

		#region SuperToolTip Gradient Colors
        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo29 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            // assign the color
            toolTipInfo29.BackColor = args.Color;

            toolTipInfo29.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo29.Header.Text = "SuperToolTip with \r\nGradient Look And Feel";
            toolTipInfo29.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo29.Header.TextMargin = new System.Windows.Forms.Padding(5);
            toolTipInfo29.Body.Text = "Select a color to experience the\r\nGradient look and feel of SuperTooltip.";
            toolTipInfo29.Body.TextMargin = new System.Windows.Forms.Padding(5);
            toolTipInfo29.Footer.Text = "Appealing look and feel with various \r\ngradient colors.";
            toolTipInfo29.Footer.TextMargin = new System.Windows.Forms.Padding(5);

            // To assign the created tooltip to a control.
            this.superToolTip1.SetToolTip(this.buttonAdv4, toolTipInfo29);
            this.popupControlContainer1.HidePopup(PopupCloseType.Done);
        }

        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            this.colorPickerUIAdv1.UpdateControl();
            this.colorPickerUIAdv1.Invalidate(true);
            this.popupControlContainer1.Height = this.colorPickerUIAdv1.Height;// +padding;
            this.popupControlContainer1.Refresh();
            this.popupControlContainer1.Update();
            this.popupControlContainer1.Invalidate(true);
            this.Refresh();
            this.popupControlContainer1.ShowPopup(Point.Empty);
        }
#endregion

        #region SuperToolTip through Code
        // To add a toolTip through code
        Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfothroughCode = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolTipInfothroughCode.BackColor = Color.Bisque;
            toolTipInfothroughCode.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
                toolTipInfothroughCode.Header.Text = this.textBox1.Text;
            
                toolTipInfothroughCode.Body.Text = this.textBox2.Text;
            
                toolTipInfothroughCode.Footer.Text = this.textBox3.Text;
            
            toolTipInfothroughCode.Header.TextAlign = ContentAlignment.MiddleCenter;
                        
        }

        private void gradientLabel6_MouseHover(object sender, EventArgs e)
        {
            this.superToolTip1.SetToolTip(this.gradientLabel6, toolTipInfothroughCode);
        }
       #endregion
              
        #region Custom region
        // To show the tooltip in a custom location use 'PopupToolTip' event.
        // NOTE: You cannot handle this event for tooltips created through code.
        private void superToolTip1_PopupToolTip(Component component, ref Rectangle rc)
        {           
            if (component == label4)
            {
                rc.X = rc.X - 260;
                rc.Y = rc.Y - 220;              
            }
        } 
        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
			{
				this.RightToLeft = RightToLeft.Yes;
                this.superToolTip1.RightToLeft = RightToLeft.Yes;
			}
            else
			{
				this.RightToLeft = RightToLeft.No;
                this.superToolTip1.RightToLeft = RightToLeft.No;
			}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Normal":
                    this.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Normal;
                    break;
                case "Balloon":
                    this.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Balloon;
                    break;
            }
        }

        private void splitContainerAdv1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colorPickerUIAdv1_Picked_1(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo29 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            // assign the color
            toolTipInfo29.BackColor = args.Color;

            toolTipInfo29.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo29.Header.Text = "SuperToolTip with \r\nGradient Look And Feel";
            toolTipInfo29.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo29.Header.TextMargin = new System.Windows.Forms.Padding(5);
            toolTipInfo29.Body.Text = "Select a color to experience the\r\nGradient look and feel of SuperTooltip.";
            toolTipInfo29.Body.TextMargin = new System.Windows.Forms.Padding(5);
            toolTipInfo29.Footer.Text = "Appealing look and feel with various \r\ngradient colors.";
            toolTipInfo29.Footer.TextMargin = new System.Windows.Forms.Padding(5);

            // To assign the created tooltip to a control.
            this.superToolTip1.SetToolTip(this.buttonAdv4, toolTipInfo29);
            this.popupControlContainer1.HidePopup(PopupCloseType.Done);
        }
     }
}