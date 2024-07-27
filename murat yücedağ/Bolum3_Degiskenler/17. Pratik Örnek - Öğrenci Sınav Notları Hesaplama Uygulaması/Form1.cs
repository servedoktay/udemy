using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17.Pratik_Örnek___Öğrenci_Sınav_Notları_Hesaplama_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje;
            double ort;
            ad= textBox4.Text;
            soyad = textBox5.Text;
            s1 = int.Parse(textBox1.Text);
            s2= int.Parse(textBox2.Text);
            proje = int.Parse(textBox3.Text);
            ort = (s1 + s2 + proje) / 3;
            listBox1.Items.Add(ad+" "+soyad+" "+"Ortalama= "+ort);
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
