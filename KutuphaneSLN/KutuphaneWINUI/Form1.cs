using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kutuphane.Facade;
using System.IO;
using Kutuphane.Entity;

namespace KutuphaneWINUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int yil = 1950; yil <= DateTime.Now.Year; yil++)
            {

                comboBoxYillar.Items.Add(yil);
            
            }

            YayınEviDoldur();

        }

        private void YayınEviDoldur()
        {
            comboBoxYayinEvleri.DataSource = null;
            comboBoxYayinEvleri.DisplayMember = "Yayınevi";
            comboBoxYayinEvleri.ValueMember = "ID";
            comboBoxYayinEvleri.DataSource = YayinEviIslem.YayinEviGetir();
        }


        byte[] resim_data;
        private void buttonGozat_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png|*.png|jpg|*.jpg|bmp|*.bmp|jpeg|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

                resim_data = new byte[fs.Length];
                fs.Read(resim_data, 0, resim_data.Length);
                fs.Close();

                pictureBoxResim.Image = Image.FromFile(ofd.FileName);



            
            }

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Kitap yeni = new Kitap();
            yeni.KitapAD = textBoxKitap.Text;
            yeni.ISBNNO = textBoxISBN.Text;
            yeni.SayfaSayisi = Convert.ToInt16(textBoxSayfa.Text);
            yeni.KapakResmi = resim_data; 
            yeni.BasimTarihi = Convert.ToInt32(comboBoxYillar.SelectedItem.ToString());
            yeni.YayinEviID = Convert.ToInt32(comboBoxYayinEvleri.SelectedValue);

            int gelen=KitapIslem.KitapEkle(yeni);

            if (gelen > 0)
            {

                MessageBox.Show("Kayıt Eklendi!");
            
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormYayinEvi frm = new FormYayinEvi();
            frm.eveklendi += new FormYayinEvi.ParametresizEventHandler(frm_eveklendi);
            frm.evsilindi += new FormYayinEvi.ParametresizEventHandler(frm_evsilindi);
            frm.ShowDialog();
        }

        void frm_evsilindi()
        {
            YayınEviDoldur();
        }

        void frm_eveklendi()
        {
            YayınEviDoldur();
        }
    }
}
