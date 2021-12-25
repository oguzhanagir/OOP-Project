using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    class GirisYap
    {
       
        public void BoslukKontrolu(string x)
        {
            if (x == "")
            {
                MessageBox.Show("Boş bırakmayınız!");            
            }
        }
    }
}
