using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_INHERITANCE
{
    class CepTelefonu:Telefon
    {
        public bool BlueToothVarMi { get; set; }
        public bool InternetliMi { get; set; }
        public bool KameraliMi { get; set; }


        public override void Cal()
        {
            MessageBox.Show("bili bili bili");
        }

    }
}
