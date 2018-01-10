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

namespace ButtonEditDemo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Tools;
	using Syncfusion.Windows.Forms;
    using System.Drawing.Drawing2D;

	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : MetroForm
	{
		private System.Windows.Forms.ErrorProvider errorProvider1;

		private Hashtable hashLabelNames;
        public Color startcolor = Color.LightGreen;
        public Color endcolor = Color.Green;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;

		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox2;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControl1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPage1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPage2;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox4;
        private ButtonEdit buttonEdit1;
        private ButtonEditChildButton buttonEditChildButton1;
        private TextBoxExt textBoxExt1;
        private ButtonEdit buttonEdit3;
        private ButtonEditChildButton buttonEditChildButton3;
        private TextBoxExt textBoxExt3;
        private ButtonEdit buttonEdit2;
        private ButtonEditChildButton buttonEditChildButton2;
        private TextBoxExt textBoxExt2;
        private ButtonEdit buttonEdit7;
        private ButtonEditChildButton buttonEditChildButton13;
        private ButtonEditChildButton buttonEditChildButton14;
        private ButtonEditChildButton buttonEditChildButton15;
        private ButtonEditChildButton buttonEditChildButton16;
        private TextBoxExt textBoxExt7;
        private ButtonEdit buttonEdit6;
        private ButtonEditChildButton buttonEditChildButton10;
        private ButtonEditChildButton buttonEditChildButton11;
        private ButtonEditChildButton buttonEditChildButton12;
        private TextBoxExt textBoxExt6;
        private ButtonEdit buttonEdit5;
        private ButtonEditChildButton buttonEditChildButton7;
        private ButtonEditChildButton buttonEditChildButton8;
        private ButtonEditChildButton buttonEditChildButton9;
        private TextBoxExt textBoxExt5;
        private ButtonEdit buttonEdit4;
        private ButtonEditChildButton buttonEditChildButton4;
        private ButtonEditChildButton buttonEditChildButton5;
        private ButtonEditChildButton buttonEditChildButton6;
        private TextBoxExt textBoxExt4;
        private TabPageAdv tabPage3;
        private GroupBox groupBox6;
        private GradientPanel gradientPanel5;
        private ButtonAdv buttonAdv12;
        private ButtonAdv buttonAdv9;
        private ButtonAdv buttonAdv25;
        private ButtonAdv buttonAdv22;
        private ButtonAdv buttonAdv20;
        private ButtonAdv buttonAdv19;
        private Label label11;
        private ButtonAdv buttonAdv18;
        private ButtonAdv buttonAdv21;
        private ButtonAdv buttonAdv4;
        private ButtonAdv buttonAdv15;
        private ButtonAdv buttonAdv1;
        private GroupBox groupBox7;
        private ButtonAdv buttonAdv6;
        private ButtonAdv buttonAdv2;
        private ButtonAdv buttonAdv10;
        private ButtonAdv buttonAdv5;
        private ButtonAdv buttonAdv11;
        private ButtonAdv buttonAdv14;
        private ButtonAdv buttonAdv8;
        private ButtonAdv buttonAdv7;
        private ButtonAdv buttonAdv13;
        private GradientPanel gradientPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPageAdv tabPageAdv1;
        private GradientPanel gradientPanel19;
        private SplitButton splitButton1;
        private GradientPanel panel6;
        private SplitButton splitButton2;
        private Label label6;
        private GradientPanel gradientPanel17;
        private TextBox textBox1;
        private Label label4;
        private GradientPanel gradientPanel18;
        private GradientPanel gradientPanel20;
        private Label label9;
        private RadioButtonAdv radioButtonAdv17;
        private RadioButtonAdv radioButtonAdv6;
        private RadioButtonAdv radioButtonAdv4;
        private RadioButtonAdv radioButtonAdv3;
        private GradientPanel panel3;
        private Label label2;
        private RadioButtonAdv radioButton2;
        private RadioButtonAdv radioButton1;
        private GradientPanel panel4;
        private Label label3;
        private ButtonAdv buttonAdv3;
        private ImageList imageList2;
		private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.Resize += new EventHandler(MainForm_Resize);
            CustomRenderer renderer = new CustomRenderer();
            renderer.SplitButton = splitButton2;
            splitButton2.Renderer = renderer;
            this.splitButton1.DropDownItems.Add(new toolstripitem());
            this.splitButton1.DropDownItems.Add(new toolstripitem());
            this.splitButton1.DropDownItems.Add(new toolstripitem());
            this.splitButton1.DropDownItems.Add(new toolstripitem());
            this.splitButton1.DropDownItems.Add(new toolstripitem());
            this.splitButton1.DropDownItems[0].Text = "Item1";
            this.splitButton1.DropDownItems[1].Text = "Item2";
            this.splitButton1.DropDownItems[2].Text = "Item3";
            this.splitButton1.DropDownItems[3].Text = "Item4";
            this.splitButton1.DropDownItems[4].Text = "Item5";
            Image img = Image.FromFile(@"../../logo_16.ico");
            this.splitButton2.DropDownItems.Add(new toolstripitem());
            this.splitButton2.DropDownItems.Add(new toolstripitem());
            this.splitButton2.DropDownItems.Add(new toolstripitem());
            this.splitButton2.DropDownItems.Add(new toolstripitem());
            this.splitButton2.DropDownItems.Add(new toolstripitem());
            this.splitButton2.DropDownItems[0].Text = "Item1";
            this.splitButton2.DropDownItems[0].Image = img;
            this.splitButton2.DropDownItems[1].Text = "Item2";
            this.splitButton2.DropDownItems[1].Image = img;
            this.splitButton2.DropDownItems[2].Text = "Item3";
            this.splitButton2.DropDownItems[2].Image = img;
            this.splitButton2.DropDownItems[3].Text = "Item4";
            this.splitButton2.DropDownItems[3].Image = img;
            this.splitButton2.DropDownItems[4].Text = "Item5";
            this.splitButton2.DropDownItems[4].Image = img;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			hashLabelNames = new Hashtable();
			this.popupControlContainer1.ParentControl = this.buttonEdit3.TextBox;
			this.popupControlContainer1.PopupParent = this.buttonEdit3;
			this.buttonEdit3.TextBox.HandleDestroyed += new EventHandler(this.DropDownParentTextBoxDestroyed);
		}

        void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.groupBox6.Location = new Point(400, 302);
                this.groupBox7.Location = new Point(400, 131);
                this.groupBox1.Location = new Point(475, 247);
                this.groupBox2.Location = new Point(475, 69);
                this.groupBox5.Location = new Point(475, 436);
                this.groupBox4.Location = new Point(381, 180);
                this.gradientPanel18.Location = new Point(585, 39);
                this.gradientPanel19.Location = new Point(217, 39);
            }
            else
            {
                this.groupBox6.Location = new Point(43, 202);
                this.groupBox7.Location = new Point(43, 31);
                this.groupBox1.Location = new Point(175, 147);
                this.groupBox2.Location = new Point(175, 69);
                this.groupBox5.Location = new Point(175, 236);
                this.groupBox4.Location = new Point(81, 80);
                this.gradientPanel18.Location = new Point(285, 39);
                this.gradientPanel19.Location = new Point(27, 39);
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

		private void DropDownParentTextBoxDestroyed(object sender, EventArgs args)
		{
			if(popupControlContainer1 != null)
				this.popupControlContainer1.ParentControl = null;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer2 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEdit2 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPage3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.buttonAdv12 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv9 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv25 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv22 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv20 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv19 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAdv18 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv21 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv15 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv11 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv13 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv10 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv7 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv8 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv14 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabPage1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPage2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonEdit7 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton13 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton14 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton15 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton16 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt7 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonEdit6 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton10 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton11 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton12 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt6 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonEdit5 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton7 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton8 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton9 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt5 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonEdit4 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton5 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton6 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt4 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel18 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel20 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonAdv17 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel19 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.splitButton1 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.panel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.splitButton2 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gradientPanel17 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).BeginInit();
            this.buttonEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit7)).BeginInit();
            this.buttonEdit7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).BeginInit();
            this.buttonEdit6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).BeginInit();
            this.buttonEdit5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).BeginInit();
            this.buttonEdit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt4)).BeginInit();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel18)).BeginInit();
            this.gradientPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel20)).BeginInit();
            this.gradientPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel19)).BeginInit();
            this.gradientPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel6)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel17)).BeginInit();
            this.gradientPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonEdit2);
            this.groupBox1.Location = new System.Drawing.Point(175, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FolderBrowser";
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.Buttons.Add(this.buttonEditChildButton2);
            this.buttonEdit2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit2.Controls.Add(this.buttonEditChildButton2);
            this.buttonEdit2.Controls.Add(this.textBoxExt2);
            this.buttonEdit2.Location = new System.Drawing.Point(72, 14);
            this.buttonEdit2.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Size = new System.Drawing.Size(121, 23);
            this.buttonEdit2.TabIndex = 0;
            this.buttonEdit2.TextBox = this.textBoxExt2;
            this.buttonEdit2.UseVisualStyle = true;
            this.buttonEdit2.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton2.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton2.Image")));
            this.buttonEditChildButton2.ImageIndex = 7;
            this.buttonEditChildButton2.ImageList = this.imageList1;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 18;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "buttonEditChildButton2";
            this.buttonEditChildButton2.Click += new System.EventHandler(this.buttonEditChildButton2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt2.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(99, 15);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonEdit1);
            this.groupBox2.Location = new System.Drawing.Point(175, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 48);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FileBrowser";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton1);
            this.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton1);
            this.buttonEdit1.Controls.Add(this.textBoxExt1);
            this.buttonEdit1.Location = new System.Drawing.Point(72, 14);
            this.buttonEdit1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(121, 23);
            this.buttonEdit1.TabIndex = 0;
            this.buttonEdit1.TextBox = this.textBoxExt1;
            this.buttonEdit1.UseVisualStyle = true;
            this.buttonEdit1.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEditChildButton1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton1.Image")));
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Click += new System.EventHandler(this.buttonEditChildButton1_Click);
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(99, 15);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt1.TabIndex = 0;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.gradientLabel1);
            this.popupControlContainer1.Location = new System.Drawing.Point(522, 69);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(169, 152);
            this.popupControlContainer1.TabIndex = 12;
            this.popupControlContainer1.Visible = false;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.SystemColors.ActiveCaption);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(169, 152);
            this.gradientLabel1.TabIndex = 0;
            this.gradientLabel1.Text = "Syncfusion";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gradientLabel1.Click += new System.EventHandler(this.gradientLabel1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.buttonEdit3);
            this.groupBox5.Location = new System.Drawing.Point(175, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 56);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DropDown";
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.Buttons.Add(this.buttonEditChildButton3);
            this.buttonEdit3.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit3.Controls.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Controls.Add(this.textBoxExt3);
            this.buttonEdit3.Location = new System.Drawing.Point(74, 20);
            this.buttonEdit3.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.Size = new System.Drawing.Size(121, 23);
            this.buttonEdit3.TabIndex = 0;
            this.buttonEdit3.TextBox = this.textBoxExt3;
            this.buttonEdit3.UseVisualStyle = true;
            this.buttonEdit3.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEditChildButton3.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton3.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton3.Image")));
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 18;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Click += new System.EventHandler(this.buttonEditChildButton3_Click);
            // 
            // textBoxExt3
            // 
            this.textBoxExt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt3.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt3.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.textBoxExt3.Name = "textBoxExt3";
            this.textBoxExt3.OverflowIndicatorToolTipText = null;
            this.textBoxExt3.Size = new System.Drawing.Size(99, 15);
            this.textBoxExt3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 121);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EventLog";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 18);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(746, 100);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageAdv1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(755, 464);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControl1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Image = null;
            this.tabPage3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPage3.Location = new System.Drawing.Point(1, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.ShowCloseButton = true;
            this.tabPage3.Size = new System.Drawing.Size(752, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ButtonAdv";
            this.tabPage3.ThemesEnabled = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gradientPanel5);
            this.groupBox6.Controls.Add(this.buttonAdv4);
            this.groupBox6.Controls.Add(this.buttonAdv15);
            this.groupBox6.Controls.Add(this.buttonAdv1);
            this.groupBox6.Location = new System.Drawing.Point(43, 202);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(660, 212);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Styles";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel5.BorderColor = System.Drawing.Color.Gainsboro;
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.Controls.Add(this.buttonAdv12);
            this.gradientPanel5.Controls.Add(this.buttonAdv9);
            this.gradientPanel5.Controls.Add(this.buttonAdv25);
            this.gradientPanel5.Controls.Add(this.buttonAdv22);
            this.gradientPanel5.Controls.Add(this.buttonAdv20);
            this.gradientPanel5.Controls.Add(this.buttonAdv19);
            this.gradientPanel5.Controls.Add(this.label11);
            this.gradientPanel5.Controls.Add(this.buttonAdv18);
            this.gradientPanel5.Controls.Add(this.buttonAdv21);
            this.gradientPanel5.Location = new System.Drawing.Point(22, 99);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(611, 88);
            this.gradientPanel5.TabIndex = 37;
            // 
            // buttonAdv12
            // 
            this.buttonAdv12.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv12.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv12.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv12.ForeColor = System.Drawing.Color.Black;
            this.buttonAdv12.KeepFocusRectangle = false;
            this.buttonAdv12.Location = new System.Drawing.Point(438, 58);
            this.buttonAdv12.Name = "buttonAdv12";
            this.buttonAdv12.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv12.Size = new System.Drawing.Size(130, 22);
            this.buttonAdv12.TabIndex = 40;
            this.buttonAdv12.Text = "Classic";
            this.buttonAdv12.UseVisualStyle = true;
            // 
            // buttonAdv9
            // 
            this.buttonAdv9.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv9.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv9.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv9.ForeColor = System.Drawing.Color.Black;
            this.buttonAdv9.KeepFocusRectangle = false;
            this.buttonAdv9.Location = new System.Drawing.Point(298, 58);
            this.buttonAdv9.Name = "buttonAdv9";
            this.buttonAdv9.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv9.Size = new System.Drawing.Size(111, 22);
            this.buttonAdv9.TabIndex = 39;
            this.buttonAdv9.Text = "Metro";
            this.buttonAdv9.UseVisualStyle = true;
            // 
            // buttonAdv25
            // 
            this.buttonAdv25.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv25.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv25.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv25.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv25.ForeColor = System.Drawing.Color.Black;
            this.buttonAdv25.KeepFocusRectangle = false;
            this.buttonAdv25.Location = new System.Drawing.Point(153, 58);
            this.buttonAdv25.Name = "buttonAdv25";
            this.buttonAdv25.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv25.Size = new System.Drawing.Size(119, 22);
            this.buttonAdv25.TabIndex = 38;
            this.buttonAdv25.Text = "Office2007Managed";
            this.buttonAdv25.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAdv25.UseVisualStyle = true;
            // 
            // buttonAdv22
            // 
            this.buttonAdv22.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2003;
            this.buttonAdv22.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv22.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv22.KeepFocusRectangle = false;
            this.buttonAdv22.Location = new System.Drawing.Point(153, 26);
            this.buttonAdv22.Name = "buttonAdv22";
            this.buttonAdv22.Size = new System.Drawing.Size(119, 22);
            this.buttonAdv22.TabIndex = 22;
            this.buttonAdv22.Text = "Office 2003";
            this.buttonAdv22.UseVisualStyle = true;
            // 
            // buttonAdv20
            // 
            this.buttonAdv20.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv20.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv20.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv20.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv20.KeepFocusRectangle = false;
            this.buttonAdv20.Location = new System.Drawing.Point(298, 26);
            this.buttonAdv20.Name = "buttonAdv20";
            this.buttonAdv20.Size = new System.Drawing.Size(111, 22);
            this.buttonAdv20.TabIndex = 20;
            this.buttonAdv20.Text = "Office 2007 Blue";
            this.buttonAdv20.UseVisualStyle = true;
            // 
            // buttonAdv19
            // 
            this.buttonAdv19.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv19.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv19.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv19.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv19.ForeColor = System.Drawing.Color.White;
            this.buttonAdv19.KeepFocusRectangle = false;
            this.buttonAdv19.Location = new System.Drawing.Point(438, 26);
            this.buttonAdv19.Name = "buttonAdv19";
            this.buttonAdv19.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonAdv19.Size = new System.Drawing.Size(130, 22);
            this.buttonAdv19.TabIndex = 19;
            this.buttonAdv19.Text = "Office 2007 Black";
            this.buttonAdv19.UseVisualStyle = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 14);
            this.label11.TabIndex = 36;
            this.label11.Text = "Styles";
            // 
            // buttonAdv18
            // 
            this.buttonAdv18.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv18.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv18.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv18.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv18.KeepFocusRectangle = false;
            this.buttonAdv18.Location = new System.Drawing.Point(26, 56);
            this.buttonAdv18.Name = "buttonAdv18";
            this.buttonAdv18.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.buttonAdv18.Size = new System.Drawing.Size(114, 24);
            this.buttonAdv18.TabIndex = 18;
            this.buttonAdv18.Text = "Office 2007 Silver";
            this.buttonAdv18.UseVisualStyle = true;
            // 
            // buttonAdv21
            // 
            this.buttonAdv21.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2000;
            this.buttonAdv21.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv21.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv21.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv21.KeepFocusRectangle = false;
            this.buttonAdv21.Location = new System.Drawing.Point(26, 26);
            this.buttonAdv21.Name = "buttonAdv21";
            this.buttonAdv21.Size = new System.Drawing.Size(114, 22);
            this.buttonAdv21.TabIndex = 21;
            this.buttonAdv21.Text = "Office XP";
            this.buttonAdv21.UseVisualStyle = true;
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv4.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv4.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv4.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv4.Image")));
            this.buttonAdv4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv4.Location = new System.Drawing.Point(22, 21);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(174, 49);
            this.buttonAdv4.TabIndex = 14;
            this.buttonAdv4.Text = "&New Document";
            this.buttonAdv4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv4.UseVisualStyle = true;
            // 
            // buttonAdv15
            // 
            this.buttonAdv15.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv15.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv15.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv15.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv15.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv15.Image")));
            this.buttonAdv15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv15.KeepFocusRectangle = false;
            this.buttonAdv15.Location = new System.Drawing.Point(232, 21);
            this.buttonAdv15.Name = "buttonAdv15";
            this.buttonAdv15.Size = new System.Drawing.Size(177, 49);
            this.buttonAdv15.TabIndex = 15;
            this.buttonAdv15.Text = "Save a copy of item in one \r\nof the available formats.\r\n";
            this.buttonAdv15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv15.UseVisualStyle = true;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv1.Image")));
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(452, 19);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonAdv1.Size = new System.Drawing.Size(181, 49);
            this.buttonAdv1.TabIndex = 13;
            this.buttonAdv1.Text = "Image above text";
            this.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdv1.UseVisualStyle = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel1);
            this.groupBox7.Location = new System.Drawing.Point(43, 31);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(660, 143);
            this.groupBox7.TabIndex = 45;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Button Types";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv5, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv11, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv13, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv10, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv8, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv14, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 61);
            this.tableLayoutPanel1.TabIndex = 47;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv5.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv5.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down;
            this.buttonAdv5.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv5.KeepFocusRectangle = false;
            this.buttonAdv5.Location = new System.Drawing.Point(475, 3);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(61, 55);
            this.buttonAdv5.TabIndex = 5;
            this.buttonAdv5.Text = "buttonAdv5";
            this.buttonAdv5.UseVisualStyle = true;
            // 
            // buttonAdv6
            // 
            this.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv6.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv6.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Up;
            this.buttonAdv6.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv6.KeepFocusRectangle = false;
            this.buttonAdv6.Location = new System.Drawing.Point(130, 3);
            this.buttonAdv6.Name = "buttonAdv6";
            this.buttonAdv6.Size = new System.Drawing.Size(53, 55);
            this.buttonAdv6.TabIndex = 6;
            this.buttonAdv6.Text = "buttonAdv6";
            this.buttonAdv6.UseVisualStyle = true;
            // 
            // buttonAdv11
            // 
            this.buttonAdv11.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv11.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv11.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv11.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.buttonAdv11.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv11.KeepFocusRectangle = false;
            this.buttonAdv11.Location = new System.Drawing.Point(305, 3);
            this.buttonAdv11.Name = "buttonAdv11";
            this.buttonAdv11.Size = new System.Drawing.Size(50, 55);
            this.buttonAdv11.TabIndex = 11;
            this.buttonAdv11.Text = "buttonAdv11";
            this.buttonAdv11.UseVisualStyle = true;
            // 
            // buttonAdv13
            // 
            this.buttonAdv13.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv13.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv13.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv13.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.LeftEnd;
            this.buttonAdv13.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv13.KeepFocusRectangle = false;
            this.buttonAdv13.Location = new System.Drawing.Point(361, 3);
            this.buttonAdv13.Name = "buttonAdv13";
            this.buttonAdv13.Size = new System.Drawing.Size(49, 55);
            this.buttonAdv13.TabIndex = 13;
            this.buttonAdv13.Text = "buttonAdv13";
            this.buttonAdv13.UseVisualStyle = true;
            // 
            // buttonAdv10
            // 
            this.buttonAdv10.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv10.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv10.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv10.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Undo;
            this.buttonAdv10.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv10.KeepFocusRectangle = false;
            this.buttonAdv10.Location = new System.Drawing.Point(61, 3);
            this.buttonAdv10.Name = "buttonAdv10";
            this.buttonAdv10.Size = new System.Drawing.Size(63, 55);
            this.buttonAdv10.TabIndex = 10;
            this.buttonAdv10.Text = "buttonAdv10";
            this.buttonAdv10.UseVisualStyle = true;
            // 
            // buttonAdv7
            // 
            this.buttonAdv7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv7.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv7.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv7.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Left;
            this.buttonAdv7.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv7.KeepFocusRectangle = false;
            this.buttonAdv7.Location = new System.Drawing.Point(189, 3);
            this.buttonAdv7.Name = "buttonAdv7";
            this.buttonAdv7.Size = new System.Drawing.Size(49, 55);
            this.buttonAdv7.TabIndex = 7;
            this.buttonAdv7.Text = "buttonAdv7";
            this.buttonAdv7.UseVisualStyle = true;
            // 
            // buttonAdv8
            // 
            this.buttonAdv8.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv8.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv8.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv8.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Right;
            this.buttonAdv8.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv8.KeepFocusRectangle = false;
            this.buttonAdv8.Location = new System.Drawing.Point(244, 3);
            this.buttonAdv8.Name = "buttonAdv8";
            this.buttonAdv8.Size = new System.Drawing.Size(55, 55);
            this.buttonAdv8.TabIndex = 8;
            this.buttonAdv8.Text = "buttonAdv8";
            this.buttonAdv8.UseVisualStyle = true;
            // 
            // buttonAdv14
            // 
            this.buttonAdv14.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv14.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv14.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv14.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.RightEnd;
            this.buttonAdv14.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv14.KeepFocusRectangle = false;
            this.buttonAdv14.Location = new System.Drawing.Point(416, 3);
            this.buttonAdv14.Name = "buttonAdv14";
            this.buttonAdv14.Size = new System.Drawing.Size(53, 55);
            this.buttonAdv14.TabIndex = 14;
            this.buttonAdv14.Text = "buttonAdv14";
            this.buttonAdv14.UseVisualStyle = true;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Calculator;
            this.buttonAdv2.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(3, 3);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(52, 55);
            this.buttonAdv2.TabIndex = 2;
            this.buttonAdv2.Text = "buttonAdv2";
            this.buttonAdv2.UseVisualStyle = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.popupControlContainer1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Image = null;
            this.tabPage1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPage1.Location = new System.Drawing.Point(1, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.ShowCloseButton = true;
            this.tabPage1.Size = new System.Drawing.Size(752, 440);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "DropDowns";
            this.tabPage1.ThemesEnabled = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Image = null;
            this.tabPage2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPage2.Location = new System.Drawing.Point(1, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.ShowCloseButton = true;
            this.tabPage2.Size = new System.Drawing.Size(752, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ButtonTypes";
            this.tabPage2.ThemesEnabled = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonEdit7);
            this.groupBox4.Controls.Add(this.buttonEdit6);
            this.groupBox4.Controls.Add(this.buttonEdit5);
            this.groupBox4.Controls.Add(this.buttonEdit4);
            this.groupBox4.Location = new System.Drawing.Point(81, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(581, 228);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ButtonTypes";
            // 
            // buttonEdit7
            // 
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton13);
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton14);
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton15);
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton16);
            this.buttonEdit7.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton16);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton15);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton14);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton13);
            this.buttonEdit7.Controls.Add(this.textBoxExt7);
            this.buttonEdit7.Location = new System.Drawing.Point(353, 142);
            this.buttonEdit7.MetroColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit7.Name = "buttonEdit7";
            this.buttonEdit7.ShowTextBox = false;
            this.buttonEdit7.Size = new System.Drawing.Size(121, 23);
            this.buttonEdit7.TabIndex = 3;
            this.buttonEdit7.TextBox = this.textBoxExt7;
            this.buttonEdit7.UseVisualStyle = true;
            // 
            // buttonEditChildButton13
            // 
            this.buttonEditChildButton13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton13.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.LeftEnd;
            this.buttonEditChildButton13.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton13.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton13.Image")));
            this.buttonEditChildButton13.Name = "buttonEditChildButton13";
            this.buttonEditChildButton13.PreferredWidth = 18;
            this.buttonEditChildButton13.TabIndex = 1;
            // 
            // buttonEditChildButton14
            // 
            this.buttonEditChildButton14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton14.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.RightEnd;
            this.buttonEditChildButton14.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton14.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton14.Image")));
            this.buttonEditChildButton14.Name = "buttonEditChildButton14";
            this.buttonEditChildButton14.PreferredWidth = 18;
            this.buttonEditChildButton14.TabIndex = 2;
            // 
            // buttonEditChildButton15
            // 
            this.buttonEditChildButton15.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton15.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo;
            this.buttonEditChildButton15.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton15.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton15.Image")));
            this.buttonEditChildButton15.Name = "buttonEditChildButton15";
            this.buttonEditChildButton15.PreferredWidth = 18;
            this.buttonEditChildButton15.TabIndex = 3;
            // 
            // buttonEditChildButton16
            // 
            this.buttonEditChildButton16.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton16.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Undo;
            this.buttonEditChildButton16.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton16.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton16.Image")));
            this.buttonEditChildButton16.Name = "buttonEditChildButton16";
            this.buttonEditChildButton16.PreferredWidth = 18;
            this.buttonEditChildButton16.TabIndex = 4;
            // 
            // textBoxExt7
            // 
            this.textBoxExt7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt7.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt7.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt7.Name = "textBoxExt7";
            this.textBoxExt7.OverflowIndicatorToolTipText = null;
            this.textBoxExt7.Size = new System.Drawing.Size(45, 15);
            this.textBoxExt7.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt7.TabIndex = 0;
            this.textBoxExt7.Text = "buttonEdit7";
            // 
            // buttonEdit6
            // 
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton10);
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton11);
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton12);
            this.buttonEdit6.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton12);
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton11);
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton10);
            this.buttonEdit6.Controls.Add(this.textBoxExt6);
            this.buttonEdit6.Location = new System.Drawing.Point(118, 142);
            this.buttonEdit6.MetroColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit6.Name = "buttonEdit6";
            this.buttonEdit6.ShowTextBox = false;
            this.buttonEdit6.Size = new System.Drawing.Size(121, 23);
            this.buttonEdit6.TabIndex = 2;
            this.buttonEdit6.TextBox = this.textBoxExt6;
            this.buttonEdit6.UseVisualStyle = true;
            // 
            // buttonEditChildButton10
            // 
            this.buttonEditChildButton10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton10.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Left;
            this.buttonEditChildButton10.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton10.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton10.Image")));
            this.buttonEditChildButton10.Name = "buttonEditChildButton10";
            this.buttonEditChildButton10.PreferredWidth = 18;
            this.buttonEditChildButton10.TabIndex = 1;
            // 
            // buttonEditChildButton11
            // 
            this.buttonEditChildButton11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton11.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Right;
            this.buttonEditChildButton11.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton11.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton11.Image")));
            this.buttonEditChildButton11.Name = "buttonEditChildButton11";
            this.buttonEditChildButton11.PreferredWidth = 18;
            this.buttonEditChildButton11.TabIndex = 2;
            // 
            // buttonEditChildButton12
            // 
            this.buttonEditChildButton12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton12.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.buttonEditChildButton12.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton12.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton12.Image")));
            this.buttonEditChildButton12.Name = "buttonEditChildButton12";
            this.buttonEditChildButton12.PreferredWidth = 18;
            this.buttonEditChildButton12.TabIndex = 3;
            // 
            // textBoxExt6
            // 
            this.textBoxExt6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt6.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt6.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt6.Name = "textBoxExt6";
            this.textBoxExt6.OverflowIndicatorToolTipText = null;
            this.textBoxExt6.Size = new System.Drawing.Size(63, 15);
            this.textBoxExt6.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt6.TabIndex = 0;
            this.textBoxExt6.Text = "buttonEdit6";
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton7);
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton8);
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton9);
            this.buttonEdit5.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton9);
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton8);
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton7);
            this.buttonEdit5.Controls.Add(this.textBoxExt5);
            this.buttonEdit5.Location = new System.Drawing.Point(351, 76);
            this.buttonEdit5.MetroColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.ShowTextBox = false;
            this.buttonEdit5.Size = new System.Drawing.Size(121, 23);
            this.buttonEdit5.TabIndex = 1;
            this.buttonEdit5.TextBox = this.textBoxExt5;
            this.buttonEdit5.UseVisualStyle = true;
            // 
            // buttonEditChildButton7
            // 
            this.buttonEditChildButton7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton7.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton7.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton7.Image")));
            this.buttonEditChildButton7.ImageIndex = 1;
            this.buttonEditChildButton7.ImageList = this.imageList1;
            this.buttonEditChildButton7.Name = "buttonEditChildButton7";
            this.buttonEditChildButton7.PreferredWidth = 18;
            this.buttonEditChildButton7.TabIndex = 1;
            this.buttonEditChildButton7.Text = "buttonEditChildButton7";
            // 
            // buttonEditChildButton8
            // 
            this.buttonEditChildButton8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton8.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton8.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton8.Image")));
            this.buttonEditChildButton8.ImageIndex = 2;
            this.buttonEditChildButton8.ImageList = this.imageList1;
            this.buttonEditChildButton8.Name = "buttonEditChildButton8";
            this.buttonEditChildButton8.PreferredWidth = 18;
            this.buttonEditChildButton8.TabIndex = 2;
            this.buttonEditChildButton8.Text = "buttonEditChildButton8";
            // 
            // buttonEditChildButton9
            // 
            this.buttonEditChildButton9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton9.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton9.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton9.Image")));
            this.buttonEditChildButton9.ImageIndex = 3;
            this.buttonEditChildButton9.ImageList = this.imageList1;
            this.buttonEditChildButton9.Name = "buttonEditChildButton9";
            this.buttonEditChildButton9.PreferredWidth = 18;
            this.buttonEditChildButton9.TabIndex = 3;
            this.buttonEditChildButton9.Text = "buttonEditChildButton9";
            // 
            // textBoxExt5
            // 
            this.textBoxExt5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt5.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt5.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt5.Name = "textBoxExt5";
            this.textBoxExt5.OverflowIndicatorToolTipText = null;
            this.textBoxExt5.Size = new System.Drawing.Size(63, 15);
            this.textBoxExt5.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt5.TabIndex = 0;
            this.textBoxExt5.Text = "buttonEdit5";
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton5);
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton6);
            this.buttonEdit4.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton6);
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton5);
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Controls.Add(this.textBoxExt4);
            this.buttonEdit4.Location = new System.Drawing.Point(118, 76);
            this.buttonEdit4.MetroColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.ShowTextBox = false;
            this.buttonEdit4.Size = new System.Drawing.Size(121, 23);
            this.buttonEdit4.TabIndex = 0;
            this.buttonEdit4.TextBox = this.textBoxExt4;
            this.buttonEdit4.UseVisualStyle = true;
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton4.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton4.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton4.Image")));
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 18;
            this.buttonEditChildButton4.TabIndex = 1;
            // 
            // buttonEditChildButton5
            // 
            this.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton5.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Up;
            this.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton5.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton5.Image")));
            this.buttonEditChildButton5.Name = "buttonEditChildButton5";
            this.buttonEditChildButton5.PreferredWidth = 18;
            this.buttonEditChildButton5.TabIndex = 2;
            // 
            // buttonEditChildButton6
            // 
            this.buttonEditChildButton6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditChildButton6.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Currency;
            this.buttonEditChildButton6.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton6.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton6.Image")));
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 3;
            // 
            // textBoxExt4
            // 
            this.textBoxExt4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt4.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt4.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt4.Name = "textBoxExt4";
            this.textBoxExt4.OverflowIndicatorToolTipText = null;
            this.textBoxExt4.Size = new System.Drawing.Size(63, 15);
            this.textBoxExt4.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt4.TabIndex = 0;
            this.textBoxExt4.Text = "buttonEdit4";
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.gradientPanel18);
            this.tabPageAdv1.Controls.Add(this.gradientPanel19);
            this.tabPageAdv1.Controls.Add(this.gradientPanel17);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(752, 440);
            this.tabPageAdv1.TabIndex = 4;
            this.tabPageAdv1.Text = "SplitButtonAdv";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // gradientPanel18
            // 
            this.gradientPanel18.BackColor = System.Drawing.Color.White;
            this.gradientPanel18.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.White, System.Drawing.SystemColors.Window);
            this.gradientPanel18.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.gradientPanel18.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel18.Controls.Add(this.gradientPanel20);
            this.gradientPanel18.Controls.Add(this.panel3);
            this.gradientPanel18.Controls.Add(this.panel4);
            this.gradientPanel18.Location = new System.Drawing.Point(285, 39);
            this.gradientPanel18.Name = "gradientPanel18";
            this.gradientPanel18.Size = new System.Drawing.Size(427, 237);
            this.gradientPanel18.TabIndex = 2;
            // 
            // gradientPanel20
            // 
            this.gradientPanel20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gradientPanel20.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel20.Controls.Add(this.label9);
            this.gradientPanel20.Controls.Add(this.radioButtonAdv17);
            this.gradientPanel20.Controls.Add(this.radioButtonAdv6);
            this.gradientPanel20.Controls.Add(this.radioButtonAdv4);
            this.gradientPanel20.Controls.Add(this.radioButtonAdv3);
            this.gradientPanel20.Location = new System.Drawing.Point(37, 128);
            this.gradientPanel20.Name = "gradientPanel20";
            this.gradientPanel20.Size = new System.Drawing.Size(352, 78);
            this.gradientPanel20.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "DropDownPosition";
            // 
            // radioButtonAdv17
            // 
            this.radioButtonAdv17.DrawFocusRectangle = false;
            this.radioButtonAdv17.Location = new System.Drawing.Point(264, 39);
            this.radioButtonAdv17.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv17.Name = "radioButtonAdv17";
            this.radioButtonAdv17.Size = new System.Drawing.Size(76, 21);
            this.radioButtonAdv17.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv17.TabIndex = 3;
            this.radioButtonAdv17.TabStop = false;
            this.radioButtonAdv17.Text = "Right";
            this.radioButtonAdv17.ThemesEnabled = false;
            this.radioButtonAdv17.CheckChanged += new System.EventHandler(this.radioButtonAdv17_CheckChanged);
            // 
            // radioButtonAdv6
            // 
            this.radioButtonAdv6.DrawFocusRectangle = false;
            this.radioButtonAdv6.Location = new System.Drawing.Point(89, 38);
            this.radioButtonAdv6.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv6.Name = "radioButtonAdv6";
            this.radioButtonAdv6.Size = new System.Drawing.Size(68, 21);
            this.radioButtonAdv6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv6.TabIndex = 2;
            this.radioButtonAdv6.TabStop = false;
            this.radioButtonAdv6.Text = "Left";
            this.radioButtonAdv6.ThemesEnabled = false;
            this.radioButtonAdv6.CheckChanged += new System.EventHandler(this.radioButtonAdv6_CheckChanged);
            // 
            // radioButtonAdv4
            // 
            this.radioButtonAdv4.Checked = true;
            this.radioButtonAdv4.DrawFocusRectangle = false;
            this.radioButtonAdv4.Location = new System.Drawing.Point(164, 39);
            this.radioButtonAdv4.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv4.Name = "radioButtonAdv4";
            this.radioButtonAdv4.Size = new System.Drawing.Size(85, 21);
            this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv4.TabIndex = 1;
            this.radioButtonAdv4.Text = "Bottom";
            this.radioButtonAdv4.ThemesEnabled = false;
            this.radioButtonAdv4.CheckChanged += new System.EventHandler(this.radioButtonAdv4_CheckChanged);
            // 
            // radioButtonAdv3
            // 
            this.radioButtonAdv3.DrawFocusRectangle = false;
            this.radioButtonAdv3.Location = new System.Drawing.Point(14, 39);
            this.radioButtonAdv3.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv3.Name = "radioButtonAdv3";
            this.radioButtonAdv3.Size = new System.Drawing.Size(68, 21);
            this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv3.TabIndex = 0;
            this.radioButtonAdv3.TabStop = false;
            this.radioButtonAdv3.Text = "Top";
            this.radioButtonAdv3.ThemesEnabled = false;
            this.radioButtonAdv3.CheckChanged += new System.EventHandler(this.radioButtonAdv3_CheckChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(37, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 78);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ButtonMode";
            // 
            // radioButton2
            // 
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.Location = new System.Drawing.Point(36, 51);
            this.radioButton2.MetroColor = System.Drawing.Color.DarkGray;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 17);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "NormalMode";
            this.radioButton2.ThemesEnabled = false;
            this.radioButton2.CheckChanged += new System.EventHandler(this.radioButton2_CheckChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.Location = new System.Drawing.Point(36, 23);
            this.radioButton1.MetroColor = System.Drawing.Color.DarkGray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 22);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "ToogleMode";
            this.radioButton1.ThemesEnabled = false;
            this.radioButton1.CheckChanged += new System.EventHandler(this.radioButton1_CheckChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.buttonAdv3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(231, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 79);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "DropDown Item";
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.buttonAdv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.Location = new System.Drawing.Point(30, 41);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(91, 28);
            this.buttonAdv3.TabIndex = 1;
            this.buttonAdv3.Text = "Remove Items";
            this.buttonAdv3.UseVisualStyle = true;
            this.buttonAdv3.UseVisualStyleBackColor = false;
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // gradientPanel19
            // 
            this.gradientPanel19.BackColor = System.Drawing.Color.White;
            this.gradientPanel19.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.White, System.Drawing.SystemColors.Window);
            this.gradientPanel19.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.gradientPanel19.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel19.Controls.Add(this.splitButton1);
            this.gradientPanel19.Controls.Add(this.panel6);
            this.gradientPanel19.Location = new System.Drawing.Point(27, 39);
            this.gradientPanel19.Name = "gradientPanel19";
            this.gradientPanel19.Size = new System.Drawing.Size(230, 237);
            this.gradientPanel19.TabIndex = 3;
            // 
            // splitButton1
            // 
            this.splitButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.splitButton1.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton1.ForeColor = System.Drawing.Color.Black;
            this.splitButton1.Location = new System.Drawing.Point(41, 22);
            this.splitButton1.Name = "splitButton1";
            metroSplitButtonRenderer1.SplitButton = null;
            this.splitButton1.Renderer = metroSplitButtonRenderer1;
            this.splitButton1.ShowDropDownOnButtonClick = false;
            this.splitButton1.Size = new System.Drawing.Size(143, 35);
            this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;
            this.splitButton1.TabIndex = 3;
            this.splitButton1.Text = "SplitButton1";
            this.splitButton1.Checked += new System.EventHandler(this.splitButton1_Checked);
            this.splitButton1.UnChecked += new System.EventHandler(this.splitButton1_UnChecked);
            this.splitButton1.DropDowItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.splitButton1_DropDowItemClicked);
            this.splitButton1.Click += new System.EventHandler(this.splitButton1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderColor = System.Drawing.Color.LightGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.splitButton2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(41, 104);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(143, 102);
            this.panel6.TabIndex = 2;
            // 
            // splitButton2
            // 
            this.splitButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.splitButton2.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton2.ForeColor = System.Drawing.Color.Black;
            this.splitButton2.Location = new System.Drawing.Point(23, 38);
            this.splitButton2.Name = "splitButton2";
            metroSplitButtonRenderer2.SplitButton = null;
            this.splitButton2.Renderer = metroSplitButtonRenderer2;
            this.splitButton2.ShowDropDownOnButtonClick = false;
            this.splitButton2.Size = new System.Drawing.Size(97, 45);
            this.splitButton2.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;
            this.splitButton2.TabIndex = 1;
            this.splitButton2.Text = "Click";
            this.splitButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitButton2_MouseDown);
            this.splitButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitButton2_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customized";
            // 
            // gradientPanel17
            // 
            this.gradientPanel17.BackColor = System.Drawing.Color.Lavender;
            this.gradientPanel17.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.SystemColors.Window);
            this.gradientPanel17.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.gradientPanel17.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel17.Controls.Add(this.textBox1);
            this.gradientPanel17.Controls.Add(this.label4);
            this.gradientPanel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel17.Location = new System.Drawing.Point(0, 292);
            this.gradientPanel17.Name = "gradientPanel17";
            this.gradientPanel17.Size = new System.Drawing.Size(752, 148);
            this.gradientPanel17.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(26, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(685, 104);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(33, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Event Log";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.tabControl1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(757, 466);
            this.gradientPanel1.TabIndex = 16;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(777, 486);
            this.Controls.Add(this.gradientPanel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(789, 518);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buttons";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).EndInit();
            this.buttonEdit2.ResumeLayout(false);
            this.buttonEdit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.gradientPanel5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit7)).EndInit();
            this.buttonEdit7.ResumeLayout(false);
            this.buttonEdit7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).EndInit();
            this.buttonEdit6.ResumeLayout(false);
            this.buttonEdit6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).EndInit();
            this.buttonEdit5.ResumeLayout(false);
            this.buttonEdit5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).EndInit();
            this.buttonEdit4.ResumeLayout(false);
            this.buttonEdit4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt4)).EndInit();
            this.tabPageAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel18)).EndInit();
            this.gradientPanel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel20)).EndInit();
            this.gradientPanel20.ResumeLayout(false);
            this.gradientPanel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel19)).EndInit();
            this.gradientPanel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel6)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel17)).EndInit();
            this.gradientPanel17.ResumeLayout(false);
            this.gradientPanel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			Application.Run(new MainForm());
		}

		

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#region File
		public void buttonEditChildButton1_Click(object sender, System.EventArgs e)
		{
			//<samplecodeblock name="ButtonEdit ChildButtonClick">
			//buttonEditChildButton1_Click
			OpenFileDialog dlg = new OpenFileDialog(); 
			dlg.Title = "Open file" ; 
			dlg.InitialDirectory = "c:\\" ; 
			dlg.Filter = "All files (*.*)|*.*" ; 
          
			if(dlg.ShowDialog() == DialogResult.OK)  
				this.buttonEdit1.TextBox.Text = dlg.FileName; 
			//</samplecodeblock>
		}
		#endregion

		#region Folder
		private void buttonEditChildButton2_Click(object sender, System.EventArgs e)
		{
			FolderBrowser browse = new FolderBrowser();
			browse.FolderBrowserCallback += new FolderBrowserCallbackEventHandler(buttonEditChildButton2_Browsed);
			browse.ShowDialog(this);
		}
		#endregion

		#region buttonEditChildButton2_Browsed
		private void buttonEditChildButton2_Browsed(object sender, FolderBrowserCallbackEventArgs e)
		{
			this.buttonEdit2.TextBox.Text = e.Path;
		}
		#endregion
		#region ShowpopUp

		private void buttonEditChildButton3_Click(object sender, System.EventArgs e)
		{
			if(this.popupControlContainer1.IsShowing() == true)
			{
				this.popupControlContainer1.HidePopup(PopupCloseType.Done);
			}
			else
			{
				this.popupControlContainer1.PopupParent = this.buttonEdit3;
				this.popupControlContainer1.ShowPopup(Point.Empty);
			}
		}
		#endregion

		#region samplecodeblock
		private void CodeGen_InitializeComponent()
		{
			//<samplecodeblock name="ButtonEdit InitializeComponent">
			// InitializeComponent sample
			this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();

			this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
			this.buttonEdit1.SuspendLayout();
			this.SuspendLayout();

			this.buttonEdit1.Buttons.Add(this.buttonEditChildButton1);
			this.buttonEdit1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.buttonEditChildButton1});
			this.buttonEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit1.Location = new System.Drawing.Point(8, 16);
			this.buttonEdit1.Name = "buttonEdit1";
			this.buttonEdit1.SelectionLength = 0;
			this.buttonEdit1.SelectionStart = 0;
			this.buttonEdit1.ShowTextBox = true;
			this.buttonEdit1.Size = new System.Drawing.Size(368, 22);
			this.buttonEdit1.TabIndex = 0;
			this.buttonEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// buttonEditChildButton1
			// 
			this.buttonEditChildButton1.ButtonAlign = Syncfusion.Windows.Forms.Tools.ButtonAlignment.Right;
			this.buttonEditChildButton1.ButtonEditParent = this.buttonEdit1;
			this.buttonEditChildButton1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
			this.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditChildButton1.Name = "buttonEditChildButton1";
			this.buttonEditChildButton1.PreferredWidth = 16;
			this.buttonEditChildButton1.TabIndex = 1;
			this.buttonEditChildButton1.Click += new System.EventHandler(this.buttonEditChildButton1_Click);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(400, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {	  this.buttonEdit1});
			this.Text = "Syncfusion ButtonEdit Demo";
			this.buttonEdit1.ResumeLayout(false);
			this.ResumeLayout(false);
			//</samplecodeblock>
		}
		#endregion

        #region buttonEdit1_ButtonClicked
		private void buttonEdit1_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
		{
			string item = args.ClickedButton.Name;
			string eventlogmessage = String.Format("Event: {0} Item: {1}\r\n", "ButtonClicked", item);
			textBox2.Text = textBox2.Text + eventlogmessage;
		}
		#endregion

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		
		}

		private void gradientLabel1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void splitButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SplitButton is Clicked\r\n" + textBox1.Text;
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            if (buttonAdv3.Text == "Remove Items")
            {
                this.splitButton1.DropDownItems.Clear();
                textBox1.Text = "DropDownItems Removed\r\n" + textBox1.Text;
                buttonAdv3.Text = "Add Items";
            }
            else
            {
                this.splitButton1.DropDownItems.Add(new toolstripitem());
                this.splitButton1.DropDownItems.Add(new toolstripitem());
                this.splitButton1.DropDownItems.Add(new toolstripitem());
                this.splitButton1.DropDownItems.Add(new toolstripitem());
                this.splitButton1.DropDownItems.Add(new toolstripitem());
                this.splitButton1.DropDownItems[0].Text = "Item1";
                this.splitButton1.DropDownItems[1].Text = "Item2";
                this.splitButton1.DropDownItems[2].Text = "Item3";
                this.splitButton1.DropDownItems[3].Text = "Item4";
                this.splitButton1.DropDownItems[4].Text = "Item5";
                textBox1.Text = "DropDownItems Added\r\n" + textBox1.Text;
                buttonAdv3.Text = "Remove Items";
            }
        }

        private void splitButton1_DropDowItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBox1.Text = e.ClickedItem.Text + " is Clicked\r\n" + textBox1.Text;
        }

        private void radioButton2_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Normal;
                textBox1.Text = "SplitButton Turns NormalMode\r\n" + textBox1.Text;
            }
        }

        private void radioButton1_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Toggle;
                textBox1.Text = "SplitButton Turns ToogleMode\r\n" + textBox1.Text;
            }
        }

        private void radioButtonAdv3_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv3.Checked)
            {
                this.splitButton1.DropDownPosition = Position.Top;
                this.splitButton2.DropDownPosition = Position.Top;
            }
        }

        private void radioButtonAdv6_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv6.Checked)
            {
                this.splitButton1.DropDownPosition = Position.Left;
                this.splitButton2.DropDownPosition = Position.Left;
            }
        }

        private void radioButtonAdv4_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv4.Checked)
            {
                this.splitButton1.DropDownPosition = Position.Bottom;
                this.splitButton2.DropDownPosition = Position.Bottom;
            }
        }

        private void radioButtonAdv17_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv17.Checked)
            {
                this.splitButton1.DropDownPosition = Position.Right;
                this.splitButton2.DropDownPosition = Position.Right;
            }
        }

        private void splitButton1_UnChecked(object sender, EventArgs e)
        {
            textBox1.Text = "SplitButton is Unchecked\r\n" + textBox1.Text;
        }

        private void splitButton1_Checked(object sender, EventArgs e)
        {
            textBox1.Text = "SplitButton is Checked\r\n" + textBox1.Text;
        }

        private void splitButton2_MouseDown(object sender, MouseEventArgs e)
        {
            startcolor = Color.DarkGoldenrod;
            this.Invalidate();
        }

        private void splitButton2_MouseUp(object sender, MouseEventArgs e)
        {
            startcolor = Color.LightGreen;
            endcolor = Color.Green;
        }
	}
    public class CustomRenderer : ISplitButtonRenderer
    {
        private SplitButton splitButton;

        #region ISplitButtonRenderer Members



        public void DrawText(PaintEventArgs e, string text, Font font, Color color, int totalwidth, int totalheight, int splitwidth)
        {

            SolidBrush brush = new SolidBrush(color);
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.EllipsisCharacter;
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Rectangle textArea = new Rectangle(7, 1, totalwidth - splitwidth, totalheight);
            e.Graphics.DrawString(text, font, brush, textArea, format);

            Rectangle imageRect = new Rectangle(4, 11, 15, totalheight - 24);
            Image img = Image.FromFile(@"../../logo_16.ico");
            e.Graphics.DrawImage(img, imageRect);
            brush.Dispose();
        }

        public void DrawBorder(PaintEventArgs e, int width, int height, int splitwidth, Color outerColor, Color innerColor, Color arrowOuter, Color arrowInner, Color buttonInner)
        {
            // Can Customize the Border Color of the SplitButton 
            // Outer Color is Changed 
            MainForm frm = new MainForm();
            Color color1 = frm.startcolor;
            Color color2 = frm.endcolor;
            Brush linearGradientBrush = new LinearGradientBrush(
                          new Rectangle(0, 0, width, height), color1, color2, 90);
            e.Graphics.FillRectangle(linearGradientBrush, new Rectangle(0, 0, width, height));
            linearGradientBrush.Dispose();
            Pen outercolor = new Pen(Color.DarkGreen);
            Pen innercolor = new Pen(Color.LightGreen);
            Pen arrowinner = new Pen(Color.LightGreen);
            Pen arrowouter = new Pen(arrowOuter);
            Pen buttoninner = new Pen(buttonInner);

            e.Graphics.DrawLine(innercolor, new Point(1, 1), new Point(width - 2, 1));
            e.Graphics.DrawLine(innercolor, new Point(width - 2, 1), new Point(width - 2, height - 2));
            e.Graphics.DrawLine(innercolor, new Point(1, height - 2), new Point(width - 2, height - 2));
            e.Graphics.DrawLine(innercolor, new Point(1, 1), new Point(1, height - 2));

            e.Graphics.DrawLine(arrowouter, new Point(width - splitwidth, 0), new Point(width - splitwidth, height - 1));

            e.Graphics.DrawLine(buttoninner, new Point(width - splitwidth - 1, 2), new Point(width - splitwidth - 1, height - 3));

            e.Graphics.DrawRectangle(arrowinner, width - splitwidth + 1, 1, splitwidth - 3, height - 3);

            e.Graphics.DrawLine(outercolor, new Point(1, 0), new Point(width - 2, 0));
            e.Graphics.DrawLine(outercolor, new Point(width - 2, 0), new Point(width - 2, 1));
            e.Graphics.DrawLine(outercolor, new Point(width - 1, 1), new Point(width - 1, height - 2));
            e.Graphics.DrawLine(outercolor, new Point(width - 2, height - 2), new Point(width - 2, height - 1));
            e.Graphics.DrawLine(outercolor, new Point(1, height - 1), new Point(width - 2, height - 1));
            e.Graphics.DrawLine(outercolor, new Point(1, height - 1), new Point(1, height - 2));
            e.Graphics.DrawLine(outercolor, new Point(0, 1), new Point(0, height - 2));
            e.Graphics.DrawLine(outercolor, new Point(1, 0), new Point(1, 1));


            buttoninner.Dispose();
            innercolor.Dispose();
            arrowinner.Dispose();
            arrowinner.Dispose();
            outercolor.Dispose();

        }

        public void DrawArrow(int left, int top, int width, int height, PaintEventArgs e, Color ArrowColor)
        {
            //Customize arrow as image
            Image arrowImage = Image.FromFile(@"../../arrow4.png");
            Rectangle imageRect = new Rectangle(left + 4, top + 14, width - 9, height - 28);
            e.Graphics.DrawImage(arrowImage, imageRect);

        }

        #endregion

        #region ISplitButtonRenderer Members

        public SplitButton SplitButton
        {
            get
            {
                return splitButton;
            }
            set
            {
                splitButton = value;
            }
        }

        #endregion
    }
}
