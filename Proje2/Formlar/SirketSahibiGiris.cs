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
    public partial class SirketSahibiGiris : Form
    {
        public SirketSahibiGiris()
        {
            InitializeComponent();
        }

        private void SirketSahibiGiris_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }

        private void btnadmingrs_Click(object sender, EventArgs e)
        {
            if(textBoxkullaniciad.Text=="admin" && textBoxsifre.Text ==".")
            {
           
                SirketSahibiKontrolPaneli kontrolpaneli = new SirketSahibiKontrolPaneli();
                 kontrolpaneli.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya Şifre girdiniz","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Information) ;
            }
        }
    }
}
