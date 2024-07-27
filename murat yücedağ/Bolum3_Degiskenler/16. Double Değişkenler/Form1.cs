using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.Double_Değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 4.24;
            label1.Text=sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            s1 = 60;
            s2 = 70;
            s3 = 79;
            ort = (s1 + s2 + s3) / 3;
            label2.Text=ort.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            Label lbl = new Label();
            lbl.Top = 200;
            lbl.Left = 200;
            lbl.Text=sayi.ToString();
            this.Controls.Add(lbl);
        }
    }
}
