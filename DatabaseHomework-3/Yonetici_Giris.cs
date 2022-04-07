using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseHomework_3
{
    public partial class Yonetici_Giris : Form
    {
        YoneticiPaneli yonetici_panel;
        string sifre = "yoneticisifre2021";
        Form1 giris;
        public Yonetici_Giris()
        {
            InitializeComponent();
            btnOk.Enabled = false;
        }

        private void btnYoneticiPanelineGit_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Equals(sifre))
            {
                yonetici_panel = new YoneticiPaneli();
                yonetici_panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen şifreyi doğru girdiğinizden emin olunuz!");
            }
        }

        private void btnSifreyiDegistir_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Equals(sifre))
            {
                txtSifre.Clear();
                MessageBox.Show("Yeni şifreyi giriniz!");
                btnOk.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen önce geçerli şifreyi girip ardından şifreyi değiştir butonuna tıklayınız!");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            sifre = txtSifre.Text;
            MessageBox.Show("Şifreniz değiştirildi...");
        }

        private void pctGeriDon_Click(object sender, EventArgs e)
        {
            giris= new Form1();
            giris.Show();
            this.Hide();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
