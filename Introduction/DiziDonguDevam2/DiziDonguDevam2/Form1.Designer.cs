namespace DiziDonguDevam2
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
            this.listBoxDogumYillari = new System.Windows.Forms.ListBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonTarih = new System.Windows.Forms.Button();
            this.listBoxHarfler = new System.Windows.Forms.ListBox();
            this.buttonHarfEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDogumYillari
            // 
            this.listBoxDogumYillari.FormattingEnabled = true;
            this.listBoxDogumYillari.Location = new System.Drawing.Point(12, 22);
            this.listBoxDogumYillari.Name = "listBoxDogumYillari";
            this.listBoxDogumYillari.Size = new System.Drawing.Size(144, 225);
            this.listBoxDogumYillari.TabIndex = 0;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(66, 262);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(90, 23);
            this.buttonEkle.TabIndex = 1;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonTarih
            // 
            this.buttonTarih.Location = new System.Drawing.Point(179, 22);
            this.buttonTarih.Name = "buttonTarih";
            this.buttonTarih.Size = new System.Drawing.Size(109, 23);
            this.buttonTarih.TabIndex = 2;
            this.buttonTarih.Text = "Tarih Göster";
            this.buttonTarih.UseVisualStyleBackColor = true;
            this.buttonTarih.Click += new System.EventHandler(this.buttonTarih_Click);
            // 
            // listBoxHarfler
            // 
            this.listBoxHarfler.FormattingEnabled = true;
            this.listBoxHarfler.Location = new System.Drawing.Point(360, 22);
            this.listBoxHarfler.Name = "listBoxHarfler";
            this.listBoxHarfler.Size = new System.Drawing.Size(148, 225);
            this.listBoxHarfler.TabIndex = 3;
            // 
            // buttonHarfEkle
            // 
            this.buttonHarfEkle.Location = new System.Drawing.Point(413, 262);
            this.buttonHarfEkle.Name = "buttonHarfEkle";
            this.buttonHarfEkle.Size = new System.Drawing.Size(95, 23);
            this.buttonHarfEkle.TabIndex = 4;
            this.buttonHarfEkle.Text = "Harf Ekle";
            this.buttonHarfEkle.UseVisualStyleBackColor = true;
            this.buttonHarfEkle.Click += new System.EventHandler(this.buttonHarfEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 334);
            this.Controls.Add(this.buttonHarfEkle);
            this.Controls.Add(this.listBoxHarfler);
            this.Controls.Add(this.buttonTarih);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.listBoxDogumYillari);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDogumYillari;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonTarih;
        private System.Windows.Forms.ListBox listBoxHarfler;
        private System.Windows.Forms.Button buttonHarfEkle;
    }
}

