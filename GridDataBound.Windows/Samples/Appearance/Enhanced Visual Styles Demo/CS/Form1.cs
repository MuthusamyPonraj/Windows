using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using System.Drawing.Drawing2D;
using Syncfusion.Diagnostics;
using Syncfusion.GridHelperClasses;

namespace Enhanced_VisualStyle_In_GDBG
{
    public partial class Form1 : Form
    {
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn1;
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn2;
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn3;
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn4;
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn5;
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn gridBoundColumn6;
        public Form1()
        {
            InitializeComponent();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            
            this.gridDataBoundGrid1.CellButtonClicked += new GridCellButtonClickedEventHandler(gridDataBoundGrid1_CellButtonClicked);
            this.gridBoundColumn1 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gridBoundColumn1.HeaderText = "Column1";
            this.gridBoundColumn1.MappingName = "Column1";
            this.gridBoundColumn2 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gridBoundColumn2.HeaderText = "Column2";
            this.gridBoundColumn2.MappingName = "Column2";

            this.gridBoundColumn3 = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gridBoundColumn3.HeaderText = "Column3";
            this.gridBoundColumn3.MappingName = "Column3";

            this.gridDataBoundGrid1.GridBoundColumns.AddRange(new Syncfusion.Windows.Forms.Grid.GridBoundColumn[] { this.gridBoundColumn1, this.gridBoundColumn2, this.gridBoundColumn3 });//, this.gridBoundColumn3, this.gridBoundColumn4, this.gridBoundColumn5, this.gridBoundColumn6 });
            this.gridDataBoundGrid1.Model.EnableLegacyStyle = false;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2010Black;

        }

        void gridDataBoundGrid1_CellButtonClicked(object sender, GridCellButtonClickedEventArgs e)
        {
            if (e.RowIndex == 4)
                MessageBox.Show("You have Clicked a Button");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            int nCols = 6;
            int nRows = 35;
           
            for (int i = 0; i < nRows; ++i)
            {
                DataColumn col = new DataColumn();
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);

            }
            for (int j = 0; j < nCols; j++)
                dt.Columns.Add();
            this.gridDataBoundGrid1.DataSource = dt;

            this.gridDataBoundGrid1.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(gridDataBoundGrid1_PrepareViewStyleInfo);
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.DefaultColWidth  = 135;
            this.gridDataBoundGrid1[2, 1].Text = "ComboBox";           
            this.gridDataBoundGrid1[4, 1].Text = "Push Button";
            this.gridDataBoundGrid1[6, 1].Text = "Check Box";
            this.gridDataBoundGrid1[8, 1].Text = "NumericUpDown";
            this.gridDataBoundGrid1[10, 1].Text = "DropDownGrid";
            this.gridDataBoundGrid1[12, 1].Text = "GridListControl";
            this.gridDataBoundGrid1[14, 1].Text = "Header";
            this.gridDataBoundGrid1.Model.EnableGridListControlInComboBox = false;
        }

        private ArrayList CreateList()
        {
            ArrayList USStates = new ArrayList();
            USStates.Add(new USState("Alabama", "AL", 0));
            USStates.Add(new USState("Alaska", "AK", 1));
            USStates.Add(new USState("Arizona", "AZ", 2));
            USStates.Add(new USState("Arkansas", "AK", 4));
            USStates.Add(new USState("California", "CA", 4));
            return USStates;
        }

        void gridDataBoundGrid1_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {        

                if (e.ColIndex == 2)
                {
                    if (e.RowIndex == 2)
                    {
                        e.Style.CellType = "ComboBox";
                        e.Style.DataSource = CreateList();
                        e.Style.DisplayMember = "LongName";
                        e.Style.ValueMember = "ShortName";
                        e.Style.Text = "Select Your Choice";
                    }                  
                    if (e.RowIndex == 4)
                    {
                        e.Style.CellType = "PushButton";
                        e.Style.Description = "Click Me";
                        e.Style.HorizontalAlignment = GridHorizontalAlignment.Center;
                        e.Style.VerticalAlignment = GridVerticalAlignment.Middle;
                    }
                    if (e.RowIndex == 6)                    
                        e.Style.CellType = "CheckBox";                        
                    
                    if (e.RowIndex == 8)
                        e.Style.CellType = "NumericUpDown";
                    if (e.RowIndex == 10)
                    {
                        e.Style.CellType = "DropDownGrid";

                    }
                    if (e.RowIndex == 12)
                    {
                        e.Style.CellType = "GridListControl";
                        e.Style.DataSource = CreateList();                        
                        e.Style.DisplayMember = "ShortName";
                        e.Style.ValueMember = "LongName";                          
                    }
                    if (e.RowIndex == 14)
                    {
                        e.Style.CellType = "Header"; 
                        e.Style.Text = "HeaderText";
                    }
                    
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pBox = (PictureBox)sender;

            switch (pBox.Name)
            {
                case "pictureBox1":
                    this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Metro;
                    break;
                case "pictureBox2":
                    this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
                    gridDataBoundGrid1.Office2007ScrollBars = true;
                    gridDataBoundGrid1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    break;
                case "pictureBox3":
                    this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Black;
                    gridDataBoundGrid1.Office2007ScrollBars = true;
                    gridDataBoundGrid1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    break;
                case "pictureBox4":
                    this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Silver;
                    gridDataBoundGrid1.Office2007ScrollBars = true;
                    gridDataBoundGrid1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    break;
                case "pictureBox5":
                    this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2010Blue;
                    gridDataBoundGrid1.Office2007ScrollBars = false;
                    gridDataBoundGrid1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue;
                    break;
                case "pictureBox6":
                    this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2010Black;
                    gridDataBoundGrid1.Office2007ScrollBars = false;
                    gridDataBoundGrid1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black;
                    break;
                case "pictureBox7":
                    this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2010Silver;
                    gridDataBoundGrid1.Office2007ScrollBars = false;
                    gridDataBoundGrid1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver;
                    break;

            }

            label6.Text = gridDataBoundGrid1.GridVisualStyles.ToString();
            label4.Text = label6.Text;

            panel1.Location = new Point(pBox.Location.X + 3, panel2.Location.Y);
            panel1.Visible = true;

            this.gridDataBoundGrid1.Refresh();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.SuspendLayout();
            PictureBox pBox = (PictureBox)sender;
            panel2.Location = new Point(pBox.Location.X + 3, panel2.Location.Y);
            panel2.Visible = true;
            WriteStyles(pBox);
            this.ResumeLayout(true);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;
        }

        private void WriteStyles(PictureBox pBox)
        {
            switch (pBox.Name)
            {
                case "pictureBox1":
                    label1.Text = "GridVisualStyles : Metro";
                    break;
                case "pictureBox2":
                    label1.Text = "GridVisualStyles : Office2007Blue";
                    break;
                case "pictureBox3":
                    label1.Text = "GridVisualStyles : Office2007Black";
                    break;
                case "pictureBox4":
                    label1.Text = "GridVisualStyles : Office2007Silver";
                    break;
                case "pictureBox5":
                    label1.Text = "GridVisualStyles : Office2010Blue";
                    break;
                case "pictureBox6":
                    label1.Text = "GridVisualStyles : Office2010Black";
                    break;
                case "pictureBox7":
                    label1.Text = "GridVisualStyles : Office2010Silver";
                    break;
            }
            label1.Visible = true;
        }

    }
    #region USState Class

    public class USState
    {
        private string myShortName;
        private string myLongName;
        private int _imageIndex;

        public USState(string strLongName, string strShortName, int _imageIndex)
        {
            this.myShortName = strShortName;
            this.myLongName = strLongName;
            this._imageIndex = _imageIndex;
        }

        public string ShortName
        {
            get { return myShortName; }
        }

        public string LongName
        {
            get { return myLongName; }
        }

        public int ImageIndex
        {
            get { return _imageIndex; }
            set { _imageIndex = value; }
        }

        public override string ToString()
        {
            return this.ShortName + " - " + this.LongName;
        }
    }
    #endregion
}
