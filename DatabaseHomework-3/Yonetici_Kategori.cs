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
    public partial class Yonetici_Kategori : Form
    {
        YoneticiPaneli yoneticiPaneli;
        DatabaseIslemleri db = new DatabaseIslemleri();
        public Yonetici_Kategori()
        {
            InitializeComponent();
            db.listele(dataGridKategori, "Category");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            yoneticiPaneli = new YoneticiPaneli();
            yoneticiPaneli.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            StaticVeriler.degisken1 = txtId.Text;
            StaticVeriler.degisken2 = txtAd.Text;
            db.kategori_ekle(dataGridKategori, "Category");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            StaticVeriler.degisken1 = txtId.Text;
            StaticVeriler.degisken2 = txtAd.Text;
            db.sil(dataGridKategori, "Category", txtId.Text, "category_id");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            StaticVeriler.degisken1 = txtId.Text;
            StaticVeriler.degisken2 = txtAd.Text;
            db.kategori_guncelle(dataGridKategori, "Category");
        }

        private void dataGridKategori_Click(object sender, EventArgs e) //datagridde tıklanan satırdaki bilgileri textboxlara alır.
        {
            txtId.Text = dataGridKategori.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridKategori.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
