using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KosulKullanimlariDevam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxMevsimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Burada seçme işlemi gerçekleştiğinde çalışacak olan kodları yazıyoruz.

            //Seçtiğim elemanın index değerine yani sıra numarasına göre işlem yapabilirim.

            //Seçtiğimiz elemanın Text özelliğini kullanarak string ile karşılaştırma yaoabiliriz.
            //if(comboBoxMevsimler.SelectedItem.ToString()=="yaz")

            listBoxAylar.Items.Clear();//İlk olarak liste temizlenir.Alta alta ekleme yapılmasın diye...
            int secilen_indeks = comboBoxMevsimler.SelectedIndex;


            /*
            if (secilen_indeks == 0)
            {

                listBoxAylar.Items.Add("Mart");
                listBoxAylar.Items.Add("Nisan");
                listBoxAylar.Items.Add("Mayıs");

            }
            else if (secilen_indeks == 1)
            {

                listBoxAylar.Items.Add("Haziran");
                listBoxAylar.Items.Add("Temmuz");
                listBoxAylar.Items.Add("Ağustos");

            }
            else if (secilen_indeks == 2)
            {

                listBoxAylar.Items.Add("Eylül");
                listBoxAylar.Items.Add("Ekim");
                listBoxAylar.Items.Add("Kasım");

            }
            else
            {

                listBoxAylar.Items.Add("Aralık");
                listBoxAylar.Items.Add("Ocak");
                listBoxAylar.Items.Add("Şubat");

            }
             * */

            switch (secilen_indeks)
            {

                case 0:
                    listBoxAylar.Items.Add("Mart");
                    listBoxAylar.Items.Add("Nisan");
                    if (true)
                    {
                        MessageBox.Show("Merhaba");
                    
                    }
                    listBoxAylar.Items.Add("Mayıs");
                    break;
                case 1:
                    listBoxAylar.Items.Add("Haziran");
                    listBoxAylar.Items.Add("Temmuz");
                    listBoxAylar.Items.Add("Ağustos");
                    break;
                case 2:
                    listBoxAylar.Items.Add("Eylül");
                    listBoxAylar.Items.Add("Ekim");
                    listBoxAylar.Items.Add("Kasım");
                    break;
                    //Yukarıdaki seçeneklerin hiçbiri sağlanmazsa default bloğu çalışır.if-else yapısında else bloğuna karşılık gelebileceğini söyleyebiliri.z
                default:
                    listBoxAylar.Items.Add("Eylül");
                    listBoxAylar.Items.Add("Ekim");
                    listBoxAylar.Items.Add("Kasım");
                    break;

            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
