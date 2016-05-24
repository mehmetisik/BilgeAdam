using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FW_GENERICS
{
    class Islemci
    {

        public void Ekle<Tip>(Tip tip)
        {
            Type t = tip.GetType();
            SqlConnection conn = new SqlConnection("server=.;database=Northwind;uid=sa;pwd=123");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            StringBuilder sb = new StringBuilder();
            sb.Append("insert " + t.Name + " (");

            foreach (PropertyInfo pi in t.GetProperties())
            {
                if (pi.GetCustomAttributes(typeof(Identity), false).Length == 0)
                {
                    sb.Append(pi.Name + ",");
                }
            
            }
            sb=sb.Remove(sb.Length - 1,1);
            sb.Append(") values (");

            foreach (PropertyInfo pi in t.GetProperties())
            {
                //Eğer gezilen Property'nin başında Identity attribute tanımlanmışsa,bu property hesaba katılmaz.
                if (pi.GetCustomAttributes(typeof(Identity), false).Length == 0)
                {
                    sb.Append("@" + pi.Name + ",");
                    
                }
            
            }
            sb = sb.Remove(sb.Length - 1, 1);
            sb.Append(")");
            cmd.CommandText = sb.ToString();

            foreach (PropertyInfo pi in t.GetProperties())
            {
                if (pi.GetCustomAttributes(typeof(Identity), false).Length == 0)
                {
                    cmd.Parameters.AddWithValue("@" + pi.Name, pi.GetValue(tip, null));
                }
            
            }

            MessageBox.Show(sb.ToString());
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        
        
        }



    }
}
