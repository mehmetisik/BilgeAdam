using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOP_STATIC.Facade;

namespace OOP_STATIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Ad = "Nihat";
            m.Soyad = "Doğan";

            Musteri m2 = new Musteri();
            m2.Ad = "Bülent";
            m2.Soyad = "Ersoy";

            MusteriIslem.MusteriEkle(m);
            MusteriIslem.MusteriEkle(m2);
        }
    }
}
