using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Magaza
    {
        public List<Müsteriler> MusteriListesi;

        public void MusteriEkle(Müsteriler a)
        {
            MusteriListesi.Add(a);
        }
        public List<Müsteriler> MusterileriKontrol()
        {
            return MusteriListesi;
        }



        public Magaza()
        {
            MusteriListesi = new List<Müsteriler>();
        }




    }
}
