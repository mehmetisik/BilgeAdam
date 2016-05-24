namespace RichTextBoxKullanim
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
            this.richTextBoxYazi = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFontFamilies = new System.Windows.Forms.ComboBox();
            this.buttonRenk = new System.Windows.Forms.Button();
            this.colorDialogSecici = new System.Windows.Forms.ColorDialog();
            this.fontDialogFontcu = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRenk);
            this.groupBox1.Controls.Add(this.comboBoxFontFamilies);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // richTextBoxYazi
            // 
            this.richTextBoxYazi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxYazi.Location = new System.Drawing.Point(0, 54);
            this.richTextBoxYazi.Name = "richTextBoxYazi";
            this.richTextBoxYazi.Size = new System.Drawing.Size(688, 322);
            this.richTextBoxYazi.TabIndex = 1;
            this.richTextBoxYazi.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font-Size:";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "8",
            "12",
            "16",
            "24",
            "32",
            "48",
            "64",
            "128"});
            this.comboBoxSize.Location = new System.Drawing.Point(85, 19);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(58, 21);
            this.comboBoxSize.TabIndex = 1;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font-Family:";
            // 
            // comboBoxFontFamilies
            // 
            this.comboBoxFontFamilies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontFamilies.FormattingEnabled = true;
            this.comboBoxFontFamilies.Location = new System.Drawing.Point(243, 19);
            this.comboBoxFontFamilies.Name = "comboBoxFontFamilies";
            this.comboBoxFontFamilies.Size = new System.Drawing.Size(173, 21);
            this.comboBoxFontFamilies.TabIndex = 3;
            this.comboBoxFontFamilies.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontFamilies_SelectedIndexChanged);
            // 
            // buttonRenk
            // 
            this.buttonRenk.Location = new System.Drawing.Point(436, 20);
            this.buttonRenk.Name = "buttonRenk";
            this.buttonRenk.Size = new System.Drawing.Size(75, 23);
            this.buttonRenk.TabIndex = 4;
            this.buttonRenk.Text = "Renk Seç";
            this.buttonRenk.UseVisualStyleBackColor = true;
            this.buttonRenk.Click += new System.EventHandler(this.buttonRenk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 376);
            this.Controls.Add(this.richTextBoxYazi);
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
        private System.Windows.Forms.Button buttonRenk;
        private System.Windows.Forms.ComboBox comboBoxFontFamilies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxYazi;
        private System.Windows.Forms.ColorDialog colorDialogSecici;
        private System.Windows.Forms.FontDialog fontDialogFontcu;
    }
}

