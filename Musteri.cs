using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; } 
        public string Soyad { get; set; } 
        public string ePosta { get; set; } 
        public string Sifre { get; set; } 
        public int TelefonNo { get; set; } 
        public string İl { get; set; } 
        public string İlce { get; set; } 
        public int PostaKodu { get; set; } 
        public string Adres { get; set; }
        public List<Siparis> Siparis { get; set; }

    }
}
