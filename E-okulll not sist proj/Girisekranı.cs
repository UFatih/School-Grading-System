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
    public partial class Girisekranı : Form
    {
        public Girisekranı()
        {
            InitializeComponent();
        }


       
        private void ogrencipng_Click(object sender, EventArgs e)
        {
            Öğrencinotları frm = new Öğrencinotları();
            frm.numara = textBox1.Text;
            frm.Show();

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightBlue;
        }

        private void ogretmenpng_Click(object sender, EventArgs e)
        {
            Ogretmen fr = new Ogretmen();
            fr.Show();
            this.Hide();
        }
    }
}
