namespace KontrolKullanim
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pbResim1 = new System.Windows.Forms.PictureBox();
            this.pbResim2 = new System.Windows.Forms.PictureBox();
            this.pbResim3 = new System.Windows.Forms.PictureBox();
            this.tmrKos = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResim1
            // 
            this.pbResim1.Image = ((System.Drawing.Image)(resources.GetObject("pbResim1.Image")));
            this.pbResim1.Location = new System.Drawing.Point(28, 38);
            this.pbResim1.Name = "pbResim1";
            this.pbResim1.Size = new System.Drawing.Size(110, 72);
            this.pbResim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim1.TabIndex = 0;
            this.pbResim1.TabStop = false;
            // 
            // pbResim2
            // 
            this.pbResim2.Image = ((System.Drawing.Image)(resources.GetObject("pbResim2.Image")));
            this.pbResim2.Location = new System.Drawing.Point(28, 132);
            this.pbResim2.Name = "pbResim2";
            this.pbResim2.Size = new System.Drawing.Size(110, 72);
            this.pbResim2.TabIndex = 1;
            this.pbResim2.TabStop = false;
            // 
            // pbResim3
            // 
            this.pbResim3.Image = ((System.Drawing.Image)(resources.GetObject("pbResim3.Image")));
            this.pbResim3.Location = new System.Drawing.Point(28, 231);
            this.pbResim3.Name = "pbResim3";
            this.pbResim3.Size = new System.Drawing.Size(110, 72);
            this.pbResim3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim3.TabIndex = 2;
            this.pbResim3.TabStop = false;
            // 
            // tmrKos
            // 
            this.tmrKos.Enabled = true;
            this.tmrKos.Interval = 500;
            this.tmrKos.Tick += new System.EventHandler(this.tmrKos_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 412);
            this.Controls.Add(this.pbResim3);
            this.Controls.Add(this.pbResim2);
            this.Controls.Add(this.pbResim1);
            this.Name = "Form3";
            this.Text = "Altılı Ganyan";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbResim1;
        private System.Windows.Forms.PictureBox pbResim2;
        private System.Windows.Forms.PictureBox pbResim3;
        private System.Windows.Forms.Timer tmrKos;
    }
}