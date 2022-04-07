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
    public partial class Yonetici_Urun : Form
    {
        YoneticiPaneli yoneticipaneli;
        DatabaseIslemleri db = new DatabaseIslemleri();
        public Yonetici_Urun()
        {
            InitializeComponent();
            db.urun_listele(dataGridUrunler);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            yoneticipaneli = new YoneticiPaneli();
            yoneticipaneli.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
         //   StaticVeriler.degisken1 = txtUrunId.Text;
            StaticVeriler.degisken2 = txtUrunAdi.Text;
            StaticVeriler.degisken3 = txtUrunFiyat.Text;
            StaticVeriler.degisken4 = txtUrunKategori.Text;
            db.urun_ekle(dataGridUrunler);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.sil(dataGridUrunler, "Product", txtUrunId.Text, "product_id");
            txtUrunId.Clear();
            txtUrunAdi.Clear();
            txtUrunFiyat.Clear();
            txtUrunKategori.Clear();
        }

        private void dataGridUrunler_Click(object sender, EventArgs e)
        {
            txtUrunId.Text = dataGridUrunler.CurrentRow.Cells[0].Value.ToString();
            txtUrunAdi.Text = dataGridUrunler.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyat.Text = dataGridUrunler.CurrentRow.Cells[2].Value.ToString();
            txtUrunKategori.Text = dataGridUrunler.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            StaticVeriler.degisken1 = txtUrunId.Text;
            StaticVeriler.degisken2 = txtUrunAdi.Text;
            StaticVeriler.degisken3 = txtUrunFiyat.Text;
            StaticVeriler.degisken4 = txtUrunKategori.Text;
            db.urun_guncelle(dataGridUrunler, "Product");
        }
    }
}
