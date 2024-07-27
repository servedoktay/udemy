using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12.String_Değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button bas = new Button();
            bas.Text = "BAS";
            this.Controls.Add(bas);
            bas.Click += Bas_Click;
        }

        private void Bas_Click(object sender, EventArgs e)
        {
            //string metin;
            //metin = "Merhaba NAber";
            //Label lbl = new Label();
            //lbl.Top = 45;
            //lbl.Left = 45;
            //lbl.Text= metin;
            //this.Controls.Add(lbl);

            string adsoyad, meslek;
            adsoyad = "Oktay Atakul";
            meslek = "Ogrenci";
            Label lbl1=new Label();
            lbl1.Top = 45;
            this.Controls.Add(lbl1);


            Label lbl2 = new Label();
            lbl2.Top = 75;
            
            this.Controls.Add(lbl2);

            lbl1.Text = adsoyad;
            lbl2.Text = meslek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sehir;
            sehir = textBox1.Text.ToString() ;
            MessageBox.Show(sehir);
            
        }
    }
}
