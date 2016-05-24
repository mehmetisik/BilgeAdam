namespace HaberTurkXml
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
            this.listBoxHaberler = new System.Windows.Forms.ListBox();
            this.panelBilgi = new System.Windows.Forms.Panel();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.linkLabelAciklama = new System.Windows.Forms.LinkLabel();
            this.panelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxHaberler
            // 
            this.listBoxHaberler.FormattingEnabled = true;
            this.listBoxHaberler.Location = new System.Drawing.Point(12, 58);
            this.listBoxHaberler.Name = "listBoxHaberler";
            this.listBoxHaberler.Size = new System.Drawing.Size(293, 329);
            this.listBoxHaberler.TabIndex = 0;
            this.listBoxHaberler.SelectedIndexChanged += new System.EventHandler(this.listBoxHaberler_SelectedIndexChanged);
            // 
            // panelBilgi
            // 
            this.panelBilgi.AutoScroll = true;
            this.panelBilgi.Controls.Add(this.linkLabelAciklama);
            this.panelBilgi.Controls.Add(this.pictureBoxResim);
            this.panelBilgi.Location = new System.Drawing.Point(396, 58);
            this.panelBilgi.Name = "panelBilgi";
            this.panelBilgi.Size = new System.Drawing.Size(325, 297);
            this.panelBilgi.TabIndex = 1;
            this.panelBilgi.Visible = false;
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Location = new System.Drawing.Point(19, 23);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(122, 139);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim.TabIndex = 0;
            this.pictureBoxResim.TabStop = false;
            // 
            // linkLabelAciklama
            // 
            this.linkLabelAciklama.AutoSize = true;
            this.linkLabelAciklama.Location = new System.Drawing.Point(19, 180);
            this.linkLabelAciklama.Name = "linkLabelAciklama";
            this.linkLabelAciklama.Size = new System.Drawing.Size(55, 13);
            this.linkLabelAciklama.TabIndex = 1;
            this.linkLabelAciklama.TabStop = true;
            this.linkLabelAciklama.Text = "linkLabel1";
            this.linkLabelAciklama.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAciklama_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 510);
            this.Controls.Add(this.panelBilgi);
            this.Controls.Add(this.listBoxHaberler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBilgi.ResumeLayout(false);
            this.panelBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHaberler;
        private System.Windows.Forms.Panel panelBilgi;
        private System.Windows.Forms.LinkLabel linkLabelAciklama;
        private System.Windows.Forms.PictureBox pictureBoxResim;
    }
}

