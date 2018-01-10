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
using Syncfusion.Windows.Forms.Tools;

namespace TabSplitterContainer_2005
{
    public partial class Main : MetroForm
    {
        SplitWindowForm window1 = null, window2 = null;

        public Main()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


            window1 = new SplitWindowForm("Window1.xaml", "Code1.rtf");
            window1.MdiParent = this;
            window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Designer1.png"));
            window1.Show();

            window2 = new SplitWindowForm("Window2.xaml", "Code2.rtf");
            window2.MdiParent = this;
            window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Designer2.png"));
            window2.Show();
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

        void tabbedMDIManager1_TabControlAdded(object sender, TabbedMDITabControlEventArgs args)
        {
            if (args.TabControl != null)
                args.TabControl.BorderVisible = true;
        }

        public SplitWindowForm ActiveWindow
        {
            get
            {
                if (this.ActiveMdiChild != null)
                    return (SplitWindowForm)this.ActiveMdiChild;
                else
                    return null;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.tabbedMDIManager1 = new Syncfusion.Windows.Forms.Tools.TabbedMDIManager(this.components);
            this.tabbedMDIManager1.AttachedTo = this;

            this.tabbedMDIManager1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager1.NeedUpdateHostedForm = false;
            this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabbedMDIManager1.UseIconsInTabs = false;
            this.tabbedMDIManager1.TabControlAdded += new Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventHandler(this.tabbedMDIManager1_TabControlAdded);
            //Initial Settings
            this.ActivateMdiChild(window1);
            this.tabbedMDIManager1.CloseButtonToolTip = "Close";
        }
    }
}