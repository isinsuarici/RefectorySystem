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
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.lstYemekhane = new System.Windows.Forms.ListBox();
            this.lstKategori = new System.Windows.Forms.ListBox();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.lstAdet = new System.Windows.Forms.ListBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblYemekhane = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblUrunlerim = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.txtTutar);
            this.panel1.Controls.Add(this.lblTutar);
            this.panel1.Controls.Add(this.lblUrun);
            this.panel1.Controls.Add(this.lblKategori);
            this.panel1.Controls.Add(this.lblYemekhane);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Controls.Add(this.lstUrun);
            this.panel1.Controls.Add(this.lstKategori);
            this.panel1.Controls.Add(this.lstYemekhane);
            this.panel1.Controls.Add(this.txtTarih);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 452);
            this.panel1.TabIndex = 0;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(124, 57);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(259, 20);
            this.txtTarih.TabIndex = 0;
            // 
            // lstYemekhane
            // 
            this.lstYemekhane.FormattingEnabled = true;
            this.lstYemekhane.Location = new System.Drawing.Point(124, 97);
            this.lstYemekhane.Name = "lstYemekhane";
            this.lstYemekhane.Size = new System.Drawing.Size(259, 17);
            this.lstYemekhane.TabIndex = 4;
            // 
            // lstKategori
            // 
            this.lstKategori.FormattingEnabled = true;
            this.lstKategori.Location = new System.Drawing.Point(124, 145);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(259, 17);
            this.lstKategori.TabIndex = 5;
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.Location = new System.Drawing.Point(124, 193);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(152, 17);
            this.lstUrun.TabIndex = 6;
            // 
            // lstAdet
            // 
            this.lstAdet.FormattingEnabled = true;
            this.lstAdet.Location = new System.Drawing.Point(67, 184);
            this.lstAdet.Name = "lstAdet";
            this.lstAdet.Size = new System.Drawing.Size(82, 17);
            this.lstAdet.TabIndex = 7;
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
            // lblYemekhane
            // 
            this.lblYemekhane.AutoSize = true;
            this.lblYemekhane.Location = new System.Drawing.Point(36, 101);
            this.lblYemekhane.Name = "lblYemekhane";
            this.lblYemekhane.Size = new System.Drawing.Size(67, 13);
            this.lblYemekhane.TabIndex = 9;
            this.lblYemekhane.Text = "Yemekhane:";
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
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(36, 193);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(33, 13);
            this.lblUrun.TabIndex = 11;
            this.lblUrun.Text = "Ürün:";
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
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(34, 244);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 13);
            this.lblTutar.TabIndex = 13;
            this.lblTutar.Text = "Tutar:";
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
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(123, 237);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(51, 20);
            this.txtTutar.TabIndex = 16;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(104, 292);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(122, 20);
            this.txtToplamTutar.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 82);
            this.listBox1.TabIndex = 18;
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.lblToplam);
            this.panel2.Controls.Add(this.btnOdeme);
            this.panel2.Controls.Add(this.lblAdet);
            this.panel2.Controls.Add(this.lblUrunlerim);
            this.panel2.Controls.Add(this.btnRezervasyon);
            this.panel2.Controls.Add(this.lstAdet);
            this.panel2.Controls.Add(this.txtToplamTutar);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(410, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 452);
            this.panel2.TabIndex = 1;
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
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(183, 224);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(145, 25);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Seçili Ürünü Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstYemekhane;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblYemekhane;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.ListBox lstKategori;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.ListBox lstAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblUrunlerim;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuncelle;
    }
}