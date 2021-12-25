using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    public class Urun
    {
        public int UrunID  { get; set; }
        public string UrunAdi { get; set; }
        public int UrunStok { get; set; }
        public decimal UrunFiyat { get; set; }
        public float Urunagirlik { get; set; }
        
        //public float agirlikAl()
        //{
        //    //Eklenecek
        //    return Urunagirlik;
        //}

        //public decimal FiyatAl()
        //{
        //    //Eklenecek
        //    return UrunFiyat;
        //}
    }
}
