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
    public partial class SirketSahibiKontrolPaneli : Form
    {
        public SirketSahibiKontrolPaneli()
        {
            InitializeComponent();
        }

        private void btnmusteritakip_Click(object sender, EventArgs e)
        {
            MusteriTakip mt = new MusteriTakip();
            mt.Show();
            this.Hide();

        }

        private void btnUrunlistele_Click(object sender, EventArgs e)
        {
            KontrolPaneliUrun kpu = new KontrolPaneliUrun();
            kpu.Show();
            this.Hide();
        }

        private void SirketSahibiKontrolPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
