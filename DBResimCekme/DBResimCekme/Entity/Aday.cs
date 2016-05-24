using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBResimCekme.Entity
{
   public class Aday
    {

        public int AdayId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi{ get; set; }
        public byte[] Resim { get; set; }
        public string KimlikNo { get; set; }
        public int MezuniyetId { get; set; }

    }
}
