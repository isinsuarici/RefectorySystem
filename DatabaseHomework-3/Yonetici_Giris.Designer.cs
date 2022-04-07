namespace DatabaseHomework_3
{
    partial class Yonetici_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_Giris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSifreyiDegistir = new System.Windows.Forms.Button();
            this.btnYoneticiPanelineGit = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblYazi = new System.Windows.Forms.Label();
            this.pctGeriDon = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGeriDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pctExit);
            this.panel1.Controls.Add(this.pctGeriDon);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnSifreyiDegistir);
            this.panel1.Controls.Add(this.btnYoneticiPanelineGit);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Controls.Add(this.lblYazi);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 273);
            this.panel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(385, 104);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 41);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSifreyiDegistir
            // 
            this.btnSifreyiDegistir.Location = new System.Drawing.Point(152, 201);
            this.btnSifreyiDegistir.Name = "btnSifreyiDegistir";
            this.btnSifreyiDegistir.Size = new System.Drawing.Size(137, 36);
            this.btnSifreyiDegistir.TabIndex = 4;
            this.btnSifreyiDegistir.Text = "Şifreyi Değiştir";
            this.btnSifreyiDegistir.UseVisualStyleBackColor = true;
            this.btnSifreyiDegistir.Click += new System.EventHandler(this.btnSifreyiDegistir_Click);
            // 
            // btnYoneticiPanelineGit
            // 
            this.btnYoneticiPanelineGit.Location = new System.Drawing.Point(328, 203);
            this.btnYoneticiPanelineGit.Name = "btnYoneticiPanelineGit";
            this.btnYoneticiPanelineGit.Size = new System.Drawing.Size(149, 33);
            this.btnYoneticiPanelineGit.TabIndex = 3;
            this.btnYoneticiPanelineGit.Text = "Yönetici Paneline Git";
            this.btnYoneticiPanelineGit.UseVisualStyleBackColor = true;
            this.btnYoneticiPanelineGit.Click += new System.EventHandler(this.btnYoneticiPanelineGit_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(102, 115);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(264, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(41, 118);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(31, 13);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblYazi
            // 
            this.lblYazi.AutoSize = true;
            this.lblYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazi.Location = new System.Drawing.Point(89, 50);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(290, 24);
            this.lblYazi.TabIndex = 0;
            this.lblYazi.Text = "Lütfen yönetici şifresini giriniz!";
            // 
            // pctGeriDon
            // 
            this.pctGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.pctGeriDon.Image = ((System.Drawing.Image)(resources.GetObject("pctGeriDon.Image")));
            this.pctGeriDon.Location = new System.Drawing.Point(24, 203);
            this.pctGeriDon.Name = "pctGeriDon";
            this.pctGeriDon.Size = new System.Drawing.Size(57, 43);
            this.pctGeriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGeriDon.TabIndex = 6;
            this.pctGeriDon.TabStop = false;
            this.pctGeriDon.Click += new System.EventHandler(this.pctGeriDon_Click);
            // 
            // pctExit
            // 
            this.pctExit.BackColor = System.Drawing.Color.Transparent;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(409, 14);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(56, 37);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 7;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // Yonetici_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 267);
            this.Controls.Add(this.panel1);
            this.Name = "Yonetici_Giris";
            this.Text = "Yonetici_Giris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGeriDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnYoneticiPanelineGit;
        private System.Windows.Forms.Button btnSifreyiDegistir;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pctGeriDon;
        private System.Windows.Forms.PictureBox pctExit;
    }
}