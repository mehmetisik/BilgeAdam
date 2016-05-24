using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBResimCekme.Entity;
using System.Data.SqlClient;
using DBResimCekme.Tool;
using System.Collections;

namespace DBResimCekme.Facade
{
    public class Adaylar
    {
        public static int AdayEkle(Aday entity)
        {
            int donecek = 0;
            SqlCommand cmd = new SqlCommand("insert Adaylar(Ad,MezuniyetId,Resim) values(@Ad,@MezId,@Resim)", Baglanti.con);


            cmd.Parameters.AddWithValue("@Ad", entity.Ad);
            cmd.Parameters.AddWithValue("@MezId", entity.MezuniyetId);
            cmd.Parameters.AddWithValue("@Resim", entity.Resim);


            cmd.Connection.Open();
            donecek = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return donecek;





        }


        public static ArrayList AdaylariGetir()
        {

            ArrayList adaylistesi = new ArrayList();

            SqlCommand cmd = new SqlCommand("select * from Adaylar", Baglanti.con);

            try
            {
                cmd.Connection.Open();
                SqlDataReader okuyucu = cmd.ExecuteReader();
                while (okuyucu.Read())
                {

                    Aday okunan = new Aday();
                    okunan.Ad = okuyucu["Ad"].ToString();
                    okunan.MezuniyetId = Convert.ToInt32(okuyucu["MezuniyetId"]);
                    okunan.Resim = (byte[])okuyucu["Resim"];

                    adaylistesi.Add(okunan);

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
            return adaylistesi;
        
        
        
        
        }


    }
}
