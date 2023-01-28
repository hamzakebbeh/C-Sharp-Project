using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinMDIGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac;
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sayac==0)
            {
                frmEkle f = new frmEkle();
                f.MdiParent = this;
                f.FormClosing += new FormClosingEventHandler(f_FormClosing);
                f.Show();
                sayac++;
                
            }

            
            
            
        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            sayac = 0;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSil f = new frmSil();
            f.MdiParent = this;
            f.Show();
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGuncelle f = new frmGuncelle();
            f.MdiParent = this;
            f.Show();
        }

        private void gosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoster f = new frmGoster();
            f.MdiParent = this; 
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);

        }
    }
}
