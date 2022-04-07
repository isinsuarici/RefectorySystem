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
using System.Windows.Forms;
using System.Data;

namespace DatabaseHomework_3
{
    public partial class Depo_Satis : Form
    {
        DatabaseIslemleri db = new DatabaseIslemleri();
        SqlConnection connection;
        YoneticiPaneli yonetici_paneli;
        public Depo_Satis()
        {
            InitializeComponent();
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

        private void btnOdemeGoruntule_Click(object sender, EventArgs e)
        {
            db.listele(dataGridDepoSatis,"Make_Payment_For");
        }

        private void btnRezervasyonGoruntule_Click(object sender, EventArgs e)
        {
            db.listele(dataGridDepoSatis, "Reservation_For");
        }

        private void btnYemekhaneToplamUrun_Click(object sender, EventArgs e) //en çok ürün olan yemekhane
        {
            baglan();
            SqlDataAdapter da = new SqlDataAdapter(" SELECT SUM(number_of_product) AS ToplamUrunSayisi, refectory_id AS 'Yemekhane' FROM Stored_In GROUP BY refectory_id", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridDepoSatis.DataSource = tablo;
            baglantiyi_kapat();
        }

        private void btnSatilanUrunler_Click(object sender, EventArgs e)
        {
            baglan();
            SqlDataAdapter da = new SqlDataAdapter(" Select  product_id AS Urun,count(1) AS Toplam  from Make_Payment_For GROUP BY product_id ORDER BY Toplam desc", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridDepoSatis.DataSource = tablo;
            baglantiyi_kapat();
        }

        private void btnEnCokSatis_Click(object sender, EventArgs e)
        {
            
            baglan();
            SqlDataAdapter da = new SqlDataAdapter("Select  MONTH(date) AS ay,count(1) AS SatisMiktari  from Make_Payment_For  WHERE YEAR(date)="+ txtYil.Text+"  GROUP BY MONTH(date) ORDER BY SatisMiktari desc", connection);
            DataTable tablo = new DataTable();
            if (txtYil.Text == "") { MessageBox.Show("Lütfen tarih giriniz!"); }
            else
            {
                da.Fill(tablo);
                dataGridDepoSatis.DataSource = tablo;
                baglantiyi_kapat();
                txtYil.Clear();
            }
        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            baglan();
            SqlDataAdapter da = new SqlDataAdapter(" SELECT sum(convert(int, round(price, 0))) AS gelir, YEAR(date) as yıl from Make_Payment_For GROUP BY YEAR(date) ORDER BY gelir desc", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridDepoSatis.DataSource = tablo;
            baglantiyi_kapat();

        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            db.listele(dataGridDepoSatis, "Stored_In");
        }

        private void pxtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pxtGeriDon_Click(object sender, EventArgs e)
        {
            yonetici_paneli = new YoneticiPaneli();
            yonetici_paneli.Show();
            this.Hide();
        }
    }
}
