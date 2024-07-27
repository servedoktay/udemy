using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15.Int_Değişkenler_Pratik_Örnek_Aritmetik_4_İşlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Sayi 1";
            label2.Text = "Sayi 1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, toplam, carpım, fark, bolum;
            s1 = int.Parse(textBox1.Text);
            s2 = int.Parse(textBox2.Text);
            toplam = s1 + s2;
            fark = s1 - s2;
            carpım = s1 * s2;
            bolum = s1 / s2;

            MessageBox.Show($"Toplam={toplam}\nFark={fark}\nÇarpım={carpım}\nBolum={bolum}");
        }
    }
}
