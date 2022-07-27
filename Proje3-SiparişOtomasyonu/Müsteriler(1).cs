using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Müsteriler
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Sehir { get; set; }




        public Müsteriler()
        {
            Kredi k = new Kredi();
            Nakit n = new Nakit();
            Cek c = new Cek();
        }

    }
}
