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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CQN1L6N\\SQLEXPRESS01;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet datset = new DataSet();
        /// <summary>
        /// sepet listele metotudur bu metottu çağırdığımızda "sepet" tablosundan 
        /// verileri dataGridView1 e aktaracaktır.
        /// </summary>
        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet",baglanti);
            adtr.Fill(datset, "sepet");
            dataGridView1.DataSource= datset.Tables["sepet"];
          
            baglanti.Close();

        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBoxToplamFiyat.Text = (double.Parse(txtBoxMiktar.Text) * double.Parse(txtBoxFiyat.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select *from urun  where barkodno like '" + txtBoxBarkod.Text + "'", baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                txtBoxUrunAdi.Text = read["urunadi"].ToString();
                txtBoxFiyat.Text = read["fiyat"].ToString();
            }
            baglanti.Close();
        }
        /// <summary>
        /// Temizle metotudur. bu metodu çağırdığımızda txtBoxBarkodun Text boş ise txtBoxMiktar 
        /// hariç tüm txtBoxlar boş olacaktır.
        /// </summary>
        private void Temizle()
        {
            if (txtBoxBarkod.Text == "")
            {
                foreach (Control item in groupBoxUrun.Controls)
                {

                    if (item is TextBox)
                    {
                        if (item != txtBoxMiktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBoxToplamFiyat.Text =(double.Parse(txtBoxMiktar.Text) * double.Parse(txtBoxFiyat.Text)).ToString();
            }
            catch(Exception)
            {
                ;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxUrunAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMagazaEkle_Click(object sender, EventArgs e)
        {
            frmMagazaEkle ekle = new frmMagazaEkle();
            ekle.ShowDialog();
        }

        private void btnMagazalar_Click(object sender, EventArgs e)
        {
            frmMagazalar listele = new frmMagazalar();
            listele.ShowDialog();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkleme ekleme= new frmUrunEkleme();
            ekleme.ShowDialog(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarkaSayfasi marka= new frmMarkaSayfasi();
            marka.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKategoriSayfasi kategori = new frmKategoriSayfasi();
            kategori.ShowDialog();
        }

        private void btnUrunListe_Click(object sender, EventArgs e)
        {
            frmUrunler listele = new frmUrunler();
            listele.ShowDialog();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
        }
        /// <summary>
        /// Hesapla metodudur. bu metotta toplam fiyatı sepet tablosundan alıp lblGenelToplamın text kısmına yazacaktır.
        /// </summary>
        private void Hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand Koumt = new SqlCommand("select sum(toplamfiyat) from sepet",baglanti);
                lblGenelToplam.Text = Koumt.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch(Exception )
            {
                ;
            }
        }
        private void txtBoxMagaza_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxMagaza.Text=="")
            {
                txtBoxTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select *from magaza  where magazaismi like '"+txtBoxMagaza.Text+"'",baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read()) 
            {
                txtBoxTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }
        bool durum;
        private void BarkodKontrol()
        {
            durum= true;
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("select * from sepet",baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while(read.Read())
            {
                if (txtBoxBarkod.Text == read["barkodno"].ToString())
                {
                    durum = false; 
                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        { 
            BarkodKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand Komut = new SqlCommand("insert into sepet(magaza,telefon,barkodno,urunadi,miktari,fiyat,tarih,toplamfiyat) values(@magaza,@telefon,@barkodno,@urunadi,@miktari,@fiyat,@tarih,@toplamfiyat)", baglanti);
                Komut.Parameters.AddWithValue("magaza", txtBoxMagaza.Text);
                Komut.Parameters.AddWithValue("telefon", txtBoxTelefon.Text);
                Komut.Parameters.AddWithValue("barkodno", txtBoxBarkod.Text);
                Komut.Parameters.AddWithValue("urunadi", txtBoxUrunAdi.Text);
                Komut.Parameters.AddWithValue("miktari", int.Parse(txtBoxMiktar.Text));
                Komut.Parameters.AddWithValue("fiyat", double.Parse(txtBoxFiyat.Text));
                Komut.Parameters.AddWithValue("toplamfiyat", double.Parse(txtBoxToplamFiyat.Text));
                Komut.Parameters.AddWithValue("tarih", DateTime.Now.ToString());
                Komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand Komut2= new SqlCommand("update sepet set miktari=miktari+'"+int.Parse(txtBoxMiktar.Text)+ "' where barkodno='"+txtBoxBarkod.Text+"'", baglanti);
                
                SqlCommand Komut3 = new SqlCommand("update sepet set toplamfiyat=miktari*fiyat where barkodno='"+txtBoxBarkod.Text+"'", baglanti);
                
                Komut2.ExecuteNonQuery();
                Komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            
            txtBoxMiktar.Text = "1";
            datset.Tables["sepet"].Clear();
            SepetListele(); 
            Hesapla();
            foreach (Control item in groupBoxUrun.Controls)
            {

                if (item is TextBox)
                {
                    if (item != txtBoxMiktar)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("delete from sepet where barkodno='"+ dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'",baglanti);
            Komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün sepetten çıkarıldı");
            datset.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
        }

        private void btnSatişIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("delete from sepet", baglanti);
            Komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler sepetten çıkarıldı");
            datset.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
        }

        private void btnSatisListele_Click(object sender, EventArgs e)
        {
            frmSatislar listele = new frmSatislar();
            listele.ShowDialog();
        }

        private void btnSatişYap_Click(object sender, EventArgs e)
        {
            for (int i =0; i<dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand Komut = new SqlCommand("insert into satis(magaza,telefon,barkodno,urunadi,miktari,fiyat,tarih,toplamfiyat) values(@magaza,@telefon,@barkodno,@urunadi,@miktari,@fiyat,@tarih,@toplamfiyat)", baglanti);
                Komut.Parameters.AddWithValue("magaza", txtBoxMagaza.Text);
                Komut.Parameters.AddWithValue("telefon", txtBoxTelefon.Text);
                Komut.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                Komut.Parameters.AddWithValue("urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                Komut.Parameters.AddWithValue("miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                Komut.Parameters.AddWithValue("fiyat", double.Parse(dataGridView1.Rows[i].Cells["fiyat"].Value.ToString()));
                Komut.Parameters.AddWithValue("toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                Komut.Parameters.AddWithValue("tarih", DateTime.Now.ToString());
                Komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" +int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "'where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            
            baglanti.Open();
            SqlCommand Komut3 = new SqlCommand("delete from sepet", baglanti);
            Komut3.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
        }
    }
}
