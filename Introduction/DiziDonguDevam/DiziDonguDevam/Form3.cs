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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonGetir_Click(object sender, EventArgs e)
        {

            listBoxSehirler.Items.Clear();
            string[] sehirler = { "İstanbul", "İzmir", "Batman" };


            /*
            for (int indeks = 0; indeks < sehirler.Length; indeks++)
            {

                listBoxSehirler.Items.Add(sehirler[indeks]);
            
            }
             */

            foreach (string sehir in sehirler)
            {

                listBoxSehirler.Items.Add(sehir);
            
            }

        }

        private void buttonIslem_Click(object sender, EventArgs e)
        {
            
            int[] sayilar = { 10, 100, 26, 10,75,84,43};

            //sayilar dizisi içerisinde sayıların toplamını ve aritmetik ortalamasını kullanıcıya mesaj penceresiyle göstermeniz.....

            int toplam = 0;

            foreach (int sayi in sayilar)
            {

                toplam += sayi;
                MessageBox.Show("Döngü çalıştıkça çıkarım ben!");
            
            }

            MessageBox.Show("Toplam:" + toplam);

            int aritmetik_ortalama = toplam / sayilar.Length;
            MessageBox.Show("Aritmetik Ortalama:" + aritmetik_ortalama);
        }
    }
}
