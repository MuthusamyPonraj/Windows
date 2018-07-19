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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using System.Runtime.InteropServices;

using Syncfusion.Windows.Forms;

namespace GridRepeaterControl
{
	#region interface ICellUserControl

	public interface ICellUserControl
	{
		//used to move data to the usercontrol from the datarow at position
		void UserControlSetValues(DataRowView drv);

		//used to move data from the usercontrol to the datarow
		void UserControlGetValues(DataRowView drv);

		//returns true when usercontrol values have changed
		bool UserControlIsModified();
	}

	#endregion

	#region Base CellUserControl class

	// the UserControl you want repeated
	// 1) must be derived from this CellUserControl class
	// 2) must implement its own ICellUserControl interface 
	public class CellUserControl : UserControl, ICellUserControl
	{
	
		#region Implementation of ICellUserControl
		public virtual void UserControlSetValues(DataRowView drv)
		{
		
		}
		public virtual void UserControlGetValues(DataRowView drv)
		{
		
		}
		public virtual bool UserControlIsModified()
		{
			return true;
		}

		#endregion

		protected override bool ProcessTabKey(bool forward)
		{
			//Console.WriteLine("ProcessTabKey " + this.ActiveControl.Text);
			return this.SelectNextControl(this.ActiveControl, forward, true, false, true);
		}

		public virtual void HandleKeyDown(System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				TextBoxBase tb = this.ActiveControl as TextBoxBase;
				if(tb != null)
				{
					if(tb.SelectionLength == 0 && tb.SelectionStart < tb.TextLength)
						tb.SelectionLength = 1;
					tb.SelectedText = "";
					e.Handled = true;
					return;
				}
			}
			else if(e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
			{
				TextBoxBase tb = this.ActiveControl as TextBoxBase;
				if(tb != null)
				{
					int increment = (e.KeyCode == Keys.Right) ? 
						( (tb.SelectionStart < tb.TextLength) ? 1 :0) :
						( (tb.SelectionStart > 0 ) ? -1 :0);
					tb.SelectionLength = 0;
					tb.SelectionStart += increment;

					e.Handled = true;
					return;
				}
			}
			
            base.OnKeyDown(e);
		}
	}

	#endregion

	#region CellModel class

	public class GenericPanelCellModel : GridGenericControlCellModel
	{        
		public GenericPanelCellModel(GridModel grid)
			: base(grid)
		{
		}

		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new GenericPanelCellRenderer(control, this);			
		}        		
	}

	#endregion

	#region CellRenderer class

	public class GenericPanelCellRenderer : GridGenericControlCellRenderer
	{
		private CellUserControl activeControl;
		private CellUserControl staticControl;

		public GenericPanelCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
		}  
      
		#region CellRenderer overrides

		//sets the style.COntrol which is drawn in the baseclass depending upon whether
		//the requested cell is active or not
		protected override void OnDraw(Graphics g, Rectangle clientRectangle, int rowIndex, int colIndex, GridStyleInfo style) 
		{	
			clientRectangle.Inflate(-1, -1);
			
			if (this.ShouldDrawFocused(rowIndex, colIndex))
			{
				style.Control = activeControl;
			}
			else
			{
				style.Control = staticControl;
				staticControl.UserControlSetValues(GetDataRowView(rowIndex));
			}
			base.OnDraw (g, clientRectangle, rowIndex, colIndex, style);
		} 

		//move the DateRowView into the activeControl
		protected override void OnInitialize(int rowIndex, int colIndex)
		{
			activeControl.UserControlSetValues(GetDataRowView(rowIndex));
			this.CurrentCell.IsModified = false;
			this.CurrentCell.BeginEdit();
		}

		//save changes to the DataRowView from the activeControl
		protected override bool OnSaveChanges()
		{
			activeControl.UserControlGetValues(GetDataRowView(this.RowIndex));
			this.CurrentCell.IsModified = false;
			return true;
		}

		#endregion

		#region InitCellPanels and GetDataRowView helper methods

		//method used to initialize things. Should be call immedaitely after adding the derived
		//cell model to the grid's CellModels collection.
		public void InitCellPanels(CellUserControl activeControl, CellUserControl staticControl)
		{
			this.activeControl = activeControl;	
			this.staticControl = staticControl;						

			this.Grid.Controls.Add(activeControl); 
			this.Grid.Controls.Add(staticControl);  

			activeControl.Visible = false;
			staticControl.Visible = false;
			
			this.Grid.QueryCanOleDragRange += new GridQueryCanOleDragRangeEventHandler(grid_QueryCanOleDragRange);
			this.Grid.DrawCurrentCellBorder += new GridDrawCurrentCellBorderEventHandler(grid_DrawCurrentCellBorder);

			this.Grid.CurrentCellDeactivating += new CancelEventHandler(grid_CurrentCellDeactivating);

		}

		void OffscreenDrawControl(Control c)
		{
		}
        
		//helper method that maps grid's row index to a DataRowView
		private DataRowView GetDataRowView(int rowIndex)
		{
			return ((DataView)this.Grid.Model.TableStyle.DataSource)[rowIndex-1];
		}
		#endregion
		
		#region Grid event handlers
		//used to indicate changes have been made, so OnSaveChanges will be called by the grid
		private void grid_CurrentCellDeactivating(object sender, CancelEventArgs e)
		{
			//Console.WriteLine("activeControl_Leave");
			if(activeControl.UserControlIsModified())
				this.CurrentCell.IsModified = true;

		}
		
		private void grid_DrawCurrentCellBorder(object sender, GridDrawCurrentCellBorderEventArgs e)
		{
			//if you want no currentcell border
			//e.Cancel = true;
		}

		//turn off grid's default D&D cursor at cell edge
		private void grid_QueryCanOleDragRange(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCanOleDragRangeEventArgs e)
		{
			e.Cancel = true;
		}
		#endregion

		private void GenericPanelCellRenderer_LocationChanged(object sender, EventArgs e)
		{

		}
	}
	#endregion
}
