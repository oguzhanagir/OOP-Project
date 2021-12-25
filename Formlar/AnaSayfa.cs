using Proje2.Formlar;
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
            this.Hide();
            müsteriGirisi.Show();           
        }

        private void btnSirketSahibi_Click(object sender, EventArgs e)
        {  
            SirketGirisi sirketGiris = new SirketGirisi();
            this.Hide();
            sirketGiris.Show();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
