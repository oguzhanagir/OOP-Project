using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2.Formlar
{
    public partial class UyeOlForm : Form
    {
        GirisYap _girisYap = new GirisYap();
        KullaniciDal _kullaniciDal = new KullaniciDal();
        public UyeOlForm()
        {
            InitializeComponent();
        }
        

        private void txbName_TextChanged(object sender, EventArgs e)
        {           
            _girisYap.BoslukKontrolu(txbName.Text);
        }

        private void txbSurname_TextChanged(object sender, EventArgs e)
        {  
            _girisYap.BoslukKontrolu(txbSurname.Text);
        }

        private void txbUeP_TextChanged_1(object sender, EventArgs e)
        {       
            _girisYap.BoslukKontrolu(txbUeP.Text);
        }

        private void txbUS_TextChanged(object sender, EventArgs e)
        {            
            _girisYap.BoslukKontrolu(txbUS.Text);
        }

        private void txbTelNo_TextChanged(object sender, EventArgs e)
        {           
            _girisYap.BoslukKontrolu(txbTelNo.ToString());

        }

        private void txbil_TextChanged(object sender, EventArgs e)
        {           
            _girisYap.BoslukKontrolu(txbil.Text);
        }

        private void txbilce_TextChanged(object sender, EventArgs e)
        {         
            _girisYap.BoslukKontrolu(txbilce.Text);
        }

        private void txbPostaKodu_TextChanged(object sender, EventArgs e)
        {    
            _girisYap.BoslukKontrolu(txbPostaKodu.Text);
        }

        private void txbAdres_TextChanged(object sender, EventArgs e)
        {   
            _girisYap.BoslukKontrolu(txbAdres.Text);
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUyeOl_Click_1(object sender, EventArgs e)
        {

            if (radioButton2.Checked != true)
            {

                MessageBox.Show("Sözleşmeyi kabul etmeden üye olamazsınız!");
            }
            else
            {
                _kullaniciDal.KullaniciEkle(new Musteri
                {
                    Ad = txbName.Text,
                    Soyad = txbSurname.Text,
                    ePosta = txbUeP.Text,
                    Sifre = txbUS.Text,
                    TelefonNo = Convert.ToInt32(txbTelNo.Text),
                    İl = txbil.Text,
                    İlce = txbilce.Text,
                    PostaKodu = Convert.ToInt32(txbPostaKodu.Text),
                    Adres = txbAdres.Text
                });
                MessageBox.Show("Üye oldunuz, keyifli alışverişler dileriz!");
                MüsteriSayfasi musteriSayfasi = new MüsteriSayfasi();
                this.Hide();
                musteriSayfasi.Show();
            }
        }
    }
}
