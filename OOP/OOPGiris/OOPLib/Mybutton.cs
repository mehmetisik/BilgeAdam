using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace OOPLib
{
   public class Mybutton:Button
    {

       private string ad;

       [Description("Sadece get edilebilir.")]
       public string Ad
       {
           get { return ad; }
       
       }

    }
}
