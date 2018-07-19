#region Copyright Syncfusion Inc. 2001 - 2009
//
//  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace MultiRowRecord
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl gridRecordNavigationControl1;
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
        private Syncfusion.Windows.Forms.ButtonAdv okButton;
		private System.Windows.Forms.CheckBox toggleMultiRowCheckBox;
		private System.Windows.Forms.CheckBox outlineHeaderCheckBox;
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
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridDataBoundGrid1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
            this.gridRecordNavigationControl1 = new Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl();
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.okButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toggleMultiRowCheckBox = new System.Windows.Forms.CheckBox();
            this.outlineHeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridRecordNavigationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridRecordNavigationControl1
            // 
            this.gridRecordNavigationControl1.AllowAddNew = false;
            this.gridRecordNavigationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRecordNavigationControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridRecordNavigationControl1.Controls.Add(this.gridDataBoundGrid1);
            this.gridRecordNavigationControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gridRecordNavigationControl1.Location = new System.Drawing.Point(48, 39);
            this.gridRecordNavigationControl1.MaxRecord = 0;
            this.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1";
            this.gridRecordNavigationControl1.ShowToolTips = true;
            this.gridRecordNavigationControl1.Size = new System.Drawing.Size(691, 312);
            this.gridRecordNavigationControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.gridRecordNavigationControl1.TabIndex = 0;
            this.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1";
            this.gridRecordNavigationControl1.ThemesEnabled = true;
            this.gridRecordNavigationControl1.PaneClosing += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.gridRecordNavigationControl1_PaneClosing);
            this.gridRecordNavigationControl1.PaneCreated += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.gridRecordNavigationControl1_PaneCreated);
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid1.DefaultColWidth = 70;
            this.gridDataBoundGrid1.DefaultRowHeight = 18;
            this.gridDataBoundGrid1.FillSplitterPane = true;
            this.gridDataBoundGrid1.HorizontalThumbTrack = true;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(672, 293);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.VerticalThumbTrack = true;
            this.gridDataBoundGrid1.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(this.gridDataBoundGrid1_PrepareViewStyleInfo);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.okButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(642, 367);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 24);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Reset Binding";
            this.okButton.UseVisualStyle = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // toggleMultiRowCheckBox
            // 
            this.toggleMultiRowCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleMultiRowCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toggleMultiRowCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleMultiRowCheckBox.Location = new System.Drawing.Point(297, 367);
            this.toggleMultiRowCheckBox.Name = "toggleMultiRowCheckBox";
            this.toggleMultiRowCheckBox.Size = new System.Drawing.Size(160, 24);
            this.toggleMultiRowCheckBox.TabIndex = 2;
            this.toggleMultiRowCheckBox.Text = "Multiple rows per record";
            this.toggleMultiRowCheckBox.CheckedChanged += new System.EventHandler(this.toggleMultiRowCheckBox_CheckedChanged);
            // 
            // outlineHeaderCheckBox
            // 
            this.outlineHeaderCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outlineHeaderCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.outlineHeaderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlineHeaderCheckBox.Location = new System.Drawing.Point(473, 367);
            this.outlineHeaderCheckBox.Name = "outlineHeaderCheckBox";
            this.outlineHeaderCheckBox.Size = new System.Drawing.Size(152, 24);
            this.outlineHeaderCheckBox.TabIndex = 2;
            this.outlineHeaderCheckBox.Text = "Outline column header";
            this.outlineHeaderCheckBox.CheckedChanged += new System.EventHandler(this.outlineHeaderCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.outlineHeaderCheckBox);
            this.panel1.Controls.Add(this.toggleMultiRowCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 406);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(784, 406);
            this.Controls.Add(this.gridRecordNavigationControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Row Record Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gridRecordNavigationControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
		}

		DataSet dataSet11 = new DataSet("Test");

		private void okButton_Click(object sender, System.EventArgs e)
		{
				this.gridDataBoundGrid1.Binder.SuspendBinding();
				this.dataSet11.Clear();
				ReadXml(@"Common\Data\GDBDdata.XML");
				this.gridDataBoundGrid1.Binder.ResumeBinding();
		}

		void ReadXml(string xmlFileName)
		{
			for (int n = 0; n < 10; n++)
			{
				if (File.Exists(xmlFileName))
				{
					this.dataSet11.ReadXmlSchema(xmlFileName);
					this.dataSet11.ReadXml(xmlFileName);
					break;
				}
				xmlFileName = @"..\" + xmlFileName;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//we'll read the data from a local XML file
			//comment this line if you want to access your SQLserver
			this.gridDataBoundGrid1.Binder.SuspendBinding();
			ReadXml(@"Common\Data\GDBDdata.XML");

			this.gridDataBoundGrid1.DataMember = "Customers";
			this.gridDataBoundGrid1.DataSource = dataSet11;
			this.gridDataBoundGrid1.Binder.ResumeBinding();

			foreach (GridBoundColumn gb in this.gridDataBoundGrid1.Binder.InternalColumns)
			{
				System.Diagnostics.Trace.WriteLine("\"" + gb.MappingName + "\"");
			}
            
			this.gridDataBoundGrid1.DefaultRowHeight = 18;
			this.gridDataBoundGrid1.DefaultColWidth = 70;
            this.gridDataBoundGrid1.ResizeColsBehavior = GridResizeCellsBehavior.ResizeAll;
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

		
		private void outlineHeaderCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			this.gridDataBoundGrid1.HighlightCurrentColumnHeader = this.outlineHeaderCheckBox.Checked;
			this.gridDataBoundGrid1.Refresh();
		}

		private void toggleMultiRowCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			this.gridRecordNavigationControl1.HSplitPos = 100;
			this.gridRecordNavigationControl1.VSplitPos = 100;

			gridDataBoundGrid1 = this.gridRecordNavigationControl1.ActivePane as GridDataBoundGrid;
			GridModel gridModel = gridDataBoundGrid1.Model;
			GridModelDataBinder binder = gridDataBoundGrid1.Binder;

			gridModel.BeginUpdate();
			if (!this.toggleMultiRowCheckBox.Checked)
			{
				binder.LayoutColumns(
					new string[] {
									 "CustomerID",
									 "CompanyName",
									 "ContactName",
									 "ContactTitle",
									 "Address",
									 "City",
									 "PostalCode",
									 "Country",
									 "Phone",
									 "Fax",
									 "Region"
								 });
				this.gridDataBoundGrid1.HighlightCurrentColumnHeader = false;
				this.outlineHeaderCheckBox.Checked = false;
				this.gridDataBoundGrid1.AllowSelection = GridSelectionFlags.Any;
				this.gridDataBoundGrid1.SortBehavior = GridSortBehavior.DoubleClick;
			}
			else
			{
				// "-" indicates a covered cell
				// "." indicates a new row 
				binder.LayoutColumns(
					new string[] {
									 "CustomerID",
									 "CompanyName", "-",
									 "ContactTitle", 
									 "ContactName", "-",
									 ".", 
									 "Address", "-", "-",
									 "City", "-", "-",
									 ".", 
									 "PostalCode",
									 "Country", "-",
									 "Phone",
									 "Fax",
									 "Region"
								 });
				this.gridDataBoundGrid1.HighlightCurrentColumnHeader = true;
				this.outlineHeaderCheckBox.Checked = true;
				this.gridDataBoundGrid1.AllowSelection = GridSelectionFlags.None;
				this.gridDataBoundGrid1.SortBehavior = GridSortBehavior.SingleClick;
			}
			gridModel.ColWidths.ResetRange(1, gridModel.ColCount);
			gridModel.ColWidths.ResizeToFit(GridRangeInfo.Rows(0, this.gridDataBoundGrid1.ViewLayout.LastVisibleRow), GridResizeToFitOptions.IncludeHeaders|GridResizeToFitOptions.ResizeCoveredCells|GridResizeToFitOptions.NoShrinkSize);
			gridModel.EndUpdate(false);
			gridModel.Refresh();
			this.gridDataBoundGrid1.VerticalThumbTrack = true;
		}

		private void gridDataBoundGrid1_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
		{
			GridDataBoundGrid grid = sender as GridDataBoundGrid;
			if (grid != null && e.RowIndex > grid.Model.Rows.HeaderCount && e.ColIndex > grid.Model.Cols.HeaderCount)
			{
				if (grid.IsShowCurrentRow(e.RowIndex) && !grid.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex))
				{
					e.Style.BackColor = SystemColors.Highlight;
					e.Style.TextColor = SystemColors.HighlightText;
				}
				else 
				{
					GridBoundRecordState rs = grid.Binder.GetRecordStateAtRowIndex(e.RowIndex);
					if (rs.Position % 2 != 0)
						e.Style.BackColor = Color.FromArgb( 219, 226, 242 );
				}
			}
		}

		private void gridRecordNavigationControl1_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridDataBoundGrid grid = e.Control as GridDataBoundGrid;
			grid.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(this.gridDataBoundGrid1_PrepareViewStyleInfo);
		}

		private void gridRecordNavigationControl1_PaneClosing(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridDataBoundGrid grid = e.Control as GridDataBoundGrid;
			grid.PrepareViewStyleInfo -= new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(this.gridDataBoundGrid1_PrepareViewStyleInfo);
		}
	}
	
	/// <summary>
	/// Represents a class that is used to find the licensing file for Syncfusion controls.
	/// </summary>
	public class DemoCommon
	{

		/// <summary>
		/// Finds the license key from the Common folder.
		/// </summary>
		/// <returns>Returns the license key.</returns>
		public static string FindLicenseKey()
		{
			string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
			for (int n = 0; n < 20; n++)
			{
				if (!System.IO.File.Exists(licenseKeyFile))
				{
					licenseKeyFile = @"..\" + licenseKeyFile;
					continue;
				}
				return System.IO.File.ReadAllText(licenseKeyFile);
			}
			return string.Empty;
		}
	}
}
