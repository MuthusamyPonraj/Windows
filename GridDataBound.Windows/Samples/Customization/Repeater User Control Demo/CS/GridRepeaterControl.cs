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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;


namespace GridRepeaterControl
{
	/// <summary>
	/// Summary description for GridRepeaterUserControl.
	/// </summary>
	public class GridRepeaterUserControl : System.Windows.Forms.UserControl
	{
		public Syncfusion.Windows.Forms.Grid.GridControl Grid;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridRepeaterUserControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Grid = new Syncfusion.Windows.Forms.Grid.GridControl();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
			this.SuspendLayout();
			// 
			// Grid
			// 
			this.Grid.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
			this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Grid.Location = new System.Drawing.Point(2, 2);
			this.Grid.Name = "Grid";
			this.Grid.Properties.BackgroundColorString = "Control";
			this.Grid.Properties.FixedLinesColorString = "ActiveCaption";
			this.Grid.Properties.GridLineColor = System.Drawing.Color.Silver;
			this.Grid.Properties.GridLineColorString = "Silver";
			this.Grid.Properties.ResizingCellsLinesColorString = "Red";
			this.Grid.Size = new System.Drawing.Size(260, 292);
			this.Grid.SmartSizeBox = false;
			this.Grid.TabIndex = 0;
			this.Grid.Text = "Grid";
			this.Grid.VerticalThumbTrack = true;
			// 
			// GridRepeaterUserControl
			// 
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Grid});
			this.DockPadding.All = 2;
			this.Name = "GridRepeaterUserControl";
			this.Size = new System.Drawing.Size(264, 296);
			this.Load += new System.EventHandler(this.GridRepeaterUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void GridRepeaterUserControl_Load(object sender, System.EventArgs e)
		{
			this.Grid.ColCount = 0;
			this.Grid.Cols.Hidden[0] = true;
			this.Grid.Rows.Hidden[0] = true;
		}
			
		private CellUserControl activeControl;
		public void AddUserControls(CellUserControl activeControl, CellUserControl staticControl, int visibleControls)
		{
			if(visibleControls < 1)
				throw new ArgumentOutOfRangeException("visibleControls", "must be more than 0");

			//turn off double buffering
			MakeUnBuffered(staticControl);
			staticControl.CausesValidation = false;

			staticControl.Location = new Point(-1000, -1000);
			activeControl.Location = new Point(-1000, -1000);

			this.Grid.BeginUpdate();

			this.Grid.ColCount = 1;
			this.Grid.RowCount = 0;
			//this.Grid.VScrollPixel = true;
			this.Grid.HScrollPixel = true;

			this.Grid.Model.CellModels.Add("RepeaterCell", new GenericPanelCellModel(this.Grid.Model));
			this.Grid.ColStyles[1].CellType = "RepeaterCell";
			GenericPanelCellRenderer cr = this.Grid.CellRenderers["RepeaterCell"] as GenericPanelCellRenderer;
			cr.InitCellPanels(activeControl, staticControl);
			this.activeControl = activeControl;

			this.Grid.DefaultRowHeight = activeControl.Height;
			this.Grid.DefaultColWidth = activeControl.Width;

			int width = this.DockPadding.Left + this.DockPadding.Right + activeControl.Width + SystemInformation.VerticalScrollBarWidth;
			int height = this.DockPadding.Top + this.DockPadding.Bottom + visibleControls * activeControl.Height;
			this.Size = new Size(width, height);

		
			this.Grid.WantTabKey = false;
			this.Grid.EndUpdate();
			this.Grid.Refresh();
		}

		private void MakeUnBuffered(Control c)
		{
			System.Reflection.MethodInfo mInfo = typeof(Control).GetMethod("SetStyle", 
				System.Reflection.BindingFlags.Instance | 
				System.Reflection.BindingFlags.InvokeMethod | 
				System.Reflection.BindingFlags.NonPublic);
			if(mInfo != null)
			{
				mInfo.Invoke(c, new object[]{ControlStyles.DoubleBuffer, false});
			}
			if(c.Controls.Count > 0)
			{
				foreach (Control c1 in c.Controls)
				{
					c1.CausesValidation = false;
					MakeUnBuffered(c1);//recursive call
				}
			}
		}

		#region DataBinding

		private DataView dv;
		private object dataSource;
		private string dataMember;
		
		public void SetDataBinding(object dataSource)
		{
			SetDataBinding(dataSource, "");
		}

		private bool queryColCountHooked = false;
		public void SetDataBinding(object dataSource, string dataMember)
		{
			if(this.dv != null)
			{
				((IBindingList)this.dv).ListChanged -= new ListChangedEventHandler(ibl_ListChanged);
			}


			this.dataMember = dataMember;
			this.dataSource = dataSource;
			this.dv = null;

			if(dataSource == null)
			{
				this.dataMember = "";
			}
			else if(dataSource is DataSet)
			{
				this.dv = ((DataSet)dataSource).Tables[dataMember].DefaultView;
			}
			else if(dataSource is DataTable && dataMember.Length == 0)
			{
				this.dv = ((DataTable)dataSource).DefaultView;
			}
			else if(dataSource is DataView && dataMember.Length == 0)
			{
				this.dv = ((DataTable)dataSource).DefaultView;
			}
			else
				throw new ArgumentException("dataSource and dataMember must define a DataView");

			this.Grid.TableStyle.DataSource = this.dv;
			if(this.dv != null)
				((IBindingList)this.dv).ListChanged += new ListChangedEventHandler(ibl_ListChanged);

			if(!queryColCountHooked)
			{
				this.Grid.QueryRowCount += new GridRowColCountEventHandler(grid_QueryRowCount);
				this.Grid.KeyDown += new KeyEventHandler(grid_KeyDown);
				queryColCountHooked = true;
			}
			this.Grid.HScrollBehavior = GridScrollbarMode.Disabled;
			this.Grid.Refresh();

				this.Grid.ResetVolatileData();
			this.Grid.UpdateScrollBars();
		}

		private void ibl_ListChanged(object sender, ListChangedEventArgs e)
		{
			switch(e.ListChangedType)
			{
				case ListChangedType.ItemAdded:
				case ListChangedType.ItemDeleted:
				case ListChangedType.ItemMoved:
				case ListChangedType.Reset:
					this.Grid.RefreshRange(this.Grid.ViewLayout.VisibleCellsRange, true);
					break;
				case ListChangedType.ItemChanged:
					this.Grid.RefreshRange(GridRangeInfo.Cell(e.NewIndex+1,1), true);
					break;
				default:
					break;

			}
		}

		private void grid_QueryRowCount(object sender, GridRowColCountEventArgs e)
		{
			e.Count = this.dv.Count;
			e.Handled = true;
		}

		private void grid_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
			{
				e.Handled = true;
				this.activeControl.HandleKeyDown(e);
			}
		}

		#endregion
	}
}
