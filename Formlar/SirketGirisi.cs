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
    public partial class SirketGirisi : Form
    {
        GirisYap _girisYap = new GirisYap();
        private string KullaniciAdi = "admin";
        private string AdminSifre = "1234";
        public SirketGirisi()
        {
            InitializeComponent();
        }

        private void btnadmingrs_Click(object sender, EventArgs e)
        {
            PanelGiris panelGiris = new PanelGiris();
            this.Hide();
            panelGiris.Show();
        }

        private void btnadmingrs_Click_1(object sender, EventArgs e)
        {
            if (textBoxkullaniciad.Text == KullaniciAdi && textBoxsifre.Text == AdminSifre)
            {
                PanelGiris panelGiris = new PanelGiris();
                this.Hide();
                panelGiris.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
           
        }
        private void textBoxkullaniciad_TextChanged(object sender, EventArgs e)
        {
            _girisYap.BoslukKontrolu(textBoxkullaniciad.Text);
        }

        private void textBoxsifre_TextChanged(object sender, EventArgs e)
        {
            _girisYap.BoslukKontrolu(textBoxsifre.Text);
        }
        private void textBoxkullaniciad_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxkullaniciad.Text = "";
            textBoxkullaniciad.ForeColor = Color.White;
        }
        private void SirketGirisi_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxsifre.Text = "";
            textBoxsifre.ForeColor = Color.White;
        }

        private void buttongeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Close();
            anaSayfa.Show();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
