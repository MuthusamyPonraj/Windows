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
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Syncfusion.Diagnostics;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System.Collections.Generic;
using System.Data;

namespace ExcelTip
{

    #region the Mouse Controller
    /// <summary>
    /// Summary description for CommentMouseController.
    /// </summary>
    public class CommentMouseController : IMouseController
    {
        private const int redCornerSize = 10;
        private const int blackArrowSize = 5;

        private GridControlBase owner;
        private int lastHitTestCode = GridHitTestContext.None;
        private const int HitComment = 101;

        private GridCellComment commentWindow;
        private int cornerSize = 8;
        private Rectangle redrawRect = Rectangle.Empty;

        private Cursor cursor1;
        private int commentRow;
        private int commentCol;

        private bool contextMenuEnabled1;
        public bool ContextMenuEnabled
        {
            get { return contextMenuEnabled1; }
            set
            {
                if (value != contextMenuEnabled1)
                {
                    contextMenuEnabled1 = value;
                    if (contextMenuEnabled1)
                    {
                        owner.MouseUp += new MouseEventHandler(grid_ContextMouseUp);
                    }
                    else
                    {
                        owner.MouseUp -= new MouseEventHandler(grid_ContextMouseUp);
                    }
                }
            }
        }

        private Brush cornerBrush1;
        public Brush CornerBrush
        {
            get { return cornerBrush1; }
            set { cornerBrush1 = value; }
        }

        public int CommentCornerSize
        {
            get { return cornerSize; }
            set { cornerSize = value; }
        }
        DataTable dt = new DataTable();

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CommentMouseController()
        {
            
        }

        public CommentMouseController(GridControlBase owner)
        {
            dt.Columns.Add("Row");
            dt.Columns.Add("Col");
            dt.Columns.Add("Data");
            this.owner = owner;
            commentWindow = new GridCellComment();
            commentWindow.CommentCorner = new Size(0, 0);
            owner.Controls.Add(commentWindow);

            owner.CellDrawn += new GridDrawCellEventHandler(grid_CellDrawn);

            owner.TopRowChanging += new GridRowColIndexChangingEventHandler(grid_Scrolling);
            owner.LeftColChanging += new GridRowColIndexChangingEventHandler(grid_Scrolling);
            owner.MouseDown += new MouseEventHandler(grid_MouseDown);
            owner.Model.QueryCellInfo += new GridQueryCellInfoEventHandler(Model_QueryCellInfo);
            cornerBrush1 = Brushes.Red; //default color

            GridExcelTipStyleProperties.Initialize();
            
        }
        bool textChanged = false;
        void Model_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            GridExcelTipStyleProperties style = new GridExcelTipStyleProperties(e.Style);
            DataRow[] dr = dt.Select("Row=" + e.RowIndex + " and Col=" + e.ColIndex + "");
            if (dr.Length != 0)
                style.ExcelTipText = dr[0]["Data"].ToString();
            if (textChanged)
            {
                this.owner.RefreshRange(GridRangeInfo.Cell(e.RowIndex, e.ColIndex));
                textChanged = false;
            }
        }

        public string Name
        {
            get { return "Comment"; }
        }

        public Cursor Cursor
        {
            get
            {
                if (cursor1 == null)
                {
                    System.IO.Stream stream = commentWindow.GetType().Module.Assembly.GetManifestResourceStream("ExcelTip.cross.CUR");
                    if (stream != null)
                        cursor1 = new Cursor(stream);
                    else
                        cursor1 = Cursors.Cross;
                }
                else
                    cursor1 = Cursors.Default;

                // could check latestHitTestCode here if this controller has
                // different HitTest states. Cursor will only be called if 
                // previous call to HitTest was successfull.
                return cursor1;
            }
        }

        #region Context Menu Code

        private ContextMenu theContextMenu;
        private int rightClickRow, rightClickCol;
        private bool leftClickOnMark = false;
        private void grid_ContextMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || leftClickOnMark)
            {
                Point pt = new Point(e.X, e.Y);
                if (this.owner.PointToRowCol(pt, out rightClickRow, out rightClickCol))
                {
                    MenuItem menu;

                    if (isExcelTipCell(this.owner.Model[rightClickRow, rightClickCol]))
                    {
                        menu = new MenuItem("Remove Comment", new EventHandler(remove_Comment));
                        MenuItem menu1 = new MenuItem("Edit Comment", new EventHandler(edit_Comment));
                        theContextMenu = new ContextMenu(new MenuItem[] { menu, menu1 });
                    }
                    else
                    {
                        menu = new MenuItem("Add Comment", new EventHandler(add_Comment));
                        theContextMenu = new ContextMenu(new MenuItem[] { menu });
                    }

                    theContextMenu.Show(this.owner, pt);
                }
            }
            leftClickOnMark = false;
        }

        private void edit_Comment(object sender, EventArgs e)
        {
            StartEditing();
        }

        private void StartEditing()
        {
            GridExcelTipStyleProperties style = new GridExcelTipStyleProperties(owner.Model[rightClickRow, rightClickCol]);
            Point pt = this.owner.ViewLayout.ClientRowColToPoint(rightClickRow, rightClickCol, GridCellSizeKind.ActualSize);
            pt.X += this.owner.Model.ColWidths[rightClickCol];
            this.commentWindow.InitializeComment(rightClickRow, rightClickCol, pt, style);

            EditComment(rightClickRow, rightClickCol);
        }

        private void add_Comment(object sender, EventArgs e)
        {
            GridExcelTipStyleProperties style = new GridExcelTipStyleProperties(owner.Model[rightClickRow, rightClickCol]);
            style.ExcelTipText = "";
            StartEditing();
        }

        private void remove_Comment(object sender, EventArgs e)
        {
            GridExcelTipStyleProperties style = new GridExcelTipStyleProperties(owner.Model[rightClickRow, rightClickCol]);
            style.ResetExcelTipText();

            DataRow[] dr = dt.Select("Row=" + rightClickRow + " and Col=" + rightClickCol + "");
            if (dr.Length != 0)
            {
                int index = 0;
                foreach (DataRow drow in dt.Rows)
                {
                    if (drow.Equals(dr[0]))
                    {
                        dt.Rows[index].Delete();
                    }
                    index++;
                }
            }
            this.owner.Refresh();
        }
        #endregion

        #region Mouse Overrides
        public void MouseHoverEnter()
        {

        }

        //private bool inDraw = false;
        /// <summary>
        /// User is moving the mouse over the hot-test area
        /// </summary>
        /// <param name="e"></param>
        public void MouseHover(MouseEventArgs e)
        {
            if (!this.commentWindow.Visible)// && !inDraw)
            {


                //translate the point to top right corner...
                int rowIndex, colIndex;
                Point pt = new Point(e.X, e.Y);

                owner.PointToRowCol(pt, out rowIndex, out colIndex, -1);
                bool hidden;
                int clientRow = owner.ViewLayout.RowIndexToVisibleClient(rowIndex, out hidden);
                int clientCol = owner.ViewLayout.ColIndexToVisibleClient(colIndex, out hidden);
                pt = owner.ViewLayout.ClientRowColToPoint(clientRow, clientCol, GridCellSizeKind.ActualSize);

                pt.X += owner.Model.ColWidths[colIndex];

                GridExcelTipStyleProperties style = (GridExcelTipStyleProperties)owner.Model[rowIndex, colIndex];
                this.commentWindow.InitializeComment(rowIndex, colIndex, pt, style);
                Point ploc = this.commentWindow.Location;
                this.commentWindow.Location = new Point(10000, 10000);
                this.commentWindow.comment.Visible = true;
                this.commentWindow.editTextBox.Visible = false;

                //show the windows
                this.commentWindow.Show();
                this.commentWindow.Update();
                this.owner.Update();

                //draw the pointer
                Graphics g = Graphics.FromHwnd(this.owner.Handle);
                Point pt1 = new Point(pt.X + this.commentWindow.CommentCorner.Width, pt.Y - this.commentWindow.CommentCorner.Height);
                redrawRect = new Rectangle(pt.X, pt.Y - this.commentWindow.CommentCorner.Height, this.commentWindow.CommentCorner.Width + 1, this.commentWindow.CommentCorner.Height + 1);
                g.DrawLine(Pens.Black, pt, pt1);
                Point topLeft = new Point(pt.X, pt.Y - blackArrowSize + 1);
                Point bottomLeft = new Point(pt.X, pt.Y + 1);
                Point bottomRight = new Point(pt.X + blackArrowSize - 1, pt.Y + 1);
                g.FillPolygon(Brushes.Black, new Point[] { topLeft, bottomLeft, bottomRight, topLeft });
                g.Dispose();



                this.commentWindow.Location = ploc;
            }
        }

        /// <summary>
        /// Called when the hovering ends, either when user has moved mouse away from hittest area
        /// or when the user has pressed a mouse button.
        /// </summary>
        public void MouseHoverLeave(EventArgs e)
        {
            if (this.commentWindow.comment.Visible)
            {
                this.commentWindow.Hide();
                this.owner.Invalidate(redrawRect);
            }
        }

        public void MouseDown(MouseEventArgs e)
        {
        }

        /// <summary>
        /// User has dragged mouse. If mouse is down, set current position.
        /// </summary>
        /// <param name="e"></param>
        public void MouseMove(MouseEventArgs e)
        {

        }

        /// <summary>
        /// User has release mouse button. Stop automatic scrolling.
        /// </summary>
        /// <param name="e"></param>
        public void MouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftClickOnMark = true;
                grid_ContextMouseUp(owner, e);
            }            
        }

        #endregion

        public void CancelMode()
        {
            if (this.commentWindow.Visible)
            {
                this.commentWindow.Hide();
                this.owner.Invalidate(redrawRect);
            }
        }

        public int HitTest(MouseEventArgs e, IMouseController controller)
        {
            lastHitTestCode = GridHitTestContext.None;

            Point pt = new Point(e.X, e.Y);
            int rowIndex, colIndex;
            owner.PointToRowCol(pt, out rowIndex, out colIndex);
            Rectangle rect = GetCorner(rowIndex, colIndex);
            if (rect.Contains(pt) && !this.commentWindow.editTextBox.Visible)
            {
                GridStyleInfo style = owner.Model[rowIndex, colIndex];
                if (isExcelTipCell(style))
                {
                    lastHitTestCode = HitComment;
                }
            }

            return lastHitTestCode;
        }

        Rectangle GetCorner(int row, int col)
        {
            Rectangle bounds = owner.RangeInfoToRectangle(GridRangeInfo.Cell(row, col), GridRangeOptions.None);
            bounds = new Rectangle(bounds.X + bounds.Width - this.CommentCornerSize - 1, bounds.Y, this.CommentCornerSize, this.CommentCornerSize);
            bounds.Intersect(owner.ClientRectangle);
            return bounds;
        }

        private bool isExcelTipCell(GridStyleInfo style)
        {
            GridExcelTipStyleProperties style1 = new GridExcelTipStyleProperties(style);
            return style1.HasExcelTipText;
        }

        private void grid_CellDrawn(object sender, GridDrawCellEventArgs e)
        {
            if (isExcelTipCell(e.Style) && (!this.owner.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex)
                     || !this.owner.CurrentCell.IsEditing))
            {
                Point topLeft = new Point(e.Bounds.X + e.Bounds.Width - CommentCornerSize, e.Bounds.Y);
                Point topRight = new Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y);
                Point bottomRight = new Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y + CommentCornerSize);
                e.Graphics.FillPolygon(cornerBrush1, new Point[] { topLeft, topRight, bottomRight, topLeft });
            }
        }

        #region Comment Edit Code

        private void EditComment(int row, int col)
        {
            commentRow = row;
            commentCol = col;

            Point pt = this.commentWindow.comment.Location;
            pt.Offset(5, 5);
            this.commentWindow.editTextBox.Location = pt;

            this.commentWindow.editTextBox.Size = this.commentWindow.comment.Size - new Size(5, 5);

            this.commentWindow.comment.Hide();

            //make sure there is space for some more lines...
            int diff = Math.Max(this.commentWindow.Height, 60) - this.commentWindow.Height;
            if (diff > 0)
            {
                this.commentWindow.Height += diff;
                this.commentWindow.editTextBox.Height += diff;
            }

            //make wide enough
            this.commentWindow.editTextBox.Width = Math.Max(this.commentWindow.Width - 10, this.commentWindow.editTextBox.Width);

            this.commentWindow.editTextBox.Show();
            this.commentWindow.ActiveControl = this.commentWindow.editTextBox;
           
            commentWindow.Leave += new EventHandler(textBox_Leave);
            commentWindow.editTextBox.TextChanged += new EventHandler(textbox_Changed);


            this.commentWindow.Show();
            this.commentWindow.editTextBox.Focus();
            this.owner.WantKeys = false;
        }


        private void textBox_Leave(object sender, EventArgs e)
        {
            if (this.commentWindow.editTextBox.Modified)
            {
                GridExcelTipStyleProperties style = new GridExcelTipStyleProperties(owner.Model[commentRow, commentCol]);
                style.ExcelTipText = this.commentWindow.editTextBox.Text;

                DataRow[] dr = dt.Select("Row=" + commentRow + " and Col=" + commentCol + "");
                if (dr.Length != 0)
                {
                    int index = 0;
                   foreach (DataRow drow in dt.Rows)
                {
                    if (drow.Equals(dr[0]))
                    {
                        dt.Rows[index].Delete();
                    }
                    index++;
                }               
                }
                dt.Rows.Add(commentRow, commentCol, this.commentWindow.editTextBox.Text);    
                dt.AcceptChanges();
                this.commentWindow.editTextBox.Modified = false;
                textChanged = true;
            }

            commentWindow.Leave -= new EventHandler(textBox_Leave);
            commentWindow.editTextBox.TextChanged -= new EventHandler(textbox_Changed);

            this.commentWindow.editTextBox.Hide();
            this.commentWindow.Hide();
            this.owner.Refresh();//.Invalidate(redrawRect);
            this.owner.WantKeys = true;
        }
        private void textbox_Changed(object sender, EventArgs e)
        {
            this.commentWindow.editTextBox.Modified = true;
        }

        private void grid_Scrolling(object sender, GridRowColIndexChangingEventArgs e)
        {
            this.CancelMode();
        }

        private void grid_MouseDown(object sender, MouseEventArgs e)
        {
            int rowIndex, colIndex;
            owner.PointToRowCol(new Point(e.X, e.Y), out rowIndex, out colIndex);
            if ((rowIndex != this.commentRow || colIndex != this.commentRow)
                            && this.commentWindow.editTextBox.Visible)
                textBox_Leave(sender, e);
        }

        #endregion


    }

    #endregion

    #region customstyle property

    public class GridExcelTipStyleProperties : GridStyleInfoCustomProperties
    {
        // static initialization of property descriptors
        static Type t = typeof(GridExcelTipStyleProperties);

        readonly static StyleInfoProperty ExcelTipTextProperty = CreateStyleInfoProperty(t, "ExcelTipText");

        // default settings for all properties this object holds
        static GridExcelTipStyleProperties defaultObject;

        // initialize default settings for all properties in static ctor
        static GridExcelTipStyleProperties()
        {
            // all properties must be initialized for the Default property
            defaultObject = new GridExcelTipStyleProperties(GridStyleInfo.Default);
            defaultObject.ExcelTipText = "";
        }

        /// <summary>
        /// Provides access to default values for this type
        /// </summary>
        public static GridExcelTipStyleProperties Default
        {
            get
            {
                return defaultObject;
            }
        }

        /// <summary>
        /// Force static ctor being called at least once
        /// </summary>
        public static void Initialize()
        {
        }

        // explicit cast from GridStyleInfo to GridExcelTipStyleProperties
        // (Note: this will only work for C#, Visual Basic does not support dynamic casts)

        /// <summary>
        /// Explicit cast from GridStyleInfo to this custom propety object
        /// </summary>
        /// <returns>A new custom properties object.</returns>
        public static explicit operator GridExcelTipStyleProperties(GridStyleInfo style)
        {
            return new GridExcelTipStyleProperties(style);
        }

        /// <summary>
        /// Initializes a GridExcelTipStyleProperties object with a style object that holds all data
        /// </summary>
        public GridExcelTipStyleProperties(GridStyleInfo style)
            : base(style)
        {
        }

        /// <summary>
        /// Initializes a GridExcelTipStyleProperties object with an empty style object. Design
        /// time environment will use this ctor and later copy the values to a style object
        /// by calling style.CustomProperties.Add(gridExcelTipStyleProperties1)
        /// </summary>
        public GridExcelTipStyleProperties()
            : base()
        {
        }

        /// <summary>
        /// Gets or sets ExcelTipText state
        /// </summary>
        [
        Description("Provides the ExcelTipText for this cell"),
        Browsable(true),
        Category("StyleCategoryBehavior")
        ]
        public string ExcelTipText
        {
            get
            {

                return (string)style.GetValue(ExcelTipTextProperty);
            }
            set
            {

                style.SetValue(ExcelTipTextProperty, value);
            }
        }
        /// <summary>
        /// Resets ExcelTipText state
        /// </summary>
        public void ResetExcelTipText()
        {
            style.ResetValue(ExcelTipTextProperty);
        }
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        private bool ShouldSerializeExcelTipText()
        {
            return style.HasValue(ExcelTipTextProperty);
        }
        /// <summary>
        /// Gets if ExcelTipText state has been initialized for the current object.
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool HasExcelTipText
        {
            get
            {
                return style.HasValue(ExcelTipTextProperty);
            }
        }
    }
    #endregion
}