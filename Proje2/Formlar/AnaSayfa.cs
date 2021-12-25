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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

      
        private void btnMüsteriGirisi_Click(object sender, EventArgs e)
        {
            MüsteriGirisi müsteriGirisi = new MüsteriGirisi();
            müsteriGirisi.Show();
            this.Hide();

            //Form geçişleri mdı child şekline çevirelecek 
           
        }

        private void btnSirketSahibi_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
