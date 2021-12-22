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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnHstaGrsYp_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskdTxtTC.Text);
            komut.Parameters.AddWithValue("@p2", Txtsfre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SekreterDetay frm = new SekreterDetay();
                frm.TCno = MskdTxtTC.Text;
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Bilglerinizi Kontrol Ediniz!", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
        }
    }
}
