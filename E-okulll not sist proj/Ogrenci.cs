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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=MSI-GL65-LEOPAR\SQLEXPRESS;Initial Catalog=NotSistemi;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void Ogrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();

            bgl.Open();
            SqlCommand kmt = new SqlCommand("Select * From TBLKULUP", bgl);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbogrklp.DisplayMember = "KULUPAD";
            cmbogrklp.ValueMember = "KULUPID";
            cmbogrklp.DataSource = dt;
            bgl.Close();
         
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntmzle_Click(object sender, EventArgs e)
        {
            txtograd.Text = " ";
            txtogrid.Text = " ";
            txtogrsoyad.Text = " ";
            txtograra.Text = " ";
            cmbogrklp.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
         
            ds.OgrenciEkle(txtograd.Text, txtogrsoyad.Text, byte.Parse(cmbogrklp.SelectedValue.ToString()), cinsiyet);
            MessageBox.Show("Bilgileriniz Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void cmbogrklp_SelectedIndexChanged(object sender, EventArgs e)
        {
           // txtogrid.Text = cmbogrklp.SelectedValue.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtogrid.Text));
            MessageBox.Show("Bilgileriniz Silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


         string cinsiyet = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            

            txtogrid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtograd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtogrsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           
            cinsiyet = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


            if (cinsiyet == "KIZ")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }

            if (cinsiyet == "ERKEK")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                

            }

            cmbogrklp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btngunc_Click(object sender, EventArgs e)
        {
            ds.OgrenciGüncelle(txtograd.Text, txtogrsoyad.Text, byte.Parse(cmbogrklp.SelectedValue.ToString()), cinsiyet, int.Parse(txtogrid.Text));
            MessageBox.Show("Bilgileriniz Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked == true)
            {
                cinsiyet = "KIZ";
            }

         

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
           

            if (radioButton2.Checked == true)
            {
                cinsiyet = "ERKEK";
            }

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciGetir(txtograra.Text);
        }
    }
}
