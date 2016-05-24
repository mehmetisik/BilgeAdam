using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Kutuphane.Tool;
using Kutuphane.Entity;

namespace Kutuphane.Facade
{
    public class YayinEviIslem
    {

        public static DataTable YayinEviGetir()
        {

            DataTable donecek = new DataTable();

            SqlCommand cmd = new SqlCommand("select * from YayinEvleri", Baglanti.conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(donecek);

            return donecek;
        
        
        }


        public static void YayinEviEkle(YayinEvi eklenecek)
        {

            SqlCommand cmd = new SqlCommand("insert Yayinevleri values(@Ev)", Baglanti.conn);

            cmd.Parameters.AddWithValue("@Ev", eklenecek.YayınEvi);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        
        }

        public static void YayinEviSil(int SilinecekId)
        {

            SqlCommand cmd = new SqlCommand("delete from Yayinevleri where ID=@Id", Baglanti.conn);

            cmd.Parameters.AddWithValue("@Id", SilinecekId);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        
        
        }

        


    }
}
