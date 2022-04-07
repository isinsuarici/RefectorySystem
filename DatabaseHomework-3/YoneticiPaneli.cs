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
    public partial class YoneticiPaneli : Form
    {
        Yonetici_Kategori kategori;
        Yonetici_Urun urun;
        Yonetici_Yemekhane yemekhane;
        Yonetici_Giris giris;
        Depo_Satis satis;
        Yemekhaneye_Urun_ekle ekle;
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            giris = new Yonetici_Giris();
            giris.Show();
            this.Hide();
        }

        private void cmbAlanSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAlanSec.SelectedItem.ToString() == "Yemekhaneler")
            {
                yemekhane = new Yonetici_Yemekhane();
                yemekhane.Show();
                this.Hide();
            }
            else if (cmbAlanSec.SelectedItem.ToString() == "Kategoriler")
            {
                kategori = new Yonetici_Kategori();
                kategori.Show();
                this.Hide();
            }
            else if (cmbAlanSec.SelectedItem.ToString() == "Ürünler")
            {
                urun = new Yonetici_Urun();
                urun.Show();
                this.Hide();
            }
            else if (cmbAlanSec.SelectedItem.ToString() == "Depo-Satış")
            {
                satis = new Depo_Satis();
                satis.Show();
                this.Hide();
            }
            else if (cmbAlanSec.SelectedItem.ToString() == "Yemekhaneye Ürün Ekle")
            {
                ekle = new Yemekhaneye_Urun_ekle();
                ekle.Show();
                this.Hide();
            }

           


        }
    }
}
