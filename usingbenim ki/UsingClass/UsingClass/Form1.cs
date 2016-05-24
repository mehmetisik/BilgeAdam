using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace UsingClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Personel[] PersonelListesi = new Personel[3];
        ArrayList PersonelListesi = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Personellerin Olusturulmasi

            Personel P1 = new Personel();
            P1.Ad = "Nihat";
            P1.Soyad = "Doğan";
            P1.Adres = "Survivor";
            P1.Departman = "Yazılım";
            P1.Email = "Naihat@Survivor.com";

            Personel P2 = new Personel();
            P2.Ad = "Ajdar";
            P2.Soyad = "Çikita";
            P2.Adres = "Twitter";
            P2.Departman = "Megastar";

            Personel P3 = new Personel();
            P3.Ad = "Mehmet";
            P3.Soyad = "Kara";
            P3.Adres = "Ev";
            P3.Departman = "Teknik";
            P3.Email = "Me @fff.com";

            PersonelListesi.Add(P1);
            PersonelListesi.Add(P2);
            PersonelListesi.Add(P3);
            
            


            #endregion

            foreach (Personel Prs in PersonelListesi)
            {
                ListViewItem Lvi = new ListViewItem();
                Lvi.Tag = Prs;
                Lvi.Text = Prs.Ad;
                Lvi.SubItems.Add(Prs.Soyad);
                Lvi.SubItems.Add(Prs.Departman);

                listViewPersoneller.Items.Add(Lvi);

            }



        }

        private void listViewPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem SecilenItem = listViewPersoneller.SelectedItems[0];
                Personel SecilenPersonel = (Personel)SecilenItem.Tag;
                textBoxAd.Text = SecilenPersonel.Ad;
                textBoxSoyad.Text = SecilenPersonel.Soyad;
                maskedTextBoxKimlikNo.Text = SecilenPersonel.KimlikNO;
                textBoxEmail.Text = SecilenPersonel.Email;
                textBoxAdres.Text = SecilenPersonel.Adres;
                comboBoxDepartman.Text = SecilenPersonel.Departman;
                if (SecilenPersonel.Cinsiyet == false)
                {
                    radioButtonErkek.Checked = true;
                }
                else
                {
                    radioButtonBayan.Checked = true;
                }
            }
            catch 
            {
                
                
            }
        }

        
    }
}
