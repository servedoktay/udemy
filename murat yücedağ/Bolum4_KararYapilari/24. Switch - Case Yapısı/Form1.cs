using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24.Switch___Case_Yapısı
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
            int ay = Convert.ToInt32(textBox1.Text);
            switch (ay)
            {
                case 1:
                    label2.Text = "Ocak"; break;
                case 2:
                    label2.Text = "Subat"; break;
                case 3:
                    label2.Text = "Mart"; break;
                case 4:
                    label2.Text = "Nisan"; break;

                case 5:
                    label2.Text = "Mayis"; break;
                case 6:
                    label2.Text = "Haziran"; break;
                case 7:
                    label2.Text = "Temnuz"; break;
                case 8:
                    label2.Text = "Ağustos"; break;
                case 9:
                    label2.Text = "Eylul"; break;
                case 10:
                    label2.Text = "Ekim"; break;
                case 11:
                    label2.Text = "Kasim"; break;
                case 12:
                    label2.Text = "Aralik"; break;


                default:
                    label2.Text = "\a HATALI AY";
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = textBox2.Text.ToLower();
            switch (mevsim)
            {
                case "yaz": label3.Text = "haziran temmuz agustos"; break;
                case "sonbahar": label3.Text = "eylul ekim kasim"; break;
                case "ilkbahar": label3.Text = "mart nisan mayis"; break;
                case "kıs": label3.Text = "aralik ocak subat"; break;
                default:
                    break;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1=Convert.ToInt32(txtS1.Text);
            s2= Convert.ToInt32(txtS2.Text);
            string secim = cmbSecim.SelectedItem.ToString();
            switch (secim)
            {
                case "+":textBox5.Text = $"{s1} + {s2} = {s1 + s2}";break;
                case "-":textBox5.Text = $"{s1} - {s2} = {s1 - s2}"; break;
                case "*": textBox5.Text = $"{s1} * {s2} = {s1 * s2}"; break;
                case "/": textBox5.Text = $"{s1} / {s2} = {s1 / s2}"; break;
                default: MessageBox.Show("Secim HAtası\a");
                    break;
            }
        }
    }
}
