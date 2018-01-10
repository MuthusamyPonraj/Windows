#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Collections;
using System.IO;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using Syncfusion.Drawing;

namespace MultiColumnTreeViewDemo
{
    public partial class MainForm : MetroForm
    {
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv1;
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv2;
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv3;

        public MainForm()
        {
            InitializeComponent();

            TreeNodeAdv root = new TreeNodeAdv();
            DriveInfo drive = new DriveInfo(Environment.SystemDirectory);
            root.Text = drive.ToString();
            this.multiColumnTreeView1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv[] {
            root});

            treeColumnAdv1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            treeColumnAdv2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            treeColumnAdv3 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();

            treeColumnAdv1.HelpText = "Name";
            treeColumnAdv1.Highlighted = false;
            treeColumnAdv1.Text = "Name";
            treeColumnAdv1.Width = 320;
            treeColumnAdv1.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.Highlight);
            treeColumnAdv1.AreaBackground = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.White, System.Drawing.Color.Snow);
            treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv2.HelpText = "Full Path";
            treeColumnAdv2.Highlighted = false;
            treeColumnAdv2.Text = "Full Path";
            treeColumnAdv2.Width = 260;
            treeColumnAdv2.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.Highlight);
            treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv3.HelpText = "Date Modified";
            treeColumnAdv3.Highlighted = false;
            treeColumnAdv3.Text = "Date Modified";
            treeColumnAdv3.Width = 150;
            treeColumnAdv3.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.Highlight);
            treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;

            this.multiColumnTreeView1.Columns.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv[]{
                treeColumnAdv1,treeColumnAdv2,treeColumnAdv3});

            this.Load += new EventHandler(MultiColumnTreeViewDemo_Load);
            this.multiColumnTreeView1.BeforeExpand += new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeViewAdvCancelableNodeEventHandler(multiColumnTreeView1_BeforeExpand);
            this.MinimumSize = this.Size;
            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


        }
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

        void MultiColumnTreeViewDemo_Load(object sender, EventArgs e)
        {
            this.multiColumnTreeView1.Nodes[0].Expanded = true;
        }

        void multiColumnTreeView1_BeforeExpand(object sender, Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeViewAdvCancelableNodeEventArgs e)
        {
            try
            {
                //Checking whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                DirectoryInfo dir = null;
                DirectoryInfo[] subDir = null;
                if (this.multiColumnTreeView1.Nodes[0].Nodes.Count == 0) //Root directory
                {
                    DriveInfo drive = new DriveInfo(e.Node.Text);
                    dir = drive.RootDirectory;

                    subDir = dir.GetDirectories();
                }

                else
                {
                    //Get the Path of the node and AddSeparatorAtEnd Property set to true
                    string path = e.Node.GetPath("\\");

                    dir = new DirectoryInfo(path);
                    subDir = dir.GetDirectories();
                }

                if (subDir != null)
                {
                    foreach (DirectoryInfo dirinfo in subDir)
                    {
                        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem subitem1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem();
                        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem subitem2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem();

                        subitem1.Text = dirinfo.FullName;
                        subitem1.HelpText = subitem1.Text;

                        subitem2.Text = dirinfo.LastWriteTime.ToString();
                        subitem2.HelpText = subitem2.Text;

                        TreeNodeAdv node = new TreeNodeAdv(dirinfo.Name);

                        node.SubItems.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem[]{
                            subitem1,subitem2});
                        e.Node.Nodes.Add(node);
                    }
                }
            }
            catch { }
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.treeColumnAdv1.HighlightBorderColor = this.colorPickerButton3.SelectedColor;
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.treeColumnAdv2.HighlightBorderColor = this.colorPickerButton2.SelectedColor;
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.treeColumnAdv3.HighlightBorderColor = this.colorPickerButton1.SelectedColor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}