using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Data.SqlClient;
using System.Data;

namespace Viciyef
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }


        public string HelloDeBana()
        {
            return "Hello Diyeyim Sana";
        }


        public string[] UrunAdlariGetir()
        {
            int indeks = 0;
            NorthwindDataContext db = new NorthwindDataContext();
            int length = db.Products.ToList().Count;
            string[] urunler = new string[length];
            foreach (var item in db.Products.ToList())
            {
                urunler[indeks] = item.ProductName;
                indeks++;
            }

            return urunler;
        
        }




        public void XmleYaz()
        {
            SqlConnection conn = new SqlConnection("server=.;database=Northwind;uid=sa;pwd=123");

            SqlCommand cmd = new SqlCommand("select ProductName from Products", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            ds.WriteXml("C:/hettere.xml");
        }
    }
}
