namespace KararYapilari
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
            this.buttonKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKontrol
            // 
            this.buttonKontrol.Location = new System.Drawing.Point(79, 49);
            this.buttonKontrol.Name = "buttonKontrol";
            this.buttonKontrol.Size = new System.Drawing.Size(81, 23);
            this.buttonKontrol.TabIndex = 0;
            this.buttonKontrol.Text = "Kontrol Et";
            this.buttonKontrol.UseVisualStyleBackColor = true;
            this.buttonKontrol.Click += new System.EventHandler(this.buttonKontrol_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 272);
            this.Controls.Add(this.buttonKontrol);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKontrol;
    }
}