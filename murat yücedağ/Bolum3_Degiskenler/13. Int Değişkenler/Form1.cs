using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.Int_Değişkenler
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = 26;
            label1.Text=sayi.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 5;
            sayi2=4;
            toplam = sayi1 + sayi2;

            label2.Text=toplam.ToString();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label3.Text = $"Alan:{alan}\n Cevre={cevre}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sınav1, sınav2, sınav3, ort;
            sınav1 = 80;
            sınav2 = 90;
            sınav3 = 10;
            ort = (sınav1 + sınav2 + sınav3) / 3;

            label4.Text = ort.ToString();
        }
    }
}
