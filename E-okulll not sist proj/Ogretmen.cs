using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_okulll_not_sist_proj
{
    public partial class Ogretmen : Form
    {
        public Ogretmen()
        {
            InitializeComponent();
        }

        private void btnkulupislm_Click(object sender, EventArgs e)
        {
            Kulup frm = new Kulup();
            frm.Show();
            this.Hide();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndersislm_Click(object sender, EventArgs e)
        {
            Ders frm = new Ders();
            frm.Show();
            this.Hide();
        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            Ogrenci frm = new Ogrenci();
            frm.Show();
            this.Hide();
        }

        private void btnsınavnot_Click(object sender, EventArgs e)
        {
            SınavNotları frm = new SınavNotları();
            frm.Show();
            this.Hide();
        }
    }
}
