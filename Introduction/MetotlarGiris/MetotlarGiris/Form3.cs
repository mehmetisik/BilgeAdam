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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        int YasHesapla(DateTime dogumTarihi)
        {

            return DateTime.Now.Year - dogumTarihi.Year;
        
        }

        int YasHesapla(int dogumYili)
        {

            return DateTime.Now.Year - dogumYili;
        
        
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            for (int yil = 1950; yil <= DateTime.Now.Year; yil++)
            {

                comboBoxYillar.Items.Add(yil);
            
            }
        }

        private void buttonTarih_Click(object sender, EventArgs e)
        {


            int yas=YasHesapla(dateTimePickerDogum.Value);
            MessageBox.Show(yas.ToString());
        }

        private void buttonYil_Click(object sender, EventArgs e)
        {
          int yas=YasHesapla(Convert.ToInt32(comboBoxYillar.SelectedItem.ToString()));

          MessageBox.Show(yas.ToString());
          

        }
    }
}
