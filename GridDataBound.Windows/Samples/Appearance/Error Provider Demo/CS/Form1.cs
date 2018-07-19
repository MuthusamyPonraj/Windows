using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.GridDataBoundGrid1.DataSource = GetTable();
            this.GridDataBoundGrid1.ThemesEnabled = true;
            //Error provider Properties
            this.GridDataBoundGrid1.ShowRowHeaderErroricon = false;
            this.GridDataBoundGrid1.CurrentCell.ShowErrorIcon = false;
            this.GridDataBoundGrid1.CurrentCell.ShowErrorMessageBox = false;
            this.GridDataBoundGrid1.CurrentCell.ValidationErrorText = string.Empty;
            this.GridDataBoundGrid1.DefaultColWidth = 150;
            this.GridDataBoundGrid1.AllowResizeToFit = false;
            this.textBox1.Enabled = false;
            textBox2.Enabled = false;
            this.GridDataBoundGrid1.CurrentCellValidating += new CancelEventHandler(GridDataBoundGrid1_CurrentCellValidating);
            this.GridDataBoundGrid1.CurrentCellErrorMessage += new GridCurrentCellErrorMessageEventHandler(GridDataBoundGrid1_CurrentCellErrorMessage);           
        }


        void GridDataBoundGrid1_CurrentCellErrorMessage(object sender, GridCurrentCellErrorMessageEventArgs e)
        {
            //   e.Cancel=true;
        }

        void GridDataBoundGrid1_CurrentCellValidating(object sender, CancelEventArgs e)
        {
            long output;
            if (chkSetError.Checked)
            {
                long.TryParse(this.GridDataBoundGrid1.CurrentCell.Renderer.ControlText, out output);
                if (this.GridDataBoundGrid1.CurrentCell.ColIndex == 1 && output > 5)
                {
                    if (string.IsNullOrEmpty(textBox2.Text))
                        this.GridDataBoundGrid1.CurrentCell.SetError("Please enter valid number");
                    else
                        this.GridDataBoundGrid1.CurrentCell.SetError(textBox2.Text);

                }
            }
        }

        private DataTable GetTable()
        {
            DataTable dt = new DataTable("MyTable");

            dt.Columns.Add(new DataColumn("S.NO", typeof(int)));
            dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("History", typeof(string)));
            for (int i = 0; i < 5; i++)
                dt.Rows.Add(new object[] { i, DateTime.Today, "Trader" });

            return dt;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.GridDataBoundGrid1.ShowRowHeaderErroricon = true;
            else
                this.GridDataBoundGrid1.ShowRowHeaderErroricon = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                this.GridDataBoundGrid1.CurrentCell.ValidationErrorText = textBox1.Text;
            else
                this.GridDataBoundGrid1.CurrentCell.ValidationErrorText = string.Empty;
        }



        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSetError.Checked)
            {
                checkBox3.Checked = true;
                textBox2.Enabled = true;
            }
            else
            {
                checkBox3.Checked = false;
                textBox2.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {               
                checkBox3.Checked = true;
                this.textBox1.Enabled = true;
            }
            else
            {
                this.GridDataBoundGrid1.CurrentCell.ValidationErrorText = string.Empty;
                checkBox3.Checked = false;
                this.textBox1.Clear();
                this.textBox1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.GridDataBoundGrid1.ShowRowHeaderErroricon = true;
            else
                this.GridDataBoundGrid1.ShowRowHeaderErroricon = false;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                this.GridDataBoundGrid1.CurrentCell.ShowErrorMessageBox = true;
            else
                this.GridDataBoundGrid1.CurrentCell.ShowErrorMessageBox = false;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                this.GridDataBoundGrid1.CurrentCell.ShowErrorIcon = true;
            else
                this.GridDataBoundGrid1.CurrentCell.ShowErrorIcon = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.GridDataBoundGrid1.CurrentCell.ValidationErrorText = textBox1.Text;
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
    }
}
