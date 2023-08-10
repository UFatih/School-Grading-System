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
    public partial class Öğrencinotları : Form
    {
        public Öğrencinotları()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=MSI-GL65-LEOPAR\SQLEXPRESS;Initial Catalog=NotSistemi;Integrated Security=True");
        public string numara;
       
        private void Öğrencinotları_Load(object sender, EventArgs e)
        {
            
            SqlCommand kmt = new SqlCommand("SELECT DERSAD, SINAV1, SINAV2, SINAV3, PROJE, ORTALAMA, DURUM FROM TBLNOT INNER JOIN TBLDERS ON TBLNOT.DERSID = TBLDERS.DERSID where OGRENCIID=@P1",bgl);
            kmt.Parameters.AddWithValue("@P1", numara);
            //this.Text = numara;
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Formun üstüne öğrenci ismi yazdırma

            bgl.Open();

            SqlCommand komut1 = new SqlCommand("select OGRAD,OGRSOYAD from TBLOGRENCI where OGRID=@p1", bgl);

            komut1.Parameters.AddWithValue("@p1", numara);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())

            {

                this.Text = dr1[0] + " " + dr1[1].ToString();

            }

            bgl.Close();

        }
    }
}
