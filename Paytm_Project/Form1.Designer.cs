namespace Paytm_Project
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
            this.paytm11 = new Paytm_Project.paytm1();
            this.SuspendLayout();
            // 
            // paytm11
            // 
            this.paytm11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paytm11.Location = new System.Drawing.Point(0, 0);
            this.paytm11.Name = "paytm11";
            this.paytm11.Size = new System.Drawing.Size(427, 489);
            this.paytm11.TabIndex = 0;
            this.paytm11.Load += new System.EventHandler(this.paytm11_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 489);
            this.Controls.Add(this.paytm11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private paytm1 paytm11;
    }
}

