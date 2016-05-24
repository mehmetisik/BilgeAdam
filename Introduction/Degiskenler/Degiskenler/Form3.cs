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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        int sayi;//Global değişken form sonlanana kadar yani program sonlanana kadar Ram'de kalır.
        private void btnArttir_Click(object sender, EventArgs e)
        {

            //int sayi = 0;

            //Sayının değerini her seferinde  1 1 arttırıyoruz.
            sayi += 1;
            //sayi++;

            //Atamalarda eşitliğin iki tarafındaki veritipleri aynı olmalı.Text özelliğinin tipi string olduğundan,bu özelliğe değer atamak istiyorsak,atayacağımız değerin mutlaka string olması gerekir.int tipindeki sayı değişkenimizi ToString() metodu ile stringe çevirdik.
            labelSayi.Text = sayi.ToString();

            //sehir local bir değişken olarak btn_Artri_Click scope'u içinde tanımlanmıştır ve sadece burada erişebiliriz.
            string sehir = "ankara";


        }


        private void btnAzalt_Click(object sender, EventArgs e)
        {
            //sayi-=1;
            sayi--;//Sayıyı her seferinde bir azaltır.

            labelSayi.Text = sayi.ToString();

           



        }
    }
}
