﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32.While_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                listBox1.Items.Add("merhaba");
                listBox2.Items.Add(i);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 1;
            int toplam = 0;
            while (j <= 5) 
            {
                toplam += j;
                j++;
            }
            MessageBox.Show(toplam.ToString());

        }
    }
}
