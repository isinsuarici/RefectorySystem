namespace DatabaseHomework_3
{
    partial class Yonetici_Yemekhane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_Yemekhane));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.dataGridYemekhane = new System.Windows.Forms.DataGridView();
            this.geriDon = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.lblYonetici_Yemekhaneler = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYemekhane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.lblAdres);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.lblKapasite);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtKapasite);
            this.panel1.Controls.Add(this.dataGridYemekhane);
            this.panel1.Controls.Add(this.geriDon);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.lblYonetici_Yemekhaneler);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(58, 108);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 35;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 105);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(124, 20);
            this.txtId.TabIndex = 34;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(411, 207);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(116, 34);
            this.btnGuncelle.TabIndex = 33;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(274, 207);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 34);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(149, 207);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 34);
            this.btnEkle.TabIndex = 31;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(244, 150);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 30;
            this.lblAdres.Text = "Adres:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(434, 105);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(85, 13);
            this.lblAd.TabIndex = 29;
            this.lblAd.Text = "Yemekhane Adı:";
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Location = new System.Drawing.Point(244, 108);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(51, 13);
            this.lblKapasite.TabIndex = 28;
            this.lblKapasite.Text = "Kapasite:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(305, 147);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(277, 20);
            this.txtAdres.TabIndex = 25;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(525, 102);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(196, 20);
            this.txtAd.TabIndex = 24;
            // 
            // txtKapasite
            // 
            this.txtKapasite.Location = new System.Drawing.Point(301, 106);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(101, 20);
            this.txtKapasite.TabIndex = 23;
            // 
            // dataGridYemekhane
            // 
            this.dataGridYemekhane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridYemekhane.Location = new System.Drawing.Point(42, 274);
            this.dataGridYemekhane.Name = "dataGridYemekhane";
            this.dataGridYemekhane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridYemekhane.Size = new System.Drawing.Size(653, 164);
            this.dataGridYemekhane.TabIndex = 22;
            this.dataGridYemekhane.Click += new System.EventHandler(this.dataGridYemekhane_Click);
            // 
            // geriDon
            // 
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.Image = ((System.Drawing.Image)(resources.GetObject("geriDon.Image")));
            this.geriDon.Location = new System.Drawing.Point(11, 12);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(87, 44);
            this.geriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geriDon.TabIndex = 21;
            this.geriDon.TabStop = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(706, 19);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 57);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 20;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblYonetici_Yemekhaneler
            // 
            this.lblYonetici_Yemekhaneler.AutoSize = true;
            this.lblYonetici_Yemekhaneler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblYonetici_Yemekhaneler.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYonetici_Yemekhaneler.ForeColor = System.Drawing.Color.Maroon;
            this.lblYonetici_Yemekhaneler.Location = new System.Drawing.Point(284, 19);
            this.lblYonetici_Yemekhaneler.Name = "lblYonetici_Yemekhaneler";
            this.lblYonetici_Yemekhaneler.Size = new System.Drawing.Size(222, 37);
            this.lblYonetici_Yemekhaneler.TabIndex = 0;
            this.lblYonetici_Yemekhaneler.Text = "Yemekhaneler";
            // 
            // Yonetici_Yemekhane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Yonetici_Yemekhane";
            this.Text = "Yonetici_Yemekhane";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYemekhane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblYonetici_Yemekhaneler;
        public System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox geriDon;
        public System.Windows.Forms.DataGridView dataGridYemekhane;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblKapasite;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtKapasite;
        public System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtId;
    }
}