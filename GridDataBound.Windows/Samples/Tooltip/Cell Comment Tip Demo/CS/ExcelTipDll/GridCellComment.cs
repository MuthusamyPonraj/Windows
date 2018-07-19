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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Security.Permissions;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Diagnostics;

namespace ExcelTip
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class GridCellComment : System.Windows.Forms.Form
	{
		internal Label comment;
		internal RichTextBox editTextBox;
		private int dx = 10;
		private int dy = 10;


		public string CommentText 
		{
			get{return comment.Text;}
			set{comment.Text = value;
			editTextBox.Text = value;}
		}

		public Font CommentFont 
		{
			get{return comment.Font;}
			set{comment.Font = value;}
		}

		public Size CommentCorner
		{
			get{return new Size(dx, dy);}
			set{dx = value.Width; dy = value.Height;}
		}
		
		private int minCommentWidth = 80;
		private int minCommentHeight = 18;

		public GridCellComment()
		{
			int width = minCommentWidth;
			int height = minCommentHeight;

			this.comment = new System.Windows.Forms.Label();
			this.editTextBox = new RichTextBox();
			this.editTextBox.Visible = false;
			this.editTextBox.Multiline = true;
			this.editTextBox.BorderStyle = BorderStyle.None;

			this.SuspendLayout();
			// 
			// comment
			// 
			this.comment.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.comment.Location = new System.Drawing.Point(dx, dy);
			this.comment.Name = "comment";
			this.comment.Size = new System.Drawing.Size(width - 2 * dx, height - 2 * dy);
			this.comment.TabIndex = 0;
			this.comment.Text = "Author:";
			this.comment.Font = new Font(this.Font, FontStyle.Bold);
			this.comment.Dock = DockStyle.Fill;
			
			
			// 
			// GridCellComment
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(width, height);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.comment,
																		  this.editTextBox});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "GridCellComment";
			this.ResumeLayout(false);
			this.CausesValidation = false;
			this.Visible = false;
			this.TopLevel = false;
			

			System.Drawing.Drawing2D.GraphicsPath myGraphicsPath  = new
				System.Drawing.Drawing2D.GraphicsPath();
			
            Point[] points = new Point[]{new Point(0, dy), new Point(0, height - dy), 
											new Point(dx, height), new Point(width - dx, height),
											new Point(width, height - dy), new Point(width , dy),
											new Point(width - dx, 0), new Point(dx , 0),
											new Point(0, dy)};
			myGraphicsPath.AddPolygon(points);
			
			
			BackColor = SystemColors.Info;


			dx = 10;
			dy = 10;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				
			}
			base.Dispose( disposing );
		}

		
		private void Form1_Load(object sender, System.EventArgs e)
		{
		}

		public void InitializeComment(int row, int col, Point pt, GridExcelTipStyleProperties style)
		{
			int xPad = 15;
			int yPad = 5;
			int dy1 = 10;
			int dx1 = 10;

			if(row == 0)
			{
				dy1 = 0;
			}

			CommentCorner = new Size(dx1, dy1);

			Point panelPoint = new Point((int) .5 * dy1, yPad);

			this.CommentText = style.ExcelTipText as string;

			pt.Offset(dx1, - dy1);
			this.Location = pt;

			Graphics g = Graphics.FromHwnd(this.Handle);
			SizeF sz = g.MeasureString(this.CommentText, this.Font);
			int height = (int)(2 * yPad + sz.Height ); //10 is fudge
			int width = (int)(2 * xPad  + sz.Width );

			this.Size = new Size(Math.Max(width, minCommentWidth), Math.Max(height, minCommentHeight));

			this.comment.Location = panelPoint;
			this.comment.Size = new Size(width - 2 * panelPoint.X, height - 2 * panelPoint.Y);
		}

		
	}

}
