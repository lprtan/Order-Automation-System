using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Cek: Odeme
    {
        public string CekAd { get; set; }
        public ulong BankaID { get; set; }

        public override void Yetkili()
        {

        }

    }
}
