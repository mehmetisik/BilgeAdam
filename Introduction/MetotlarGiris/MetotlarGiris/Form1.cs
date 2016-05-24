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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void Temizle()
        {

            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxAdres.Clear();
            textBoxTelefon.Clear();
            dateTimePickerDogum.Value = DateTime.Now;
            textBoxEmail.Clear();
        
        
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgileriniz başarılı bir şekilde kaydedildi!");
            Temizle();

            
            
        }

        int Topla(int birincisayi,int ikincisayi)
        {

            return birincisayi + ikincisayi;
        
        }



        private void buttonİptal_Click(object sender, EventArgs e)
        {
            Temizle();
            MessageBox.Show(Topla(10, 20).ToString());
        }


    }
}
