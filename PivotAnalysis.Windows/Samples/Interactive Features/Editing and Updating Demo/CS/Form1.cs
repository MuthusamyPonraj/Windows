#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Threading;
using System.IO;
using DemoCommon.Grid;

namespace EditingDemo
{
    public partial class Form1 : GridDemoForm
    {
        #region API Definition
        private ProductSales.ProductSalesCollection _productSalesData = ProductSales.GetSalesData();
        DispatcherTimer timer = null;
        int updateRate = 200; //msecs
        int updateCount = 20; //updates per tick event
        private Random rand = new Random(123123);
        #endregion;

        #region "Window Updates"

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);

        #endregion

        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            this.PivotGridSettings();
            SampleCustomization();
        }

        #endregion

        #region "Pivot Grid Settings"
        /// <summary>
        /// Pivot Grid Settings for populating the Pivot Rows and Columns
        /// </summary>
        private void PivotGridSettings()
        {

            this.pivotGridControl1.ItemSource = _productSalesData;// ProductSales.GetSalesData();

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "C", SummaryType = SummaryType.DoubleTotalSum });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            //tab key navigation set as false to move the next control
            this.pivotGridControl1.TableControl.WantTabKey = false;
        }

        #endregion

        #region "Sample Customization"
        /// <summary>
        /// The Grid Settings can be Customized
        /// </summary>        
        private void SampleCustomization()
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            this.pivotGridControl1.ShowGroupBar = true;  
        }

        #region "Events"

        //refresh the pivotgrid
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.Refresh();
        }

        //enables the editing values
        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.pivotGridControl1.EnableValueEditing = true;
                this.pivotGridControl1.EditManager.HideExpanders = true;
            }
            else
            {
                if (this.pivotGridControl1.EnableValueEditing)
                    this.pivotGridControl1.EditManager.HideExpanders = false;
            }
            pivotGridControl1.TableControl.Refresh();
        }

        //allow the editmanager to editing the total cells
        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
                this.pivotGridControl1.EditManager.AllowEditingOfTotalCells = true;
            else
                this.pivotGridControl1.EditManager.AllowEditingOfTotalCells = false;
            pivotGridControl1.TableControl.Refresh();
        }

        //enables and disables the checkboxes 
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.checkBoxAdv2.Checked = true;
                this.checkBoxAdv3.Enabled = true;
            }
            else
            {
                this.checkBoxAdv2.Checked = false;
                this.checkBoxAdv3.Enabled = false;
            }
            pivotGridControl1.TableControl.Refresh();
        }

        //Enabling and Disabling the Editing mode of Pivot grid
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv2.Checked)
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                this.pivotGridControl1.EnableValueEditing = true;
                this.pivotGridControl1.EnableUpdating = true;
            }
            else
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                if (checkBox2.Checked)
                    checkBox2.Checked = false;
                if (checkBox3.Checked)
                    checkBox3.Checked = false;
                this.pivotGridControl1.EnableValueEditing = false;
                this.pivotGridControl1.EnableUpdating = true;
            }
            pivotGridControl1.TableControl.Refresh();
        }

       
        /// <summary>
        ///Set the timer to activate the PivotGrid update
        /// </summary>
        private void DoTimerActivate(bool yes)
        {
            if (yes)
            {                
                timer = new DispatcherTimer();
                timer.Tick += new EventHandler(timer_Tick);
                timer.Interval = TimeSpan.FromMilliseconds(updateRate);
                this.pivotGridControl1.UpdateManager.ThrottleUpdateRate = 500;
                timer.Start();
            }
            else
            {
                DisposeTimer();                              
            }
        }

        /// <summary>
        /// To stop the timer with efficient manner
        /// </summary>
        private void DisposeTimer()
        {
            timer.Stop();
            this.Invoke((MethodInvoker)delegate
            {
                timer = null;

            });  
        }
        /// <summary>
        ///Update the items source from the ProductSalesCollection
        /// </summary>
        /// <param name="loc"></param>
        private void UpdateItemsSource(string loc)
        {
            ProductSales dr = null;
            switch (loc)
            {
                case "Add at Top":
                    dr = new ProductSales()
                    {
                        Country = "Canada",
                        State = "Brunswick",
                        Product = "Bike",
                        Date = "FY 2003",
                        Quantity = 1,
                        Amount = 100d
                    };
                    break;
                case "Add at Middle":
                    dr = new ProductSales()
                    {
                        Country = "Canada",
                        State = "Brunswick",
                        Product = "Bike",
                        Date = "FY 2007",
                        Quantity = 1,
                        Amount = 200d
                    };
                    break;
                case "Add at Bottom":
                    dr = new ProductSales()
                    {
                        Country = "Canada",
                        State = "Brunswick",
                        Product = "Bike",
                        Date = "FY 2010",
                        Quantity = 1,
                        Amount = 300d
                    };
                    break;
            }
            _productSalesData.Add(dr);
            this.pivotGridControl1.Refresh(true);
        }

        /// <summary>
        /// Set the timer value
        /// </summary>
        void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < updateCount; ++i)
            {
                ChangeOneValue(1);
            }
        }
        private void ChangeOneValue(int loc)
        {
            double old = (double)_productSalesData[loc].Amount;
            _productSalesData[loc].Amount = rand.Next(1000);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateItemsSource("Add at Top");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateItemsSource("Add at Middle");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateItemsSource("Add at Bottom");
        }

        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv3.Checked)
            {

                if (this.pivotGridControl1.EnableUpdating)
                    DoTimerActivate(true);
            }
            else
            {
                DoTimerActivate(false);
            }
        }

        #endregion

        #endregion
       
    }
}
