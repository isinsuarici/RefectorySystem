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
    class Yemekhane_DB
    {
        SqlConnection connection;
        Yemekhane yemekhane;

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

        public void cmb_items(ComboBox cmb,string tablo_adi,string kosul_yapisi) {
            baglan();
            SqlCommand da = new SqlCommand("select name from "+ tablo_adi+" "+ kosul_yapisi, connection);
            SqlDataReader okuyucu = da.ExecuteReader();
            if (okuyucu.HasRows)
            {
                while (okuyucu.Read())
                {
                    if(!cmb.Items.Contains(okuyucu["name"]))
                    cmb.Items.Add(okuyucu["name"]);
                }
                okuyucu.Close();
            }
                baglantiyi_kapat();
        }
        public int id_al(string istenen_id, string tablo_adi, string kolon_adi, string kosul_adi) 
        {
            int ret = -1;
            baglan();
            SqlCommand komut = new SqlCommand("select "+ istenen_id + " from "+ tablo_adi+" where "+ kolon_adi +"= '" + kosul_adi + "'", connection);
            ret = int.Parse("" + komut.ExecuteScalar());
            baglantiyi_kapat();
            return ret;
        }
        public void cmb_urun_items(ComboBox cmb, string yemekhane_adi, string kategori_adi)
        {
            baglan();
            int kategori_id, yemekhane_id;
            string  product_id;
            string kosul = "";

            SqlCommand da = new SqlCommand("select * from Stored_In",connection);
           // if(SqlDataReader.)
            SqlDataReader okuyucu = da.ExecuteReader();
            if (okuyucu.HasRows)
            {
                while (okuyucu.Read())
                {
                    yemekhane_id = id_al("refectory_id", "Refectory", "name", yemekhane_adi);
                    kategori_id = id_al("category_id", "Category", "name", kategori_adi);
                    // yemekhane_id = okuyucu["refectory_id"].ToString();
                    product_id = okuyucu["product_id"].ToString();
                    kosul = ", Stored_In where Product.product_id=" + product_id + " and Product.category_id=" + kategori_id+" and Stored_In.refectory_id="+yemekhane_id;
                    cmb_items(cmb, "Product", kosul);
                }
                okuyucu.Close();
            }
           
            baglantiyi_kapat();

        }
        public int tutar_getir(string tablo_adi, string kolon_adi, string kosul_adi)
        {
            int ret = -1;
            baglan();
            //select  convert(int, round(price, 0)) from Product where name= 'Cola'
            SqlCommand komut = new SqlCommand("select convert(int, round(price, 0)) from " + tablo_adi + " where " + kolon_adi + "= '" + kosul_adi + "'", connection);
            ret =  (int.Parse(""+komut.ExecuteScalar()));
            baglantiyi_kapat();
            return ret;
        }

       
     

    }
}
