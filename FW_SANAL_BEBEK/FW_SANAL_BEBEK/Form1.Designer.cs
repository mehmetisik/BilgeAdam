namespace FW_SANAL_BEBEK
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
            this.components = new System.ComponentModel.Container();
            this.labelDurum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAclik = new System.Windows.Forms.Label();
            this.labelGaz = new System.Windows.Forms.Label();
            this.labelLavabo = new System.Windows.Forms.Label();
            this.labelMutluluk = new System.Windows.Forms.Label();
            this.labelUyku = new System.Windows.Forms.Label();
            this.buttonBesle = new System.Windows.Forms.Button();
            this.buttonCikar = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonMutluEt = new System.Windows.Forms.Button();
            this.buttonUyut = new System.Windows.Forms.Button();
            this.timerYasam = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurum.Location = new System.Drawing.Point(241, 30);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(36, 39);
            this.labelDurum.TabIndex = 0;
            this.labelDurum.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Açlık Durumu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gaz Durumu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lavabo Durumu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mutluluk Durumu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Uyku Durumu:";
            // 
            // labelAclik
            // 
            this.labelAclik.AutoSize = true;
            this.labelAclik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAclik.Location = new System.Drawing.Point(201, 138);
            this.labelAclik.Name = "labelAclik";
            this.labelAclik.Size = new System.Drawing.Size(24, 25);
            this.labelAclik.TabIndex = 6;
            this.labelAclik.Text = "0";
            // 
            // labelGaz
            // 
            this.labelGaz.AutoSize = true;
            this.labelGaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGaz.Location = new System.Drawing.Point(201, 179);
            this.labelGaz.Name = "labelGaz";
            this.labelGaz.Size = new System.Drawing.Size(24, 25);
            this.labelGaz.TabIndex = 7;
            this.labelGaz.Text = "0";
            // 
            // labelLavabo
            // 
            this.labelLavabo.AutoSize = true;
            this.labelLavabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLavabo.Location = new System.Drawing.Point(201, 219);
            this.labelLavabo.Name = "labelLavabo";
            this.labelLavabo.Size = new System.Drawing.Size(24, 25);
            this.labelLavabo.TabIndex = 8;
            this.labelLavabo.Text = "0";
            // 
            // labelMutluluk
            // 
            this.labelMutluluk.AutoSize = true;
            this.labelMutluluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMutluluk.Location = new System.Drawing.Point(201, 263);
            this.labelMutluluk.Name = "labelMutluluk";
            this.labelMutluluk.Size = new System.Drawing.Size(24, 25);
            this.labelMutluluk.TabIndex = 9;
            this.labelMutluluk.Text = "0";
            // 
            // labelUyku
            // 
            this.labelUyku.AutoSize = true;
            this.labelUyku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUyku.Location = new System.Drawing.Point(201, 308);
            this.labelUyku.Name = "labelUyku";
            this.labelUyku.Size = new System.Drawing.Size(24, 25);
            this.labelUyku.TabIndex = 10;
            this.labelUyku.Text = "0";
            // 
            // buttonBesle
            // 
            this.buttonBesle.Location = new System.Drawing.Point(248, 138);
            this.buttonBesle.Name = "buttonBesle";
            this.buttonBesle.Size = new System.Drawing.Size(75, 23);
            this.buttonBesle.TabIndex = 11;
            this.buttonBesle.Text = "Besle";
            this.buttonBesle.UseVisualStyleBackColor = true;
            // 
            // buttonCikar
            // 
            this.buttonCikar.Location = new System.Drawing.Point(248, 183);
            this.buttonCikar.Name = "buttonCikar";
            this.buttonCikar.Size = new System.Drawing.Size(75, 23);
            this.buttonCikar.TabIndex = 12;
            this.buttonCikar.Text = "Çıkar";
            this.buttonCikar.UseVisualStyleBackColor = true;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(248, 223);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(75, 23);
            this.buttonTemizle.TabIndex = 13;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            // 
            // buttonMutluEt
            // 
            this.buttonMutluEt.Location = new System.Drawing.Point(248, 263);
            this.buttonMutluEt.Name = "buttonMutluEt";
            this.buttonMutluEt.Size = new System.Drawing.Size(75, 23);
            this.buttonMutluEt.TabIndex = 14;
            this.buttonMutluEt.Text = "Pışpışla";
            this.buttonMutluEt.UseVisualStyleBackColor = true;
            // 
            // buttonUyut
            // 
            this.buttonUyut.Location = new System.Drawing.Point(248, 308);
            this.buttonUyut.Name = "buttonUyut";
            this.buttonUyut.Size = new System.Drawing.Size(75, 23);
            this.buttonUyut.TabIndex = 15;
            this.buttonUyut.Text = "Uyut";
            this.buttonUyut.UseVisualStyleBackColor = true;
            // 
            // timerYasam
            // 
            this.timerYasam.Interval = 500;
            this.timerYasam.Tick += new System.EventHandler(this.timerYasam_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 389);
            this.Controls.Add(this.buttonUyut);
            this.Controls.Add(this.buttonMutluEt);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonCikar);
            this.Controls.Add(this.buttonBesle);
            this.Controls.Add(this.labelUyku);
            this.Controls.Add(this.labelMutluluk);
            this.Controls.Add(this.labelLavabo);
            this.Controls.Add(this.labelGaz);
            this.Controls.Add(this.labelAclik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDurum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAclik;
        private System.Windows.Forms.Label labelGaz;
        private System.Windows.Forms.Label labelLavabo;
        private System.Windows.Forms.Label labelMutluluk;
        private System.Windows.Forms.Label labelUyku;
        private System.Windows.Forms.Button buttonBesle;
        private System.Windows.Forms.Button buttonCikar;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonMutluEt;
        private System.Windows.Forms.Button buttonUyut;
        private System.Windows.Forms.Timer timerYasam;

    }
}

