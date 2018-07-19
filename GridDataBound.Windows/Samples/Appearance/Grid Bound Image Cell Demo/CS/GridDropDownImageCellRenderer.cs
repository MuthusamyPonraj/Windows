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
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;

using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace GridDataBoundImages
{
	/// <summary>
	/// Summary description for DropDownImageCellRenderer.
	/// </summary>
	public class GridDropDownImageCellRenderer: GridDropDownCellRenderer
    {
        System.Windows.Forms.PictureBox pictureBox;
		private int pictureWidth;
		private int pictureHeight;
		private Image picImage;

		public GridDropDownImageCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
        {
			DropDownButton = new GridCellComboBoxButton(this);
        }


        protected override void InitializeDropDownContainer()
        {
            base.InitializeDropDownContainer();

			pictureBox = new PictureBox();
			pictureBox.Dock = DockStyle.Fill;
			pictureBox.BorderStyle = BorderStyle.Fixed3D;
			pictureBox.Visible = true;
			pictureBox.Image = this.picImage;
			DropDownContainer.Controls.Add(pictureBox);
			pictureBox.Focus();
        }

		public void PictureBoxKeyDown(object sender, KeyEventArgs e)
		{
    		CurrentCell.CloseDropDown(PopupCloseType.Done);
		}

        public override void DropDownContainerShowingDropDown(object sender, CancelEventArgs e)
        {
			this.DropDownContainer.PopupHost.FormBorderStyle = FormBorderStyle.Sizable;
			this.DropDownContainer.Dock = DockStyle.Fill;
			this.DropDownContainer.PopupHost.Width = this.pictureWidth;
            this.DropDownContainer.PopupHost.Height = this.pictureHeight;
			this.DropDownContainer.IgnoreDialogKey = true;
			
            base.DropDownContainerShowingDropDown(sender, e);
        }

        public override void DropDownContainerShowedDropDown(object sender, EventArgs e)
        {
			//this.pictureBox.Focus();
		}

		public override void DropDownContainerCloseDropDown(object sender, PopupClosedEventArgs e)  
		{
			if (e.PopupCloseType == PopupCloseType.Done)
			{
			//nothing...
			}
			this.DropDownContainer.Dock = DockStyle.None;
			this.DropDownContainer.IgnoreDialogKey = false;
			base.DropDownContainerCloseDropDown(sender, e);
		}

		

		protected override void OnDraw(Graphics g, Rectangle clientRectangle, int rowIndex, int colIndex, GridStyleInfo style) 
		{
		//	base.OnDraw(g, clientRectangle, rowIndex, colIndex, style);
			
		//	this.DrawBackground(g, clientRectangle, style, true);
		}

		

		protected override void OnInitialize(int rowIndex, int colIndex)
		{
			GridStyleInfo style = Grid.Model[rowIndex, colIndex];
			Byte[] pict = style.CellValue as Byte[];
				if(pict != null)
				{
					int PictOffSet = 78;//((GridImageCellModel)this.Model).PictureBufferOffset;

					MemoryStream buffer = new MemoryStream(pict, PictOffSet, pict.Length - PictOffSet);
					this.picImage = Image.FromStream(buffer, true);

					System.Drawing.GraphicsUnit gu = System.Drawing.GraphicsUnit.Point;
					
					RectangleF srcRect = this.picImage.GetBounds(ref gu);
					this.pictureWidth = (int) srcRect.Width;
					this.pictureHeight = (int) srcRect.Height;
					if(this.pictureBox != null)
						pictureBox.Image = this.picImage;
				}
		}
    }
}
