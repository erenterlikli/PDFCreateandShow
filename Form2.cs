using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //giriş çıkış işlemleri için.
//indirdiğimiz ve referans olarak projeye dahil ettiğimiz kısım için.
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Pdfİşlemleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document pdfim = new iTextSharp.text.Document(); //bu referansı oluşturduk.
            PdfWriter.GetInstance(pdfim, new FileStream(@"C:YapayZeka.Pdf", FileMode.Create)); //pdfin yeri.
            pdfim.AddAuthor(textBox1.Text);
            pdfim.AddCreator(textBox2.Text);
            pdfim.AddCreationDate();
            pdfim.AddSubject(textBox3.Text);
            pdfim.AddTitle(textBox4.Text);
            pdfim.AddKeywords(textBox5.Text);

            if(pdfim.IsOpen()==false)
            {
                pdfim.Open();
            }

            pdfim.Add(new Paragraph(textBox6.Text));
            pdfim.Close();
        }
    }
}
