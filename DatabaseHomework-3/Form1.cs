using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseHomework_3
{
    public partial class Form1 : Form
    {
        public Yemekhane yemekhane;
        public FormKayit kayit;
        public YoneticiPaneli yoneticipaneli;
        DatabaseIslemleri db;
        Yonetici_Kategori yonetici_kategori;
        Yonetici_Urun yonetici_urun;
        Yonetici_Yemekhane yonetici_yemekhane;
        Giris_Kayit_DB giris_kayit;
        Yonetici_Giris yonetici_giris;

        public Form1()
        {
            InitializeComponent();
            db = new DatabaseIslemleri();
            db.baglan();

        }
        
        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            kayit = new FormKayit();
            kayit.Show();
            this.Hide();
        } //yeni kayıt olacaklar için

        private void lblGiris_Click(object sender, EventArgs e)
        {
            yoneticipaneli = new YoneticiPaneli();
            yoneticipaneli.Show();
            this.Hide();
        } 

        private void btnGiris_Click(object sender, EventArgs e)// şifre ve idyi başarılı bir şekilde girenler için
        {
            giris_kayit = new Giris_Kayit_DB();
            giris_kayit.kullanici_giris_kontrol(txtMail.Text, txtPassword.Text);
        }

        private void pctYoneticiPanelineGit_Click(object sender, EventArgs e)
        {
            yonetici_giris = new Yonetici_Giris();
            yonetici_giris.Show();
            this.Hide();
        }
    }
}
