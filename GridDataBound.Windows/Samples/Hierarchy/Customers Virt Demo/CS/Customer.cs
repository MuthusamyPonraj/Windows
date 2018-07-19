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
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using Syncfusion.ComponentModel;
using Syncfusion.Diagnostics;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

// TODO: In this sample when you add a new customer and then
// cancel the editing of the new customer an empty customer
// will remain in the list. Correct behavior would be to remove
// the empty customer when AddNew operation is canceled.

namespace CustomersSample
{
	public interface IRecordObject
	{
		/// <summary>
		/// Method handler for the <see cref="GridModel.QueryCellInfo"/> event.
		/// </summary>
		/// <param name=" e">An <see cref="GridQueryCellInfoEventArgs"/> that contains the event data.</param>
		void QueryCellInfo(QueryColumnStyleEventArgs e); 
		
		/// <summary>
		/// Method handler for the <see cref="GridModel.SaveCellInfo"/> event.
		/// </summary>
		/// <param name=" e">An <see cref="GridSaveCellInfoEventArgs"/> that contains the event data.</param>
		//void SaveCellInfo(GridSaveCellInfoEventArgs e);
	}

	public sealed class QueryColumnStyleEventArgs : SyncfusionHandledEventArgs 
	{
		GridQueryCellInfoEventArgs gridInfo;
		GridBoundRecordState state;
		GridHierarchyLevel level;
		GridBoundColumn columnStyle;
		string mappingName;
	
		internal QueryColumnStyleEventArgs(GridQueryCellInfoEventArgs gridInfo, GridBoundRecordState state, GridHierarchyLevel level, GridBoundColumn columnStyle, string mappingName) 
		{
			this.gridInfo = gridInfo;
			this.state = state;
			this.level = level;
			this.columnStyle = columnStyle;
			this.mappingName = mappingName;
		}
	
		[TraceProperty(true)]
		public GridQueryCellInfoEventArgs GridInfo
		{
			get
			{
				return gridInfo;
			}
		}
	
		[TraceProperty(true)]
		public GridBoundRecordState State
		{
			get
			{
				return state;
			}
		}
	
		[TraceProperty(true)]
		public GridHierarchyLevel Level
		{
			get
			{
				return level;
			}
		}
	
		[TraceProperty(true)]
		public GridBoundColumn ColumnStyle
		{
			get
			{
				return columnStyle;
			}
		}
	
		[TraceProperty(true)]
		public string MappingName
		{
			get
			{
				return mappingName;
			}
		}
	}
	

	public class RecordObjectBinder
	{
		public RecordObjectBinder(GridDataBoundGridModel model)
		{
			WireGridModel(model);
		}

		void WireGridModel(GridModel model)
		{
			model.QueryCellInfo += new GridQueryCellInfoEventHandler(GridModelQueryCellInfo);
			model.SaveCellInfo += new GridSaveCellInfoEventHandler(GridModelSaveCellInfo);
		}

		void GridModelQueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
		{
			IGridModelSource ms = sender as IGridModelSource;
			GridDataBoundGridModel gridModel = ms.Model as GridDataBoundGridModel;
			GridModelDataBinder gridBinder = gridModel.DataProvider as GridModelDataBinder;

			int fieldNum = gridBinder.ColIndexToField(e.ColIndex);
			int position = gridBinder.RowIndexToPosition(e.RowIndex);
			if (position < 0 || fieldNum < 0)
			{
				// row or column header
				return;
			}

			// Get record state information as position, listManager, childCount etc.
			GridBoundRecordState state = gridBinder.GetRecordStateAtRowIndex(e.RowIndex);

			// Get level information with bound columns, layout, row/col to field mapping
			GridHierarchyLevel level = gridBinder.GetHierarchyLevel(state.LevelIndex);

			// Adjust for wrapped rows when a record has several rows
			int fieldInCollection = level.RowFieldToField(state.RowIndexInRecord, fieldNum);

			// Get the columns collection for the hierarchy level
			GridBoundColumnsCollection columns = level.InternalColumns;

			if (fieldInCollection >= 0 && fieldInCollection < columns.Count)
			{
				// Get the column style for this field
				GridBoundColumn columnStyle = columns[fieldInCollection];
				if (columnStyle != null)
				{
					// Check if this is an unbound column (where mapping name did not match any Property in associated class)
					PropertyDescriptor pd = columnStyle.PropertyDescriptor;
					if (pd == null)
					{
						if (state.Position < state.Table.Count)
						{
							// Get the record object from the table for this record
							object rowObject = state.Table[state.Position];

							// Check for the IRecordObject interface
							IRecordObject recordObject = rowObject as IRecordObject;
							if (recordObject != null)
							{
								// Get style info from IRecordObject
								string mappingName = columnStyle.MappingName;
								QueryColumnStyleEventArgs cse = new QueryColumnStyleEventArgs(e, state, level, columnStyle, mappingName);
								recordObject.QueryCellInfo(cse);
								
								// Assign e.Handled = true if information was provided by QueryCellInfo call
								e.Handled = cse.Handled;

								TraceUtil.TraceCurrentMethodInfo(cse);
							}
						}
					}
				}
			}					
		}
		
		void GridModelSaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
		{
			// similar code here for saving style info
		}

	}


	public class Customer : IRecordObject 
	{
       
		struct CustomerData 
		{
			internal string id ;
			internal string firstName ;
			internal string lastName ;
		}
        
		private CustomersList _parent;
		private CustomersList _children = new CustomersList();
		private CustomerData custData; 
		private bool inTxn = false;

		public void QueryCellInfo(QueryColumnStyleEventArgs e)
		{
			GridQueryCellInfoEventArgs ce = e.GridInfo;
			if (e.MappingName == "Unbound1")
			{
				ce.Style.CellValue = string.Format("{0}: {1} {2}", this.ID, FirstName, LastName);
				if (e.Level.LevelIndex == 0)
					ce.Style.BackColor = Color.FromArgb( 0xff, 0xbf, 0x34 );
				else
					ce.Style.BackColor = Color.FromArgb( 192, 201, 219 );
			}
			else if (e.MappingName == "Unbound2")
			{
				ce.Style.CellValue = e.State.Position.ToString();
			}
		}

		public Customer(string ID) : base() 
		{
			this.custData = new CustomerData();
			this.custData.id = ID;
			this.custData.firstName = "";
			this.custData.lastName = "";
		}

		public string ID 
		{
			get 
			{
				return this.custData.id;
			}
			set
			{
				this.custData.id = value;
			}
		}
        
		public string FirstName 
		{
			get 
			{
				return this.custData.firstName;
			}
			set 
			{
				this.custData.firstName = value;
			}
		}
             
		public string LastName 
		{
			get 
			{
				return this.custData.lastName;
			}
			set 
			{
				this.custData.lastName = value;
			}
		}
       
		public CustomersList Children 
		{
			get 
			{
				return _children;
			}
			set 
			{
				_children = value ;
			}
		}

		internal CustomersList Parent 
		{
			get 
			{
				return _parent;
			}
			set 
			{
				_parent = value ;
			}
		}

		private void OnCustomerChanged() 
		{
			if (!inTxn && Parent != null) 
			{
				Parent.CustomerChanged(this);
			}
		}
	}

	public class CustomersList :  CollectionBase
	{
    
		private ListChangedEventArgs resetEvent = new ListChangedEventArgs(ListChangedType.Reset, -1);

		public void LoadCustomers() 
		{
			IList l = (IList)this;
			Customer cust1 = ReadCustomer1();
			cust1.Children.Add(ReadCustomer3());
			cust1.Children.Add(ReadCustomer4());
			l.Add(cust1);
			Customer cust2 = ReadCustomer2();
			cust2.Children.Add(ReadCustomer5());
			cust2.Children.Add(ReadCustomer6());
			l.Add(cust2);
			OnListChanged(resetEvent);
		}

		public Customer this[int index] 
		{
			get 
			{
				return (Customer)(List[index]);
			}
			set 
			{
				List[index] = value;
			}
		}

		public int Add (Customer value) 
		{
			return List.Add(value);
		}

		public Customer AddNew() 
		{
			return (Customer)((IBindingList)this).AddNew();
		}


		public void Remove (Customer value) 
		{
			List.Remove(value);
		}

        
		protected virtual void OnListChanged(ListChangedEventArgs ev) 
		{
			if (ListChanged != null) 
			{
				ListChanged(this, ev);
			}
		}
        

		protected override void OnClear() 
		{
			foreach (Customer c in List) 
			{
				c.Parent = null;
			}
		}

		protected override void OnClearComplete() 
		{
			OnListChanged(resetEvent);
		}

		protected override void OnInsertComplete(int index, object value) 
		{
			Customer c = (Customer)value;
			c.Parent = this;
			OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
		}

		protected override void OnRemoveComplete(int index, object value) 
		{
			Customer c = (Customer)value;
			c.Parent = this;
			OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
		}

		protected override void OnSetComplete(int index, object oldValue, object newValue) 
		{
			if (oldValue != newValue) 
			{

				Customer oldcust = (Customer)oldValue;
				Customer newcust = (Customer)newValue;
                
				oldcust.Parent = null;
				newcust.Parent = this;
                
            
				OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
			}
		}
        
		// Called by Customer when it changes.
		internal void CustomerChanged(Customer cust) 
		{
         
			int index = List.IndexOf(cust);
            
			OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
		}
        

		// Events.
		public event ListChangedEventHandler ListChanged ;


		// Worker functions to populate the list with data.
		private static Customer ReadCustomer1() 
		{
			Customer cust = new Customer("536-45-1245");
			cust.FirstName = "Jo";
			cust.LastName = "Brown";
			return cust;
		}
        
		private static Customer ReadCustomer2() 
		{
			Customer cust = new Customer("246-12-5645");
			cust.FirstName = "Robert";
			cust.LastName = "Brown";
			return cust;
		}

		private static Customer ReadCustomer3() 
		{
			Customer cust = new Customer("537-45-1245");
			cust.FirstName = "Keith";
			cust.LastName = "Brown";
			return cust;
		}
        
		private static Customer ReadCustomer4() 
		{
			Customer cust = new Customer("247-12-5645");
			cust.FirstName = "Sven";
			cust.LastName = "Brown";
			return cust;
		}
	
		private static Customer ReadCustomer5() 
		{
			Customer cust = new Customer("538-45-1245");
			cust.FirstName = "Katie";
			cust.LastName = "Brown";
			return cust;
		}
        
		private static Customer ReadCustomer6() 
		{
			Customer cust = new Customer("248-12-5645");
			cust.FirstName = "Steve";
			cust.LastName = "Brown";
			return cust;
		}
	}


}
