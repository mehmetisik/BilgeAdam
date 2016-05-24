using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_STATIC
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        //frmMain formuna taşınacak değişken
        public static string kullaniciAd;
        private void button1_Click(object sender, EventArgs e)
        {
            //Açılacak olan formun bir instanceI yani fotokopisi alınır.

            if(string.IsNullOrEmpty(textBoxUser.Text.Trim()))
            {
            
                MessageBox.Show("Lütfen Bir Kullanıcı Adı Giriniz!");
                return;//Click scope'u dışına atacağından aşağıdaki kodların hiçbiri çalışmaz.
            
            }

            kullaniciAd = textBoxUser.Text;
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}
