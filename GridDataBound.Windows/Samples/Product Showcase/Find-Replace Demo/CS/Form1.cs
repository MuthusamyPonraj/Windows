using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System.IO;

namespace FindReplaceDemo_2005
{
    public partial class Form1 : Form
    {
        DataSet ds;
        GridFindReplaceDialogSink frDialog;
        GridFindReplaceEventArgs frEvents;
        GridFindTextOptions options;
        object locInfo;
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            ds = new DataSet();
            ReadXml(ds, @"\common\Data\GDBDdata.XML");
            this.gridDataBoundGrid1.DataSource = ds.Tables["products"];
            this.gridDataBoundGrid1.Model.EnableLegacyStyle = false;
            this.gridDataBoundGrid1.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = this.grpBoxFindReplace.BackColor = Color.LightBlue; 

            //Setup FindReplace dialog
            frDialog = new GridFindReplaceDialogSink(this.gridDataBoundGrid1);
            options = GridFindTextOptions.None;
            cmbBoxOptions.SelectedIndex = 2;
            this.gridDataBoundGrid1.ForceCurrentCellMoveTo = true;
            this.gridDataBoundGrid1.CurrentCell.MoveTo(1, 1);
            this.gridDataBoundGrid1.Model.QueryCellInfo += new GridQueryCellInfoEventHandler(Model_QueryCellInfo);
        }

        #region Sample Helper
        void ReadXml(DataSet ds, string xmlFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
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
        #endregion Sample Helper

        #region Find and Replace
        bool findAll = false;
        bool resetAll = false;
        void Model_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (findAll)
            {
                GridCurrentCell gcc = this.gridDataBoundGrid1.CurrentCell;
                if (this.cmbBoxOptions.Text.Equals("WholeTable"))
                {
                    SetCellBackColor(e);
                }
                else if (cmbBoxOptions.Text.Equals("ColumnOnly") && gcc!= null)
                {
                    if (e.ColIndex == gcc.ColIndex)
                    {
                        SetCellBackColor(e);
                    }
                }
            }
            else if (resetAll)
                e.Style.BackColor = SystemColors.Window;
        }

        private void SetCellBackColor(GridQueryCellInfoEventArgs e)
        {
            string text = e.Style.Text;
            string userText = cmbBoxSearch.Text.Trim();
            if (!chkBoxMatchCase.Checked)
            {
                text = text.ToLower();
                userText = userText.ToLower();
            }
            if (this.chkBoxMatchWholeCell.Checked)
            {
                if (text.Equals(userText))
                    e.Style.BackColor = Color.Orange;
            }
            else
            {
                if (text.Contains(userText))
                    e.Style.BackColor = Color.Orange;
            }
        }
        
        
        //FindNext
        private void btnFindNext_Click(object sender, EventArgs e)
        {
            if (cmbBoxSearch.Text != string.Empty)
            {
                AddToSearchedList(cmbBoxSearch.Text);
                SetOptions();
                locInfo = GridRangeInfo.Table();
                frEvents = new GridFindReplaceEventArgs(cmbBoxSearch.Text, "", options, locInfo);
                frDialog.Find(frEvents);
            }
        }

        //FindAll - Sets the cell back color via QueryCellInfo event in the grid and so highlights all the values 
        //that match with the given search string.
        private void btnFindAll_Click(object sender, EventArgs e)
        {
            if (cmbBoxSearch.Text != null)
            {
                AddToSearchedList(cmbBoxSearch.Text);
                findAll = true;
                resetAll = false;
                this.gridDataBoundGrid1.Refresh();
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (cmbBoxSearch.Text != string.Empty && cmbBoxReplace.Text != string.Empty)
            {
                SetOptions();
                frEvents = new GridFindReplaceEventArgs(cmbBoxSearch.Text, cmbBoxReplace.Text, options, locInfo);
                frDialog.Replace(frEvents);
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            if (cmbBoxSearch.Text != string.Empty && cmbBoxReplace.Text != string.Empty)
            {
                if (cmbBoxSearch.Text != string.Empty && this.cmbBoxReplace.Text != string.Empty)
                {
                    SetOptions();
                    frEvents = new GridFindReplaceEventArgs(cmbBoxSearch.Text, this.cmbBoxReplace.Text, options, locInfo);
                    frDialog.ReplaceAll(frEvents);
                }
                findAll = false;
                resetAll = true;
                this.gridDataBoundGrid1.Refresh();
            }
            else
                MessageBox.Show("Search/Replace value is missing");
        }

        #region Helper methods

        //Setup the search options.
        private void SetOptions()
        {
            options = GridFindTextOptions.None;
            if (chkBoxMatchCase.Checked)
                options = GridFindTextOptions.MatchCase;
            if (chkBoxMatchWholeCell.Checked)
                options |= GridFindTextOptions.MatchWholeCell;
            if (chkBoxSearchUp.Checked)
                options |= GridFindTextOptions.SearchUp;
            switch (cmbBoxOptions.SelectedIndex)
            {
                case 0: options |= GridFindTextOptions.ColumnOnly; break;
                case 1: options |= GridFindTextOptions.SelectionOnly; break;
                case 2: options |= GridFindTextOptions.WholeTable; break;
            }
        }
      
        //Keep track of the search strings being entered.
        private void AddToSearchedList(string txt)
        {
            if (!cmbBoxSearch.Items.Contains(txt))
                cmbBoxSearch.Items.Insert(0, txt);
        }
        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Set the backcolor of the cells being highlighted to their original color using QueryCellInfo event.
            resetAll = true;
            findAll = false;
            this.gridDataBoundGrid1.Selections.Clear();
            this.gridDataBoundGrid1.Refresh();
        }
        #endregion Find and Replace
    }
}