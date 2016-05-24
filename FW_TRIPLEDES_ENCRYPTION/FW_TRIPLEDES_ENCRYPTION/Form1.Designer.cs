namespace FW_TRIPLEDES_ENCRYPTION
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSifrelenecek = new System.Windows.Forms.TextBox();
            this.buttonSifrele = new System.Windows.Forms.Button();
            this.textBoxSifrelenmis = new System.Windows.Forms.TextBox();
            this.buttonCoz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            // 
            // textBoxSifrelenecek
            // 
            this.textBoxSifrelenecek.Location = new System.Drawing.Point(65, 29);
            this.textBoxSifrelenecek.Name = "textBoxSifrelenecek";
            this.textBoxSifrelenecek.Size = new System.Drawing.Size(228, 20);
            this.textBoxSifrelenecek.TabIndex = 1;
            // 
            // buttonSifrele
            // 
            this.buttonSifrele.Location = new System.Drawing.Point(188, 69);
            this.buttonSifrele.Name = "buttonSifrele";
            this.buttonSifrele.Size = new System.Drawing.Size(105, 31);
            this.buttonSifrele.TabIndex = 2;
            this.buttonSifrele.Text = "Şifrele";
            this.buttonSifrele.UseVisualStyleBackColor = true;
            this.buttonSifrele.Click += new System.EventHandler(this.buttonSifrele_Click);
            // 
            // textBoxSifrelenmis
            // 
            this.textBoxSifrelenmis.Location = new System.Drawing.Point(381, 29);
            this.textBoxSifrelenmis.Name = "textBoxSifrelenmis";
            this.textBoxSifrelenmis.Size = new System.Drawing.Size(275, 20);
            this.textBoxSifrelenmis.TabIndex = 3;
            // 
            // buttonCoz
            // 
            this.buttonCoz.Location = new System.Drawing.Point(530, 69);
            this.buttonCoz.Name = "buttonCoz";
            this.buttonCoz.Size = new System.Drawing.Size(126, 23);
            this.buttonCoz.TabIndex = 4;
            this.buttonCoz.Text = "Çöz";
            this.buttonCoz.UseVisualStyleBackColor = true;
            this.buttonCoz.Click += new System.EventHandler(this.buttonCoz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 180);
            this.Controls.Add(this.buttonCoz);
            this.Controls.Add(this.textBoxSifrelenmis);
            this.Controls.Add(this.buttonSifrele);
            this.Controls.Add(this.textBoxSifrelenecek);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSifrelenecek;
        private System.Windows.Forms.Button buttonSifrele;
        private System.Windows.Forms.TextBox textBoxSifrelenmis;
        private System.Windows.Forms.Button buttonCoz;
    }
}

