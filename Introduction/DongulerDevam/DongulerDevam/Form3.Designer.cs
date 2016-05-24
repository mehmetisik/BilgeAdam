namespace DongulerDevam
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
            this.listBoxSayilar = new System.Windows.Forms.ListBox();
            this.buttonLoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSayilar
            // 
            this.listBoxSayilar.FormattingEnabled = true;
            this.listBoxSayilar.Location = new System.Drawing.Point(22, 34);
            this.listBoxSayilar.Name = "listBoxSayilar";
            this.listBoxSayilar.Size = new System.Drawing.Size(156, 186);
            this.listBoxSayilar.TabIndex = 0;
            // 
            // buttonLoto
            // 
            this.buttonLoto.Location = new System.Drawing.Point(204, 34);
            this.buttonLoto.Name = "buttonLoto";
            this.buttonLoto.Size = new System.Drawing.Size(87, 26);
            this.buttonLoto.TabIndex = 1;
            this.buttonLoto.Text = "Sayısal Loto";
            this.buttonLoto.UseVisualStyleBackColor = true;
            this.buttonLoto.Click += new System.EventHandler(this.buttonLoto_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 377);
            this.Controls.Add(this.buttonLoto);
            this.Controls.Add(this.listBoxSayilar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSayilar;
        private System.Windows.Forms.Button buttonLoto;
    }
}