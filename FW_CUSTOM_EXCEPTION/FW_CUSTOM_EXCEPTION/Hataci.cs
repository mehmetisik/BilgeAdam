using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FW_CUSTOM_EXCEPTION
{
    class Hataci : Exception
    {

        private string _hata;

        public string Hata
        {

            get { return _hata; }
            set { _hata = value; }

        }

        public override string Message
        {
            get
            {
                return this.Hata;
            }
        }

        public Hataci()
        {

        }

        public Hataci(string error)
        {
            this.Hata = error;

        }

        public void IslemYap()
        {

            SqlConnection conn = new SqlConnection("server=.;database=master;uid=sa;pwd=123");

            SqlCommand cmd = new SqlCommand("select * from Products", conn);

            
                try
                {
                    conn.Open();
                }
                catch
                {

                    throw new Hataci("Bağantıda bilgisinde sorun olabilir");
                }

                try
                {
                    int sayi = Convert.ToInt32("HEDE");
                }
                catch 
                {

                    throw new Hataci("Çevirmede hata var");
                }
               
            

            






        }
    }
}
