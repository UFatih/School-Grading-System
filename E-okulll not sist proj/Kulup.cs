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
    public partial class Kulup : Form
    {
        public Kulup()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=MSI-GL65-LEOPAR\SQLEXPRESS;Initial Catalog=NotSistemi;Integrated Security=True");

        public void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLKULUP", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


      

        private void btnlist_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void btntmzle_Click(object sender, EventArgs e)
        {
            txtad.Text = " ";
            txtid.Text = " ";
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt1 = new SqlCommand("INSERT INTO TBLKULUP (KULUPAD) VALUES (@P1)", bgl);
            kmt1.Parameters.AddWithValue("@P1", txtad.Text);
            kmt1.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Bilgileriniz Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt2 = new SqlCommand("Delete from  TBLKULUP where KULUPID=@P1", bgl);
            kmt2.Parameters.AddWithValue("@P1", txtid.Text);
            kmt2.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Bilgileriniz silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();
        }

        private void btngunc_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt3 = new SqlCommand("Update TBLKULUP set KULUPAD=@P1 where KULUPID=@P2", bgl);
            kmt3.Parameters.AddWithValue("@P1", txtad.Text);
            kmt3.Parameters.AddWithValue("@p2", txtid.Text);
            kmt3.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Bilgileriniz güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();


        }

        private void Kulup_Load(object sender, EventArgs e)
        {
            liste();
        }
    }
}
