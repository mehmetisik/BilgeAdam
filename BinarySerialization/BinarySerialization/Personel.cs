using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BinarySerialization
{
    [Serializable]
    class Personel
    {

        public Personel()
        {
            liste = new ArrayList();
        }

        [NonSerialized]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public static ArrayList liste { get; set; }
        
        

    }
}
