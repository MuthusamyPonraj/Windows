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

namespace GroupbarDemo
{
    public partial class LoadData : Form
    {
        public LoadData()
        {
            InitializeComponent();
            this.CenterToParent();
            numericUpDown1.Maximum = 500000;
            numericUpDown1.Minimum = 100000;
            numericUpDown1.Value = 200000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.recordCount = Convert.ToInt32(numericUpDown1.Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
