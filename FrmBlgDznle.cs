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
    public partial class FrmBlgDznle : Form
    {
        public FrmBlgDznle()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        public string TCno;

        private void FrmBlgDznle_Load(object sender, EventArgs e)
        {
            MskdTcTxt.Text = TCno;

            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TCno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxSyd.Text = dr[2].ToString();
                MskdTxtTlfn.Text = dr[4].ToString();
                TxtSfre.Text = dr[5].ToString();
                CmbBxCnsyt.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2",TxSyd.Text);
            komut2.Parameters.AddWithValue("@p3",MskdTxtTlfn.Text);
            komut2.Parameters.AddWithValue("@p4",TxtSfre.Text);
            komut2.Parameters.AddWithValue("@p5",CmbBxCnsyt.Text);
            komut2.Parameters.AddWithValue("@p6",TCno);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla Güncellendi","Bilgi Kutusu",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
        
        
    }
}
