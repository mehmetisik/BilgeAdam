namespace StringMathDateTimeMethods
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
            this.listBoxSehirler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSehir = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSehirler
            // 
            this.listBoxSehirler.FormattingEnabled = true;
            this.listBoxSehirler.Items.AddRange(new object[] {
            "Adana",
            "Bursa",
            "Edirne",
            "aNKARA"});
            this.listBoxSehirler.Location = new System.Drawing.Point(12, 12);
            this.listBoxSehirler.Name = "listBoxSehirler";
            this.listBoxSehirler.Size = new System.Drawing.Size(147, 173);
            this.listBoxSehirler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şehir:";
            // 
            // textBoxSehir
            // 
            this.textBoxSehir.Location = new System.Drawing.Point(53, 201);
            this.textBoxSehir.Name = "textBoxSehir";
            this.textBoxSehir.Size = new System.Drawing.Size(106, 20);
            this.textBoxSehir.TabIndex = 2;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(84, 227);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 3;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 400);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxSehir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSehirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSehirler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSehir;
        private System.Windows.Forms.Button buttonEkle;
    }
}

