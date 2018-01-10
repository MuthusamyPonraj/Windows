#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
namespace NavigationDrawer_2010
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
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
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            Syncfusion.Windows.Forms.CaptionLabel captionLabel1 = new Syncfusion.Windows.Forms.CaptionLabel();
            this.navigationDrawer1 = new Syncfusion.Windows.Forms.Tools.NavigationDrawer();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SlideOnTop = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Apply = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Reveal = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Push = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BottomPosition = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.TopPosition = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rightPosition = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.leftposition = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drawerMenuItem1 = new NavigationDrawer_2010.DrawMenuItemExt();
            this.drawerMenuItem2 = new NavigationDrawer_2010.DrawMenuItemExt();
            this.drawerMenuItem3 = new NavigationDrawer_2010.DrawMenuItemExt();
            this.drawerMenuItem4 = new NavigationDrawer_2010.DrawMenuItemExt();
            this.drawerMenuItem5 = new NavigationDrawer_2010.DrawMenuItemExt();
            this.header = new DrawerHeader();
            this.SettingsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlideOnTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reveal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Push)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftposition)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationDrawer1
            // 
            this.navigationDrawer1.BackColor = System.Drawing.Color.White;
            this.navigationDrawer1.Dock = System.Windows.Forms.DockStyle.Fill;
            header.Size = new System.Drawing.Size(header.Width, 120);
            this.navigationDrawer1.Items.Add(this.header);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem1);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem2);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem3);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem4);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem5);
            this.navigationDrawer1.Location = new System.Drawing.Point(0, 0);
            this.navigationDrawer1.Name = "navigationDrawer1";
            this.navigationDrawer1.Size = new System.Drawing.Size(988, 719);
            this.navigationDrawer1.TabIndex = 0;
            this.navigationDrawer1.Text = "navigationDrawer1";
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images4"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images5"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images6"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images7"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images8"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images9"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images10"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images11"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images12"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images13")))});
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.panel2);
            this.SettingsPanel.Controls.Add(this.panel3);
            this.SettingsPanel.Controls.Add(this.panel1);
            this.SettingsPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsPanel.Location = new System.Drawing.Point(534, 9);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(294, 661);
            this.SettingsPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.SlideOnTop);
            this.panel2.Controls.Add(this.Apply);
            this.panel2.Controls.Add(this.Reveal);
            this.panel2.Controls.Add(this.Push);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 337);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Transition";
            // 
            // Cancel
            // 
            this.Cancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.Cancel.BeforeTouchSize = new System.Drawing.Size(85, 27);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.IsBackStageButton = false;
            this.Cancel.Location = new System.Drawing.Point(165, 242);
            this.Cancel.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(155)))), ((int)(((byte)(202)))));
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(85, 27);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Reset";
            this.Cancel.UseVisualStyle = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SlideOnTop
            // 
            this.SlideOnTop.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.SlideOnTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlideOnTop.Location = new System.Drawing.Point(42, 73);
            this.SlideOnTop.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.SlideOnTop.Name = "SlideOnTop";
            this.SlideOnTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SlideOnTop.Size = new System.Drawing.Size(150, 21);
            this.SlideOnTop.TabIndex = 11;
            this.SlideOnTop.Text = "Slide On Top";
            this.SlideOnTop.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.SlideOnTop.ThemesEnabled = false;
            // 
            // Apply
            // 
            this.Apply.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.Apply.BeforeTouchSize = new System.Drawing.Size(85, 27);
            this.Apply.ForeColor = System.Drawing.Color.White;
            this.Apply.IsBackStageButton = false;
            this.Apply.Location = new System.Drawing.Point(43, 242);
            this.Apply.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(155)))), ((int)(((byte)(202)))));
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(85, 27);
            this.Apply.TabIndex = 14;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyle = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Reveal
            // 
            this.Reveal.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Reveal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reveal.Location = new System.Drawing.Point(42, 130);
            this.Reveal.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.Reveal.Name = "Reveal";
            this.Reveal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Reveal.Size = new System.Drawing.Size(150, 21);
            this.Reveal.TabIndex = 12;
            this.Reveal.Text = "Reveal";
            this.Reveal.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Reveal.ThemesEnabled = false;
            // 
            // Push
            // 
            this.Push.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Push.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Push.Location = new System.Drawing.Point(42, 188);
            this.Push.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.Push.Name = "Push";
            this.Push.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Push.Size = new System.Drawing.Size(150, 21);
            this.Push.TabIndex = 13;
            this.Push.Text = "Push";
            this.Push.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Push.ThemesEnabled = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 322);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.panel3.Size = new System.Drawing.Size(294, 2);
            this.panel3.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BottomPosition);
            this.panel1.Controls.Add(this.TopPosition);
            this.panel1.Controls.Add(this.rightPosition);
            this.panel1.Controls.Add(this.leftposition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 322);
            this.panel1.TabIndex = 16;
            // 
            // BottomPosition
            // 
            this.BottomPosition.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.BottomPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomPosition.Location = new System.Drawing.Point(39, 259);
            this.BottomPosition.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BottomPosition.Name = "BottomPosition";
            this.BottomPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BottomPosition.Size = new System.Drawing.Size(150, 21);
            this.BottomPosition.TabIndex = 15;
            this.BottomPosition.Text = "Bottom";
            this.BottomPosition.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.BottomPosition.ThemesEnabled = false;
            // 
            // TopPosition
            // 
            this.TopPosition.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.TopPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPosition.Location = new System.Drawing.Point(39, 206);
            this.TopPosition.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.TopPosition.Name = "TopPosition";
            this.TopPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopPosition.Size = new System.Drawing.Size(150, 21);
            this.TopPosition.TabIndex = 14;
            this.TopPosition.Text = "Top";
            this.TopPosition.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.TopPosition.ThemesEnabled = false;
            // 
            // rightPosition
            // 
            this.rightPosition.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rightPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPosition.Location = new System.Drawing.Point(39, 157);
            this.rightPosition.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rightPosition.Name = "rightPosition";
            this.rightPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rightPosition.Size = new System.Drawing.Size(150, 21);
            this.rightPosition.TabIndex = 13;
            this.rightPosition.Text = "Right";
            this.rightPosition.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rightPosition.ThemesEnabled = false;
            // 
            // leftposition
            // 
            this.leftposition.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.leftposition.DrawFocusRectangle = false;
            this.leftposition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftposition.Location = new System.Drawing.Point(39, 107);
            this.leftposition.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.leftposition.Name = "leftposition";
            this.leftposition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.leftposition.Size = new System.Drawing.Size(150, 21);
            this.leftposition.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.leftposition.TabIndex = 12;
            this.leftposition.Text = "Left";
            this.leftposition.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.leftposition.ThemesEnabled = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Settings";
            // 
            // drawerMenuItem1
            // 
            this.drawerMenuItem1.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem1.DefaultColor = System.Drawing.Color.White;
            this.drawerMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerMenuItem1.HoverColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem1.ItemText = "Home";
            this.drawerMenuItem1.Location = new System.Drawing.Point(2, 0);
            this.drawerMenuItem1.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem1.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem1.Name = "drawerMenuItem1";
            //this.drawerMenuItem1.Selected = false;
            this.drawerMenuItem1.SelectionColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem1.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem1.TabIndex = 0;
            this.drawerMenuItem1.Text = "Home";
            this.drawerMenuItem1.TextColor = System.Drawing.Color.White;
            // 
            // drawerMenuItem2
            // 
            this.drawerMenuItem2.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem2.DefaultColor = System.Drawing.Color.White;
            this.drawerMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerMenuItem2.HoverColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem2.ItemText = "People";
            this.drawerMenuItem2.Location = new System.Drawing.Point(2, 50);
            this.drawerMenuItem2.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem2.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem2.Name = "drawerMenuItem2";
            //this.drawerMenuItem2.Selected = false;
            this.drawerMenuItem2.SelectionColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem2.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem2.TabIndex = 1;
            this.drawerMenuItem2.Text = "People";
            this.drawerMenuItem2.TextColor = System.Drawing.Color.White;
            // 
            // drawerMenuItem3
            // 
            this.drawerMenuItem3.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem3.DefaultColor = System.Drawing.Color.White;
            this.drawerMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerMenuItem3.HoverColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem3.ItemText = "Profile";
            this.drawerMenuItem3.Location = new System.Drawing.Point(2, 100);
            this.drawerMenuItem3.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem3.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem3.Name = "drawerMenuItem3";
            //this.drawerMenuItem3.Selected = false;
            this.drawerMenuItem3.SelectionColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem3.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem3.TabIndex = 2;
            this.drawerMenuItem3.Text = "Profile";
            this.drawerMenuItem3.TextColor = System.Drawing.Color.White;
            // 
            // drawerMenuItem4
            // 
            this.drawerMenuItem4.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem4.DefaultColor = System.Drawing.Color.White;
            this.drawerMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerMenuItem4.HoverColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem4.ItemText = "Photos";
            this.drawerMenuItem4.Location = new System.Drawing.Point(2, 150);
            this.drawerMenuItem4.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem4.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem4.Name = "drawerMenuItem4";
            //this.drawerMenuItem4.Selected = false;
            this.drawerMenuItem4.SelectionColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem4.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem4.TabIndex = 3;
            this.drawerMenuItem4.Text = "Photos";
            this.drawerMenuItem4.TextColor = System.Drawing.Color.White;
            // 
            // drawerMenuItem5
            // 
            this.drawerMenuItem5.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem5.DefaultColor = System.Drawing.Color.White;
            this.drawerMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerMenuItem5.HoverColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem5.ItemText = "About us";
            this.drawerMenuItem5.Location = new System.Drawing.Point(2, 200);
            this.drawerMenuItem5.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem5.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem5.Name = "drawerMenuItem5";
            //this.drawerMenuItem5.Selected = false;
            this.drawerMenuItem5.SelectionColor = System.Drawing.Color.LightGray;
            this.drawerMenuItem5.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem5.TabIndex = 4;
            this.drawerMenuItem5.Text = "About us";
            this.drawerMenuItem5.TextColor = System.Drawing.Color.White;
            this.drawerMenuItem5.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(221)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(221)))));
            this.BorderThickness = 11;
            this.CaptionBarHeight = 50;
            captionImage1.Image = global::NavigationDrawer_2010.Properties.Resources.TriggerImage6_1;
            captionImage1.Location = new System.Drawing.Point(6, 15);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(45, 28);
            this.CaptionImages.Add(captionImage1);
            captionLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            captionLabel1.ForeColor = System.Drawing.Color.White;
            captionLabel1.Location = new System.Drawing.Point(55, 16);
            captionLabel1.Name = "CaptionLabel1";
            captionLabel1.Text = "Home";
            this.CaptionLabels.Add(captionLabel1);
            this.ClientSize = new System.Drawing.Size(988, 719);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.navigationDrawer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(221)))));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SettingsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlideOnTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reveal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Push)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftposition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.NavigationDrawer navigationDrawer1;
        private DrawMenuItemExt drawerMenuItem1;
        private DrawMenuItemExt drawerMenuItem2;
        private DrawMenuItemExt drawerMenuItem3;
        private DrawMenuItemExt drawerMenuItem4;
        private DrawMenuItemExt drawerMenuItem5;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private System.Windows.Forms.Panel SettingsPanel;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Push;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Reveal;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv SlideOnTop;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv Cancel;
        private Syncfusion.Windows.Forms.ButtonAdv Apply;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv BottomPosition;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv TopPosition;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rightPosition;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv leftposition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DrawerHeader header;
    }
}

