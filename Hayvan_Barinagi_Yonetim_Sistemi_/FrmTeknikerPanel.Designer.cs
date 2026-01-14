namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    partial class FrmTeknikerPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKritik = new System.Windows.Forms.TextBox();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSKT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.gridStok = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGeri = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBeslenmeGuncelle = new System.Windows.Forms.Button();
            this.btnBeslenmeSil = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gridBeslenme = new System.Windows.Forms.DataGridView();
            this.btnBeslenmeEkle = new System.Windows.Forms.Button();
            this.dtpBeslenmeSaat = new System.Windows.Forms.DateTimePicker();
            this.dtpBeslenmeTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbBeslenmeBirim = new System.Windows.Forms.ComboBox();
            this.txtBeslenmeMiktar = new System.Windows.Forms.TextBox();
            this.cmbOgun = new System.Windows.Forms.ComboBox();
            this.cmbBeslenmeStok = new System.Windows.Forms.ComboBox();
            this.cmbBeslenmeHayvan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBeslenme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(215, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Aşı",
            "Mama",
            "İlaç",
            "Sarf Malzeme"});
            this.cmbKategori.Location = new System.Drawing.Point(215, 99);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(200, 24);
            this.cmbKategori.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mevcut Miktar:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(215, 135);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(200, 22);
            this.txtMiktar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birim:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Adet",
            "Kg",
            "Kutu",
            "Ml"});
            this.cmbBirim.Location = new System.Drawing.Point(215, 54);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(200, 24);
            this.cmbBirim.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kritik Seviye:";
            // 
            // txtKritik
            // 
            this.txtKritik.Location = new System.Drawing.Point(215, 182);
            this.txtKritik.Name = "txtKritik";
            this.txtKritik.Size = new System.Drawing.Size(200, 22);
            this.txtKritik.TabIndex = 9;
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Location = new System.Drawing.Point(215, 231);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(200, 22);
            this.txtTedarikci.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tedarikçi:";
            // 
            // dtpSKT
            // 
            this.dtpSKT.Location = new System.Drawing.Point(215, 276);
            this.dtpSKT.Name = "dtpSKT";
            this.dtpSKT.Size = new System.Drawing.Size(200, 22);
            this.dtpSKT.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Son Kullanma Tarihi:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEkle.Location = new System.Drawing.Point(58, 334);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(137, 65);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSil.Location = new System.Drawing.Point(215, 334);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(137, 65);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuncelle.Location = new System.Drawing.Point(58, 420);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(137, 65);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnTemizle.Location = new System.Drawing.Point(215, 420);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(137, 65);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // gridStok
            // 
            this.gridStok.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStok.Location = new System.Drawing.Point(487, 58);
            this.gridStok.Name = "gridStok";
            this.gridStok.RowHeadersWidth = 51;
            this.gridStok.RowTemplate.Height = 24;
            this.gridStok.Size = new System.Drawing.Size(718, 506);
            this.gridStok.TabIndex = 18;
            this.gridStok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStok_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PowderBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(487, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 33);
            this.label8.TabIndex = 19;
            this.label8.Text = "STOK";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1221, 599);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGeri);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.gridStok);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.btnTemizle);
            this.tabPage1.Controls.Add(this.cmbBirim);
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.cmbKategori);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpSKT);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtMiktar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtTedarikci);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtKritik);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1213, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Stok İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGeri.Location = new System.Drawing.Point(-1, 529);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(99, 41);
            this.btnGeri.TabIndex = 20;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBeslenmeGuncelle);
            this.tabPage2.Controls.Add(this.btnBeslenmeSil);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.gridBeslenme);
            this.tabPage2.Controls.Add(this.btnBeslenmeEkle);
            this.tabPage2.Controls.Add(this.dtpBeslenmeSaat);
            this.tabPage2.Controls.Add(this.dtpBeslenmeTarih);
            this.tabPage2.Controls.Add(this.cmbBeslenmeBirim);
            this.tabPage2.Controls.Add(this.txtBeslenmeMiktar);
            this.tabPage2.Controls.Add(this.cmbOgun);
            this.tabPage2.Controls.Add(this.cmbBeslenmeStok);
            this.tabPage2.Controls.Add(this.cmbBeslenmeHayvan);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1213, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Beslenme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBeslenmeGuncelle
            // 
            this.btnBeslenmeGuncelle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBeslenmeGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeslenmeGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeslenmeGuncelle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBeslenmeGuncelle.Location = new System.Drawing.Point(137, 473);
            this.btnBeslenmeGuncelle.Name = "btnBeslenmeGuncelle";
            this.btnBeslenmeGuncelle.Size = new System.Drawing.Size(123, 50);
            this.btnBeslenmeGuncelle.TabIndex = 17;
            this.btnBeslenmeGuncelle.Text = "GÜNCELLE";
            this.btnBeslenmeGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnBeslenmeSil
            // 
            this.btnBeslenmeSil.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBeslenmeSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeslenmeSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeslenmeSil.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBeslenmeSil.Location = new System.Drawing.Point(220, 397);
            this.btnBeslenmeSil.Name = "btnBeslenmeSil";
            this.btnBeslenmeSil.Size = new System.Drawing.Size(119, 53);
            this.btnBeslenmeSil.TabIndex = 16;
            this.btnBeslenmeSil.Text = "SİL";
            this.btnBeslenmeSil.UseVisualStyleBackColor = false;
            this.btnBeslenmeSil.Click += new System.EventHandler(this.btnBeslenmeSil_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(25, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Saat:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(25, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Tarih:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(25, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Birim:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(25, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Miktar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(25, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Öğün Adı";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(25, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Yemek/Mama Seçimi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(25, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hayvan Seçimi";
            // 
            // gridBeslenme
            // 
            this.gridBeslenme.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridBeslenme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBeslenme.Location = new System.Drawing.Point(404, 6);
            this.gridBeslenme.Name = "gridBeslenme";
            this.gridBeslenme.RowHeadersWidth = 51;
            this.gridBeslenme.RowTemplate.Height = 24;
            this.gridBeslenme.Size = new System.Drawing.Size(801, 558);
            this.gridBeslenme.TabIndex = 8;
            // 
            // btnBeslenmeEkle
            // 
            this.btnBeslenmeEkle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBeslenmeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeslenmeEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeslenmeEkle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBeslenmeEkle.Location = new System.Drawing.Point(65, 397);
            this.btnBeslenmeEkle.Name = "btnBeslenmeEkle";
            this.btnBeslenmeEkle.Size = new System.Drawing.Size(119, 48);
            this.btnBeslenmeEkle.TabIndex = 7;
            this.btnBeslenmeEkle.Text = "EKLE";
            this.btnBeslenmeEkle.UseVisualStyleBackColor = false;
            this.btnBeslenmeEkle.Click += new System.EventHandler(this.btnBeslenmeEkle_Click);
            // 
            // dtpBeslenmeSaat
            // 
            this.dtpBeslenmeSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBeslenmeSaat.Location = new System.Drawing.Point(190, 304);
            this.dtpBeslenmeSaat.Name = "dtpBeslenmeSaat";
            this.dtpBeslenmeSaat.ShowUpDown = true;
            this.dtpBeslenmeSaat.Size = new System.Drawing.Size(200, 22);
            this.dtpBeslenmeSaat.TabIndex = 6;
            // 
            // dtpBeslenmeTarih
            // 
            this.dtpBeslenmeTarih.Location = new System.Drawing.Point(190, 266);
            this.dtpBeslenmeTarih.Name = "dtpBeslenmeTarih";
            this.dtpBeslenmeTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpBeslenmeTarih.TabIndex = 5;
            // 
            // cmbBeslenmeBirim
            // 
            this.cmbBeslenmeBirim.FormattingEnabled = true;
            this.cmbBeslenmeBirim.Items.AddRange(new object[] {
            "Kg",
            "Gr",
            "Lt"});
            this.cmbBeslenmeBirim.Location = new System.Drawing.Point(190, 223);
            this.cmbBeslenmeBirim.Name = "cmbBeslenmeBirim";
            this.cmbBeslenmeBirim.Size = new System.Drawing.Size(200, 24);
            this.cmbBeslenmeBirim.TabIndex = 4;
            this.cmbBeslenmeBirim.SelectedIndexChanged += new System.EventHandler(this.cmbBeslenmeBirim_SelectedIndexChanged);
            // 
            // txtBeslenmeMiktar
            // 
            this.txtBeslenmeMiktar.Location = new System.Drawing.Point(190, 179);
            this.txtBeslenmeMiktar.Name = "txtBeslenmeMiktar";
            this.txtBeslenmeMiktar.Size = new System.Drawing.Size(200, 22);
            this.txtBeslenmeMiktar.TabIndex = 3;
            // 
            // cmbOgun
            // 
            this.cmbOgun.FormattingEnabled = true;
            this.cmbOgun.Items.AddRange(new object[] {
            "Sabah",
            "Öğle ",
            "Akşam "});
            this.cmbOgun.Location = new System.Drawing.Point(190, 133);
            this.cmbOgun.Name = "cmbOgun";
            this.cmbOgun.Size = new System.Drawing.Size(191, 24);
            this.cmbOgun.TabIndex = 2;
            // 
            // cmbBeslenmeStok
            // 
            this.cmbBeslenmeStok.FormattingEnabled = true;
            this.cmbBeslenmeStok.Location = new System.Drawing.Point(190, 86);
            this.cmbBeslenmeStok.Name = "cmbBeslenmeStok";
            this.cmbBeslenmeStok.Size = new System.Drawing.Size(191, 24);
            this.cmbBeslenmeStok.TabIndex = 1;
            // 
            // cmbBeslenmeHayvan
            // 
            this.cmbBeslenmeHayvan.FormattingEnabled = true;
            this.cmbBeslenmeHayvan.Location = new System.Drawing.Point(190, 38);
            this.cmbBeslenmeHayvan.Name = "cmbBeslenmeHayvan";
            this.cmbBeslenmeHayvan.Size = new System.Drawing.Size(191, 24);
            this.cmbBeslenmeHayvan.TabIndex = 0;
            this.cmbBeslenmeHayvan.SelectedIndexChanged += new System.EventHandler(this.cmbBeslenmeHayvan_SelectedIndexChanged);
            // 
            // FrmTeknikerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 599);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.Name = "FrmTeknikerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTeknikerPanel";
            this.Load += new System.EventHandler(this.FrmTeknikerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBeslenme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKritik;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpSKT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView gridStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpBeslenmeSaat;
        private System.Windows.Forms.DateTimePicker dtpBeslenmeTarih;
        private System.Windows.Forms.ComboBox cmbBeslenmeBirim;
        private System.Windows.Forms.TextBox txtBeslenmeMiktar;
        private System.Windows.Forms.ComboBox cmbOgun;
        private System.Windows.Forms.ComboBox cmbBeslenmeStok;
        private System.Windows.Forms.ComboBox cmbBeslenmeHayvan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridBeslenme;
        private System.Windows.Forms.Button btnBeslenmeEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBeslenmeGuncelle;
        private System.Windows.Forms.Button btnBeslenmeSil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGeri;
    }
}