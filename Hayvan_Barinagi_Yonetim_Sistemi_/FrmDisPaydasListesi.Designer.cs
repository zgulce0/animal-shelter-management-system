namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    partial class FrmDisPaydasListesi
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
            this.dgvDisPaydaslar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSecilenKisi = new System.Windows.Forms.Label();
            this.chkUygunluk = new System.Windows.Forms.CheckBox();
            this.chkDogrulama = new System.Windows.Forms.CheckBox();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisPaydaslar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisPaydaslar
            // 
            this.dgvDisPaydaslar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDisPaydaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisPaydaslar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDisPaydaslar.Location = new System.Drawing.Point(0, 0);
            this.dgvDisPaydaslar.Name = "dgvDisPaydaslar";
            this.dgvDisPaydaslar.RowHeadersWidth = 51;
            this.dgvDisPaydaslar.RowTemplate.Height = 24;
            this.dgvDisPaydaslar.Size = new System.Drawing.Size(1238, 309);
            this.dgvDisPaydaslar.TabIndex = 0;
            this.dgvDisPaydaslar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisPaydaslar_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(2, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSecilenKisi
            // 
            this.lblSecilenKisi.AutoSize = true;
            this.lblSecilenKisi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenKisi.Location = new System.Drawing.Point(400, 347);
            this.lblSecilenKisi.Name = "lblSecilenKisi";
            this.lblSecilenKisi.Size = new System.Drawing.Size(90, 20);
            this.lblSecilenKisi.TabIndex = 3;
            this.lblSecilenKisi.Text = "Seçilen Kişi:";
            // 
            // chkUygunluk
            // 
            this.chkUygunluk.AutoSize = true;
            this.chkUygunluk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkUygunluk.Location = new System.Drawing.Point(335, 396);
            this.chkUygunluk.Name = "chkUygunluk";
            this.chkUygunluk.Size = new System.Drawing.Size(197, 24);
            this.chkUygunluk.TabIndex = 4;
            this.chkUygunluk.Text = "Sahiplendirmeye Uygun";
            this.chkUygunluk.UseVisualStyleBackColor = true;
            // 
            // chkDogrulama
            // 
            this.chkDogrulama.AutoSize = true;
            this.chkDogrulama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDogrulama.Location = new System.Drawing.Point(571, 396);
            this.chkDogrulama.Name = "chkDogrulama";
            this.chkDogrulama.Size = new System.Drawing.Size(195, 24);
            this.chkDogrulama.TabIndex = 5;
            this.chkDogrulama.Text = "Kimlik/Bilgi Doğrulandı";
            this.chkDogrulama.UseVisualStyleBackColor = true;
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumGuncelle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDurumGuncelle.Location = new System.Drawing.Point(871, 347);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(169, 58);
            this.btnDurumGuncelle.TabIndex = 6;
            this.btnDurumGuncelle.Text = "Durum Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // FrmDisPaydasListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 450);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.chkDogrulama);
            this.Controls.Add(this.chkUygunluk);
            this.Controls.Add(this.lblSecilenKisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDisPaydaslar);
            this.MaximizeBox = false;
            this.Name = "FrmDisPaydasListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisPaydasListesi";
            this.Load += new System.EventHandler(this.FrmDisPaydasListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisPaydaslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisPaydaslar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSecilenKisi;
        private System.Windows.Forms.CheckBox chkUygunluk;
        private System.Windows.Forms.CheckBox chkDogrulama;
        private System.Windows.Forms.Button btnDurumGuncelle;
    }
}