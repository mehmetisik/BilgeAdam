namespace FW_SYSTEM_AYO
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSuruculer = new System.Windows.Forms.ComboBox();
            this.treeViewKlasorler = new System.Windows.Forms.TreeView();
            this.listViewDosyalar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sürücüler:";
            // 
            // comboBoxSuruculer
            // 
            this.comboBoxSuruculer.FormattingEnabled = true;
            this.comboBoxSuruculer.Location = new System.Drawing.Point(104, 35);
            this.comboBoxSuruculer.Name = "comboBoxSuruculer";
            this.comboBoxSuruculer.Size = new System.Drawing.Size(236, 21);
            this.comboBoxSuruculer.TabIndex = 1;
            this.comboBoxSuruculer.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuruculer_SelectedIndexChanged);
            // 
            // treeViewKlasorler
            // 
            this.treeViewKlasorler.Location = new System.Drawing.Point(46, 92);
            this.treeViewKlasorler.Name = "treeViewKlasorler";
            this.treeViewKlasorler.Size = new System.Drawing.Size(294, 358);
            this.treeViewKlasorler.TabIndex = 2;
            this.treeViewKlasorler.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewKlasorler_AfterSelect);
            // 
            // listViewDosyalar
            // 
            this.listViewDosyalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewDosyalar.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewDosyalar.Location = new System.Drawing.Point(418, 92);
            this.listViewDosyalar.Name = "listViewDosyalar";
            this.listViewDosyalar.Size = new System.Drawing.Size(700, 358);
            this.listViewDosyalar.SmallImageList = this.ımageList1;
            this.listViewDosyalar.TabIndex = 3;
            this.listViewDosyalar.UseCompatibleStateImageBehavior = false;
            this.listViewDosyalar.View = System.Windows.Forms.View.SmallIcon;
            this.listViewDosyalar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewDosyalar_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dosya Adı";
            this.columnHeader1.Width = 161;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boyutu";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Uzantısı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Oluşturulma Tarihi";
            this.columnHeader4.Width = 270;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopyalaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 512);
            this.Controls.Add(this.listViewDosyalar);
            this.Controls.Add(this.treeViewKlasorler);
            this.Controls.Add(this.comboBoxSuruculer);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSuruculer;
        private System.Windows.Forms.TreeView treeViewKlasorler;
        private System.Windows.Forms.ListView listViewDosyalar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList1;
    }
}