namespace XMLGiris
{
    partial class Form2
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
            this.comboBoxKurlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSatis = new System.Windows.Forms.Label();
            this.labelAlis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurlar";
            // 
            // comboBoxKurlar
            // 
            this.comboBoxKurlar.FormattingEnabled = true;
            this.comboBoxKurlar.Location = new System.Drawing.Point(69, 32);
            this.comboBoxKurlar.Name = "comboBoxKurlar";
            this.comboBoxKurlar.Size = new System.Drawing.Size(203, 21);
            this.comboBoxKurlar.TabIndex = 1;
            this.comboBoxKurlar.SelectedIndexChanged += new System.EventHandler(this.comboBoxKurlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Satış Fiyatı:";
            // 
            // labelSatis
            // 
            this.labelSatis.AutoSize = true;
            this.labelSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSatis.Location = new System.Drawing.Point(409, 82);
            this.labelSatis.Name = "labelSatis";
            this.labelSatis.Size = new System.Drawing.Size(41, 13);
            this.labelSatis.TabIndex = 5;
            this.labelSatis.Text = "label4";
            // 
            // labelAlis
            // 
            this.labelAlis.AutoSize = true;
            this.labelAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlis.Location = new System.Drawing.Point(409, 52);
            this.labelAlis.Name = "labelAlis";
            this.labelAlis.Size = new System.Drawing.Size(41, 13);
            this.labelAlis.TabIndex = 4;
            this.labelAlis.Text = "label5";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 439);
            this.Controls.Add(this.labelSatis);
            this.Controls.Add(this.labelAlis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxKurlar);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKurlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSatis;
        private System.Windows.Forms.Label labelAlis;
    }
}