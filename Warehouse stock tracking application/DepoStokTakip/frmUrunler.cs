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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CQN1L6N\\SQLEXPRESS01;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet datset = new DataSet();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            UrunListele();
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
        private void UrunListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(datset, "urun");
            dataGridView1.DataSource = datset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBoxBarkoNo.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txtBoxKategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtBoxMarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txtBoxUrunAdi.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txtBoxMiktar.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            txtBoxFiyat.Text = dataGridView1.CurrentRow.Cells["fiyat"].Value.ToString();

        }

        private void btGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("update urun set urunadi=@urunadi, miktari=@miktari, fiyat=@fiyat where barkodno=@barkodno", baglanti);
            Komut.Parameters.AddWithValue("@barkodno",txtBoxBarkoNo.Text);
            Komut.Parameters.AddWithValue("@urunadi",txtBoxUrunAdi.Text);
            Komut.Parameters.AddWithValue("@miktari",int.Parse(txtBoxMiktar.Text));
            Komut.Parameters.AddWithValue("@fiyat",double.Parse(txtBoxFiyat.Text));
            Komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables["urun"].Clear();
            UrunListele();

            MessageBox.Show("Güncelleme tamamlanmıştır");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxBarkoNo.Text))
            {
                baglanti.Open();
                SqlCommand Komut = new SqlCommand("update urun set kategori=@kategori, marka=@marka  where barkodno=@barkodno", baglanti);
                Komut.Parameters.AddWithValue("@barkodno", txtBoxBarkoNo.Text);
                Komut.Parameters.AddWithValue("@kategori", comboBoxKategori.Text);
                Komut.Parameters.AddWithValue("@marka", comboBoxMarka.Text);
                Komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme tamamlanmıştır");
                datset.Tables["urun"].Clear();
                UrunListele();
            }
            else
            {
                MessageBox.Show("Barkodno yazılı değil");
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMarka.Items.Clear();
            comboBoxMarka.Text = "";

            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select * from markabilgileri where kategori='" + comboBoxKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxMarka.Items.Add(read["Marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+ "'", baglanti);
            Komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("kayıt silindi");
        }

        private void txtBoxBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where barkodno like '%" + txtBoxBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
