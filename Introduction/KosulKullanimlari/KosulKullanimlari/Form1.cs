using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KosulKullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kullaniciadi = "admin";
        string sifre = "1234";
        

        private void buttonGiris_Click(object sender, EventArgs e)
        {

            

            if (kullaniciadi == textBoxKullaniciAdi.Text & sifre == textBoxSifre.Text)
            {

                //Eğer yukarıdaki 2 koşul da sağlanırsa yani true olursa buradaki kod çalışır.
                MessageBox.Show(kullaniciadi + " isimli kullanıcı oturum açtı!");


            }
            else
            {

                MessageBox.Show("Kullanıcı adı ya da şifre hatalı");
            
            }

            textBoxKullaniciAdi.Clear();
            textBoxSifre.Clear();
            textBoxKullaniciAdi.Focus();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
