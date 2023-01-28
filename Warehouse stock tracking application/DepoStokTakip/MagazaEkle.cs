using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DepoStokTakip
{
    public class MagazaEkle
    {
        
            
            string _Magazaismi;
            string _adres;
            string _telefon;
            string _email;

            public string Magazaismi { get => _Magazaismi; set => _Magazaismi = value; }
            public string Adres { get => _adres; set => _adres = value; }
            public string Telefon { get => _telefon; set => _telefon = value; }
            public string Email { get => _email; set => _email = value; }


        private static string myConn = ConfigurationManager.ConnectionStrings["DepoStokTakip.Properties.Settings.Stok_TakipConnectionString"].ConnectionString;
        private const string InsertQuery = "Insert into magaza(magazaismi,adres,telefon,email) values(@MagazaEklemagazaismi,@MagazaEkleadres,@MagazaEkletelefon,@MagazaEkleemail)";

        public bool InsertMagaza(MagazaEkle magazaEkle)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@MagazaEklemagazaismi", magazaEkle.Magazaismi);
                    com.Parameters.AddWithValue("@MagazaEkleadres", magazaEkle.Adres);
                    com.Parameters.AddWithValue("@MagazaEkletelefon", magazaEkle.Telefon);
                    com.Parameters.AddWithValue("@MagazaEkleemail", magazaEkle.Email);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }




    }

}
