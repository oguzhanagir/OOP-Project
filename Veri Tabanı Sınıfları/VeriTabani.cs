using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2.Veri_Tabanı_Sınıfları
{
    public class VeriTabani
    {
        public SqlConnection Baglanti()
        {
            SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=Proje1;integrated security=true");
            _connection.Open();

            return _connection;
        }
        public void BaglantiKontrol()
        {
            if (Baglanti().State == ConnectionState.Closed)
            {
                Baglanti().Open();
            }        
        }
    }
}
