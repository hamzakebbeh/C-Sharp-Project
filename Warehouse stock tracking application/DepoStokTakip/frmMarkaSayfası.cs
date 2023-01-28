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
    public partial class frmMarkaSayfasi : Form
    {
        public frmMarkaSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CQN1L6N\\SQLEXPRESS01;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void MarkaKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select *from markabilgileri", baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBoxKategori.Text == read["kategori"].ToString() && txtBoxMarka.Text == read["marka"].ToString() || comboBoxKategori.Text== "" || txtBoxMarka.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void frmMarkaSayfasi_Load(object sender, EventArgs e)
        {
            Kategoribilgilericagir();

        }

        private void Kategoribilgilericagir()
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select * from Kategoribilgileri", baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarkaKontrol();
            if (durum == true)
            {

                baglanti.Open();
                SqlCommand Komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + comboBoxKategori.Text + "','" + txtBoxMarka.Text + "')", baglanti);
                Komut.ExecuteNonQuery();
                baglanti.Close();
               

                MessageBox.Show("Marka  eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori ve marka mevcut", "Uyarı");
            }
            txtBoxMarka.Text = "";
            comboBoxKategori.Text = "";
        }
    }
}
