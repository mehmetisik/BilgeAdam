using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MdiLoginliGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kulAdi = "yigit";
        string sifre = "yılan";
        public static string tasinacak_data;//frmMain'e göndereceğimiz değeri taşıyan değişken
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == kulAdi && textBoxPassword.Text == sifre)
            {

                //Hem kullanıcı adı hem de şifre doğru olduğundan kullanıcı giriş yapmıştır ve ana forma gidebilir.
                this.DialogResult = DialogResult.OK;//Eğer kullanıcının login bilgileri doğruysa,bu formun DialogResult özelliğini öbür formda kontrol etmek için DialogResult.Ok yapıyoruz.
                tasinacak_data = "Hoşgeldiniz:" + kulAdi + " Oturum Açma Zamanı:" + DateTime.Now.ToLongTimeString();


            }
            else
            {
                MessageBox.Show("Kullanıcı adını ya da şifreyi hatalı girdiniz.");
            
            }
        }
    }
}
