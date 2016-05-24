using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KontrolKullanim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHareket_Click(object sender, EventArgs e)
        {
            //pbResim.Left += 5;//Varolan değeri koruyarak her seferinde sol tarafa olan uzaklık yani Left değeri sürekli artacak.

            //Butonun görevi Timer'ı yani otomatik işlemi yapacağımız kontrolü başlatmak.

            tmrHareket.Start();
        }

        private void tmrHareket_Tick(object sender, EventArgs e)
        {
            //Otomatik olarak gerçekleşecek işlemler Tick eventi içerisine yazılır.
            //Otomatik olarak resim bizim belirlediğimiz zaman aralığında(Interval) sağ tarafa doğru hareket edecek.

            pbResim.Left += 3;
        }
    }
}
