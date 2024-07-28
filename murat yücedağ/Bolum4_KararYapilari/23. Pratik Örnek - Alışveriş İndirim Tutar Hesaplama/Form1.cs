using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23.Pratik_Örnek___Alışveriş_İndirim_Tutar_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = int.Parse(textBox1.Text);
            if (kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                lblHesapla.Text = $"{toplam} TL";
            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                lblHesapla.Text = $"{toplam} TL";
            }
            if (kitapadet >= 41)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                lblHesapla.Text = $"{toplam} TL";
            }
        }
    }
}
//0-20 yuzde 20
//21-40 arasi %40
//41++ kitap alan yuzde 50