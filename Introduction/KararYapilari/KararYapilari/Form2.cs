using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonKontrol_Click(object sender, EventArgs e)
        {

            int sayi = 10;

            /*
             * 
             * ==->Eşittir anlamına gelir
             * !=->Eşit değilse anlamı taşır.
             * 
             * */

            //if(koşul) koşul ik türlü değer alır.true ya da false
            if (sayi == 5)//sayi değişkeninin değeri 5'e eşitse
            {

                //if'in parantezleri içerisindeki koşul true ise,scope içerisine girilir ve buradaki kodlar çalıştırılır.
                MessageBox.Show("Sayı 5'tir!");


            }
            else
            {
                //sayi değişkeninin değerinin 5 olmadığı bütün durumlarda else bloğu çalışır.
                MessageBox.Show("Sayı 5 değildir!");
            
            }

        }
    }
}
