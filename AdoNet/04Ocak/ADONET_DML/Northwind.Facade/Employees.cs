using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Northwind.Tool;

namespace Northwind.Facade
{
   public class Employees
    {
       public static DataTable employeesleriListele(int sayi)
       {

           SqlConnection conn = ConnectionInfo.connection;
           SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE EmployeeID<@sayi",conn);

           cmd.Parameters.AddWithValue("@sayi", sayi);

           conn.Open();

           SqlDataReader rdr = cmd.ExecuteReader();

           DataTable dt = new DataTable();

           dt.Load(rdr);

           conn.Close();

           return dt;
       }
    }
}
