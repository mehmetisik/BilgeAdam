using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FW_COLLECTIONS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = new int[1000];
        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();

            sayilar.Add(60);
            sayilar.Add(80);
            sayilar.Add(100);

            //sayilar.Sum();

            List<Personel> perlistesi = new List<Personel>();
            Personel p1 = new Personel("Selami");
            Personel p2 = new Personel("Sıla");
            Personel p3 = new Personel("Ali");

            perlistesi.Add(p1);
            perlistesi.Add(p2);
            perlistesi.Add(p3);

           //perlistesi=perlistesi.Where(p => p.Ad.StartsWith("A")).ToList();

           perlistesi = perlistesi.Where(p => p.Ad.Contains("a")).ToList();

           var liste = perlistesi.Where(p => p.Ad.Contains("a")).ToList();

           foreach (var item in liste)
           {
               
           }
           //dynamic sayi = 10;

           //sayi = new Random().ToString();

           //sayi = new Personel("Hettere");


        }

        class Personel
        {

            public Personel(string _ad)
            {
                this.Ad = _ad;
            }

            public int ID { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public DateTime DogumTarihi { get; set; }
        
        }
    }
}
