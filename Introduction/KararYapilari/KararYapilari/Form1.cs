using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double fiyat;//Tüm scope'lardan erişebileceğimiz değişken
        private void buttonSiparis_Click(object sender, EventArgs e)
        {

           

            
            //NumericUpDown kontrolüne girilen değeri almak için value özelliği kullanılır.Tipi decimal'dır.Bunu double tipteki bir değişkene değer olarak atamak için Convert ile tip dönüşümü yapıyoruz.
            double adet = Convert.ToDouble(numAdet.Value);

            double indirim = Convert.ToDouble(txtIndirim.Text);

            //Matematiksel işlemlerde öncelik parantez,sonra çarpma ve bölme,daha sonra toplama ve çıkarmadadır.
            double toplam_tutar = fiyat * adet - (fiyat * adet * indirim/100);

            labelFiyat.Text = "Toplam Tutar:" + toplam_tutar.ToString();
            panelFiyat.Visible = true;//Panelin gözükmesini sağlıyoruz.





            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void cmbPizzalar_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (cmbPizzalar.SelectedItem.ToString() == "Karışık Pizza")
            {

                //Eğer seçilen değer Karışık Pizza ise...
                fiyat = 50;
                txtIndirim.Text = "0";

            }
            else if (cmbPizzalar.SelectedItem.ToString() == "Kaşarlı Pizza")
            {

                fiyat = 20;
                txtIndirim.Text = "20";

            }
            else if (cmbPizzalar.SelectedItem.ToString() == "Mantarlı Pizza")
            {
                fiyat = 5;
                txtIndirim.Text = "50";

            }
            else if (cmbPizzalar.SelectedItem.ToString() == "Sucuklu Pizza")
            {
                fiyat = 8;
                txtIndirim.Text = "10";

            }
            else
            {
                //Yukarıdaki koşulların hiçbiri sağlanmazsa else bloğu çalışır.
                fiyat = 100;

            }

        }
        private void buttonKapat_Click(object sender, EventArgs e)
        {
            panelFiyat.Visible = false;
        }

       


    }
}
