namespace KararYapilari
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPizzalar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mstTelefon = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonNakit = new System.Windows.Forms.RadioButton();
            this.radioButtonKart = new System.Windows.Forms.RadioButton();
            this.buttonSiparis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelFiyat = new System.Windows.Forms.Panel();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.panelFiyat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSiparis);
            this.groupBox1.Controls.Add(this.radioButtonKart);
            this.groupBox1.Controls.Add(this.radioButtonNakit);
            this.groupBox1.Controls.Add(this.mstTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIndirim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numAdet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbPizzalar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Seçiniz:";
            // 
            // cmbPizzalar
            // 
            this.cmbPizzalar.FormattingEnabled = true;
            this.cmbPizzalar.Items.AddRange(new object[] {
            "Karışık Pizza",
            "Kaşarlı Pizza",
            "Sade Pizza",
            "Mantarlı Pizza",
            "Sucuklu Pizza",
            "Rokalı Pizza"});
            this.cmbPizzalar.Location = new System.Drawing.Point(101, 31);
            this.cmbPizzalar.Name = "cmbPizzalar";
            this.cmbPizzalar.Size = new System.Drawing.Size(167, 21);
            this.cmbPizzalar.TabIndex = 1;
            this.cmbPizzalar.SelectedIndexChanged += new System.EventHandler(this.cmbPizzalar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet:";
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(101, 71);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(63, 20);
            this.numAdet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İndirim Oranı:";
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(100, 108);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(123, 20);
            this.txtIndirim.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon No:";
            // 
            // mstTelefon
            // 
            this.mstTelefon.Location = new System.Drawing.Point(100, 149);
            this.mstTelefon.Mask = "(999) 000-0000";
            this.mstTelefon.Name = "mstTelefon";
            this.mstTelefon.Size = new System.Drawing.Size(123, 20);
            this.mstTelefon.TabIndex = 7;
            // 
            // radioButtonNakit
            // 
            this.radioButtonNakit.AutoSize = true;
            this.radioButtonNakit.Location = new System.Drawing.Point(94, 189);
            this.radioButtonNakit.Name = "radioButtonNakit";
            this.radioButtonNakit.Size = new System.Drawing.Size(50, 17);
            this.radioButtonNakit.TabIndex = 8;
            this.radioButtonNakit.TabStop = true;
            this.radioButtonNakit.Text = "Nakit";
            this.radioButtonNakit.UseVisualStyleBackColor = true;
            // 
            // radioButtonKart
            // 
            this.radioButtonKart.AutoSize = true;
            this.radioButtonKart.Location = new System.Drawing.Point(164, 189);
            this.radioButtonKart.Name = "radioButtonKart";
            this.radioButtonKart.Size = new System.Drawing.Size(73, 17);
            this.radioButtonKart.TabIndex = 9;
            this.radioButtonKart.TabStop = true;
            this.radioButtonKart.Text = "Kredi Kartı";
            this.radioButtonKart.UseVisualStyleBackColor = true;
            // 
            // buttonSiparis
            // 
            this.buttonSiparis.Location = new System.Drawing.Point(84, 229);
            this.buttonSiparis.Name = "buttonSiparis";
            this.buttonSiparis.Size = new System.Drawing.Size(161, 23);
            this.buttonSiparis.TabIndex = 10;
            this.buttonSiparis.Text = "Sipariş Ver";
            this.buttonSiparis.UseVisualStyleBackColor = true;
            this.buttonSiparis.Click += new System.EventHandler(this.buttonSiparis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "%";
            // 
            // panelFiyat
            // 
            this.panelFiyat.Controls.Add(this.labelFiyat);
            this.panelFiyat.Controls.Add(this.buttonKapat);
            this.panelFiyat.Location = new System.Drawing.Point(414, 81);
            this.panelFiyat.Name = "panelFiyat";
            this.panelFiyat.Size = new System.Drawing.Size(219, 131);
            this.panelFiyat.TabIndex = 1;
            this.panelFiyat.Visible = false;
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(193, 0);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(26, 23);
            this.buttonKapat.TabIndex = 0;
            this.buttonKapat.Text = "X";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Location = new System.Drawing.Point(28, 51);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(35, 13);
            this.labelFiyat.TabIndex = 1;
            this.labelFiyat.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 365);
            this.Controls.Add(this.panelFiyat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.panelFiyat.ResumeLayout(false);
            this.panelFiyat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSiparis;
        private System.Windows.Forms.RadioButton radioButtonKart;
        private System.Windows.Forms.RadioButton radioButtonNakit;
        private System.Windows.Forms.MaskedTextBox mstTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIndirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPizzalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelFiyat;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Button buttonKapat;
    }
}

