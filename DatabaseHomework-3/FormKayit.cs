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
    public partial class FormKayit : Form
    {
        //  public Yemekhane yemekhane = new Yemekhane();
        Form1 giris;
        Giris_Kayit_DB giris_kayit;
        public FormKayit()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            giris_kayit = new Giris_Kayit_DB();
            giris_kayit.kullanici_ekle(txtName.Text, txtSurname.Text, txtMail.Text, txtTelefon.Text, txtPassword.Text);
            giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            giris = new Form1();
            giris.Show();
            this.Hide();
        }
    }
}
