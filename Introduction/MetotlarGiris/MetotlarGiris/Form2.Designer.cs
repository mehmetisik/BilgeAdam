namespace MetotlarGiris
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSayi1 = new System.Windows.Forms.TextBox();
            this.textBoxSayi2 = new System.Windows.Forms.TextBox();
            this.buttonTopla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayı:";
            // 
            // textBoxSayi1
            // 
            this.textBoxSayi1.Location = new System.Drawing.Point(82, 27);
            this.textBoxSayi1.Name = "textBoxSayi1";
            this.textBoxSayi1.Size = new System.Drawing.Size(130, 20);
            this.textBoxSayi1.TabIndex = 2;
            // 
            // textBoxSayi2
            // 
            this.textBoxSayi2.Location = new System.Drawing.Point(82, 67);
            this.textBoxSayi2.Name = "textBoxSayi2";
            this.textBoxSayi2.Size = new System.Drawing.Size(130, 20);
            this.textBoxSayi2.TabIndex = 3;
            // 
            // buttonTopla
            // 
            this.buttonTopla.Location = new System.Drawing.Point(120, 102);
            this.buttonTopla.Name = "buttonTopla";
            this.buttonTopla.Size = new System.Drawing.Size(92, 23);
            this.buttonTopla.TabIndex = 4;
            this.buttonTopla.Text = "Topla";
            this.buttonTopla.UseVisualStyleBackColor = true;
            this.buttonTopla.Click += new System.EventHandler(this.buttonTopla_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 326);
            this.Controls.Add(this.buttonTopla);
            this.Controls.Add(this.textBoxSayi2);
            this.Controls.Add(this.textBoxSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSayi1;
        private System.Windows.Forms.TextBox textBoxSayi2;
        private System.Windows.Forms.Button buttonTopla;
    }
}