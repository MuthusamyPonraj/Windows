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

namespace CellCommentTips
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        DataSet ds;
        private ArrayList comments;
        private ExcelTip.CommentMouseController commentMouseController1;
        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBound1;
        private System.Windows.Forms.Label label1;
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

            this.gridDataBound1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridDataBound1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            this.gridDataBound1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.BackColor = Color.FromArgb(223, 227, 239);

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridDataBound1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBound1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridDataBound1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right);
            this.gridDataBound1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDataBound1.Location = new System.Drawing.Point(41, 65);
            this.gridDataBound1.Name = "gridControl1";
            //this.gridDataBound1.RowCount = 30;
            this.gridDataBound1.Size = new System.Drawing.Size(616, 256);
            this.gridDataBound1.SmartSizeBox = false;
            this.gridDataBound1.TabIndex = 0;
            //this.gridDataBound1.Text = "gridControl1";
            this.gridDataBound1.ThemesEnabled = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right);
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Right-Click Cell or Left-Click existing comment corner to Add, Remove or Edit comment ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 350);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(688, 350);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.gridDataBound1,
																		  this.panel1});
            this.Name = "Form1";
            this.Text = "Cell Comment Tip Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBound1)).EndInit();
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
            //create the Comment mousecontroller.
            this.commentMouseController1 = new ExcelTip.CommentMouseController(gridDataBound1);
            //allow context menu to edit/add comments
            this.commentMouseController1.ContextMenuEnabled = true;
            //register the controller
            gridDataBound1.MouseControllerDispatcher.Add(commentMouseController1);

            ds = new DataSet();
            ReadXml(ds, @"\common\Data\GDBDdata.XML");
            this.gridDataBound1.DataSource = ds.Tables["customers"];
            this.gridDataBound1.DefaultRowHeight = 18;
            this.gridDataBound1.DefaultColWidth = 70;
            this.gridDataBound1.Properties.GridLineColor = System.Drawing.Color.Silver;
            this.gridDataBound1.DefaultGridBorderStyle = GridBorderStyle.Solid;
        }

        void Model_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColIndex == 2)
            {
                ExcelTip.GridExcelTipStyleProperties style = new ExcelTip.GridExcelTipStyleProperties(e.Style);
                style.ExcelTipText = Convert.ToString(this.comments[e.RowIndex - 1]);
                e.Handled = true;
            }
        }
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

    }
}
