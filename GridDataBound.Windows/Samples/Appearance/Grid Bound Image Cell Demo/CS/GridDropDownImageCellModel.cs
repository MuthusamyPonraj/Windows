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
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms.Grid;


namespace GridDataBoundImages
{
	public class GridDropDownImageCellModel: GridDropDownCellModel
    {
		protected GridDropDownImageCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
	
		}

        public GridDropDownImageCellModel(GridModel pGrid)
            : base(pGrid)
        {
        }
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new GridDropDownImageCellRenderer(control, this);
		}

    }
}
