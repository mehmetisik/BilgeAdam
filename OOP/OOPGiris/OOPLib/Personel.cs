using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace OOPLib
{
   public class Personel
    {
        //Sadece class içinden erişilebilir değişken
        private string ad;

        //Property(özellik-zarf tutan el tanımlaması)
       [Description("Personel Ad değeri elde edilebilir ve bu özelliğe değer atanabilir.")]
        public string Ad
        {

            get {return ad ;}
            set { ad = value; }
        
        }
    }
}
