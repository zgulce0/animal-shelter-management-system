namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    partial class FrmYoneticiPaneli
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
            this.btnPersonelIslemleri = new System.Windows.Forms.Button();
            this.btnBasvurular = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBagisListesi = new System.Windows.Forms.Button();
            this.btnDisPaydasListesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelIslemleri
            // 
            this.btnPersonelIslemleri.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPersonelIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelIslemleri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelIslemleri.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnPersonelIslemleri.Location = new System.Drawing.Point(627, 78);
            this.btnPersonelIslemleri.Name = "btnPersonelIslemleri";
            this.btnPersonelIslemleri.Size = new System.Drawing.Size(201, 76);
            this.btnPersonelIslemleri.TabIndex = 0;
            this.btnPersonelIslemleri.Text = "Personel İşlemleri";
            this.btnPersonelIslemleri.UseVisualStyleBackColor = false;
            this.btnPersonelIslemleri.Click += new System.EventHandler(this.btnPersonelIslemleri_Click);
            // 
            // btnBasvurular
            // 
            this.btnBasvurular.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBasvurular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBasvurular.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasvurular.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBasvurular.Location = new System.Drawing.Point(627, 223);
            this.btnBasvurular.Name = "btnBasvurular";
            this.btnBasvurular.Size = new System.Drawing.Size(201, 76);
            this.btnBasvurular.TabIndex = 1;
            this.btnBasvurular.Text = "Sahiplendirme Başvuruları";
            this.btnBasvurular.UseVisualStyleBackColor = false;
            this.btnBasvurular.Click += new System.EventHandler(this.btnBasvurular_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCikis.Location = new System.Drawing.Point(520, 337);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(201, 76);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBagisListesi
            // 
            this.btnBagisListesi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBagisListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBagisListesi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBagisListesi.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBagisListesi.Location = new System.Drawing.Point(378, 78);
            this.btnBagisListesi.Name = "btnBagisListesi";
            this.btnBagisListesi.Size = new System.Drawing.Size(201, 76);
            this.btnBagisListesi.TabIndex = 3;
            this.btnBagisListesi.Text = "Bağış Listesi";
            this.btnBagisListesi.UseVisualStyleBackColor = false;
            this.btnBagisListesi.Click += new System.EventHandler(this.btnBagisListesi_Click);
            // 
            // btnDisPaydasListesi
            // 
            this.btnDisPaydasListesi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDisPaydasListesi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisPaydasListesi.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDisPaydasListesi.Location = new System.Drawing.Point(378, 223);
            this.btnDisPaydasListesi.Name = "btnDisPaydasListesi";
            this.btnDisPaydasListesi.Size = new System.Drawing.Size(201, 76);
            this.btnDisPaydasListesi.TabIndex = 4;
            this.btnDisPaydasListesi.Text = "Dış Paydaş Listesi";
            this.btnDisPaydasListesi.UseVisualStyleBackColor = false;
            this.btnDisPaydasListesi.Click += new System.EventHandler(this.btnDisPaydasListesi_Click);
            // 
            // FrmYoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 450);
            this.Controls.Add(this.btnDisPaydasListesi);
            this.Controls.Add(this.btnBagisListesi);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBasvurular);
            this.Controls.Add(this.btnPersonelIslemleri);
            this.MaximizeBox = false;
            this.Name = "FrmYoneticiPaneli";
            this.Text = "FrmYoneticiPaneli";
            this.Load += new System.EventHandler(this.FrmYoneticiPaneli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelIslemleri;
        private System.Windows.Forms.Button btnBasvurular;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBagisListesi;
        private System.Windows.Forms.Button btnDisPaydasListesi;
    }
}