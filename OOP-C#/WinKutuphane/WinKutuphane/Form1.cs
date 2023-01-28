using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinKutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            BaslangicNodeOlustur();

            comboBox1.Items.AddRange(Enum.GetNames(typeof(Tip)));
            comboBox1.Items.Insert(0, "Seciniz");
            comboBox1.SelectedIndex = 0;

        }

        private void BaslangicNodeOlustur()
        {
            TreeNode tnKitaplar = new TreeNode();
            tnKitaplar.Text = "Kitaplar";
            treeView1.Nodes.Add(tnKitaplar);

            TreeNode tnFantastik = new TreeNode();
            tnFantastik.Text = "Fantastik";
            tnFantastik.Name = "fn";
            tnKitaplar.Nodes.Add(tnFantastik);

            TreeNode tnPolisiye = new TreeNode();
            tnPolisiye.Text = "Polisiye";
            tnPolisiye.Name = "po";
            tnKitaplar.Nodes.Add(tnPolisiye);

            TreeNode tnMacera = new TreeNode();
            tnMacera.Text = "Macera";
            tnMacera.Name = "ma";
            tnKitaplar.Nodes.Add(tnMacera);

        }

        enum Tip { 
      
            Fantastik=1,
            Polisiye,
            Macera
        }

        struct Kitap
        {
            public string Adi;
            public int SayfaSayisi;
            public Tip Turu;
            public Guid ISBN;
            public string Yazar;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap k;
            k.Adi = textBox1.Text;
            k.SayfaSayisi = int.Parse(textBox2.Text);
            k.Yazar = textBox3.Text;
            k.Turu = (Tip)comboBox1.SelectedIndex;
            k.ISBN = Guid.NewGuid();

            KitapKayit(k);
        }

        private void KitapKayit(Kitap k)
        {
            TreeNode tn = new TreeNode();
            tn.Text = k.Adi;
            tn.Tag = k;
            string key = null;

            switch ((int)k.Turu)
            {
                case 1:
                    key = "fn";
                    break;
                case 2:
                    key = "po";
                    break;
                case 3:
                    key = "ma";
                    break;
            }

            treeView1.Nodes[0].Nodes[key].Nodes.Add(tn);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "fn" || e.Node.Name == "po" || e.Node.Name == "ma")
            {

                listView1.Items.Clear();
                foreach (TreeNode tn in e.Node.Nodes)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = ((Kitap)(tn.Tag)).Adi;
                    li.SubItems.Add(((Kitap)(tn.Tag)).Yazar);
                    li.SubItems.Add(((Kitap)(tn.Tag)).SayfaSayisi.ToString());
                    li.SubItems.Add(((Kitap)(tn.Tag)).ISBN.ToString());

                    listView1.Items.Add(li);
                }
            }
            else
            {
                MessageBox.Show("Kitap türü seçmelisiniz.");
            }
        }

       
    }
}
