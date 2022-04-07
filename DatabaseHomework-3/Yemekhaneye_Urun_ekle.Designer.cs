namespace DatabaseHomework_3
{
    partial class Yemekhaneye_Urun_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yemekhaneye_Urun_ekle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridUrunEkle = new System.Windows.Forms.DataGridView();
            this.txtGuncelle = new System.Windows.Forms.TextBox();
            this.lblUrunEkle = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYemekhaneId = new System.Windows.Forms.TextBox();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.pctGeri = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pctGeri);
            this.panel1.Controls.Add(this.pctExit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUrunId);
            this.panel1.Controls.Add(this.txtYemekhaneId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.lblUrunEkle);
            this.panel1.Controls.Add(this.txtGuncelle);
            this.panel1.Controls.Add(this.dataGridUrunEkle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 461);
            this.panel1.TabIndex = 0;
            // 
            // dataGridUrunEkle
            // 
            this.dataGridUrunEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunEkle.Location = new System.Drawing.Point(177, 247);
            this.dataGridUrunEkle.Name = "dataGridUrunEkle";
            this.dataGridUrunEkle.Size = new System.Drawing.Size(418, 169);
            this.dataGridUrunEkle.TabIndex = 0;
            this.dataGridUrunEkle.Click += new System.EventHandler(this.dataGridUrunEkle_Click);
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.Location = new System.Drawing.Point(263, 147);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(210, 20);
            this.txtGuncelle.TabIndex = 1;
            // 
            // lblUrunEkle
            // 
            this.lblUrunEkle.AutoSize = true;
            this.lblUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunEkle.Location = new System.Drawing.Point(275, 30);
            this.lblUrunEkle.Name = "lblUrunEkle";
            this.lblUrunEkle.Size = new System.Drawing.Size(241, 24);
            this.lblUrunEkle.TabIndex = 2;
            this.lblUrunEkle.Text = "Yemekhaneye Ürün Ekle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(513, 139);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(82, 34);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yeni Ürün Miktarı:";
            // 
            // txtYemekhaneId
            // 
            this.txtYemekhaneId.Location = new System.Drawing.Point(225, 202);
            this.txtYemekhaneId.Name = "txtYemekhaneId";
            this.txtYemekhaneId.Size = new System.Drawing.Size(61, 20);
            this.txtYemekhaneId.TabIndex = 5;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(423, 203);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(83, 20);
            this.txtUrunId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yemekhane Id:";
            // 
            // pctExit
            // 
            this.pctExit.BackColor = System.Drawing.Color.Transparent;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(704, 23);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(58, 41);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 9;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // pctGeri
            // 
            this.pctGeri.BackColor = System.Drawing.Color.Transparent;
            this.pctGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctGeri.Image")));
            this.pctGeri.Location = new System.Drawing.Point(41, 45);
            this.pctGeri.Name = "pctGeri";
            this.pctGeri.Size = new System.Drawing.Size(63, 45);
            this.pctGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGeri.TabIndex = 10;
            this.pctGeri.TabStop = false;
            this.pctGeri.Click += new System.EventHandler(this.pctGeri_Click);
            // 
            // Yemekhaneye_Urun_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Yemekhaneye_Urun_ekle";
            this.Text = "Yemekhaneye_Urun_ekle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridUrunEkle;
        private System.Windows.Forms.Label lblUrunEkle;
        private System.Windows.Forms.TextBox txtGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtYemekhaneId;
        private System.Windows.Forms.PictureBox pctGeri;
        private System.Windows.Forms.PictureBox pctExit;
    }
}