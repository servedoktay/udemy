using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30.Pratik_Örnek___Ardışık_Sayı_Toplamları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1 ile 10 arasındaki sayilarin toplamı

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            label1.Text = $"{toplam}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int topla = 0;
            //1 ile 10 arasindaki cift sayiların toplami
            for (int i = 0; i <= 10; i += 2)
            {
                topla += i;
            }
            label2.Text=topla.ToString();
        }
    }
}
