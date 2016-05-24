using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //Eğer iki string tipte veriyi + işaretiyle işleme tabii tutarsak,bu bir karakter birleştirme işlemi olur ve yanyana karakterler yazılır.
            // MessageBox.Show(textBoxSayi1.Text + textBoxSayi2.Text);


            int birinci_sayi = Convert.ToInt32(textBoxSayi1.Text);
            int ikinci_sayi = Convert.ToInt32(textBoxSayi2.Text);


            int sonuc = birinci_sayi + ikinci_sayi;

            MessageBox.Show(sonuc.ToString());

            textBoxSayi1.Clear();
            textBoxSayi2.Clear();

            

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
