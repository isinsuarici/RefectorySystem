namespace DatabaseHomework_3
{
    partial class Depo_Satis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depo_Satis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridDepoSatis = new System.Windows.Forms.DataGridView();
            this.btnOdemeGoruntule = new System.Windows.Forms.Button();
            this.btnRezervasyonGoruntule = new System.Windows.Forms.Button();
            this.btnYemekhaneToplamUrun = new System.Windows.Forms.Button();
            this.btnSatilanUrunler = new System.Windows.Forms.Button();
            this.btnEnCokSatis = new System.Windows.Forms.Button();
            this.btnGelir = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.pxtGeriDon = new System.Windows.Forms.PictureBox();
            this.pxtExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepoSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtGeriDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pxtExit);
            this.panel1.Controls.Add(this.pxtGeriDon);
            this.panel1.Controls.Add(this.txtYil);
            this.panel1.Controls.Add(this.btnStok);
            this.panel1.Controls.Add(this.btnGelir);
            this.panel1.Controls.Add(this.btnEnCokSatis);
            this.panel1.Controls.Add(this.btnSatilanUrunler);
            this.panel1.Controls.Add(this.btnYemekhaneToplamUrun);
            this.panel1.Controls.Add(this.btnRezervasyonGoruntule);
            this.panel1.Controls.Add(this.btnOdemeGoruntule);
            this.panel1.Controls.Add(this.dataGridDepoSatis);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 455);
            this.panel1.TabIndex = 0;
            // 
            // dataGridDepoSatis
            // 
            this.dataGridDepoSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDepoSatis.Location = new System.Drawing.Point(119, 208);
            this.dataGridDepoSatis.Name = "dataGridDepoSatis";
            this.dataGridDepoSatis.Size = new System.Drawing.Size(627, 230);
            this.dataGridDepoSatis.TabIndex = 0;
            // 
            // btnOdemeGoruntule
            // 
            this.btnOdemeGoruntule.Location = new System.Drawing.Point(49, 31);
            this.btnOdemeGoruntule.Name = "btnOdemeGoruntule";
            this.btnOdemeGoruntule.Size = new System.Drawing.Size(122, 37);
            this.btnOdemeGoruntule.TabIndex = 1;
            this.btnOdemeGoruntule.Text = "Ödeme Kayıtlarını Görüntüle";
            this.btnOdemeGoruntule.UseVisualStyleBackColor = true;
            this.btnOdemeGoruntule.Click += new System.EventHandler(this.btnOdemeGoruntule_Click);
            // 
            // btnRezervasyonGoruntule
            // 
            this.btnRezervasyonGoruntule.Location = new System.Drawing.Point(186, 31);
            this.btnRezervasyonGoruntule.Name = "btnRezervasyonGoruntule";
            this.btnRezervasyonGoruntule.Size = new System.Drawing.Size(123, 37);
            this.btnRezervasyonGoruntule.TabIndex = 2;
            this.btnRezervasyonGoruntule.Text = "Rezervasyon Kayıtlarını Görüntüle";
            this.btnRezervasyonGoruntule.UseVisualStyleBackColor = true;
            this.btnRezervasyonGoruntule.Click += new System.EventHandler(this.btnRezervasyonGoruntule_Click);
            // 
            // btnYemekhaneToplamUrun
            // 
            this.btnYemekhaneToplamUrun.Location = new System.Drawing.Point(338, 31);
            this.btnYemekhaneToplamUrun.Name = "btnYemekhaneToplamUrun";
            this.btnYemekhaneToplamUrun.Size = new System.Drawing.Size(145, 37);
            this.btnYemekhaneToplamUrun.TabIndex = 3;
            this.btnYemekhaneToplamUrun.Text = "Yemekhanelerdeki Toplam Ürün Sayılarını Görüntüle";
            this.btnYemekhaneToplamUrun.UseVisualStyleBackColor = true;
            this.btnYemekhaneToplamUrun.Click += new System.EventHandler(this.btnYemekhaneToplamUrun_Click);
            // 
            // btnSatilanUrunler
            // 
            this.btnSatilanUrunler.Location = new System.Drawing.Point(511, 31);
            this.btnSatilanUrunler.Name = "btnSatilanUrunler";
            this.btnSatilanUrunler.Size = new System.Drawing.Size(134, 37);
            this.btnSatilanUrunler.TabIndex = 4;
            this.btnSatilanUrunler.Text = "Satılan Ürün Miktarlarını Görüntüle";
            this.btnSatilanUrunler.UseVisualStyleBackColor = true;
            this.btnSatilanUrunler.Click += new System.EventHandler(this.btnSatilanUrunler_Click);
            // 
            // btnEnCokSatis
            // 
            this.btnEnCokSatis.Location = new System.Drawing.Point(186, 115);
            this.btnEnCokSatis.Name = "btnEnCokSatis";
            this.btnEnCokSatis.Size = new System.Drawing.Size(116, 47);
            this.btnEnCokSatis.TabIndex = 5;
            this.btnEnCokSatis.Text = "En Çok Satış Yapılan Ayı Görüntüle";
            this.btnEnCokSatis.UseVisualStyleBackColor = true;
            this.btnEnCokSatis.Click += new System.EventHandler(this.btnEnCokSatis_Click);
            // 
            // btnGelir
            // 
            this.btnGelir.Location = new System.Drawing.Point(338, 115);
            this.btnGelir.Name = "btnGelir";
            this.btnGelir.Size = new System.Drawing.Size(106, 47);
            this.btnGelir.TabIndex = 6;
            this.btnGelir.Text = "Gelir Görüntüle";
            this.btnGelir.UseVisualStyleBackColor = true;
            this.btnGelir.Click += new System.EventHandler(this.btnGelir_Click);
            // 
            // btnStok
            // 
            this.btnStok.Location = new System.Drawing.Point(477, 115);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(132, 47);
            this.btnStok.TabIndex = 7;
            this.btnStok.Text = "Stoktaki Ürünleri Görüntüle";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(72, 129);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(108, 20);
            this.txtYil.TabIndex = 8;
            // 
            // pxtGeriDon
            // 
            this.pxtGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.pxtGeriDon.Image = ((System.Drawing.Image)(resources.GetObject("pxtGeriDon.Image")));
            this.pxtGeriDon.Location = new System.Drawing.Point(12, 374);
            this.pxtGeriDon.Name = "pxtGeriDon";
            this.pxtGeriDon.Size = new System.Drawing.Size(56, 51);
            this.pxtGeriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxtGeriDon.TabIndex = 9;
            this.pxtGeriDon.TabStop = false;
            this.pxtGeriDon.Click += new System.EventHandler(this.pxtGeriDon_Click);
            // 
            // pxtExit
            // 
            this.pxtExit.BackColor = System.Drawing.Color.Transparent;
            this.pxtExit.Image = ((System.Drawing.Image)(resources.GetObject("pxtExit.Image")));
            this.pxtExit.Location = new System.Drawing.Point(695, 31);
            this.pxtExit.Name = "pxtExit";
            this.pxtExit.Size = new System.Drawing.Size(71, 58);
            this.pxtExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxtExit.TabIndex = 10;
            this.pxtExit.TabStop = false;
            this.pxtExit.Click += new System.EventHandler(this.pxtExit_Click);
            // 
            // Depo_Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Depo_Satis";
            this.Text = "Depo_Satis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepoSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtGeriDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridDepoSatis;
        private System.Windows.Forms.Button btnOdemeGoruntule;
        private System.Windows.Forms.Button btnRezervasyonGoruntule;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnGelir;
        private System.Windows.Forms.Button btnEnCokSatis;
        private System.Windows.Forms.Button btnSatilanUrunler;
        private System.Windows.Forms.Button btnYemekhaneToplamUrun;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.PictureBox pxtExit;
        private System.Windows.Forms.PictureBox pxtGeriDon;
    }
}