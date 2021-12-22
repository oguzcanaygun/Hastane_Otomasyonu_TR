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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            // ad soyad çekme
            SqlCommand kmt = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevu geçmişini çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTC="+LblTC.Text,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları comboboxa çekme
            SqlCommand kmt2 = new SqlCommand("select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr1 = kmt2.ExecuteReader();
            while (dr1.Read())
            {
                CmbDktrBrans.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();

            

        }

        private void CmbDktrBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // branşı seçilen doktorları combobox a ekleme
            CmbDoktor.Items.Clear();
            CmbDoktor.Text = "";
            SqlCommand kmt3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@p1", CmbDktrBrans.Text);
            SqlDataReader dr2 = kmt3.ExecuteReader();
            while (dr2.Read())
            {
                CmbDoktor.Items.Add(dr2[0] + " " + dr2[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='" + CmbDktrBrans.Text + "'"+" and RandevuDoktor='"+CmbDoktor.Text+"'and RandevuDurum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LnkBlgDznle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBlgDznle fr = new FrmBlgDznle();
            fr.TCno = LblTC.Text;
            fr.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRndvAl_Click(object sender, EventArgs e)
        {
            SqlCommand rndvual = new SqlCommand("update Tbl_Randevular set RandevuDurum=1,HastaTC=@p2,HastaSikayet=@p3 where Randevuid=@p1",bgl.baglanti());
            rndvual.Parameters.AddWithValue("@p1",TxtID.Text);
            rndvual.Parameters.AddWithValue("@p2",LblTC.Text);
            rndvual.Parameters.AddWithValue("@p3",RchTxtSıkyt.Text);
            rndvual.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Basarıyla Alındı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
