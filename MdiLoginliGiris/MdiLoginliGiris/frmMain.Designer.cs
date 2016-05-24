namespace MdiLoginliGiris
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.biletİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletKesimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGirisDetay = new System.Windows.Forms.Label();
            this.flowLayoutPanelKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletİşlemleriToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // biletİşlemleriToolStripMenuItem
            // 
            this.biletİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonToolStripMenuItem,
            this.biletKesimiToolStripMenuItem});
            this.biletİşlemleriToolStripMenuItem.Name = "biletİşlemleriToolStripMenuItem";
            this.biletİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.biletİşlemleriToolStripMenuItem.Text = "Bilet İşlemleri";
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            this.rezervasyonToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonToolStripMenuItem_Click);
            // 
            // biletKesimiToolStripMenuItem
            // 
            this.biletKesimiToolStripMenuItem.Name = "biletKesimiToolStripMenuItem";
            this.biletKesimiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.biletKesimiToolStripMenuItem.Text = "Bilet Kesimi";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGirisDetay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Detayları";
            // 
            // labelGirisDetay
            // 
            this.labelGirisDetay.AutoSize = true;
            this.labelGirisDetay.Location = new System.Drawing.Point(21, 27);
            this.labelGirisDetay.Name = "labelGirisDetay";
            this.labelGirisDetay.Size = new System.Drawing.Size(35, 13);
            this.labelGirisDetay.TabIndex = 0;
            this.labelGirisDetay.Text = "label1";
            // 
            // flowLayoutPanelKoltuklar
            // 
            this.flowLayoutPanelKoltuklar.Location = new System.Drawing.Point(24, 107);
            this.flowLayoutPanelKoltuklar.Name = "flowLayoutPanelKoltuklar";
            this.flowLayoutPanelKoltuklar.Size = new System.Drawing.Size(491, 284);
            this.flowLayoutPanelKoltuklar.TabIndex = 2;
            // 
            // contextMenuStripMenu
            // 
            this.contextMenuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerveEtToolStripMenuItem,
            this.satışYapToolStripMenuItem,
            this.iptalToolStripMenuItem});
            this.contextMenuStripMenu.Name = "contextMenuStripMenu";
            this.contextMenuStripMenu.Size = new System.Drawing.Size(153, 92);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            this.rezerveEtToolStripMenuItem.Click += new System.EventHandler(this.rezerveEtToolStripMenuItem_Click);
            // 
            // satışYapToolStripMenuItem
            // 
            this.satışYapToolStripMenuItem.Name = "satışYapToolStripMenuItem";
            this.satışYapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.satışYapToolStripMenuItem.Text = "Satış Yap";
            this.satışYapToolStripMenuItem.Click += new System.EventHandler(this.satışYapToolStripMenuItem_Click);
            // 
            // iptalToolStripMenuItem
            // 
            this.iptalToolStripMenuItem.Name = "iptalToolStripMenuItem";
            this.iptalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iptalToolStripMenuItem.Text = "İptal";
            this.iptalToolStripMenuItem.Click += new System.EventHandler(this.iptalToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 416);
            this.Controls.Add(this.flowLayoutPanelKoltuklar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Yiğit Taşımacılık ve Turizm Ltd Şti. V 1.0 ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStripMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem biletİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletKesimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelGirisDetay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKoltuklar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalToolStripMenuItem;
    }
}