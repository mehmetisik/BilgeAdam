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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        private void buttonSayısalLoto_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[6];//Rastgele oluşturacağımız ve aynı olmayacak 6 sayıyı içinde barındıracağımız dizi
            int indeks = 0;//Diziye eleman eklemek için kullanacağımız değişken
            Random rastgele = new Random();

            while (indeks < 6)
            {

                //Diziye her eleman ekledğimizde bir sonraki eleman için index değerini arttırmamız gerekir.6 elemanlı bir dizi için de index değeri en fazla 5 olabilir(eleman sayısı-1).Fakat burada bir koşulumuz var ve o koşulda üretilen sayının dizi içerisinde bulunmaması!!!

                int gelen_sayi = rastgele.Next(1, 50);

                //sayılar dizisi içerisinde gelen_sayi değeri yoksa IndexOf -1 değeri döndürür ve bunun koşulunun sağlanıp sağlanmadığını kontrol ediyoruz.
                if (Array.IndexOf(sayilar, gelen_sayi) == -1)
                {

                    sayilar[indeks] = gelen_sayi;
                    indeks++;//Bir sonraki elemana ekleme yapmak için index değerini 1 arttırıyoruz.
                
                }




            }//Döngünün scopunun bitişi

            Array.Sort(sayilar);//Diziyi küçükten büyüğe doğru sıralar.

            label1.Text = sayilar[0].ToString();
            label2.Text = sayilar[1].ToString();
            label3.Text = sayilar[2].ToString();
            label4.Text = sayilar[3].ToString();
            label5.Text = sayilar[4].ToString();
            label6.Text = sayilar[5].ToString();

        }

        
    }
}
