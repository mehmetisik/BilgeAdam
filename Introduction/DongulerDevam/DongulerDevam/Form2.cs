using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DongulerDevam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLoto_Click(object sender, EventArgs e)
        {
            listBoxSayilar.Items.Clear();

            Random rastgele = new Random();

            for (byte kacTane = 0; kacTane < 6; kacTane++)
            {
                //Öncelikle her bir döngü için rastgele sayı oluşturuyoruz.
                int rastgele_sayi = rastgele.Next(1, 50);

                //Sayıların aynı gelmemesi gerekiyor.Dolayısıyla ekleme yapılırken,rastgele oluşturulan sayı listede var mı yok mu kontrol etmemiz gerekir.Eğer listede aynı sayıdan varsa ekleme yapmayacağız.

                //ListBox içinde bir elemanın olup olmadığını Contains metodu ile kontrol ederiz.Contains metodu geriye mantıksal olarak true ya da false değeri döndürür.Eğer eleman varsa geriye true değeri döner,yoksa false değeri döner.
                if (!listBoxSayilar.Items.Contains(rastgele_sayi))
                {

                    listBoxSayilar.Items.Add(rastgele_sayi);
                
                }

            
            }

            
        }
    }
}
