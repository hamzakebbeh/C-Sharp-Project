using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinOOPGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bayan b = new Bayan();
            b.adi = "Miranda Kerr";
            b.boy = 185;
            b.kilo = 45;
            b.olculer = "89-58-90";

            MessageBox.Show(b.DirDir());
        }
    }
}
