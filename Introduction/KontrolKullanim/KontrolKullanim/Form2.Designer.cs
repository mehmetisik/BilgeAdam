namespace KontrolKullanim
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
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnHareket = new System.Windows.Forms.Button();
            this.tmrHareket = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResim
            // 
            this.pbResim.Image = ((System.Drawing.Image)(resources.GetObject("pbResim.Image")));
            this.pbResim.Location = new System.Drawing.Point(27, 24);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(154, 98);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 0;
            this.pbResim.TabStop = false;
            // 
            // btnHareket
            // 
            this.btnHareket.Location = new System.Drawing.Point(96, 321);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(85, 23);
            this.btnHareket.TabIndex = 1;
            this.btnHareket.Text = "Hareket Ettir";
            this.btnHareket.UseVisualStyleBackColor = true;
            this.btnHareket.Click += new System.EventHandler(this.btnHareket_Click);
            // 
            // tmrHareket
            // 
            this.tmrHareket.Tick += new System.EventHandler(this.tmrHareket_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 391);
            this.Controls.Add(this.btnHareket);
            this.Controls.Add(this.pbResim);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnHareket;
        private System.Windows.Forms.Timer tmrHareket;
    }
}