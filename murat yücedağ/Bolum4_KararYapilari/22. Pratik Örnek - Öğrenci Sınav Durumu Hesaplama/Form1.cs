using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22.Pratik_Örnek___Öğrenci_Sınav_Durumu_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void txtSinav3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ort;
            string durum;
            s1 = Convert.ToInt32(txtSinav1.Text);
            s2 = Convert.ToInt32(txtSinav2.Text);
            proje = Convert.ToInt32(txtProje.Text);

            ort = (s1 + s2 + proje) / 3;

            if (ort>=50)
            {
                durum = "Geçti";
            }

            else
            {
                durum = "kaldi";
                
            }
            txtOrtalama.Text = $"{ort.ToString("0.00")} / {durum}";
        }

        private void txtOrtalama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
