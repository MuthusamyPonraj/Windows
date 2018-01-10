#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.DataBinding;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram.Controls;

namespace DiagramORM.Sample
{
    class Program
    {
        [STAThread]
        static void Main( string[] args ) {
            Application.EnableVisualStyles();
            Application.Run( new Form1( ) );

        }
    }
}
