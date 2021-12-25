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
    public partial class PanelGiris : Form
    {
        public PanelGiris()
        {
            InitializeComponent();
        }

        private void btnUrunlistele_Click(object sender, EventArgs e)
        {
            KontrolPaneli kontrolPaneli = new KontrolPaneli();
            this.Hide();
            kontrolPaneli.Show();
        }

        private void btnmusteritakip_Click(object sender, EventArgs e)
        {
            MusteriTakip musteriTakip = new MusteriTakip();
            this.Hide();
            musteriTakip.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SirketGirisi sirketGirisi = new SirketGirisi();
            this.Hide();
            sirketGirisi.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
