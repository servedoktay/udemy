using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34.Timer_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer kullanimi
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac++;
            label1.Text = sayac.ToString();
            //if (sayac==50)
            //{
            //    timer1.Stop();
            //    this.BackColor = Color.PeachPuff; //rengi kodla degıstırmek
            //}
            if (sayac == 2)
                this.BackColor = Color.PeachPuff;
            if (sayac == 4)
            {
                this.BackColor = Color.Magenta;
                sayac = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {
                this.BackColor = Color.Red;
            }
            if (sayac > 3 && sayac <= 6)
            {
                this.BackColor = Color.Green;
            }
            if (sayac > 6 && sayac < 8)
            {
                this.BackColor = Color.Blue;
                sayac = 1;
            }
        }
    }
}
