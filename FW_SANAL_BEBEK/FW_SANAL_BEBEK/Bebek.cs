using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FW_SANAL_BEBEK
{
    class Bebek
    {
        //Properties
        public int AclikDurumu { get; set; }
        public int MutlulukDurumu { get; set; }
        public int GazDurumu { get; set; }
        public int UykuDurumu { get; set; }
        public int CisDurumu { get; set; }

        //Delegates
        public delegate void ParametresizEventHandler();
        public delegate void ParametreliEventHandler(string olumsebebi);

        //Events
        public event ParametresizEventHandler Aciktim;
        public event ParametresizEventHandler UykumGeldi;
        public event ParametresizEventHandler GazimGeldi;
        public event ParametresizEventHandler Mutsuzum;
        public event ParametresizEventHandler CisimGeldi;


        public event ParametreliEventHandler AzrailGeldi;

        //Methods
        public void AcimBen()
        {
            Aciktim();
        
        }

        public void UykuluyumBen()
        {

            UykumGeldi();
        
        }

        public void KarnimAgriyor()
        {
            GazimGeldi();
           
        
        }
        public void SilaDinliyorum()
        {
            Mutsuzum();
        
        }
        public void LavaboyaGidiyorum()
        {
            CisimGeldi();
        
        }

        public void GunesiGordum(string sebep)
        {
            AzrailGeldi(sebep);
        
        }

    }
}
