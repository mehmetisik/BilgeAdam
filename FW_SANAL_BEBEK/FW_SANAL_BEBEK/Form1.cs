using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FW_SANAL_BEBEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bebek b;
        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bebek();
            b.Aciktim += new Bebek.ParametresizEventHandler(b_Aciktim);
            b.AzrailGeldi += new Bebek.ParametreliEventHandler(b_AzrailGeldi);
            timerYasam.Start();

        }

        void b_AzrailGeldi(string olumsebebi)
        {
            labelDurum.Text = olumsebebi;
        }

        private void timerYasam_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            b.AclikDurumu += rastgele.Next(0, 10);
            b.GazDurumu += rastgele.Next(1, 4);
            b.UykuDurumu += rastgele.Next(5, 10);
            b.CisDurumu += rastgele.Next(1, 5);
            b.MutlulukDurumu += rastgele.Next(10, 14);

            LabellerdaGoster();


            if (b.AclikDurumu > 80 && b.AclikDurumu < 100)
            {

                b.AcimBen();
            
            }
            else if (b.AclikDurumu > 100)
            { 
            
             b.GunesiGordum("b.Aciktim += new Bebek.ParametresizEventHandler(b_Aciktim);");
             timerYasam.Stop();
            
            }

        }

        void b_Aciktim()
        {
            labelDurum.Text = "Besle Beni";
        }

        void LabellerdaGoster()
        {

            labelAclik.Text = b.AclikDurumu.ToString();
            labelGaz.Text = b.GazDurumu.ToString();
            labelMutluluk.Text = b.MutlulukDurumu.ToString();
            labelUyku.Text = b.UykuDurumu.ToString();
            labelLavabo.Text = b.CisDurumu.ToString();
        
        
        }
    }
}
