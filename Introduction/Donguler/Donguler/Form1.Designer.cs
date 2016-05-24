namespace Donguler
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
            this.comboBoxSayilar = new System.Windows.Forms.ComboBox();
            this.groupBoxKlavye = new System.Windows.Forms.GroupBox();
            this.textBoxYazi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayilar:";
            // 
            // comboBoxSayilar
            // 
            this.comboBoxSayilar.FormattingEnabled = true;
            this.comboBoxSayilar.Location = new System.Drawing.Point(78, 31);
            this.comboBoxSayilar.Name = "comboBoxSayilar";
            this.comboBoxSayilar.Size = new System.Drawing.Size(167, 21);
            this.comboBoxSayilar.TabIndex = 1;
            // 
            // groupBoxKlavye
            // 
            this.groupBoxKlavye.AutoSize = true;
            this.groupBoxKlavye.Location = new System.Drawing.Point(34, 100);
            this.groupBoxKlavye.Name = "groupBoxKlavye";
            this.groupBoxKlavye.Size = new System.Drawing.Size(589, 257);
            this.groupBoxKlavye.TabIndex = 2;
            this.groupBoxKlavye.TabStop = false;
            this.groupBoxKlavye.Text = "Ekran Klavyesi";
            // 
            // textBoxYazi
            // 
            this.textBoxYazi.Location = new System.Drawing.Point(307, 31);
            this.textBoxYazi.Multiline = true;
            this.textBoxYazi.Name = "textBoxYazi";
            this.textBoxYazi.Size = new System.Drawing.Size(240, 63);
            this.textBoxYazi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 442);
            this.Controls.Add(this.textBoxYazi);
            this.Controls.Add(this.groupBoxKlavye);
            this.Controls.Add(this.comboBoxSayilar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSayilar;
        private System.Windows.Forms.GroupBox groupBoxKlavye;
        private System.Windows.Forms.TextBox textBoxYazi;
    }
}

