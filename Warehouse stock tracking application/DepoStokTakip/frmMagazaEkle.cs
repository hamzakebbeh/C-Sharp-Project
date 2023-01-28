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
    public partial class frmMagazaEkle : Form
    {
        //MagazaEkle maza = new MagazaEkle();
        public frmMagazaEkle()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CQN1L6N\\SQLEXPRESS01;Initial Catalog=Stok_Takip;Integrated Security=True");

       /* private void ClearControls()
        {
            txtBoxMagazaIsmi.Text = "";
            txtBoxAdres.Text = "";
            txtBoxTelefon.Text = "";
            txtBoxEmail.Text = "";
        }*/
        private void frmMagazaEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
             baglanti.Open();
             SqlCommand Komut = new SqlCommand("Insert into magaza(magazaismi,adres,telefon,email) values(@magazaismi,@adres,@telefon,@email)", baglanti);
             Komut.Parameters.AddWithValue("@magazaismi", txtBoxMagazaIsmi.Text);
             Komut.Parameters.AddWithValue("@adres", txtBoxAdres.Text);
             Komut.Parameters.AddWithValue("@telefon", txtBoxTelefon.Text);
             Komut.Parameters.AddWithValue("@email", txtBoxEmail.Text);
             Komut.ExecuteNonQuery();
             baglanti.Close();
             MessageBox.Show("Mağaza kaydı eklendi");
             foreach (Control item in this.Controls)
             {
                 if (item is TextBox)
                 {
                     item.Text = "";
                 }
             }
            /*maza.Magazaismi = txtBoxMagazaIsmi.Text;
            maza.Adres = txtBoxAdres.Text;
            maza.Telefon = txtBoxTelefon.Text;
            maza.Telefon = txtBoxEmail.Text;

            // Personel bilgilerini veritabanına eklemek için InsertPersonel metodunu çağırın.
            var kontrol = maza.InsertMagaza(maza);
            // Eklenen personelleri göstermek için listeyi yenileyin
            if (kontrol)
            {
                // Çalışan başarıyla eklendikten sonra kontrolleri temizleyin
                ClearControls();
                MessageBox.Show("Personel başarıyla eklendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");*/
        }
    }
}
