using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kutuphane.Entity;
using System.Data.SqlClient;
using Kutuphane.Tool;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Kutuphane.Facade
{
    public class KitapIslem
    {

        public static int KitapEkle(Kitap eklenecek)
        {
            int donecek = 0;

            SqlCommand cmd = new SqlCommand("insert Kitaplar values(@Ad,@ISBN,@BasimYil,@Sayfa,@Resim,@YayinID)", Baglanti.conn);

            cmd.Parameters.AddWithValue("@Ad", eklenecek.KitapAD);

            cmd.Parameters.AddWithValue("@ISBN", eklenecek.ISBNNO);

            cmd.Parameters.AddWithValue("@BasimYil", eklenecek.BasimTarihi);

            cmd.Parameters.AddWithValue("@Sayfa", eklenecek.SayfaSayisi);

            cmd.Parameters.AddWithValue("@Resim", eklenecek.KapakResmi);

            cmd.Parameters.AddWithValue("@YayinID", eklenecek.YayinEviID);

            cmd.Connection.Open();
            donecek = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return donecek;




        }


        public static ArrayList KitapAra(string harf)
        {


            ArrayList donecek = new ArrayList();

            //Prosedür çalıştırılacağı zaman Command Text kısmına prosedür adı yazılır.
            SqlCommand cmd = new SqlCommand("KitapGetir", Baglanti.conn);

            cmd.Parameters.AddWithValue("@Ad", harf);

            //Çalıştıracağımız komutun bir sp olduğunu da derleyiciye bildiriyoruz.
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Connection.Open();
               SqlDataReader dr=cmd.ExecuteReader();

               while (dr.Read())
               {

                   Kitap okunan = new Kitap();
                   okunan.KitapID = Convert.ToInt32(dr["KitapID"]);
                   okunan.KitapAD = dr["Ad"].ToString();
                   okunan.SayfaSayisi = Convert.ToInt16(dr["SayfaSayisi"]);
                   okunan.BasimTarihi = Convert.ToInt32(dr["BasımTarihi"]);
                   okunan.YayinEviID = Convert.ToInt32(dr["YayinEvId"]);
                   okunan.ISBNNO = dr["ISBNNO"].ToString();
                   okunan.KapakResmi = (byte[])dr["KapakResmi"];
                   donecek.Add(okunan);
               
               }

            }
            catch(SqlException ex)
            {


                MessageBox.Show(ex.Message);

            }
            finally
            {

                cmd.Connection.Close();
            
            }

            return donecek;

        
        
        }

    }
}
