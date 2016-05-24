using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FW_OOPAdvanced
{
    class Araba:Tasit,ITasiyabilable
    {
        public void Tasi()
        {
            MessageBox.Show("En fazla 5 kişi taşırım ben");
        }
    }

    class Otobus:Tasit,ITasiyabilable
    {


        public void Tasi()
        {
            MessageBox.Show("Eğer ben bir İETT otobüsüysem 278 kişi alırım ben");
        }
    }
    class Tır:Tasit,ITasiyabilable
    {




        public void Tasi()
        {
            MessageBox.Show("Ben daha çok taşırım");
        }
    }


}
