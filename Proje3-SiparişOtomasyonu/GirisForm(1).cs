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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        public string GirisYapanKullanici;
        public string isim;
        public string soyisim;
        private void GirisForm_Load(object sender, EventArgs e)
        {

            GirisYapanKullanici = Form1.girenkullanici;
            string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
            foreach (string line in hepsi)
            {
                if (line.StartsWith(GirisYapanKullanici))
                {

                        if (line.Split(' ').Count() > 4)
                        {
                            isim = line.Split(' ')[2];
                            soyisim = line.Split(' ')[3];
                            break;
                        }

                }
            }

                lblGirisYapanKullanici.Text = "Hoşgeldiniz Sayın " + isim + " " + soyisim;

        }
    }
}


