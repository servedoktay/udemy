using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.Proje___Sinema_Büfe_Satış_Uygulaması
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam ;
            misir = Convert.ToInt32(txtMisir.Text);
            bilet = int.Parse(txtBilet.Text);
            su = int.Parse(txtSu.Text);
            cay = int.Parse(txtCay.Text);

            toplam = misir * 4+su*1+cay*2+bilet*8;
            lblHesap.Text = toplam.ToString()+ " Tl";
            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + " Tl";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMisir.Clear();
            txtCay.Clear();
            txtSu.Clear();
            txtBilet.Clear();
            lblHesap.Text = "00 TL";
        }
    }
}
