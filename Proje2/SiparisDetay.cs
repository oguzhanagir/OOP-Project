using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class SiparisDetay
    {
        public int SiparisMiktar { get; set; }
        public double VergiDurumu { get; set; }
        public Siparis Siparisim { get; set; }
        public List<Urun> Urunum { get; set; }

        public double agirlik_alt_toplam()
        {
            return 1;
        }

        public double hesap_alt_toplam()
        {
            return 1;
        }

    }
}
