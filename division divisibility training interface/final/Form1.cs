using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*string tipindeki verileri dizi içinde tanımlama*/
        string[] kurallar = {"1 İle Bölünebilme:Her sayı bölünür.",
        "2 İle Bölünebilme:Son rakamı çift sayı ise bölünür. Bir tam sayı 2 ile bölünmezse kalan her zaman 1 olur.",
        "3 İle Bölünebilme:Rakamların değerleri toplamı 3 veya üçün katları ise bölünür.",
        "4 İle Bölünebilme:Bir sayının birler ve onlar basamağı 00 ya da 4'ün katı ise sayı 4 ile bölünür.",
        "5 İle Bölünebilme:Son rakamı 0 veya 5 ise 5'e bölünür.",
        "6 İle Bölünebilme:Sayı hem 2'ye hem 3'e kalansız bölünebiliyorsa 6'ya da bölünür.",
        "7 İle Bölünebilme:Sayının rakamlarının altına birler basamağından başlayarak sırasıyla; (+1),(+3),(+2),(-1),(-3),(-2),(+1)... sayılarıyla çarpılır. Elde edilen sayıların toplamı 7'nin tam katı ise bu sayı 7 ile tam bölünüyor demektir.",
        "8 İle Bölünebilme:Son üç rakamı 8 ile tam bölünen ya da son üç rakamı 000 olan sayılar 8 e tam bölünebilir.",
        "9 İle Bölünebilme:Rakamların sayı değerleri toplamı 9 veya dokuzun katlarıysa bölünür.",
        "10 İle Bölünebilme:Son rakamı 0 ise bölünür."};
        string[] sayılar = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <=10; i++)/*combobox için veri yazdırma */
            {
                comboBox1.Items.Add(i);
            }
        }

        int sayii = 0;/* "sayii" int tipinde tanımlama ve 0 değeri atama*/
        int A; /*A'yı tanımlama */
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txt_sayi.Text);/* text box'ı int'e dönüştürmek ve s1 ataması*/
            int s2 = Convert.ToInt32(comboBox1.Text);/* combo box'ı int'e dönüştürmek ve s2 ataması*/
            lbl_sonuc.Text = (s1 / s2).ToString();/*label içinde aritmetik işlem (bölümü bulma)ve stringe çevirerek labele atamaktır */
             lbl_kalan.Text = (s1 % s2).ToString();/*label içinde aritmetik işlem (kalanı bulma)ve stringe çevirerek labele atamaktır */
            A = s1 % s2; /*int tipindeki A'ya kalanı atama*/
            if (A > 0)/* kalan 0'dan büyük ise şartı*/
            {
                listBox2.Items.Add ("UYARI!!!!:" +s1+ " sayısı " +s2+ " saysına  tam bölünmemektedir"  );/*şart sağlanıyorsa ekrana yazdırlacak yazı*/
            }

            sayii = Convert.ToInt32(comboBox1.Text);

            for (int j = 0; j < kurallar.Length ; j++)/*1.kural 10. kural arasında kalanlar  */
            {
                if (sayii.ToString() == sayılar[j])/*tür değişimi yapılıp şart ifadesi tanımlanmıştır*/
                {
                    listBox1.Items.Add(kurallar[j]);/*İllerin jsini eklenecektir*/
                }
            }
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txt_sayi.Text);
            int s2 = Convert.ToInt32(comboBox1.Text);
            lbl_sonuc.Text = (s1 / s2).ToString();
            lbl_kalan.Text = (s1 % s2).ToString();
            A = s1 % s2;
            if (A > 0)
            {
                listBox2.Items.Add( "UYARI!!!:" +s1 + " sayısı " + s2 + " saysına  tam bölünmemektedir");
            }

            sayii = Convert.ToInt32(comboBox1.Text);

            for (int j = 0; j < kurallar.Length; j++)
            {
                if (sayii.ToString() == sayılar[j])
                {
                    listBox1.Items.Add(kurallar[j]);
                }
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = MessageBox.Show("Kapatmak istediğinize emin misiniz? ", "HAMZA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;/*kullanıcı uygulamayı kapatmak istediğinde karşısına açılacak olan evet ve hayır seçenekleri*/
            if (tus == DialogResult.Yes)/*eğer eveti seçerse */
            {
                Close();/*uygulama kapanacaktır*/
            }
        }

        private void lbl_sonuc_Click(object sender, EventArgs e)
        {

        }

        private void lbl_kalan_Click(object sender, EventArgs e)
        {

        }
    }
}
