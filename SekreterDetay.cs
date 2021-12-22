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
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }
        public string TCno;
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCno;

            // ad soyadı sql databaseden çekme
            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreterler where SekreterTC=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",TCno);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            // branşları databaseden datagride çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // doktorları databaseden datagrid2 ye çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Doktorlar",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // branşları combobox a çekme

            SqlCommand branslar = new SqlCommand("select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader drbrans = branslar.ExecuteReader();
            while (drbrans.Read())
            {
                CmbBxBrans.Items.Add(drbrans[0].ToString());
            }
            bgl.baglanti().Close();
            
        }

        private void BtnKydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",MskdTxtBxTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",MskdTxtBxSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",CmbBxBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4",CmbBxDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void CmbBxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbBxDoktor.Items.Clear();
            CmbBxDoktor.Text = "";
            SqlCommand doktorcek = new SqlCommand("select (DoktorAd+' ' +DoktorSoyad) from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            doktorcek.Parameters.AddWithValue("@p1",CmbBxBrans.Text);
            SqlDataReader drdoktor = doktorcek.ExecuteReader();
            while (drdoktor.Read())
            {
                CmbBxDoktor.Items.Add(drdoktor[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnOlstur_Click(object sender, EventArgs e)
        {
            SqlCommand komutdyrolstr = new SqlCommand("insert into Tbl_Duyurular values (@d1)",bgl.baglanti());
            komutdyrolstr.Parameters.AddWithValue("@d1",RchTxtBxDuyuruOlstr.Text);
            komutdyrolstr.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Başarıyla Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void BtnDktrPnli_Click(object sender, EventArgs e)
        {
            DoktorPaneli frmdr = new DoktorPaneli();
            frmdr.Show();
        }

        private void BtnBrnsPnli_Click(object sender, EventArgs e)
        {
            FrmBrans frmbrns = new FrmBrans();
            frmbrns.Show();
        }

        private void BtnRndvular_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmrndv = new FrmRandevuListesi();
            frmrndv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmdyrlr = new FrmDuyurular();
            frmdyrlr.Show();
        }
    }
}
