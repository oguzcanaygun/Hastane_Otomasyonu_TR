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
    public partial class duyurlarpleb : Form
    {
        public duyurlarpleb()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();

        private void duyurlarpleb_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Duyurular",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }
    }
}
