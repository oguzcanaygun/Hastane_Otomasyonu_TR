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

namespace Hastane_Otomasyon
{
    public partial class frmguvenlikdetay : Form
    {
        public frmguvenlikdetay()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        public string TCno;
        private void frmguvenlikdetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCno;

            //tcye göre ad soyadı databaseden çekme
            SqlCommand komut1 = new SqlCommand("select * from Tbl_Guvenlikler where GuvenlikTC=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",TCno);
            SqlDataReader da1 = komut1.ExecuteReader();
            while (da1.Read())
            {
                LblAdSyd.Text = da1[1].ToString() + " " + da1[2].ToString();
            }
            bgl.baglanti().Close();
            // datagride duyurları databaseden çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Duyurular",bgl.baglanti());
            da2.Fill(dt1);
            dataGridView1.DataSource = dt1;        

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formkroki frasd = new formkroki();
            frasd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
