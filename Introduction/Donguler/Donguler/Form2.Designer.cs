namespace Donguler
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
            this.listBoxSayilar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHadi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSayilar
            // 
            this.listBoxSayilar.FormattingEnabled = true;
            this.listBoxSayilar.Location = new System.Drawing.Point(36, 101);
            this.listBoxSayilar.Name = "listBoxSayilar";
            this.listBoxSayilar.Size = new System.Drawing.Size(177, 199);
            this.listBoxSayilar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1\'den:";
            // 
            // textBoxSayi
            // 
            this.textBoxSayi.Location = new System.Drawing.Point(67, 24);
            this.textBoxSayi.Name = "textBoxSayi";
            this.textBoxSayi.Size = new System.Drawing.Size(146, 20);
            this.textBoxSayi.TabIndex = 2;
            this.textBoxSayi.TextChanged += new System.EventHandler(this.textBoxSayi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "\'e kadar çift sayılar";
            // 
            // buttonHadi
            // 
            this.buttonHadi.Enabled = false;
            this.buttonHadi.Location = new System.Drawing.Point(223, 59);
            this.buttonHadi.Name = "buttonHadi";
            this.buttonHadi.Size = new System.Drawing.Size(97, 26);
            this.buttonHadi.TabIndex = 4;
            this.buttonHadi.Text = "Haydi Gari";
            this.buttonHadi.UseVisualStyleBackColor = true;
            this.buttonHadi.Click += new System.EventHandler(this.buttonHadi_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.buttonHadi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 337);
            this.Controls.Add(this.buttonHadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSayilar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHadi;
    }
}