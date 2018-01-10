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
using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.IO;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace TabbedMDI_2005
{
    public partial class Form1 : MetroForm
    {
        private DemoCommon.AboutForm aboutForm = null;
        private bool tabWindowsOn = false;
        private int document1Count = 0;
        private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDIManager;

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            //adding TabbedMDI Manager
            this.tabbedMDIManager = new Syncfusion.Windows.Forms.Tools.TabbedMDIManager();
            this.tabbedMDIManager.AttachedTo = this;
            this.tabbedMDIManager.DropDownButtonVisible = true;
            this.tabbedMDIManager.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager.NeedUpdateHostedForm = false;
            this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabbedMDIManager.BeforeDropDownPopup += new Syncfusion.Windows.Forms.Tools.DropDownPopupEventHandler(this.BeforePopup);
            this.tabbedMDIManager.TabControlAdded += new Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventHandler(this.tabbedMDIManager_TabControlAdded);
            // Trigger when right clicking on the tabs.
            this.tabbedMDIManager.ContextMenuItem.BeforePopup += new CancelEventHandler(ContextMenuItem_BeforePopup);
            this.propertyGrid1.SelectedObject = (object)this.tabbedMDIManager;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
             
            this.NewDocClick(this, EventArgs.Empty);
            this.NewDocClick(this, EventArgs.Empty);
            this.NewDocClick(this, EventArgs.Empty);
            this.NewDocClick(this, EventArgs.Empty);

            // Turn on MDI Tabbed Documents mode.
            // Call this after loading the mdi children to restore their previous state.
            this.TabbedMDIOn = true;
            this.tabbedMDIManager.ContextMenuItem.Items.Add(this.closeAllBarItem);
            this.tabbedMDIManager.ContextMenuItem.BeginGroupAt(closeAllBarItem);
            this.tabbedMDIManager.ContextMenuItem.Items.Add(this.barItem1);

            if (File.Exists(@"..\..\persist.xml"))
            {
                AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\..\persist");
                this.tabbedMDIManager.LoadTabGroupStates(serializer);
                SendMessageToStatusBar("TabGroupStates loaded");
            }
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

        void MainMenuBar_DrawBackground(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White,e.ClipRectangle);
        }

        // Convenient way to toggle TabbedMDI mode.
        internal bool TabbedMDIOn
        {
            get { return this.tabWindowsOn; }
            set
            {
                if (!(this.tabWindowsOn == value))
                {
                    this.tabWindowsOn = value;

                    if (this.tabWindowsOn)
                    {
                        this.tabbedMDIManager.AttachToMdiContainer(this);
                    }
                    else
                    {
                        this.tabbedMDIManager.DetachFromMdiContainer(this, false); // false to not invoke the Cascade mode after detaching.
                    }
                }
            }
        }

        internal TabbedMDIManager TabbedMDIManager
        {
            get { return this.tabbedMDIManager; }
        }

        private void SendMessageToStatusBar(string text)
        {
            this.statusBarAdvPanel1.Text = text;
        }

        TabControlAdv tabControl;
        // Triggered when a tabgroup host is created.
        private void tabbedMDIManager_TabControlAdded(object sender, Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs args)
        {
            tabControl = args.TabControl;
            if (barItem18.Checked)
            {
                args.TabControl.Office2007ColorScheme = Office2007Theme.Blue;
            }
            else if (barItem19.Checked)
            {
                args.TabControl.Office2007ColorScheme = Office2007Theme.Black;
            }
            else if (barItem20.Checked)
            {
                args.TabControl.Office2007ColorScheme = Office2007Theme.Silver;
            }
        }

        //Add a document 
        private void AddDocument(Form doc)
        {
            doc.MdiParent = this;
            doc.Show();
            this.mdiListBarItem1.ChildCaptions.Add(doc.Name);
        }

        private void NewDocClick(object sender, EventArgs e)
        {
            this.checkBoxAdv4.Checked = true;
            this.tabbedMDIManager.ShowCloseButton = true;
            document1Count++;
            Document1 doc = new Document1("Document " + document1Count.ToString());
            AddDocument(doc);
            if(document1Count %2 ==0)
            this.tabbedMDIManager.ShowCloseButtonForForm(doc,true );
            // To set tooltip for the tabs
            this.tabbedMDIManager.SetTooltip(doc, "Tooltip for " + doc.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void ToggleAlign(object sender, EventArgs e)
        {
            this.tabbedMDIManager.Horizontal = !this.tabbedMDIManager.Horizontal;
        }

        private void AppExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Parse(object sender, EventArgs e)
        {
            string children = String.Empty;
            foreach (Form form in this.tabbedMDIManager.MdiChildren)
            {
                children += form.Text + "\r\n";
            }
            MessageBox.Show(children);
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            this.mainFrameBarManager1.MainMenuBar.DrawBackground += new PaintEventHandler(MainMenuBar_DrawBackground);
            if (this.ActiveMdiChild == null)
            {
                statusBarAdv1.Text = "";
            }
            else
            {
                statusBarAdv1.Text = this.ActiveMdiChild.Text;
            }
        }

        private void LoadState(object sender, EventArgs e)
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\..\persist");
            this.tabbedMDIManager.LoadTabGroupStates(serializer);
            SendMessageToStatusBar("TabGroupStates loaded");
        }

        private void SaveState(object sender, EventArgs e)
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\..\persist");
            this.tabbedMDIManager.SaveTabGroupStates(serializer);
            serializer.PersistNow();
            SendMessageToStatusBar("TabGroupStates saved");
        }

        private void CloseAll(object sender, EventArgs e)
        {
            foreach (Form f in this.tabbedMDIManager.MdiChildren)
            {
                if (this.ActiveMdiChild.Name != f.Name)
                    f.Close();
            }
        }

        private void ShowProperties(object sender, EventArgs e)
        {
            barItem7.Checked = !barItem7.Checked;

            tabControlAdv1.Visible = barItem7.Checked;
            splitter1.Visible = barItem7.Checked;
        }

        private void About(object sender, EventArgs e)
        {
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
        }

        private void ContextMenuItem_BeforePopup(object sender, CancelEventArgs e)
        {
            switch (comboBoxAdv1.SelectedIndex)
            {
                case 0:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                    break;
                case 1:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
                    break;
                case 2:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005;
                    break;
                case 3:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    break;
                case 4:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
                    break;
                case 5:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    break;
            }
            //Disables the "Close All But this" barItem when the number of Tab Pages are equal to one.
            int i = 0;
            foreach (Form f in this.tabbedMDIManager.MdiChildren)
            {
                i = i + 1;
            }
            if (i < 2)
                this.closeAllBarItem.Enabled = false;
            else
                this.closeAllBarItem.Enabled = true;
        }

        // This event triggers before dropdown button shows its mdi list.
        private void BeforePopup(object sender, Syncfusion.Windows.Forms.Tools.DropDownPopupEventArgs e)
        {
            switch (comboBoxAdv1.SelectedIndex)
            {
                case 0:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                    break;
                case 1:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
                    break;
                case 2:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005;
                    break;
                case 3:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    break;
                case 4:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
                    break;
            }
        }

        public void MenuCheckRemove(Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Item)
        {
            foreach (BarItem barItem in this.StylesList.Items)
            {
                if (barItem != Item)
                {
                    ((BarItem)barItem).Checked = false;

                }
                else
                    ((BarItem)barItem).Checked = true;
            }
        }

        // Changing the tab style.
        private void TabStyles_Click(object sender, System.EventArgs e)
        {
            this.MenuCheckRemove((BarItem)sender);

            if (this.barItem8.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRenderer2D);
            else if (this.barItem9.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRenderer3D);
            else if (this.barItem10.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererWorkbookMode);
            else if (this.barItem11.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.OneNoteStyleRenderer);
            else if (this.barItem12.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.OneNoteStyleFlatTabsRenderer);
            else if (this.barItem13.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2003);
            else if (this.barItem14.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererWhidbey);
            else if (this.barItem15.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbey);
            else if (this.barItem16.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbeyBeta);
            else if (this.barItem17.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererIE7);

                // TabbedMDIManager does not have Office2007 Black and Silver them
                // Hence accessing the internal tabControlAdv and applying
                // 
            else if (this.barItem18.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);

                foreach (TabHost tabhost in tabbedMDIManager.TabGroupHosts)
                    tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Blue;

            }
            else if (this.barItem19.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);

                foreach (TabHost tabhost in tabbedMDIManager.TabGroupHosts)
                    tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Black;

            }
            else if (this.barItem20.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);

                foreach (TabHost tabhost in tabbedMDIManager.TabGroupHosts)
                    tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Silver;
            }
            else if (this.barItem22.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererBlendLight);
            else if (this.barItem23.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererBlendDark);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxAdv6_CheckedChanged(object sender, EventArgs e)
        {
            //Show or Hide MDI List dropdown.
            this.tabbedMDIManager.DropDownButtonVisible = !this.tabbedMDIManager.DropDownButtonVisible;
            SendMessageToStatusBar("DropDownButtonVisible set to " + this.checkBoxAdv6.Checked.ToString());
        }

        private void checkBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide the close button.
            this.tabbedMDIManager.CloseButtonVisible = !this.tabbedMDIManager.CloseButtonVisible;
            SendMessageToStatusBar("CloseButton Visible set to " + this.checkBoxAdv1.Checked.ToString());
        }

        private void checkBoxAdv2_CheckedChanged(object sender, EventArgs e)
        {
            // Close the child form when clicking the tab using the middle mouse button.
            this.tabbedMDIManager.CloseOnMiddleButtonClick = checkBoxAdv2.Checked;
            SendMessageToStatusBar("CloseOnMiddleButtonClick set to " + checkBoxAdv2.Checked.ToString());
        }

        private void checkBoxAdv4_CheckedChanged(object sender, EventArgs e)
        {
            // Show or Hide child form icons.
            this.tabbedMDIManager.UseIconsInTabs = !this.tabbedMDIManager.UseIconsInTabs;
            SendMessageToStatusBar("UseIconInTabs set to " + this.checkBoxAdv4.Checked.ToString());
        }

        private void checkBoxAdv3_CheckedChanged(object sender, EventArgs e)
        {
            // Show or Hide the tab panel.
            this.tabbedMDIManager.Visible = !this.tabbedMDIManager.Visible;
            SendMessageToStatusBar("TabbedMDIManager visibility set to " + this.checkBoxAdv3.Checked.ToString());
        }

        private void checkBoxAdv5_CheckedChanged(object sender, EventArgs e)
        {
            // Show or Hide close button for individual tabs.
            if (this.checkBoxAdv5.Checked)
            {
                this.tabbedMDIManager.ShowCloseButton = false;
                this.tabbedMDIManager.ShowCloseButton = !this.tabbedMDIManager.ShowCloseButton;
            }
            else
            {
                this.tabbedMDIManager.ShowCloseButton = false;
            }
            SendMessageToStatusBar("ShowCloseButton set to " + this.checkBoxAdv5.Checked.ToString());
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tabbedMDIManager.LockHostFormUpdate();
        }
    }
}