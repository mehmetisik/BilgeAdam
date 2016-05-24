using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using Northwind.Tool;
using System.Data;
using ADONET_STORED_PROC.Entity;

namespace ADONET_STORED_PROC.DAL
{
    public class Products
    {

        public static ArrayList GetProducts(int CategoryId)
        {
            //Geriye değer olarak döndüreceğimiz liste...
            ArrayList donecek_liste = new ArrayList();

            //Procedure çalıştırılacağı zaman prosedürün adı commandtext bölümüne string olarka yazılır.
            SqlCommand cmd = new SqlCommand("sp_KategoriyeGoreUrun",
 ConnectionInfo.connection);

            //Eğer prosedür parametre alacaksa,birebir tanımlandığı prosedür içindeki adı yazılır.
            cmd.Parameters.AddWithValue("@CatId", CategoryId);

            //Stored Procedure çalıştırılacaksa mutlaka CommandType belirtilmeli...
            cmd.CommandType = CommandType.StoredProcedure;

            try

            {

                cmd.Connection.Open();
                SqlDataReader okuyucu = cmd.ExecuteReader();

                while (okuyucu.Read())
                {

                    //Her bir kayıt için bir tane Product tipinde nesne oluşturuyoruz.
                    Product urun = new Product();
                    urun.ProductId = Convert.ToInt32(okuyucu["ProductId"]);
                    urun.ProductName = okuyucu["ProductName"].ToString();
                    urun.UnitPrice = Convert.ToDecimal(okuyucu["UnitPrice"]);
                    urun.UnitsInStock = Convert.ToInt16(okuyucu["UnitsInStock"]);

                    urun.CategoryId = Convert.ToInt32(okuyucu["CategoryId"]);
                    urun.QuantityPerUnit = okuyucu["QuantityPerUnit"].ToString();
                    urun.Discontinued = Convert.ToBoolean(okuyucu["Discontinued"]);
                    urun.UnitsOnOrder = Convert.ToInt32(okuyucu["UnitsOnOrder"]);

                    donecek_liste.Add(urun);


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

            return donecek_liste;




        }

    }
}
