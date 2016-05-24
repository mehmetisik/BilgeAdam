namespace KosulKullanimlariDevam
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
            this.comboBoxMevsimler = new System.Windows.Forms.ComboBox();
            this.listBoxAylar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevsimler:";
            // 
            // comboBoxMevsimler
            // 
            this.comboBoxMevsimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMevsimler.FormattingEnabled = true;
            this.comboBoxMevsimler.Items.AddRange(new object[] {
            "İlkbahar",
            "Yaz",
            "Sonbahar",
            "Kış"});
            this.comboBoxMevsimler.Location = new System.Drawing.Point(90, 25);
            this.comboBoxMevsimler.Name = "comboBoxMevsimler";
            this.comboBoxMevsimler.Size = new System.Drawing.Size(153, 21);
            this.comboBoxMevsimler.TabIndex = 1;
            this.comboBoxMevsimler.SelectedIndexChanged += new System.EventHandler(this.comboBoxMevsimler_SelectedIndexChanged);
            // 
            // listBoxAylar
            // 
            this.listBoxAylar.FormattingEnabled = true;
            this.listBoxAylar.Location = new System.Drawing.Point(90, 81);
            this.listBoxAylar.Name = "listBoxAylar";
            this.listBoxAylar.Size = new System.Drawing.Size(153, 160);
            this.listBoxAylar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 309);
            this.Controls.Add(this.listBoxAylar);
            this.Controls.Add(this.comboBoxMevsimler);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMevsimler;
        private System.Windows.Forms.ListBox listBoxAylar;
    }
}

