using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPDevam
{
    class Ogrenci
    {

        //Sadece bulunduğu class içinden erişilebilir değişken...
        private string _ad;

        public string Ad
        {

            get { return _ad; }//get bloğu değer elde etmek için kullanılır
            set { _ad = value; }//set bloğu ise değer atamak için kullanılır.

        }

        //field
        private DateTime _dogumTarihi;


        //Property tanımlaması
        public DateTime DogumTarihi
        {
            set { _dogumTarihi = value; }
        
        }

        //field
        private int _yas;

        //Property
        public int Yas
        {

            get 
            {
                
                return DateTime.Now.Year - _dogumTarihi.Year; 
                
            
            }
        
        }

    }
}
