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
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using System.Data.SqlServerCe;
namespace GridDataBoundImages
{

	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkBox1;

		private bool proportionalCellSizing;
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }

			//Listen to the IBindingList.ListChanged events instead of the 
			//CurrencyManager events.
			this.gridDataBoundGrid1.UseListChangedEvent = true;
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid1.DefaultColWidth = 70;
            this.gridDataBoundGrid1.DefaultRowHeight = 18;
            this.gridDataBoundGrid1.HorizontalThumbTrack = true;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(240, 31);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(536, 481);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.VerticalThumbTrack = true;
            this.gridDataBoundGrid1.CurrentCellMoved += new Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(this.gridDataBoundGrid1_CurrentCellMoved);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(328, 521);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 40);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(311, 11);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "FitProportionally";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(171, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "NoResize";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(24, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "FitToCell";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 216);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(16, 531);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Proportional Grid Cells";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 566);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grid Bound Image Cell Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{			
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif		
			Application.Run(new Form1());
		}

		string GetPath(string mdbFileName)
		{
			for (int n = 0; n < 14; n++)
			{
				if (System.IO.File.Exists(mdbFileName))
				{
					return mdbFileName;
				}
				mdbFileName = @"..\" + mdbFileName;
			}
			return mdbFileName;
		}

        internal static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }
		private void Form1_Load(object sender, System.EventArgs e)
		{
			//load the data & bind the grid using code instead of the designer...
			// Set the connection and sql strings
			// assumes your mdb file is in your root
            DataSet _dataSet = null;
            String connectionstring = "Data Source=" + FindFile("NorthwindwithImage.sdf");
            String commandstring = "select EmployeeID, LastName, FirstName, Photo, Photo from Employees";
            _dataSet = new DataSet();

            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connectionstring);
            da.Fill(_dataSet, "Employees");

				this.gridDataBoundGrid1.DataSource = _dataSet;
				this.gridDataBoundGrid1.DataMember = "Employees";


//setup the column formats...
			
			//default image cell 
			GridImageCellModel imageCell = new GridImageCellModel(gridDataBoundGrid1.Model);

			//setup how image is fitted to cell
			imageCell.CellDrawOption = GridImageCellDrawOption.FitProportionally;
			//imageCell.CellDrawOption = GridImageCellDrawOption.NoResize;
			//imageCell.CellDrawOption = GridImageCellDrawOption.FitToCell; //default

			//setup offset into byte stream - northwind db is 78 because of VB6 OLE header
			//if you saved bitmap directly to the bytestream, value is 0.
			//imageCell.PictureBufferOffset = 0; //bmps directly into byte stream
			imageCell.PictureBufferOffset = 78;//northwind
			
			gridDataBoundGrid1.Model.CellModels.Add("ImageCell", imageCell);
	
			//as another option, use a dropdown
			gridDataBoundGrid1.Model.CellModels.Add("DropDownPicture", new GridDropDownImageCellModel(this.gridDataBoundGrid1.Model));
	
			//set up the GridBoundColumns with correct celltypes
			CurrencyManager cm = (CurrencyManager)this.BindingContext[gridDataBoundGrid1.DataSource, gridDataBoundGrid1.DataMember];

			//no adding of new rows
			((DataView)cm.List).AllowNew = false;

			PropertyDescriptorCollection pdc = cm.GetItemProperties();
			foreach(PropertyDescriptor pd in pdc)
			{
				GridBoundColumn col = new Syncfusion.Windows.Forms.Grid.GridBoundColumn(pd);
				col.MappingName = pd.Name;
				col.HeaderText = pd.Name;
				if(pd.Name == "Photo")
					col.StyleInfo.CellType = "ImageCell";
				if(pd.Name == "Photo1")
				{
					col.StyleInfo.CellType = "DropDownPicture";
					col.HeaderText = "Photo1";
				}
				gridDataBoundGrid1.GridBoundColumns.Add(col);
			}

			this.radioButton1.Checked = true;
			this.gridDataBoundGrid1.CurrentCell.Reactivate();

			//handle dynamically sizing columns/rows to clientarea
			this.gridDataBoundGrid1.Model.QueryColWidth += new GridRowColSizeEventHandler(GetColWidth);
			this.gridDataBoundGrid1.Model.QueryRowHeight += new GridRowColSizeEventHandler(GetRowHeight);

			this.checkBox1.Checked = true;
			this.proportionalCellSizing = true;
			this.gridDataBoundGrid1.DefaultRowHeight = 30;
			this.gridDataBoundGrid1.ResizeRowsBehavior = GridResizeCellsBehavior.ResizeAll;

			// force display of image
			gridDataBoundGrid1_CurrentCellChanged(gridDataBoundGrid1, EventArgs.Empty);
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridDataBoundGrid1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;
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

		
		private void GetColWidth(object sender, GridRowColSizeEventArgs e)
		{
			if(this.proportionalCellSizing && e.Index > 0)
			{
				e.Size = (int) ((this.gridDataBoundGrid1.ClientRectangle.Width - this.gridDataBoundGrid1.Model.ColWidths[0]) / (float)this.gridDataBoundGrid1.Model.ColCount);
				e.Handled = true;
			}
		}

		private void GetRowHeight(object sender, GridRowColSizeEventArgs e)
		{
			if(this.proportionalCellSizing && e.Index > 0)
			{
				e.Size = (int) ((this.gridDataBoundGrid1.ClientRectangle.Height - this.gridDataBoundGrid1.Model.RowHeights[0]) / (float)this.gridDataBoundGrid1.Model.RowCount);
				e.Handled = true;
			}
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			GridImageCellModel imageCell = this.gridDataBoundGrid1.Model.CellModels["ImageCell"] as GridImageCellModel;
			if(imageCell != null)
			{
				imageCell.CellDrawOption = GridImageCellDrawOption.FitToCell;
				this.gridDataBoundGrid1.Refresh();
			}
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			GridImageCellModel imageCell = this.gridDataBoundGrid1.Model.CellModels["ImageCell"] as GridImageCellModel;
			if(imageCell != null)
			{
				imageCell.CellDrawOption = GridImageCellDrawOption.NoResize;
				this.gridDataBoundGrid1.Refresh();
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			GridImageCellModel imageCell = this.gridDataBoundGrid1.Model.CellModels["ImageCell"] as GridImageCellModel;
			if(imageCell != null)
			{
				imageCell.CellDrawOption = GridImageCellDrawOption.FitProportionally;
				this.gridDataBoundGrid1.Refresh();
			}
		}

		private void gridDataBoundGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			int PictOffSet = 78;

			try
			{
				Byte[] pict = gridDataBoundGrid1[gridDataBoundGrid1.CurrentCell.RowIndex, 4].CellValue as Byte[];
					if(pict != null)
					{
						MemoryStream buffer = new MemoryStream(pict, PictOffSet, pict.Length - PictOffSet);
	
						this.pictureBox1.Image = Image.FromStream(buffer, true);
					}
					else
						this.pictureBox1.Image = null;
			}
			catch
			{
				this.pictureBox1.Image = null;
			}
		}

		private void gridDataBoundGrid1_CurrentCellMoved(object sender, Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventArgs e)
		{
			int PictOffSet = 78;

			try
			{
				Byte[] pict = gridDataBoundGrid1[gridDataBoundGrid1.CurrentCell.RowIndex, 4].CellValue as Byte[];
					if(pict != null)
					{
						MemoryStream buffer = new MemoryStream(pict, PictOffSet, pict.Length - PictOffSet);
	
						this.pictureBox1.Image = Image.FromStream(buffer, true);
					}
					else
						this.pictureBox1.Image = null;
			}
			catch
			{
				this.pictureBox1.Image = null;
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			proportionalCellSizing = ! proportionalCellSizing;
			this.gridDataBoundGrid1.Refresh();
		}

		private void Form1_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
			this.gridDataBoundGrid1.Refresh();
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			this.gridDataBoundGrid1.Refresh();
		}

		
	}
}
