namespace MetotlarGiris
{
    partial class Form5
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
            this.textBoxMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAranan = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metin:";
            // 
            // textBoxMetin
            // 
            this.textBoxMetin.Location = new System.Drawing.Point(73, 29);
            this.textBoxMetin.Multiline = true;
            this.textBoxMetin.Name = "textBoxMetin";
            this.textBoxMetin.Size = new System.Drawing.Size(397, 149);
            this.textBoxMetin.TabIndex = 1;
            this.textBoxMetin.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa hede hede hede" +
                " hede hede hede hede hede hede hede hede hede v hede v vv hedehedehedehedev  hed" +
                "e hede hede hede hede";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ara:";
            // 
            // textBoxAranan
            // 
            this.textBoxAranan.Location = new System.Drawing.Point(105, 193);
            this.textBoxAranan.Name = "textBoxAranan";
            this.textBoxAranan.Size = new System.Drawing.Size(180, 20);
            this.textBoxAranan.TabIndex = 3;
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(153, 229);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(132, 23);
            this.buttonAra.TabIndex = 4;
            this.buttonAra.Text = "Bak Bakalım!";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 377);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxAranan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMetin);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAranan;
        private System.Windows.Forms.Button buttonAra;
    }
}