using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class SiparisDetayi : Form
    {

        public string _SiparisÜrünAd;      
        public int _SiparisÜrünAdet;
        public decimal _SiparisÜrünFiyat;
        public float _SiparisÜrünAgirlik;

        

       

        
        Siparis _siparis = new Siparis();
        KapidaÖdeme _kapidaÖdeme = new KapidaÖdeme();
        Formlar.MüsteriSayfasi _müsteriSayfasi = new Formlar.MüsteriSayfasi();

        public SiparisDetayi()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnBitis.Text = "Ödeme Ekranına Git";
            lblÖdemeBilgi.Text = null;
            lblKapıdaÖdeme.Text = null;
            lblToplamTutar.Text = _siparis.ToplamıHesapla(_SiparisÜrünFiyat, _SiparisÜrünAdet).ToString();
        }

        

     
        
      
        private void SiparisDetayi_Load(object sender, EventArgs e)
        {
            

            //Sipariş Detay Listelenmesi

            lblÜrünAd.Text = _SiparisÜrünAd;
            lblAdet.Text = _SiparisÜrünAdet.ToString();
            lblÜrününFiyati.Text = _SiparisÜrünFiyat.ToString();
            lblVergiTutari.Text = _siparis.VergiHesapla(Convert.ToDecimal(_SiparisÜrünFiyat),_SiparisÜrünAdet).ToString();
            lblToplamAgirlik.Text = _SiparisÜrünAgirlik.ToString();
            lblKargoÜcreti.Text = "Kargo Ücreti 10 TL";

            
            lblToplamTutar.Text = _siparis.ToplamıHesapla(_SiparisÜrünFiyat, _SiparisÜrünAdet).ToString();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formlar.MüsteriSayfasi müsteriSayfasi = new Formlar.MüsteriSayfasi();
            this.Hide();
            müsteriSayfasi.Show();    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBitis_Click_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                btnBitis.Text = "Sipariş Ver";
                MessageBox.Show("Siparişiniz Başarılı Şekilde Alındı Bizi Tercih Ettiğiniz İçin Teşekkürler");
                this.Hide();
                _müsteriSayfasi.Show();
            }
            else if (checkBox2.Checked == true)
            {
                btnBitis.Text = "Sipariş Ver";
                MessageBox.Show("Siparişiniz Başarılı Şekilde Alındı Bizi Tercih Ettiğiniz İçin Teşekkürler");
                this.Hide();
                _müsteriSayfasi.Show();
            }

            else if (checkBox1.Checked == true)
            {
                Formlar.KrediKartiÖdemeForm krediKartiÖdemeForm = new Formlar.KrediKartiÖdemeForm();
                this.Hide();
                krediKartiÖdemeForm.Show();
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            btnBitis.Text = "Sipariş Ver";
            lblÖdemeBilgi.Text = _kapidaÖdeme.KapidaÖdemeBilgiGöster();
            lblKapıdaÖdeme.Text = _kapidaÖdeme.KapidaÖdemeMiktari.ToString();
            lblToplamTutar.Text = _kapidaÖdeme.KapidaÖdemeTutariToplam(_SiparisÜrünFiyat, _SiparisÜrünAdet).ToString();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            HavaleÖdeme havaleÖdeme = new HavaleÖdeme();
            btnBitis.Text = "Sipariş Ver";
            lblÖdemeBilgi.Text = havaleÖdeme.HavaleBilgi();
            lblKapıdaÖdeme.Text = null;
            lblToplamTutar.Text = _siparis.ToplamıHesapla(_SiparisÜrünFiyat, _SiparisÜrünAdet).ToString();
        }
    }
}
