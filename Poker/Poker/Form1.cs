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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] dosyayollari;//İskambil resimlerinin her birinin yol(path) bilgisini tutan dizi
        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
           int indeks=rastgele.Next(0, dosyayollari.Length);//dosyayollari.Lenght dizinin uzunluğunu bize verir.En son index değeri eleman sayısı-1 olacağından Next metodunun son parametresi dizinin eleman sayısına eşit olmalıdır.

           pictureBoxKart.Image = Image.FromFile(dosyayollari[indeks]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //İskambil kağıtlarını prjemizin çalışmaya başladığı Debug klasörüne attık.Bu klasörde bulunan sadece jpg uzantılı dosyaların yol bilgilerini alıp diziye atıyoruz.
           dosyayollari=Directory.GetFiles(Application.StartupPath, "*.jpg");



        }
    }
}
