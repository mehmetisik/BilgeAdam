using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdiLoginliGiris
{
    class Bilet
    {

        public decimal Para { get; set; }
        public BiletTipi tip { get; set; }
    }

    enum BiletTipi
    { 
    
        Tam,
        Indirimli,
        Yasli,
        Ogrenci
    
    }
}
