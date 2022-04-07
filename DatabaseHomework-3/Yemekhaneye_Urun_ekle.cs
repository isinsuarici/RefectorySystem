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
    public partial class Yemekhaneye_Urun_ekle : Form
    {
        DatabaseIslemleri db = new DatabaseIslemleri();
        SqlConnection connection;
        YoneticiPaneli ynt;
        public Yemekhaneye_Urun_ekle()
        {
            InitializeComponent();
            db.listele(dataGridUrunEkle,"Stored_In");
            txtYemekhaneId.Enabled = false;
            txtUrunId.Enabled = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan();
            SqlCommand komut3 = new SqlCommand("UPDATE Stored_In SET number_of_product='" + txtGuncelle.Text + "' " + "WHERE refectory_id='" + txtYemekhaneId.Text + "'and product_id='" + txtUrunId.Text + "'", connection);
            komut3.ExecuteNonQuery();
            baglantiyi_kapat();
            db.listele(dataGridUrunEkle, "Stored_In");
        }

        private void dataGridUrunEkle_Click(object sender, EventArgs e)
        {
            txtGuncelle.Text = dataGridUrunEkle.CurrentRow.Cells[0].Value.ToString();
            txtYemekhaneId.Text = dataGridUrunEkle.CurrentRow.Cells[1].Value.ToString();
            txtUrunId.Text = dataGridUrunEkle.CurrentRow.Cells[2].Value.ToString();
            
        }
        public void baglan()
        {
            try
            {
                connection = new SqlConnection(@"Server=DESKTOP-69VCGIM;Database=REFECTORY;Trusted_Connection=True;");
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı yolu alınamadı.");
            }
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    //  MessageBox.Show("Baglanti acildi");
                }
                catch (Exception)
                {
                    MessageBox.Show("Bağlantı açılırken bir hata oluştu.");
                }
            }
        }//baglan metodu sonu
        public void baglantiyi_kapat()
        {
            if (connection.State != ConnectionState.Closed)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bağlantı kapatılırken bir hata oluştu.");
                }
            }
        }//baglanti_kapat metodu sonu

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctGeri_Click(object sender, EventArgs e)
        {
            ynt = new YoneticiPaneli();
            ynt.Show();
            this.Hide();
        }
    }
}
