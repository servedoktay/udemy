using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Label_ve_Textbox_Kullanımı
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

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "ElifŞuuuu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Meyyem";
            label4.Text = "Atakul";
            label8.Text = " ev Hanimi".ToUpper();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Yazilim Mühendisliği";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ne yazdırıcam sag nereye yazıdırıcam sol
            label9.Text = textBox2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ad, soyad, meslek;
            ad = textBox3.Text;
            soyad = textBox4.Text;
            meslek = textBox5.Text;

            MessageBox.Show(ad + " " + soyad.ToUpper() + "  " + meslek);
        }
    }
}
