using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HataYakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOrtalama_Click(object sender, EventArgs e)
        {

            try
            {

                //Çalışma zamanı(runtime) hatalarını gidermek için try-catch bloğunu kullanırız.try içerisinde çalıştırmak istediğimiz ve hata ollması muhtemel kod parçasını yazarız.
                double birinci_sayi = Convert.ToDouble(textBoxSayi1.Text);

                double ikinci_sayi = Convert.ToDouble(textBoxSayi2.Text);

                double sonuc = (birinci_sayi + ikinci_sayi) / 2;

                MessageBox.Show(sonuc.ToString());

            }
            catch
            {

                //Hata meydana geldiğinde ne olacağını ise catch bloğunda belirtiriz.
                MessageBox.Show("Lütfen Sayısal Değerler Kullanarak İşlem Yapınız!");

            }
            finally
            {
                //Finally bloğunda ise hata olsa da olmasa da kesin olarak çalıştırılacak kod parçası tutulur.
                textBoxSayi1.Clear();
                textBoxSayi2.Clear();
            
            }



            
        }
    }
}
