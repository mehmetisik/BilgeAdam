using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;


namespace IntroTekrar
{

    public enum YaziTipi
    { 
    
        Alfabetik,
        Sayısal
    
    }


    class MyTextBox:TextBox
    {


        public MyTextBox()
        {
            InitializeComponent();
        }

        private ErrorProvider errorProvider1;
        private IContainer components;

        //Field(Property'nin get ve set olaylarını gerçekleştirne değişken)
        private string _Yazi;

        [Description("Bu property'yi neden tanımladığımızı bilmiyoruz!")]
        public string Yazi
        {

            get { return _Yazi; }
            set { _Yazi = value; }
        
        }

        public YaziTipi tip { get; set; }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (this.tip == YaziTipi.Sayısal)
            {

                if (!char.IsNumber(e.KeyChar))
                {

                    e.Handled = true;
                    errorProvider1.SetError(this, "Nümerik karakter giriniz!");

                }
                else
                {
                    errorProvider1.Dispose();

                }
            }
            else
            {

                if (!char.IsLetter(e.KeyChar))
                {

                    e.Handled = true;
                    errorProvider1.SetError(this, "Alfabetik Karakter giriniz!");

                }
                else
                {
                    errorProvider1.Dispose();

                }
            
            
            }
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }








    }
}
