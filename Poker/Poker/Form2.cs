using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Poker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        string[] dosyayollari;//Resimlerin dosya yollarını tuttuğumuz dizi
        Image[] resimler;//PictureBox'a ekleyeceğimiz resimleri tutacak dizi
       
        
        private void buttonDagit_Click(object sender, EventArgs e)
        {
            ResimleriOlustur();
            groupBoxPlayer1.Controls.Clear();
            #region Player1Dagitim
            int birincioyuncu_kartsayisi = 0;
            //1.Oyuncu İçin Kart Dağıtımı
            Random r = new Random();
            int left = 5, top = 5;
            while (birincioyuncu_kartsayisi < 4)
            {

                int resim_indeks = r.Next(0, resimler.Length);
                //Eklediğimiz indeks değerine sahip Image'e null değerini atıyoruz.Dolayısıyla gelen indeks değerine sahip Image null değerine sahip değilse henüz eklenmemiş demektir.
                if (resimler[resim_indeks] != null)
                { 
                
                    //PictureBox'ları oluşturuyoruz.
                    PictureBox pb = new PictureBox();
                    pb.Image = resimler[resim_indeks];
                    pb.Width = 70;
                    pb.Tag = resimler[resim_indeks].Tag;
                    pb.Click += new EventHandler(pb_Click);
                    pb.Height = 70;
                    pb.Left = left;//bulunduğu groupbox'ın sol tarafa olan uzaklığı
                    pb.Top = top;//bulunduğu groupbox'ın üst tarafa olan uzaklığı

                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    groupBoxPlayer1.Controls.Add(pb);
                    left += 72;
                    resimler[resim_indeks] = null;
                    birincioyuncu_kartsayisi++;

                
                }

            }
            #endregion






        }

        void pb_Click(object sender, EventArgs e)
        {
            PictureBox tiklanan = sender as PictureBox;
            MessageBox.Show(tiklanan.Tag.ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void ResimleriOlustur()
        {
            dosyayollari = Directory.GetFiles(Application.StartupPath, "*.jpg");
            resimler = new Image[dosyayollari.Length];
            int indeks = 0;//resimler dizisine eleman eklemek için kullanacağımız değişken

            foreach (string yol in dosyayollari)
            {

                Image img = Image.FromFile(yol);
                img.Tag = yol.Split('-')[1].Split('.')[0];
                resimler[indeks] = img;
                indeks++;

            }
        }
    }
}
