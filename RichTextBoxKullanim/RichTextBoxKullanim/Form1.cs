using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RichTextBoxKullanim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Font myfont = new Font("Arial", 8);
        private void Form1_Load(object sender, EventArgs e)
        {

            comboBoxFontFamilies.DisplayMember = "Name";
            
            comboBoxFontFamilies.DataSource = FontFamily.Families;//Bütün font ailesi bir liste olduğundan,bunu comboBox'a veri kaynağı olarak veriyoruz.
        }

        private void buttonRenk_Click(object sender, EventArgs e)
        {
            //if (colorDialogSecici.ShowDialog() == DialogResult.OK)
            //{
            //    //Değiştikten sonra yazı rengi de,seçtiğimiz renge göre değişecektir.
            //    richTextBoxYazi.SelectionColor = colorDialogSecici.Color;
                
            
            //}

            fontDialogFontcu.ShowDialog();
        }

        void Degistir(float size, string family)
        {

            try
            {
                myfont = new Font(family, size);
                richTextBoxYazi.SelectionFont = myfont;
            }
            catch 
            {
              
            }
           
        
        
        }

        private void comboBoxFontFamilies_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Degistir(float.Parse(comboBoxSize.Text), comboBoxFontFamilies.Text);

            }
            catch { }
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Degistir(float.Parse(comboBoxSize.Text), comboBoxFontFamilies.Text);

            }
            catch { }
           
        }
    }
}
