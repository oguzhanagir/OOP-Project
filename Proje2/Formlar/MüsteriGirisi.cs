using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje2.Formlar;

namespace Proje2
{
    public partial class MüsteriGirisi : Form
    {
        public MüsteriGirisi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MüsteriGirisi_Load(object sender, EventArgs e)
        {

        }

        private void btbGiris_Click(object sender, EventArgs e)
        {
             MusteriSayfası musteriSayfasi = new MusteriSayfası();
             musteriSayfasi.Show();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
           UyeOlForm uyeOl = new UyeOlForm();
            uyeOl.Show();
        }
    }
}
