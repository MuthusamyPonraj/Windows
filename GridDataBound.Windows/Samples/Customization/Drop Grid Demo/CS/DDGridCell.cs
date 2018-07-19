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

namespace GDBGwithDropGrids
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Drawing;
	using System.Windows.Forms;
	using System.Text;
	using System.Runtime.Serialization;

	using Syncfusion.Diagnostics;
	using Syncfusion.Drawing;

	using Syncfusion.Windows.Forms;
	using Syncfusion.Styles;
	using Syncfusion.Windows.Forms.Grid;
	using System.Data;

	public delegate void QueryFilterStringEventHandler(object sender, QueryFilterStringEventArgs e);
	public delegate void QueryFormatGridEventHandler(object sender, QueryFormatGridEventArgs e);


	public class QueryFilterStringEventArgs : EventArgs
	{
		private string _filter;
		private int _row;
		private int _col;

		public QueryFilterStringEventArgs(int row, int col)
		{
			_row = row;
			_col = col;
		}
		public int Row
		{
			get
			{
				return _row;
			}
			
		}

		public int Column
		{
			get
			{
				return _col;
			}
			
		}

		public string FilterString
		{
			get
			{
				return _filter;
			}
			set
			{
				_filter = value;
			}
		}
	}

	public class QueryFormatGridEventArgs : EventArgs
	{
		private GridControlBase _grid;
		private int _row;
		private int _col;

		public QueryFormatGridEventArgs(int row, int col, GridControlBase grid)
		{
			_row = row;
			_col = col;
			_grid = grid;
		}
		public int Row
		{
			get
			{
				return _row;
			}
			
		}

		public int Column
		{
			get
			{
				return _col;
			}
			
		}

		public GridControlBase Grid
		{
			get
			{
				return _grid;
			}
			set
			{
				_grid = value;
			}
		}
	}

	public class DBDropDownGridCellModel:GridDropDownGridCellModel
	{
		public event QueryFilterStringEventHandler QueryFilterString;
		public event QueryFormatGridEventHandler QueryFormatGrid;

		private GridDataBoundGrid _embbeddedGrid;
		private object _dataSource;

		public object DataSource
		{
			get
			{ 
				return _dataSource;
			}
			set
			{
				_dataSource = value;
			}
		}

		public GridDataBoundGrid EmbeddedGrid
		{
			get
			{ 
				if(_embbeddedGrid == null)
					_embbeddedGrid = new GridDataBoundGrid();
				return _embbeddedGrid;
			}
			set
			{
				_embbeddedGrid = value;
			}
		}

		public virtual void OnQueryFilterString(QueryFilterStringEventArgs e)
		{
			if(QueryFilterString != null)
			{
				QueryFilterString(this, e);
			}
		}

		public virtual void OnQueryFormatGrid(QueryFormatGridEventArgs e)
		{
			if(QueryFormatGrid != null)
			{
				QueryFormatGrid(this, e);
			}
		}

		protected DBDropDownGridCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public DBDropDownGridCellModel(GridModel grid)
			: base(grid)
		{
				
		}
	
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new DropDownGridCellRenderer(control, this);
		}
	}

	public class DropDownGridCellRenderer: GridDropDownGridCellRenderer 
	{
		GridDataBoundGrid dbgrid;
		
		public DropDownGridCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			this.DisableTextBox = true;
			DropDownButton = new GridCellComboBoxButton(this);
			this.dbgrid = null;
		}

		protected override void OnInitialize(int rowIndex, int colIndex)
		{
			DBDropDownGridCellModel cellModel = (DBDropDownGridCellModel)this.Model;
			this.dbgrid  = cellModel.EmbeddedGrid;
		
			//fire the event to retrieve the filter string...
			string filter = "";
			QueryFilterStringEventArgs e = new QueryFilterStringEventArgs(rowIndex, colIndex);
			cellModel.OnQueryFilterString(e);
			filter = e.FilterString;
			if (filter != "")
			{
				//get the view based on the filter & set it as the datasource
				DataTable dt1 = (DataTable)cellModel.DataSource;
				DataView dv = new DataView(dt1, filter, "", DataViewRowState.CurrentRows);
				dv.AllowNew = false;

				//dv.AllowEdit = false;
				dv.AllowDelete = false;

				//make sure dggrid has a binding context...
				if (this.dbgrid.BindingContext == null)
					this.dbgrid.BindingContext = this.Grid.BindingContext;

				this.dbgrid.DataSource = dv;
			}			
		}

		public override void OnPrepareViewStyleInfo(GridPrepareViewStyleInfoEventArgs e)
		{
			if (e.RowIndex == Grid.Model.RowCount && ((GridDataBoundGrid)Grid).EnableAddNew)
			{
				e.Style.ShowButtons = GridShowButtons.Hide;
				e.Style.Clickable = false;
			}

			base.OnPrepareViewStyleInfo(e);
		}

		protected override Control CreateInnerControl(out GridControlBase grid)
		{
			grid = this.dbgrid;
			grid.Dock = DockStyle.Fill;
	
			return grid;
		}

		public override void DropDownContainerShowingDropDown(object sender, CancelEventArgs e)
		{
			if (((GridDataBoundGrid) Grid).Binder.IsAddNew)
			{
				e.Cancel = true;
				return;
			}
			
			base.DropDownContainerShowingDropDown(sender, e);

			//fire the event that allows for the formatting of the dropped grid
			dbgrid.BeginInit();
			QueryFormatGridEventArgs e1 = new QueryFormatGridEventArgs(this.RowIndex, this.ColIndex, dbgrid);
			((DBDropDownGridCellModel)this.Model).OnQueryFormatGrid(e1);
			dbgrid.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0));
			
			dbgrid.EndInit();

			//set its height & width based on the parent grid
			int width = this.Grid.Size.Width - this.Grid.Model.ColWidths[0] - SystemInformation.VerticalScrollBarWidth;
			int height = Math.Max(60, this.dbgrid.Model.RowHeights.GetTotal(0, Math.Min(6,this.dbgrid.Model.RowCount)))  + SystemInformation.HorizontalScrollBarHeight;
			this.DropDownContainer.PopupHost.Size = new Size(width, height);
		}
	}
}
