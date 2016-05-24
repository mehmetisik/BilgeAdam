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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string [] ogrenciler = {"Ali","Ayşe","Nihat","10"};

            //3 elemanlı int tipinde elemanları barındırabilecek bir dizi tanımlaması
            int [] sayilar=new int[3];

            sayilar[0] = 1;//Dizilerin elemanlarına değer atamak veye değerlerini almak için index adını verdiğimiz sıra numaralarını kullanırız.Ve bu numaralar 0'dan başlar.

            sayilar[1] = 10;
            sayilar[2] = 30;
            //sayilar[3] = 100; 3 elemanlı bir diziye 3 eleman atanabilir.4.elemanı eklmeye çalışırsam,index değerinin dışına çıkıldığından çalışma zamanı hatası alırız.İlle de 4.elemanı eklemek istiyorsak,diziyi yeniden boyutlandırmamız gerekir.


            //foreach (string ogrenci in ogrenciler)
            //{

            //    MessageBox.Show(ogrenci);
            
            //}

            for (int indeks = 0; indeks < ogrenciler.Length; indeks++)
            {

                MessageBox.Show(ogrenciler[indeks]);
            
            }


        }
    }
}
