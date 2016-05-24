namespace UsingClass
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
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.groupBoxListe = new System.Windows.Forms.GroupBox();
        	this.listViewPersoneller = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
        	this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        	this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.groupBoxBilgiler = new System.Windows.Forms.GroupBox();
        	this.radioButtonKadin = new System.Windows.Forms.RadioButton();
        	this.radioButtonErkek = new System.Windows.Forms.RadioButton();
        	this.textBoxEmail = new System.Windows.Forms.TextBox();
        	this.textBoxAdres = new System.Windows.Forms.TextBox();
        	this.comboBoxDepartmanlar = new System.Windows.Forms.ComboBox();
        	this.maskedTextBoxKimlikNo = new System.Windows.Forms.MaskedTextBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.textBoxSoyad = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.textBoxAd = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        	this.splitContainer1.Panel1.SuspendLayout();
        	this.splitContainer1.Panel2.SuspendLayout();
        	this.splitContainer1.SuspendLayout();
        	this.groupBoxListe.SuspendLayout();
        	this.toolStrip1.SuspendLayout();
        	this.groupBoxBilgiler.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// splitContainer1
        	// 
        	this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        	this.splitContainer1.Name = "splitContainer1";
        	// 
        	// splitContainer1.Panel1
        	// 
        	this.splitContainer1.Panel1.Controls.Add(this.groupBoxListe);
        	// 
        	// splitContainer1.Panel2
        	// 
        	this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
        	this.splitContainer1.Panel2.Controls.Add(this.groupBoxBilgiler);
        	this.splitContainer1.Size = new System.Drawing.Size(870, 475);
        	this.splitContainer1.SplitterDistance = 482;
        	this.splitContainer1.TabIndex = 0;
        	// 
        	// groupBoxListe
        	// 
        	this.groupBoxListe.Controls.Add(this.listViewPersoneller);
        	this.groupBoxListe.Location = new System.Drawing.Point(13, 32);
        	this.groupBoxListe.Name = "groupBoxListe";
        	this.groupBoxListe.Size = new System.Drawing.Size(431, 364);
        	this.groupBoxListe.TabIndex = 0;
        	this.groupBoxListe.TabStop = false;
        	this.groupBoxListe.Text = "Personel Listesi";
        	// 
        	// listViewPersoneller
        	// 
        	this.listViewPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader1,
        	        	        	this.columnHeader2,
        	        	        	this.columnHeader3});
        	this.listViewPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.listViewPersoneller.FullRowSelect = true;
        	this.listViewPersoneller.GridLines = true;
        	this.listViewPersoneller.HideSelection = false;
        	this.listViewPersoneller.Location = new System.Drawing.Point(21, 39);
        	this.listViewPersoneller.MultiSelect = false;
        	this.listViewPersoneller.Name = "listViewPersoneller";
        	this.listViewPersoneller.Size = new System.Drawing.Size(391, 301);
        	this.listViewPersoneller.TabIndex = 0;
        	this.listViewPersoneller.UseCompatibleStateImageBehavior = false;
        	this.listViewPersoneller.View = System.Windows.Forms.View.Details;
        	this.listViewPersoneller.SelectedIndexChanged += new System.EventHandler(this.listViewPersoneller_SelectedIndexChanged);
        	// 
        	// columnHeader1
        	// 
        	this.columnHeader1.Text = "Ad";
        	this.columnHeader1.Width = 89;
        	// 
        	// columnHeader2
        	// 
        	this.columnHeader2.Text = "Soyad";
        	this.columnHeader2.Width = 97;
        	// 
        	// columnHeader3
        	// 
        	this.columnHeader3.Text = "Departman";
        	this.columnHeader3.Width = 153;
        	// 
        	// toolStrip1
        	// 
        	this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripButton,
        	        	        	this.saveToolStripButton,
        	        	        	this.toolStripSeparator,
        	        	        	this.cutToolStripButton,
        	        	        	this.toolStripSeparator1,
        	        	        	this.helpToolStripButton});
        	this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        	this.toolStrip1.Name = "toolStrip1";
        	this.toolStrip1.Size = new System.Drawing.Size(384, 25);
        	this.toolStrip1.TabIndex = 2;
        	this.toolStrip1.Text = "toolStrip1";
        	// 
        	// newToolStripButton
        	// 
        	this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
        	this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripButton.Name = "newToolStripButton";
        	this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.newToolStripButton.Text = "&New";
        	this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
        	// 
        	// saveToolStripButton
        	// 
        	this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
        	this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.saveToolStripButton.Name = "saveToolStripButton";
        	this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.saveToolStripButton.Text = "&Save";
        	this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
        	// 
        	// toolStripSeparator
        	// 
        	this.toolStripSeparator.Name = "toolStripSeparator";
        	this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
        	// 
        	// cutToolStripButton
        	// 
        	this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
        	this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.cutToolStripButton.Name = "cutToolStripButton";
        	this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.cutToolStripButton.Text = "Sil";
        	this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
        	// 
        	// toolStripSeparator1
        	// 
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
        	// 
        	// helpToolStripButton
        	// 
        	this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
        	this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.helpToolStripButton.Name = "helpToolStripButton";
        	this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.helpToolStripButton.Text = "He&lp";
        	// 
        	// groupBoxBilgiler
        	// 
        	this.groupBoxBilgiler.Controls.Add(this.radioButtonKadin);
        	this.groupBoxBilgiler.Controls.Add(this.radioButtonErkek);
        	this.groupBoxBilgiler.Controls.Add(this.textBoxEmail);
        	this.groupBoxBilgiler.Controls.Add(this.textBoxAdres);
        	this.groupBoxBilgiler.Controls.Add(this.comboBoxDepartmanlar);
        	this.groupBoxBilgiler.Controls.Add(this.maskedTextBoxKimlikNo);
        	this.groupBoxBilgiler.Controls.Add(this.label6);
        	this.groupBoxBilgiler.Controls.Add(this.label5);
        	this.groupBoxBilgiler.Controls.Add(this.label4);
        	this.groupBoxBilgiler.Controls.Add(this.label3);
        	this.groupBoxBilgiler.Controls.Add(this.textBoxSoyad);
        	this.groupBoxBilgiler.Controls.Add(this.label2);
        	this.groupBoxBilgiler.Controls.Add(this.textBoxAd);
        	this.groupBoxBilgiler.Controls.Add(this.label1);
        	this.groupBoxBilgiler.Location = new System.Drawing.Point(35, 61);
        	this.groupBoxBilgiler.Name = "groupBoxBilgiler";
        	this.groupBoxBilgiler.Size = new System.Drawing.Size(311, 389);
        	this.groupBoxBilgiler.TabIndex = 1;
        	this.groupBoxBilgiler.TabStop = false;
        	this.groupBoxBilgiler.Text = "Personel Bilgileri";
        	this.groupBoxBilgiler.Enter += new System.EventHandler(this.GroupBoxBilgilerEnter);
        	// 
        	// radioButtonKadin
        	// 
        	this.radioButtonKadin.AutoSize = true;
        	this.radioButtonKadin.Location = new System.Drawing.Point(189, 331);
        	this.radioButtonKadin.Name = "radioButtonKadin";
        	this.radioButtonKadin.Size = new System.Drawing.Size(52, 17);
        	this.radioButtonKadin.TabIndex = 13;
        	this.radioButtonKadin.TabStop = true;
        	this.radioButtonKadin.Text = "Kadın";
        	this.radioButtonKadin.UseVisualStyleBackColor = true;
        	// 
        	// radioButtonErkek
        	// 
        	this.radioButtonErkek.AutoSize = true;
        	this.radioButtonErkek.Location = new System.Drawing.Point(100, 331);
        	this.radioButtonErkek.Name = "radioButtonErkek";
        	this.radioButtonErkek.Size = new System.Drawing.Size(53, 17);
        	this.radioButtonErkek.TabIndex = 12;
        	this.radioButtonErkek.TabStop = true;
        	this.radioButtonErkek.Text = "Erkek";
        	this.radioButtonErkek.UseVisualStyleBackColor = true;
        	// 
        	// textBoxEmail
        	// 
        	this.textBoxEmail.Location = new System.Drawing.Point(90, 291);
        	this.textBoxEmail.Name = "textBoxEmail";
        	this.textBoxEmail.Size = new System.Drawing.Size(179, 20);
        	this.textBoxEmail.TabIndex = 11;
        	// 
        	// textBoxAdres
        	// 
        	this.textBoxAdres.Location = new System.Drawing.Point(90, 194);
        	this.textBoxAdres.Multiline = true;
        	this.textBoxAdres.Name = "textBoxAdres";
        	this.textBoxAdres.Size = new System.Drawing.Size(179, 76);
        	this.textBoxAdres.TabIndex = 10;
        	// 
        	// comboBoxDepartmanlar
        	// 
        	this.comboBoxDepartmanlar.FormattingEnabled = true;
        	this.comboBoxDepartmanlar.Items.AddRange(new object[] {
        	        	        	"Futbolcu",
        	        	        	"Survivorcı",
        	        	        	"Dansçı",
        	        	        	"Yetenekçi"});
        	this.comboBoxDepartmanlar.Location = new System.Drawing.Point(90, 153);
        	this.comboBoxDepartmanlar.Name = "comboBoxDepartmanlar";
        	this.comboBoxDepartmanlar.Size = new System.Drawing.Size(179, 21);
        	this.comboBoxDepartmanlar.TabIndex = 9;
        	// 
        	// maskedTextBoxKimlikNo
        	// 
        	this.maskedTextBoxKimlikNo.Location = new System.Drawing.Point(90, 118);
        	this.maskedTextBoxKimlikNo.Name = "maskedTextBoxKimlikNo";
        	this.maskedTextBoxKimlikNo.Size = new System.Drawing.Size(179, 20);
        	this.maskedTextBoxKimlikNo.TabIndex = 8;
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(25, 291);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(39, 13);
        	this.label6.TabIndex = 7;
        	this.label6.Text = "E-Mail:";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(25, 194);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(37, 13);
        	this.label5.TabIndex = 6;
        	this.label5.Text = "Adres:";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(25, 156);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(62, 13);
        	this.label4.TabIndex = 5;
        	this.label4.Text = "Departman:";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(25, 121);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(54, 13);
        	this.label3.TabIndex = 4;
        	this.label3.Text = "Kimlik No:";
        	// 
        	// textBoxSoyad
        	// 
        	this.textBoxSoyad.Location = new System.Drawing.Point(90, 74);
        	this.textBoxSoyad.Name = "textBoxSoyad";
        	this.textBoxSoyad.Size = new System.Drawing.Size(179, 20);
        	this.textBoxSoyad.TabIndex = 3;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(25, 81);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(40, 13);
        	this.label2.TabIndex = 2;
        	this.label2.Text = "Soyad:";
        	// 
        	// textBoxAd
        	// 
        	this.textBoxAd.Location = new System.Drawing.Point(90, 31);
        	this.textBoxAd.Name = "textBoxAd";
        	this.textBoxAd.Size = new System.Drawing.Size(183, 20);
        	this.textBoxAd.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(25, 38);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(23, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Ad:";
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(870, 475);
        	this.Controls.Add(this.splitContainer1);
        	this.Name = "Form1";
        	this.Text = "Personel Yönetimi";
        	this.Load += new System.EventHandler(this.Form1_Load);
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.Panel2.ResumeLayout(false);
        	this.splitContainer1.Panel2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        	this.splitContainer1.ResumeLayout(false);
        	this.groupBoxListe.ResumeLayout(false);
        	this.toolStrip1.ResumeLayout(false);
        	this.toolStrip1.PerformLayout();
        	this.groupBoxBilgiler.ResumeLayout(false);
        	this.groupBoxBilgiler.PerformLayout();
        	this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxListe;
        private System.Windows.Forms.ListView listViewPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.GroupBox groupBoxBilgiler;
        private System.Windows.Forms.RadioButton radioButtonKadin;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.ComboBox comboBoxDepartmanlar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKimlikNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label1;
    }
}

