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
    public partial class MüsteriSayfasi : Form
    {
        

        ÜrünDal _ürünDal = new ÜrünDal();
        
        public MüsteriSayfasi()
        {
            InitializeComponent();
        }

        
        private void MusteriSayfası_Load(object sender, EventArgs e)
        {
            MüsteriGirisi müsteriGirisi = new MüsteriGirisi();
            dgwMusteriSayfasi.DataSource = _ürünDal.HepsiniAl();
            
           
        }
        private void dgwMusteriSayfasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblÜrünAd.Text = dgwMusteriSayfasi.CurrentRow.Cells[1].Value.ToString();
            lblÜrünFiyat.Text = dgwMusteriSayfasi.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnBuy_Click_1(object sender, EventArgs e)
        {
            SiparisDetayi siparisDetayi = new SiparisDetayi();

            int _stok = Convert.ToInt32(dgwMusteriSayfasi.CurrentRow.Cells[2].Value) - Convert.ToInt32(txtÜrünAdet.Text);

            Urun urun = new Urun
            {
                UrunID = Convert.ToInt32(dgwMusteriSayfasi.CurrentRow.Cells[0].Value),
                UrunAdi = dgwMusteriSayfasi.CurrentRow.Cells[1].Value.ToString(),
                UrunStok = _stok,
                UrunFiyat = Convert.ToInt32(dgwMusteriSayfasi.CurrentRow.Cells[3].Value),
                Urunagirlik = Convert.ToSingle(dgwMusteriSayfasi.CurrentRow.Cells[4].Value)
            };
            _ürünDal.UrunGüncelle(urun);

            siparisDetayi._SiparisÜrünAd = lblÜrünAd.Text;
            siparisDetayi._SiparisÜrünAdet = Convert.ToInt32(txtÜrünAdet.Text);
            siparisDetayi._SiparisÜrünFiyat = Convert.ToInt32(dgwMusteriSayfasi.CurrentRow.Cells[3].Value);
            siparisDetayi._SiparisÜrünAgirlik = Convert.ToSingle(dgwMusteriSayfasi.CurrentRow.Cells[4].Value);




            this.Hide();
            siparisDetayi.Show();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            MüsteriGirisi müsteriGirisi = new MüsteriGirisi();
            this.Hide();
            müsteriGirisi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
