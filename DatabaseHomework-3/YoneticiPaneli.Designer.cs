namespace DatabaseHomework_3
{
    partial class YoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAlanSec = new System.Windows.Forms.ComboBox();
            this.lblAlanSec = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.geriDon = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.cmbAlanSec);
            this.panel1.Controls.Add(this.lblAlanSec);
            this.panel1.Location = new System.Drawing.Point(189, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 454);
            this.panel1.TabIndex = 0;
            // 
            // cmbAlanSec
            // 
            this.cmbAlanSec.FormattingEnabled = true;
            this.cmbAlanSec.Items.AddRange(new object[] {
            "Yemekhaneler",
            "Kategoriler",
            "Ürünler",
            "Depo-Satış",
            "Yemekhaneye Ürün Ekle"});
            this.cmbAlanSec.Location = new System.Drawing.Point(56, 135);
            this.cmbAlanSec.Name = "cmbAlanSec";
            this.cmbAlanSec.Size = new System.Drawing.Size(259, 21);
            this.cmbAlanSec.TabIndex = 1;
            this.cmbAlanSec.SelectedIndexChanged += new System.EventHandler(this.cmbAlanSec_SelectedIndexChanged);
            // 
            // lblAlanSec
            // 
            this.lblAlanSec.AutoSize = true;
            this.lblAlanSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlanSec.Location = new System.Drawing.Point(43, 81);
            this.lblAlanSec.Name = "lblAlanSec";
            this.lblAlanSec.Size = new System.Drawing.Size(272, 20);
            this.lblAlanSec.TabIndex = 0;
            this.lblAlanSec.Text = "İşlem yapmak istediğiniz alanı seçiniz.";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.geriDon);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 451);
            this.panel2.TabIndex = 1;
            // 
            // geriDon
            // 
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.Image = ((System.Drawing.Image)(resources.GetObject("geriDon.Image")));
            this.geriDon.Location = new System.Drawing.Point(65, 33);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(59, 59);
            this.geriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geriDon.TabIndex = 1;
            this.geriDon.TabStop = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(664, 33);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(64, 66);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "YoneticiPaneli";
            this.Text = "YoneticiPaneli";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.geriDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAlanSec;
        public System.Windows.Forms.ComboBox cmbAlanSec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox geriDon;
        private System.Windows.Forms.PictureBox Exit;
    }
}