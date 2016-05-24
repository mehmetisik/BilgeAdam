using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ADO_ACCESS_BAGLANTI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:/Deneme.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
           


            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {

                    MessageBox.Show("Bağlantı Kuruldu.");

                }
            }
            catch (OleDbException oex)
            {

                MessageBox.Show(oex.Message);
            }

            finally
            {
                baglanti.Close();
            
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {


            listBoxPersoneller.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("select Ad,Soyad from Personeller", baglanti);

            cmd.Connection.Open();
            OleDbDataReader okuyucu=cmd.ExecuteReader();

            while (okuyucu.Read())
            { 
            
                listBoxPersoneller.Items.Add(okuyucu["Ad"].ToString()+" "+okuyucu["Soyad"].ToString());
            
            }

            cmd.Connection.Close();


        }
    }
}
