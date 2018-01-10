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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Globalization;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Collections.Generic;

namespace ComboTest
{

	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ComboBox comboBox2;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textLog;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private ComboTest.DataSet1 dataSet11;
		private ComboTest.DataSet2 dataSet21;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv ComboBoxAdvBound;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkNumbersOnly;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkCaseSens;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkAutoComp;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSorted;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv ComboBoxAdv1;
		private System.Windows.Forms.Label label3;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private System.Windows.Forms.Label label4;
        private Label label5;
        private ComboBoxAdv comboBoxAdv3;
        private Label label6;
        private Label label10;
        private Label label11;
        private Label label12;
        private ButtonAdv btnSetBanner;
        private TextBoxExt txtBanner;
        private RadioButtonAdv rdoFocus;
        private RadioButtonAdv rdoEdit;
        private ButtonEdit bannerColorEdit;
        private TextBoxExt textBoxExt1;
        private ButtonEditChildButton buttonEditChildButton1;
        private BannerTextProvider bannerTextProvider1;
        private ColorDialog colorDialog1;
        private ToolTip toolTip1;
        private SplitContainerAdv splitContainerAdv1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private IContainer components;
        List<string> list = new List<string>();
		public Form1()
		{	
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            string mdbFile = Application.StartupPath + @" \..\..\..\..\..\..\..\..\Common\Data\ComboBoxAdvDataBinding.mdb";

            // Database connection string
            this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbFile;
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

		public static string FindFile(string xmlFileName)
		{
			// Check both in parent folder and Parent\Data folders.
			string xmlDataFileName = @"Data\" + xmlFileName;
			for (int n = 0; n < 10; n++)
			{
				if (System.IO.File.Exists(xmlFileName))
				{
					return xmlFileName;
				}
				if (System.IO.File.Exists(xmlDataFileName))
				{
					return xmlDataFileName;
				}
				xmlFileName = @"..\" + xmlFileName;
				xmlDataFileName = @"..\" + xmlDataFileName;
			}

			return xmlFileName;
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
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataSet11 = new ComboTest.DataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.dataSet21 = new ComboTest.DataSet2();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkSorted = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkAutoComp = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkCaseSens = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkNumbersOnly = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxAdvBound = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAdv3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSetBanner = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtBanner = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.rdoFocus = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rdoEdit = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.bannerColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSorted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCaseSens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNumbersOnly)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAdvBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerColorEdit)).BeginInit();
            this.bannerColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(456, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 517);
            this.panel1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.Location = new System.Drawing.Point(3, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 517);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textLog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 472);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events:";
            // 
            // textLog
            // 
            this.textLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLog.Location = new System.Drawing.Point(3, 17);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(723, 124);
            this.textLog.TabIndex = 0;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT CustomerName, ID, Sex FROM Customers";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Customers(CustomerName, Sex) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"),
            new System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.VarWChar, 50, "Sex")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE Customers SET CustomerName = ?, Sex = ? WHERE (ID = ?) AND (CustomerName =" +
    " ? OR ? IS NULL AND CustomerName IS NULL) AND (Sex = ? OR ? IS NULL AND Sex IS N" +
    "ULL)";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"),
            new System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.VarWChar, 50, "Sex"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM Customers WHERE (ID = ?) AND (CustomerName = ? OR ? IS NULL AND Custo" +
    "merName IS NULL) AND (Sex = ? OR ? IS NULL AND Sex IS NULL)";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerName", "CustomerName"),
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Sex", "Sex")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT Description, ID FROM Sex_Description";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO Sex_Description(Description) VALUES (?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = "UPDATE Sex_Description SET Description = ? WHERE (ID = ?) AND (Description = ? OR" +
    " ? IS NULL AND Description IS NULL)";
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = "DELETE FROM Sex_Description WHERE (ID = ?) AND (Description = ? OR ? IS NULL AND " +
    "Description IS NULL)";
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sex_Description", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ComboBoxAdv1);
            this.groupBox3.Controls.Add(this.chkSorted);
            this.groupBox3.Controls.Add(this.chkAutoComp);
            this.groupBox3.Controls.Add(this.chkCaseSens);
            this.groupBox3.Controls.Add(this.chkNumbersOnly);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 157);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ComboBoxAdv:";
            // 
            // ComboBoxAdv1
            // 

            this.ComboBoxAdv1.BackColor = System.Drawing.Color.White;
            bannerTextInfo1.Text = "[Select]";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.ComboBoxAdv1, bannerTextInfo1);
            this.ComboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.ComboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxAdv1.Location = new System.Drawing.Point(32, 25);
            this.ComboBoxAdv1.Name = "ComboBoxAdv1";
            this.ComboBoxAdv1.Size = new System.Drawing.Size(176, 21);
            this.ComboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.ComboBoxAdv1.TabIndex = 5;
            // 
            // chkSorted
            // 
            this.chkSorted.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkSorted.DrawFocusRectangle = false;
            this.chkSorted.Location = new System.Drawing.Point(32, 129);
            this.chkSorted.MetroColor = System.Drawing.Color.Gray;
            this.chkSorted.Name = "chkSorted";
            this.chkSorted.Size = new System.Drawing.Size(125, 22);
            this.chkSorted.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkSorted.TabIndex = 4;
            this.chkSorted.Text = "Sorted";
            this.chkSorted.ThemesEnabled = false;
            this.chkSorted.CheckedChanged += new System.EventHandler(this.chkSorted_CheckedChanged);
            // 
            // chkAutoComp
            // 
            this.chkAutoComp.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkAutoComp.Checked = true;
            this.chkAutoComp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoComp.DrawFocusRectangle = false;
            this.chkAutoComp.Location = new System.Drawing.Point(32, 78);
            this.chkAutoComp.MetroColor = System.Drawing.Color.Gray;
            this.chkAutoComp.Name = "chkAutoComp";
            this.chkAutoComp.Size = new System.Drawing.Size(114, 23);
            this.chkAutoComp.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkAutoComp.TabIndex = 3;
            this.chkAutoComp.Text = "Auto Complete";
            this.chkAutoComp.ThemesEnabled = false;
            this.chkAutoComp.CheckedChanged += new System.EventHandler(this.chkAutoComp_CheckedChanged);
            // 
            // chkCaseSens
            // 
            this.chkCaseSens.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkCaseSens.DrawFocusRectangle = false;
            this.chkCaseSens.Location = new System.Drawing.Point(32, 103);
            this.chkCaseSens.MetroColor = System.Drawing.Color.Gray;
            this.chkCaseSens.Name = "chkCaseSens";
            this.chkCaseSens.Size = new System.Drawing.Size(195, 24);
            this.chkCaseSens.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkCaseSens.TabIndex = 2;
            this.chkCaseSens.Text = "Case Sensitive Auto Complete";
            this.chkCaseSens.ThemesEnabled = false;
            this.chkCaseSens.CheckedChanged += new System.EventHandler(this.chkCaseSens_CheckedChanged);
            // 
            // chkNumbersOnly
            // 
            this.chkNumbersOnly.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkNumbersOnly.DrawFocusRectangle = false;
            this.chkNumbersOnly.Location = new System.Drawing.Point(32, 57);
            this.chkNumbersOnly.MetroColor = System.Drawing.Color.Gray;
            this.chkNumbersOnly.Name = "chkNumbersOnly";
            this.chkNumbersOnly.Size = new System.Drawing.Size(120, 18);
            this.chkNumbersOnly.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkNumbersOnly.TabIndex = 1;
            this.chkNumbersOnly.Text = "Numbers Only";
            this.chkNumbersOnly.ThemesEnabled = false;
            this.chkNumbersOnly.CheckedChanged += new System.EventHandler(this.chkNumbersOnly_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ComboBoxAdvBound);
            this.groupBox2.Controls.Add(this.dataGrid1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 390);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataBound ComboBoxAdv";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Databinding for this combo initialized in code. Change the sex in the current row" +
    " in the grid below and see the values change here and vice-versa.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Databound Grid:";
            // 
            // ComboBoxAdvBound
            // 
            this.ComboBoxAdvBound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxAdvBound.BackColor = System.Drawing.Color.White;
            this.ComboBoxAdvBound.BeforeTouchSize = new System.Drawing.Size(383, 21);
            this.ComboBoxAdvBound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAdvBound.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxAdvBound.Location = new System.Drawing.Point(8, 84);
            this.ComboBoxAdvBound.Name = "ComboBoxAdvBound";
            this.ComboBoxAdvBound.Size = new System.Drawing.Size(383, 21);
            this.ComboBoxAdvBound.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.ComboBoxAdvBound.TabIndex = 0;
            this.ComboBoxAdvBound.SelectedIndexChanged += new System.EventHandler(this.boundCombo_SelectedIndexChanged);
            this.ComboBoxAdvBound.SelectionChangeCommitted += new System.EventHandler(this.combo_SelectionChangeCommitted);
            this.ComboBoxAdvBound.Validating += new System.ComponentModel.CancelEventHandler(this.combo_Validating);
            this.ComboBoxAdvBound.Validated += new System.EventHandler(this.combo_Validated);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.dataSet11.Customers;
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid1.Location = new System.Drawing.Point(8, 137);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(388, 237);
            this.dataGrid1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(729, 48);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(120, 21);
            this.comboBoxAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "Metro",
            "Default",
            "OfficeXP",
            "VS2005",
            "Office2003",
            "Office2007"});
            this.comboBoxAdv2.Location = new System.Drawing.Point(149, 19);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(120, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 6;
            this.comboBoxAdv2.Text = "Metro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Style:";
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv3.BeforeTouchSize = new System.Drawing.Size(92, 21);
            this.comboBoxAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv3.Enabled = false;
            this.comboBoxAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv3.Items.AddRange(new object[] {
            "Blue",
            "Silver",
            "Black"});
            this.comboBoxAdv3.Location = new System.Drawing.Point(174, 46);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Size = new System.Drawing.Size(92, 21);
            this.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv3.TabIndex = 16;
            this.comboBoxAdv3.Text = "Blue";
            this.comboBoxAdv3.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Office2007 - Color Scheme:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(11, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "      Visual Style";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 14);
            this.label10.TabIndex = 6;
            this.label10.Text = "Text";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "Mode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 14);
            this.label12.TabIndex = 8;
            this.label12.Text = "Color";
            // 
            // btnSetBanner
            // 
            this.btnSetBanner.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSetBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnSetBanner.BeforeTouchSize = new System.Drawing.Size(106, 23);
            this.btnSetBanner.Enabled = false;
            this.btnSetBanner.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBanner.ForeColor = System.Drawing.Color.White;
            this.btnSetBanner.IsBackStageButton = false;
            this.btnSetBanner.Location = new System.Drawing.Point(98, 104);
            this.btnSetBanner.Name = "btnSetBanner";
            this.btnSetBanner.Size = new System.Drawing.Size(106, 23);
            this.btnSetBanner.TabIndex = 21;
            this.btnSetBanner.Text = "Set Banner Text";
            this.btnSetBanner.UseVisualStyle = true;
            this.btnSetBanner.UseVisualStyleBackColor = true;
            this.btnSetBanner.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBanner
            // 
            this.txtBanner.BeforeTouchSize = new System.Drawing.Size(127, 13);
            this.txtBanner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBanner.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanner.Location = new System.Drawing.Point(98, 19);
            this.txtBanner.Metrocolor = System.Drawing.Color.Empty;
            this.txtBanner.Name = "txtBanner";
            this.txtBanner.Size = new System.Drawing.Size(154, 20);
            this.txtBanner.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBanner.TabIndex = 22;
            // 
            // rdoFocus
            // 
            this.rdoFocus.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rdoFocus.DrawFocusRectangle = false;
            this.rdoFocus.Location = new System.Drawing.Point(174, 45);
            this.rdoFocus.MetroColor = System.Drawing.Color.Gray;
            this.rdoFocus.Name = "rdoFocus";
            this.rdoFocus.Size = new System.Drawing.Size(85, 17);
            this.rdoFocus.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rdoFocus.TabIndex = 23;
            this.rdoFocus.TabStop = false;
            this.rdoFocus.Text = "FocusMode";
            this.rdoFocus.ThemesEnabled = false;
            // 
            // rdoEdit
            // 
            this.rdoEdit.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rdoEdit.Checked = true;
            this.rdoEdit.DrawFocusRectangle = false;
            this.rdoEdit.Location = new System.Drawing.Point(98, 45);
            this.rdoEdit.MetroColor = System.Drawing.Color.Gray;
            this.rdoEdit.Name = "rdoEdit";
            this.rdoEdit.Size = new System.Drawing.Size(74, 17);
            this.rdoEdit.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rdoEdit.TabIndex = 24;
            this.rdoEdit.Text = "EditMode";
            this.rdoEdit.ThemesEnabled = false;
            // 
            // bannerColorEdit
            // 
            this.bannerColorEdit.BackColor = System.Drawing.Color.White;
            this.bannerColorEdit.BeforeTouchSize = new System.Drawing.Size(151, 21);
            this.bannerColorEdit.Buttons.Add(this.buttonEditChildButton1);
            this.bannerColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.bannerColorEdit.Controls.Add(this.buttonEditChildButton1);
            this.bannerColorEdit.Controls.Add(this.textBoxExt1);
            this.bannerColorEdit.Location = new System.Drawing.Point(98, 73);
            this.bannerColorEdit.MetroColor = System.Drawing.Color.Silver;
            this.bannerColorEdit.Name = "bannerColorEdit";
            this.bannerColorEdit.Size = new System.Drawing.Size(151, 21);
            this.bannerColorEdit.TabIndex = 25;
            this.bannerColorEdit.TextBox = this.textBoxExt1;
            this.bannerColorEdit.UseVisualStyle = true;
            this.bannerColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bannerColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(20, 17);
            this.buttonEditChildButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BackColor = System.Drawing.Color.White;
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(127, 13);
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt1.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(127, 13);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt1.TabIndex = 0;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(10, 76);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainerAdv1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainerAdv1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainerAdv1.Size = new System.Drawing.Size(729, 390);
            this.splitContainerAdv1.SplitterDistance = 404;
            this.splitContainerAdv1.TabIndex = 26;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.comboBoxAdv2);
            this.groupBox5.Controls.Add(this.comboBoxAdv3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(20, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 76);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Visual Style";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.bannerColorEdit);
            this.groupBox4.Controls.Add(this.btnSetBanner);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtBanner);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.rdoEdit);
            this.groupBox4.Controls.Add(this.rdoFocus);
            this.groupBox4.Location = new System.Drawing.Point(20, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 133);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BannerTextSettings";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(749, 626);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(761, 658);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBoxAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSorted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCaseSens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNumbersOnly)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAdvBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerColorEdit)).EndInit();
            this.bannerColorEdit.ResumeLayout(false);
            this.bannerColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//To Fille the ComboBoxAdv1 with Month name items.
			for(int i=1;i<13;i++)
				ComboBoxAdv1.Items.Add(CultureInfo.CurrentUICulture.DateTimeFormat.GetMonthName(i));

		
			//To Fill the ComboBoxAdvBound with items from DataSource.
			this.oleDbDataAdapter1.Fill(this.dataSet11);
			this.oleDbDataAdapter2.Fill(this.dataSet21);

			ComboBoxAdvBound.DataSource = this.dataSet21.Sex_Description;
			ComboBoxAdvBound.DisplayMember = "Description";
			ComboBoxAdvBound.ValueMember = "ID";

			ComboBoxAdvBound.DataBindings.Add("SelectedValue", this.dataSet11.Customers, "Sex");	
			this.comboBoxAdv2.SelectedIndex = 0;
			this.comboBoxAdv2.SelectedIndexChanged += new EventHandler(OnThemeChanged);

            foreach (string item in ComboBoxAdv1.Items)
            {
                list.Add(item);
            }

            Application.Idle += new EventHandler(Application_Idle);
		}

        

		#region ComboBoxAdv Events
		private void boundCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
			this.textLog.Text += c.Name + "'s SelectedIndexChanged to:" + c.SelectedIndex + "\r\n";
		}

		private void combo_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
			this.textLog.Text += c.Name + "'s SelectionChangeCommitted. New index is:" + c.SelectedIndex  + "\r\n";
		}

		private void combo_Validated(object sender, System.EventArgs e)
		{
			ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
			if(c.SelectedItem != null)
				this.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.SelectedItem.ToString()  + "\r\n";
			else
				this.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.Text + "\r\n";
		}

		private void combo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
			if(c.SelectedItem != null)
				this.textLog.Text += c.Name + "is validating the new entry:" + c.SelectedItem.ToString() + "\r\n";
			else
				this.textLog.Text += c.Name + "is validating the new entry:" + c.Text + "\r\n";
		}
		#endregion

		private void chkNumbersOnly_CheckedChanged(object sender, System.EventArgs e)
		{
			ComboBoxAdv1.NumberOnly = chkNumbersOnly.Checked;
		}

		private void chkCaseSens_CheckedChanged(object sender, System.EventArgs e)
		{
			ComboBoxAdv1.CaseSensitiveAutocomplete = chkCaseSens.Checked;
		}

		private void chkAutoComp_CheckedChanged(object sender, System.EventArgs e)
		{
			ComboBoxAdv1.AutoComplete = chkAutoComp.Checked;
		}

		private void chkSorted_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkSorted.Checked)
                ComboBoxAdv1.Sorted = chkSorted.Checked;
            else
            {
                ComboBoxAdv1.Sorted = false;
                ComboBoxAdv1.Items.Clear();

                foreach (string item in list)
                {
                    ComboBoxAdv1.Items.Add(item);
                }
            }
		}

		#region ThemeStyles

		private void OnThemeChanged(object sender,EventArgs e)
		{
			if(this.comboBoxAdv2.SelectedItem.ToString()!="")
			{
				switch(this.comboBoxAdv2.SelectedItem.ToString())
				{
                    case "Metro":
                        this.ComboBoxAdv1.Style = VisualStyle.Metro;
                        this.comboBoxAdv2.Style = VisualStyle.Metro;
                        this.ComboBoxAdvBound.Style = VisualStyle.Metro;
                        this.comboBoxAdv3.Enabled = false;
                        break;
					case "Default":
						this.ComboBoxAdv1.Style = VisualStyle.Default;
						this.comboBoxAdv2.Style = VisualStyle.Default;
						this.ComboBoxAdvBound.Style = VisualStyle.Default;
                        this.comboBoxAdv3.Enabled = false;
						break;
					case "OfficeXP":
						this.ComboBoxAdv1.Style = VisualStyle.OfficeXP;
						this.comboBoxAdv2.Style = VisualStyle.OfficeXP;
						this.ComboBoxAdvBound.Style = VisualStyle.OfficeXP;
                        this.comboBoxAdv3.Enabled = false;
						break;
					case "Office2003":
						this.ComboBoxAdv1.Style = VisualStyle.Office2003;
						this.comboBoxAdv2.Style = VisualStyle.Office2003;
						this.ComboBoxAdvBound.Style = VisualStyle.Office2003;
                        this.comboBoxAdv3.Enabled = false;
						break;
					case "VS2005":
						this.ComboBoxAdv1.Style = VisualStyle.VS2005;
						this.comboBoxAdv2.Style = VisualStyle.VS2005;
						this.ComboBoxAdvBound.Style = VisualStyle.VS2005;
                        this.comboBoxAdv3.Enabled = false;
						break;
					case "Office2007":
						this.ComboBoxAdv1.Style = VisualStyle.Office2007;
						this.comboBoxAdv2.Style = VisualStyle.Office2007;
						this.ComboBoxAdvBound.Style = VisualStyle.Office2007;
                        this.comboBoxAdv3.Enabled = true;
						break;
                }
			}
		}

		#endregion

        #region Office2007 Color Scheme

        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv3.SelectedItem.ToString())
            {
                case "Blue":
                    {
                        this.ComboBoxAdv1.Office2007ColorTheme = Office2007Theme.Blue;
                        this.comboBoxAdv2.Office2007ColorTheme = Office2007Theme.Blue;
                        this.comboBoxAdv3.Office2007ColorTheme = Office2007Theme.Blue;
                        this.ComboBoxAdvBound.Office2007ColorTheme = Office2007Theme.Blue;
                        break;
                    }
                case "Silver":
                    {
                        this.ComboBoxAdv1.Office2007ColorTheme = Office2007Theme.Silver;
                        this.comboBoxAdv2.Office2007ColorTheme = Office2007Theme.Silver;
                        this.comboBoxAdv3.Office2007ColorTheme = Office2007Theme.Silver;
                        this.ComboBoxAdvBound.Office2007ColorTheme = Office2007Theme.Silver;
                        break;
                    }
                case "Black":
                    {
                        this.ComboBoxAdv1.Office2007ColorTheme = Office2007Theme.Black;
                        this.comboBoxAdv2.Office2007ColorTheme = Office2007Theme.Black;
                        this.comboBoxAdv3.Office2007ColorTheme = Office2007Theme.Black;
                        this.ComboBoxAdvBound.Office2007ColorTheme = Office2007Theme.Black;
                        break;
                    }
            }
        }
        #endregion

        #region BannerText Settings
        private void button1_Click(object sender, EventArgs e)
        {
            BannerTextMode mode;

            if (rdoFocus.Checked)
                mode = BannerTextMode.FocusMode;
            else
                mode = BannerTextMode.EditMode;

            BannerTextInfo bInfo = this.bannerTextProvider1.GetBannerText(this.ComboBoxAdv1);
            bInfo.Text = this.txtBanner.Text;
            bInfo.Color = this.bannerColorEdit.TextBox.BackColor;
            bInfo.Mode = mode;
            bInfo.Visible = true;
            BannerTextInfo bInfo2 = this.bannerTextProvider1.GetBannerText(this.ComboBoxAdvBound);
            bInfo2.Text = this.txtBanner.Text;
            bInfo2.Color = this.bannerColorEdit.TextBox.BackColor;
            bInfo2.Mode = mode;
            bInfo2.Visible = true;
            this.ComboBoxAdv1.Refresh();
            this.ComboBoxAdvBound.Refresh();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            if (txtBanner.Text == "")
                this.btnSetBanner.Enabled = false;
            else
                this.btnSetBanner.Enabled = true;
        }

        private void bannerColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.bannerColorEdit.TextBox.BackColor = colorDialog1.Color;
        }
        #endregion
    }
}
