namespace KosulKullanimlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBoxResim1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxResim2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxResim3 = new System.Windows.Forms.PictureBox();
            this.labelJeton = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.timerHareket = new System.Windows.Forms.Timer(this.components);
            this.ımageListResimler = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxResim1
            // 
            this.pictureBoxResim1.Location = new System.Drawing.Point(44, 105);
            this.pictureBoxResim1.Name = "pictureBoxResim1";
            this.pictureBoxResim1.Size = new System.Drawing.Size(73, 83);
            this.pictureBoxResim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim1.TabIndex = 0;
            this.pictureBoxResim1.TabStop = false;
            // 
            // pictureBoxResim2
            // 
            this.pictureBoxResim2.Location = new System.Drawing.Point(128, 104);
            this.pictureBoxResim2.Name = "pictureBoxResim2";
            this.pictureBoxResim2.Size = new System.Drawing.Size(73, 83);
            this.pictureBoxResim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim2.TabIndex = 1;
            this.pictureBoxResim2.TabStop = false;
            // 
            // pictureBoxResim3
            // 
            this.pictureBoxResim3.Location = new System.Drawing.Point(210, 104);
            this.pictureBoxResim3.Name = "pictureBoxResim3";
            this.pictureBoxResim3.Size = new System.Drawing.Size(73, 83);
            this.pictureBoxResim3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim3.TabIndex = 2;
            this.pictureBoxResim3.TabStop = false;
            // 
            // labelJeton
            // 
            this.labelJeton.BackColor = System.Drawing.Color.Maroon;
            this.labelJeton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelJeton.Location = new System.Drawing.Point(41, 197);
            this.labelJeton.Name = "labelJeton";
            this.labelJeton.Size = new System.Drawing.Size(96, 27);
            this.labelJeton.TabIndex = 3;
            this.labelJeton.Text = "Jeton:0";
            this.labelJeton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(256, 270);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(46, 40);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // timerHareket
            // 
            this.timerHareket.Interval = 10;
            this.timerHareket.Tick += new System.EventHandler(this.timerHareket_Tick);
            // 
            // ımageListResimler
            // 
            this.ımageListResimler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListResimler.ImageStream")));
            this.ımageListResimler.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListResimler.Images.SetKeyName(0, "elma.jpg");
            this.ımageListResimler.Images.SetKeyName(1, "kivi2.jpg");
            this.ımageListResimler.Images.SetKeyName(2, "muzresmi12.jpg");
            this.ımageListResimler.Images.SetKeyName(3, "visne.jpg");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 322);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelJeton);
            this.Controls.Add(this.pictureBoxResim3);
            this.Controls.Add(this.pictureBoxResim2);
            this.Controls.Add(this.pictureBoxResim1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Makinesi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxResim1;
        private System.Windows.Forms.PictureBox pictureBoxResim2;
        private System.Windows.Forms.PictureBox pictureBoxResim3;
        private System.Windows.Forms.Label labelJeton;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Timer timerHareket;
        private System.Windows.Forms.ImageList ımageListResimler;
    }
}