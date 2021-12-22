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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Duyurular",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchTxtBxDuyuruOlstr.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void BtnOlstur_Click(object sender, EventArgs e)
        {
            SqlCommand dyrsil = new SqlCommand("delete from Tbl_Duyurular where Duyuruid=@p1",bgl.baglanti());
            dyrsil.Parameters.AddWithValue("@p1",textBox1.Text);
            dyrsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
