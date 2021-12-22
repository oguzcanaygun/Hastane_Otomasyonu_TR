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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Branslar",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand brnsekle = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)",bgl.baglanti());
            brnsekle.Parameters.AddWithValue("@p1",TxtBransAD.Text);
            brnsekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBransID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand brnssil = new SqlCommand("delete from Tbl_Branslar where Bransid=@p1",bgl.baglanti());
            brnssil.Parameters.AddWithValue("@p1",TxtBransID.Text);
            brnssil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand brnsguncelle = new SqlCommand("update Tbl_Branslar set BransAd=@p2 where Bransid=@p1",bgl.baglanti());
            brnsguncelle.Parameters.AddWithValue("@p1",TxtBransID.Text);
            brnsguncelle.Parameters.AddWithValue("@p2",TxtBransAD.Text);
            brnsguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
