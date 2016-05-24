namespace ADONETGIRIS
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
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.Location = new System.Drawing.Point(31, 35);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(100, 23);
            this.buttonBaglan.TabIndex = 0;
            this.buttonBaglan.Text = "Bağlan";
            this.buttonBaglan.UseVisualStyleBackColor = true;
            this.buttonBaglan.Click += new System.EventHandler(this.buttonBaglan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 321);
            this.Controls.Add(this.buttonBaglan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBaglan;
    }
}

