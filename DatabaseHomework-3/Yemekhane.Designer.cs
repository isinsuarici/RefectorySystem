namespace DatabaseHomework_3
{
    partial class Yemekhane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yemekhane));
            this.panel1 = new System.Windows.Forms.Panel();
            this.geriDon = new System.Windows.Forms.PictureBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbYemekhane = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblYemekhane = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lstSepetim = new System.Windows.Forms.ListBox();
            this.lblUrunlerim = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.geriDon);
            this.panel1.Controls.Add(this.cmbUrun);
            this.panel1.Controls.Add(this.cmbKategori);
            this.panel1.Controls.Add(this.cmbYemekhane);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.txtTutar);
            this.panel1.Controls.Add(this.lblTutar);
            this.panel1.Controls.Add(this.lblUrun);
            this.panel1.Controls.Add(this.lblKategori);
            this.panel1.Controls.Add(this.lblYemekhane);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 452);
            this.panel1.TabIndex = 0;
            // 
            // geriDon
            // 
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.Image = ((System.Drawing.Image)(resources.GetObject("geriDon.Image")));
            this.geriDon.Location = new System.Drawing.Point(18, 319);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(52, 32);
            this.geriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geriDon.TabIndex = 25;
            this.geriDon.TabStop = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(124, 190);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(259, 21);
            this.cmbUrun.TabIndex = 24;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(124, 145);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(259, 21);
            this.cmbKategori.TabIndex = 23;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // cmbYemekhane
            // 
            this.cmbYemekhane.FormattingEnabled = true;
            this.cmbYemekhane.Location = new System.Drawing.Point(124, 98);
            this.cmbYemekhane.Name = "cmbYemekhane";
            this.cmbYemekhane.Size = new System.Drawing.Size(259, 21);
            this.cmbYemekhane.TabIndex = 22;
            this.cmbYemekhane.SelectedIndexChanged += new System.EventHandler(this.cmbYemekhane_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(123, 319);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(169, 66);
            this.btnEkle.TabIndex = 21;
            this.btnEkle.Text = "Sepetime Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(123, 237);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(51, 20);
            this.txtTutar.TabIndex = 16;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(34, 244);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 13);
            this.lblTutar.TabIndex = 13;
            this.lblTutar.Text = "Tutar:";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(36, 193);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(33, 13);
            this.lblUrun.TabIndex = 11;
            this.lblUrun.Text = "Ürün:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(36, 145);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(49, 13);
            this.lblKategori.TabIndex = 10;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblYemekhane
            // 
            this.lblYemekhane.AutoSize = true;
            this.lblYemekhane.Location = new System.Drawing.Point(36, 101);
            this.lblYemekhane.Name = "lblYemekhane";
            this.lblYemekhane.Size = new System.Drawing.Size(67, 13);
            this.lblYemekhane.TabIndex = 9;
            this.lblYemekhane.Text = "Yemekhane:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(36, 59);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(34, 13);
            this.lblTarih.TabIndex = 8;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(29, 184);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(32, 13);
            this.lblAdet.TabIndex = 12;
            this.lblAdet.Text = "Adet:";
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyon.Location = new System.Drawing.Point(14, 374);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(152, 46);
            this.btnRezervasyon.TabIndex = 14;
            this.btnRezervasyon.Text = "Rezervasyon Yap";
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.Location = new System.Drawing.Point(183, 374);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(165, 46);
            this.btnOdeme.TabIndex = 15;
            this.btnOdeme.Text = "Ödeme Yap";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(104, 292);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(122, 20);
            this.txtToplamTutar.TabIndex = 17;
            // 
            // lstSepetim
            // 
            this.lstSepetim.FormattingEnabled = true;
            this.lstSepetim.Location = new System.Drawing.Point(23, 71);
            this.lstSepetim.Name = "lstSepetim";
            this.lstSepetim.Size = new System.Drawing.Size(325, 82);
            this.lstSepetim.TabIndex = 18;
            // 
            // lblUrunlerim
            // 
            this.lblUrunlerim.AutoSize = true;
            this.lblUrunlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunlerim.Location = new System.Drawing.Point(71, 17);
            this.lblUrunlerim.Name = "lblUrunlerim";
            this.lblUrunlerim.Size = new System.Drawing.Size(226, 37);
            this.lblUrunlerim.TabIndex = 19;
            this.lblUrunlerim.Text = "Sepetimdekiler";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(11, 295);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(73, 13);
            this.lblToplam.TabIndex = 20;
            this.lblToplam.Text = "Toplam Tutar:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(14, 224);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(143, 25);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Seçili Ürünü Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.txtAdet);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.lblToplam);
            this.panel2.Controls.Add(this.btnOdeme);
            this.panel2.Controls.Add(this.lblAdet);
            this.panel2.Controls.Add(this.lblUrunlerim);
            this.panel2.Controls.Add(this.btnRezervasyon);
            this.panel2.Controls.Add(this.txtToplamTutar);
            this.panel2.Controls.Add(this.lstSepetim);
            this.panel2.Location = new System.Drawing.Point(410, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 452);
            this.panel2.TabIndex = 1;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(67, 181);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(74, 20);
            this.txtAdet.TabIndex = 24;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(183, 224);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(145, 25);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Seçili Ürünü Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // Yemekhane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Yemekhane";
            this.Text = "Yemekhane";
            this.Load += new System.EventHandler(this.Yemekhane_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblYemekhane;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblUrunlerim;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cmbUrun;
        public System.Windows.Forms.ComboBox cmbKategori;
        public System.Windows.Forms.ComboBox cmbYemekhane;
        public System.Windows.Forms.TextBox txtTutar;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.ListBox lstSepetim;
        public System.Windows.Forms.Button btnOdeme;
        public System.Windows.Forms.Button btnRezervasyon;
        public System.Windows.Forms.TextBox txtToplamTutar;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox geriDon;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}