#region Copyright Syncfusion Inc. 2001 - 2008
//
//  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using System.Data.EntityClient;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using Entity_Framework;

namespace Entity_FrameWork
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Office2007Form
    {
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
            catch
            {
            }
        }

        /// <summary>
        /// Get the path of the icon file.
        /// </summary>
        /// <param name="bitmapName">IconFile name.</param>
        /// <returns>Icon file location.</returns>
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

        /// <summary>
        /// Create a method for exit in file menuitem.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Get the customer table from NorthWind database.
        /// </summary>
        /// <returns>Customers details.</returns>
        private IQueryable<Customers> GetAllCustomers()
        {
            var customers = from c in db.Customers
                            select c;
            return customers;
        }

        NorthwindGridEntities db;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Get the path of the connecting databse.
            string conString = "Data Source=" + FindFile("NorthwindwithImage.sdf");
            
            try
            {
                //Create a connection object for entity connection.
                EntityConnection con = new EntityConnection("name=NorthwindGridEntities");
                con.StoreConnection.ConnectionString = conString;
                db = new NorthwindGridEntities(con);
                this.gridDataBoundGrid1.DataSource = db.Customers;
                this.gridDataBoundGrid1.Binder.EnableAddNew = false;
            }
            catch (SqlException)
            {
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in Connection. " + err.Message);
                Application.Exit();
            }
            int colcount = this.gridDataBoundGrid1.Model.ColCount;
            this.gridDataBoundGrid1.Model.HideCols[colcount - 1] = true;
            this.gridDataBoundGrid1.Model.HideCols[colcount] = true;
            this.gridDataBoundGrid1.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(gridDataBoundGrid1_PrepareViewStyleInfo);
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.SingleClick;
        }

        /// <summary>
        /// To set the backcolor of the grid.
        /// </summary>
        void gridDataBoundGrid1_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
        {
            if (e.RowIndex > 0 && e.RowIndex % 2 == 0)
            {
                e.Style.BackColor = Color.PaleTurquoise;
            }
        }

        /// <summary>
        /// Get the path of image file.
        /// </summary>
        /// <param name="bitmapName">ImageFile name.</param>
        /// <returns>ImageFile location.</returns>
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;            
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }
            return fileName;
        }
    }
}