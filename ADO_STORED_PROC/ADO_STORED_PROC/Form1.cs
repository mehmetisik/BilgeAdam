using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_STORED_PROC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (dateTimePickerTarih2.Value <= dateTimePickerTarih1.Value)
            {

                MessageBox.Show("İkinci Tarih İlk tarihten büyük olmalıdır");
                return;

            }

            listViewDetay.Items.Clear();
            SqlConnection baglanti = new SqlConnection("server=.;database=Northwind;Integrated Security=True");


            //Eğer procedure çalıştırılacaksa procedure adı CommandText bölümüne string olarak yazılır.
            SqlCommand cmd = new SqlCommand("sp_TariheGoreSatis", baglanti);

            //Eğer parametre alıyorsa,prosedür oluşturulurken kullanılan parametre isimleri aynen burada da kullanılır.

            cmd.Parameters.AddWithValue("@IlkTarih", dateTimePickerTarih1.Value);
            cmd.Parameters.AddWithValue("@IkinciTarih", dateTimePickerTarih2.Value);

            //Prosedür çalıştırılmadan önce,derleyiciye bir procedure çalıştırılacağı da söylenmelidir.

            //Göndereceğimiz kmutun bir stored procedure olduğunu CommandType ile belirtiyoruz.
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {

                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    //ListView'e eleman eklemek için ListViewItem kullanılır.

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dr["Calisan"].ToString();
                    lvi.SubItems.Add(dr["ProductName"].ToString());
                    string toplam = dr["Toplam"].ToString();
                    string [] dizi=toplam.Split(',');
                    if (dizi.Length == 2)
                    {
                        if (dizi[1].Length == 2)
                        {
                            toplam = "";
                            toplam = dizi[0] +","+ dizi[1].Substring(0, 2);

                        }
                        else
                        {

                            toplam = "";
                            toplam = dizi[0] +","+ dizi[1].Substring(0, 1);
                        }
                     
                    
                    }
                    lvi.SubItems.Add(toplam);
                    DateTime tarih = Convert.ToDateTime(dr["OrderDate"]);
                    lvi.SubItems.Add(tarih.ToShortDateString());
                    listViewDetay.Items.Add(lvi);
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


        }
    }
}
