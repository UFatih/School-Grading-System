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
    public partial class Ders : Form
    {
        public Ders()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLDERSTableAdapter ds = new DataSet1TableAdapters.TBLDERSTableAdapter();
        private void Ders_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtadders.Text);
            MessageBox.Show("Bilgileriniz Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtidders.Text));
            MessageBox.Show("Bilgileriniz Silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btngunc_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(txtadders.Text, byte.Parse(txtidders.Text));
            MessageBox.Show("Bilgileriniz Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtidders.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtadders.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
