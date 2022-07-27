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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

            ;

        }

        public static string girenkullanici;
        public bool kontrol = false;
        public void btnGiris_Click(object sender, EventArgs e)
        {
            
            
            string dosyayolu = @Application.StartupPath + "\\veri.txt";
            if (File.Exists(dosyayolu) == false)
            {
                StreamWriter SW;
                SW = File.CreateText(Application.StartupPath + "\\veri.txt");
                SW.Close();
            }
            
            else
            {
                string[] hepsi = File.ReadAllLines(Application.StartupPath + "\\veri.txt");
                foreach (string line in hepsi)
                {
                    if (line.Contains(txtKullaniciAdi.Text + " " + txtSifre.Text))
                    {
                        MessageBox.Show("Giriş Başarılı!\nHoşgeldiniz...");
                        girenkullanici = txtKullaniciAdi.Text;
                        MainForm main = new MainForm();
                        this.Hide();
                        main.Show();
                        kontrol = true;
                        break;
                    }
                    else
                    {
                        kontrol = false;
                    }
                }
                
                    
                }

            

            if (kontrol == false)
            {
                
                MessageBox.Show("Kaydınız Bulunamadı!\nLütfen Kayıt Olunuz...");

            }


        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayıtForm f2 = new KayıtForm();
            this.Hide();
            f2.Show();

        }
    }
}
