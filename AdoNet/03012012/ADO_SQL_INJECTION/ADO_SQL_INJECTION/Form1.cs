using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_SQL_INJECTION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxCompanies.Items.Clear();//Her seferinde alt alta eleman eklememsi için listBox'ı temizliyoruz.

            SqlConnection conn = new SqlConnection("server=.;database=Northwind;uid=sa;pwd=1");

            //Eğer sorgu parametresiz aşağıdaki gibi tek tırnak içerisinde gönderilirse Injection yeme ihtimali doğar.Bu yüzden sorguların hepsi parametre ile gönderilmelidir.
            //SqlCommand cmd = new SqlCommand("select CompanyName from Customers where City='" + textBoxCity.Text + "'", conn);

            SqlCommand cmd = new SqlCommand("select CompanyName from Customers where City=@City", conn);

            //Eğer sorgu parametre ile çalışacaksa aşağıdaki gibi parametrenin değerini belirleriz.
            cmd.Parameters.AddWithValue("@City", textBoxCity.Text);


            conn.Open();//Bağlantıyı aç...
            SqlDataReader okuyucu = cmd.ExecuteReader();//Birden fazla satır okuma işlemi için sorgu ExecuteReader ile çalıştırılmalıdır.Geriye okuma işlemini gerçekleştirebleceğimiz SqlDataReader tipinde değer döndürür.

            //Kayıt okuma işlemi Read metodu ile gerçekleştirilir.Kayıt okuma işlemi devam ettiği müddetçe geriye true değeri döndürür.DataReader satır satır okuma işlemi yapar ve ileri yönlü okuma yapar.Okuduğu her kaydı da hafızadan sildiğinden oldukça performanslı bir şekilde çalışır.
            while (okuyucu.Read())
            {
                //okuyucu["SütunAdı"] ya da okuyucu[sütunindeksi] şeklinde sorguda kullanıla sütun bilgilerine göre değerler alınırz.
              listBoxCompanies.Items.Add(okuyucu["CompanyName"].ToString());
            
            
            }

            conn.Close();







        }
    }
}
