using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOPDevam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = "Ali";//Ad özelliğine değer atanması(set)
            ogr.DogumTarihi = DateTime.Parse("01.01.1970");
            
            MessageBox.Show(ogr.Yas.ToString());//Ad özelliğinin değerinin elde edilmes.(get)

            Futbolcu messi = new Futbolcu();
            messi.Ad = "Lionel";
            messi.Soyad = "Messi";
            messi.Mevkii = "Forvet";
            messi.SutCek("Yılan gibi şut çekerim,90'a gider!");

            Futbolcu sabri = new Futbolcu();
            sabri.Ad = "Sabri";
            sabri.Soyad = "Reyiz";
            sabri.SutCek("Dağlara taşlara gider,insanların kafasını yararım,top statı aşar sonra da elime başıma götürürüm");
            

        }
    }
}
