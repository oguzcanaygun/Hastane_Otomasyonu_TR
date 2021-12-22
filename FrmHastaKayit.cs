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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void BtnKytOl_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into dbo.Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",TxtAd.Text);
            kmt.Parameters.AddWithValue("@p2",TxtSyd.Text);
            kmt.Parameters.AddWithValue("@p3",TxtTc.Text);
            kmt.Parameters.AddWithValue("@p4",MskdTxtTlfn.Text);
            kmt.Parameters.AddWithValue("@p5",TxtSfre.Text);
            kmt.Parameters.AddWithValue("@p6",CmbBxCnsyt.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Yapıldı Şifreniz:"+TxtSfre.Text,"Kayıt Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
