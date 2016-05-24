using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetotlarGiris
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string kelime;
        private void buttonBuyuk_Click(object sender, EventArgs e)
        {
          labelKelime.Text=labelKelime.Text.ToUpper();//Bütün karakterleri büyük yapmamızı sağlar.
        }

        private void buttonKucuk_Click(object sender, EventArgs e)
        {
            labelKelime.Text=labelKelime.Text.ToLower();//Hepsini küçük harfe çevirir.
        }

        private void buttonAyir_Click(object sender, EventArgs e)
        {
            //Bir başlangıç indeksi ve bu başlangıç indeksinden itibaren kaç karakteri ayıracaksak onun uzunluğunu veriyoruz.
            labelKelime.Text=labelKelime.Text.Substring(0, 7);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            labelKelime.Text=labelKelime.Text.Remove(0, 7);

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //TextBox'ın textii nullsa(değer atanmamışsa ya da boşsa)
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                //MessageBox.Show("İlgili alan boş bırakılamaz!");

                string girilen = textBox1.Text.Trim();//Sağ ve sol taraftaki boşlukları temizliyoruz.

                //Split metodu bir string'i belirli bir karaktere göre parçalamımızı sağlar.Geriye string dizi döndürür.
                string [] isimler=girilen.Split(' ');

                girilen = "";

                foreach (string isim in isimler)
                {

                    if (isim != "")
                    {

                        girilen += isim.Substring(0, 1).ToUpper() + isim.Substring(1, isim.Length - 1).ToLower() + " ";
                    
                    }
                
                
                }
                girilen = girilen.Remove(girilen.Length - 1, 1);
                textBox1.Text = girilen;



            
            
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
