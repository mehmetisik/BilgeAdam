namespace PrintingGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxUrunler = new System.Windows.Forms.ListBox();
            this.printDocumentYazdirilacak = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogOnIzleyici = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonYazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUrunler
            // 
            this.listBoxUrunler.FormattingEnabled = true;
            this.listBoxUrunler.Items.AddRange(new object[] {
            "Televizyon",
            "Bilgisayar",
            "Buzdolabı",
            "Klima",
            "LCD"});
            this.listBoxUrunler.Location = new System.Drawing.Point(21, 29);
            this.listBoxUrunler.Name = "listBoxUrunler";
            this.listBoxUrunler.Size = new System.Drawing.Size(178, 212);
            this.listBoxUrunler.TabIndex = 0;
            // 
            // printDocumentYazdirilacak
            // 
            this.printDocumentYazdirilacak.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentYazdirilacak_PrintPage);
            // 
            // printPreviewDialogOnIzleyici
            // 
            this.printPreviewDialogOnIzleyici.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOnIzleyici.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOnIzleyici.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogOnIzleyici.Document = this.printDocumentYazdirilacak;
            this.printPreviewDialogOnIzleyici.Enabled = true;
            this.printPreviewDialogOnIzleyici.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogOnIzleyici.Icon")));
            this.printPreviewDialogOnIzleyici.Name = "printPreviewDialogOnIzleyici";
            this.printPreviewDialogOnIzleyici.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ön İzle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.Location = new System.Drawing.Point(220, 258);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(85, 23);
            this.buttonYazdir.TabIndex = 2;
            this.buttonYazdir.Text = "Yazdır";
            this.buttonYazdir.UseVisualStyleBackColor = true;
            this.buttonYazdir.Click += new System.EventHandler(this.buttonYazdir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 378);
            this.Controls.Add(this.buttonYazdir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUrunler;
        private System.Drawing.Printing.PrintDocument printDocumentYazdirilacak;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogOnIzleyici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonYazdir;
    }
}

