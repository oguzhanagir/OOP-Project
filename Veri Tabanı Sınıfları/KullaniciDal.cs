using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    class KullaniciDal : Veri_Tabanı_Sınıfları.VeriTabani
    {      

        
        public bool _isThere;
        
        public List<Musteri> BütünKullaniciListele()
        {
            BaglantiKontrol();
            SqlCommand command = new SqlCommand("Select * from Users",Baglanti());
            SqlDataReader reader = command.ExecuteReader();

            List<Musteri> musteris = new List<Musteri>();

            while (reader.Read())
            {
                Musteri musteri = new Musteri
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    ePosta = reader["ePosta"].ToString(),
                    Sifre = reader["Sifre"].ToString(),
                    TelefonNo = Convert.ToInt32(reader["TelefonNo"]),
                    İl = reader["İl"].ToString(),
                    İlce = reader["İlce"].ToString(),
                    PostaKodu = Convert.ToInt32(reader["PostaKodu"]),
                    Adres = reader["Adres"].ToString()

                };
                musteris.Add(musteri);
            }
            reader.Close();
            Baglanti().Close();

            return musteris;
        }


        public void KullaniciEkle(Musteri musteri)
        {
            BaglantiKontrol();

            SqlCommand command =
                new SqlCommand(
                    "Insert into Users values(@Ad,@Soyad,@ePosta,@Sifre,@TelefonNo,@İl,@İlce,@PostaKodu,@Adres) ",
                    Baglanti());
            command.Parameters.AddWithValue("@Ad", musteri.Ad);
            command.Parameters.AddWithValue("@Soyad", musteri.Soyad);
            command.Parameters.AddWithValue("@ePosta", musteri.ePosta);
            command.Parameters.AddWithValue("@Sifre", musteri.Sifre);
            command.Parameters.AddWithValue("@TelefonNo", musteri.TelefonNo);
            command.Parameters.AddWithValue("@İl", musteri.İl);
            command.Parameters.AddWithValue("@İlce", musteri.İlce);
            command.Parameters.AddWithValue("@PostaKodu", musteri.PostaKodu);
            command.Parameters.AddWithValue("@Adres", musteri.Adres);

            command.ExecuteNonQuery();
            Baglanti().Close();
        }

        public void KullaniciGüncelle(Musteri musteri)
        {
            BaglantiKontrol();

            SqlCommand command =
                new SqlCommand(
                    "Update Users set Ad=@Ad, Soyad=@Soyad, ePosta=@ePosta, Sifre=@Sifre, TelefonNo=@TelefonNo, İl=@İl, İlce=@İlce, PostaKodu=@PostaKodu, Adres=@Adres where ID=@id ",
                    Baglanti());
            command.Parameters.AddWithValue("@id", musteri.Id);
            command.Parameters.AddWithValue("@Ad", musteri.Ad);
            command.Parameters.AddWithValue("@Soyad", musteri.Soyad);
            command.Parameters.AddWithValue("@ePosta", musteri.ePosta);
            command.Parameters.AddWithValue("@Sifre", musteri.Sifre);
            command.Parameters.AddWithValue("@TelefonNo", musteri.TelefonNo);
            command.Parameters.AddWithValue("@İl", musteri.İl);
            command.Parameters.AddWithValue("@İlce", musteri.İlce);
            command.Parameters.AddWithValue("@PostaKodu", musteri.PostaKodu);
            command.Parameters.AddWithValue("@Adres", musteri.Adres);
            command.ExecuteNonQuery();
            Baglanti().Close();

        }

        
        public void KullaniciSil(int id)
        {
            BaglantiKontrol();

            SqlCommand command = new SqlCommand("Delete from Users where ID=@id", Baglanti());        
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            Baglanti().Close();
        }

        public void KullaniciKontrol(string ePosta, string Sifre)
        {
            BaglantiKontrol();
            
          

            SqlCommand command = new SqlCommand("Select * from Users ", Baglanti());
            SqlDataReader reader = command.ExecuteReader();
           

            while (reader.Read())
            {
                    if (ePosta==reader["ePosta"].ToString().TrimEnd() && Sifre==reader["Sifre"].ToString().TrimEnd())
                    {
                        
                        _isThere = true;
                        
                        break;
                
                    }
                    else
                    {
                        _isThere = false;
                    }
            }
            reader.Close();      
            Baglanti().Close();
          
        }

        
    }
}
