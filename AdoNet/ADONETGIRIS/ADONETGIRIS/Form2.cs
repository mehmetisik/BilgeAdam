using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONETGIRIS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonBaglan_Click(object sender, EventArgs e)
        {
            //Windows Authentication ile farklı şekilde bağlanma bilgisi...
            //SqlConnection baglanti = new SqlConnection("data source=.;Initial Catalog=Northwind;Trusted_Connection=True");


            SqlConnection baglanti = new SqlConnection();

            //Sql Server Authentication ile bağlanacaksak,Sql Server'da tanımlı kullanıcının kullanıcı adı ve şifre bilgisini girmemiz gerekir.

            //uid=kullanıcı adını temsil eder(User Id)
            //pwd=Kullanıcı şifresini temsil eder(Password)
            baglanti.ConnectionString = "server=.;database=Northwind;uid=sa;pwd=1";

            baglanti.Open();

            if (baglanti.State == ConnectionState.Open)
            {

                MessageBox.Show("Bağlantı Kuruldu!");

            }
            baglanti.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=Northwind;Integrated Security=True");

            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "insert Categories(CategorYNAME) values('Veyyu')";

            conn.Open();//Bağlantıyı aç....
            int etkilenen_kayit_sayisi = komut.ExecuteNonQuery();//ExecuteNonQuery komutu çalıştırır ve geriye etkilenen kayıt sayısını döndürür.
            if (etkilenen_kayit_sayisi > 0)
            {

                MessageBox.Show("Kayıt Eklendi");

            }

            conn.Close();//İşlemler yapıldıktan sonra bağlantı kapatılır.


        }
    }
}
