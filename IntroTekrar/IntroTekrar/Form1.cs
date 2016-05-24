using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntroTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {

            //textBoxKelime kontrolünün içi boş ya da null ise işlem yaptırmıyoruz.
            if (string.IsNullOrEmpty(textBoxKelime.Text))
            {

                MessageBox.Show("Hiçbir karakter girmeden nasıl işlem yapabileceğini zannediyorsun.Akıllı ol!");
                return;


            }

            int kacTane = 0;
            //string[] kelimeler = textBoxMetin.Text.Split(' ');

            //foreach (string kelime in kelimeler)
            //{

            //    if (kelime == textBoxKelime.Text)
            //    {

            //        kacTane++;

            //    }


            //}
            //MessageBox.Show(kacTane.ToString());

            int eskiuzunluk = textBoxMetin.Text.Length;//Arama yapacağımız metnin ilk uzunluğu
            string aranacak = textBoxKelime.Text;
            int yeniuzunluk = textBoxMetin.Text.Replace(aranacak, "").Length;//aranacak kelimenin geçtiği yeri boş yapıyoruz.

            kacTane = (eskiuzunluk - yeniuzunluk) / aranacak.Length;
            MessageBox.Show(kacTane.ToString());



        }
    }
}
