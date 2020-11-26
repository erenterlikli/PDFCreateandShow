using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //giriş çıkış işlemleri olduğu için.

namespace Pdfİşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdfac = new OpenFileDialog();
            pdfac.Title = "Pdf Aç";
            pdfac.Filter = "Pdf Dosyaları (*.Pdf) | *.Pdf";

            if(pdfac.ShowDialog()== DialogResult.OK)
            {
                textBox1.Text = pdfac.FileName;
                axAcroPDF1.LoadFile(pdfac.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
