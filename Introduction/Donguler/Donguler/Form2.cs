using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxSayi_TextChanged(object sender, EventArgs e)
        {
            //TextBox'ın karakter uzunluğu 0'dan büyükse
            if (textBoxSayi.Text.Length > 0)
            {

                buttonHadi.Enabled = true;

            }
            else
            {
                buttonHadi.Enabled = false;
            
            }
        }

        private void buttonHadi_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxSayilar.Items.Clear();//Temizleme hep önce gerçekleşmeli

                int girilen_sayi = Convert.ToInt32(textBoxSayi.Text);

                for (int sayi = 1; sayi <= girilen_sayi; sayi++)
                {

                    if (sayi % 2 == 0)
                    {
                        listBoxSayilar.Items.Add(sayi);

                    }


                }

            }
            catch
            {
                MessageBox.Show("Oraya sayı gir demiştik!");

            }
            finally
            {
                textBoxSayi.Clear();
            
            }
            
        }
    }
}
