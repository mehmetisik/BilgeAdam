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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int makine_hareketi;//Formun tıpkı slot makinesi gibi yukarı aşağı ve sağ sol haraketi yaparak sallanma hareketinde kullanacağımız kontrol amaçlı değişken

        int kacKere;//Formun sallanma hareketinin kaç defa gerçekleşeceğini belirleyen değişken

        int jeton_sayisi;//Kasaya atılan jeton sayısını tutacak değişken
        int birinci_indeks, ikinci_indeks, ucuncu_indeks;
        private void timerHareket_Tick(object sender, EventArgs e)
        {
            //Tick olayında sallanma olayının 20 defa gerçekleşmesini ,istiyoruz.Dolayısıyla bunun gerçekleşmesi için kacKare değişkeninden faydalanırız.
            if (kacKere < 50)
            {

                #region Formun Sallanması
                if (makine_hareketi == 0)
                {

                    //bulunduğumuz form ile ilgili özellikleri değiştirmek için this anahtar kelimesini kullanırız.this bulunduğumuz formu temsil eder.

                    this.Left += 5;//Sağ tarafa 5 pixel kaydırıyoruz.
                    this.Top += 5;//Aşağıya doğru 5 pixel indiriyoruz
                    makine_hareketi = 1;

                }
                else
                {

                    this.Left -= 5;
                    this.Top -= 5;
                    makine_hareketi = 0;


                }
                #endregion


                #region ResimDöndürme
                //Resimlerin döndürülmesi

                Random r = new Random();
                //Oluşturacağımız indeks asla eleman sayısının 1 eksiğini geçmemeli.Örneğin 4 elemanlı bir listeden elde edebileceğimiz indeks numarası en fazla 4-1 yani 3 alacaktır.Çünkü index değeri 0'dan başlar.

                //imagelist içinde kaç resim olduğunu imagelist.Images.Count özelilliğinden alırız.

                //
               birinci_indeks = r.Next(0, ımageListResimler.Images.Count);

                ikinci_indeks = r.Next(0, ımageListResimler.Images.Count);

                ucuncu_indeks = r.Next(0, ımageListResimler.Images.Count);


                //PictureBox'lara resim eklemek için Image özelliğini kullanırız.ımageList'ten resim almak için index adını verdiğimiz sıra numaralarından faydalanırız.Yukarıda oluşturduğumuz rastgele sıra numaralarını,imageList'ten eleman almak için kullanıyoruz.
                pictureBoxResim1.Image = ımageListResimler.Images[birinci_indeks];

                pictureBoxResim2.Image = ımageListResimler.Images[ikinci_indeks];

                pictureBoxResim3.Image = ımageListResimler.Images[ucuncu_indeks];

                #endregion

                kacKere++;

            }
                //kacKere değeri 50 olduğunda durmuştur ve else ifadesini kullanırsak kod else scopeları içersine düşer.
            else
            {

                timerHareket.Stop();
                //Resimlerin birbirine eşit olup olmadığını hareket durduktan ve timer stop edildikten sonra yapıyoruz.


                if (birinci_indeks == ikinci_indeks && ikinci_indeks == ucuncu_indeks)
                {

                    MessageBox.Show("Tebrikler:" + jeton_sayisi + " kadar jeton kazandınız!");
                    jeton_sayisi = 0;
                    labelJeton.Text = "Jeton:0";
                
                }

            
            }
 
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            timerHareket.Start();
            kacKere = 0;
            jeton_sayisi++;//Her seferinde kasaya bir tane jeton atılacağından jeton_sayisi değişkeninin değeri 1 arttırılır.

            labelJeton.Text = "Jeton Sayısı:" + jeton_sayisi;
        }
    }
}
