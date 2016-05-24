using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace FW_SYSTEM_AYO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            DriveInfo[] suruculer = DriveInfo.GetDrives();

            foreach (DriveInfo di in suruculer)
            {
                if(di.IsReady)
                comboBoxSuruculer.Items.Add(di.Name);

            }

           


        }

        private void treeViewKlasorler_AfterSelect(object sender, TreeViewEventArgs e)
        {


            //Seçtiğimiz klasör
            DirectoryInfo di = new DirectoryInfo(e.Node.Tag.ToString());

            //Alt dizinlerin alınması
            DirectoryInfo[] klasorler = di.GetDirectories();

            listViewDosyalar.Items.Clear();
            //Alt dizinlerin node'a eklenmesi
            foreach (DirectoryInfo dizin in klasorler)
            {
                TreeNode tn = e.Node.Nodes.Add(dizin.FullName);
                tn.Tag = dizin.FullName;


                foreach (FileInfo fi in dizin.GetFiles())
                {

                    ListViewItem lvi = new ListViewItem(fi.Name);
                    lvi.Tag = fi.FullName;
                    lvi.SubItems.Add(fi.Length.ToString());
                    lvi.SubItems.Add(fi.Extension);
                    lvi.SubItems.Add(fi.CreationTime.ToShortDateString());

                    listViewDosyalar.Items.Add(lvi);

                    if (!ımageList1.Images.ContainsKey(fi.Extension))
                    {
                        Icon ikon = Icon.ExtractAssociatedIcon(fi.FullName);
                        ımageList1.Images.Add(fi.Extension, ikon);
                    
                    
                    }
                    lvi.ImageKey = fi.Extension;
                
                
                }



            }


        }

        private void comboBoxSuruculer_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewKlasorler.Nodes.Clear();
            DirectoryInfo di = new DirectoryInfo(comboBoxSuruculer.SelectedItem.ToString());

            foreach (DirectoryInfo dizin in di.GetDirectories())
            {
                TreeNode tn = treeViewKlasorler.Nodes.Add(dizin.Name);
                tn.Tag = dizin.FullName;
            }

        }

        private void listViewDosyalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(listViewDosyalar.SelectedItems[0].Tag.ToString());
        }
    }







}

