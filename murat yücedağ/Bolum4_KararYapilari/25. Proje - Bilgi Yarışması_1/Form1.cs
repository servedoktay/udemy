using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25.Proje___Bilgi_Yarışması_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogruS = 0, yanlisS = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            //kullanıcı 1 cevap cevince enebled olsun hepsi
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            lblKendiC.Text = btnB.Text;

            if (lblDogruC.Text == lblKendiC.Text)
            {
                dogruS++;
                lbldogruS.Text = dogruS.ToString();
                pcbYesil.Visible = true;
            }
            else
            {
                yanlisS++;
                lblyanlisS.Text = yanlisS.ToString();
                pcbKir.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            //kullanıcı 1 cevap cevince enebled false olsun hepsi
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            lblKendiC.Text = btnA.Text;

            if (lblDogruC.Text == lblKendiC.Text)
            {
                dogruS++;
                lbldogruS.Text = dogruS.ToString();
                pcbYesil.Visible = true;
            }
            else
            {
                yanlisS++;
                lblyanlisS.Text = yanlisS.ToString();
                pcbKir.Visible = true;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //kullanıcı 1 cevap cevince false enebled olsun hepsi
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            lblKendiC.Text = btnC.Text;

            if (lblDogruC.Text == lblKendiC.Text)
            {
                dogruS++;
                lbldogruS.Text = dogruS.ToString();
                pcbYesil.Visible = true;
            }
            else
            {
                yanlisS++;
                lblyanlisS.Text = yanlisS.ToString();
                pcbKir.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            //kullanıcı 1 cevap cevince enebled false olsun hepsi
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            lblKendiC.Text = btnD.Text;

            if (lblDogruC.Text == lblKendiC.Text)
            {
                dogruS++;
                lbldogruS.Text = dogruS.ToString();
                pcbYesil.Visible = true;
            }
            else
            {
                yanlisS++;
                lblyanlisS.Text = yanlisS.ToString();
                pcbKir.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soruno++;
            lblSoruNo.Text = soruno.ToString();
            pcbKir.Visible = false;
            pcbYesil.Visible = false;

            //kullanıcı 1 cevap cevince enebled olsun hepsi
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;



            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kac Yılında İlan Edildi";
                btnA.Text = "1920";
                btnB.Text = "1924";
                btnC.Text = "1923";
                btnD.Text = "1925";
                lblDogruC.Text = "1923"; //dogru cevabı tutuyor

                //2 label tut ve dogru ve kendı cevabımı tut
            }
            if (soruno == 2)
            {
                richTextBox1.Text = ("Hangi İl Ege Bolgesinde Degildir?");
                btnA.Text = "İzmir";
                btnB.Text = "Balikesir";
                btnC.Text = "Aydin";
                btnD.Text = "Manisa";

                lblDogruC.Text = "Balikesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = ("Son Kuslar Hangi Yazarimiza Aittir");
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Resat Nuri";
                btnSonraki.Text = "SONUCLAR";

                lblDogruC.Text = "Sait Faik";
            }
            if (soruno > 3)
            {
                soruno--;
                lblSoruNo.Text = soruno.ToString();
                MessageBox.Show($"Sinav Bitti.\nDogru Sayisi:{dogruS} Yanlis Sayisi: {yanlisS}");
                pcbKir.Visible = false;
                pcbYesil.Visible = false;

                //kullanıcı 1 cevap cevince enebled olsun hepsi
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
