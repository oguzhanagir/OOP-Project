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
        
    public partial class KrediKartiÖdemeForm : Form
    {  
        GirisYap _girisYap = new GirisYap();
        public KrediKartiÖdemeForm()
        {
            InitializeComponent();
        }
         
       
        private void button2_Click(object sender, EventArgs e)
        {
            SiparisDetayi siparisDetayi = new SiparisDetayi();
            this.Hide();
            siparisDetayi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbAd_TextChanged(object sender, EventArgs e)
        {
            _girisYap.BoslukKontrolu(txbAd.Text);
        }

        private void txbSoyad_TextChanged(object sender, EventArgs e)
        {
            _girisYap.BoslukKontrolu(txbSoyad.Text);
        }

        private void txbKrediKartiNo_TextChanged(object sender, EventArgs e)
        {
            _girisYap.BoslukKontrolu(txbKrediKartiNo.Text);
        }

        private void txbSonKullanmaTarihi_TextChanged(object sender, EventArgs e)
        {
            _girisYap.BoslukKontrolu(txbSonKullanmaTarihi.Text);
        }

        private void txbGüvenlikKodu_TextChanged(object sender, EventArgs e)
        {
            _girisYap.BoslukKontrolu(txbGüvenlikKodu.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MüsteriSayfasi müsteriSayfasi = new MüsteriSayfasi();
            MessageBox.Show("Siparişiniz verildi!");
            this.Hide();
            müsteriSayfasi.Show();
        }
    }
}
