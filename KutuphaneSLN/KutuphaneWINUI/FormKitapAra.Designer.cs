namespace KutuphaneWINUI
{
    partial class FormKitapAra
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
            this.textBoxKitap = new System.Windows.Forms.TextBox();
            this.listViewKitaplar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // textBoxKitap
            // 
            this.textBoxKitap.Location = new System.Drawing.Point(83, 30);
            this.textBoxKitap.Name = "textBoxKitap";
            this.textBoxKitap.Size = new System.Drawing.Size(232, 20);
            this.textBoxKitap.TabIndex = 1;
            this.textBoxKitap.TextChanged += new System.EventHandler(this.textBoxKitap_TextChanged);
            // 
            // listViewKitaplar
            // 
            this.listViewKitaplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewKitaplar.Location = new System.Drawing.Point(28, 105);
            this.listViewKitaplar.Name = "listViewKitaplar";
            this.listViewKitaplar.Size = new System.Drawing.Size(384, 290);
            this.listViewKitaplar.TabIndex = 2;
            this.listViewKitaplar.UseCompatibleStateImageBehavior = false;
            this.listViewKitaplar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ISBNNO";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Basım Yılı";
            // 
            // FormKitapAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 468);
            this.Controls.Add(this.listViewKitaplar);
            this.Controls.Add(this.textBoxKitap);
            this.Controls.Add(this.label1);
            this.Name = "FormKitapAra";
            this.Text = "FormKitapAra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKitap;
        private System.Windows.Forms.ListView listViewKitaplar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}