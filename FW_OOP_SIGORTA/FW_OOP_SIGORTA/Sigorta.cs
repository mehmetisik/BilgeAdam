using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FW_OOP_SIGORTA
{
    class Sigorta
    {
        //field
        private int _amper;

        //Property
        public int Amper
        {

            get { return _amper; }
            set { _amper = value; }
        
        }

        public Sigorta(int Amper)
        {
            this.Amper = Amper;
        }

        //delegate
        public delegate void SigortaAtti();
        public event SigortaAtti sigortayandi;

            

    }
}
