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
                Temizle();
                
            }
        }

        DialogResult Sonuc;

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            if (listViewPersoneller.SelectedItems.Count>0)
            {
                Personel Guncellenecek = (Personel)listViewPersoneller.SelectedItems[0].Tag;
                Guncellenecek.Ad = textBoxAd.Text;
                Guncellenecek.Soyad = textBoxSoyad.Text;
                Guncellenecek.Departman = comboBoxDepartman.Text;
                Guncellenecek.KimlikNO = maskedTextBoxKimlikNo.Text;
                Guncellenecek.Email = textBoxEmail.Text;
                Guncellenecek.Adres = textBoxAdres.Text;
                if (radioButtonErkek.Checked)
                {
                    Guncellenecek.Cinsiyet = false;
                }
                else
                {
                    Guncellenecek.Cinsiyet = true;
                }

                Sonuc = MessageBox.Show("İlgili kaydı Güncellemek İstediğinizden Eminmisiniz Eski Değişiklikler Kaybolacak","Güncellme işlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (Sonuc ==DialogResult.Yes)
                {
                    listViewPersoneller.SelectedItems[0].SubItems[0].Text=Guncellenecek.Ad;
                    listViewPersoneller.SelectedItems[0].SubItems[1].Text = Guncellenecek.Soyad;
                    listViewPersoneller.SelectedItems[0].SubItems[2].Text = Guncellenecek.Adres;
                    listViewPersoneller.SelectedItems[0].Tag = Guncellenecek;

                }
                else
                {
                    Personel Yeni = new Personel();
                    Yeni.Ad = textBoxAd.Text;
                    Yeni.Soyad = textBoxSoyad.Text;
                    Yeni.Departman = comboBoxDepartman.Text;
                    Yeni.KimlikNO = maskedTextBoxKimlikNo.Text;
                    Yeni.Email = textBoxEmail.Text;
                    Yeni.Adres = textBoxAdres.Text;
                    if (radioButtonErkek.Checked)
                    {
                        Yeni.Cinsiyet = false;
                    }
                    else
                    {
                        Yeni.Cinsiyet = true;
                    }

                    Sonuc = MessageBox.Show(textBoxAd.Text+" "+textBoxSoyad.Text+"İsimli Personeli Eklemek İstiyomusunuz","Ekleme işlemş",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (Sonuc==DialogResult.Yes)
                    {
                        ListViewItem Lvi = new ListViewItem();
                        Lvi.Tag = Yeni;
                        Lvi.Text = Yeni.Ad;
                        Lvi.SubItems.Add(Yeni.Soyad);
                        Lvi.SubItems.Add(Yeni.Departman);

                        listViewPersoneller.Items.Add(Lvi);
                    }
                }
                
            }
            else
            {

            }
        }
        void Temizle()
        {
            foreach (Control Gezilen in groupBoxBilgiler.Controls)
            {
                if (Gezilen is TextBox)
                {
                    (Gezilen as TextBox).Clear();
                }
                else if (Gezilen is MaskedTextBox)
                {
                    (Gezilen as MaskedTextBox).Clear();

                }
                else if(Gezilen is ComboBox)
                {
                    (Gezilen as ComboBox).Text = string.Empty;
                }
            }

 
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Temizle();
            try
            {
                listViewPersoneller.SelectedItems[0].Selected = false;
            }
            catch 
            {
                
                
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (listViewPersoneller.SelectedItems.Count > 0)
            {
                string Isim = listViewPersoneller.SelectedItems[0].SubItems[0].Text + " " + listViewPersoneller.SelectedItems[0].SubItems[1].Text;
                Sonuc = MessageBox.Show(Isim+"İsimli personeli silmek istiyor msunuz","Silme İşlemi",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Sonuc == DialogResult.Yes)
                {
                    if (Isim.Contains("Haydar"))
                    {
                        Sonuc = MessageBox.Show("ÇokÖnemli Bi ismi Silmek Üzereseniz  Em,inmisiniz","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                        if (Sonuc==DialogResult.Yes)
                        {
                            listViewPersoneller.SelectedItems[0].Remove();
                        }
                    }
                    else
                    {
                        listViewPersoneller.SelectedItems[0].Remove();
                    }

                }
                

            }
            else 
            {
                MessageBox.Show("Silemezsin lisreden elemean seciniz");
            }
        }


        
    }
}
