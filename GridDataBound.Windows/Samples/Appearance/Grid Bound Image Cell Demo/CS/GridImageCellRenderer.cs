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
using System.IO;

using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;


namespace GridDataBoundImages
{
	/// <summary>
	/// Summary description for GridImageCellRenderer.
	/// </summary>
	public class GridImageCellRenderer : GridStaticCellRenderer
	{
		public GridImageCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
	{
		
	}

		protected override void OnDraw(System.Drawing.Graphics g, System.Drawing.Rectangle clientRectangle, int rowIndex, int colIndex, Syncfusion.Windows.Forms.Grid.GridStyleInfo style)
		{
			if (clientRectangle.IsEmpty)
				return;
			
			try
			{
				Byte[] pict = style.CellValue as Byte[];
				if(pict != null)
				{
					int PictOffSet = ((GridImageCellModel)this.Model).PictureBufferOffset;

					MemoryStream buffer = new MemoryStream(pict, PictOffSet, pict.Length - PictOffSet);
					Image image = Image.FromStream(buffer, true);

					GridImageCellDrawOption cellDrawOption = ((GridImageCellModel)this.Model).CellDrawOption;
					System.Drawing.GraphicsUnit gu = System.Drawing.GraphicsUnit.Point;
					
					RectangleF srcRect = image.GetBounds(ref gu);
					Rectangle destRect = Rectangle.Empty;

					Region saveRegion = g.Clip;

					switch(cellDrawOption)
					{
						case GridImageCellDrawOption.FitToCell:
							destRect = clientRectangle;
							break;
						case GridImageCellDrawOption.NoResize:
							destRect = new Rectangle(clientRectangle.X, clientRectangle.Y, (int) srcRect.Width, (int) srcRect.Height);
							g.Clip = new Region(clientRectangle);
							break;
						case GridImageCellDrawOption.FitProportionally:
						{
							float srcRatio =  srcRect.Width / srcRect.Height;
							float tarRatio = (float) clientRectangle.Width / clientRectangle.Height;
							destRect = clientRectangle;
							if( tarRatio < srcRatio )
							{
								destRect.Height = (int) (destRect.Width * srcRatio);	
							}
							else
							{
								destRect.Width = (int) (destRect.Height * srcRatio);
							}
						}
							break;
						
						default:
							break;
					}

					if(!destRect.IsEmpty)
						g.DrawImage(image,  destRect, srcRect, gu);

					g.Clip = saveRegion;
//					if(cellDrawOption == GridImageCellDrawOption.FitToCell)
//						g.DrawImage(image, clientRectangle);
//					else if(cellDrawOption == GridImageCellDrawOption.NoResize)
//					{
//						RectangleF srcRect = image.GetBounds(ref gu);
//						Rectangle destRect = new Rectangle(clientRectangle.X, clientRectangle.Y, (int) srcRect.Width, (int) srcRect.Height);
//						g.DrawImage(image,  destRect, srcRect, gu);
//					}
				}
			}
			catch{}
			
		}
	}
}
