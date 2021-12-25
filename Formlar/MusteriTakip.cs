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
    public partial class MusteriTakip : Form
    {
        public MusteriTakip()
        {
            InitializeComponent();
        }

        KullaniciDal _kullaniciDal = new KullaniciDal();
        private void MusteriTakip_Load(object sender, EventArgs e)
        {
            dgwKullaniciListe.DataSource = _kullaniciDal.BütünKullaniciListele();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            PanelGiris panelGiris = new PanelGiris();
            this.Close();
            panelGiris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
