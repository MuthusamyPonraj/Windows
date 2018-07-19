using System;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
using Syncfusion.Windows.Forms.Grid;
using System.Windows.Forms;
using System.Data;


namespace GridMultiColSortHelper
{
	/// <summary>
	/// Helper class to faciliate multicolumn sorting 
	/// in a GridDataBoundGrid bound to a DataTable.
	/// </summary>
	public class GridMultiColSortHelper
	{
		/// <summary>
		/// the constructor
		/// </summary>
		public GridMultiColSortHelper()
		{
			
		}

		//tracks the columns that are currently sorted by position in sort.
		private ArrayList sortedCols = new ArrayList();

		//tracks the columns currently sorted by column name
		private SortedList sortDirections = new SortedList();

		//indicates whether the helper class should autosize teh columns
		private bool handleAutoSize = false;

		//a reference to the GridDataBoundGrid
		private GridDataBoundGrid grid = null;

        private string defaultSortColumn = string.Empty;
        public string DefaultSortColumn
        {
            get { return defaultSortColumn; } 
            set 
            {
                if(defaultSortColumn != value)
                { 
                   DataView dv =  GetDataView();
                   if (dv.Table.Columns.Contains(value))
                       defaultSortColumn = value;
                   else
                       MessageBox.Show(@"Column """+ value + @""" is not in this view");
                }
            }
        }

		/// <summary>
		/// Sets teh helper class to manage sorting in the grid
		/// </summary>
		/// <param name="grid">the GridDataBoundGrid</param>
		/// <param name="handleAutoSize">whether or not you want the helper class to resize the columns widths</param>
		public void WireGrid(GridDataBoundGrid grid, bool handleAutoSize)
		{
			if(this.grid != null && !this.grid.Equals(grid))
				UnwireGrid();
			 
			if(this.grid != null && this.grid.Equals(grid))
				return;

			this.grid = grid;
			this.grid.CellClick += new GridCellClickEventHandler(grid_CellClick);
			this.grid.CellDoubleClick += new GridCellClickEventHandler(grid_CellDoubleClick);
			this.grid.DrawCellDisplayText += new GridDrawCellDisplayTextEventHandler(grid_DrawCellDisplayText);
			this.grid.BaseStylesMap["Column Header"].StyleInfo.CellType = "Header";
		 
			//test out the datasource
			DataView dv = GetDataView();

			if(handleAutoSize)
			{
				//size columns so triangle will fit ok
				this.grid.AllowResizeToFit = false;
				this.grid.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0));
				for(int i = 1; i <= this.grid.Model.ColCount; ++i)
					this.grid.Model.ColWidths[i] = this.grid.Model.ColWidths[i] + 12;
			}
			this.handleAutoSize = handleAutoSize;
		}

		/// <summary>
		/// unhooks the helper object from the GridDataBoundGrid
		/// </summary>
		public void UnwireGrid()
		{
			if(this.grid == null)
				return;

			this.grid.CellClick -= new GridCellClickEventHandler(grid_CellClick);
			this.grid.CellDoubleClick -= new GridCellClickEventHandler(grid_CellDoubleClick);
			this.grid.DrawCellDisplayText -= new GridDrawCellDisplayTextEventHandler(grid_DrawCellDisplayText);
			this.grid.BaseStylesMap["Column Header"].StyleInfo.CellType = "SortColumnHeader";

			this.grid = null;
		}

		//gets at the DataView
		private DataView GetDataView()
		{
			CurrencyManager cm = this.grid.BindingContext[this.grid.DataSource, this.grid.DataMember] as CurrencyManager;
			if(cm != null)
			{
				DataView dv = cm.List as DataView;
				if(dv != null)
					return dv;
			}

			throw new ArgumentException("DataSource must be a DataTable or DataView");
		}

		//draws the cell text with sort icon if needed
		private void grid_DrawCellDisplayText(object sender, GridDrawCellDisplayTextEventArgs e)
		{
			if(e.Style.CellIdentity.ColIndex > 0 && e.Style.CellIdentity.RowIndex == 0 && this.sortDirections.Count > 0)
			{
				int field = this.grid.Binder.ColIndexToField(e.Style.CellIdentity.ColIndex);
				GridBoundColumnsCollection gbcc = (this.grid.GridBoundColumns == null || this.grid.GridBoundColumns.Count == 0)
					? this.grid.Binder.InternalColumns : this.grid.GridBoundColumns;
				string colName = gbcc[field].MappingName;
				if(this.sortDirections[colName] != null)
				{
					ListSortDirection listSortDirection = (ListSortDirection)this.sortDirections[colName];
					int margin = 12;
					Rectangle textRectangle = e.TextRectangle;
					textRectangle.Width -= margin;
 
					GridStaticCellRenderer.DrawText(e.Graphics, e.DisplayText, e.Style.GdipFont, textRectangle, e.Style, e.Style.TextColor, false);

					 
						Rectangle rect = new Rectangle(textRectangle.Right, textRectangle.Y, 10, textRectangle.Height);
						rect = GridUtil.CenterInRect(rect, new Size(8, 8));

						Brush brush = new SolidBrush(SystemColors.ControlDark);

						//g.FillRectangle(brush, rect);
						int i2 = Math.Max(0, (rect.Height - 3) / 2);
						rect.Inflate(-i2, -i2);
						Pen pen1 = new Pen(SystemColors.WindowFrame);
						Pen pen2 = new Pen(SystemColors.Control);
						GridTriangleDirection triangleDirection = listSortDirection == ListSortDirection.Ascending ? GridTriangleDirection.Up : GridTriangleDirection.Down;
						GridPaintTriangle.Paint(e.Graphics, rect, triangleDirection, brush, pen1, true);
						pen1.Dispose();
						pen2.Dispose();
					
					e.Cancel = true;
				}
			}
		}

		//handles the click sorting
		private void grid_CellClick(object sender, GridCellClickEventArgs e)
		{
			if(this.grid.SortBehavior != GridSortBehavior.SingleClick)
				return;
			if(e.RowIndex == 0)
			{
				HandleSortCol(e.ColIndex);
				e.Cancel = true;
			}
		}

		//handles the double click sorting
		private void grid_CellDoubleClick(object sender, GridCellClickEventArgs e)
		{
			if(this.grid.SortBehavior != GridSortBehavior.DoubleClick)
				return;
			if(e.RowIndex == 0)
			{
				HandleSortCol(e.ColIndex);
				e.Cancel = true;
			}
		}

		//sets up the sort information in sortDirections and sortedCols.
		private void HandleSortCol(int colIndex)
		{
			int field = this.grid.Binder.ColIndexToField(colIndex);
			if(field > -1)
			{
				GridBoundColumnsCollection gbcc = (this.grid.GridBoundColumns == null || this.grid.GridBoundColumns.Count == 0)
					? this.grid.Binder.InternalColumns : this.grid.GridBoundColumns;
				string colName = gbcc[field].MappingName;
				ListSortDirection dir = ListSortDirection.Ascending;

				if(this.sortDirections[colName] != null)
				{
					dir = ((ListSortDirection)this.sortDirections[colName] == ListSortDirection.Ascending)
						? ListSortDirection.Descending : ListSortDirection.Ascending;
				}

				if((Control.ModifierKeys & Keys.Control) == 0)
				{
					this.sortedCols.Clear();
					this.sortDirections.Clear();
				}

				if(this.sortDirections[colName] != null)
				{
					this.sortDirections[colName] = dir;
				}
				else
				{
                    if (this.DefaultSortColumn != "" && !this.sortedCols.Contains(this.DefaultSortColumn))
                    {
                        this.sortedCols.Add(this.DefaultSortColumn);
                        this.sortDirections.Add(this.DefaultSortColumn, ListSortDirection.Ascending);
                    }
					this.sortedCols.Add(colName);
					this.sortDirections.Add(colName, dir);
				}

				SortColumns();
			}
		}

		/// <summary>
		/// Lets you programaticcally sort multiple columns
		/// </summary>
		/// <param name="colName">name of column to be sorted</param>
		/// <param name="dir">the direction of the sort</param>
		/// <param name="clearSortedColumns">whether previous sorts should be cleared</param>
		/// <param name="initiateSort">whether the sort should be done.</param>
		public void SortColumn(string colName, ListSortDirection dir, bool clearSortedColumns, bool initiateSort)
		{
			if(clearSortedColumns)
			{
				this.sortedCols.Clear();
				this.sortDirections.Clear();
			}

			if(this.sortDirections[colName] != null)
			{
				this.sortDirections[colName] = dir;
			}
			else
			{
                if (this.DefaultSortColumn != "" && !this.sortedCols.Contains(this.DefaultSortColumn))
                {
                    this.sortedCols.Add(this.DefaultSortColumn);
                    this.sortDirections.Add(this.DefaultSortColumn, ListSortDirection.Ascending);
                }
				this.sortedCols.Add(colName);
				this.sortDirections.Add(colName, dir);
			}

			if(initiateSort)
				SortColumns();
		}

		//sorts the columns as specified in sortedCols and sortDirections through the DataView
		private void SortColumns()
		{
			string sort = "";
			for(int i = 0; i < this.sortedCols.Count; ++i)
			{
				string colName = this.sortedCols[i].ToString();
				string dir = (this.sortDirections[colName].Equals(ListSortDirection.Ascending))
					? "Asc" : "Desc";
				if(i > 0)
					sort += ',';
				sort += string.Format("[{0}] {1}", colName, dir);
				int colIndex = this.grid.Binder.NameToColIndex(colName);

				this.grid[0, colIndex].Tag = this.sortDirections[colName];
			}
			//Console.WriteLine(sort);

			DataView dv = GetDataView();
			dv.Sort = sort;
		
		}
	}

	
}
