using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    public class ÜrünDal : Veri_Tabanı_Sınıfları.VeriTabani
    {
      
        public List<Urun> HepsiniAl()
        {
            BaglantiKontrol();
            SqlCommand command = new SqlCommand("Select * from Products", Baglanti());
            SqlDataReader reader =  command.ExecuteReader();
            List<Urun> uruns = new List<Urun>();

            while (reader.Read())
            {
                Urun urun = new Urun
                {
                    UrunID = Convert.ToInt32(reader["Id"]),
                    UrunAdi = reader["Ad"].ToString(),
                    UrunStok = Convert.ToInt32(reader["Stok"]),
                    UrunFiyat = Convert.ToDecimal(reader["Fiyat"]),
                    Urunagirlik = Convert.ToSingle(reader["Agirlik"])
                };
                uruns.Add(urun);
            }
            reader.Close();
            Baglanti().Close();

            return uruns;
        }
     

        public void UrunEkle(Urun urun)
        {
            BaglantiKontrol();

            SqlCommand command = new SqlCommand("Insert into Products values(@Ad,@Stok,@Fiyat,@Agirlik) ", Baglanti());
            command.Parameters.AddWithValue("@Ad", urun.UrunAdi);
            command.Parameters.AddWithValue("@Stok", urun.UrunStok);
            command.Parameters.AddWithValue("@Fiyat", urun.UrunFiyat);
            command.Parameters.AddWithValue("@Agirlik", urun.Urunagirlik);
            command.ExecuteNonQuery();

            Baglanti().Close();
        }

        public void UrunGüncelle(Urun urun)
        {
            BaglantiKontrol();

            SqlCommand command = new SqlCommand("Update Products set Ad=@Ad, Stok=@Stok, Fiyat=@Fiyat, Agirlik=@Agirlik where ID=@id ", Baglanti());
            command.Parameters.AddWithValue("@id", urun.UrunID);
            command.Parameters.AddWithValue("@Ad", urun.UrunAdi);
            command.Parameters.AddWithValue("@Stok", urun.UrunStok);
            command.Parameters.AddWithValue("@Fiyat", urun.UrunFiyat);
            command.Parameters.AddWithValue("@Agirlik", urun.Urunagirlik);
            command.ExecuteNonQuery();

            Baglanti().Close();
        }


        public void UrunSil(int id )
        {
            BaglantiKontrol();
            SqlCommand command = new SqlCommand("Delete from Products where ID=@id", Baglanti());
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            Baglanti().Close();
        }
    }
}
