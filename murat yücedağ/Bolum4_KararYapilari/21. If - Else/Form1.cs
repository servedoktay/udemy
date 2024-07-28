using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21.If___Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ali")
            {
                label1.Text = "DOGRU";
            }
            else
                label1.Text = "yanlis";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox2.Text);
            if (sayi == 5)
            {
                label2.Text = "dogru";
            }
            else
            {
                label2.Text = "yanlis";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //KLAVYEDEN GİRİLEN SAYI TEKMİ CİFTMİ
            int sayi = int.Parse(textBox3.Text);
            if (sayi % 2 == 0)
            {
                label3.Text = "cift";
            }
            else
            {
                label3.Text = "tek";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //sayi cift ve 10dan buyukmu
            int sayi = int.Parse(textBox4.Text);
            if (sayi % 2 == 0 &&sayi>10)
            {
                label4.Text = "cift ve 10 dan büyük";
            }
            else
            {
                label4.Text = "şartlar saglanmadi";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox5.Text);
            if (sayi % 2 == 0 || sayi > 10)
            {
                label5.Text = "cift ve 10 dan büyük";
            }
            else
            {
                label5.Text = "şartlar saglanmadi";
            }
        }
    }
}
