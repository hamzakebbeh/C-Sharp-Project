using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinInstance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1=20;
            int sayi2 = 30;
            sayi1 = sayi2;
            MessageBox.Show(sayi2.ToString());


            Klima k1 = new Klima();
            k1.fiyat = 1200;
            Klima k2 = new Klima();
            k2.fiyat = 1500;
            k1 = k2;
            MessageBox.Show(k1.fiyat.ToString());
        }
    }
}
