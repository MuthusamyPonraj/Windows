#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;
using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
namespace DataBoundGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
		private GDBGSerialization.Dataset1 dataset11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            String commandstring = "select * from Customers";
            String connection = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connection);
            try
            {
                da.Fill(dataset11, "Customers");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }
            
			//Format GridBoundColumns
			this.gridDataBoundGrid1.Binder.InternalColumns[0].StyleInfo.BackColor=Color.FromArgb(255,229,201);
			this.gridDataBoundGrid1.Binder.InternalColumns[1].StyleInfo.TextColor=Color.FromArgb(41,65,125);
			this.gridDataBoundGrid1.Binder.InternalColumns[1].StyleInfo.Font.Bold=true;
			this.gridDataBoundGrid1.Binder.InternalColumns[2].StyleInfo.BackColor=Color.FromArgb(246,246,222);
			this.gridDataBoundGrid1.Binder.InternalColumns[3].StyleInfo.Font.Bold=true;
			this.gridDataBoundGrid1.Binder.InternalColumns[4].StyleInfo.BackColor=Color.FromArgb(223,247,252);
			this.gridDataBoundGrid1.Binder.InternalColumns[7].StyleInfo.BackColor=Color.FromArgb(205,211,227);
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridDataBoundGrid1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridDataBoundGrid1.AllowResizeToFit = false;
            this.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Table(), GridResizeToFitOptions.IncludeHeaders);
        }

        private string FindFile(string connstring)
        {
            connstring = @"common\data\" + connstring;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(connstring))
                    return new FileInfo(connstring).FullName;
                connstring = @"..\" + connstring;
            }

            return connstring;
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

        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            this.dataset11 = new GDBGSerialization.Dataset1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.DataMember = "";
            this.gridDataBoundGrid1.DataSource = this.dataset11.Customers;
            this.gridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(632, 224);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(221)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(200, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "BinarySerialize";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(221)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(312, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "BinaryDeserialize";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridDataBoundGrid1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 224);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(213)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(632, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serialize Data Bound Grid Demo";
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			FileDialog dlg=new SaveFileDialog();
			dlg.Filter="Binary files (*.egt)|*.egt|All files (*.*)|*.*";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					//serialize out the row heights & columnwidths
					IFormatter formatter = new BinaryFormatter();
					Stream stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
		
					//handle the mappingnames
					GridBoundColumnsCollection col = (GridBoundColumnsCollection) this.gridDataBoundGrid1.GridBoundColumns;
					if(col.Count == 0)
						col = this.gridDataBoundGrid1.Binder.InternalColumns;

					int nCols = col.Count;
					string[] a = new string[nCols];
					int i = 0;
					foreach(GridBoundColumn c in col)
						a[i++] = c.MappingName;

					formatter.Serialize(stream, a);
					formatter.Serialize(stream, this.gridDataBoundGrid1.Model.ColWidths.Dictionary);
                    formatter.Serialize(stream, this.gridDataBoundGrid1.Model.RowHeights.Dictionary);
					formatter.Serialize(stream,this.gridDataBoundGrid1.Model.ColStyles[1].BackColor);
					stream.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			
			FileDialog dlg = new OpenFileDialog();
			dlg.Filter="Binary files (*.egt)|*.egt|All files (*.*)|*.*";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					IFormatter formatter = new BinaryFormatter();
					Stream stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
					try
					{
						this.gridDataBoundGrid1.BeginUpdate();
				   
						//handle the mappingnames
						GridBoundColumnsCollection col = (GridBoundColumnsCollection) this.gridDataBoundGrid1.GridBoundColumns.Clone();
						if(col.Count == 0)
							col = this.gridDataBoundGrid1.Binder.InternalColumns;
						//Deserialize GridBoundColumns
						string[] a = (string[]) formatter.Deserialize(stream);
						this.gridDataBoundGrid1.GridBoundColumns.Clear();
						foreach(string s in a)
						{
							GridBoundColumn c = col[s];
							this.gridDataBoundGrid1.GridBoundColumns.Add(c);
						}
			
						this.gridDataBoundGrid1.Model.ColWidths.Dictionary = 
							(Syncfusion.Windows.Forms.Grid.GridRowColSizeDictionary) formatter.Deserialize(stream);
                        this.gridDataBoundGrid1.Model.RowHeights.Dictionary =
                            (Syncfusion.Windows.Forms.Grid.GridRowColSizeDictionary)formatter.Deserialize(stream);
						this.gridDataBoundGrid1.Model.ColStyles[1].BackColor=(Color)formatter.Deserialize(stream);
					}
					finally
					{
						this.gridDataBoundGrid1.EndUpdate();
						this.gridDataBoundGrid1.Refresh();
						stream.Close();
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
	}
}
