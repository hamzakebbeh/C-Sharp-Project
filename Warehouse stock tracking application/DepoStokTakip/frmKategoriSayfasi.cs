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


namespace DepoStokTakip
{
    public partial class frmKategoriSayfasi : Form
    {
        public frmKategoriSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CQN1L6N\\SQLEXPRESS01;Initial Catalog=Stok_Takip;Integrated Security=True");

        bool durum;
        private void KategoriKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBoxKategori.Text == read["kategori"].ToString() || txtBoxKategori.Text == "") 
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void frmKategoriSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand Komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + txtBoxKategori.Text + "')", baglanti);
                Komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kategori eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori mevcut", "!!Uyarı");
            }
            txtBoxKategori.Text = "";
        }
    }
}
