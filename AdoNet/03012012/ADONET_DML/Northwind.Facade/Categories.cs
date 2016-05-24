using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Entity;
using System.Data.SqlClient;
using Northwind.Tool;
using System.Data;

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

        public static void DeleteObject(Category entity)
        {

            SqlCommand cmd = new SqlCommand("delete from Categories where CategoryId=@CategoryId", ConnectionInfo.connection);

            cmd.Parameters.AddWithValue("@CategoryId", entity.CategoryId);

            ConnectionInfo.ExecuteCommand(cmd);
            

        
        }


    }
}
