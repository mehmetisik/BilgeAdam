namespace Poker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBoxPlayer1 = new System.Windows.Forms.GroupBox();
            this.groupBoxPlayer4 = new System.Windows.Forms.GroupBox();
            this.groupBoxPlayer2 = new System.Windows.Forms.GroupBox();
            this.groupBoxPlayer3 = new System.Windows.Forms.GroupBox();
            this.buttonDagit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxPlayer1
            // 
            this.groupBoxPlayer1.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBoxPlayer1.Location = new System.Drawing.Point(332, 12);
            this.groupBoxPlayer1.Name = "groupBoxPlayer1";
            this.groupBoxPlayer1.Size = new System.Drawing.Size(327, 117);
            this.groupBoxPlayer1.TabIndex = 0;
            this.groupBoxPlayer1.TabStop = false;
            this.groupBoxPlayer1.Text = "Player1";
            // 
            // groupBoxPlayer4
            // 
            this.groupBoxPlayer4.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBoxPlayer4.Location = new System.Drawing.Point(332, 414);
            this.groupBoxPlayer4.Name = "groupBoxPlayer4";
            this.groupBoxPlayer4.Size = new System.Drawing.Size(327, 117);
            this.groupBoxPlayer4.TabIndex = 1;
            this.groupBoxPlayer4.TabStop = false;
            this.groupBoxPlayer4.Text = "Player4";
            // 
            // groupBoxPlayer2
            // 
            this.groupBoxPlayer2.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBoxPlayer2.Location = new System.Drawing.Point(33, 210);
            this.groupBoxPlayer2.Name = "groupBoxPlayer2";
            this.groupBoxPlayer2.Size = new System.Drawing.Size(327, 117);
            this.groupBoxPlayer2.TabIndex = 1;
            this.groupBoxPlayer2.TabStop = false;
            this.groupBoxPlayer2.Text = "Player2";
            // 
            // groupBoxPlayer3
            // 
            this.groupBoxPlayer3.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBoxPlayer3.Location = new System.Drawing.Point(613, 210);
            this.groupBoxPlayer3.Name = "groupBoxPlayer3";
            this.groupBoxPlayer3.Size = new System.Drawing.Size(327, 117);
            this.groupBoxPlayer3.TabIndex = 1;
            this.groupBoxPlayer3.TabStop = false;
            this.groupBoxPlayer3.Text = "Player3";
            // 
            // buttonDagit
            // 
            this.buttonDagit.Location = new System.Drawing.Point(431, 244);
            this.buttonDagit.Name = "buttonDagit";
            this.buttonDagit.Size = new System.Drawing.Size(134, 44);
            this.buttonDagit.TabIndex = 2;
            this.buttonDagit.Text = "Dağıt";
            this.buttonDagit.UseVisualStyleBackColor = true;
            this.buttonDagit.Click += new System.EventHandler(this.buttonDagit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 607);
            this.Controls.Add(this.buttonDagit);
            this.Controls.Add(this.groupBoxPlayer3);
            this.Controls.Add(this.groupBoxPlayer2);
            this.Controls.Add(this.groupBoxPlayer4);
            this.Controls.Add(this.groupBoxPlayer1);
            this.Name = "Form2";
            this.Text = "Çakma Texas Holdem";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlayer1;
        private System.Windows.Forms.GroupBox groupBoxPlayer4;
        private System.Windows.Forms.GroupBox groupBoxPlayer2;
        private System.Windows.Forms.GroupBox groupBoxPlayer3;
        private System.Windows.Forms.Button buttonDagit;
    }
}