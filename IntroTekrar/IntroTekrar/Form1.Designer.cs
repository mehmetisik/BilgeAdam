namespace IntroTekrar
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
            this.textBoxKelime = new System.Windows.Forms.TextBox();
            this.textBoxMetin = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime:";
            // 
            // textBoxKelime
            // 
            this.textBoxKelime.Location = new System.Drawing.Point(86, 30);
            this.textBoxKelime.Name = "textBoxKelime";
            this.textBoxKelime.Size = new System.Drawing.Size(177, 20);
            this.textBoxKelime.TabIndex = 1;
            // 
            // textBoxMetin
            // 
            this.textBoxMetin.Location = new System.Drawing.Point(86, 70);
            this.textBoxMetin.Multiline = true;
            this.textBoxMetin.Name = "textBoxMetin";
            this.textBoxMetin.Size = new System.Drawing.Size(432, 256);
            this.textBoxMetin.TabIndex = 2;
            this.textBoxMetin.Text = resources.GetString("textBoxMetin.Text");
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(430, 342);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(88, 23);
            this.buttonAra.TabIndex = 3;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 435);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxMetin);
            this.Controls.Add(this.textBoxKelime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKelime;
        private System.Windows.Forms.TextBox textBoxMetin;
        private System.Windows.Forms.Button buttonAra;
    }
}

