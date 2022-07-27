using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Sipariş
    {
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }

        public Sipariş()
        {
            SiparisDetayi siparisdetayi = new SiparisDetayi();
        }
        public decimal VergiHesaplama()
        {
            return 0;
        }

        public decimal HamHesap()
        {
            return 0;
        }

        public decimal ToplamHesap()
        {
            return 0;
        }
    }
}
