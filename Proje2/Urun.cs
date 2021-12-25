using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Urun
    {
        public    int UrunID  { get; set; }
        public string UrunAdi { get; set; }
        public string Uruncesidi { get; set; }
        public    int Urunstok { get; set; }
        public double UrunFiyat { get; set; }
        public double Urunagirlik { get; set; }

        public double fiyatAta()
        {
            return UrunFiyat;
        }

        public double agirlikAl()
        {
            return Urunagirlik;
        }

    }
}
