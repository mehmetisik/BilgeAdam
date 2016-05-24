namespace Degiskenler
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
            this.labelSayi = new System.Windows.Forms.Label();
            this.btnArttir = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSayi
            // 
            this.labelSayi.AutoSize = true;
            this.labelSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSayi.Location = new System.Drawing.Point(188, 58);
            this.labelSayi.Name = "labelSayi";
            this.labelSayi.Size = new System.Drawing.Size(35, 37);
            this.labelSayi.TabIndex = 0;
            this.labelSayi.Text = "0";
            // 
            // btnArttir
            // 
            this.btnArttir.Location = new System.Drawing.Point(114, 118);
            this.btnArttir.Name = "btnArttir";
            this.btnArttir.Size = new System.Drawing.Size(75, 23);
            this.btnArttir.TabIndex = 1;
            this.btnArttir.Text = "Arttır";
            this.btnArttir.UseVisualStyleBackColor = true;
            this.btnArttir.Click += new System.EventHandler(this.btnArttir_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(207, 118);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(75, 23);
            this.btnAzalt.TabIndex = 2;
            this.btnAzalt.Text = "Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 321);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnArttir);
            this.Controls.Add(this.labelSayi);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSayi;
        private System.Windows.Forms.Button btnArttir;
        private System.Windows.Forms.Button btnAzalt;
    }
}