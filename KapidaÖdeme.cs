using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class KapidaÖdeme : ÖdemeYöntemleri
    {
        public int KapidaÖdemeMiktari = 10;
        public int KapidaÖdemeEkTutar { get; set; }
        public string KapidaÖdemeBilgi { get; set; }

        public decimal KapidaÖdemeTutariToplam(decimal _fiyat, int _adet)
        {
            Siparis siparis = new Siparis();
            KapidaÖdemeEkTutar = Convert.ToInt32(siparis.ToplamıHesapla(_fiyat, _adet)) + KapidaÖdemeMiktari;

            return KapidaÖdemeEkTutar; 
        }
        public string KapidaÖdemeBilgiGöster()
        {
            KapidaÖdemeBilgi = "Kapıda Ödeme Tutarı 10 TL";

            return KapidaÖdemeBilgi;
        }
    }   
}
