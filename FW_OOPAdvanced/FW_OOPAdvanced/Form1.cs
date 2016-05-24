using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FW_OOPAdvanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba arb = new Araba();
            Otobus bus = new Otobus();
            Tır dır = new Tır();

            TasimaKapasitesiGoster(bus);
            TasimaKapasitesiGoster(arb);
           
            TasimaKapasitesiGoster(dır);
            
        }

        void TasimaKapasitesiGoster(ITasiyabilable its)
        {

            its.Tasi();
        
        }
    }
}
