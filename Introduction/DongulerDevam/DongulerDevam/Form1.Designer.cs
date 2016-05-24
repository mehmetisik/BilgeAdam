namespace DongulerDevam
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
            this.listBoxFor = new System.Windows.Forms.ListBox();
            this.listBoxWhile = new System.Windows.Forms.ListBox();
            this.listBoxDoWhile = new System.Windows.Forms.ListBox();
            this.buttonFor = new System.Windows.Forms.Button();
            this.buttonWhile = new System.Windows.Forms.Button();
            this.buttonDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFor
            // 
            this.listBoxFor.FormattingEnabled = true;
            this.listBoxFor.Location = new System.Drawing.Point(33, 36);
            this.listBoxFor.Name = "listBoxFor";
            this.listBoxFor.Size = new System.Drawing.Size(153, 199);
            this.listBoxFor.TabIndex = 0;
            // 
            // listBoxWhile
            // 
            this.listBoxWhile.FormattingEnabled = true;
            this.listBoxWhile.Location = new System.Drawing.Point(227, 36);
            this.listBoxWhile.Name = "listBoxWhile";
            this.listBoxWhile.Size = new System.Drawing.Size(153, 199);
            this.listBoxWhile.TabIndex = 1;
            // 
            // listBoxDoWhile
            // 
            this.listBoxDoWhile.FormattingEnabled = true;
            this.listBoxDoWhile.Location = new System.Drawing.Point(418, 36);
            this.listBoxDoWhile.Name = "listBoxDoWhile";
            this.listBoxDoWhile.Size = new System.Drawing.Size(153, 199);
            this.listBoxDoWhile.TabIndex = 2;
            // 
            // buttonFor
            // 
            this.buttonFor.Location = new System.Drawing.Point(111, 256);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(75, 23);
            this.buttonFor.TabIndex = 3;
            this.buttonFor.Text = "FOR";
            this.buttonFor.UseVisualStyleBackColor = true;
            this.buttonFor.Click += new System.EventHandler(this.buttonFor_Click);
            // 
            // buttonWhile
            // 
            this.buttonWhile.Location = new System.Drawing.Point(305, 256);
            this.buttonWhile.Name = "buttonWhile";
            this.buttonWhile.Size = new System.Drawing.Size(75, 23);
            this.buttonWhile.TabIndex = 4;
            this.buttonWhile.Text = "WHILE";
            this.buttonWhile.UseVisualStyleBackColor = true;
            this.buttonWhile.Click += new System.EventHandler(this.buttonWhile_Click);
            // 
            // buttonDoWhile
            // 
            this.buttonDoWhile.Location = new System.Drawing.Point(496, 256);
            this.buttonDoWhile.Name = "buttonDoWhile";
            this.buttonDoWhile.Size = new System.Drawing.Size(75, 23);
            this.buttonDoWhile.TabIndex = 5;
            this.buttonDoWhile.Text = "Do While";
            this.buttonDoWhile.UseVisualStyleBackColor = true;
            this.buttonDoWhile.Click += new System.EventHandler(this.buttonDoWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 395);
            this.Controls.Add(this.buttonDoWhile);
            this.Controls.Add(this.buttonWhile);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.listBoxDoWhile);
            this.Controls.Add(this.listBoxWhile);
            this.Controls.Add(this.listBoxFor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFor;
        private System.Windows.Forms.ListBox listBoxWhile;
        private System.Windows.Forms.ListBox listBoxDoWhile;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.Button buttonWhile;
        private System.Windows.Forms.Button buttonDoWhile;
    }
}

