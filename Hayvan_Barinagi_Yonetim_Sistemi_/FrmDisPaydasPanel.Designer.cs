namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    partial class FrmDisPaydasPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSahiplen = new System.Windows.Forms.TabPage();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSahiplenmeTalebi = new System.Windows.Forms.Button();
            this.gridHayvanlar = new System.Windows.Forms.DataGridView();
            this.tabGecmis = new System.Windows.Forms.TabPage();
            this.gridGecmis = new System.Windows.Forms.DataGridView();
            this.tabBagis = new System.Windows.Forms.TabPage();
            this.btnBagisYap = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBagisTuru = new System.Windows.Forms.ComboBox();
            this.txtBagisMiktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBagisGecmisi = new System.Windows.Forms.TabPage();
            this.tabProfil = new System.Windows.Forms.TabPage();
            this.dgvBagisGecmisi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProfilAd = new System.Windows.Forms.TextBox();
            this.txtProfilSoyad = new System.Windows.Forms.TextBox();
            this.txtProfilTC = new System.Windows.Forms.TextBox();
            this.txtProfilTel = new System.Windows.Forms.TextBox();
            this.txtProfilEposta = new System.Windows.Forms.TextBox();
            this.txtProfilAdres = new System.Windows.Forms.TextBox();
            this.cmbIletisimTercihi = new System.Windows.Forms.ComboBox();
            this.btnProfilGuncelle = new System.Windows.Forms.Button();
            this.HayvanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabSahiplen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHayvanlar)).BeginInit();
            this.tabGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).BeginInit();
            this.tabBagis.SuspendLayout();
            this.tabBagisGecmisi.SuspendLayout();
            this.tabProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBagisGecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSahiplen);
            this.tabControl1.Controls.Add(this.tabGecmis);
            this.tabControl1.Controls.Add(this.tabBagis);
            this.tabControl1.Controls.Add(this.tabBagisGecmisi);
            this.tabControl1.Controls.Add(this.tabProfil);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1215, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSahiplen
            // 
            this.tabSahiplen.BackColor = System.Drawing.SystemColors.Window;
            this.tabSahiplen.Controls.Add(this.btnGeri);
            this.tabSahiplen.Controls.Add(this.btnSahiplenmeTalebi);
            this.tabSahiplen.Controls.Add(this.gridHayvanlar);
            this.tabSahiplen.Location = new System.Drawing.Point(4, 29);
            this.tabSahiplen.Name = "tabSahiplen";
            this.tabSahiplen.Padding = new System.Windows.Forms.Padding(3);
            this.tabSahiplen.Size = new System.Drawing.Size(1207, 417);
            this.tabSahiplen.TabIndex = 0;
            this.tabSahiplen.Text = "Hayvanları Görüntüle";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGeri.Location = new System.Drawing.Point(0, 371);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(119, 50);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnSahiplenmeTalebi
            // 
            this.btnSahiplenmeTalebi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSahiplenmeTalebi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSahiplenmeTalebi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSahiplenmeTalebi.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSahiplenmeTalebi.Location = new System.Drawing.Point(521, 333);
            this.btnSahiplenmeTalebi.Name = "btnSahiplenmeTalebi";
            this.btnSahiplenmeTalebi.Size = new System.Drawing.Size(174, 59);
            this.btnSahiplenmeTalebi.TabIndex = 1;
            this.btnSahiplenmeTalebi.Text = "Sahiplenme Talebi";
            this.btnSahiplenmeTalebi.UseVisualStyleBackColor = false;
            this.btnSahiplenmeTalebi.Click += new System.EventHandler(this.btnSahiplenmeTalebi_Click);
            // 
            // gridHayvanlar
            // 
            this.gridHayvanlar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHayvanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HayvanID});
            this.gridHayvanlar.Location = new System.Drawing.Point(8, 6);
            this.gridHayvanlar.Name = "gridHayvanlar";
            this.gridHayvanlar.RowHeadersWidth = 51;
            this.gridHayvanlar.RowTemplate.Height = 24;
            this.gridHayvanlar.Size = new System.Drawing.Size(1191, 318);
            this.gridHayvanlar.TabIndex = 0;
            this.gridHayvanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHayvanlar_CellContentClick);
            // 
            // tabGecmis
            // 
            this.tabGecmis.Controls.Add(this.gridGecmis);
            this.tabGecmis.Location = new System.Drawing.Point(4, 29);
            this.tabGecmis.Name = "tabGecmis";
            this.tabGecmis.Padding = new System.Windows.Forms.Padding(3);
            this.tabGecmis.Size = new System.Drawing.Size(1207, 417);
            this.tabGecmis.TabIndex = 1;
            this.tabGecmis.Text = "Sahiplendiklerim";
            this.tabGecmis.UseVisualStyleBackColor = true;
            // 
            // gridGecmis
            // 
            this.gridGecmis.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGecmis.Location = new System.Drawing.Point(6, 6);
            this.gridGecmis.Name = "gridGecmis";
            this.gridGecmis.RowHeadersWidth = 51;
            this.gridGecmis.RowTemplate.Height = 24;
            this.gridGecmis.Size = new System.Drawing.Size(1193, 407);
            this.gridGecmis.TabIndex = 0;
            // 
            // tabBagis
            // 
            this.tabBagis.Controls.Add(this.btnBagisYap);
            this.tabBagis.Controls.Add(this.txtAciklama);
            this.tabBagis.Controls.Add(this.label3);
            this.tabBagis.Controls.Add(this.label2);
            this.tabBagis.Controls.Add(this.cmbBagisTuru);
            this.tabBagis.Controls.Add(this.txtBagisMiktar);
            this.tabBagis.Controls.Add(this.label1);
            this.tabBagis.Location = new System.Drawing.Point(4, 29);
            this.tabBagis.Name = "tabBagis";
            this.tabBagis.Size = new System.Drawing.Size(1207, 417);
            this.tabBagis.TabIndex = 0;
            this.tabBagis.Text = "Bağış Yap";
            this.tabBagis.UseVisualStyleBackColor = true;
            // 
            // btnBagisYap
            // 
            this.btnBagisYap.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBagisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBagisYap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBagisYap.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBagisYap.Location = new System.Drawing.Point(500, 191);
            this.btnBagisYap.Name = "btnBagisYap";
            this.btnBagisYap.Size = new System.Drawing.Size(151, 71);
            this.btnBagisYap.TabIndex = 6;
            this.btnBagisYap.Text = "Bağış Yap";
            this.btnBagisYap.UseVisualStyleBackColor = false;
            this.btnBagisYap.Click += new System.EventHandler(this.btnBagisYap_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(588, 113);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(166, 27);
            this.txtAciklama.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(423, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(423, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bağış Türü Seçiniz:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbBagisTuru
            // 
            this.cmbBagisTuru.FormattingEnabled = true;
            this.cmbBagisTuru.Items.AddRange(new object[] {
            "Nakit",
            "Köpek Maması",
            "Kedi Maması ",
            "Kuş Maması "});
            this.cmbBagisTuru.Location = new System.Drawing.Point(588, 73);
            this.cmbBagisTuru.Name = "cmbBagisTuru";
            this.cmbBagisTuru.Size = new System.Drawing.Size(166, 28);
            this.cmbBagisTuru.TabIndex = 2;
            // 
            // txtBagisMiktar
            // 
            this.txtBagisMiktar.Location = new System.Drawing.Point(588, 32);
            this.txtBagisMiktar.Name = "txtBagisMiktar";
            this.txtBagisMiktar.Size = new System.Drawing.Size(166, 27);
            this.txtBagisMiktar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(423, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bağış Miktarı:";
            // 
            // tabBagisGecmisi
            // 
            this.tabBagisGecmisi.Controls.Add(this.dgvBagisGecmisi);
            this.tabBagisGecmisi.Location = new System.Drawing.Point(4, 29);
            this.tabBagisGecmisi.Name = "tabBagisGecmisi";
            this.tabBagisGecmisi.Padding = new System.Windows.Forms.Padding(3);
            this.tabBagisGecmisi.Size = new System.Drawing.Size(1207, 417);
            this.tabBagisGecmisi.TabIndex = 2;
            this.tabBagisGecmisi.Text = "Bağış Geçmişim";
            this.tabBagisGecmisi.UseVisualStyleBackColor = true;
            // 
            // tabProfil
            // 
            this.tabProfil.Controls.Add(this.btnProfilGuncelle);
            this.tabProfil.Controls.Add(this.cmbIletisimTercihi);
            this.tabProfil.Controls.Add(this.txtProfilAdres);
            this.tabProfil.Controls.Add(this.txtProfilEposta);
            this.tabProfil.Controls.Add(this.txtProfilTel);
            this.tabProfil.Controls.Add(this.txtProfilTC);
            this.tabProfil.Controls.Add(this.txtProfilSoyad);
            this.tabProfil.Controls.Add(this.txtProfilAd);
            this.tabProfil.Controls.Add(this.label10);
            this.tabProfil.Controls.Add(this.label9);
            this.tabProfil.Controls.Add(this.label8);
            this.tabProfil.Controls.Add(this.label7);
            this.tabProfil.Controls.Add(this.label6);
            this.tabProfil.Controls.Add(this.label5);
            this.tabProfil.Controls.Add(this.label4);
            this.tabProfil.Location = new System.Drawing.Point(4, 29);
            this.tabProfil.Name = "tabProfil";
            this.tabProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfil.Size = new System.Drawing.Size(1207, 417);
            this.tabProfil.TabIndex = 3;
            this.tabProfil.Text = "Profil Bilgilerim";
            this.tabProfil.UseVisualStyleBackColor = true;
            // 
            // dgvBagisGecmisi
            // 
            this.dgvBagisGecmisi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBagisGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBagisGecmisi.Location = new System.Drawing.Point(6, 6);
            this.dgvBagisGecmisi.Name = "dgvBagisGecmisi";
            this.dgvBagisGecmisi.RowHeadersWidth = 51;
            this.dgvBagisGecmisi.RowTemplate.Height = 24;
            this.dgvBagisGecmisi.Size = new System.Drawing.Size(1193, 407);
            this.dgvBagisGecmisi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(323, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(323, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Soyad:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(323, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "TC Kimlik No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(323, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Telefon Numarası:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(323, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "E-Posta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(610, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Adres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(323, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "İletişim Tercihi:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtProfilAd
            // 
            this.txtProfilAd.Location = new System.Drawing.Point(427, 33);
            this.txtProfilAd.Name = "txtProfilAd";
            this.txtProfilAd.Size = new System.Drawing.Size(100, 27);
            this.txtProfilAd.TabIndex = 7;
            // 
            // txtProfilSoyad
            // 
            this.txtProfilSoyad.Location = new System.Drawing.Point(427, 85);
            this.txtProfilSoyad.Name = "txtProfilSoyad";
            this.txtProfilSoyad.Size = new System.Drawing.Size(100, 27);
            this.txtProfilSoyad.TabIndex = 8;
            // 
            // txtProfilTC
            // 
            this.txtProfilTC.Location = new System.Drawing.Point(485, 136);
            this.txtProfilTC.Name = "txtProfilTC";
            this.txtProfilTC.Size = new System.Drawing.Size(136, 27);
            this.txtProfilTC.TabIndex = 9;
            // 
            // txtProfilTel
            // 
            this.txtProfilTel.Location = new System.Drawing.Point(485, 180);
            this.txtProfilTel.Name = "txtProfilTel";
            this.txtProfilTel.Size = new System.Drawing.Size(136, 27);
            this.txtProfilTel.TabIndex = 11;
            // 
            // txtProfilEposta
            // 
            this.txtProfilEposta.Location = new System.Drawing.Point(485, 230);
            this.txtProfilEposta.Name = "txtProfilEposta";
            this.txtProfilEposta.Size = new System.Drawing.Size(136, 27);
            this.txtProfilEposta.TabIndex = 11;
            // 
            // txtProfilAdres
            // 
            this.txtProfilAdres.Location = new System.Drawing.Point(679, 33);
            this.txtProfilAdres.Multiline = true;
            this.txtProfilAdres.Name = "txtProfilAdres";
            this.txtProfilAdres.Size = new System.Drawing.Size(183, 96);
            this.txtProfilAdres.TabIndex = 12;
            // 
            // cmbIletisimTercihi
            // 
            this.cmbIletisimTercihi.FormattingEnabled = true;
            this.cmbIletisimTercihi.Items.AddRange(new object[] {
            "Telefon",
            "Eposta",
            "SMS"});
            this.cmbIletisimTercihi.Location = new System.Drawing.Point(485, 282);
            this.cmbIletisimTercihi.Name = "cmbIletisimTercihi";
            this.cmbIletisimTercihi.Size = new System.Drawing.Size(121, 28);
            this.cmbIletisimTercihi.TabIndex = 13;
            // 
            // btnProfilGuncelle
            // 
            this.btnProfilGuncelle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnProfilGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfilGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfilGuncelle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnProfilGuncelle.Location = new System.Drawing.Point(663, 230);
            this.btnProfilGuncelle.Name = "btnProfilGuncelle";
            this.btnProfilGuncelle.Size = new System.Drawing.Size(199, 88);
            this.btnProfilGuncelle.TabIndex = 14;
            this.btnProfilGuncelle.Text = "Profil Bilgilerimi Güncelle";
            this.btnProfilGuncelle.UseVisualStyleBackColor = false;
            this.btnProfilGuncelle.Click += new System.EventHandler(this.btnProfilGuncelle_Click);
            // 
            // HayvanID
            // 
            this.HayvanID.DataPropertyName = "HayvanID";
            this.HayvanID.HeaderText = "ID";
            this.HayvanID.MinimumWidth = 6;
            this.HayvanID.Name = "HayvanID";
            this.HayvanID.Visible = false;
            this.HayvanID.Width = 125;
            // 
            // FrmDisPaydasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDisPaydasPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisPaydasPanel";
            this.Load += new System.EventHandler(this.FrmDisPaydasPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSahiplen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHayvanlar)).EndInit();
            this.tabGecmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).EndInit();
            this.tabBagis.ResumeLayout(false);
            this.tabBagis.PerformLayout();
            this.tabBagisGecmisi.ResumeLayout(false);
            this.tabProfil.ResumeLayout(false);
            this.tabProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBagisGecmisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSahiplen;
        private System.Windows.Forms.TabPage tabGecmis;
        private System.Windows.Forms.TabPage tabBagis;
        private System.Windows.Forms.Button btnSahiplenmeTalebi;
        private System.Windows.Forms.DataGridView gridHayvanlar;
        private System.Windows.Forms.TextBox txtBagisMiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBagisTuru;
        private System.Windows.Forms.Button btnBagisYap;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridGecmis;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TabPage tabBagisGecmisi;
        private System.Windows.Forms.TabPage tabProfil;
        private System.Windows.Forms.DataGridView dgvBagisGecmisi;
        private System.Windows.Forms.TextBox txtProfilEposta;
        private System.Windows.Forms.TextBox txtProfilTel;
        private System.Windows.Forms.TextBox txtProfilTC;
        private System.Windows.Forms.TextBox txtProfilSoyad;
        private System.Windows.Forms.TextBox txtProfilAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProfilGuncelle;
        private System.Windows.Forms.ComboBox cmbIletisimTercihi;
        private System.Windows.Forms.TextBox txtProfilAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn HayvanID;
    }
}