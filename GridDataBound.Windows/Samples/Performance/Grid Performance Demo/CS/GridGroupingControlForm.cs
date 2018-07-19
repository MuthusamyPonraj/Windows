#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace GroupingPerf
{
	/// <summary>
	/// Summary description for GridGroupingControlForm.
	/// </summary>
	public class GridGroupingControlForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel gridPanel;
		private GridGroupingControl grid;
		private System.Windows.Forms.Button btnInitGrid;
		private DataTable table;

		int randomKey = 100;
		int zipCount = 100;
		int recordCount = 20000;
		bool calculateMaxColumnWidth = false;
		bool useGroupingSortList = false;
		bool sortandCategorize = true;
		bool optimizeScrolling = true;
		int batchSize = 50;
		int repeatCount = 300;
		string[] states = new string[]{"North Carolina", "South Carolina", "Washington", "Nevada", "Ohio"};
		private System.Windows.Forms.Button btnResetGrid;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelRecordCount;
		private System.Windows.Forms.Label labelZipCount;
		private System.Windows.Forms.CheckBox checkBoxCalculateMaximumWidth;
		private System.Windows.Forms.CheckBox checkBoxUseDataViewSort;
		private System.Windows.Forms.CheckBox checkBoxMultiThreading;
		private System.Windows.Forms.TextBox textBoxRecordCount;
		private System.Windows.Forms.TextBox textBoxZipCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxRepeatCount;
		private System.Windows.Forms.Button buttonInsertRecords;
		private System.Windows.Forms.Button buttonRemoveRecords;
		private System.Windows.Forms.CheckBox checkBoxSortandCategorize;
		private System.Windows.Forms.CheckBox checkBoxUseScrollWindow;
		private System.Windows.Forms.GroupBox grpInitializeTable;
		private System.Windows.Forms.GroupBox grpgroupBox1;
		private System.Windows.Forms.Label lbllabel2;
		private System.Windows.Forms.TextBox txtBatchSize;
		private System.Windows.Forms.Button buttonChangeRecords;
		private System.Windows.Forms.Button btnCollapseAll;
		private System.Windows.Forms.Button btnExpandAll;
		private System.Windows.Forms.Button btnChangeNames;
		bool allowMultiThreading = false;

		public GridGroupingControlForm()
		{
			// GroupingEngineFactory provides a trimmed down GridGroup
			// which eliminates overhead of not needed preview rows, header and footer cells.
			GridEngineFactory.Factory = new GroupingEngineFactory();

			InitializeComponent();

			this.textBoxRepeatCount.Text = repeatCount.ToString();
			this.textBoxRecordCount.Text = recordCount.ToString();
			this.textBoxZipCount.Text = zipCount.ToString();
			this.checkBoxMultiThreading.Checked =this.allowMultiThreading;
			this.checkBoxUseDataViewSort.Checked = this.useGroupingSortList;
			this.checkBoxCalculateMaximumWidth.Checked = this.calculateMaxColumnWidth;
			checkBoxSortandCategorize.Checked = this.sortandCategorize;
			this.txtBatchSize.Text = this.batchSize.ToString();
			checkBoxUseScrollWindow.Checked = optimizeScrolling;

			InitializeDataTable();

		}

		private void InitializeDataTable()
		{
			Random random = new Random(randomKey++);
			int numStates = states.GetLength(0);
			string nameFormat = "Name{0:00000}";

			this.table = new DataTable("Test");

			DataColumn col = table.Columns.Add();
			col.DataType = typeof(string);
			col.ColumnName = "Name";

			col = table.Columns.Add();
			col.DataType = typeof(string);
			col.ColumnName = "State";

			col = table.Columns.Add();
			col.DataType = typeof(int);
			col.ColumnName = "Zip";

			for(int i = 0; i < recordCount; i++)
			{
				DataRow row = this.table.NewRow();
				row["Name"] = string.Format(nameFormat, i);
				row["State"] = states[random.Next(numStates-1)];
				row["Zip"] = random.Next(zipCount);
				this.table.Rows.Add(row);
			}

			this.table.DefaultView.RowStateFilter = DataViewRowState.CurrentRows;
		}

		void ResetGroupingGrid()
		{
			if (this.grid != null)
			{
				this.gridPanel.Controls.Remove(this.grid);
				this.table.Disposed += new EventHandler(table_Disposed);
				this.table.DefaultView.Disposed += new EventHandler(table_Disposed);
				this.grid.Dispose();
				this.grid = null;
				this.LogMemoryUsage();
			}
		}

		void LogMemoryUsage()
		{
			if (grid != null)
			{
				this.textBox1.Text += String.Format("Table Record Count {0}, Grid Record Count {1}/{3}, Display Element Count {2}, Element Count{4}\r\n", table.Rows.Count, grid.Table.Records.Count, grid.Table.DisplayElements.Count, grid.Table.UnsortedRecords.Count, grid.Table.Elements.Count);
			}
			// Force garbage collection and get used memory size
			GC.Collect();
			System.Threading.Thread.Sleep(randomKey++);
			Process myProcess = Process.GetCurrentProcess();
			double workingSetSizeinKiloBytes = myProcess.WorkingSet / 1000;
			string s = "Process's physical memory usage: " + workingSetSizeinKiloBytes.ToString() + " kb \r\n";
			this.textBox1.Text += s;
			ScrollTextBox();
		}

		void ScrollTextBox()
		{
			this.textBox1.SelectionStart = this.textBox1.Text.Length;
			this.textBox1.ScrollBars = ScrollBars.Vertical;
			this.textBox1.ScrollToCaret();
			this.textBox1.Focus();
		}

		private void InitializeGroupingGrid()
		{
			if (this.grid != null)
				this.grid.Dispose();

			DateTime dtStart = DateTime.Now;

			Cursor.Current = Cursors.WaitCursor;

			// Fill DataTable
			InitializeDataTable();

			DateTime dtFill = DateTime.Now;

			// Show an empty grid - triggers JIT compilation when run first time
			this.grid = new GridGroupingControl();
			this.grid.TableDescriptor.AllowCalculateMaxColumnWidth = calculateMaxColumnWidth;
			this.grid.Dock = DockStyle.Fill;

			// only set this on true multiprocessor machines - otherwise it slows down a bit
			// because of synchronization overhead.
			this.grid.Table.AllowThreading = this.allowMultiThreading;

			// DataView has performance issues when inserting new records into a large
			// dataset. Instead of getting the DataTable.DefaultView, the engine
			// can wrap the data table with a more efficient DataTableList class. 
			// This allows instantenoues inserts for DataTable with > 100000 records.
			this.grid.Engine.AllowSwapDataViewWithDataTableList = true;

			// Assign data source
			if (useGroupingSortList)
			{
				GroupingSortList gs = new GroupingSortList(this.table);
				this.grid.DataSource = gs;
			}
			else
				this.grid.DataSource = this.table;

			// Assign grouping and sort order
			if (this.sortandCategorize)
			{
				this.grid.TableDescriptor.GroupedColumns.Add("State");
				this.grid.TableDescriptor.GroupedColumns.Add("Zip");
			}

			// Force filling and intialization of engine and drawing of grid.
			int count = this.grid.Table.DisplayElements.Count;

			DateTime dtCount = DateTime.Now;

			// paint the grid.
			this.gridPanel.Controls.Add(this.grid);
			this.grid.Update();

			Cursor.Current = Cursors.Default;

			DateTime dtPaint = DateTime.Now;

			string time1 = String.Format("Fill Datatable: {0}\r\n", dtFill-dtStart);
			string time3 = String.Format("Set data source and categorize: {0}\r\n", dtCount-dtFill);
			string time4 = String.Format("Repaint: {0}\r\n", dtPaint-dtCount);
			string time6 = String.Format("Total time: {0}\r\n", dtPaint-dtStart);

			this.textBox1.Text += "\r\n\r\n" + time1 + time3 + time4 + time6;
			this.LogMemoryUsage();
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
			this.gridPanel = new System.Windows.Forms.Panel();
			this.btnInitGrid = new System.Windows.Forms.Button();
			this.btnResetGrid = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelRecordCount = new System.Windows.Forms.Label();
			this.labelZipCount = new System.Windows.Forms.Label();
			this.checkBoxCalculateMaximumWidth = new System.Windows.Forms.CheckBox();
			this.checkBoxUseDataViewSort = new System.Windows.Forms.CheckBox();
			this.checkBoxMultiThreading = new System.Windows.Forms.CheckBox();
			this.textBoxRecordCount = new System.Windows.Forms.TextBox();
			this.textBoxZipCount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxRepeatCount = new System.Windows.Forms.TextBox();
			this.buttonInsertRecords = new System.Windows.Forms.Button();
			this.buttonRemoveRecords = new System.Windows.Forms.Button();
			this.buttonChangeRecords = new System.Windows.Forms.Button();
			this.checkBoxSortandCategorize = new System.Windows.Forms.CheckBox();
			this.checkBoxUseScrollWindow = new System.Windows.Forms.CheckBox();
			this.grpInitializeTable = new System.Windows.Forms.GroupBox();
			this.grpgroupBox1 = new System.Windows.Forms.GroupBox();
			this.btnChangeNames = new System.Windows.Forms.Button();
			this.btnExpandAll = new System.Windows.Forms.Button();
			this.btnCollapseAll = new System.Windows.Forms.Button();
			this.txtBatchSize = new System.Windows.Forms.TextBox();
			this.lbllabel2 = new System.Windows.Forms.Label();
			this.grpInitializeTable.SuspendLayout();
			this.grpgroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			// gridPanel
			//
			this.gridPanel.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				| System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right);
			this.gridPanel.Location = new System.Drawing.Point(16, 16);
			this.gridPanel.Name = "gridPanel";
			this.gridPanel.Size = new System.Drawing.Size(544, 352);
			this.gridPanel.TabIndex = 0;
			//
			// btnInitGrid
			//
			this.btnInitGrid.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnInitGrid.Location = new System.Drawing.Point(16, 232);
			this.btnInitGrid.Name = "btnInitGrid";
			this.btnInitGrid.Size = new System.Drawing.Size(72, 24);
			this.btnInitGrid.TabIndex = 1;
			this.btnInitGrid.TabStop = false;
			this.btnInitGrid.Text = "Load Grid";
			this.btnInitGrid.Click += new System.EventHandler(this.btnInitGrid_Click);
			//
			// btnResetGrid
			//
			this.btnResetGrid.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnResetGrid.Location = new System.Drawing.Point(680, 248);
			this.btnResetGrid.Name = "btnResetGrid";
			this.btnResetGrid.Size = new System.Drawing.Size(72, 24);
			this.btnResetGrid.TabIndex = 1;
			this.btnResetGrid.TabStop = false;
			this.btnResetGrid.Text = "Reset Grid";
			this.btnResetGrid.Click += new System.EventHandler(this.btnResetGrid_Click);
			//
			// textBox1
			//
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right);
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(16, 384);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(544, 160);
			this.textBox1.TabIndex = 3;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "Results:\r\n-----------";
			//
			// labelRecordCount
			//
			this.labelRecordCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelRecordCount.Location = new System.Drawing.Point(592, 40);
			this.labelRecordCount.Name = "labelRecordCount";
			this.labelRecordCount.Size = new System.Drawing.Size(72, 23);
			this.labelRecordCount.TabIndex = 4;
			this.labelRecordCount.Text = "RecordCount";
			//
			// labelZipCount
			//
			this.labelZipCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelZipCount.Location = new System.Drawing.Point(592, 80);
			this.labelZipCount.Name = "labelZipCount";
			this.labelZipCount.Size = new System.Drawing.Size(64, 23);
			this.labelZipCount.TabIndex = 5;
			this.labelZipCount.Text = "Zip Count";
			//
			// checkBoxCalculateMaximumWidth
			//
			this.checkBoxCalculateMaximumWidth.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.checkBoxCalculateMaximumWidth.Checked = true;
			this.checkBoxCalculateMaximumWidth.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCalculateMaximumWidth.Location = new System.Drawing.Point(592, 144);
			this.checkBoxCalculateMaximumWidth.Name = "checkBoxCalculateMaximumWidth";
			this.checkBoxCalculateMaximumWidth.Size = new System.Drawing.Size(160, 24);
			this.checkBoxCalculateMaximumWidth.TabIndex = 3;
			this.checkBoxCalculateMaximumWidth.Text = "Calculate Column Width";
			//
			// checkBoxUseDataViewSort
			//
			this.checkBoxUseDataViewSort.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.checkBoxUseDataViewSort.Location = new System.Drawing.Point(592, 168);
			this.checkBoxUseDataViewSort.Name = "checkBoxUseDataViewSort";
			this.checkBoxUseDataViewSort.Size = new System.Drawing.Size(160, 24);
			this.checkBoxUseDataViewSort.TabIndex = 4;
			this.checkBoxUseDataViewSort.Text = "Use DataView Sort ";
			//
			// checkBoxMultiThreading
			//
			this.checkBoxMultiThreading.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.checkBoxMultiThreading.Location = new System.Drawing.Point(592, 192);
			this.checkBoxMultiThreading.Name = "checkBoxMultiThreading";
			this.checkBoxMultiThreading.Size = new System.Drawing.Size(128, 24);
			this.checkBoxMultiThreading.TabIndex = 5;
			this.checkBoxMultiThreading.Text = "MultiThreading";
			//
			// textBoxRecordCount
			//
			this.textBoxRecordCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.textBoxRecordCount.Location = new System.Drawing.Point(680, 40);
			this.textBoxRecordCount.Name = "textBoxRecordCount";
			this.textBoxRecordCount.Size = new System.Drawing.Size(64, 20);
			this.textBoxRecordCount.TabIndex = 0;
			this.textBoxRecordCount.Text = "50000";
			//
			// textBoxZipCount
			//
			this.textBoxZipCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.textBoxZipCount.Location = new System.Drawing.Point(680, 80);
			this.textBoxZipCount.Name = "textBoxZipCount";
			this.textBoxZipCount.Size = new System.Drawing.Size(64, 20);
			this.textBoxZipCount.TabIndex = 1;
			this.textBoxZipCount.Text = "1000";
			//
			// label1
			//
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.Location = new System.Drawing.Point(592, 336);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Repeat Count";
			//
			// textBoxRepeatCount
			//
			this.textBoxRepeatCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.textBoxRepeatCount.Location = new System.Drawing.Point(680, 336);
			this.textBoxRepeatCount.Name = "textBoxRepeatCount";
			this.textBoxRepeatCount.Size = new System.Drawing.Size(64, 20);
			this.textBoxRepeatCount.TabIndex = 6;
			this.textBoxRepeatCount.Text = "100";
			//
			// buttonInsertRecords
			//
			this.buttonInsertRecords.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonInsertRecords.Location = new System.Drawing.Point(16, 144);
			this.buttonInsertRecords.Name = "buttonInsertRecords";
			this.buttonInsertRecords.Size = new System.Drawing.Size(104, 23);
			this.buttonInsertRecords.TabIndex = 12;
			this.buttonInsertRecords.TabStop = false;
			this.buttonInsertRecords.Text = "Insert Records";
			this.buttonInsertRecords.Click += new System.EventHandler(this.buttonInsertRecords_Click);
			//
			// buttonRemoveRecords
			//
			this.buttonRemoveRecords.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonRemoveRecords.Location = new System.Drawing.Point(16, 112);
			this.buttonRemoveRecords.Name = "buttonRemoveRecords";
			this.buttonRemoveRecords.Size = new System.Drawing.Size(104, 23);
			this.buttonRemoveRecords.TabIndex = 12;
			this.buttonRemoveRecords.TabStop = false;
			this.buttonRemoveRecords.Text = "Remove Records";
			this.buttonRemoveRecords.Click += new System.EventHandler(this.buttonRemoveRecords_Click);
			//
			// buttonChangeRecords
			//
			this.buttonChangeRecords.Location = new System.Drawing.Point(16, 176);
			this.buttonChangeRecords.Name = "buttonChangeRecords";
			this.buttonChangeRecords.Size = new System.Drawing.Size(104, 23);
			this.buttonChangeRecords.TabIndex = 16;
			this.buttonChangeRecords.TabStop = false;
			this.buttonChangeRecords.Text = "Change Records";
			this.buttonChangeRecords.Click += new System.EventHandler(this.buttonChangeRecords_Click);
			//
			// checkBoxSortandCategorize
			//
			this.checkBoxSortandCategorize.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.checkBoxSortandCategorize.Checked = true;
			this.checkBoxSortandCategorize.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSortandCategorize.Location = new System.Drawing.Point(592, 120);
			this.checkBoxSortandCategorize.Name = "checkBoxSortandCategorize";
			this.checkBoxSortandCategorize.Size = new System.Drawing.Size(160, 24);
			this.checkBoxSortandCategorize.TabIndex = 2;
			this.checkBoxSortandCategorize.Text = "Sort and Categorize";
			//
			// checkBoxUseScrollWindow
			//
			this.checkBoxUseScrollWindow.Location = new System.Drawing.Point(24, 88);
			this.checkBoxUseScrollWindow.Name = "checkBoxUseScrollWindow";
			this.checkBoxUseScrollWindow.Size = new System.Drawing.Size(152, 16);
			this.checkBoxUseScrollWindow.TabIndex = 8;
			this.checkBoxUseScrollWindow.Text = "Use ScrollWindow";
			//
			// grpInitializeTable
			//
			this.grpInitializeTable.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.grpInitializeTable.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.btnInitGrid});
			this.grpInitializeTable.Location = new System.Drawing.Point(576, 16);
			this.grpInitializeTable.Name = "grpInitializeTable";
			this.grpInitializeTable.Size = new System.Drawing.Size(208, 272);
			this.grpInitializeTable.TabIndex = 14;
			this.grpInitializeTable.TabStop = false;
			this.grpInitializeTable.Text = "Initialize Table";
			//
			// grpgroupBox1
			//
			this.grpgroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.grpgroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.btnChangeNames,
																					   this.btnExpandAll,
																					   this.btnCollapseAll,
																					   this.txtBatchSize,
																					   this.lbllabel2,
																					   this.checkBoxUseScrollWindow,
																					   this.buttonRemoveRecords,
																					   this.buttonChangeRecords,
																					   this.buttonInsertRecords});
			this.grpgroupBox1.Location = new System.Drawing.Point(576, 304);
			this.grpgroupBox1.Name = "grpgroupBox1";
			this.grpgroupBox1.Size = new System.Drawing.Size(208, 240);
			this.grpgroupBox1.TabIndex = 15;
			this.grpgroupBox1.TabStop = false;
			this.grpgroupBox1.Text = "Manipulate Grid";
			//
			// btnChangeNames
			//
			this.btnChangeNames.Location = new System.Drawing.Point(16, 207);
			this.btnChangeNames.Name = "btnChangeNames";
			this.btnChangeNames.Size = new System.Drawing.Size(104, 23);
			this.btnChangeNames.TabIndex = 17;
			this.btnChangeNames.TabStop = false;
			this.btnChangeNames.Text = "Change Names";
			this.btnChangeNames.Click += new System.EventHandler(this.btnChangeNames_Click);
			//
			// btnExpandAll
			//
			this.btnExpandAll.Location = new System.Drawing.Point(128, 176);
			this.btnExpandAll.Name = "btnExpandAll";
			this.btnExpandAll.Size = new System.Drawing.Size(64, 32);
			this.btnExpandAll.TabIndex = 15;
			this.btnExpandAll.TabStop = false;
			this.btnExpandAll.Text = "Expand All";
			this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
			//
			// btnCollapseAll
			//
			this.btnCollapseAll.Location = new System.Drawing.Point(128, 112);
			this.btnCollapseAll.Name = "btnCollapseAll";
			this.btnCollapseAll.Size = new System.Drawing.Size(64, 32);
			this.btnCollapseAll.TabIndex = 14;
			this.btnCollapseAll.TabStop = false;
			this.btnCollapseAll.Text = "Collapse All";
			this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
			//
			// txtBatchSize
			//
			this.txtBatchSize.Location = new System.Drawing.Point(104, 56);
			this.txtBatchSize.Name = "txtBatchSize";
			this.txtBatchSize.Size = new System.Drawing.Size(64, 20);
			this.txtBatchSize.TabIndex = 7;
			this.txtBatchSize.Text = "1";
			//
			// lbllabel2
			//
			this.lbllabel2.Location = new System.Drawing.Point(24, 56);
			this.lbllabel2.Name = "lbllabel2";
			this.lbllabel2.Size = new System.Drawing.Size(72, 16);
			this.lbllabel2.TabIndex = 0;
			this.lbllabel2.Text = "Batch Size";
			//
			// GridGroupingControlForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBoxRepeatCount,
																		  this.textBoxRecordCount,
																		  this.checkBoxCalculateMaximumWidth,
																		  this.textBox1,
																		  this.textBoxZipCount,
																		  this.checkBoxSortandCategorize,
																		  this.label1,
																		  this.checkBoxMultiThreading,
																		  this.checkBoxUseDataViewSort,
																		  this.labelZipCount,
																		  this.labelRecordCount,
																		  this.gridPanel,
																		  this.btnResetGrid,
																		  this.grpInitializeTable,
																		  this.grpgroupBox1});
			this.MinimumSize = new System.Drawing.Size(400, 600);
			this.Name = "GridGroupingControlForm";
			this.Text = "GridGroupingControl Performance";
			this.grpInitializeTable.ResumeLayout(false);
			this.grpgroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void btnInitGrid_Click(object sender, System.EventArgs e)
		{

			this.allowMultiThreading = this.checkBoxMultiThreading.Checked;
			this.useGroupingSortList = this.checkBoxUseDataViewSort.Checked;
			this.calculateMaxColumnWidth = this.checkBoxCalculateMaximumWidth.Checked;
			this.recordCount = Convert.ToInt32(this.textBoxRecordCount.Text);
			this.zipCount = Convert.ToInt32(this.textBoxZipCount.Text);
			this.sortandCategorize = checkBoxSortandCategorize.Checked;

			this.InitializeGroupingGrid();
		}

		private void table_Disposed(object sender, EventArgs e)
		{
		}

		private void btnResetGrid_Click(object sender, System.EventArgs e)
		{
			this.ResetGroupingGrid();
		}

		private void buttonInsertRecords_Click(object sender, System.EventArgs e)
		{
			if (grid == null)
				return;

			repeatCount = Convert.ToInt32(this.textBoxRepeatCount.Text);
			batchSize = Convert.ToInt32(this.txtBatchSize.Text);
			optimizeScrolling = checkBoxUseScrollWindow.Checked;

			Cursor.Current = Cursors.WaitCursor;

			DateTime dtStart = DateTime.Now;

			Random random = new Random(randomKey++);
			int numStates = states.GetLength(0);
			string nameFormat = "Ins{0:00000}";

			// Use ScrollWindow operations instead of invalidating whole grid when
			// inserting or removing records.
			this.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling;

			for(int i = 0; i < repeatCount; i++)
			{
				DataRow row = this.table.NewRow();
				row["Name"] = string.Format(nameFormat, this.table.Rows.Count);
				row["State"] = states[random.Next(numStates-1)];
				row["Zip"] = random.Next(zipCount);
				this.table.Rows.Add(row);

				// Force immediate update of visible area and scrollbars after each operation
				// when grouped, record will automatically be inserted in the correct group
				// and sort order.
				if ((i+1) % batchSize == 0)
					grid.Update();
			}
			this.grid.Update();

			DateTime dtEnd = DateTime.Now;

			Cursor.Current = Cursors.Default;

			string time1 = String.Format("Inserted {0} Records: {1}\r\n", repeatCount, dtEnd-dtStart);
			this.textBox1.Text += "\r\n\r\n" + time1;
			this.LogMemoryUsage();
		}

		private void buttonRemoveRecords_Click(object sender, System.EventArgs e)
		{
			if (grid == null)
				return;

			repeatCount = Convert.ToInt32(this.textBoxRepeatCount.Text);
			batchSize = Convert.ToInt32(this.txtBatchSize.Text);
			optimizeScrolling = checkBoxUseScrollWindow.Checked;

			Cursor.Current = Cursors.WaitCursor;

			DateTime dtStart = DateTime.Now;

			Random random = new Random(randomKey++);

			// Use ScrollWindow operations instead of invalidating whole grid when
			// inserting or removing records.
			this.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling;

			for(int i = 0; i < repeatCount; i++)
			{
				int record = (int) Math.Min(table.Rows.Count-1, random.Next(0, table.Rows.Count));
				if (record < 0)
					break;

					this.table.Rows.RemoveAt(record);

				// Force immediate update of visible area and scrollbars after each operation
				//Trace.WriteLine(String.Format("Table Record Count {0}, Grid Record Count {1}/{3}, Display Element Count {2}\r\n", table.Rows.Count, grid.Table.Records.Count, grid.Table.DisplayElements.Count, grid.Table.UnsortedRecords.Count));
				if ((i+1) % batchSize == 0)
					grid.Update();

				if (table.Rows.Count == 0)
					break;
			}
			this.grid.Update();

			DateTime dtEnd = DateTime.Now;

			Cursor.Current = Cursors.Default;

			string time1 = String.Format("Removed {0} Records: {1}\r\n", repeatCount, dtEnd-dtStart);
			this.textBox1.Text += "\r\n\r\n" + time1;
			this.LogMemoryUsage();
		}

		private void btnChangeNames_Click(object sender, System.EventArgs e)
		{
			if (grid == null)
				return;

			repeatCount = Convert.ToInt32(this.textBoxRepeatCount.Text);
			batchSize = Convert.ToInt32(this.txtBatchSize.Text);
			optimizeScrolling = checkBoxUseScrollWindow.Checked;

			Cursor.Current = Cursors.WaitCursor;

			DateTime dtStart = DateTime.Now;

			Random random = new Random(randomKey++);
			string nameFormat = "Chg{0:00000}";
			int numStates = states.GetLength(0);


			// Use ScrollWindow operations instead of invalidating whole grid when
			// inserting or removing records.
			this.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling;

			for(int i = 0; i < repeatCount; i++)
			{
				int record = (int) Math.Min(table.Rows.Count-1, random.Next(table.Rows.Count));
				if (record >= 0)
				{
					DataRow row = this.table.Rows[record];
					row["Name"] = string.Format(nameFormat, i);
				}

				// Force immediate update of visible area and scrollbars after each operation
				// If grid is sorted by name, the record will be removed and reinserted at correct
				// sort position.
				if ((i+1) % batchSize == 0)
					grid.Update();
			}
			this.grid.Update();

			DateTime dtEnd = DateTime.Now;

			Cursor.Current = Cursors.Default;

			string time1 = String.Format("Changed {0} Records: {1}\r\n", repeatCount, dtEnd-dtStart);
			this.textBox1.Text += "\r\n\r\n" + time1;
			this.LogMemoryUsage();
		}

		private void btnCollapseAll_Click(object sender, System.EventArgs e)
		{
			if (grid == null)
				return;

			DateTime dtStart = DateTime.Now;

			Cursor.Current = Cursors.WaitCursor;

			this.grid.Table.CollapseAllGroups();

			DateTime dtEnd = DateTime.Now;

			Cursor.Current = Cursors.Default;

			string time1 = String.Format("Expanded all groups: {0}\r\n", dtEnd-dtStart);
			this.textBox1.Text += "\r\n\r\n" + time1;
			this.LogMemoryUsage();
		}

		private void btnExpandAll_Click(object sender, System.EventArgs e)
		{
			if (grid == null)
				return;

			DateTime dtStart = DateTime.Now;

			Cursor.Current = Cursors.WaitCursor;

			this.grid.Table.ExpandAllGroups();

			DateTime dtEnd = DateTime.Now;

			Cursor.Current = Cursors.Default;

			string time1 = String.Format("Expanded all groups: {0}\r\n", dtEnd-dtStart);
			this.textBox1.Text += "\r\n\r\n" + time1;
			this.LogMemoryUsage();
		}

		private void buttonChangeRecords_Click(object sender, System.EventArgs e)
		{
			if (grid == null)
				return;

			repeatCount = Convert.ToInt32(this.textBoxRepeatCount.Text);
			batchSize = Convert.ToInt32(this.txtBatchSize.Text);
			optimizeScrolling = checkBoxUseScrollWindow.Checked;

			Cursor.Current = Cursors.WaitCursor;

			DateTime dtStart = DateTime.Now;

			Random random = new Random(randomKey++);
			string nameFormat = "Chg{0:00000}";
			int numStates = states.GetLength(0);


			// Use ScrollWindow operations instead of invalidating whole grid when
			// inserting or removing records.
			this.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling;

			for(int i = 0; i < repeatCount; i++)
			{
				int record = (int) Math.Min(table.Rows.Count-1, random.Next(table.Rows.Count));
				if (record >= 0)
				{
					DataRow row = this.table.Rows[record];
					row.BeginEdit();
					row["Name"] = string.Format(nameFormat, i);
					row["State"] = states[random.Next(numStates-1)];
					row["Zip"] = random.Next(zipCount);
					row.EndEdit();
				}

				// Force immediate update of visible area and scrollbars after each operation
				// If grid is sorted by name, the record will be removed and reinserted at correct
				// sort position.
				if ((i+1) % batchSize == 0)
					grid.Update();
			}
			this.grid.Update();

			DateTime dtEnd = DateTime.Now;

			Cursor.Current = Cursors.Default;

			string time1 = String.Format("Changed {0} Records: {1}\r\n", repeatCount, dtEnd-dtStart);
			this.textBox1.Text += "\r\n\r\n" + time1;
			this.LogMemoryUsage();		}


	}



	/// <summary>
	/// GroupingSortList wraps a DataView with a IBindingList and implements the IGroupingList
	/// interface and its Sort method. This allows performing the sort on the dataview directly
	/// instead of letting the grouping engine perform the sorting.
	/// </summary>
	public class GroupingSortList : IGroupingList, IBindingList
	{
		DataTable dt;
		DataView dv;
		IBindingList bindingList;

		public GroupingSortList(DataTable dt)
		{
			this.dt = dt;
			this.dv = dt.DefaultView;
			bindingList = (IBindingList) dv;
			bindingList.ListChanged += new ListChangedEventHandler(bindingList_ListChanged);
		}

		#region IGroupingList Members

		public void ApplySort(RelationChildColumnDescriptorCollection relationChildColumns, SortColumnDescriptorCollection groupColumns, SortColumnDescriptorCollection sortColumns)
		{
			bool first = true;
			StringBuilder sb = new StringBuilder();
			foreach (SortColumnDescriptor sd in relationChildColumns)
			{
				if (first)
					first = false;
				else
					sb.Append(", ");

				sb.Append(sd.FieldDescriptor.MappingName);
				if (sd.SortDirection == ListSortDirection.Descending)
					sb.Append(" DESC");
			}
			foreach (SortColumnDescriptor sd in groupColumns)
			{
				if (first)
					first = false;
				else
					sb.Append(", ");

				sb.Append(sd.FieldDescriptor.MappingName);
				if (sd.SortDirection == ListSortDirection.Descending)
					sb.Append(" DESC");
			}
			foreach (SortColumnDescriptor sd in sortColumns)
			{
				if (first)
					first = false;
				else
					sb.Append(", ");

				sb.Append(sd.FieldDescriptor.MappingName);
				if (sd.SortDirection == ListSortDirection.Descending)
					sb.Append(" DESC");
			}

			string sort = sb.ToString();
			if (sort != dv.Sort)
			{
				dv.Sort = sort;
			}
		}

		public bool AllowItemReference
		{
			get
			{
				return false;
			}
		}

		public bool SupportsGroupSorting
		{
			get
			{
				return true;
			}
		}

		public Syncfusion.Grouping.GroupingSortBehavior GroupingSortBehavior
		{
			get
			{
				return Syncfusion.Grouping.GroupingSortBehavior.GroupByGroup;
			}
		}

		#endregion

		#region IBindingList Members

		public void AddIndex(PropertyDescriptor property)
		{
			bindingList.AddIndex(property);
		}

		public bool AllowNew
		{
			get
			{
				return bindingList.AllowNew;
			}
		}

		void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, System.ComponentModel.ListSortDirection direction)
		{
			bindingList.ApplySort(property, direction);
		}

		public PropertyDescriptor SortProperty
		{
			get
			{
				return bindingList.SortProperty;
			}
		}

		public int Find(PropertyDescriptor property, object key)
		{
			return bindingList.Find(property, key);
		}

		public bool SupportsSorting
		{
			get
			{
				return bindingList.SupportsSorting;
			}
		}

		public bool IsSorted
		{
			get
			{
				return bindingList.IsSorted;
			}
		}

		public bool AllowRemove
		{
			get
			{
				return bindingList.AllowRemove;
			}
		}

		public bool SupportsSearching
		{
			get
			{
				return bindingList.SupportsSearching;
			}
		}

		public System.ComponentModel.ListSortDirection SortDirection
		{
			get
			{
				return bindingList.SortDirection;
			}
		}

		public event System.ComponentModel.ListChangedEventHandler ListChanged;

		public bool SupportsChangeNotification
		{
			get
			{
				return bindingList.SupportsChangeNotification;
			}
		}

		public void RemoveSort()
		{
			bindingList.RemoveSort();
		}

		public object AddNew()
		{
			return bindingList.AddNew();
		}

		public bool AllowEdit
		{
			get
			{
				return bindingList.AllowEdit;
			}
		}

		public void RemoveIndex(PropertyDescriptor property)
		{
			bindingList.RemoveIndex(property);
		}

		#endregion

		#region IList Members

		public bool IsReadOnly
		{
			get
			{
				return bindingList.IsReadOnly;
			}
		}

		public object this[int index]
		{
			get
			{
				return bindingList[index];
			}
			set
			{
				bindingList[index] = value;
			}
		}

		public void RemoveAt(int index)
		{
			bindingList.RemoveAt(index);
		}

		public void Insert(int index, object value)
		{
			bindingList.Insert(index, value);
		}

		public void Remove(object value)
		{
			bindingList.Remove(value);
		}

		public bool Contains(object value)
		{

			return bindingList.Contains(value);
		}

		public void Clear()
		{
			bindingList.Clear();
		}

		public int IndexOf(object value)
		{
			return bindingList.IndexOf(value);
		}

		public int Add(object value)
		{
			return bindingList.Add(value);
		}

		public bool IsFixedSize
		{
			get
			{
				return bindingList.IsFixedSize;
			}
		}

		#endregion

		#region ICollection Members

		public bool IsSynchronized
		{
			get
			{
				return bindingList.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return bindingList.Count;
			}
		}

		public void CopyTo(Array array, int index)
		{
			bindingList.CopyTo(array, index);
		}

		public object SyncRoot
		{
			get
			{
				return bindingList.SyncRoot;
			}
		}

		#endregion

		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			return bindingList.GetEnumerator();
		}

		#endregion

		private void bindingList_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (ListChanged != null)
				ListChanged(this, e);
		}
	}

	/// <summary>
	/// GroupingEngineFactory provides a trimmed down GridGroup
	/// which eliminates overhead of not needed preview rows, header and footer cells.
	/// </summary>
	public class GroupingEngineFactory : GridEngineFactoryBase
	{
		public override GridEngine CreateEngine()
		{
			return new GroupingEngine();
		}
	}

	public class GroupingEngine : GridEngine
	{
		public override Group CreateGroup(Section parent)
		{
			return new GroupingGroup(parent);
		}

	}

	public class GroupingGroup : Group
	{
		public GroupingGroup(Section parent)
			: base(parent)
		{
		}

		protected override void OnInitializeSections(bool hasRecords, SortColumnDescriptorCollection fields)
		{
			this.Sections.Add(this.ParentTableDescriptor.CreateCaptionSection(this));
			if (hasRecords)
				this.Sections.Add(this.ParentTableDescriptor.CreateRecordsDetails(this, fields));
			else
				this.Sections.Add(this.ParentTableDescriptor.CreateGroupsDetails(this, fields));
			this.Sections.Add(this.ParentTableDescriptor.CreateSummarySection(this));
		}

		public override bool IsChildVisible(Element el)
		{
			if (el is CaptionSection)
			{
				return true;
			}
			else if (el is DetailsSection)
			{
				return this.IsExpanded;
			}
			else if (el is SummarySection)
			{
				return this.IsExpanded;
			}
			return true;
		}
	}

}
