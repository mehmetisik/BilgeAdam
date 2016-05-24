using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using DBResimCekme.Tool;
using DBResimCekme.Entity;

namespace DBResimCekme.Facade
{
    public class Mezuniyetler
    {
        public static ArrayList MezuniyetleriGetir()
        {

            ArrayList donecek = new ArrayList();

            SqlCommand cmd = new SqlCommand("select * from Mezuniyetler", Baglanti.con);


            try
            {
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Mezuniyet okunan = new Mezuniyet();
                    okunan.MezuniyetId = Convert.ToInt32(dr[0]);
                    okunan.MezuniyetDurumu = dr[1].ToString();

                    donecek.Add(okunan);

                }


            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            
            }

            return donecek;


        }


    }
}
