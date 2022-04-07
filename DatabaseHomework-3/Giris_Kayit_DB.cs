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
    class Giris_Kayit_DB
    {
        SqlConnection connection;
        Form1 giris = new Form1();
        FormKayit kayit;
        SqlDataReader okuyucu;

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
       
        public void kullanici_giris_kontrol(string email, string sifre)
        {
            baglan();
            SqlCommand komut = new SqlCommand("SELECT Profile.password, People.e_mail from Profile,People WHERE People.person_id=Profile.person_id AND Profile.password="+ sifre + " AND People.e_mail='" + email + "'", connection);
            okuyucu = komut.ExecuteReader();


            if (okuyucu.Read())
            {
                int ret = -1;
                Yemekhane yemekhane = new Yemekhane();
                okuyucu.Close();
                SqlCommand komut2 = new SqlCommand("SELECT person_id from People WHERE e_mail='" + email + "'", connection);
                ret = (int.Parse("" + komut2.ExecuteScalar())); //person_id almak için
                yemekhane.Show();
                giris.Hide(); //çalışmıyor
                StaticVeriler.person_idmiz = ret;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }
            baglantiyi_kapat();

        }

        public void kullanici_ekle(string ad, string soyad, string mail, string telefon, string sifre) //try catch yazılabilir
        {
            kayit = new FormKayit();
            baglan();
            SqlCommand komut1 = new SqlCommand("insert into People(Fname, Lname, e_mail, phone_number) VALUES('" + ad + "', '" + soyad + "', '" + mail + "', '" + telefon + "')", connection);
            komut1.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("select person_id from People where e_mail = '"+mail+"'",connection);
            // SqlDataReader okuyucu = komut2.ExecuteReader(); 
            int person_id = int.Parse(""+komut2.ExecuteScalar()); 
           // okuyucu.Close();
            SqlCommand komut3 = new SqlCommand("insert into Profile(password, person_id) VALUES('"+sifre+"', '"+person_id+"')",connection);
            komut3.ExecuteNonQuery();
            baglantiyi_kapat(); 
            kayit.txtMail.Clear();
            kayit.txtName.Clear();
            kayit.txtPassword.Clear(); //Profile ekleniyor.
            kayit.txtSurname.Clear();
            kayit.txtTelefon.Clear();

        }

    }
}
