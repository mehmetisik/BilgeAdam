namespace ADO_CURRENCY_MANAGER
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnitsInStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxDiscontinued = new System.Windows.Forms.CheckBox();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonIleri);
            this.groupBox1.Controls.Add(this.buttonGeri);
            this.groupBox1.Controls.Add(this.checkBoxDiscontinued);
            this.groupBox1.Controls.Add(this.textBoxQuantityPerUnit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxUnitsInStock);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxUnitPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN BİLGİLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(88, 37);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(223, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(88, 77);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(223, 20);
            this.textBoxUnitPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat:";
            // 
            // textBoxUnitsInStock
            // 
            this.textBoxUnitsInStock.Location = new System.Drawing.Point(88, 117);
            this.textBoxUnitsInStock.Name = "textBoxUnitsInStock";
            this.textBoxUnitsInStock.Size = new System.Drawing.Size(223, 20);
            this.textBoxUnitsInStock.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stok:";
            // 
            // textBoxQuantityPerUnit
            // 
            this.textBoxQuantityPerUnit.Location = new System.Drawing.Point(88, 155);
            this.textBoxQuantityPerUnit.Name = "textBoxQuantityPerUnit";
            this.textBoxQuantityPerUnit.Size = new System.Drawing.Size(223, 20);
            this.textBoxQuantityPerUnit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ünite Birimi:";
            // 
            // checkBoxDiscontinued
            // 
            this.checkBoxDiscontinued.AutoSize = true;
            this.checkBoxDiscontinued.Location = new System.Drawing.Point(88, 192);
            this.checkBoxDiscontinued.Name = "checkBoxDiscontinued";
            this.checkBoxDiscontinued.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDiscontinued.TabIndex = 11;
            this.checkBoxDiscontinued.Text = "İndirimli Mi?";
            this.checkBoxDiscontinued.UseVisualStyleBackColor = true;
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(140, 232);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(80, 33);
            this.buttonGeri.TabIndex = 12;
            this.buttonGeri.Text = "<<<";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonIleri
            // 
            this.buttonIleri.Location = new System.Drawing.Point(238, 232);
            this.buttonIleri.Name = "buttonIleri";
            this.buttonIleri.Size = new System.Drawing.Size(86, 33);
            this.buttonIleri.TabIndex = 13;
            this.buttonIleri.Text = ">>>";
            this.buttonIleri.UseVisualStyleBackColor = true;
            this.buttonIleri.Click += new System.EventHandler(this.buttonIleri_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "İlk Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Son Kayıt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.CheckBox checkBoxDiscontinued;
        private System.Windows.Forms.TextBox textBoxQuantityPerUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUnitsInStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

