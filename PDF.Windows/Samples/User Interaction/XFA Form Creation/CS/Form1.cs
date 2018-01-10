#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Xfa;


namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private System.Windows.Forms.Button btnPDFForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;      

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPDFForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();          
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPDFForm
            // 
            this.btnPDFForm.BackColor = System.Drawing.Color.Transparent;
            this.btnPDFForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPDFForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPDFForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPDFForm.Image = ((System.Drawing.Image)(resources.GetObject("btnPDFForm.Image")));
            this.btnPDFForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDFForm.Location = new System.Drawing.Point(294, 167);
            this.btnPDFForm.Name = "btnPDFForm";
            this.btnPDFForm.Size = new System.Drawing.Size(75, 23);
            this.btnPDFForm.TabIndex = 0;
            this.btnPDFForm.Text = "PDF";
            this.btnPDFForm.UseVisualStyleBackColor = false;
            this.btnPDFForm.Click += new System.EventHandler(this.btnPDFForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-1, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 105);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
                " that Adobe Reader or its equivalent is required to view the resultant document." +
                "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 90);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
                      
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 200);           
            this.Controls.Add(this.btnPDFForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    XFA Form Creation";
            this.CaptionAlign = HorizontalAlignment.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private void btnPDFForm_Click(object sender, System.EventArgs e)
        {
            PdfXfaDocument doc = new PdfXfaDocument();
          
            PdfXfaPage page = doc.Pages.Add();           

            PdfFont font0 = new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold);
            PdfFont font1 = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Italic);
            PdfFont font2 = new PdfStandardFont(PdfFontFamily.TimesRoman, 9, PdfFontStyle.Italic);
            PdfFont font3 = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);

            PdfXfaForm mainForm = new PdfXfaForm(PdfXfaFlowDirection.Vertical, page.GetClientSize().Width);
            PdfXfaForm subForm1 = new PdfXfaForm(PdfXfaFlowDirection.Horizontal,page.GetClientSize().Width - 40);
            
            PdfXfaForm headerForm = new PdfXfaForm(page.GetClientSize().Width);
            headerForm.Width = page.GetClientSize().Width;
            headerForm.Border = new PdfXfaBorder() ;
            headerForm .Border .Width =0;
            headerForm.Border.FillColor = new PdfXfaSolidBrush(new PdfColor(Color.OrangeRed));

            PdfXfaTextElement cr = new PdfXfaTextElement("CONFERENCE REGISTRATION") ;
            cr.HorizontalAlignment = PdfXfaHorizontalAlignment.Center;
            cr.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            cr.Width = page.GetClientSize().Width;
            cr.Height = 60;
            cr.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 26, PdfFontStyle.Bold);
            cr.ForeColor = new PdfColor(Color.White);
            headerForm.Fields.Add(cr);

            mainForm.Fields.Add(headerForm);

            subForm1.Margins.Left = 40;
            subForm1.Margins.Bottom = 40;            

            PdfXfaTextElement name = new PdfXfaTextElement("Name", font0);
            name.Width = 500;
            name.Height = 70;
            name.VerticalAlignment = PdfXfaVerticalAlignment.Bottom;
            name.Margins.Top = 20;
            subForm1.Fields.Add(name);

            PdfXfaLine line1 = new PdfXfaLine(new PointF(0, 0), new PointF(450, 0), 1.2f);
            line1.Color = new PdfColor(Color.LightGray);
            subForm1.Fields.Add(line1);

            PdfXfaRectangleField rectangle = new PdfXfaRectangleField("rect", new SizeF(60, 1.2f));
            rectangle .Visibility = PdfXfaVisibility.Invisible;
            subForm1.Fields.Add(rectangle);

            PdfXfaCaption caption1 = new PdfXfaCaption();
            caption1.VerticalAlignment = PdfXfaVerticalAlignment.Bottom;
            caption1.HorizontalAlignment = PdfXfaHorizontalAlignment.Center;
            caption1.Position = PdfXfaPosition.Bottom;
            caption1.Font = font2;
            caption1.Width = caption1.Font.MeasureString("first Name").Height + 3;

            PdfXfaComboBoxField title = new PdfXfaComboBoxField("title", new SizeF(40, 40));
            title.Caption = caption1.Clone() as PdfXfaCaption;
            title.Width = 34;
            title.Height = 40;
            title.Caption.Text = "Title";
            title.Border.Style = PdfXfaBorderStyle.Lowered;
            title.HorizontalAlignment = PdfXfaHorizontalAlignment.JustifyAll;
            title.Items.Add("Mr");
            title.Items.Add("Mrs");
            title.Items.Add("Miss");
            subForm1.Fields.Add(title);
            title.Margins.Top = 7;

            PdfXfaTextBoxField fn = new PdfXfaTextBoxField("fn", new SizeF(207, 40)) ;
            fn.Caption = caption1.Clone() as PdfXfaCaption;
            fn.Width = 208;
            fn.Height = 40;
            fn.Caption.Text = "First Name";
            fn.Margins.Left = 5;
            fn.Margins.Top = 7;        
            fn.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(fn);

            PdfXfaTextBoxField ln = new PdfXfaTextBoxField("ln", new SizeF(214, 50)) ;
            ln.Caption = caption1.Clone() as PdfXfaCaption;
            ln.Width = 208;
            ln.Height = 40;
            ln.Caption.Text = "Last Name";
            ln.Border.Style = PdfXfaBorderStyle.Lowered;
            ln.Margins.Left = 5;
            ln.Margins.Top = 7;            
            subForm1.Fields.Add(ln);

            caption1.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            caption1.VerticalAlignment = PdfXfaVerticalAlignment.Top;
            caption1.Position = PdfXfaPosition.Top;
            caption1.Font = font3;


            PdfXfaDateTimeField dob = new PdfXfaDateTimeField("dob", new SizeF(450, 40));
            dob.Caption = caption1.Clone() as PdfXfaCaption;
            dob.Caption.Text = "Date of Birth";
            dob.Margins.Top = 7; 
            dob.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;			
            dob.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(dob);


            PdfXfaTextBoxField company = new PdfXfaTextBoxField("company", new SizeF(450, 40)) ;
            company .Width = 450;
            company .Height = 40;
            company.Caption = caption1.Clone() as PdfXfaCaption;
            company.Caption.Text = "Company";
            company.Margins.Top = 7;            
            company.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(company);

            PdfXfaTextBoxField jt = new PdfXfaTextBoxField("jt", new SizeF(500, 50));
            jt.Width = 450;
            jt.Height = 40;
            jt.Caption = caption1.Clone() as PdfXfaCaption;
            jt.Caption.Text = "Job Title";
            jt.Border.Style = PdfXfaBorderStyle.Lowered;
            jt.Margins.Top = 7;           
            subForm1.Fields.Add(jt);

            PdfXfaTextBoxField jd = new PdfXfaTextBoxField("jd", new SizeF(500, 120)) ;
            jd.Width = 450;
            jd.Caption = caption1.Clone() as PdfXfaCaption;
            jd.Caption.Text = "Job Description";
            jd.Type = PdfXfaTextBoxType.Multiline;
            jd.Border.Style = PdfXfaBorderStyle.Lowered;
            jd.Margins.Top = 7;
            subForm1.Fields.Add(jd);

            PdfXfaTextElement address = new PdfXfaTextElement("Address", font0);
            address.Width = 500;
            address.Height = 40;
            address.VerticalAlignment = PdfXfaVerticalAlignment.Bottom;
            address.Margins.Top = 10;
            subForm1.Fields.Add(address);
            subForm1.Fields.Add(line1);

            caption1.VerticalAlignment = PdfXfaVerticalAlignment.Bottom;
            caption1.Position = PdfXfaPosition.Bottom;
            caption1.Font = font2;

            PdfXfaTextBoxField st = new PdfXfaTextBoxField("st", new SizeF(450, 30)) ;
            st.Width = 450;
            st.Height =40;
            st.Caption = caption1.Clone() as PdfXfaCaption;
            st.Caption.Text = "Street Address";
            st.Border.Style = PdfXfaBorderStyle.Lowered;
            st.Margins.Top = 7;
            subForm1.Fields.Add(st);

            PdfXfaTextBoxField addLine1 = new PdfXfaTextBoxField("ad1", new SizeF(500, 30)) ;
            addLine1.Width = 450;
            addLine1 .Height =40;
            addLine1.Caption = caption1.Clone() as PdfXfaCaption;
            addLine1.Caption.Text = "Address Line1";
            addLine1.Border.Style = PdfXfaBorderStyle.Lowered;
            addLine1.Margins.Top = 7;
            subForm1.Fields.Add(addLine1);

            PdfXfaTextBoxField city = new PdfXfaTextBoxField("city", new SizeF(280, 30)) ;
            city .Width = 220;
            city .Height = 40;
            city.Caption = caption1.Clone() as PdfXfaCaption;
            city.Caption.Text = "City";
            city.Border.Style = PdfXfaBorderStyle.Lowered;
            city.Margins.Top=7;
            subForm1.Fields.Add(city);

            PdfXfaComboBoxField state = new PdfXfaComboBoxField("state", new SizeF(230, 40));
            state.Items.Add("Colorado");
            state.Items.Add("Florida");
            state.Items.Add("Georgia");
            state.Items.Add("Hawaii");
            state.Items.Add("Nevada");
            state.Items.Add("New Mexico");
            state.Items.Add("New York");
            state.Items.Add("North Carolina");
            state.Items.Add("Oregon");
            state.Items.Add("Texas");
            state.Caption = caption1.Clone() as PdfXfaCaption;
            state.Caption.Text = "State";
            state.Border.Style = PdfXfaBorderStyle.Lowered;
            state.Margins .Left = 5;
            state.Margins.Top = 7;
            subForm1.Fields.Add(state);


            PdfXfaNumericField zip = new PdfXfaNumericField("zip", new SizeF(220, 40));
            zip.Caption = caption1.Clone() as PdfXfaCaption;
            zip.CombLength = 5;
            zip.Caption.Text = "Postal / Zip Code";
            zip.PatternString = "zzzz9";
            zip.FieldType = PdfXfaNumericType.Integer;
            zip.Border.Style = PdfXfaBorderStyle.Lowered;
            zip.Margins.Top = 7;
            subForm1.Fields.Add(zip);

            PdfXfaTextBoxField country = new PdfXfaTextBoxField("country", new SizeF(500, 30)) ;
            country.Width = 230;
            country .Height = 40;
            country.Caption = caption1.Clone() as PdfXfaCaption;
            country.Caption.Text = "Country";
            country.Border.Style = PdfXfaBorderStyle.Lowered;
            country.Margins.Left = 5;
            country.Margins.Top = 7;
            subForm1.Fields.Add(country);


            PdfXfaTextBoxField email = new PdfXfaTextBoxField("em", new SizeF(500, 30)) ;
            email .Width =220;
            email .Height = 40;
            email.Caption = caption1.Clone() as PdfXfaCaption;
            email.Caption.Text = "Email";
            email.Margins.Top = 7;
            email.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(email);

            PdfXfaNumericField phone = new PdfXfaNumericField("phone", new SizeF(230, 40));
            phone.Caption = caption1.Clone() as PdfXfaCaption;
            phone.Caption.Text = "Phone Number";
            phone.FieldType = PdfXfaNumericType.Decimal;
            phone.Margins.Left = 5;
            phone.PatternString = "zzzzzzzzz9";
            phone.Margins.Top = 7;
            phone.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(phone);



            PdfXfaTextElement specialDN = new PdfXfaTextElement("Special Dietary Needs");
            specialDN.Font = font0;
            specialDN.Margins.Top = 25;
            specialDN.Height = 42;
            specialDN.Width = 450;
            subForm1.Fields.Add(specialDN);
            subForm1.Fields.Add(line1);

            PdfXfaListBoxField sdn = new PdfXfaListBoxField("sdn", new SizeF(450, 80));
            sdn.Items.Add("Vegan");
            sdn.Items.Add("Gluten Free");
            sdn.Items.Add("Nut Free");
            sdn.Items.Add("Diary Free");
            sdn.Items.Add("Vegetables");
              sdn.SelectionMode = PdfXfaSelectionMode.Multiple;
            sdn.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            sdn.Border.Style = PdfXfaBorderStyle.Lowered;
            sdn.Margins.Top = 7;
            subForm1.Fields.Add(sdn);


            PdfXfaTextElement specialAN = new PdfXfaTextElement("Special Assistance Needs");
            specialAN.Font = font0;
            specialAN.Margins.Top = 25;
            specialAN.Height = 42;
            specialAN.Width = 450;
            subForm1.Fields.Add(specialAN);
            subForm1.Fields.Add(line1);

            PdfXfaListBoxField san = new PdfXfaListBoxField("san", new SizeF(450, 40));
            san.Items.Add("Wheel chair");
            san.Items.Add("Ambulatory lift services");
            san.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            san.Margins.Top = 7;
            san.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(san);

            PdfXfaTextElement pcm = new PdfXfaTextElement("Prefered Contact Method");
            pcm.Font = font0;
            pcm.Margins.Top = 25;
            pcm.Height = 42;
            pcm.Width = 500;
            subForm1.Fields.Add(pcm);
            subForm1.Fields.Add(line1);

            PdfXfaCaption caption = new PdfXfaCaption();
            caption.Font = font1;
            caption.Width = 370;
            caption.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            caption.Position = PdfXfaPosition.Right;

            PdfXfaCheckBoxField c_email = new PdfXfaCheckBoxField("email", new SizeF(400, 22));
            c_email.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            c_email.Caption = caption.Clone() as PdfXfaCaption;
            c_email.Caption.Text = "E-Mail";
            c_email.CheckedStyle = PdfXfaCheckedStyle.Check;
            c_email.Border.Style = PdfXfaBorderStyle.Lowered;
            c_email.Margins.Top = 7;
            subForm1.Fields.Add(c_email);


            PdfXfaCheckBoxField c_phone = new PdfXfaCheckBoxField("phone", new SizeF(400, 20));
            c_phone.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            c_phone.Caption = caption.Clone() as PdfXfaCaption;
            c_phone.Caption.Text = "Phone";
            c_phone.Margins.Top = 7;
            c_phone.Border.Style = PdfXfaBorderStyle.Lowered;
            c_phone.CheckedStyle = PdfXfaCheckedStyle.Check;
            subForm1.Fields.Add(c_phone);

            PdfXfaCheckBoxField c_mail = new PdfXfaCheckBoxField("mail", new SizeF(400, 20));
            c_mail.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            c_mail.Caption = caption.Clone() as PdfXfaCaption;
            c_mail.Caption.Text = "Mail";
            c_mail.Border.Style = PdfXfaBorderStyle.Lowered;
            c_mail.Margins.Top = 7;
            c_mail.CheckedStyle = PdfXfaCheckedStyle.Check;
            subForm1.Fields.Add(c_mail);

            PdfXfaCheckBoxField c_nocontact = new PdfXfaCheckBoxField("nc", new SizeF(400, 20));
            c_nocontact.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            c_nocontact.Caption = caption.Clone() as PdfXfaCaption;
            c_nocontact.Caption.Text = "No Contact";
            c_nocontact.Margins.Top = 5;
            c_nocontact.Border.Style = PdfXfaBorderStyle.Lowered;
            c_nocontact.CheckedStyle = PdfXfaCheckedStyle.Check;
            subForm1.Fields.Add(c_nocontact);

            PdfXfaTextElement MS = new PdfXfaTextElement("Membership status");
            MS.Font = font0;
            MS.Margins.Top = 25;
            MS.Height = 42;
            MS.Width = 400;
            subForm1.Fields.Add(MS);
            subForm1.Fields.Add(line1);

            PdfXfaRadioButtonGroup msg = new PdfXfaRadioButtonGroup("group1");
            msg.Margins.Top = 7;
            subForm1.Fields.Add(msg);            

            PdfXfaRadioButtonField r_nonMember = new PdfXfaRadioButtonField("r1", new SizeF(120, 15));
            r_nonMember.Caption = caption.Clone() as PdfXfaCaption;
            r_nonMember.Caption.Text = "Non-Member";
            r_nonMember.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            r_nonMember.Border.Style = PdfXfaBorderStyle.Lowered;
            r_nonMember.Caption.Width = 100;
            msg.Items.Add(r_nonMember);

            PdfXfaRadioButtonField r_member = new PdfXfaRadioButtonField("r2", new SizeF(100, 15));
            r_member.Caption = caption.Clone() as PdfXfaCaption;
            r_member.Caption.Text = "Member";
            r_member.Border.Style = PdfXfaBorderStyle.Lowered;
            r_member.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            r_member.Caption.Width = 80;
            msg.Items.Add(r_member);

            PdfXfaRadioButtonField r_exhibition = new PdfXfaRadioButtonField("r3", new SizeF(100, 15));
            r_exhibition.Caption = caption.Clone() as PdfXfaCaption;
            r_exhibition.Caption.Text = "Exhibition";
            r_exhibition.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            r_exhibition.Caption.Width = 80;
            r_exhibition.Border.Style = PdfXfaBorderStyle.Lowered;
            msg.Items.Add(r_exhibition);

            PdfXfaRadioButtonField r_student = new PdfXfaRadioButtonField("r4", new SizeF(100, 15));
            r_student.Caption = caption.Clone() as PdfXfaCaption;
            r_student.Caption.Text = "Student";
            r_student.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            r_student.Border.Style = PdfXfaBorderStyle.Lowered;
            r_student.Caption.Width = 80;
            msg.Items.Add(r_student);           

            mainForm.Fields.Add(subForm1);
            doc.XfaForm = mainForm;
           
            doc.Save("Sample.pdf", PdfXfaType.Static);

            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }
       
      /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
            string fullPath = @"..\..\..\..\..\..\..\..\Common\";
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }
    }
}
