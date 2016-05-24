namespace DiziDonguDevam
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
            this.listBoxSehirler = new System.Windows.Forms.ListBox();
            this.buttonGetir = new System.Windows.Forms.Button();
            this.buttonIslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSehirler
            // 
            this.listBoxSehirler.FormattingEnabled = true;
            this.listBoxSehirler.Location = new System.Drawing.Point(22, 29);
            this.listBoxSehirler.Name = "listBoxSehirler";
            this.listBoxSehirler.Size = new System.Drawing.Size(157, 212);
            this.listBoxSehirler.TabIndex = 0;
            // 
            // buttonGetir
            // 
            this.buttonGetir.Location = new System.Drawing.Point(70, 259);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(109, 23);
            this.buttonGetir.TabIndex = 1;
            this.buttonGetir.Text = "Getir";
            this.buttonGetir.UseVisualStyleBackColor = true;
            this.buttonGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // buttonIslem
            // 
            this.buttonIslem.Location = new System.Drawing.Point(252, 84);
            this.buttonIslem.Name = "buttonIslem";
            this.buttonIslem.Size = new System.Drawing.Size(99, 23);
            this.buttonIslem.TabIndex = 2;
            this.buttonIslem.Text = "İşlem Yap";
            this.buttonIslem.UseVisualStyleBackColor = true;
            this.buttonIslem.Click += new System.EventHandler(this.buttonIslem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 338);
            this.Controls.Add(this.buttonIslem);
            this.Controls.Add(this.buttonGetir);
            this.Controls.Add(this.listBoxSehirler);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSehirler;
        private System.Windows.Forms.Button buttonGetir;
        private System.Windows.Forms.Button buttonIslem;
    }
}