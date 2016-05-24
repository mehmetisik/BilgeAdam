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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int ay = 1; ay < 13; ay++)
            {
                comboBoxAylar.Items.Add(ay);

            }

            for (int yil = 1900; yil <= DateTime.Now.Year; yil++)
            {

                comboBoxYillar.Items.Add(yil);

            }

            //comboBoxYillar.SelectedIndex = 0;//İlk elemanı seçili yapıyoruz.
            comboBoxYillar.SelectedIndex = comboBoxYillar.Items.Count - 1;//Son elemanı seçili yapıyoruz.
            comboBoxAylar.SelectedIndex = 0;



        }

        void GunOlustur()
        {
            comboBoxGunler.Items.Clear();//Alt alta sürekli ekleme yapmaması için combboyu temizliyoruz.
            int secilenay = Convert.ToInt32(comboBoxAylar.SelectedItem.ToString());
            int secilenyil = Convert.ToInt32(comboBoxYillar.SelectedItem.ToString());

            //Belirtilen ay ve yıl bilgisine bağlı olarak toplam gün sayısını alıyoruz.
            int gunsayisi = DateTime.DaysInMonth(secilenyil, secilenay);

            for (int gun = 1; gun <= gunsayisi; gun++)
            {

                comboBoxGunler.Items.Add(gun);
            
            }

        }

        private void comboBoxAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GunOlustur();

            }
            catch { }

           
        }

        private void comboBoxYillar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                GunOlustur();
            }
            catch { }


           
        }
    }
}
