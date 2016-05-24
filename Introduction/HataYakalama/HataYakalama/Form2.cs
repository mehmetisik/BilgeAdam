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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonGozat_Click(object sender, EventArgs e)
        {
            //Kullanıcıya herhangi bir klasörden dosya seçmesini ve gözatabilmesini sağlayan kontrol opendialog kontrolüdür.Ve kullanıcıya diyalog penceresi açmak için de ShowDialog metodu kullanılır.

            //Herhangi bir format vermek istiyorsa filter özelliğini kullanırız.*'dan sonrasrı uzantı,önceki ise format type'da gözükece olan kısım
            //openFileDialogDosya.Filter = "jpg|*.jpg|png|*.png";


            //Kullanıcıya diyalog penceresi açılmış ve kullanıcı oradan dosya seçmişse
            if (openFileDialogDosya.ShowDialog() == DialogResult.OK)
            {

                //PictureBox'a resim eklemek için Image özelliğini kullanıyoruz.Herhangi bir resmi eklemek için dosyanın yolunu(path) almamız yeterli.Bunu da Image.FromFile ile gerçekleştiriyoruz.

                try
                {

                    pictureBoxResim.Image = Image.FromFile(openFileDialogDosya.FileName);

                }
                catch
                {
                    MessageBox.Show("Lütfen resim uzantını destekleyen formattaki dosyaları seçiniz.");
                
                }
               
            
            }

            
        }
    }
}
