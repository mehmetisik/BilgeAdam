using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;//Color tipini kullanmak için bu kütüphane gerekli...

namespace OOPDevam
{
    class Insan
    {
        private string _ad;//field tanımlandıktan sonra Ctrl+R+E'ye basarak encapsulation(kapsülleme ) işlemini gerçekleştiriyoruz.(Property'nin oluşturulması)

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        //PropFull ile otomatik olarak yazım işlemini açıyoruz.Hem field hem de property tanımlamasını otomatik olarak açar.
        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        private Color _gozrengi;

        public Color Gozrengi
        {
            get { return _gozrengi; }
            set { _gozrengi = value; }
        }

        //Field tanımlamadan get-set olayını kullanacaksak prop ifadesini kullanırız.

       //prop+tab+tab
        public string Ulke { get; set;}

        


        


    }
}
