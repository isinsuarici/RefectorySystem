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
    public partial class Yonetici_Yemekhane : Form
    {
       
        YoneticiPaneli yoneticipaneli;
        DatabaseIslemleri db = new DatabaseIslemleri();
        public Yonetici_Yemekhane()
        {
            InitializeComponent();
            db.listele(dataGridYemekhane,"Refectory");
           
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
            // id txt sini enabled yap
            StaticVeriler.degisken1 = txtKapasite.Text;
            StaticVeriler.degisken2 = txtAd.Text;
            StaticVeriler.degisken3 = txtAdres.Text;
            StaticVeriler.degisken4 = txtId.Text;
            db.yemekhane_ekle(dataGridYemekhane, "Refectory");
        }


        private void dataGridYemekhane_Click(object sender, EventArgs e) //datagridde tıklanan satırdaki bilgileri textboxlara alır.
        {
            txtId.Text = dataGridYemekhane.CurrentRow.Cells[0].Value.ToString();
            txtKapasite.Text = dataGridYemekhane.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataGridYemekhane.CurrentRow.Cells[2].Value.ToString();
            txtAdres.Text = dataGridYemekhane.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            StaticVeriler.degisken1 = txtKapasite.Text;
            StaticVeriler.degisken2 = txtAd.Text;
            StaticVeriler.degisken3 = txtAdres.Text;
            StaticVeriler.degisken4 = txtId.Text;
            db.sil(dataGridYemekhane, "Refectory", txtId.Text, "refectory_id");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            StaticVeriler.degisken1 = txtKapasite.Text;
            StaticVeriler.degisken2 = txtAd.Text;
            StaticVeriler.degisken3 = txtAdres.Text;
            StaticVeriler.degisken4 = txtId.Text;
            db.yemekhane_guncelle(dataGridYemekhane, "Refectory");
        }
    }
}
