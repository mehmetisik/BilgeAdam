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
                
            
            }
           

        }
    }
}
