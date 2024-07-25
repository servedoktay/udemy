using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.Combobox_ve_Listbox_Araçları_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Futbolcu");
            listBox1.Items.Add("Manken");
            listBox1.Items.Add("Kasiyer");
            listBox1.Items.Add("Pilot");
            listBox1.Items.Add("Antrenör");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Declare variables to store the input values
            string ad, soyad, yas, memleket, maas;

            // Read values from text boxes
            ad = textBox3.Text;
            soyad = textBox4.Text;
            yas = textBox5.Text;
            memleket = textBox6.Text;
            maas = textBox7.Text;

            // Concatenate the values into a single string
            string listItem = ad + " " + soyad + " " + yas + " " + memleket + " " + maas;

            // Add the concatenated string to the list box
            listBox2.Items.Add(listItem);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
