using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOPLib;


namespace OOPGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //new anahtar kelimesi ile class'tan bir tane kopya(instance) alıyoruz.Böylelikle bu şablonun özelliklerine sahip nesneyi RAM'de oluşturuyoruz.
            Urun urn = new Urun();
            urn.UrunAdi = "LG";
            urn.Fiyat = 100.50m;
            
            
            MessageBox.Show(urn.UrunAdi + " isimli ürünün fiyatı:" + urn.Fiyat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba a = new Araba();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Ad = "Ali";
            
        }
    }
}
