using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FW_SYSTEM_AYO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter("C:/Yazi.txt", true);
            sw.Write(textBox1.Text);
            sw.Close();

            //Dosyanın içeriğini bir byte dizine atma...
            //FileStream fs = new FileStream("C://Yazi.txt", FileMode.Open);
            //byte[] dizi = new byte[fs.Length];
            //fs.Read(dizi, 0, dizi.Length);//Dosya içeriğini byte dizisine yazdırmak için Read metodu kullanılır.
            //fs.Close();


            ////Herhangi bir byte dizisinin içeriğini dosyaya yazdırma
            //FileStream olusturucu = new FileStream("C://Yeni.txt", FileMode.Create);
            //olusturucu.Write(dizi, 0, dizi.Length);
            //olusturucu.Close();

            File.Delete("C://Yazi.txt");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:/Yazi.txt");
            textBox1.Text=sr.ReadToEnd();
            sr.Close();
        }
    }
}
