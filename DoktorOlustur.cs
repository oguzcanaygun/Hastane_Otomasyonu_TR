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
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Doktorlar",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //branşları sayfa yüklenince databaseden combobox a çekme
            SqlCommand bransgetir = new SqlCommand("Select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = bransgetir.ExecuteReader();
            while (dr2.Read())
            {
                CmbBxBrans.Items.Add(dr2[0]);
            }


        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand doktorekle = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            doktorekle.Parameters.AddWithValue("@p1",TxtAd.Text);
            doktorekle.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            doktorekle.Parameters.AddWithValue("@p3",CmbBxBrans.Text);
            doktorekle.Parameters.AddWithValue("@p4",MskdTxtBxTC.Text);
            doktorekle.Parameters.AddWithValue("@p5",TxtBxSifre.Text);
            doktorekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Başarıyla Yapıldı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBxBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskdTxtBxTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtBxSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",MskdTxtBxTC.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4",bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1",TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3",CmbBxBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p4",MskdTxtBxTC.Text);
            komutguncelle.Parameters.AddWithValue("@p5",TxtBxSifre.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void CmbBxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
