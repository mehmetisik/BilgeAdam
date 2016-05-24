namespace KutuphaneWINUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxYayinEvleri = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKitap = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxYillar = new System.Windows.Forms.ComboBox();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.buttonGozat = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yayınevi:";
            // 
            // comboBoxYayinEvleri
            // 
            this.comboBoxYayinEvleri.FormattingEnabled = true;
            this.comboBoxYayinEvleri.Location = new System.Drawing.Point(81, 176);
            this.comboBoxYayinEvleri.Name = "comboBoxYayinEvleri";
            this.comboBoxYayinEvleri.Size = new System.Drawing.Size(166, 21);
            this.comboBoxYayinEvleri.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.buttonGozat);
            this.groupBox1.Controls.Add(this.comboBoxYayinEvleri);
            this.groupBox1.Controls.Add(this.pictureBoxResim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxYillar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxSayfa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxKitap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 301);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı:";
            // 
            // textBoxKitap
            // 
            this.textBoxKitap.Location = new System.Drawing.Point(81, 28);
            this.textBoxKitap.Name = "textBoxKitap";
            this.textBoxKitap.Size = new System.Drawing.Size(191, 20);
            this.textBoxKitap.TabIndex = 1;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(81, 67);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(191, 20);
            this.textBoxISBN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN NO:";
            // 
            // textBoxSayfa
            // 
            this.textBoxSayfa.Location = new System.Drawing.Point(81, 103);
            this.textBoxSayfa.Name = "textBoxSayfa";
            this.textBoxSayfa.Size = new System.Drawing.Size(191, 20);
            this.textBoxSayfa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Basım Yılı:";
            // 
            // comboBoxYillar
            // 
            this.comboBoxYillar.FormattingEnabled = true;
            this.comboBoxYillar.Location = new System.Drawing.Point(81, 136);
            this.comboBoxYillar.Name = "comboBoxYillar";
            this.comboBoxYillar.Size = new System.Drawing.Size(141, 21);
            this.comboBoxYillar.TabIndex = 7;
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Location = new System.Drawing.Point(336, 28);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(114, 129);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim.TabIndex = 10;
            this.pictureBoxResim.TabStop = false;
            // 
            // buttonGozat
            // 
            this.buttonGozat.Location = new System.Drawing.Point(336, 165);
            this.buttonGozat.Name = "buttonGozat";
            this.buttonGozat.Size = new System.Drawing.Size(114, 25);
            this.buttonGozat.TabIndex = 11;
            this.buttonGozat.Text = "Gözat";
            this.buttonGozat.UseVisualStyleBackColor = true;
            this.buttonGozat.Click += new System.EventHandler(this.buttonGozat_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(336, 245);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(114, 36);
            this.buttonEkle.TabIndex = 12;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 387);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxYayinEvleri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonGozat;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.ComboBox comboBoxYillar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

