using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphane.Entity
{
   public class Kitap
    {

        public int KitapID { get; set; }
        public string KitapAD { get; set; }
        public string ISBNNO { get; set; }
        public int BasimTarihi { get; set; }
        public short SayfaSayisi { get; set; }
        public byte[] KapakResmi { get; set; }
        public int YayinEviID { get; set; }


    }
}
