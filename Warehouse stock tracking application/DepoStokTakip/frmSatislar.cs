using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoStokTakip
{
    public partial class frmSatislar : Form
    {
        public frmSatislar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CQN1L6N\\SQLEXPRESS01;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet datset = new DataSet();
        private void SatistListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(datset, "satis");
            dataGridView1.DataSource = datset.Tables["satis"];

            baglanti.Close();

        }
        private void frmSatislar_Load(object sender, EventArgs e)
        {
              SatistListele();
        }
    }
}
