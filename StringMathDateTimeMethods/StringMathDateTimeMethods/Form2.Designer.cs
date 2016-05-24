namespace StringMathDateTimeMethods
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
            this.comboBoxGunler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAylar = new System.Windows.Forms.ComboBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxYillar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gün:";
            // 
            // comboBoxGunler
            // 
            this.comboBoxGunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGunler.FormattingEnabled = true;
            this.comboBoxGunler.Location = new System.Drawing.Point(94, 31);
            this.comboBoxGunler.Name = "comboBoxGunler";
            this.comboBoxGunler.Size = new System.Drawing.Size(58, 21);
            this.comboBoxGunler.TabIndex = 1;
            this.comboBoxGunler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay:";
            // 
            // comboBoxAylar
            // 
            this.comboBoxAylar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAylar.FormattingEnabled = true;
            this.comboBoxAylar.Location = new System.Drawing.Point(208, 31);
            this.comboBoxAylar.Name = "comboBoxAylar";
            this.comboBoxAylar.Size = new System.Drawing.Size(93, 21);
            this.comboBoxAylar.TabIndex = 3;
            this.comboBoxAylar.SelectedIndexChanged += new System.EventHandler(this.comboBoxAylar_SelectedIndexChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yıl:";
            // 
            // comboBoxYillar
            // 
            this.comboBoxYillar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYillar.FormattingEnabled = true;
            this.comboBoxYillar.Location = new System.Drawing.Point(332, 30);
            this.comboBoxYillar.Name = "comboBoxYillar";
            this.comboBoxYillar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYillar.TabIndex = 5;
            this.comboBoxYillar.SelectedIndexChanged += new System.EventHandler(this.comboBoxYillar_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 275);
            this.Controls.Add(this.comboBoxYillar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAylar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGunler);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAylar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxYillar;
    }
}