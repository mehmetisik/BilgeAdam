namespace IntroTekrar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myTextBox3 = new IntroTekrar.MyTextBox();
            this.myTextBox2 = new IntroTekrar.MyTextBox();
            this.myTextBox1 = new IntroTekrar.MyTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 0;
            // 
            // myTextBox3
            // 
            this.myTextBox3.Location = new System.Drawing.Point(42, 175);
            this.myTextBox3.Name = "myTextBox3";
            this.myTextBox3.Size = new System.Drawing.Size(164, 20);
            this.myTextBox3.TabIndex = 3;
            this.myTextBox3.tip = IntroTekrar.YaziTipi.Alfabetik;
            this.myTextBox3.Yazi = null;
            // 
            // myTextBox2
            // 
            this.myTextBox2.Location = new System.Drawing.Point(42, 128);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(164, 20);
            this.myTextBox2.TabIndex = 2;
            this.myTextBox2.tip = IntroTekrar.YaziTipi.Sayısal;
            this.myTextBox2.Yazi = null;
            // 
            // myTextBox1
            // 
            this.myTextBox1.Location = new System.Drawing.Point(42, 87);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(164, 20);
            this.myTextBox1.TabIndex = 1;
            this.myTextBox1.tip = IntroTekrar.YaziTipi.Alfabetik;
            this.myTextBox1.Yazi = null;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 300);
            this.Controls.Add(this.myTextBox3);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private MyTextBox myTextBox1;
        private MyTextBox myTextBox2;
        private MyTextBox myTextBox3;
    }
}