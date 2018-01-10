#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
//using PivotUpdating.Model;
//using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Threading;
using System;
using System.ComponentModel;

namespace EditingDemo
{
    public class ViewModel 
    {
        DispatcherTimer timer = null;
        int updateRate = 200; //msecs
        int updateCount = 20; //updates per tick event
        private Random rand = new Random(123123);

        #region Properties
        private ProductSales.ProductSalesCollection _productSalesData;

        /// <summary>
        /// Gets or sets the product sales data.
        /// </summary>
        /// <value>The product sales data.</value>
        public ProductSales.ProductSalesCollection ProductSalesData
        {
            get
            {
                _productSalesData = _productSalesData ?? ProductSales.GetSalesData();
                return _productSalesData;
            }
            set
            {
                _productSalesData = value;
            }
        }

     
        public List<int> ThrottleUpdateRates
        {
            get
            {
                return new List<int> { 0, 300, 500, 1000, 2000 };
            }
        }

      

        #endregion

        #region Helper Methods

        private void DoTimerActivate(object parm)
        {
            if (parm is bool)
            {
                if (timer == null)
                {
                    timer = new DispatcherTimer();
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Interval = TimeSpan.FromMilliseconds(updateRate);
                }

                if ((bool)parm)
                {
                    timer.Start();
                }
                else
                {
                    timer.Stop();
                }
            }
        }

        private void UpdateItemsSource(object parm)
        {
            ProductSales dr = null;
            switch (parm.ToString())
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
        }

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
        #endregion

    }
}
