using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31.Karar_Yapıları_ile_Döngü_Kullanımı
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
            //1 ile 10 arasında 3 e tam bolunenler
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1 ile 100 arasında 5 ve ve 7 ye tam bolunen sayılar

            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0 && i % 7 == 00)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //klavyeden girilen sayıya kadar listeleyen prgo
            int sayi = int.Parse(textBox1.Text);
            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //klavyeden girilen sayının tam bolenlerini bulan program
            listBox1.Items.Clear();
            int sayi = int.Parse(textBox1.Text);
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 00)
                {
                    listBox1.Items.Add(i);
                }
            }
            listBox1.Items.Add(sayi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //faktöriyel buldurtma
            int sayi = int.Parse(textBox2.Text);
            int fakt = 1;
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi == 0)
                {
                    textBox3.Text = "0";
                    break;
                }
                else
                    fakt *= i;
            }
            textBox3.Text = fakt.ToString();


        }
    }
}
