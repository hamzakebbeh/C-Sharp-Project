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
using System.Runtime.InteropServices;

namespace DepoStokTakip
{
    public partial class frmUrunEkleme : Form
    {
        public frmUrunEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CQN1L6N\\SQLEXPRESS01;Initial Catalog=Stok_Takip;Integrated Security=True");

        bool durum;
        private void BarkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select * from urun", baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBoxBarkodNoY.Text == read["barkodno"].ToString() || txtBoxBarkodNoY.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Kategoribilgilericagir()
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select * from Kategoribilgileri", baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxKategoriY.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmUrunEkleme_Load(object sender, EventArgs e)
        {
            Kategoribilgilericagir();
        }

        private void comboBoxKategoriY_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMarkaY.Items.Clear();
            comboBoxMarkaY.Text = "";

            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select * from markabilgileri where kategori='"+comboBoxKategoriY.SelectedItem+"'", baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxMarkaY.Items.Add(read["Marka"].ToString());
            }
            baglanti.Close();

        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand Komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,fiyat) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@fiyat)", baglanti);

                Komut.Parameters.AddWithValue("@barkodno", txtBoxBarkodNoY.Text);
                Komut.Parameters.AddWithValue("@kategori", comboBoxKategoriY.Text);
                Komut.Parameters.AddWithValue("@marka", comboBoxMarkaY.Text);
                Komut.Parameters.AddWithValue("@urunadi", txtBoxUrunAdiY.Text);
                Komut.Parameters.AddWithValue("@miktari", int.Parse(txtBoxMiktarY.Text));
                Komut.Parameters.AddWithValue("@fiyat", double.Parse(txtBoxFiyatY.Text));

                Komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir barkodno mevcut", "Uyarı");
            }
            comboBoxMarkaY.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox) 
                {
                    item.Text = "";
                }
            }
        }

        private void txtBoxBarkoNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxBarkoNo.Text=="")
            {
                lblMiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                { 
                    if (item is TextBox) 
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select * from urun where barkodno like '" + txtBoxBarkoNo.Text + "'", baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read()) 
            {
                txtBoxKategori.Text = read["kategori"].ToString();
                txtBoxMarka.Text = read["marka"].ToString();
                txtBoxUrunAdi.Text = read["urunadi"].ToString();
                lblMiktar.Text = read["miktari"].ToString() ;
                txtBoxFiyat.Text = read["fiyat"].ToString();

            }
            baglanti.Close();
        }

        private void btnOlanEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'"+int.Parse(txtBoxMiktar.Text)+"'where barkodno='"+txtBoxBarkoNo.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Ürün miktarına ekleme yapıldı");
        }
    }
}
