namespace DiziDonguDevam2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBoxIfade = new System.Windows.Forms.TextBox();
            this.buttonBak = new System.Windows.Forms.Button();
            this.textBoxHarf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIfade
            // 
            this.textBoxIfade.Location = new System.Drawing.Point(34, 21);
            this.textBoxIfade.Multiline = true;
            this.textBoxIfade.Name = "textBoxIfade";
            this.textBoxIfade.Size = new System.Drawing.Size(272, 152);
            this.textBoxIfade.TabIndex = 0;
            this.textBoxIfade.Text = resources.GetString("textBoxIfade.Text");
            // 
            // buttonBak
            // 
            this.buttonBak.Location = new System.Drawing.Point(37, 223);
            this.buttonBak.Name = "buttonBak";
            this.buttonBak.Size = new System.Drawing.Size(87, 31);
            this.buttonBak.TabIndex = 1;
            this.buttonBak.Text = "Ara";
            this.buttonBak.UseVisualStyleBackColor = true;
            this.buttonBak.Click += new System.EventHandler(this.buttonBak_Click);
            // 
            // textBoxHarf
            // 
            this.textBoxHarf.Location = new System.Drawing.Point(66, 187);
            this.textBoxHarf.Name = "textBoxHarf";
            this.textBoxHarf.Size = new System.Drawing.Size(47, 20);
            this.textBoxHarf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ara:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHarf);
            this.Controls.Add(this.buttonBak);
            this.Controls.Add(this.textBoxIfade);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIfade;
        private System.Windows.Forms.Button buttonBak;
        private System.Windows.Forms.TextBox textBoxHarf;
        private System.Windows.Forms.Label label1;
    }
}