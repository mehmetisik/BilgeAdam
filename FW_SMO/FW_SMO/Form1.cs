using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
using FW_SMO.Tool;
using System.IO;

namespace FW_SMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Server s;
        private void Form1_Load(object sender, EventArgs e)
        {

            ServerConnection baglanti = new ServerConnection(ConnectionInfo.conn);
            s = new Server(baglanti);

            foreach (Database db in s.Databases)
            {
                if (!db.IsSystemObject)
                    listBoxDatabases.Items.Add(db.Name);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {

                string path = fd.SelectedPath;

                try
                {
                    //ConnectionInfo.conn.Open();
                    foreach (string dbName in listBoxDatabases.Items)
                    {

                        SqlCommand cmd = new SqlCommand("backup database " + dbName + " to disk=@path", ConnectionInfo.conn);


                        cmd.Parameters.AddWithValue("@path", path + "/" + dbName + ".bak");
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
                finally
                {

                    ConnectionInfo.conn.Close();

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fd = new FolderBrowserDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {


                string secilen_veritabani = listBoxDatabases.SelectedItem.ToString();

                foreach (Table item in s.Databases[secilen_veritabani].Tables)
                {

                    EntityOlustur(item.Name, secilen_veritabani, fd.SelectedPath);

                }

                
            }
        }


        string Donustur(DataType tip)
        {

            string donecek = "";

            switch (tip.Name)
            {
                case "nvarchar":
                    donecek = "string";
                    break;
                case "int":
                    donecek = "int";
                    break;
                case "money":
                    donecek = "decimal";
                    break;
                case "datetime":
                    donecek = "DateTime";
                    break;
                case "image":
                    donecek = "byte []";
                    break;
                default:
                    donecek = "string";
                    break;



            }



            return donecek;

        }

        void EntityOlustur(string tabloadi,string veritabani,string path)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("using System;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");

            sb.AppendLine("namespace Hede");
            sb.AppendLine("{");

            sb.AppendLine("public class "+tabloadi);

            sb.AppendLine("{");

            foreach (Column clm in s.Databases[veritabani].Tables[tabloadi].Columns)
            {

                sb.AppendLine("public " + Donustur(clm.DataType) + " " + clm.Name + "{get;set;}");



            }
            sb.AppendLine("}");
            sb.AppendLine("}");

            StreamWriter sw = new StreamWriter(path + "/" + tabloadi+".cs");

            sw.Write(sb.ToString());
            sw.Close();

        
        
        
        }
    }
}
