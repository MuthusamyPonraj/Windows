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
            this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016Colorful;
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

            UpdateSpellCheckerAdvStyleforOffice2016Themes();
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

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == 0)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Metro;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 1)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016Colorful;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 2)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016White;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 3)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016DarkGray;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 4)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016Black;
            }

            UpdateSpellCheckerAdvStyleforOffice2016Themes();

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
        private void UpdateSpellCheckerAdvStyleforOffice2016Themes()
        {
           
            if (this.spellCheckerAdv1.VisualStyle == SpellCheckerAdvStyle.Metro)
            {
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = System.Drawing.Color.Black;
                this.CaptionBarColor = System.Drawing.Color.White;
                this.CaptionForeColor = ColorTranslator.FromHtml("#ff343434");
                this.autoLabel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel3.BackColor = ColorTranslator.FromHtml("#16a5dc");
                this.autoLabel4.BackColor = ColorTranslator.FromHtml("#16a5dc");
                this.label1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel1.ForeColor = System.Drawing.Color.Black;
                this.autoLabel2.ForeColor = System.Drawing.Color.Black;
                this.autoLabel3.ForeColor = System.Drawing.Color.White;
                this.autoLabel4.ForeColor = System.Drawing.Color.White;
                this.textBox3.ForeColor = System.Drawing.Color.Black;
                this.label1.ForeColor = System.Drawing.Color.Black;
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Metro;
                this.buttonAdv1.Appearance = ButtonAppearance.Metro;
                this.spellCheckerAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
                this.ShowIcon = true;
                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
                this.panel1.BorderStyle = BorderStyle.None;
                this.panel7.BorderStyle = BorderStyle.None;
                this.panel8.BorderStyle = BorderStyle.None;
            }
            else if (this.spellCheckerAdv1.VisualStyle == SpellCheckerAdvStyle.Office2016Colorful)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = System.Drawing.Color.White;
                this.CaptionForeColor = ColorTranslator.FromHtml("#ff343434");
                this.autoLabel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel3.BackColor = ColorTranslator.FromHtml("#16a5dc");
                this.autoLabel4.BackColor = ColorTranslator.FromHtml("#16a5dc");
                this.textBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel3.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel4.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label1.ForeColor= ColorTranslator.FromHtml("#262626");
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Colorful;
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.panel1.BorderStyle = BorderStyle.None;
                this.panel7.BorderStyle = BorderStyle.None;
                this.panel8.BorderStyle = BorderStyle.None;
            }
            else if (this.spellCheckerAdv1.VisualStyle == SpellCheckerAdvStyle.Office2016Black)
            {
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.autoLabel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel3.BackColor = ColorTranslator.FromHtml("#363636");
                this.autoLabel4.BackColor = ColorTranslator.FromHtml("#363636");
                this.textBox3.BackColor = ColorTranslator.FromHtml("#262626");
                this.label1.BackColor= ColorTranslator.FromHtml("#262626");
                this.autoLabel1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.autoLabel3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.autoLabel4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.textBox3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Office2016Black;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Black;
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#363636");
                this.panel1.BorderStyle = BorderStyle.None;
                this.panel7.BorderStyle = BorderStyle.None;
                this.panel8.BorderStyle = BorderStyle.None;
            }
            else if (this.spellCheckerAdv1.VisualStyle == SpellCheckerAdvStyle.Office2016White)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.autoLabel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.BackColor= ColorTranslator.FromHtml("#ffffff");
                this.autoLabel1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.textBox3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label1.ForeColor= ColorTranslator.FromHtml("#262626");
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Office2016White;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016White;
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.panel1.BorderStyle = BorderStyle.None;
                this.panel7.BorderStyle = BorderStyle.None;
                this.panel8.BorderStyle = BorderStyle.None;
            }
            else if (this.spellCheckerAdv1.VisualStyle == SpellCheckerAdvStyle.Office2016DarkGray)
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.autoLabel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#666666");
                this.autoLabel3.BackColor = ColorTranslator.FromHtml("#505050");
                this.autoLabel4.BackColor = ColorTranslator.FromHtml("#505050");
                this.textBox3.BackColor = ColorTranslator.FromHtml("#666666");
                this.label1.BackColor = ColorTranslator.FromHtml("#666666");
                this.autoLabel1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.autoLabel3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.autoLabel4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.textBox3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016DarkGray;
                this.buttonAdv1.ForeColor = Color.Black;
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.panel1.BorderStyle = BorderStyle.Fixed3D;
                this.panel7.BorderStyle = BorderStyle.Fixed3D;
                this.panel8.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        #endregion


    }
}
