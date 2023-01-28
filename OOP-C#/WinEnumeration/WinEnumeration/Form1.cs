using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinEnumeration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string[] plakalar = Enum.GetNames((typeof(Plakalar)));
            comboBox1.Items.AddRange(plakalar);


            foreach (string plaka in plakalar)
            {

                comboBox1.Items.Add(plaka);
            }

            //Cinsiyet c = Cinsiyet.Kadın;
            //int karsilik = (int)c;

            //Plakalar p = (Plakalar)44;
            //MessageBox.Show(p.ToString());

            //this.WindowState = FormWindowState.Normal;

        }

        enum Cinsiyet 
        { 
            Erkek,
            Kadın,
            Kerimcan
        
        }

        enum Plakalar
        {
            Mersin,
            Urfa,
            Malatya,
            Hatay
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedText = "Seciniz";
        }
    }
}
