namespace DBResimCekme
{
    partial class FormAdaylar
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
            this.flowLayoutPanelAdaylar = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAdaylar
            // 
            this.flowLayoutPanelAdaylar.AutoScroll = true;
            this.flowLayoutPanelAdaylar.Location = new System.Drawing.Point(21, 54);
            this.flowLayoutPanelAdaylar.Name = "flowLayoutPanelAdaylar";
            this.flowLayoutPanelAdaylar.Size = new System.Drawing.Size(567, 354);
            this.flowLayoutPanelAdaylar.TabIndex = 0;
            // 
            // FormAdaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 469);
            this.Controls.Add(this.flowLayoutPanelAdaylar);
            this.Name = "FormAdaylar";
            this.Text = "FormAdaylar";
            this.Load += new System.EventHandler(this.FormAdaylar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAdaylar;
    }
}