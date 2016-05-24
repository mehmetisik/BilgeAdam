using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Northwind.Tool
{
    public class ConnectionInfo
    {

        public static SqlConnection connection
        {

            get {return new SqlConnection("server=.;database=Northwind;Integrated Security=True");}
        
        
        }


        public static void ExecuteCommand(SqlCommand command)
        {

            try
            {

                command.Connection.Open();
                command.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {

                MessageBox.Show("Hata Var:" + ex.Message);

            }
            finally
            {

                command.Connection.Close();
            
            }
        
        
        }

    }
}
