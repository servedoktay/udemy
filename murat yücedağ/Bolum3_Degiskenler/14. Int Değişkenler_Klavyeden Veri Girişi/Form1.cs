using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14.Int_Değişkenler_Klavyeden_Veri_Girişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yazdir;
            yazdir=int.Parse(textBox1.Text);           
            label2.Text = yazdir.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox2.Text);
            int kup =(int) Math.Pow(sayi,3);
            MessageBox.Show($"{sayi} sayisinin kupu={kup}");

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
