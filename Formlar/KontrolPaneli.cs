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
    public partial class KontrolPaneli : Form
    {
        public KontrolPaneli()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            _ürünDal.UrunEkle(new Urun
            {
                UrunAdi = tbxUrunAd.Text,
                UrunStok = Convert.ToInt32(tbxUrunStok.Text),
                UrunFiyat = Convert.ToDecimal(tbxUrunfiyat.Text),
                Urunagirlik = Convert.ToSingle(tbxUrunAgirlik.Text)
            });
            ÜrünleriListele();
            MessageBox.Show("Ürün Başarılı Bir Şekilde Eklendi");
        }

        ÜrünDal _ürünDal = new ÜrünDal();
        private void btnListele_Click(object sender, EventArgs e)
        {
            ÜrünleriListele();
        }

        private void ÜrünleriListele()
        {
            dataGridView1.DataSource = _ürünDal.HepsiniAl();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {

            PanelGiris panelGiris = new PanelGiris();
            this.Hide();
            panelGiris.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun
            {
                UrunID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                UrunAdi = tbxUrunAd.Text,
                UrunFiyat = Convert.ToDecimal(tbxUrunfiyat.Text),
                UrunStok = Convert.ToInt32(tbxUrunStok.Text),
                Urunagirlik = Convert.ToSingle(tbxUrunAgirlik.Text)
            };

            _ürünDal.UrunGüncelle(urun);
            ÜrünleriListele();
            MessageBox.Show("Ürün Güncelleme Başarılı Bir Şekilde Yapıldı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUrunAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxUrunStok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxUrunfiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxUrunAgirlik.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            _ürünDal.UrunSil(id);
            ÜrünleriListele();
            MessageBox.Show("Ürün Silme Başarılı Bir Şekilde Gerçekleşti");
        }

        private void KontrolPaneli_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();     
        }
        private void btniptal_Click(object sender, EventArgs e)
        {
            
                tbxUrunAd.Text = null;
                tbxUrunStok.Text = null;
                tbxUrunfiyat.Text = null;
                tbxUrunAgirlik.Text = null;
            
        }
      
        private void button2_Click(object sender, EventArgs e)
        {

            PanelGiris panelGiris = new PanelGiris();
            this.Hide();
            panelGiris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
