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
    public partial class Yemekhane : Form
    {
        Form1 giris;
        SqlConnection connection;
        Yemekhane_DB yemekhane_DB = new Yemekhane_DB();
        public Yemekhane()
        {
            InitializeComponent();
           
        }
        private void Yemekhane_Load(object sender, EventArgs e)
        {
            cmbYemekhane.Items.Clear();
            yemekhane_DB.cmb_items(cmbYemekhane,"Refectory","");
            cmbYemekhane.Text = cmbYemekhane.Items[0].ToString();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
           
            giris = new Form1();
           // giris.Show();
            this.Hide();
        }

        private void cmbYemekhane_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKategori.Items.Clear();
            yemekhane_DB.cmb_items(cmbKategori, "Category","");
            cmbKategori.Text = cmbKategori.Items[0].ToString();
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUrun.Items.Clear();
            yemekhane_DB.cmb_urun_items(cmbUrun,cmbYemekhane.Text,cmbKategori.Text);
            cmbUrun.Text = cmbUrun.Items[0].ToString();
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTutar.Text = yemekhane_DB.tutar_getir("Product", "name", cmbUrun.Text).ToString();
        }
        string fiyat = "";
        int toplam_tutar;
        int birim_fiyatimiz;
        private void btnEkle_Click(object sender, EventArgs e) //sepete seçili ürünü ekleme işlemi
        {
            if ((txtToplamTutar.Text)=="") //ilk ürün eklemede
            {
                txtToplamTutar.Text = "0";
            } //ürün ilk kez eklenmiyorsa toplam tutar sıfır olmayacak
            // fiyat = ": " + txtTutar.Text + " tl";
            lstSepetim.Items.Add("1 adet:"+ cmbUrun.SelectedItem + ":" + txtTutar.Text + " tl");
            txtToplamTutar.Text = (Convert.ToInt32(txtToplamTutar.Text) + Convert.ToInt32(txtTutar.Text)).ToString();
           
        }
        private void btnSil_Click(object sender, EventArgs e) //sepetten seçili ürünü silme işlemi
        {
            string urun_fiyat = lstSepetim.SelectedItem.ToString().Split(':')[2];
            string urun_gercek_fiyat = urun_fiyat.Split(' ')[0];
            txtToplamTutar.Text = ((Convert.ToInt32(txtToplamTutar.Text)) - Convert.ToInt32(urun_gercek_fiyat)).ToString();
            lstSepetim.Items.Remove(lstSepetim.SelectedItem);
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e) //seçili ürünün miktarını güncelleme işlemi
        {
            int index = lstSepetim.SelectedIndex;
          //  MessageBox.Show(birim_fiyatimiz.ToString());
           
            //  string tutar= fiyat.Split(' ')[1];
            // string[] urun= lstSepetim.SelectedItem.ToString().Split(':');
            //   string urun_miktar = lstSepetim.SelectedItem.ToString().Split(':')[0]; //1 adet 
            string adet_sayisi = lstSepetim.SelectedItem.ToString().Split(':')[0]; // adet sayisi stringi
            string gercek_adet_sayisi = adet_sayisi.Split(' ')[0]; // anlik adet sayisi 

            string urun_adi = lstSepetim.SelectedItem.ToString().Split(':')[1]; //urun adi
            string urun_fiyat=lstSepetim.SelectedItem.ToString().Split(':')[2];  //25 tl
         
            string urun_gercek_fiyat =urun_fiyat.Split(' ')[0]; // bir ürünün toplam fiyatı 
         //   MessageBox.Show(urun_gercek_fiyat);
         
            int birim_fiyat = Convert.ToInt32(urun_gercek_fiyat) / Convert.ToInt32(gercek_adet_sayisi);
            string guncelle = txtAdet.Text + " adet:" + urun_adi+":"+ (Convert.ToInt32(birim_fiyat) * (Convert.ToInt32(txtAdet.Text))) +" tl";
            txtToplamTutar.Text =(((Convert.ToInt32(txtToplamTutar.Text)) + ((Convert.ToInt32(txtAdet.Text) - Convert.ToInt32(gercek_adet_sayisi)) * Convert.ToInt32(birim_fiyat))).ToString());
            lstSepetim.Items.Remove(lstSepetim.SelectedItem);
            lstSepetim.Items.Insert(index, guncelle);
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
                    //   MessageBox.Show("Baglanti acildi");
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

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            int ret = 1;
            DateTime dateWithMe = new DateTime();
            dateWithMe = dateTimePicker1.Value;
            string tarih = dateWithMe.ToString("yyyy-MM-dd h:mm:ss.fff");
            
            string urun_adet = lstSepetim.Items[0].ToString().Split(':')[0]; //1 adet
            string urun_adi = lstSepetim.Items[0].ToString().Split(':')[1]; //urun adi
            string urun_fiyat = lstSepetim.Items[0].ToString().Split(':')[2];  //25 tl
            string urun_gercek_fiyat = urun_fiyat.Split(' ')[0]; // bir ürünün toplam fiyatı 
            string urun_gercek_adet= urun_adet.Split(' ')[0]; //1
            baglan();  // (CAST(N'2012-06-18 10:34:09.000' AS DateTime) ,5,6,827)
            SqlCommand komut2 = new SqlCommand("SELECT product_id from Product WHERE name='" + urun_adi + "'", connection);
            ret = (int.Parse("" + komut2.ExecuteScalar())); //product_id almak için
            


            SqlCommand komut = new SqlCommand("insert into Make_Payment_For(date, price, product_id,person_id) VALUES(CAST(N'" + tarih + "' AS DateTime) ," + urun_gercek_fiyat + "," + ret + " ," + StaticVeriler.person_idmiz + ")  ", connection);
            komut.ExecuteNonQuery();
            
            

            int ref_id = -1;
            SqlCommand komut4 = new SqlCommand("SELECT refectory_id from Refectory WHERE name='" + cmbYemekhane.Text + "'", connection);
            ref_id = (int.Parse("" + komut4.ExecuteScalar())); //refectory_id almak için

            int urun_sayisi = -1;
            SqlCommand komut5 = new SqlCommand("SELECT number_of_product from Stored_In WHERE refectory_id='" + ref_id + "'and product_id='"+ret+"'", connection);
            urun_sayisi = (int.Parse("" + komut5.ExecuteScalar())); //number_of_product almak için
            int yeni_urun_sayisi = urun_sayisi - Convert.ToInt32(urun_gercek_adet);
            //UPDATE Stored_In SET number_of_product=657 WHERE refectory_id=1 and product_id=2
            SqlCommand komut3 = new SqlCommand("UPDATE Stored_In SET number_of_product='" + yeni_urun_sayisi + "' " + "WHERE refectory_id='" + ref_id + "'and product_id='" + ret + "'", connection);
            komut3.ExecuteNonQuery();
            baglantiyi_kapat();
            MessageBox.Show("Ödeme işleminiz başarıyla yapıldı!");

        }
       
        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            int ret = 1;
            DateTime dateWithMe = new DateTime();
            dateWithMe = dateTimePicker1.Value;
            string tarih = dateWithMe.ToString("yyyy-MM-dd h:mm:ss.fff");
           

            string urun_adi = lstSepetim.Items[0].ToString().Split(':')[1]; //urun adi
            string urun_fiyat = lstSepetim.Items[0].ToString().Split(':')[2];  //25 tl
            string urun_gercek_fiyat = urun_fiyat.Split(' ')[0]; // bir ürünün toplam fiyatı 
            baglan();  // (CAST(N'2012-06-18 10:34:09.000' AS DateTime) ,5,6,827)
            SqlCommand komut2 = new SqlCommand("SELECT product_id from Product WHERE name='" + urun_adi + "'", connection);
            ret = (int.Parse("" + komut2.ExecuteScalar())); //product_id almak için
            


            SqlCommand komut = new SqlCommand("insert into Reservation_For(date, product_id,person_id) VALUES(CAST(N'" + tarih + "' AS DateTime) ," + ret + " ," + StaticVeriler.person_idmiz + ")  ", connection);
            komut.ExecuteNonQuery();
            baglantiyi_kapat();
            MessageBox.Show("Rezervasyonunuz başarıyla yapıldı!");
        }
    }
}
