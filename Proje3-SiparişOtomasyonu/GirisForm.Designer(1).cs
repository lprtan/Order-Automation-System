
namespace Proje3_SiparişOtomasyonu
{
    partial class GirisForm
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
            this.lblGirisYapanKullanici = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGirisYapanKullanici
            // 
            this.lblGirisYapanKullanici.AutoSize = true;
            this.lblGirisYapanKullanici.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYapanKullanici.Location = new System.Drawing.Point(220, 100);
            this.lblGirisYapanKullanici.Name = "lblGirisYapanKullanici";
            this.lblGirisYapanKullanici.Size = new System.Drawing.Size(304, 33);
            this.lblGirisYapanKullanici.TabIndex = 0;
            this.lblGirisYapanKullanici.Text = "Giris Yapan Kullanıcı İsmi";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.lblGirisYapanKullanici);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GirisForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGirisYapanKullanici;
    }
}