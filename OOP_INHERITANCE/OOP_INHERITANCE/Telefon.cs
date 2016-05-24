using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_INHERITANCE
{
    class Telefon
    {
        //Propertyler
        public string Model { get; set; }
        public string Marka { get; set; }
        public Color Renk { get; set; }
        public decimal Fiyat { get; set; }
        public string UretimYeri { get; set; }
        public bool GarantiVarMi { get; set; }

        //Metod

        public virtual void Cal()
        {

            MessageBox.Show("LÜLÜLÜLÜ LÜLÜLÜLÜ");

        }

        //Constructor(Yapıcı Metot)->Class üyelerine ilk değer ataması için kullanılır.
        public Telefon()
        {
            this.UretimYeri = "Made in P.R.C";
        }

    }
}
