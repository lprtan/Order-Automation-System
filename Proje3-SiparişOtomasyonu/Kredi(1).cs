using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Kredi : Odeme
    {
        public ulong KartNumarasi { get; set; }
        public string Tip { get; set; }

        public string SonKullanmaTarih { get; set; }

        public override void Yetkili()
        {
            
        }
    }
}
