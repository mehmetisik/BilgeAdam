namespace UsingClass
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialogDosya = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.buttonGozat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dialog Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogDosya
            // 
            this.openFileDialogDosya.FileName = "openFileDialog1";
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Location = new System.Drawing.Point(146, 12);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(196, 237);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim.TabIndex = 1;
            this.pictureBoxResim.TabStop = false;
            // 
            // buttonGozat
            // 
            this.buttonGozat.Location = new System.Drawing.Point(146, 266);
            this.buttonGozat.Name = "buttonGozat";
            this.buttonGozat.Size = new System.Drawing.Size(75, 23);
            this.buttonGozat.TabIndex = 2;
            this.buttonGozat.Text = "Gözat";
            this.buttonGozat.UseVisualStyleBackColor = true;
            this.buttonGozat.Click += new System.EventHandler(this.buttonGozat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 340);
            this.Controls.Add(this.buttonGozat);
            this.Controls.Add(this.pictureBoxResim);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Dialog Result";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialogDosya;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.Button buttonGozat;
    }
}