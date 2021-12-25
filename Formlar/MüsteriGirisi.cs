using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proje2.Formlar;

namespace Proje2
{
    public partial class MüsteriGirisi : Form
    {
        GirisYap _girisYap = new GirisYap();
        public string _MüsteriEposta;
        
        public MüsteriGirisi()
        {
            InitializeComponent();
        }

        private void txbePosta_TextChanged(object sender, EventArgs e)
        {
            _girisYap.BoslukKontrolu(txbePosta.Text);
        }

        private void txbSifre_TextChanged(object sender, EventArgs e)
        {          
            _girisYap.BoslukKontrolu(txbSifre.Text);
        }

        private void txbePosta_MouseClick(object sender, MouseEventArgs e)
        {
            txbePosta.Text = "";
            txbePosta.ForeColor = Color.White;
        }

        private void txbSifre_MouseClick(object sender, MouseEventArgs e)
        {
            txbSifre.Text = "";
            txbSifre.ForeColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Close();
            anaSayfa.Show();
        }

        private void btbGiris_Click_1(object sender, EventArgs e)
        {
            KullaniciDal kullaniciDal = new KullaniciDal();
            kullaniciDal.KullaniciKontrol(txbePosta.Text, txbSifre.Text);
            Musteri musteri = new Musteri();

            if (kullaniciDal._isThere)
            {
                MessageBox.Show("Başarılı Bir Şekilde Giriş Yaptınız.");

                musteri.Ad = txbePosta.Text;

                MüsteriSayfasi musteriSayfasi = new MüsteriSayfasi();   
                this.Hide();
                musteriSayfasi.Show();
            }
            else
            {
                MessageBox.Show("Hatalı e-posta veya şifre!");
            }

        }

        private void btnUyeOl_Click_1(object sender, EventArgs e)
        {
            UyeOlForm uyeOl = new UyeOlForm();
            this.Hide();
            uyeOl.Show();
        }
    }
}
