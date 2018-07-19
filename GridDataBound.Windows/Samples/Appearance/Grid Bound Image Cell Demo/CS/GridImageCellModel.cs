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
using System.Runtime.Serialization;

using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;

namespace GridDataBoundImages
{
	/// <summary>
	/// Summary description for GridImageCellModel.
	/// </summary>
	public class GridImageCellModel : GridStaticCellModel
	{
		private GridImageCellDrawOption cellDrawOption;
		private int pictureBufferOffset;

		protected GridImageCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public GridImageCellModel(GridModel grid)
			: base(grid)
		{
			cellDrawOption = GridImageCellDrawOption.FitToCell;
			pictureBufferOffset = 78;
		}

		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new GridImageCellRenderer(control, this);
		}

		public GridImageCellDrawOption CellDrawOption
		{
			get{return cellDrawOption;}
			set{cellDrawOption = value;}
		}

		public int PictureBufferOffset
		{
			get{return pictureBufferOffset;}
			set{pictureBufferOffset = value;}
		}

	}

	public enum GridImageCellDrawOption
	{
		FitToCell      = 0,
		NoResize      = 1,
		FitProportionally = 2,
	};

}
