using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_STATIC.Facade
{
    class MusteriIslem
    {
        public static void MusteriEkle(Musteri eklenecek)
        {

            MessageBox.Show(eklenecek.Ad + " " + eklenecek.Soyad + " isimli müşteri listeye eklendi!");
        
        }

    }
}
