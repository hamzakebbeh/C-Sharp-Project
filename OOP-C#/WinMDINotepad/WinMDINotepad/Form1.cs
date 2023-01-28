using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinMDINotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Form frmYeni = new Form();
            TextBox txt = new TextBox();
            frmYeni.MdiParent = this;
            txt.Multiline = true;
            txt.Dock = DockStyle.Fill;
            frmYeni.Text = "Dökuman";
            frmYeni.Controls.Add(txt);
            frmYeni.WindowState = FormWindowState.Maximized;
            frmYeni.Show();

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Metin Dosyaları(*.txt)|*.txt|Tüm Dosyalar|*.*";

            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Form frmYeni = new Form();
                TextBox txt = new TextBox();
                frmYeni.MdiParent = this;
                frmYeni.Text = o.SafeFileName;
                frmYeni.WindowState = FormWindowState.Maximized;
                txt.Multiline = true;
                txt.Dock = DockStyle.Fill;
                
                StreamReader sr = new StreamReader(o.FileName);
                txt.Text = sr.ReadToEnd();
                frmYeni.Controls.Add(txt);
                frmYeni.Show();

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Metin Dosyaları(*.txt)|*.txt|Tüm Dosyalar|*.*";

            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(s.FileName);
                sw.Write((this.ActiveMdiChild.ActiveControl as TextBox).Text);
                sw.Close();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            Form fAktif = this.ActiveMdiChild;
            if (fAktif != null)
            {
                TextBox tAktif = fAktif.ActiveControl as TextBox;
                if (tAktif != null)
                {
                    tAktif.Cut();

                }
                
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Form fAktif = this.ActiveMdiChild;
            if (fAktif != null)
            {
                TextBox tAktif = fAktif.ActiveControl as TextBox;
                if (tAktif != null)
                {
                    tAktif.Copy();
                    
                }
            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
