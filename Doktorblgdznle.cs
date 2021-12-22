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
    public partial class Doktorblgdznle : Form
    {
        public Doktorblgdznle()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        public string TCno;
        private void BtnGncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2",Txtsyd.Text);
            komut2.Parameters.AddWithValue("@p3",CmbBxBrns.Text);
            komut2.Parameters.AddWithValue("@p4",TxtSfre.Text);
            komut2.Parameters.AddWithValue("@p5",mskdbxTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Basarıyla Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Doktorblgdznle_Load(object sender, EventArgs e)
        {
            mskdbxTC.Text = TCno;
            // form yüklendiginde doktor bilgilerini textboxlara getirme
            SqlCommand komut1 = new SqlCommand("select * from Tbl_Doktorlar Where DoktorTC=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",mskdbxTC.Text);
            SqlDataReader da1 = komut1.ExecuteReader();
            while (da1.Read())
            {
                TxtAd.Text = da1[1].ToString();
                Txtsyd.Text = da1[2].ToString();
                CmbBxBrns.Text = da1[3].ToString();
                TxtSfre.Text = da1[5].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
