using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_INHERITANCE
{
    class EvTelefonu:Telefon
    {

        public bool TelsizMi { get; set; }
        public bool ElleCevirmeliMi { get; set; }

        public override void Cal()
        {
            MessageBox.Show("lelelel lelelele");
        }

    }
}
