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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Randevular",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskdTxtBxTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskdTxtBxSaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBxBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            CmbBxDoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MskdTxtBxTC.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand rndvsil = new SqlCommand("delete from Tbl_Randevular where Randevuid=@p1",bgl.baglanti());
            rndvsil.Parameters.AddWithValue("@p1",TxtID.Text);
            rndvsil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla Silindi");

        }
    }
}
