namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    partial class FrmTibbiKayit
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
            this.lblHayvanBilgi = new System.Windows.Forms.Label();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStok = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.chkRandevu = new System.Windows.Forms.CheckBox();
            this.dtpRandevu = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gridTibbiGecmis = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTibbiGecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHayvanBilgi
            // 
            this.lblHayvanBilgi.AutoSize = true;
            this.lblHayvanBilgi.BackColor = System.Drawing.Color.PowderBlue;
            this.lblHayvanBilgi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHayvanBilgi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHayvanBilgi.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblHayvanBilgi.Location = new System.Drawing.Point(372, 9);
            this.lblHayvanBilgi.Name = "lblHayvanBilgi";
            this.lblHayvanBilgi.Size = new System.Drawing.Size(358, 25);
            this.lblHayvanBilgi.TabIndex = 0;
            this.lblHayvanBilgi.Text = "SEÇİLEN HASTA İÇİN TIBBİ KAYIT BİLGİLERİ";
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Muayene",
            "Aşılama",
            "Ameliyat",
            "Tedavi",
            "Parazit",
            "Rutin Kontrol"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(208, 35);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbIslemTuru.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "İşlem Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanılan İlaç/Aşı";
            // 
            // cmbStok
            // 
            this.cmbStok.FormattingEnabled = true;
            this.cmbStok.Location = new System.Drawing.Point(208, 80);
            this.cmbStok.Name = "cmbStok";
            this.cmbStok.Size = new System.Drawing.Size(121, 24);
            this.cmbStok.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "İşlem Tarihi";
            // 
            // dtpIslemTarihi
            // 
            this.dtpIslemTarihi.Location = new System.Drawing.Point(166, 119);
            this.dtpIslemTarihi.Name = "dtpIslemTarihi";
            this.dtpIslemTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpIslemTarihi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açıklama / Teşhis";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(55, 184);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 69);
            this.txtAciklama.TabIndex = 9;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sonuç";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(120, 283);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(200, 22);
            this.txtSonuc.TabIndex = 11;
            // 
            // chkRandevu
            // 
            this.chkRandevu.AutoSize = true;
            this.chkRandevu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkRandevu.Location = new System.Drawing.Point(55, 320);
            this.chkRandevu.Name = "chkRandevu";
            this.chkRandevu.Size = new System.Drawing.Size(204, 24);
            this.chkRandevu.TabIndex = 12;
            this.chkRandevu.Text = "Sonraki Randevu Var mı?";
            this.chkRandevu.UseVisualStyleBackColor = true;
            this.chkRandevu.CheckedChanged += new System.EventHandler(this.chkRandevu_CheckedChanged_1);
            // 
            // dtpRandevu
            // 
            this.dtpRandevu.Enabled = false;
            this.dtpRandevu.Location = new System.Drawing.Point(55, 350);
            this.dtpRandevu.Name = "dtpRandevu";
            this.dtpRandevu.Size = new System.Drawing.Size(197, 22);
            this.dtpRandevu.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnKaydet.Location = new System.Drawing.Point(59, 393);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 50);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridTibbiGecmis
            // 
            this.gridTibbiGecmis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTibbiGecmis.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridTibbiGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTibbiGecmis.Location = new System.Drawing.Point(372, 52);
            this.gridTibbiGecmis.Name = "gridTibbiGecmis";
            this.gridTibbiGecmis.RowHeadersWidth = 51;
            this.gridTibbiGecmis.RowTemplate.Height = 24;
            this.gridTibbiGecmis.Size = new System.Drawing.Size(865, 452);
            this.gridTibbiGecmis.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(0, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Geri Dön ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTibbiKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHayvanBilgi);
            this.Controls.Add(this.gridTibbiGecmis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpRandevu);
            this.Controls.Add(this.chkRandevu);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpIslemTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIslemTuru);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTibbiKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTibbiKayit";
            this.Load += new System.EventHandler(this.FrmTibbiKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTibbiGecmis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHayvanBilgi;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpIslemTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.CheckBox chkRandevu;
        private System.Windows.Forms.DateTimePicker dtpRandevu;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView gridTibbiGecmis;
        private System.Windows.Forms.Button button1;
    }
}