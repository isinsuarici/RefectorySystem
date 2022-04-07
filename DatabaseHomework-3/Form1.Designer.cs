namespace DatabaseHomework_3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblGiris = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblKayitOl = new System.Windows.Forms.Label();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctYoneticiPanelineGit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctYoneticiPanelineGit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(261, 212);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 13);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "e-mail:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(261, 255);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(31, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(308, 209);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(141, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(308, 252);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(141, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.BackColor = System.Drawing.Color.Black;
            this.lblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.Salmon;
            this.lblGiris.Location = new System.Drawing.Point(267, 138);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(202, 42);
            this.lblGiris.TabIndex = 5;
            this.lblGiris.Text = "GİRİŞ YAP";
            this.lblGiris.Click += new System.EventHandler(this.lblGiris_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(326, 320);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(98, 52);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblKayitOl
            // 
            this.lblKayitOl.AutoSize = true;
            this.lblKayitOl.Location = new System.Drawing.Point(256, 290);
            this.lblKayitOl.Name = "lblKayitOl";
            this.lblKayitOl.Size = new System.Drawing.Size(223, 13);
            this.lblKayitOl.TabIndex = 7;
            this.lblKayitOl.Text = "Henüz kayıtlı değil misin? Kaydolmak için tıkla.";
            this.lblKayitOl.Click += new System.EventHandler(this.lblKayitOl_Click);
            // 
            // pctExit
            // 
            this.pctExit.BackColor = System.Drawing.Color.Transparent;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(651, 59);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(82, 68);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 8;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pctYoneticiPanelineGit);
            this.panel1.Controls.Add(this.pctExit);
            this.panel1.Controls.Add(this.lblKayitOl);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.lblGiris);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 493);
            this.panel1.TabIndex = 9;
            // 
            // pctYoneticiPanelineGit
            // 
            this.pctYoneticiPanelineGit.BackColor = System.Drawing.Color.Transparent;
            this.pctYoneticiPanelineGit.Image = ((System.Drawing.Image)(resources.GetObject("pctYoneticiPanelineGit.Image")));
            this.pctYoneticiPanelineGit.Location = new System.Drawing.Point(12, 21);
            this.pctYoneticiPanelineGit.Name = "pctYoneticiPanelineGit";
            this.pctYoneticiPanelineGit.Size = new System.Drawing.Size(116, 120);
            this.pctYoneticiPanelineGit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctYoneticiPanelineGit.TabIndex = 9;
            this.pctYoneticiPanelineGit.TabStop = false;
            this.pctYoneticiPanelineGit.Click += new System.EventHandler(this.pctYoneticiPanelineGit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 494);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctYoneticiPanelineGit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblGiris;
        public System.Windows.Forms.TextBox txtMail;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Button btnGiris;
        public System.Windows.Forms.Label lblKayitOl;
        public System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctYoneticiPanelineGit;
    }
}

