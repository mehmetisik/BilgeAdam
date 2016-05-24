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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //veri tipi değişken adı=değer;
            //Verileri programlama esnasında değişkenler adını vediğimiz veri saklama ortamları içerisine yaparız.Ve saklamak istediğimiz verilere değişken isimleri üzerinden erişiriz.


            int sayi = 100;

            string sehir = "istanbul";

            byte ikincisayi = 255;

            /*
             * Eğer tamsayı tipinde değişken tanımlayacaksak kullanabileceğimiz veri tipleri byte,short,int ve long'tur.
             * 
             */

            double ondalikli = 0.1;

            float sayi2 = 0.056f;//Ondalık sayı,float tipinde tanımlanmışsa sonuna f,decimal tipte tanımlanmışsa sayının sonuna m son eki konulur.

            decimal para = 1500.90m;


            //Değişken isimleri sayı ile başlayamaz.Bazı alfanümerik olmayan karakter ile değişken tanımlanamaz.(.,-,! vs..).Alt çizgü kullanılarak değişken tanımlanabilir.
            int _sayi = 50;

            //char tek bir karakter saklamak için kullandığımız veri tipiidir.Ve uNicode karakterleri de desteklemek için 16 bitlik yer kaplar.
            char karakter = 'Д';

        }
    }
}
