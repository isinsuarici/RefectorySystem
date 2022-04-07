namespace DatabaseHomework_3
{
    partial class Yonetici_Kategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_Kategori));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dataGridKategori = new System.Windows.Forms.DataGridView();
            this.geriDon = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKategoriler = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.dataGridKategori);
            this.panel1.Controls.Add(this.geriDon);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.lblKategoriler);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 453);
            this.panel1.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(470, 119);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(123, 20);
            this.txtAd.TabIndex = 15;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(271, 119);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(97, 20);
            this.txtId.TabIndex = 14;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(397, 119);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(67, 13);
            this.lblAd.TabIndex = 13;
            this.lblAd.Text = "Kategori Adı:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(232, 122);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id:";
            // 
            // dataGridKategori
            // 
            this.dataGridKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKategori.Location = new System.Drawing.Point(178, 244);
            this.dataGridKategori.Name = "dataGridKategori";
            this.dataGridKategori.Size = new System.Drawing.Size(438, 195);
            this.dataGridKategori.TabIndex = 11;
            this.dataGridKategori.Click += new System.EventHandler(this.dataGridKategori_Click);
            // 
            // geriDon
            // 
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.Image = ((System.Drawing.Image)(resources.GetObject("geriDon.Image")));
            this.geriDon.Location = new System.Drawing.Point(11, 7);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(102, 53);
            this.geriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geriDon.TabIndex = 10;
            this.geriDon.TabStop = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(710, 13);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(77, 54);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 9;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(331, 180);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 30);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(511, 180);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(154, 30);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(146, 180);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(154, 30);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKategoriler
            // 
            this.lblKategoriler.AutoSize = true;
            this.lblKategoriler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriler.ForeColor = System.Drawing.Color.Maroon;
            this.lblKategoriler.Location = new System.Drawing.Point(293, 23);
            this.lblKategoriler.Name = "lblKategoriler";
            this.lblKategoriler.Size = new System.Drawing.Size(171, 37);
            this.lblKategoriler.TabIndex = 0;
            this.lblKategoriler.Text = "Kategoriler";
            // 
            // Yonetici_Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Yonetici_Kategori";
            this.Text = "Yonetici_Kategori";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKategoriler;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox geriDon;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.DataGridView dataGridKategori;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtId;
    }
}