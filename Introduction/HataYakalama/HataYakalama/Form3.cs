using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HataYakalama
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBoxDosyalar_TextChanged(object sender, EventArgs e)
        {

            //Eğer içerisine girilen karakter varsa,buton aktif yapılır.Trim() metodu ile sağ ve sol taraftaki boşlukları temizliyoruz.
            if (comboBoxDosyalar.Text.Trim().Length > 0)
            {

                buttonRun.Enabled = true;

            }
            //Karakter sayısı 0 ise buton tekrar pasife çekilir.
            else
            {

                buttonRun.Enabled = false;

            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {

            //Kullanıcı bir dosya seçmişse
            if (openFileDialogDosya.ShowDialog() == DialogResult.OK)
            {

                //Dosyanın yolunu combo'nun Text özelliğinde gösteriyoruz.
                comboBoxDosyalar.Text = openFileDialogDosya.FileName;
                comboBoxDosyalar.Items.Add(openFileDialogDosya.FileName);

                

            }

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            //Herhangi bir dosyayı çalıştırmak için kullandığımız komut

            try
            {
                System.Diagnostics.Process.Start(comboBoxDosyalar.Text);

            }
            catch
            {

                MessageBox.Show("Lütfen adam gibi bir dosya seçiniz!Olmayan dosyayı seçip kafamı bozma");
            
            }

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();//Uygulamayı sonlandırır.

            this.Close();
        }
    }
}
