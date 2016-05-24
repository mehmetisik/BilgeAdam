using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DongulerDevam
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int eklenecek_sayi = Convert.ToInt32(textBoxSayi.Text);

                listBoxSayilar.Items.Add(eklenecek_sayi);



            }
            catch
            {

                MessageBox.Show("Lütfen Sayısal Değerler Giriniz!");

            }
            finally
            {

                textBoxSayi.Clear();
            
            }
        }

        private void buttonAritmetik_Click(object sender, EventArgs e)
        {

            if (listBoxSayilar.Items.Count == 0)
            {
                MessageBox.Show("Listede eleman olmadığından işlem yapılamıyor!...");
                return;// Kodu Kullanıldığı scope'un(en genel anlamda Click olayının dışına atar!).return çalışırsa return altındaki kodlar çalışmaz.
            
            }

            int toplam=0;
            for (int indeks = 0; indeks < listBoxSayilar.Items.Count; indeks++)
            {

                toplam += Convert.ToInt32(listBoxSayilar.Items[indeks]);
            
            
            }
            //Döngünün amacı listedeki sayıların yoplamını bulmak.Bunun için de ilk elemandan son elemana kadar tüm elemanları elde etmemiz gerekir.Bunun için de döngülerden faydalanırız.

            int aritmetik_ortalama = toplam / listBoxSayilar.Items.Count;

            MessageBox.Show("Aritmetik Ortlama Değeri:" + aritmetik_ortalama);
            listBoxSayilar.Items.Clear();

        }
    }
}
