namespace DatabaseHomework_3
{
    partial class Yonetici_Urun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_Urun));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.geriDon = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunKategori = new System.Windows.Forms.TextBox();
            this.lblUrunId = new System.Windows.Forms.Label();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.lblUrunKategori = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lnlUrunler = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dataGridUrunler);
            this.panel1.Controls.Add(this.txtUrunAdi);
            this.panel1.Controls.Add(this.geriDon);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.txtUrunId);
            this.panel1.Controls.Add(this.txtUrunFiyat);
            this.panel1.Controls.Add(this.txtUrunKategori);
            this.panel1.Controls.Add(this.lblUrunId);
            this.panel1.Controls.Add(this.lblUrunFiyat);
            this.panel1.Controls.Add(this.lblUrunKategori);
            this.panel1.Controls.Add(this.lblUrunAd);
            this.panel1.Controls.Add(this.lnlUrunler);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 454);
            this.panel1.TabIndex = 0;
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Location = new System.Drawing.Point(52, 218);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.Size = new System.Drawing.Size(607, 208);
            this.dataGridUrunler.TabIndex = 28;
            this.dataGridUrunler.Click += new System.EventHandler(this.dataGridUrunler_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(225, 124);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(152, 20);
            this.txtUrunAdi.TabIndex = 27;
            // 
            // geriDon
            // 
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.Image = ((System.Drawing.Image)(resources.GetObject("geriDon.Image")));
            this.geriDon.Location = new System.Drawing.Point(16, 36);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(108, 61);
            this.geriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geriDon.TabIndex = 26;
            this.geriDon.TabStop = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(670, 30);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(98, 67);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 25;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(335, 168);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(149, 29);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(518, 167);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(140, 30);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(152, 167);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 30);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(52, 123);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(77, 20);
            this.txtUrunId.TabIndex = 8;
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(431, 124);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(63, 20);
            this.txtUrunFiyat.TabIndex = 7;
            // 
            // txtUrunKategori
            // 
            this.txtUrunKategori.Location = new System.Drawing.Point(589, 126);
            this.txtUrunKategori.Name = "txtUrunKategori";
            this.txtUrunKategori.Size = new System.Drawing.Size(155, 20);
            this.txtUrunKategori.TabIndex = 6;
            // 
            // lblUrunId
            // 
            this.lblUrunId.AutoSize = true;
            this.lblUrunId.Location = new System.Drawing.Point(27, 126);
            this.lblUrunId.Name = "lblUrunId";
            this.lblUrunId.Size = new System.Drawing.Size(19, 13);
            this.lblUrunId.TabIndex = 4;
            this.lblUrunId.Text = "Id:";
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(391, 126);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(34, 13);
            this.lblUrunFiyat.TabIndex = 3;
            this.lblUrunFiyat.Text = "Fiyatı:";
            // 
            // lblUrunKategori
            // 
            this.lblUrunKategori.AutoSize = true;
            this.lblUrunKategori.Location = new System.Drawing.Point(527, 126);
            this.lblUrunKategori.Name = "lblUrunKategori";
            this.lblUrunKategori.Size = new System.Drawing.Size(56, 13);
            this.lblUrunKategori.TabIndex = 2;
            this.lblUrunKategori.Text = "Kategorisi:";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(149, 126);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(51, 13);
            this.lblUrunAd.TabIndex = 1;
            this.lblUrunAd.Text = "Ürün Adı:";
            // 
            // lnlUrunler
            // 
            this.lnlUrunler.AutoSize = true;
            this.lnlUrunler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lnlUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnlUrunler.ForeColor = System.Drawing.Color.Maroon;
            this.lnlUrunler.Location = new System.Drawing.Point(303, 36);
            this.lnlUrunler.Name = "lnlUrunler";
            this.lnlUrunler.Size = new System.Drawing.Size(122, 37);
            this.lnlUrunler.TabIndex = 0;
            this.lnlUrunler.Text = "Ürünler";
            // 
            // Yonetici_Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Yonetici_Urun";
            this.Text = "Yonetici_Urun";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lnlUrunler;
        public System.Windows.Forms.TextBox txtUrunId;
        public System.Windows.Forms.TextBox txtUrunFiyat;
        public System.Windows.Forms.TextBox txtUrunKategori;
        public System.Windows.Forms.Label lblUrunId;
        public System.Windows.Forms.Label lblUrunFiyat;
        public System.Windows.Forms.Label lblUrunKategori;
        public System.Windows.Forms.Label lblUrunAd;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox geriDon;
        public System.Windows.Forms.TextBox txtUrunAdi;
        public System.Windows.Forms.DataGridView dataGridUrunler;
    }
}