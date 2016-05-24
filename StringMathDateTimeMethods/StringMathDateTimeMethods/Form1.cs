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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxSehir.Text.Trim()))
            {

                MessageBox.Show("Lütfen eklemek içi bir şehir giriniz");
                return;
            
            }

            bool varMi = false;//Ekleyeceğimiz şehrin,listede olup olmadığını kontrol eden değişken
            foreach (string sehir in listBoxSehirler.Items)
            {
                //Girilen iki string birbirine eşitse
                //OrdinalIgnoreCase:i->I
                //cURRENTCulterIgnoreCase->Bizde ise i->İ olacaktır.
                if (string.Equals(sehir, textBoxSehir.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
                {

                    varMi = true;
                    break;//Döngüyü sonlandırıyoruz.

                }
              
            
            }//Döngünün bitişi

            if (varMi == true)
            {

                MessageBox.Show("Zaten listede var!");

            }
            else
            {
                listBoxSehirler.Items.Add(textBoxSehir.Text.Trim());
            
            }

           
            
        }
    }
}
