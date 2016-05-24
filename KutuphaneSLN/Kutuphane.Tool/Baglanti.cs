using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Kutuphane.Tool
{
    public class Baglanti
    {
        public static SqlConnection conn = new SqlConnection("server=.;database=KutuphaneDB;Integrated Security=True");

    }
}
