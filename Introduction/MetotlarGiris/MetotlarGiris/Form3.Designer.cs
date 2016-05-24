namespace MetotlarGiris
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDogum = new System.Windows.Forms.DateTimePicker();
            this.buttonTarih = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxYillar = new System.Windows.Forms.ComboBox();
            this.buttonYil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğum Tarihi:";
            // 
            // dateTimePickerDogum
            // 
            this.dateTimePickerDogum.Location = new System.Drawing.Point(106, 22);
            this.dateTimePickerDogum.Name = "dateTimePickerDogum";
            this.dateTimePickerDogum.Size = new System.Drawing.Size(204, 20);
            this.dateTimePickerDogum.TabIndex = 1;
            // 
            // buttonTarih
            // 
            this.buttonTarih.Location = new System.Drawing.Point(224, 59);
            this.buttonTarih.Name = "buttonTarih";
            this.buttonTarih.Size = new System.Drawing.Size(86, 23);
            this.buttonTarih.TabIndex = 2;
            this.buttonTarih.Text = "Yaş Hesapla";
            this.buttonTarih.UseVisualStyleBackColor = true;
            this.buttonTarih.Click += new System.EventHandler(this.buttonTarih_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yıl Seç:";
            // 
            // comboBoxYillar
            // 
            this.comboBoxYillar.FormattingEnabled = true;
            this.comboBoxYillar.Location = new System.Drawing.Point(443, 22);
            this.comboBoxYillar.Name = "comboBoxYillar";
            this.comboBoxYillar.Size = new System.Drawing.Size(154, 21);
            this.comboBoxYillar.TabIndex = 4;
            // 
            // buttonYil
            // 
            this.buttonYil.Location = new System.Drawing.Point(501, 59);
            this.buttonYil.Name = "buttonYil";
            this.buttonYil.Size = new System.Drawing.Size(96, 23);
            this.buttonYil.TabIndex = 5;
            this.buttonYil.Text = "Yaş Hesapla";
            this.buttonYil.UseVisualStyleBackColor = true;
            this.buttonYil.Click += new System.EventHandler(this.buttonYil_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 344);
            this.Controls.Add(this.buttonYil);
            this.Controls.Add(this.comboBoxYillar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTarih);
            this.Controls.Add(this.dateTimePickerDogum);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogum;
        private System.Windows.Forms.Button buttonTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxYillar;
        private System.Windows.Forms.Button buttonYil;
    }
}