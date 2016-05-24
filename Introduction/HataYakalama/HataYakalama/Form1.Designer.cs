namespace HataYakalama
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
            this.textBoxSayi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSayi2 = new System.Windows.Forms.TextBox();
            this.buttonOrtalama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı:";
            // 
            // textBoxSayi1
            // 
            this.textBoxSayi1.Location = new System.Drawing.Point(69, 21);
            this.textBoxSayi1.Name = "textBoxSayi1";
            this.textBoxSayi1.Size = new System.Drawing.Size(127, 20);
            this.textBoxSayi1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.Sayı:";
            // 
            // textBoxSayi2
            // 
            this.textBoxSayi2.Location = new System.Drawing.Point(68, 62);
            this.textBoxSayi2.Name = "textBoxSayi2";
            this.textBoxSayi2.Size = new System.Drawing.Size(128, 20);
            this.textBoxSayi2.TabIndex = 3;
            // 
            // buttonOrtalama
            // 
            this.buttonOrtalama.Location = new System.Drawing.Point(121, 98);
            this.buttonOrtalama.Name = "buttonOrtalama";
            this.buttonOrtalama.Size = new System.Drawing.Size(75, 23);
            this.buttonOrtalama.TabIndex = 4;
            this.buttonOrtalama.Text = "Ortalama";
            this.buttonOrtalama.UseVisualStyleBackColor = true;
            this.buttonOrtalama.Click += new System.EventHandler(this.buttonOrtalama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 249);
            this.Controls.Add(this.buttonOrtalama);
            this.Controls.Add(this.textBoxSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSayi1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSayi2;
        private System.Windows.Forms.Button buttonOrtalama;
    }
}

