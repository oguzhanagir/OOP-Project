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
        public int VergiTutarı { get; set; }
        public int ToplamTutar { get; set; }
        public int ToplamAgirlik { get; set; }
        public Musteri Musteri { get; set; }
        public List<ÖdemeYöntemleri> ÖdemeYöntemleris { get; set; }


        public int VergiHesapla()
        {


            

            return VergiTutarı;
        }


        public int ToplamıHesapla()
        {



            return ToplamTutar;
        }


        public int ToplamAgirligiHesapla()
        {



            return ToplamAgirlik;
        }


    }

}