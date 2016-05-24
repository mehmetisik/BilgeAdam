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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Parametre olarak aldığı iki int değeri toplayıp geriye değer olarak döndürür.
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <returns></returns>
        int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        
        
        }

        /// <summary>
        /// Parametre olarak almış olduğu iki string değeri,integer'a çevirip bu iki değerin toplamını döndürür.
        /// </summary>
        /// <param name="birinci"></param>
        /// <param name="ikinci"></param>
        /// <returns></returns>
        int Topla(string birinci, string ikinci)
        {

            return Convert.ToInt32(birinci) + Convert.ToInt32(ikinci);
        
        
        }

        private void buttonTopla_Click(object sender, EventArgs e)
        {
            int sonuc=Topla(textBoxSayi1.Text, textBoxSayi2.Text);

            
             

            MessageBox.Show(sonuc.ToString());

        }

    }
}
