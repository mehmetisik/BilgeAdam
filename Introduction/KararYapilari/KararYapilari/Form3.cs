using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kullanıcından değeri aldık.
            int sayi = Convert.ToInt32(textBoxSayi.Text);

            if (sayi % 2 == 0)
            {
                //Sayının 2'ye bölümünden kalan 0 ise 
                MessageBox.Show("Girilen Sayı Çift Sayıdır!");

            }
            else
            {
                MessageBox.Show("Girilen Sayı Tek Sayıdır!");
            
            }

            textBoxSayi.Clear();//TextBox'ın içini temizlememizi sağlar.
            textBoxSayi.Focus();//TextBox'ın içine imlecin gelmesi


        }
    }
}
