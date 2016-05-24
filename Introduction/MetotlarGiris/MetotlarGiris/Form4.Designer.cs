namespace MetotlarGiris
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
            this.buttonBuyuk = new System.Windows.Forms.Button();
            this.buttonKucuk = new System.Windows.Forms.Button();
            this.buttonAyir = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.labelKelime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuyuk
            // 
            this.buttonBuyuk.Location = new System.Drawing.Point(26, 25);
            this.buttonBuyuk.Name = "buttonBuyuk";
            this.buttonBuyuk.Size = new System.Drawing.Size(98, 23);
            this.buttonBuyuk.TabIndex = 0;
            this.buttonBuyuk.Text = "Hepsi Büyük";
            this.buttonBuyuk.UseVisualStyleBackColor = true;
            this.buttonBuyuk.Click += new System.EventHandler(this.buttonBuyuk_Click);
            // 
            // buttonKucuk
            // 
            this.buttonKucuk.Location = new System.Drawing.Point(26, 67);
            this.buttonKucuk.Name = "buttonKucuk";
            this.buttonKucuk.Size = new System.Drawing.Size(98, 23);
            this.buttonKucuk.TabIndex = 1;
            this.buttonKucuk.Text = "Hepsi Küçük";
            this.buttonKucuk.UseVisualStyleBackColor = true;
            this.buttonKucuk.Click += new System.EventHandler(this.buttonKucuk_Click);
            // 
            // buttonAyir
            // 
            this.buttonAyir.Location = new System.Drawing.Point(26, 110);
            this.buttonAyir.Name = "buttonAyir";
            this.buttonAyir.Size = new System.Drawing.Size(98, 23);
            this.buttonAyir.TabIndex = 2;
            this.buttonAyir.Text = "Karakter Ayır";
            this.buttonAyir.UseVisualStyleBackColor = true;
            this.buttonAyir.Click += new System.EventHandler(this.buttonAyir_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(26, 155);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(98, 23);
            this.buttonSil.TabIndex = 3;
            this.buttonSil.Text = "Karakter Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // labelKelime
            // 
            this.labelKelime.AutoSize = true;
            this.labelKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelime.Location = new System.Drawing.Point(201, 67);
            this.labelKelime.Name = "labelKelime";
            this.labelKelime.Size = new System.Drawing.Size(261, 37);
            this.labelKelime.TabIndex = 4;
            this.labelKelime.Text = "Merhaba CSharp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "     mEhmEt  Ali ErBil      ";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(387, 192);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 6;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 394);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelKelime);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonAyir);
            this.Controls.Add(this.buttonKucuk);
            this.Controls.Add(this.buttonBuyuk);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuyuk;
        private System.Windows.Forms.Button buttonKucuk;
        private System.Windows.Forms.Button buttonAyir;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label labelKelime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonKaydet;
    }
}