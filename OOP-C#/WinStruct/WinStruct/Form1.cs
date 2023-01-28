using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinStruct
{
    struct Urun 
    {
        public string Adi;
        public int Fiyat;
        public int Stok;

        public override string ToString()
        {
            return Adi;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun u;
            u.Adi = textBox1.Text;
            u.Fiyat = int.Parse(textBox2.Text);
            u.Stok = int.Parse(textBox3.Text);

            listBox1.Items.Add(u);
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Urun USecilen = (Urun)listBox1.SelectedItem;
            lblAdi.Text = USecilen.Adi;
            lblFiyat.Text = USecilen.Fiyat.ToString();
            lblStok.Text = USecilen.Stok.ToString();

        }
    }
}
