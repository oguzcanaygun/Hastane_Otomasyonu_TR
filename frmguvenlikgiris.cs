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
    public partial class frmguvenlikgiris : Form
    {
        public frmguvenlikgiris()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void frmguvenlikgiris_Load(object sender, EventArgs e)
        {
            


        }

        private void BtnGrsYap_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from Tbl_Guvenlikler where GuvenlikTC=@p1 and GuvenlikSifre=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskdTxtTC.Text);
            kmt.Parameters.AddWithValue("@p2", Txtsfre.Text);
            SqlDataReader da1 = kmt.ExecuteReader();
            if (da1.Read())
            {
                frmguvenlikdetay frxd = new frmguvenlikdetay();
                frxd.TCno = MskdTxtTC.Text;
                frxd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz Yanliş Giriş Yaptınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
