using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proje3_SiparişOtomasyonu
{
    public partial class UEkleForm : Form
    {
        public UEkleForm()
        {
            InitializeComponent();
        }
        public string GirisYapanKullanici;
        private void button1_Click(object sender, EventArgs e)
        {
            GirisYapanKullanici = Form1.girenkullanici;

            string filePath = Application.StartupPath + "\\veri.txt";
            string [] lines = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(GirisYapanKullanici))
                    lines[i] = lines[i] + " " + txtUrunEkleAd.Text + " " + txtUrunEkleFiyat.Text + " " + txtUrunEkleAgirlik.Text;
                MessageBox.Show("Ürününüz Başarıyla Eklenmiştir...");
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}
