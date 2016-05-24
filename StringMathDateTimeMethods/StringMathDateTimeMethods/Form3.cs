using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringMathDateTimeMethods
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            //double us=Math.Pow(2, 3);
            //MessageBox.Show(us.ToString());

            //MessageBox.Show(Math.Sqrt(16).ToString());


            MessageBox.Show(GeometrikOrtalamaHesapla(1,5,10,27,48).ToString());
        }

        double GeometrikOrtalamaHesapla(params int [] sayilar)
        {

            double carpim = 1;

            foreach (int sayi in sayilar)
            {

                carpim *= sayi;
            
            }

            return Math.Pow(carpim, 1.0 / sayilar.Length);
        
        
        }

        
    }
}
