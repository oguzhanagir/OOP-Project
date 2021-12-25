using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class HavaleÖdeme : ÖdemeYöntemleri
    {
        
        public string HavaleAd { get; set; } 
        public override void Yetkilendirme()
        {
            base.Yetkilendirme();
        }

        public string HavaleBilgi()
        {
            HavaleAd = "---- Numaralı Banka Id";
            return HavaleAd;
        }
    }
}
