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
using Syncfusion.Windows.Forms.Tools;
using System.Collections;

namespace MultiSelectionComboBoxDemo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.MultiSelectionComboBox1.Location = new Point(this.panel2.Width / 2 - this.MultiSelectionComboBox1.Width / 2, this.panel2.Height / 2 - this.MultiSelectionComboBox1.Height / 2);
            this.MultiSelectionComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //Create dataTable
            DataTable dt = new DataTable("Table1");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("occupation");
            dt.Columns.Add("place");
            // Create a Data Set
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dt.Rows.Add(new string[] { "Alex", "Zen", "Doctor", "Italy" });
            dt.Rows.Add(new string[] { "Bob", "Harry", "Staff", "London" });
            dt.Rows.Add(new string[] { "Alice", "Peter", "Developer", "US" });
            dt.Rows.Add(new string[] { "Adlensha", "Fdo", "Staff", "Italy" });
            dt.Rows.Add(new string[] { "Brick", "John", "Nurse", "North America" });
            dt.Rows.Add(new string[] { "Collen", "Geo", "Developer", "India" });
            DataView view = new DataView(dt);
            this.MultiSelectionComboBox1.MetroColor = Color.DarkGray;
            this.MultiSelectionComboBox1.ForeColor = Color.SlateGray;
            this.MultiSelectionComboBox1.GroupHeaderForeColor = Color.DimGray;
            this.MultiSelectionComboBox1.GroupHeaderBackColor = Color.White;
            this.MultiSelectionComboBox1.ShowCheckBox = true;
            this.MultiSelectionComboBox1.ShowGroups = true;
            this.MultiSelectionComboBox1.DisplayMode = DisplayMode.VisualItem;
            this.MultiSelectionComboBox1.DataSource = view;
            this.MultiSelectionComboBox1.DisplayMember = "FirstName";
            this.MultiSelectionComboBox1.AutoSuggestMode = AutoSuggestMode.Begin;
            this.MultiSelectionComboBox1.MaxDropDownItems = 5;
            this.splitContainerAdv1.SplitterWidth = 1;
            this.MultiSelectionComboBox1.Location = new Point(this.panel2.Width / 2 - this.MultiSelectionComboBox1.Width / 2, this.panel2.Height / 2 - this.MultiSelectionComboBox1.Height / 2);
            this.SizeChanged += new EventHandler(Form1_SizeChanged);
            this.colorPickerButton1.BackColor = Color.White;
            this.MultiSelectionComboBox1.DropDownButton.MouseEnter += new EventHandler(DropDownButton_MouseEnter);
            this.MultiSelectionComboBox1.DropDownButton.MouseLeave += new EventHandler(DropDownButton_MouseLeave);
            this.MultiSelectionComboBox1.DropDownButton.BackColor = Color.FromArgb(237, 238, 236);
            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX >= 120)
                {
                    this.splitContainerAdv1.Panel2MinSize = 490;
                    this.splitContainerAdv1.Panel1MinSize = 550;
                    this.splitContainerAdv1.SplitterDistance = 800;
                }
                else
                {
                    this.splitContainerAdv1.Panel2MinSize = 370;
                    this.splitContainerAdv1.Panel1MinSize = 420;
                }
            }
        }

        void DropDownButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as ButtonEditChildButton).BackColor = Color.FromArgb(237, 238, 236);
        }

        void DropDownButton_MouseEnter(object sender, EventArgs e)
        {
            (sender as ButtonEditChildButton).BackColor = Color.FromArgb(233, 233, 233);
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

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX >= 120)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.splitContainerAdv1.Panel1MinSize = 640;
                        this.splitContainerAdv1.Panel2MinSize = 500;
                    }
                    this.splitContainerAdv1.SplitterDistance = this.Width - 500;
                    this.MultiSelectionComboBox1.Location = new Point(this.panel2.Width / 2 - this.MultiSelectionComboBox1.Width / 2, this.panel2.Height / 2 - this.MultiSelectionComboBox1.Height / 2);
                }
                else
                {
                    if (this.WindowState == FormWindowState.Maximized)
                        this.splitContainerAdv1.Panel1MinSize = 620;
                    this.splitContainerAdv1.SplitterDistance = this.Width - 400;
                    this.MultiSelectionComboBox1.Location = new Point(this.panel2.Width / 2 - this.MultiSelectionComboBox1.Width / 2, this.panel2.Height / 2 - this.MultiSelectionComboBox1.Height / 2);
                }
            }
        }

        
     
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.MultiSelectionComboBox1.GroupHeaderBackColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.MultiSelectionComboBox1.GroupHeaderForeColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.MultiSelectionComboBox1.GroupHeaderSeparatorColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        /// <summary>
        /// Selection Mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "Begin")
            {
                this.MultiSelectionComboBox1.AutoSuggestMode = AutoSuggestMode.Begin;
            }
            else if ((sender as ComboBoxAdv).Text == "Match")
            {
                this.MultiSelectionComboBox1.AutoSuggestMode = AutoSuggestMode.Match;
            }
            else
            {
                this.MultiSelectionComboBox1.AutoSuggestMode = AutoSuggestMode.Disabled;
            }
        }

        /// <summary>
        /// AutoSizeMode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "Horizontal")
            {
                this.MultiSelectionComboBox1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.AutoSizeModes.Horizontal;
            }
            else if ((sender as ComboBoxAdv).Text == "Vertical")
            {
                this.MultiSelectionComboBox1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.AutoSizeModes.Vertical;
            }
            else
            {
                this.MultiSelectionComboBox1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.AutoSizeModes.None;
            }
        }

        /// <summary>
        /// ShowCheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "True")
            {
                this.MultiSelectionComboBox1.ShowCheckBox = true;
            }
            else
            {
                this.MultiSelectionComboBox1.ShowCheckBox = false;
            }
        }

        /// <summary>
        /// Allow Grouping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "True")
                this.MultiSelectionComboBox1.ShowGroups = true;
            else
                this.MultiSelectionComboBox1.ShowGroups = false;
        }

        private void comboBoxAdv5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "Visual Item")
            {
                this.MultiSelectionComboBox1.DisplayMode = DisplayMode.VisualItem;
            }
            else if ((sender as ComboBoxAdv).Text == "Delimiter Mode")
            {
                this.MultiSelectionComboBox1.DisplayMode = DisplayMode.DelimiterMode;
            }
            else
            {
                this.MultiSelectionComboBox1.DisplayMode = DisplayMode.NormalMode;
            }
        }

       
    }
}
