using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_STATIC
{
    class Musteri
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KimlikNo { get; set; }

       public static void MailGonder(string mesaj)
        {
            MessageBox.Show(mesaj + " gönderildi");
        
        }

    }
}
