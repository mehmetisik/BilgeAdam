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

        //Personel[] personellistesi = new Personel[3];
        ArrayList personellistesi = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {

            //Personel p1=new Personel();
            //p1.Ad="Yiğit";

            //personellistesi[0] = p1;

            #region PersonellerinOlusturulması

            Personel p1 = new Personel();
            p1.Ad = "Nihat";
            p1.Soyad = "Doğan";
            p1.Adres = "Survivor";
            p1.Departman = "Yazılım";
            p1.Email = "nihat@survivor.com";

            Personel p2 = new Personel();
            p2.Ad = "Ajdar";
            p2.Soyad = "Çikita";
            p2.Adres = "Twitter";
            p2.Departman = "Megastar";

            Personel p3 = new Personel();
            p3.Ad = "Pascal";
            p3.Soyad = "Nouma";
            p3.Adres = "Beşiktaş";
            p3.Departman = "Futbolcu";
            p3.Email = "crazyboy@besiktas.com";

            //Oluşturulan nesnelerin ArrayList'e eklenmesi...
            personellistesi.Add(p1);
            personellistesi.Add(p2);
            personellistesi.Add(p3);




            #endregion


            foreach (Personel prs in personellistesi)
            {

                //Her bir presonel için,bir ListViewItem oluşturuyoruz.ListView'e eleman eklemek için ListViewItem kullanılır.
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = prs;
                lvi.Text = prs.Ad;//İlk sütuna göre değer verilmesini sağlar.
                //Daha sonraki sütunlara değer vermek için ise SubItems.Add metodu kullanılır.
                lvi.SubItems.Add(prs.Soyad);
                lvi.SubItems.Add(prs.Departman);


                listViewPersoneller.Items.Add(lvi);



            }


        }

        private void listViewPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Öncelikle seçtiğimiz ListViewItem'ı alacağız.

            //SelectedItems[0] demek seçilen elemanların ilki demektir.Zaten tek bir tane eleman seçtiğimiz için,seçtiğimiz elemanı bu şekilde almış oluyoruz.
            try
            {
                ListViewItem secilen_item = listViewPersoneller.SelectedItems[0];
                Personel secilen_personel = (Personel)secilen_item.Tag;
                textBoxAd.Text = secilen_personel.Ad;
                textBoxSoyad.Text = secilen_personel.Soyad;
                maskedTextBoxKimlikNo.Text = secilen_personel.KimlikNo;
                textBoxEmail.Text = secilen_personel.Email;
                textBoxAdres.Text = secilen_personel.Adres;
                comboBoxDepartmanlar.Text = secilen_personel.Departman;
                if (secilen_personel.Cinsiyet == false)
                {
                    radioButtonErkek.Checked = true;


                }
                else
                {

                    radioButtonKadin.Checked = false;

                }

            }
            catch
            {
                Temizle();

            }


        }

        DialogResult sonuc;//Kullanıcıdan,gösterdiğimiz MessageBox'lardan alınan değerleri tutacak değişken
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            //Listede bir eleman seçili demektir.Bu da bir güncelleme işlemi olacağı anlamına gelir.
            if (listViewPersoneller.SelectedItems.Count > 0)
            {

                //Seçtiğimiz liste elemanının arka tarafında tuttuğumuz Personel'i alıyoruz.
                Personel guncellenecek = (Personel)listViewPersoneller.SelectedItems[0].Tag;
                guncellenecek.Ad = textBoxAd.Text;
                guncellenecek.Soyad = textBoxSoyad.Text;
                guncellenecek.Departman = comboBoxDepartmanlar.Text;
                guncellenecek.KimlikNo = maskedTextBoxKimlikNo.Text;
                guncellenecek.Email = textBoxEmail.Text;
                guncellenecek.Adres = textBoxAdres.Text;
                if (radioButtonErkek.Checked)
                {

                    guncellenecek.Cinsiyet = false;
                }
                else
                {
                    guncellenecek.Cinsiyet = true;

                }

                sonuc = MessageBox.Show("İlgili kaydı güncellemek istediğinizden emin misiniz?Eski değişiklikler kaybolacak.Sonra yok yanlış oldu falan diye ağlamayın.", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {

                    listViewPersoneller.SelectedItems[0].SubItems[0].Text = guncellenecek.Ad;
                    listViewPersoneller.SelectedItems[0].SubItems[1].Text = guncellenecek.Soyad;
                    listViewPersoneller.SelectedItems[0].SubItems[2].Text = guncellenecek.Departman;
                    listViewPersoneller.SelectedItems[0].Tag = guncellenecek;


                }

            }
            else
            {
                //Seçili eleman olmadığından buradaki kod bloğu çalışacak.Bu da yeni bir Personel ekleneceği anlamına gelir.

                Personel yeni = new Personel();
                yeni.Ad = textBoxAd.Text;
                yeni.Soyad = textBoxSoyad.Text;
                yeni.Departman = comboBoxDepartmanlar.Text;
                yeni.KimlikNo = maskedTextBoxKimlikNo.Text;
                yeni.Email = textBoxEmail.Text;
                yeni.Adres = textBoxAdres.Text;
                if (radioButtonErkek.Checked)
                {

                    yeni.Cinsiyet = false;
                }
                else
                {
                    yeni.Cinsiyet = true;

                }

                sonuc = MessageBox.Show(textBoxAd.Text + " " + textBoxSoyad.Text + " isimli personeli eklemek istiyor musunuz?", "Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {

                    ListViewItem lvi = new ListViewItem();//ListView'e eleman eklemek için kullandığımız nesnemiz

                    lvi.Tag = yeni;
                    lvi.Text = yeni.Ad;
                    lvi.SubItems.Add(yeni.Soyad);
                    lvi.SubItems.Add(yeni.Departman);
                    listViewPersoneller.Items.Add(lvi);
                    
                
                
                }


            }





        }

        void Temizle()
        {

            //GroupBox içindeki bütün kontrollerde geziyoruz.
            foreach (Control gezilen in groupBoxBilgiler.Controls)
            {
                //
                if (gezilen is TextBox)
                {
                    (gezilen as TextBox).Clear();

                }
                else if (gezilen is MaskedTextBox)
                {

                    (gezilen as MaskedTextBox).Clear();

                }
                else if (gezilen is ComboBox)
                {

                    (gezilen as ComboBox).Text = string.Empty;//ComboBox'ın üzerindeki yazıyı temizliyoruz.

                }


            }


        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Temizle();

            //Seçili elemanın,seçili olma özelliğini ortadan kaldırıyoruz.
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

                //Silme işlemi gerçekleşecek.
                string isim=listViewPersoneller.SelectedItems[0].SubItems[0].Text+" "+listViewPersoneller.SelectedItems[0].SubItems[1].Text;
                sonuc = MessageBox.Show(isim + " isimli personeli silmek istiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {

                    if (isim.Contains("haydar"))
                    {

                        sonuc = MessageBox.Show("Çok önemli bir zatı silmek üzeresiniz,Emin misiniz?", "Hede İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (sonuc == DialogResult.Yes)
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

                MessageBox.Show("Silemezsin...Boşuna uğraşma.Git listeden eleman seç");
            
            }
        }
        
        void GroupBoxBilgilerEnter(object sender, EventArgs e)
        {
        	
        }
    }
}
