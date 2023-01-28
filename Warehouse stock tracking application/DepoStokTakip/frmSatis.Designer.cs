namespace DepoStokTakip
{
    partial class frmSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxMagaza = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTelefon = new System.Windows.Forms.TextBox();
            this.txtBoxMagaza = new System.Windows.Forms.TextBox();
            this.groupBoxUrun = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxToplamFiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFiyat = new System.Windows.Forms.TextBox();
            this.txtBoxMiktar = new System.Windows.Forms.TextBox();
            this.txtBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBoxBarkod = new System.Windows.Forms.TextBox();
            this.btnSatişYap = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatişIptal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnMagazalar = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnSatisListele = new System.Windows.Forms.Button();
            this.btnUrunListe = new System.Windows.Forms.Button();
            this.btnMagazaEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxMagaza.SuspendLayout();
            this.groupBoxUrun.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(303, 117);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(833, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxMagaza
            // 
            this.groupBoxMagaza.Controls.Add(this.label2);
            this.groupBoxMagaza.Controls.Add(this.label1);
            this.groupBoxMagaza.Controls.Add(this.txtBoxTelefon);
            this.groupBoxMagaza.Controls.Add(this.txtBoxMagaza);
            this.groupBoxMagaza.Location = new System.Drawing.Point(38, 117);
            this.groupBoxMagaza.Name = "groupBoxMagaza";
            this.groupBoxMagaza.Size = new System.Drawing.Size(259, 155);
            this.groupBoxMagaza.TabIndex = 1;
            this.groupBoxMagaza.TabStop = false;
            this.groupBoxMagaza.Text = "Mağaza işlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefon";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mağaza";
            // 
            // txtBoxTelefon
            // 
            this.txtBoxTelefon.Location = new System.Drawing.Point(125, 68);
            this.txtBoxTelefon.Name = "txtBoxTelefon";
            this.txtBoxTelefon.Size = new System.Drawing.Size(118, 27);
            this.txtBoxTelefon.TabIndex = 4;
            // 
            // txtBoxMagaza
            // 
            this.txtBoxMagaza.Location = new System.Drawing.Point(125, 27);
            this.txtBoxMagaza.Name = "txtBoxMagaza";
            this.txtBoxMagaza.Size = new System.Drawing.Size(118, 27);
            this.txtBoxMagaza.TabIndex = 3;
            this.txtBoxMagaza.TextChanged += new System.EventHandler(this.txtBoxMagaza_TextChanged);
            // 
            // groupBoxUrun
            // 
            this.groupBoxUrun.Controls.Add(this.label9);
            this.groupBoxUrun.Controls.Add(this.txtBoxToplamFiyat);
            this.groupBoxUrun.Controls.Add(this.btnEkle);
            this.groupBoxUrun.Controls.Add(this.label7);
            this.groupBoxUrun.Controls.Add(this.label5);
            this.groupBoxUrun.Controls.Add(this.label4);
            this.groupBoxUrun.Controls.Add(this.label3);
            this.groupBoxUrun.Controls.Add(this.txtBoxFiyat);
            this.groupBoxUrun.Controls.Add(this.txtBoxMiktar);
            this.groupBoxUrun.Controls.Add(this.txtBoxUrunAdi);
            this.groupBoxUrun.Controls.Add(this.txtBoxBarkod);
            this.groupBoxUrun.Location = new System.Drawing.Point(14, 278);
            this.groupBoxUrun.Name = "groupBoxUrun";
            this.groupBoxUrun.Size = new System.Drawing.Size(283, 288);
            this.groupBoxUrun.TabIndex = 2;
            this.groupBoxUrun.TabStop = false;
            this.groupBoxUrun.Text = "Ürün İşlemleri";
            this.groupBoxUrun.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Toplam Fiyat";
            // 
            // txtBoxToplamFiyat
            // 
            this.txtBoxToplamFiyat.Location = new System.Drawing.Point(151, 192);
            this.txtBoxToplamFiyat.Name = "txtBoxToplamFiyat";
            this.txtBoxToplamFiyat.Size = new System.Drawing.Size(118, 27);
            this.txtBoxToplamFiyat.TabIndex = 15;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(151, 234);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 48);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fiyat";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miktar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "BarkodNO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxFiyat
            // 
            this.txtBoxFiyat.Location = new System.Drawing.Point(151, 158);
            this.txtBoxFiyat.Name = "txtBoxFiyat";
            this.txtBoxFiyat.Size = new System.Drawing.Size(118, 27);
            this.txtBoxFiyat.TabIndex = 7;
            this.txtBoxFiyat.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtBoxMiktar
            // 
            this.txtBoxMiktar.Location = new System.Drawing.Point(151, 115);
            this.txtBoxMiktar.Name = "txtBoxMiktar";
            this.txtBoxMiktar.Size = new System.Drawing.Size(118, 27);
            this.txtBoxMiktar.TabIndex = 6;
            this.txtBoxMiktar.Text = "1";
            this.txtBoxMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxMiktar.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtBoxUrunAdi
            // 
            this.txtBoxUrunAdi.Location = new System.Drawing.Point(151, 70);
            this.txtBoxUrunAdi.Name = "txtBoxUrunAdi";
            this.txtBoxUrunAdi.Size = new System.Drawing.Size(118, 27);
            this.txtBoxUrunAdi.TabIndex = 5;
            this.txtBoxUrunAdi.TextChanged += new System.EventHandler(this.txtBoxUrunAdı_TextChanged);
            // 
            // txtBoxBarkod
            // 
            this.txtBoxBarkod.Location = new System.Drawing.Point(151, 23);
            this.txtBoxBarkod.Name = "txtBoxBarkod";
            this.txtBoxBarkod.Size = new System.Drawing.Size(118, 27);
            this.txtBoxBarkod.TabIndex = 4;
            this.txtBoxBarkod.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnSatişYap
            // 
            this.btnSatişYap.Location = new System.Drawing.Point(1142, 261);
            this.btnSatişYap.Name = "btnSatişYap";
            this.btnSatişYap.Size = new System.Drawing.Size(118, 48);
            this.btnSatişYap.TabIndex = 15;
            this.btnSatişYap.Text = "Satış yap";
            this.btnSatişYap.UseVisualStyleBackColor = true;
            this.btnSatişYap.Click += new System.EventHandler(this.btnSatişYap_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1142, 124);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(118, 48);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatişIptal
            // 
            this.btnSatişIptal.Location = new System.Drawing.Point(1142, 185);
            this.btnSatişIptal.Name = "btnSatişIptal";
            this.btnSatişIptal.Size = new System.Drawing.Size(118, 48);
            this.btnSatişIptal.TabIndex = 17;
            this.btnSatişIptal.Text = "Satış iptal";
            this.btnSatişIptal.UseVisualStyleBackColor = true;
            this.btnSatişIptal.Click += new System.EventHandler(this.btnSatişIptal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnMagazalar);
            this.panel1.Controls.Add(this.btnUrunEkle);
            this.panel1.Controls.Add(this.btnSatisListele);
            this.panel1.Controls.Add(this.btnUrunListe);
            this.panel1.Controls.Add(this.btnMagazaEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 100);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(1083, 18);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(163, 65);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.Text = "Kategori Ekleme";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(904, 18);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(163, 65);
            this.btnMarka.TabIndex = 5;
            this.btnMarka.Text = "Marka Ekleme";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnMagazalar
            // 
            this.btnMagazalar.Location = new System.Drawing.Point(190, 18);
            this.btnMagazalar.Name = "btnMagazalar";
            this.btnMagazalar.Size = new System.Drawing.Size(163, 65);
            this.btnMagazalar.TabIndex = 4;
            this.btnMagazalar.Text = "Mağazalar";
            this.btnMagazalar.UseVisualStyleBackColor = true;
            this.btnMagazalar.Click += new System.EventHandler(this.btnMagazalar_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(365, 18);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(163, 65);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ürün Ekleme";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnSatisListele
            // 
            this.btnSatisListele.Location = new System.Drawing.Point(723, 18);
            this.btnSatisListele.Name = "btnSatisListele";
            this.btnSatisListele.Size = new System.Drawing.Size(163, 65);
            this.btnSatisListele.TabIndex = 2;
            this.btnSatisListele.Text = "Satışlar Listesi";
            this.btnSatisListele.UseVisualStyleBackColor = true;
            this.btnSatisListele.Click += new System.EventHandler(this.btnSatisListele_Click);
            // 
            // btnUrunListe
            // 
            this.btnUrunListe.Location = new System.Drawing.Point(544, 18);
            this.btnUrunListe.Name = "btnUrunListe";
            this.btnUrunListe.Size = new System.Drawing.Size(163, 65);
            this.btnUrunListe.TabIndex = 1;
            this.btnUrunListe.Text = "Ürün Listesi";
            this.btnUrunListe.UseVisualStyleBackColor = true;
            this.btnUrunListe.Click += new System.EventHandler(this.btnUrunListe_Click);
            // 
            // btnMagazaEkle
            // 
            this.btnMagazaEkle.Location = new System.Drawing.Point(14, 18);
            this.btnMagazaEkle.Name = "btnMagazaEkle";
            this.btnMagazaEkle.Size = new System.Drawing.Size(163, 65);
            this.btnMagazaEkle.TabIndex = 0;
            this.btnMagazaEkle.Text = "Mağaza Ekleme";
            this.btnMagazaEkle.UseVisualStyleBackColor = true;
            this.btnMagazaEkle.Click += new System.EventHandler(this.btnMagazaEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1143, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sipariş tutarı";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(1196, 401);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(14, 19);
            this.lblGenelToplam.TabIndex = 20;
            this.lblGenelToplam.Text = ".";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1291, 641);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSatişIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatişYap);
            this.Controls.Add(this.groupBoxUrun);
            this.Controls.Add(this.groupBoxMagaza);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxMagaza.ResumeLayout(false);
            this.groupBoxMagaza.PerformLayout();
            this.groupBoxUrun.ResumeLayout(false);
            this.groupBoxUrun.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxMagaza;
        private System.Windows.Forms.TextBox txtBoxTelefon;
        private System.Windows.Forms.TextBox txtBoxMagaza;
        private System.Windows.Forms.GroupBox groupBoxUrun;
        private System.Windows.Forms.TextBox txtBoxFiyat;
        private System.Windows.Forms.TextBox txtBoxMiktar;
        private System.Windows.Forms.TextBox txtBoxUrunAdi;
        private System.Windows.Forms.TextBox txtBoxBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatişYap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatişIptal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMagazalar;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnSatisListele;
        private System.Windows.Forms.Button btnUrunListe;
        private System.Windows.Forms.Button btnMagazaEkle;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxToplamFiyat;
    }
}

