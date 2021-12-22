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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        
        private void BtnHstaGrsYp_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",MskdTxtTC.Text);
            komut1.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                FrmDoktorDetay drdty = new FrmDoktorDetay();
                drdty.TCno = MskdTxtTC.Text;
                drdty.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Giris Yaptınız Bilgilerinizi Kontrol Ediniz!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}
