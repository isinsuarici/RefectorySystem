using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseHomework_3
{
    public partial class Form1 : Form
    {
        public Yemekhane yemekhane = new Yemekhane();
        public FormKayit kayit = new FormKayit();
        public Form1()
        {
            InitializeComponent();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            yemekhane.ShowDialog();
        }

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            kayit.ShowDialog();
        }
    }
}
