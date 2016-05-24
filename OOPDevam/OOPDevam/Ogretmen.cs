using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOPDevam
{
    class Ogretmen : Insan
    {
        public string Brans { get; set; }


    }

    class Futbolcu : Insan
    {
        public string Mevkii { get; set; }
        public int SutGucu { get; set; }

        public void SutCek(string nasılSutCeker)
        {
            MessageBox.Show(nasılSutCeker);

        }

    }

    class Manken
    {


    }
}
