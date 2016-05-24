using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace FW_WEB_SERVICES
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string[] GetCategoryNames()
        {

            SqlConnection conn = new SqlConnection("server=.;database=Northwind;uid=sa;pwd=123");

            SqlCommand cmd = new SqlCommand("select Count(*) from Categories", conn);

            conn.Open();
            int length=(int)cmd.ExecuteScalar();

            string[] categories = new string[length];

            SqlCommand cmd2 = new SqlCommand("select CategoryName from Categories", conn);

            int indeks = 0;

            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            { 
            
                categories[indeks]=dr[0].ToString();
                indeks++;
            
            
            }
            conn.Close();

            return categories;


                
        
        
        
        }


    }
}