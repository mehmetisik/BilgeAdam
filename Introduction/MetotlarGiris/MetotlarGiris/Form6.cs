using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetotlarGiris
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        double Topla(params double [] sayilar)
        {
            double sonuc = 0;

            foreach (double sayi in sayilar)
            {

                sonuc += sayi;
            
            }

            return sonuc;
        
        }
        void YerDegistir(ref int sayi, ref string isim)
        {

            sayi = 10;
            isim = "ali";

        }
        
        private void Form6_Load(object sender, EventArgs e)
        {
            Topla(1, 2, 4, 5,10.2,20,40,80);
        }

        string ad = "veli";
        int rakam = 100;
        private void button2_Click(object sender, EventArgs e)
        {

            YerDegistir(ref rakam,ref ad);

            MessageBox.Show("veli" + ad + " olmuştur!" + "100 ise " + rakam + " olmuştur!");



        }

        
    }
}
