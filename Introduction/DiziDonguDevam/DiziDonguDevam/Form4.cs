using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiziDonguDevam
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            char karakter = 'A';
            string sehir = "İstanbul";

            foreach (char harf in sehir)
            {

                listBox.Items.Add(harf);
            
            }
        }

        private void timerKaydir_Tick(object sender, EventArgs e)
        {
            char ilk_karakter = this.Text[0];
            this.Text = this.Text.Remove(0, 1);
            this.Text += ilk_karakter;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int toplam = 0;

            for (int indeks = 0; indeks < 10; indeks++)
            {


                toplam += Convert.ToInt32(maskedTextBox1.Text[indeks].ToString());
            
            }
        }

       
    }
}
