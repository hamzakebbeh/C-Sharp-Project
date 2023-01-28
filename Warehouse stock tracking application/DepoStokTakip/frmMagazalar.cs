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
    public partial class frmMagazalar : Form
    {
        public frmMagazalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CQN1L6N\\SQLEXPRESS01;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet datset = new DataSet();

        private void frmMagazalar_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
        }
        /// <summary>
        /// Kayit_Goster metodudur. magaza tablosundan magaza bilgileri dataGridView1 aktarmaktadır .
        /// </summary>
        private void Kayit_Goster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from magaza", baglanti);
            adtr.Fill(datset, "magaza");
            dataGridView1.DataSource = datset.Tables["magaza"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxMagazaIsmi.Text = dataGridView1.CurrentRow.Cells["magazaismi"].Value.ToString();
            txtBoxAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtBoxTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtBoxEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("update magaza set   adres=@adres , telefon=@telefon , email=@email where magazaismi=@magazaismi ", baglanti);
            Komut.Parameters.AddWithValue("@magazaismi", txtBoxMagazaIsmi.Text);
            Komut.Parameters.AddWithValue("@adres", txtBoxAdres.Text);
            Komut.Parameters.AddWithValue("@telefon", txtBoxTelefon.Text);
            Komut.Parameters.AddWithValue("@email", txtBoxEmail.Text);
            Komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables["magaza"].Clear();
            Kayit_Goster();
            MessageBox.Show("Mağaza kaydı güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("delete from magaza where magazaismi='" + dataGridView1.CurrentRow.Cells["magazaismi"].Value.ToString()+ "'", baglanti);
            Komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables["magaza"].Clear();
            Kayit_Goster();
            MessageBox.Show("kayıt silindi");

        }

        private void txtBoxAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from magaza where magazaismi like '%" + txtBoxAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
