using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DatabaseHomework_3
{
    public class DatabaseIslemleri
    {
        SqlConnection connection;
        Yonetici_Yemekhane yonetici_yemekhane;
        Yonetici_Kategori yonetici_kategori;
        Yonetici_Urun yonetici_urun;


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
        public void listele(DataGridView dataGrid,string tabloAdi)
        {
            baglan();
            SqlDataAdapter da = new SqlDataAdapter("select * FROM "+ tabloAdi, connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGrid.DataSource = tablo;
            baglantiyi_kapat();
        } //datagridview'e veritabanındaki verileri listelemek için
        public void urun_listele(DataGridView dataGrid)
        {
            baglan();
            SqlDataAdapter da = new SqlDataAdapter("select Product.product_id as 'Urun ID', Product.name as 'Urun Adi', Product.price as 'Fiyat', Category.name as 'Kategori' from Product, Category where Category.category_id=Product.category_id", connection);
            //select Product.product_id as 'Product ID', Product.name as 'Product Name', Product.price as 'The Price', Category.name as 'Category Name' from Product join Category on Category.category_id=Product.category_id  .....joinli aynı

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGrid.DataSource = tablo;
            baglantiyi_kapat();
        }
        public void urun_ekle(DataGridView dataGrid)
        {
            yonetici_urun = new Yonetici_Urun();
            int kategori_id = kategori_id_al();
            if (kategori_id != -1)
            {
                baglan();
                SqlCommand komut = new SqlCommand("insert into Product(name, price, category_id) VALUES('" + StaticVeriler.degisken2 + "', '" + StaticVeriler.degisken3 + "', " + kategori_id + ")", connection);
                komut.ExecuteNonQuery();
                baglantiyi_kapat();
            }

            urun_listele(dataGrid);
            yonetici_urun.txtUrunId.Clear();
            yonetici_urun.txtUrunAdi.Clear();
            yonetici_urun.txtUrunFiyat.Clear();
            yonetici_urun.txtUrunKategori.Clear();
        }
     /*   public void rezervasyon_ekle(DataGridView dataGrid)
        {
            odeme = new Rezervasyon_Odeme();

            baglan();
            SqlCommand komut = new SqlCommand("insert into Reservation_For(date, product_id, person_id) VALUES('" + StaticVeriler.degisken1 + "', '" + StaticVeriler.degisken3 + "', " + StaticVeriler.degisken4 + ")", connection);
            komut.ExecuteNonQuery();
            baglantiyi_kapat();
            odeme.txtUrunId.Clear();
            odeme.txtTarih.Clear();
            odeme.txtOgrenciId.Clear();
            odeme.txtFiyat.Clear();

            listele(dataGrid,"Reservation_For");

        }*/
        public int kategori_id_al() //kategori name için id alma işlemi
        {
            int ret = -1;
            baglan();
            SqlCommand komut = new SqlCommand("select category_id from Category where name='" + StaticVeriler.degisken4 +"'",connection);
            ret = int.Parse("" + komut.ExecuteScalar());
            baglantiyi_kapat();
            return ret;
        }
        public void urun_guncelle(DataGridView dataGrid, string tabloAdi) // refectory_id güncellenemeyeceği için komutta onu güncelle yazmadık 
        {
            int kategori_id = kategori_id_al();
            if (kategori_id != -1)
            {
                baglan();
                SqlCommand komut = new SqlCommand("UPDATE Product SET name='" + StaticVeriler.degisken2 + "', price='" + StaticVeriler.degisken3 + "', category_id= '" + kategori_id + "' " + " WHERE product_id='" + StaticVeriler.degisken1 + "' ", connection);
                komut.ExecuteNonQuery();
                baglantiyi_kapat();
                urun_listele(dataGrid);
            }
        }
        public void yemekhane_ekle (DataGridView dataGrid, string tabloAdi)
        {
           yonetici_yemekhane = new Yonetici_Yemekhane();

            baglan();
            SqlCommand komut = new SqlCommand("insert into Refectory ( capacity, name, address) VALUES ('" + StaticVeriler.degisken1+"' , '"+StaticVeriler.degisken2+"' , '"+StaticVeriler.degisken3+"')", connection );
            komut.ExecuteNonQuery();
            baglantiyi_kapat();

            listele(dataGrid, tabloAdi);
            yonetici_yemekhane.txtId.Clear();
            yonetici_yemekhane.txtKapasite.Clear();
            yonetici_yemekhane.txtAd.Clear();
            yonetici_yemekhane.txtAdres.Clear();
        }
        public void sil(DataGridView dataGrid, string tabloAdi,string id,string kosul_id)
        {
            //string id = StaticVeriler.degisken4; 
            baglan();
            SqlCommand komut = new SqlCommand("DELETE from "+tabloAdi+" WHERE "+ kosul_id+ " =('" + id + "')", connection);
            komut.ExecuteNonQuery();
            baglantiyi_kapat();
            if (tabloAdi != "Product")
                listele(dataGrid, tabloAdi);
            else
                urun_listele(dataGrid);
        } //genel
        public void yemekhane_guncelle(DataGridView dataGrid, string tabloAdi) // refectory_id güncellenemeyeceği için komutta onu güncelle yazmadık 
        {
            baglan();
            SqlCommand komut = new SqlCommand("UPDATE Refectory SET capacity='"+StaticVeriler.degisken1+"', name='"+StaticVeriler.degisken2+"', address='"+StaticVeriler.degisken3+"' "+"WHERE refectory_id='"+StaticVeriler.degisken4+"' ",connection);
            komut.ExecuteNonQuery();
            baglantiyi_kapat();
            listele(dataGrid, tabloAdi);
        }
        public void kategori_ekle(DataGridView dataGrid, string tabloAdi)
        {
            yonetici_kategori = new Yonetici_Kategori();

            baglan();
            SqlCommand komut = new SqlCommand("insert into Category ( name) VALUES ('" + StaticVeriler.degisken2 + "')", connection);
            komut.ExecuteNonQuery();
            baglantiyi_kapat();

            listele(dataGrid, tabloAdi);
            yonetici_kategori.txtId.Clear();
            yonetici_kategori.txtAd.Clear();
        }
        public void kategori_guncelle(DataGridView dataGrid, string tabloAdi) // category_id güncellenemeyeceği için komutta onu güncelle yazmadık 
        {
            baglan();
            SqlCommand komut = new SqlCommand("UPDATE Category SET name='" + StaticVeriler.degisken2 + "' " + "WHERE category_id='" + StaticVeriler.degisken1 + "' ", connection);
            komut.ExecuteNonQuery();
            baglantiyi_kapat();
            listele(dataGrid, tabloAdi);
        }
        /*public void rezervasyon_guncelle(DataGridView dataGrid, string tabloAdi)  
        {
            baglan();
            SqlCommand komut = new SqlCommand("UPDATE Reservation_For SET product_id='" + StaticVeriler.degisken3 + "' " + "WHERE date='" + StaticVeriler.degisken1 + "' and person_id="+StaticVeriler.degisken1 +"", connection);
            komut.ExecuteNonQuery();
            baglantiyi_kapat();
            listele(dataGrid, tabloAdi);
        }*/



    }
}
