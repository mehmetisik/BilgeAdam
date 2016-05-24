using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FW_OOPAdvanced
{
    //class'ın varsayılan erişim belirleyicisi internal'dır.Tanımlandığı namespace üzerinden erişilebilir.
    class Tasit
    {

        public Color Renk { get; set; }
        public string UretimYeri { get; set; }
        public decimal Fiyat { get; set; }
        public string YakitTipi { get; set; }


    }
}
