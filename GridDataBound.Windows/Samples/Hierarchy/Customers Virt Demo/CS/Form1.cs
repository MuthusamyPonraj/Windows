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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
namespace CustomersSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl gridRecordNavigationControl1;
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
        private Syncfusion.Windows.Forms.ButtonAdv okButton;
        private Syncfusion.Windows.Forms.ButtonAdv _cancelButton;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
		private System.Windows.Forms.DataGrid dataGrid1;
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
			this.gridDataBoundGrid1.AllowDragSelectedCols = false;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            this.gridDataBoundGrid1.Model.Properties.BackgroundColor = SystemColors.Window;
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
            this._cancelButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridRecordNavigationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRecordNavigationControl1
            // 
            this.gridRecordNavigationControl1.AllowAddNew = false;
            this.gridRecordNavigationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRecordNavigationControl1.BackColor = System.Drawing.SystemColors.Control;
            this.gridRecordNavigationControl1.Controls.Add(this.gridDataBoundGrid1);
            this.gridRecordNavigationControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gridRecordNavigationControl1.Location = new System.Drawing.Point(24, 24);
            this.gridRecordNavigationControl1.MaxRecord = 0;
            this.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1";
            this.gridRecordNavigationControl1.ShowToolTips = true;
            this.gridRecordNavigationControl1.Size = new System.Drawing.Size(544, 176);
            this.gridRecordNavigationControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.gridRecordNavigationControl1.TabIndex = 0;
            this.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1";
            this.gridRecordNavigationControl1.ThemesEnabled = true;
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
            this.gridDataBoundGrid1.FillSplitterPane = true;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(523, 155);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ThemesEnabled = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(408, 398);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(72, 24);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyle = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this._cancelButton.CausesValidation = false;
            this._cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancelButton.Location = new System.Drawing.Point(496, 398);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(72, 24);
            this._cancelButton.TabIndex = 2;
            this._cancelButton.Text = "&Cancel";
            this._cancelButton.UseVisualStyle = true;
            this._cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Test";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(24, 232);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(544, 160);
            this.dataGrid1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 438);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(584, 438);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.gridRecordNavigationControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Virt Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gridRecordNavigationControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{			
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif		
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			CustomersList customers = new CustomersList();
			customers.LoadCustomers();
			GridModelDataBinder binder = this.gridDataBoundGrid1.Binder;
			binder.SetDataBinding(customers, "");

			GridHierarchyLevel childrenLevel = this.gridDataBoundGrid1.Binder.AddRelation("Children");
			childrenLevel.ShowHeaders = false;
			this.gridDataBoundGrid1.Binder.RootHierarchyLevel.ShowHeaders = true;
			this.dataGrid1.DataSource = customers;
			
			RecordObjectBinder rob = new RecordObjectBinder(this.gridDataBoundGrid1.Model as GridDataBoundGridModel);
			
			GridHierarchyLevel rootLevel = binder.RootHierarchyLevel;

			GridBoundColumnsCollection gbc = new GridBoundColumnsCollection(this.gridDataBoundGrid1.Binder);
			GridBoundColumn rgb1 = new GridBoundColumn();
			rgb1.MappingName = "ID";
			GridBoundColumn rgb2 = new GridBoundColumn();
			rgb2.MappingName = "FirstName";
			GridBoundColumn rgb3 = new GridBoundColumn();
			rgb3.MappingName = "LastName";
			GridBoundColumn rgb4 = new GridBoundColumn();
			rgb4.MappingName = "Unbound1";
			GridBoundColumn rgb5 = new GridBoundColumn();
			rgb5.MappingName = "Unbound2";
			gbc.AddRange(new GridBoundColumn[] { rgb1, rgb2, rgb3, rgb4, rgb5 } );
	
			rootLevel.GridBoundColumns = gbc;
			childrenLevel.GridBoundColumns = (GridBoundColumnsCollection) gbc.Clone();
            childrenLevel.RowStyle.BackColor = SystemColors.Window;
            rootLevel.RowStyle.BackColor = SystemColors.Window;
           	this.gridDataBoundGrid1.DefaultRowHeight = 18;
			this.gridDataBoundGrid1.DefaultColWidth = 70;			
			this.gridDataBoundGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver;
			this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;

			// We could also call rootLevel.LayoutCoumns and childrenLevel.LayoutColumns
			// here and specify covered cells, row breaks, column order etc.
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


		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
            this.gridDataBoundGrid1.CollapseAll();
            this.dataGrid1.Collapse(-1);
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.gridDataBoundGrid1.ExpandAll();
            this.dataGrid1.Expand(-1);
        }

	}
}
