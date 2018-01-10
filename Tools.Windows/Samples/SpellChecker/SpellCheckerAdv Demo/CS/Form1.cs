#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SpellCheckerAdv_2012
{
    public partial class Form1 : MetroForm
    {
        TextBoxSpellEditor TextEditor;
        ContextMenu textboxcontextmenu = new ContextMenu();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Metro;
            TextEditor = new TextBoxSpellEditor(this.textBox3);
            SpellEditor = TextEditor;
            this.spellCheckerAdv1.PerformSpellCheckForControl(SpellEditor);
            this.textBox3.ContextMenu = textboxcontextmenu;
            this.Load += new EventHandler(Form1_Load);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            if (!File.Exists("C:\\ProgramData\\Microsoft Corporation\\Microsoft® Visual Studio® 2012\\11.0.50727.1\\Custom_Dictionay.dic"))
                this.spellCheckerAdv1.CustomDictionaryPath = "C:\\ProgramData\\ClipboardFunctionsDemo\\SpellCheckerDemo_2008\\1.0.0.0\\Custom_Dictionay.dic";
        }
        #region [IconFile]
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
        #endregion

        /// <summary>
        /// Gets or sets the ISpellCheckerAdvEditorTools interface.
        /// </summary>
        public ISpellCheckerAdvEditorTools SpellEditor
        {
            get;
            set;
        }

        #region[Events]

        void Form1_Load(object sender, EventArgs e)
        {
            this.textBox3.HideSelection = true;
        }      

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreEmailAddress = this.checkBoxAdv1.Checked;
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreUpperCaseWords = this.checkBoxAdv2.Checked;
        }

        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreAlphaNumericWords = this.checkBoxAdv3.Checked;
        }

        private void checkBoxAdv4_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreUrl = this.checkBoxAdv4.Checked;
        }

        private void checkBoxAdv5_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreMixedCaseWords = this.checkBoxAdv5.Checked;
        }

        private void buttonAdv1_Click_1(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.SpellCheck(new SpellCheckerAdvEditorWrapper(this.textBox3));
        }

        #endregion

       
    }
}
