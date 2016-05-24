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

            get { return new SqlConnection("server=.;database=Northwind;Integrated Security=True"); }


        }


        public static int ExecuteCommand(SqlCommand command)
        {
            int donecek = 0;
            try
            {

                command.Connection.Open();
                donecek = command.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {

                MessageBox.Show("Hata Var:" + ex.Message);

            }
            finally
            {

                command.Connection.Close();

            }

            return donecek;


        }

    }
}
