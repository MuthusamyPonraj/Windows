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

namespace GDBGwithDropGrids
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	using Syncfusion.Windows.Forms.Grid;
	/// <summary>
	/// Summary description for GridHierDataBoundGrid.
	/// </summary>
	public class GridHierarchicalDataBoundGrid : GridDataBoundGrid
	{
		public GridHierarchicalDataBoundGrid(Form f, DataTable parentTable, DataTable childTable, GridDataBoundGrid childGrid, QueryFilterStringEventHandler queryFilterHandler, QueryFormatGridEventHandler queryFormatHandler, bool hasChildGrid): base()
		{
			if(hasChildGrid)
			{
				//add special cell control (dropdowngrid)
				DBDropDownGridCellModel cellModel = new DBDropDownGridCellModel(this.Model);
				//DDGridCellModel cellModel = new DDGridCellModel(this.Model);
				cellModel.EmbeddedGrid = childGrid; //make the orderGrid the dropgrid
				cellModel.DataSource = childTable;

				cellModel.QueryFilterString += queryFilterHandler;
				cellModel.QueryFormatGrid += queryFormatHandler;

				this.Model.CellModels.Add("DBDropDownGridCell", cellModel);

			}

			this.DataSource = parentTable;
			//set up GridBoundColumns for the parentTable
			CurrencyManager cm = (CurrencyManager)f.BindingContext[parentTable];
			PropertyDescriptorCollection pdc = cm.GetItemProperties();

			GridBoundColumn gbc;
			
			this.GridBoundColumns.Clear();

			if(hasChildGrid)
			{
				//add special unbound column at beginning
				gbc = new GridBoundColumn();
				gbc.MappingName = "";
				gbc.HeaderText = "    ";
				gbc.StyleInfo.CellType = "DBDropDownGridCell";
				gbc.StyleInfo.CellValue = "";
				this.GridBoundColumns.Add(gbc);
				
			}

			//add the reset
				foreach(DataColumn dc in parentTable.Columns)
			{
				PropertyDescriptor pd = pdc[dc.ColumnName];
				gbc = new GridBoundColumn(pd);
				gbc.MappingName = dc.ColumnName;
				gbc.HeaderText = dc.ColumnName;

				
				this.GridBoundColumns.Add(gbc);

				
				//avoid 1st select problem
				////this.CurrentCell.Deactivate(true);
				//this.customerGrid.Model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.SetCurrent;
				////this.CurrentCell.Activate(1, 2, GridSetCurrentCellOptions.SetFocus);
			}
			
			//this.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0));
				

			if(hasChildGrid)
			{
				
				
				this.Model.ColWidths[1] = 18;
				this.Model.Cols.FrozenCount = 1;

				//this is here to hide an extra column at the end ????
				//remove when the problem is corrected...
				this.Model.Cols.Hidden[this.Model.ColCount] = true;
			}

			//set the width of th erow headers
			this.Model.ColWidths[0] = 18;
			this.ThemesEnabled = true;
		}
	}
}
