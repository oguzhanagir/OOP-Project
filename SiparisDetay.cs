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



        //public decimal agirlik_alt_toplam(string adi,int miktarim)
        //{
        //    decimal fiyatim= Urunum.Find(i => i.UrunAdi == adi).FiyatAl();

        //    return fiyatim*miktarim;
        //    //Eklenecek
        //}

        //public double hesap_alt_toplam(string adi, int miktarim)
        //{
        //    double kilo = Urunum.Find(i => i.UrunAdi == adi).agirlikAl();

        //    return kilo * miktarim;
        //}
    }
}
