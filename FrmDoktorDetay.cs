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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string TCno;
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCno;

            //tcsi gelen doktorun adını soyadını databaseden çekme

            SqlCommand kmtadsydck = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            kmtadsydck.Parameters.AddWithValue("@p1",TCno);
            SqlDataReader dr1 = kmtadsydck.ExecuteReader();
            while (dr1.Read())
            {
                LblAdsyd.Text = dr1[0].ToString() + " " + dr1[1].ToString();
            }
            bgl.baglanti().Close();
            // Randevuları Getirme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='"+LblAdsyd.Text+"'",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;



        }

        private void BtnBlgDznl_Click(object sender, EventArgs e)
        {
            Doktorblgdznle frmdr = new Doktorblgdznle();
            frmdr.TCno = LblTC.Text;
            frmdr.Show();
        }

        private void BtnDyrlr_Click(object sender, EventArgs e)
        {
            duyurlarpleb dyrlplb = new duyurlarpleb();
            dyrlplb.Show();
        }

        private void BtnCks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchTxtSkyt.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }
    }
}
