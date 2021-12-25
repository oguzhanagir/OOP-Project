using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    abstract class  ÖdemeYöntemleri
    {
        public int Miktar { get; set; }
        public Siparis Siparis { get; set; }
        public virtual void Yetkilendirme()
        {

        }
    }
}
