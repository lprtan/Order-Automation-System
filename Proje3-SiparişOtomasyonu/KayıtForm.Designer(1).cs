
namespace Proje3_SiparişOtomasyonu
{
    partial class KayıtForm
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
            this.btnKayitTamamla = new System.Windows.Forms.Button();
            this.txtKayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.txtKayitIsim = new System.Windows.Forms.TextBox();
            this.txtKayitSoyisim = new System.Windows.Forms.TextBox();
            this.txtKayitSehir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKayitTamamla
            // 
            this.btnKayitTamamla.Location = new System.Drawing.Point(173, 229);
            this.btnKayitTamamla.Name = "btnKayitTamamla";
            this.btnKayitTamamla.Size = new System.Drawing.Size(75, 23);
            this.btnKayitTamamla.TabIndex = 0;
            this.btnKayitTamamla.Text = "Kayıt Ol!";
            this.btnKayitTamamla.UseVisualStyleBackColor = true;
            this.btnKayitTamamla.Click += new System.EventHandler(this.btnKayitTamamla_Click);
            // 
            // txtKayitKullaniciAdi
            // 
            this.txtKayitKullaniciAdi.Location = new System.Drawing.Point(121, 26);
            this.txtKayitKullaniciAdi.Name = "txtKayitKullaniciAdi";
            this.txtKayitKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKayitKullaniciAdi.TabIndex = 1;
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(121, 56);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(100, 20);
            this.txtKayitSifre.TabIndex = 2;
            // 
            // txtKayitIsim
            // 
            this.txtKayitIsim.Location = new System.Drawing.Point(121, 94);
            this.txtKayitIsim.Name = "txtKayitIsim";
            this.txtKayitIsim.Size = new System.Drawing.Size(100, 20);
            this.txtKayitIsim.TabIndex = 3;
            // 
            // txtKayitSoyisim
            // 
            this.txtKayitSoyisim.Location = new System.Drawing.Point(121, 131);
            this.txtKayitSoyisim.Name = "txtKayitSoyisim";
            this.txtKayitSoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtKayitSoyisim.TabIndex = 4;
            // 
            // txtKayitSehir
            // 
            this.txtKayitSehir.Location = new System.Drawing.Point(121, 166);
            this.txtKayitSehir.Name = "txtKayitSehir";
            this.txtKayitSehir.Size = new System.Drawing.Size(100, 20);
            this.txtKayitSehir.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "İsim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soyisim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şehir :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnKayitTamamla);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKayitKullaniciAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKayitSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKayitIsim);
            this.groupBox1.Controls.Add(this.txtKayitSoyisim);
            this.groupBox1.Controls.Add(this.txtKayitSehir);
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 281);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt";
            // 
            // KayıtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 351);
            this.Controls.Add(this.groupBox1);
            this.Name = "KayıtForm";
            this.Text = "KayıtForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtKayitKullaniciAdi;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.TextBox txtKayitIsim;
        private System.Windows.Forms.TextBox txtKayitSoyisim;
        private System.Windows.Forms.TextBox txtKayitSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnKayitTamamla;
    }
}