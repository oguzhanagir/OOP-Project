using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    enum SiparisDurumu
    {
        TeslimEdildi,
        KargoyaVerildi,
        İptalEdildi,
        GeriIade
    }
    class Siparis
    {
        private const double VERGİORANI = 0.18;
        public DateTime Tarih { get; set; }

        public int KargoTutari = 10;
        public double VergiTutarı { get; set; }
        public decimal ToplamTutar { get; set; }
        public float ToplamAgirlik { get; set; }
        public Musteri Musteri { get; set; }
        public List<ÖdemeYöntemleri> ÖdemeYöntemleris { get; set; }

        public double VergiHesapla(decimal _fiyat, int _adet)
        {
            //Ürünün fiyatına göre  vergi hesaplama
            VergiTutarı = Convert.ToDouble(_fiyat) * VERGİORANI;

            return VergiTutarı;
        }


        public decimal ToplamıHesapla(decimal _fiyat, int _adet)
        {
            // Vergi tutarı + Ürünün fiyatı hesaplama

            decimal toplamfiyat = _fiyat * _adet + KargoTutari;
            ToplamTutar=toplamfiyat + Convert.ToDecimal( VergiHesapla(_fiyat,_adet));  

            return ToplamTutar;
        }


        public float ToplamAgirligiHesapla(float agirlik, int _miktar)
        {
            //Ürünün toplam ağırlını hesaplama    
            ToplamAgirlik = agirlik * _miktar;

            return ToplamAgirlik;
        }
    }
}