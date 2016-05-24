using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADO_MYSQL_CONNECTION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "server=localhost;database=Northwind;user id=yigit;pwd=123" ;

            try
            {

                baglanti.Open();
                MessageBox.Show(baglanti.State.ToString());

            }
            catch
            {


            }
            finally
            {

                baglanti.Close();
            
            }
        }
    }
}
