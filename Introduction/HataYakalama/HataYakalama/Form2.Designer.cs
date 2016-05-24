namespace HataYakalama
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
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.openFileDialogDosya = new System.Windows.Forms.OpenFileDialog();
            this.buttonGozat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxResim.Location = new System.Drawing.Point(107, 25);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(177, 215);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim.TabIndex = 0;
            this.pictureBoxResim.TabStop = false;
            // 
            // openFileDialogDosya
            // 
            this.openFileDialogDosya.FileName = "openFileDialog1";
            // 
            // buttonGozat
            // 
            this.buttonGozat.Location = new System.Drawing.Point(185, 256);
            this.buttonGozat.Name = "buttonGozat";
            this.buttonGozat.Size = new System.Drawing.Size(75, 23);
            this.buttonGozat.TabIndex = 1;
            this.buttonGozat.Text = "Gözat";
            this.buttonGozat.UseVisualStyleBackColor = true;
            this.buttonGozat.Click += new System.EventHandler(this.buttonGozat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 316);
            this.Controls.Add(this.buttonGozat);
            this.Controls.Add(this.pictureBoxResim);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.OpenFileDialog openFileDialogDosya;
        private System.Windows.Forms.Button buttonGozat;
    }
}