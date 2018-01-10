#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace ComboDropDownDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.Tools.ComboDropDown comboDropDown1;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeView1;
		private Syncfusion.Windows.Forms.Grid.GridListControl gridListControl1;
		private Syncfusion.Windows.Forms.Tools.ComboDropDown comboDropDown2;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Label label19;
        private Label label3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Label label5;
        private BannerTextProvider bannerTextProvider1;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit bannerClrEdit;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Label label8;
        private Label label9;
        private Label label10;
        private RadioButtonAdv rdoEdit;
        private RadioButtonAdv rdoFocus;
        private TextBoxExt txtBanner;
        private ButtonAdv btnSetBanner;
        private ColorDialog colorDialog1;
        private GradientPanel gradientPanel1;
        private SplitContainerAdv splitContainerAdv1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            autoLabel2.Visible = comboBoxAdv2.Visible = false;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            comboBoxAdv1.SelectedIndex = 6;
            this.treeView1.ShouldSelectNodeOnEnter = false;


            this.treeView1.AfterSelect += new EventHandler(treeView1_AfterSelect);

            this.gridListControl1.Grid.CellClick += new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(Grid_CellClick);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.treeView1.ExpandAll();
            this.MinimumSize = this.Size;
			
			#region GridList
			ArrayList USStates = new ArrayList()   ;
			USStates.Add(new USState("Alaska", "AK", 1));
			USStates.Add(new USState("Arizona", "AZ", 2));
			USStates.Add(new USState("Arkansas", "AK", 3));
			USStates.Add(new USState("California", "CA", 4));
			USStates.Add(new USState("Colorado", "CO", 5));
			USStates.Add(new USState("Connecticut", "CT", 6));
			USStates.Add(new USState("Delaware", "DE", 3));
			USStates.Add(new USState("Florida", "FL", 4));
			USStates.Add(new USState("Georgia", "GA", 1));
			USStates.Add(new USState("Hawaii", "HI", 0));
			USStates.Add(new USState("Idaho", "ID", 3));
			USStates.Add(new USState("Illinois", "IL", 2));
			USStates.Add(new USState("Indiana", "IN", 6));
			USStates.Add(new USState("Iowa", "IA", 5));
			USStates.Add(new USState("Kansas", "KA", 5));
			USStates.Add(new USState("Kentucky", "KY", 4));
			USStates.Add(new USState("Louisiana", "LA", 3));
			USStates.Add(new USState("Maine", "ME", 0));
			USStates.Add(new USState("Maryland", "MD", 0));
			USStates.Add(new USState("Massachusetts", "MA", 2));
			USStates.Add(new USState("Michigan", "MI", 1));
			USStates.Add(new USState("Minnesota", "MN", 6));
			USStates.Add(new USState("Mississippi", "MS", 5));
			USStates.Add(new USState("Missouri", "MO", 2));
			USStates.Add(new USState("Montana", "MT", 1));
			USStates.Add(new USState("Nebraska", "NE", 4));
			USStates.Add(new USState("Nevada", "NV", 0));
			USStates.Add(new USState("New Hampshire", "NH", 3));
			USStates.Add(new USState("New Jersey", "NJ", 3));
			USStates.Add(new USState("New Mexico", "NM", 2));
			USStates.Add(new USState("New York", "NY", 5));
			USStates.Add(new USState("North Carolina", "NC", 4));
			USStates.Add(new USState("North Dakota", "ND", 4));
			USStates.Add(new USState("Ohio", "OH", 1));
			USStates.Add(new USState("Oklahoma", "OK", 2));
			USStates.Add(new USState("Oregon", "OR", 5));
			USStates.Add(new USState("Pennsylvania", "PA", 0));
			USStates.Add(new USState("Rhode Island", "RI", 6));
			USStates.Add(new USState("South Carolina", "SC", 5));
			USStates.Add(new USState("South Dakota", "SD", 4));
			USStates.Add(new USState("Tennessee", "TN", 3));
			USStates.Add(new USState("Texas", "TX", 2));
			USStates.Add(new USState("Utah", "UT", 0));
			USStates.Add(new USState("Vermont", "VT", 1));
			USStates.Add(new USState("Virginia", "VA", 0));
			USStates.Add(new USState("Washington", "WA", 2));
			USStates.Add(new USState("West Virginia", "WV", 0));
			USStates.Add(new USState("Wisconsin", "WI", 3));
			USStates.Add(new USState("Wyoming", "WY", 5));

			
			ImageList imageList2 = new ImageList();
			imageList2.ImageSize = new Size(15, 15);
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\add2.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\bug_green.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\star_blue.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\navigate_check.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\jar_bean_delete.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\console.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\delete2.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\layout_horizontal.png"));

			this.gridListControl1.ImageList = imageList2;

			
			this.gridListControl1.BeginUpdate();
			this.gridListControl1.DataSource = USStates ;
			this.gridListControl1.DisplayMember  = "LongName"     ;
			this.gridListControl1.ValueMember = "ShortName" ;
			this.gridListControl1.MultiColumn = true;
			this.gridListControl1.ShowColumnHeader = true;
			this.gridListControl1.SelectionMode = SelectionMode.One;
			this.gridListControl1.ThemesEnabled = true;
			this.gridListControl1.Grid.VerticalThumbTrack = true;			
			
			
			
			this.gridListControl1.FillLastColumn = true;
			this.gridListControl1.EndUpdate();

			#endregion
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

        void treeView1_AfterSelect(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode != null)
                // Set the combo's text to be the TreeNode's Text.
                this.comboDropDown1.Text = this.treeView1.SelectedNode.Text;
            else
                this.comboDropDown1.Text = String.Empty;

            // Close the dropdown.
            this.comboDropDown1.PopupContainer.HidePopup(PopupCloseType.Done);
        }       

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv7 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv8 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv9 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv10 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv11 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.comboDropDown1 = new Syncfusion.Windows.Forms.Tools.ComboDropDown();
            this.treeView1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboDropDown2 = new Syncfusion.Windows.Forms.Tools.ComboDropDown();
            this.gridListControl1 = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.bannerClrEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdoEdit = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rdoFocus = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.txtBanner = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSetBanner = new Syncfusion.Windows.Forms.ButtonAdv();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).BeginInit();
            this.bannerClrEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboDropDown1
            // 
            this.comboDropDown1.BackColor = System.Drawing.Color.White;
            bannerTextInfo1.Text = "[Select]";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.comboDropDown1, bannerTextInfo1);
            this.comboDropDown1.Location = new System.Drawing.Point(59, 113);
            this.comboDropDown1.Name = "comboDropDown1";
            this.comboDropDown1.PopupControl = this.treeView1;
            this.comboDropDown1.Size = new System.Drawing.Size(175, 21);
            this.comboDropDown1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboDropDown1.TabIndex = 0;
            this.comboDropDown1.DropDown += new System.EventHandler(this.comboDropDown1_DropDown);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeView1.CanSelectDisabledNode = false;
            this.treeView1.DpiAware = false;
            // 
            // 
            // 
            this.treeView1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeView1.HelpTextControl.Name = "helpText";
            this.treeView1.HelpTextControl.TabIndex = 0;
            this.treeView1.HideSelection = false;
            this.treeView1.HotTracking = true;
            this.treeView1.ItemHeight = 34;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(701, 117);
            this.treeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeView1.Name = "treeView1";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "Node1";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2});
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Node0";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "Node10";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv5.Optioned = true;
            treeNodeAdv5.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "Node3";
            treeNodeAdv4.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv5});
            treeNodeAdv4.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "Node2";
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv7.Optioned = true;
            treeNodeAdv7.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "Node5";
            treeNodeAdv6.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv7});
            treeNodeAdv6.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "Node4";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.Optioned = true;
            treeNodeAdv9.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Node7";
            treeNodeAdv8.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv9});
            treeNodeAdv8.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Node6";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv11.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Node9";
            treeNodeAdv10.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv11});
            treeNodeAdv10.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "Node8";
            this.treeView1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv6,
            treeNodeAdv8,
            treeNodeAdv10});
            this.treeView1.RightImageList = this.imageList1;
            this.treeView1.ShowFocusRect = false;
            this.treeView1.Size = new System.Drawing.Size(174, 166);
            this.treeView1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeView1.TabIndex = 1;
            // 
            // 
            // 
            this.treeView1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeView1.ToolTipControl.Name = "toolTip";
            this.treeView1.ToolTipControl.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            // 
            // comboDropDown2
            // 
            this.comboDropDown2.BackColor = System.Drawing.Color.White;
            bannerTextInfo2.Text = "[Select]";
            bannerTextInfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.comboDropDown2, bannerTextInfo2);
            this.comboDropDown2.Location = new System.Drawing.Point(59, 240);
            this.comboDropDown2.Name = "comboDropDown2";
            this.comboDropDown2.PopupControl = this.gridListControl1;
            this.comboDropDown2.Size = new System.Drawing.Size(175, 21);
            this.comboDropDown2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboDropDown2.TabIndex = 4;
            // 
            // gridListControl1
            // 
            this.gridListControl1.BackColor = System.Drawing.Color.White;
            this.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridListControl1.DisplayMember = "LongName";
            this.gridListControl1.FillLastColumn = true;
            this.gridListControl1.ItemHeight = 17;
            this.gridListControl1.Location = new System.Drawing.Point(701, 246);
            this.gridListControl1.MultiColumn = true;
            this.gridListControl1.Name = "gridListControl1";
            this.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridListControl1.Properties.MarkColHeader = false;
            this.gridListControl1.Properties.MarkRowHeader = false;
            this.gridListControl1.SelectedIndex = -1;
            this.gridListControl1.Size = new System.Drawing.Size(175, 176);
            this.gridListControl1.TabIndex = 2;
            this.gridListControl1.ThemesEnabled = true;
            this.gridListControl1.TopIndex = 0;
            this.gridListControl1.ValueMember = "ShortName";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(17, 258);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(36, 13);
            this.autoLabel1.TabIndex = 4;
            this.autoLabel1.Text = "Styles";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Default",
            "OfficeXP",
            "Office2003",
            "VS2005",
            "Office2007",
            "Office2010",
            "Metro"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Default"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "OfficeXP"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2003"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "VS2005"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2007"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2010"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Metro"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(95, 255);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(99, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.comboBoxAdv1.TabIndex = 3;
            this.comboBoxAdv1.Text = "Default";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(56, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 23);
            this.label19.TabIndex = 25;
            this.label19.Text = "With TreeView";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(56, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "With GridListControl";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(17, 292);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(74, 13);
            this.autoLabel2.TabIndex = 29;
            this.autoLabel2.Text = "ColorScheme";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "Blue",
            "Silver",
            "Black"});
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Blue"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Silver"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Black"));
            this.comboBoxAdv2.Location = new System.Drawing.Point(95, 289);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(99, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.comboBoxAdv2.TabIndex = 28;
            this.comboBoxAdv2.Text = "Blue";
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(14, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Visual Styles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(14, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "BannerText Settings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bannerClrEdit
            // 
            this.bannerClrEdit.Buttons.Add(this.buttonEditChildButton1);
            this.bannerClrEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.bannerClrEdit.Controls.Add(this.buttonEditChildButton1);
            this.bannerClrEdit.Controls.Add(this.textBoxExt1);
            this.bannerClrEdit.Location = new System.Drawing.Point(55, 128);
            this.bannerClrEdit.MetroColor = System.Drawing.Color.Gray;
            this.bannerClrEdit.Name = "bannerClrEdit";
            this.bannerClrEdit.Size = new System.Drawing.Size(175, 23);
            this.bannerClrEdit.TabIndex = 34;
            this.bannerClrEdit.TextBox = this.textBoxExt1;
            this.bannerClrEdit.UseVisualStyle = true;
            this.bannerClrEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bannerClrEdit_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(151, 15);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Text";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Color";
            // 
            // rdoEdit
            // 
            this.rdoEdit.DrawFocusRectangle = false;
            this.rdoEdit.Location = new System.Drawing.Point(55, 82);
            this.rdoEdit.MetroColor = System.Drawing.Color.Gray;
            this.rdoEdit.Name = "rdoEdit";
            this.rdoEdit.Size = new System.Drawing.Size(79, 17);
            this.rdoEdit.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rdoEdit.TabIndex = 35;
            this.rdoEdit.TabStop = false;
            this.rdoEdit.Text = "Edit Mode";
            this.rdoEdit.ThemesEnabled = false;
            // 
            // rdoFocus
            // 
            this.rdoFocus.Checked = true;
            this.rdoFocus.DrawFocusRectangle = false;
            this.rdoFocus.Location = new System.Drawing.Point(140, 80);
            this.rdoFocus.MetroColor = System.Drawing.Color.Gray;
            this.rdoFocus.Name = "rdoFocus";
            this.rdoFocus.Size = new System.Drawing.Size(90, 17);
            this.rdoFocus.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rdoFocus.TabIndex = 36;
            this.rdoFocus.Text = "Focus Mode";
            this.rdoFocus.ThemesEnabled = false;
            // 
            // txtBanner
            // 
            this.txtBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBanner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBanner.Location = new System.Drawing.Point(55, 50);
            this.txtBanner.Metrocolor = System.Drawing.Color.Empty;
            this.txtBanner.Name = "txtBanner";
            this.txtBanner.Size = new System.Drawing.Size(175, 22);
            this.txtBanner.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBanner.TabIndex = 37;
            // 
            // btnSetBanner
            // 
            this.btnSetBanner.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSetBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnSetBanner.Location = new System.Drawing.Point(95, 167);
            this.btnSetBanner.Name = "btnSetBanner";
            this.btnSetBanner.Size = new System.Drawing.Size(90, 23);
            this.btnSetBanner.TabIndex = 38;
            this.btnSetBanner.Text = "Set Banner Text";
            this.btnSetBanner.UseVisualStyle = true;
            this.btnSetBanner.UseVisualStyleBackColor = true;
            this.btnSetBanner.Click += new System.EventHandler(this.btnSetBanner_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.bannerClrEdit);
            this.gradientPanel1.Controls.Add(this.comboBoxAdv1);
            this.gradientPanel1.Controls.Add(this.label10);
            this.gradientPanel1.Controls.Add(this.comboBoxAdv2);
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.autoLabel2);
            this.gradientPanel1.Controls.Add(this.btnSetBanner);
            this.gradientPanel1.Controls.Add(this.autoLabel1);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.rdoFocus);
            this.gradientPanel1.Controls.Add(this.txtBanner);
            this.gradientPanel1.Controls.Add(this.rdoEdit);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(238, 383);
            this.gradientPanel1.TabIndex = 39;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Location = new System.Drawing.Point(20, 98);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.label19);
            this.splitContainerAdv1.Panel1.Controls.Add(this.comboDropDown1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.comboDropDown2);
            this.splitContainerAdv1.Panel1.Controls.Add(this.label3);
            this.splitContainerAdv1.Panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(666, 385);
            this.splitContainerAdv1.SplitterDistance = 419;
            this.splitContainerAdv1.TabIndex = 40;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.gridListControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo DropDown";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).EndInit();
            this.bannerClrEdit.ResumeLayout(false);
            this.bannerClrEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		
		#region AfterDropDownPopup
		private void AfterDropDownPopup(object sender, EventArgs e)
		{
			// Uncomment this line, if you want the tree to take focus on dropdown.
			 this.treeView1.Focus();
		}
		#endregion
		#region DropDown
		private void comboDropDown1_DropDown(object sender, System.EventArgs e)
		{
			// Before the dropdown is shown, select a TreeNode based on the text in the combo.
            if (this.comboDropDown1.Text != String.Empty)
            {
                TreeNodeAdv matchedNode = this.FindNode(this.treeView1.Nodes, this.comboDropDown1.Text);
                this.treeView1.SelectedNode = matchedNode;
            }
		}
		#endregion
		#region TreeNode
		// Recursively traverse through all the nodes looking for a node with the specified text.
		private TreeNodeAdv FindNode(TreeNodeAdvCollection nodes, string text)
		{
			foreach(TreeNodeAdv child in nodes)
				if(child.Text == text)
					return child;

			foreach(TreeNodeAdv child in nodes)
			{
				TreeNodeAdv matched = this.FindNode(child.Nodes, text);
				if(matched != null)
					return matched;
			}

			return null;
		}
		#endregion

		private void Form1_Load (object sender, EventArgs e)
		{
			// Listen to the Popup event
			this.comboDropDown1.PopupContainer.Popup += new EventHandler(this.AfterDropDownPopup);
            Application.Idle += new EventHandler(Application_Idle);
        }

        #region BannerText Settings
        void Application_Idle(object sender, EventArgs e)
        {
            if (txtBanner.Text == "")
                btnSetBanner.Enabled = false;
            else
                btnSetBanner.Enabled = true;
        }

        private void bannerClrEdit_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.bannerClrEdit.TextBox.BackColor = colorDialog1.Color;
        }

        void Grid_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
        {
            if (this.gridListControl1.SelectedIndex != -1)
                this.comboDropDown2.TextBox.Text = this.gridListControl1.SelectedItem.ToString();
            else
                this.comboDropDown2.TextBox.Text = String.Empty;

            this.comboDropDown2.PopupContainer.HidePopup(PopupCloseType.Done);
        }

        void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeView1.SelectedNode != null)
                // Set the combo's text to be the TreeNode's Text.
                this.comboDropDown1.Text = this.treeView1.SelectedNode.Text;
            else
                this.comboDropDown1.Text = String.Empty;

            // Close the dropdown.
            this.comboDropDown1.PopupContainer.HidePopup(PopupCloseType.Done);
        }

        private void btnSetBanner_Click(object sender, EventArgs e)
        {
            BannerTextMode mode;
            if (rdoEdit.Checked)
                mode = BannerTextMode.EditMode;
            else
                mode = BannerTextMode.FocusMode;
            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.comboDropDown1);
            binfo.Text = txtBanner.Text;
            binfo.Mode = mode;
            binfo.Color = bannerClrEdit.TextBox.BackColor;
            BannerTextInfo binfo2 = this.bannerTextProvider1.GetBannerText(this.comboDropDown2);
            binfo2.Text = txtBanner.Text;
            binfo2.Mode = mode;
            binfo2.Color = bannerClrEdit.TextBox.BackColor;
            this.comboDropDown1.Refresh();
            this.comboDropDown2.Refresh();

        }
        #endregion

        #region Styles

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            autoLabel2.Visible = comboBoxAdv2.Visible = false;
            switch (this.comboBoxAdv1.SelectedItem.ToString())
            {
                case "Default":
                    {
                        this.comboDropDown1.Style = VisualStyle.Default;
                         this.comboDropDown2.Style = VisualStyle.Default;
                        break;
                    }
                case "OfficeXP":
                    {
                        this.comboDropDown1.Style = VisualStyle.OfficeXP;
                        this.comboDropDown2.Style = VisualStyle.OfficeXP;
                        break;
                    }
                case "Office2003":
                    {
                        this.comboDropDown1.Style = VisualStyle.Office2003;
                        this.comboDropDown2.Style = VisualStyle.Office2003;
                        break;
                    }
                case "VS2005":
                    {
                        this.comboDropDown1.Style = VisualStyle.VS2005;
                        this.comboDropDown2.Style = VisualStyle.VS2005;
                        break;
                    }
                case "Office2007":
                    {
                        this.comboDropDown1.Style = VisualStyle.Office2007;
                        this.comboDropDown2.Style = VisualStyle.Office2007;
                        autoLabel2.Visible = comboBoxAdv2.Visible = true;
                      
                        break;
                    }
                case "Office2010":
                    {
                        this.comboDropDown1.Style = VisualStyle.Office2010;
                        this.comboDropDown2.Style = VisualStyle.Office2010;
                        autoLabel2.Visible = comboBoxAdv2.Visible = true;
                        break;
                    }
                case "Metro":
                    {
                        this.comboDropDown1.Style = VisualStyle.Metro;
                        this.comboDropDown2.Style = VisualStyle.Metro;
                        break;
                    }
             
            }
        }
#endregion

        #region Color Schemes

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv2.SelectedItem.ToString())
            {
                case "Blue":
                    {
                        this.comboDropDown1.Office2007ColorTheme = Office2007Theme.Blue;
                        this.comboDropDown2.Office2007ColorTheme = Office2007Theme.Blue;
                        this.comboDropDown1.Office2010ColorTheme = Office2010Theme.Blue;
                        this.comboDropDown2.Office2010ColorTheme = Office2010Theme.Blue;

                          break;
                    }
                case "Silver":
                    {
                        this.comboDropDown1.Office2007ColorTheme = Office2007Theme.Silver;
                        this.comboDropDown2.Office2007ColorTheme = Office2007Theme.Silver;
                        this.comboDropDown1.Office2010ColorTheme = Office2010Theme.Silver;
                        this.comboDropDown2.Office2010ColorTheme = Office2010Theme.Silver;

                        break;
                    }
                case "Black":
                    {
                        this.comboDropDown1.Office2007ColorTheme = Office2007Theme.Black;
                        this.comboDropDown2.Office2007ColorTheme = Office2007Theme.Black;
                        this.comboDropDown1.Office2010ColorTheme = Office2010Theme.Black;
                        this.comboDropDown2.Office2010ColorTheme = Office2010Theme.Black;

                        break;
                    }
            }

        }
        #endregion
    }

	#region ArrayList
	public class USState
	{
		private string myShortName ;
		private string myLongName ;
		private int imgIndex;
   
		public  USState(string strLongName, string strShortName, int imageIndex)
		{
			this.myShortName = strShortName;
			this.myLongName = strLongName;
			this.imgIndex = imageIndex;
		}

		public string ShortName
		{
			get
			{
				return myShortName;
			}
		}

		public string LongName
		{
      
			get
			{
				return myLongName ;
			}
		}

		public int ImageIndex
		{
			get
			{
				return imgIndex;
			}
			set
			{
				imgIndex = value;
			}
		}


		public override string ToString()
		{
			return this.ShortName + " - " + this.LongName;
		}
	}
	#endregion
}
