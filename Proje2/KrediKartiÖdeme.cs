using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class KrediKartiÖdeme : ÖdemeYöntemleri
    {
        public int KrediKartiNo { get; set; }
        public string KrediKartiAdi { get; set; }
        public string KrediKartiSoyadi { get; set; }
        public DateTime KrediKartiSonKullanmaTarihi { get; set; }

        public override void Yetkilendirme()
        {
            base.Yetkilendirme();
        }
    }
}
