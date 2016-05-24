using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiziDonguDevam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {

            for (int tarih = 1950; tarih < DateTime.Now.Year - 18; tarih++)
            {

                //if (tarih != 1980)

                //    listBoxDogumYillari.Items.Add(tarih);

                if (tarih == 1980)
                    continue;//Altındaki hiçbir kodu çalıştırmadan direk döngüde artıma gider ve döngü dönmeye devam eder.



                listBoxDogumYillari.Items.Add(tarih);



            }
        }

        private void buttonTarih_Click(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;

            MessageBox.Show(tarih.ToLongDateString());
        }


        private void buttonHarfEkle_Click(object sender, EventArgs e)
        {

            for (char harf = 'A'; harf <= 'Z'; harf++)
            {

                if (harf == 'X' || harf == 'Q' || harf == 'W')
                {
                    continue;
                }

                listBoxHarfler.Items.Add(harf);

                //if (harf == 'C')
                //{
                //    listBoxHarfler.Items.Add('Ç');
                //}
                //else if (harf == 'G')
                //{

                //    listBoxHarfler.Items.Add('Ğ');

                //}
                //else if (harf == 'I')
                //{

                //    listBoxHarfler.Items.Add('İ');

                //}
                //else if (harf == 'S')
                //{

                //    listBoxHarfler.Items.Add('Ş');

                //}

                switch (harf)
                {

                    case 'C':
                        listBoxHarfler.Items.Add('Ç');
                        break;

                    case 'G':
                        listBoxHarfler.Items.Add('Ğ');
                        break;

                    case 'I':
                        listBoxHarfler.Items.Add('İ');
                        break;
                    case 'S':
                        listBoxHarfler.Items.Add('Ş');
                        break;
                    case 'O':
                        listBoxHarfler.Items.Add('Ö');
                        break;
                    case 'U':
                        listBoxHarfler.Items.Add('Ü');
                        break;








                }

            }
        }
    }
}
