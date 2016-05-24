namespace DongulerDevam
{
    partial class Form4
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
            this.listBoxSayilar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSayi = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonAritmetik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSayilar
            // 
            this.listBoxSayilar.FormattingEnabled = true;
            this.listBoxSayilar.Location = new System.Drawing.Point(12, 12);
            this.listBoxSayilar.Name = "listBoxSayilar";
            this.listBoxSayilar.Size = new System.Drawing.Size(129, 173);
            this.listBoxSayilar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı:";
            // 
            // textBoxSayi
            // 
            this.textBoxSayi.Location = new System.Drawing.Point(45, 197);
            this.textBoxSayi.Name = "textBoxSayi";
            this.textBoxSayi.Size = new System.Drawing.Size(96, 20);
            this.textBoxSayi.TabIndex = 2;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(66, 223);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 3;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonAritmetik
            // 
            this.buttonAritmetik.Location = new System.Drawing.Point(147, 12);
            this.buttonAritmetik.Name = "buttonAritmetik";
            this.buttonAritmetik.Size = new System.Drawing.Size(123, 28);
            this.buttonAritmetik.TabIndex = 4;
            this.buttonAritmetik.Text = "Aritmetik Ortalama";
            this.buttonAritmetik.UseVisualStyleBackColor = true;
            this.buttonAritmetik.Click += new System.EventHandler(this.buttonAritmetik_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 256);
            this.Controls.Add(this.buttonAritmetik);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSayilar);
            this.Name = "Form4";
            this.Text = "Aritmetik Ortalama Hesaplayıcı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSayi;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonAritmetik;
    }
}