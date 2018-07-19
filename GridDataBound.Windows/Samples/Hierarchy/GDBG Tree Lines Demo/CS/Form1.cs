using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
namespace GDBGTreeLines
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
        private Syncfusion.Windows.Forms.ButtonAdv button2;
        private Syncfusion.Windows.Forms.ButtonAdv button3;
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
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(16, 144);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.ShowTreeLines = true;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(384, 296);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(24, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Hide Row Header";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(24, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 24);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "No Color";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(24, 80);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(104, 24);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "No Gridlines";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Auto size TreeLineCell Column";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(224, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Expand All";
            this.button2.UseVisualStyle = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(224, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Collapse All";
            this.button3.UseVisualStyle = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(424, 454);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDBG Tree Lines Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
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
			Application.Run(new Form1());
		}
		
		GridHierarchyLevel level0,level1,level2,level3,level4;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			DataTable parentTable = GetParentTable();
			DataTable childTable = GetChildTable();
			DataTable grandChildTable = GetGrandChildTable();
			DataTable greatGrandChildTable = GetGreatGrandChildTable();
			DataTable greatGreatGrandChildTable = GetGreatGreatGrandChildTable();

			DataSet ds=new DataSet();
			ds.Tables.AddRange(new DataTable[] {parentTable,childTable,grandChildTable,greatGrandChildTable,greatGreatGrandChildTable});

			ds.Relations.Add(new DataRelation("ParentToChild", ds.Tables[0].Columns["parentID"], ds.Tables[1].Columns["ParentID"]));
			ds.Relations.Add(new DataRelation("ChildToGrandChild", ds.Tables[1].Columns["childID"], ds.Tables[2].Columns["ChildID"]));
			ds.Relations.Add(new DataRelation("GrandChildToGreatGrandChild", ds.Tables[2].Columns["grandChildID"], ds.Tables[3].Columns["GrandChildID"]));
			ds.Relations.Add(new DataRelation("GreatGrandChildToGreatGreatGrandChild", ds.Tables[3].Columns["greatGrandChildID"], ds.Tables[4].Columns["GreatGrandChildID"]));

			this.gridDataBoundGrid1.DataSource=ds;
			this.gridDataBoundGrid1.DataMember=parentTable.TableName;
			level0 = this.gridDataBoundGrid1.Binder.RootHierarchyLevel;
			level1 = this.gridDataBoundGrid1.Binder.AddRelation("ParentToChild");
			level2 = this.gridDataBoundGrid1.Binder.AddRelation("ChildToGrandChild");
			level3 = this.gridDataBoundGrid1.Binder.AddRelation("GrandChildToGreatGrandChild");
			level4 = this.gridDataBoundGrid1.Binder.AddRelation("GreatGrandChildToGreatGreatGrandChild");

			this.gridDataBoundGrid1.Model.Options.ResizeColsBehavior |= GridResizeCellsBehavior.InsideGrid;

			this.gridDataBoundGrid1.TableStyle.WrapText = false;

			this.gridDataBoundGrid1.CurrentCell.MoveTo(this.gridDataBoundGrid1.Model.Rows.HeaderCount + 1, 3);
			this.gridDataBoundGrid1.Binder.EnableAddNew = false;
			this.gridDataBoundGrid1.Properties.BackgroundColor = SystemColors.Window;
            checkBox2_CheckedChanged(this,EventArgs.Empty);
			checkBox3_CheckedChanged(this,EventArgs.Empty);
			checkBox4_CheckedChanged(this,EventArgs.Empty);
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

		
		#region DataTables

		private int numberParentRows = 5;
		private int numberChildRows = 20;
		private int numberGrandChildRows = 50;
		private int numberGreatGrandChildRows = 150;
		private int numberGreatGreatGrandChildRows = 250;

		private DataTable GetParentTable()
		{
			DataTable dt = new DataTable("ParentTable");


			dt.Columns.Add(new DataColumn("ParentName"));
			dt.Columns.Add(new DataColumn("parentID")); //lower case p
			dt.Columns.Add(new DataColumn("ParentDec"));

			for (int i = 0; i < numberParentRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[1] = i;//.ToString();
				dr[0] = string.Format("parentName{0}", i);
				dr[2] = string.Format("desc{0}", i);
				dt.Rows.Add(dr);
			}

			return dt;
		}

		Random r = new Random();
		private DataTable GetChildTable()
		{
			DataTable dt = new DataTable("ChildTable");

			dt.Columns.Add(new DataColumn("ChildName"));
			dt.Columns.Add(new DataColumn("childID")); //lower case c
			dt.Columns.Add(new DataColumn("ParentID")); //upper case P

			for (int i = 0; i < numberChildRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[1] = i.ToString();
				dr[0] = string.Format("ChildName{0}", i);
				dr[2] = r.Next(numberParentRows).ToString();//(i % numberParentRows).ToString();
				dt.Rows.Add(dr);
			}

			return dt;
		}

		private DataTable GetGrandChildTable()
		{
			DataTable dt = new DataTable("GrandChildTable");

			dt.Columns.Add(new DataColumn("GrandChildName"));
			dt.Columns.Add(new DataColumn("grandChildID"));
			dt.Columns.Add(new DataColumn("ChildID")); //upper case C

			for (int i = 0; i < numberGrandChildRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[1] = i.ToString();
				dr[0] = string.Format("GrandChildName{0}", i);
				dr[2] = r.Next(numberChildRows).ToString();//(i % numberChildRows).ToString();
				dt.Rows.Add(dr);
			}

			return dt;
		}

		private DataTable GetGreatGrandChildTable()
		{
			DataTable dt = new DataTable("GreatGrandChildTable");

			dt.Columns.Add(new DataColumn("GreatGrandChildName"));
			dt.Columns.Add(new DataColumn("greatGrandChildID"));
			dt.Columns.Add(new DataColumn("GrandChildID")); //upper case C

			for (int i = 0; i < numberGreatGrandChildRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[1] = i.ToString();
				dr[0] = string.Format("GreatGrandChildName{0}", i);
				dr[2] = r.Next(numberGrandChildRows).ToString();//(i % numberGrandChildRows).ToString();
				dt.Rows.Add(dr);
			}

			return dt;
		}

		private DataTable GetGreatGreatGrandChildTable()
		{
			DataTable dt = new DataTable("GreatGreatGrandChildTable");

			dt.Columns.Add(new DataColumn("GreatGreatGrandChildName"));
			dt.Columns.Add(new DataColumn("greatGreatGrandChildID"));
			dt.Columns.Add(new DataColumn("GreatGrandChildID")); //upper case C

			for (int i = 0; i < numberGreatGreatGrandChildRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[1] = i.ToString();
				dr[0] = string.Format("GreatGreatGrandChildName{0}", i);
				dr[2] = r.Next(numberGreatGrandChildRows).ToString();//(i % numberGreatGrandChildRows).ToString();
				dt.Rows.Add(dr);
			}

			return dt;
		}
		#endregion

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			//hide row headers
			this.gridDataBoundGrid1.Model.Properties.RowHeaders=!checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			//no color
			if(this.checkBox3.Checked)
			{
				level0.RowStyle.BackColor = SystemColors.Window;
				level1.RowStyle.BackColor = SystemColors.Window;
				level2.RowStyle.BackColor = SystemColors.Window;
				level3.RowStyle.BackColor = SystemColors.Window;
				level4.RowStyle.BackColor = SystemColors.Window;
				gridDataBoundGrid1.TableStyle.TextColor = Color.Black;
			}
			else
			{
				level0.RowStyle.BackColor = Color.FromArgb( 132, 161, 195 ); 
				level1.RowStyle.BackColor = Color.FromArgb( 196, 214, 233 ); 
				level2.RowStyle.BackColor = Color.FromArgb( 204, 212, 230 ); 
				level3.RowStyle.BackColor = Color.FromArgb( 218, 229, 245 ); 
				level4.RowStyle.BackColor = Color.FromArgb( 237, 240, 246 );
				gridDataBoundGrid1.TableStyle.TextColor = Color.FromArgb( 238, 122, 3 );
			}

			this.gridDataBoundGrid1.Refresh();
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			//no gridlines
			if(this.checkBox4.Checked)
			{
				this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.None;
			}
			else
			{
				this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
				this.gridDataBoundGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver;
			}
			this.gridDataBoundGrid1.Refresh();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(this.gridDataBoundGrid1.ShowTreeLines)
			{
				this.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Col(2));
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.gridDataBoundGrid1.BeginUpdate();
			this.gridDataBoundGrid1.ExpandAll();
			this.gridDataBoundGrid1.EndUpdate();
			this.gridDataBoundGrid1.Refresh();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.gridDataBoundGrid1.BeginUpdate();
			this.gridDataBoundGrid1.CollapseAll();
			this.gridDataBoundGrid1.EndUpdate();
			this.gridDataBoundGrid1.Refresh();
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
