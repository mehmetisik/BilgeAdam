using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using ADO_STORED_PROC_DEVAM.Tool;
using System.Data;
using ADO_STORED_PROC_DEVAM.Entity;
using System.Windows.Forms;

namespace ADO_STORED_PROC_DEVAM.Facade
{
   public class RaporIslem
    {

       public static ArrayList SatislariGetir(DateTime birinci, DateTime ikinci)
       {

           ArrayList donecek = new ArrayList();

           SqlCommand cmd = new SqlCommand("sp_TariheGoreSatis", Baglanti.conn);

           cmd.Parameters.AddWithValue("@IlkTarih", birinci);
           cmd.Parameters.AddWithValue("@IkinciTarih", ikinci);

           cmd.CommandType = CommandType.StoredProcedure;

           try
           {
               cmd.Connection.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {

                   Rapor okunan = new Rapor();
                   okunan.Calisan = dr["Calisan"].ToString();
                   okunan.ProductName = dr["productName"].ToString();
                   okunan.Toplam = Convert.ToDecimal(dr["Toplam"]);
                   okunan.OrderDate = Convert.ToDateTime(dr["OrderDate"]);
                   donecek.Add(okunan);


               }
           }
           catch (SqlException ex)
           {

               MessageBox.Show(ex.Message);
           }
           finally
           {
               cmd.Connection.Close();
           
           }

           return donecek;
       
       }


       public static DataTable SatisGetir(DateTime birinci, DateTime ikinci)
       {


           DataTable dt = new DataTable();

           SqlCommand cmd = new SqlCommand("sp_TariheGoreSatis", Baglanti.conn);

           cmd.Parameters.AddWithValue("@IlkTarih", birinci);
           cmd.Parameters.AddWithValue("@IkinciTarih", ikinci);

           cmd.CommandType = CommandType.StoredProcedure;


           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(dt);

           return dt;
       
       
       }


    }
}
