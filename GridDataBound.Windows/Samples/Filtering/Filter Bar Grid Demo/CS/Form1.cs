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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace FilterBarGrid
{
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
		private Syncfusion.Windows.Forms.ButtonAdv button1;
        private Syncfusion.Windows.Forms.ButtonAdv button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;

		private GridFilterBar theFilterBar;
		private DataSet ds;
		private string currentTableName;
        private Syncfusion.Windows.Forms.ButtonAdv button3;
        private Syncfusion.Windows.Forms.ButtonAdv enableDialogButton;
        private Syncfusion.Windows.Forms.ButtonAdv NoneCustomButton;
		private System.Windows.Forms.Panel panel1;

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
			this.gridDataBoundGrid1.ResizeColsBehavior = GridResizeCellsBehavior.None;
			this.gridDataBoundGrid1.ResizeRowsBehavior=GridResizeCellsBehavior.None;
			this.gridDataBoundGrid1.AllowSelection=GridSelectionFlags.Cell;

            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridDataBoundGrid1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
		
		private void InitializeComponent()
		{
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.enableDialogButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.NoneCustomButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid1.HorizontalThumbTrack = true;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(45, 54);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(555, 313);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.VerticalThumbTrack = true;
            this.gridDataBoundGrid1.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(this.gridDataBoundGrid1_PrepareViewStyleInfo);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(624, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Filter Bar";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(623, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove Filter Bar";
            this.button2.UseVisualStyle = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Row Filter:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(192, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "(none)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Customers",
            "Employees",
            "Orders",
            "Products"});
            this.comboBox1.Location = new System.Drawing.Point(46, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Customers";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(624, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Reset Grid";
            this.button3.UseVisualStyle = true;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // enableDialogButton
            // 
            this.enableDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enableDialogButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.enableDialogButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.enableDialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableDialogButton.Location = new System.Drawing.Point(624, 172);
            this.enableDialogButton.Name = "enableDialogButton";
            this.enableDialogButton.Size = new System.Drawing.Size(112, 36);
            this.enableDialogButton.TabIndex = 7;
            this.enableDialogButton.Text = "     Enable        Custom Dialog";
            this.enableDialogButton.UseVisualStyle = true;
            this.enableDialogButton.UseVisualStyleBackColor = true;
            this.enableDialogButton.Click += new System.EventHandler(this.enableDialogButton_Click);
            // 
            // NoneCustomButton
            // 
            this.NoneCustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoneCustomButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.NoneCustomButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.NoneCustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoneCustomButton.Location = new System.Drawing.Point(623, 213);
            this.NoneCustomButton.Name = "NoneCustomButton";
            this.NoneCustomButton.Size = new System.Drawing.Size(112, 37);
            this.NoneCustomButton.TabIndex = 8;
            this.NoneCustomButton.Text = "      German         [none]  [custom]";
            this.NoneCustomButton.UseVisualStyle = true;
            this.NoneCustomButton.UseVisualStyleBackColor = true;
            this.NoneCustomButton.Click += new System.EventHandler(this.NoneCustomButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NoneCustomButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 414);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(752, 414);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Controls.Add(this.enableDialogButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter Bar Grid Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());			
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
		}

		#region Initial Setup
		
		void ReadXml(DataSet ds, string xmlFileName)
		{
			for (int n = 0; n < 10; n++)
			{
				if (System.IO.File.Exists(xmlFileName))
				{
					ds.ReadXml(xmlFileName);
					break;
				}
				xmlFileName = @"..\" + xmlFileName;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.gridDataBoundGrid1.DefaultRowHeight = 18;
			this.gridDataBoundGrid1.DefaultColWidth = 70;			
			
			ds = new DataSet();
			ReadXml(ds, @"Common\Data\GDBDdata.XML");

			SetTableIntoGridAndWireFilterBar("customers");			
			this.gridDataBoundGrid1.CellDoubleClick+=new GridCellClickEventHandler(gridDataBoundGrid1_CellDoubleClick);
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


		private void SetTableIntoGridAndWireFilterBar(string tableName)
		{
			this.Cursor = Cursors.WaitCursor;

			this.gridDataBoundGrid1.GridBoundColumns.Clear();
			this.gridDataBoundGrid1.Selections.Clear();

			this.gridDataBoundGrid1.BeginUpdate();

			if(this.theFilterBar != null && theFilterBar.Wired)
			{
				//reset the old table
				theFilterBar.RowFilter = "";

				theFilterBar.UnwireGrid();
			}

			currentTableName = tableName;

			this.gridDataBoundGrid1.DataSource = ds.Tables[tableName];
	
			this.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0), GridResizeToFitOptions.NoShrinkSize);

			//create the filter bar and display it
			theFilterBar = new GridFilterBar();

			//catch the creating column header event so we can turn off unwanted filter headers
			//needs to be hooked before WireGrid call to catch things...
			theFilterBar.CreatingColumnHeader += new GridFilterBarCreatingColumnHeaderEventHandler(GridFilterBarCreatingColumnHeader);

			theFilterBar.WireGrid(this.gridDataBoundGrid1);

			//catch the rowfilter changed event so we can display the filter text
			theFilterBar.FilterBarTextChanged += new GridFilterBarTextChangedEventHandler(GridFilterBarTextChanged);
            
			//apply any special formatting...
			FormatGridForTable(tableName);


			this.gridDataBoundGrid1.EndUpdate();

			this.Cursor = Cursors.Arrow;
            this.gridDataBoundGrid1.CurrentCellShowingDropDown += new GridCurrentCellShowingDropDownEventHandler(gridDataBoundGrid1_CurrentCellShowingDropDown);
        }

        void gridDataBoundGrid1_CurrentCellShowingDropDown(object sender, GridCurrentCellShowingDropDownEventArgs e)
        {
            if (this.gridDataBoundGrid1.CurrentCell.ColIndex == 1 && this.comboBox1.Text == "Employees")
            {
                e.Cancel = true;
            }
            if ((this.gridDataBoundGrid1.CurrentCell.ColIndex == 1 || this.gridDataBoundGrid1.CurrentCell.ColIndex == 2 || this.gridDataBoundGrid1.CurrentCell.ColIndex == 3) && this.comboBox1.Text == "Products")
            {
                e.Cancel = true;
            }
        }
		
		private void FormatGridForTable(string tableName)
		{
			GridBoundColumnsCollection gbcc = this.gridDataBoundGrid1.Binder.InternalColumns;

			if(tableName == "Customers")
			{
				//none
			}
			else if(tableName == "Employees")
			{
				gbcc["BirthDate"].StyleInfo.Format = "d";
				gbcc["BirthDate"].StyleInfo.CellValueType = typeof(DateTime);
				gbcc["HireDate"].StyleInfo.Format = "d";
				gbcc["HireDate"].StyleInfo.CellValueType = typeof(DateTime);
				
				
				//get rid of photo column
                gbcc["Photo"].Hidden = true;
                gbcc["PhotoPath"].Hidden = true;
			}
			else if(tableName == "Orders")
			{
				gbcc["OrderDate"].StyleInfo.Format = "d";
				gbcc["OrderDate"].StyleInfo.CellValueType = typeof(DateTime);
				gbcc["RequiredDate"].StyleInfo.Format = "d";
				gbcc["RequiredDate"].StyleInfo.CellValueType = typeof(DateTime);
				gbcc["ShippedDate"].StyleInfo.Format = "d";
				gbcc["ShippedDate"].StyleInfo.CellValueType = typeof(DateTime);

				gbcc["Freight"].StyleInfo.Format = "f2";
				gbcc["Freight"].StyleInfo.CellValueType = typeof(double);
				gbcc["Freight"].StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right;

				//make EmployeeID display LastName using a hidden foreign key combobox

				DataTable dt = ds.Tables["Employees"];
				gbcc["EmployeeID"].StyleInfo.CellType = "ComboBox";
				gbcc["EmployeeID"].StyleInfo.DataSource = dt;
				gbcc["EmployeeID"].StyleInfo.DisplayMember = "LastName";
				gbcc["EmployeeID"].StyleInfo.ValueMember = "EmployeeID";
				gbcc["EmployeeID"].StyleInfo.ShowButtons = GridShowButtons.Hide;
				
			}
			else if(tableName == "Products")
			{
				gbcc["UnitPrice"].StyleInfo.Format = "f2";
				gbcc["UnitPrice"].StyleInfo.CellValueType = typeof(double);
				gbcc["UnitPrice"].StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right;
				gbcc["UnitsInStock"].StyleInfo.Format = "f0";
				gbcc["UnitsInStock"].StyleInfo.CellValueType = typeof(double);
				gbcc["UnitsInStock"].StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center;
				gbcc["UnitsOnOrder"].StyleInfo.Format = "f0";
				gbcc["UnitsOnOrder"].StyleInfo.CellValueType = typeof(double);
				gbcc["UnitsOnOrder"].StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center;
			}
		}


		#endregion

		#region Form Event Handlers
		private void button1_Click(object sender, System.EventArgs e)
		{
			//add filter bar
			if(theFilterBar != null && !theFilterBar.Wired)
			{
				theFilterBar.WireGrid(this.gridDataBoundGrid1);
				this.label2.Text = "";
			}
			this.gridDataBoundGrid1.RefreshRange(GridRangeInfo.Row(1));
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//remove filter bar
			theFilterBar.UnwireGrid();
			this.gridDataBoundGrid1.RefreshRange(GridRangeInfo.Row(1));
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//load a different table...
			if(this.ds != null && this.comboBox1.Text != currentTableName)
			{
				SetTableIntoGridAndWireFilterBar(this.comboBox1.Text);
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//reset the datagrid
			if(theFilterBar != null)
			{
				theFilterBar.RowFilter = "";
				this.label2.Text = "";
			}
		}

		#endregion

		#region FilterBar Event Handlers

		//use this event to control whether or a column has a filter cell at the top
		private void GridFilterBarCreatingColumnHeader(object sender, GridFilterBarCreatingColumnHeaderEventArgs e)
		{
			if(currentTableName == "Customers")
			{
				//just show all columns for this table though not really useful
			}
			else if(currentTableName == "Employees")
			{
				//don't try filter the primary key colum
				if(e.ColName == "EmployeeID")
					e.Cancel = true;
			}
			else if(currentTableName == "Products")
			{
				//don't try filter these columns
				if(e.ColName == "ProductID" 
					|| e.ColName == "ProductName" 
					|| e.ColName == "QuantityPerUnit")
						e.Cancel = true;
			}
			else if(currentTableName == "Orders")
			{
				//show all columns
			}
		}

		//this event is fired when the row filter is changed
		private void GridFilterBarTextChanged(object sender, GridFilterBarTextChangedEventArgs e)
		{
			this.label2.Text = theFilterBar.RowFilter;
		}

		//show my own custom filter dialog
		private void GridFilterBarShowDialogEventHandler(object send, GridFilterBarShowDialogEventArgs e)
		{
			MyFilterDialog dlg = new MyFilterDialog();

			dlg.grid = this.gridDataBoundGrid1;
			dlg.table = this.ds.Tables[currentTableName];
			DialogResult result = dlg.ShowDialog();
			 
			if(result == DialogResult.Ignore)
			{
				//show the default dialog
				e.Handled = false;
			}
			else 
			{
				//otherwise don't show default and set the result
				e.Handled = true;
				e.Result = result; //cancel or OK-filter the grid with e.FilterCriteria
				e.FilterCriteria = dlg.textBox1.Text; // the filter string
			}
		}
		#endregion

		private bool useCustomDialog = false;
		private void enableDialogButton_Click(object sender, System.EventArgs e)
		{
			useCustomDialog = !useCustomDialog;
			if(useCustomDialog)
			{
				//catch the ShowDialog event to display my own custom filter dialog
				theFilterBar.FilterBarShowDialog += new GridFilterBarShowDialogEventHandler(GridFilterBarShowDialogEventHandler);
				this.enableDialogButton.Text = "      Disable        Custom Dialog";
			}
			else
			{
				theFilterBar.FilterBarShowDialog -= new GridFilterBarShowDialogEventHandler(GridFilterBarShowDialogEventHandler);
				this.enableDialogButton.Text = "      Enable        Custom Dialog";
			}
		}

		private void NoneCustomButton_Click(object sender, System.EventArgs e)
		{
			this.gridDataBoundGrid1.BeginUpdate();
			this.theFilterBar.UnwireGrid();

			if(this.NoneCustomButton.Text.IndexOf("German") > -1)
			{
				theFilterBar.GridFilterBarStrings[0] = "(Keine Auswahl)";
				theFilterBar.GridFilterBarStrings[1] = "(Dialogauswahl)";
				theFilterBar.GridFilterBarStrings[2] = "gleich";
				theFilterBar.GridFilterBarStrings[3] = "nicht gleich";
				theFilterBar.GridFilterBarStrings[4] = "groesser";
				theFilterBar.GridFilterBarStrings[5] = "groesser oder gleich";
				theFilterBar.GridFilterBarStrings[6] = "kleiner";
				theFilterBar.GridFilterBarStrings[7] = "kleiner oder gleich";
				theFilterBar.GridFilterBarStrings[8] = "Textanfang gleich";
				theFilterBar.GridFilterBarStrings[9] = "Textanfang nicht gleich";
				theFilterBar.GridFilterBarStrings[10] = "Textende gleich";
				theFilterBar.GridFilterBarStrings[11] = "Textende nicht gleich";
				theFilterBar.GridFilterBarStrings[12] = "Enthaelt";
				theFilterBar.GridFilterBarStrings[13] = "Enthaelt nicht";
				theFilterBar.GridFilterBarStrings[14] = "Verwende * fuer beliebige Zeichenfolge";
				theFilterBar.GridFilterBarStrings[15] = "Zeige Reihen mit:";
				this.NoneCustomButton.Text = "   Do not show       [none]  [custom]";
			}
			else if(this.NoneCustomButton.Text.IndexOf("Do not") > -1)
			{
				theFilterBar.GridFilterBarStrings[0] = "";
				theFilterBar.GridFilterBarStrings[1] = "";
				theFilterBar.GridFilterBarStrings[2] = "equal";
				theFilterBar.GridFilterBarStrings[3] = "not equal";
				theFilterBar.GridFilterBarStrings[4] = "greater than";
				theFilterBar.GridFilterBarStrings[5] = "greater than or equal";
				theFilterBar.GridFilterBarStrings[6] = "less than";
				theFilterBar.GridFilterBarStrings[7] = "less than or equal";
				theFilterBar.GridFilterBarStrings[8] = "begins with";
				theFilterBar.GridFilterBarStrings[9] = "does not begin with";
				theFilterBar.GridFilterBarStrings[10] = "ends with";
				theFilterBar.GridFilterBarStrings[11] = "does not end with";
				theFilterBar.GridFilterBarStrings[12] = "contains";
				theFilterBar.GridFilterBarStrings[13] = "does not contain";
				theFilterBar.GridFilterBarStrings[14] = "Use * to represent any series of characters";
				theFilterBar.GridFilterBarStrings[15] = "Show rows where:";
				this.NoneCustomButton.Text = "      Default         [none]  [custom]";
			} 
			else if(this.NoneCustomButton.Text.IndexOf("Default") > -1)
			{
				theFilterBar.GridFilterBarStrings[0] = "(none)";
				theFilterBar.GridFilterBarStrings[1] = "(custom)";
				this.NoneCustomButton.Text = "      German         [none]  [custom]";
			}
			this.theFilterBar.WireGrid(this.gridDataBoundGrid1);
			this.gridDataBoundGrid1.EndUpdate();
		}

		private void gridDataBoundGrid1_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
		{
			if(e.RowIndex > 0 && e.ColIndex > 0)
			{			           
				if (e.RowIndex == 1 && this.theFilterBar != null && theFilterBar.Wired)  				
				{
					e.Style.BackColor = Color.White; // Color.FromArgb(218, 229, 245);                                
					e.Style.TextColor = Color.MidnightBlue;
				}
				else
				{
					e.Style.BackColor =  Color.FromArgb( 242, 248, 255 );//Color.FromArgb( 218, 229, 245 );//Color.FromArgb( 0x85, 0xbf, 0x75 );//Color.FromArgb(237, 240, 246);					                    // Color.FromArgb(0xde, 0x64, 0x13);
					e.Style.TextColor = Color.MidnightBlue; 
				}
			}
		}

		private void gridDataBoundGrid1_CellDoubleClick(object sender, GridCellClickEventArgs e)
		{
			if(this.comboBox1.SelectedIndex==1)
			{
				if(e.RowIndex==1 && e.ColIndex==1)
					e.Cancel=true;
			}
			else if(this.comboBox1.SelectedIndex==3)
			{
				if(e.RowIndex==1 && (e.ColIndex>=1 && e.ColIndex<=3))
					e.Cancel=true;
			}
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
