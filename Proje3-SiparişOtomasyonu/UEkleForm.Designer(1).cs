
namespace Proje3_SiparişOtomasyonu
{
    partial class UEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunEkleAd = new System.Windows.Forms.TextBox();
            this.txtUrunEkleFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunEkleAgirlik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürünün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürünün Fiyatı  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürünün Ağırlığı :";
            // 
            // txtUrunEkleAd
            // 
            this.txtUrunEkleAd.Location = new System.Drawing.Point(300, 137);
            this.txtUrunEkleAd.Name = "txtUrunEkleAd";
            this.txtUrunEkleAd.Size = new System.Drawing.Size(100, 20);
            this.txtUrunEkleAd.TabIndex = 3;
            // 
            // txtUrunEkleFiyat
            // 
            this.txtUrunEkleFiyat.Location = new System.Drawing.Point(300, 174);
            this.txtUrunEkleFiyat.Name = "txtUrunEkleFiyat";
            this.txtUrunEkleFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtUrunEkleFiyat.TabIndex = 4;
            // 
            // txtUrunEkleAgirlik
            // 
            this.txtUrunEkleAgirlik.Location = new System.Drawing.Point(300, 216);
            this.txtUrunEkleAgirlik.Name = "txtUrunEkleAgirlik";
            this.txtUrunEkleAgirlik.Size = new System.Drawing.Size(100, 20);
            this.txtUrunEkleAgirlik.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUrunEkleAgirlik);
            this.Controls.Add(this.txtUrunEkleFiyat);
            this.Controls.Add(this.txtUrunEkleAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UEkleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtUrunEkleAd;
        public System.Windows.Forms.TextBox txtUrunEkleFiyat;
        public System.Windows.Forms.TextBox txtUrunEkleAgirlik;
    }
}