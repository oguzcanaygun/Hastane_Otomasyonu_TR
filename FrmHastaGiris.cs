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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void LnkLblHstUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void BtnHstaGrsYp_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",MskdTxtTC.Text);
            kmt.Parameters.AddWithValue("@p2",TxtHstaSfre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = MskdTxtTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Edin Hatali Giris Yaptınız!");
            }
            bgl.baglanti().Close();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
