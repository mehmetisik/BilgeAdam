using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Entity;
using System.Data.SqlClient;
using Northwind.Tool;
using System.Data;
using System.Collections;

namespace Northwind.Facade
{
    public class Categories
    {

        public static void AddObject(Category entity)
        {

            SqlCommand cmd = new SqlCommand("insert Categories(CategoryName,Description) values(@CatName,@Desc)", ConnectionInfo.connection);

            cmd.Parameters.AddWithValue("@CatName", entity.CategoryName);

            cmd.Parameters.AddWithValue("@Desc", entity.Description);


            ConnectionInfo.ExecuteCommand(cmd);


        }

        public static bool DeleteObject(Category entity)
        {
            bool silindiMi = false;
            SqlCommand cmd = new SqlCommand("delete from Categories where CategoryId=@CategoryId", ConnectionInfo.connection);

            cmd.Parameters.AddWithValue("@CategoryId", entity.CategoryId);

           int sayi=ConnectionInfo.ExecuteCommand(cmd);

           if (sayi>0)
           {
               silindiMi = true;
           }

           return silindiMi;

        }

      

        //Geriye veritabanındaki Categories tablosuna ait kayıtları Category tipindeki nesneleri içinde barındıran bir ArrayList döndürür.
        public static ArrayList GetAllCategories()
        {
            //Geriye döndüreceğimiz liste
            ArrayList donecek_liste = new ArrayList();


            SqlCommand cmd = new SqlCommand("select * from Categories", ConnectionInfo.connection);

            try
            {

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Okunan her bir kaydı Category tipinde ifade ediyoruz.
                    Category cat = new Category();
                    cat.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    cat.CategoryName = reader["CategoryName"].ToString();
                    cat.Description = reader["Description"].ToString();

                    donecek_liste.Add(cat);//Her bir kayıt için oluşturulan Category tipindeki nesneyi geriye değer olarak döndüreceğimiz ArrayList içerisine ekliyoruz.


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


        public static void UpdateObject(Category entity)
        {

            SqlCommand cmd = new SqlCommand("update Categories set CategoryName=@CatName,Description=@Desc where CategoryId=@Id", ConnectionInfo.connection);


            cmd.Parameters.AddWithValue("@CatName", entity.CategoryName);
            cmd.Parameters.AddWithValue("@Desc", entity.Description);
            cmd.Parameters.AddWithValue("@Id", entity.CategoryId);

            ConnectionInfo.ExecuteCommand(cmd);
        
        
        }


    }
}
