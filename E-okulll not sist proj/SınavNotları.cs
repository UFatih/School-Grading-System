using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_okulll_not_sist_proj
{
    public partial class SınavNotları : Form
    {
        public SınavNotları()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=MSI-GL65-LEOPAR\SQLEXPRESS;Initial Catalog=NotSistemi;Integrated Security=True");
        DataSet1TableAdapters.TBLNOTTableAdapter ds = new DataSet1TableAdapters.TBLNOTTableAdapter();
        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtogrid.Text));
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtdurum.Text = " ";
            txtogrid.Text = " ";
            txtortalama.Text = " ";
            txtproje.Text = " ";
            txtsınvbir.Text = " ";
            txtsınviki.Text = " ";
            txtsınvuc.Text = " ";
            cmbders.Text = " ";
        }

        private void SınavNotları_Load(object sender, EventArgs e)
        {
           

            bgl.Open();
            SqlCommand kmt = new SqlCommand("Select * From TBLDERS", bgl);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.DisplayMember = "DERSAD";
            cmbders.ValueMember = "DERSID";
            cmbders.DataSource = dt;
            bgl.Close();
        }

        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtogrid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsınvbir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsınviki.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsınvuc.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            
        }

            
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        private void btnhesapla_Click(object sender, EventArgs e)
        {
           
            sinav1 = Convert.ToInt16(txtsınvbir.Text);
            sinav2 = Convert.ToInt16(txtsınviki.Text);
            sinav3 = Convert.ToInt16(txtsınvuc.Text);
            proje = Convert.ToInt16(txtproje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtortalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                txtdurum.Text = "True";
            }
            else
                txtdurum.Text = "False";


        }   
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbders.SelectedValue.ToString()), int.Parse(txtogrid.Text), byte.Parse(txtsınvbir.Text), byte.Parse(txtsınviki.Text), byte.Parse(txtsınvuc.Text), byte.Parse(txtproje.Text), byte.Parse(txtortalama.Text), bool.Parse(txtdurum.Text), notid);

        }
    }
}
