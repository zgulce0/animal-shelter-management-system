namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    partial class FrmGirisSecim
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisSecim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.btnDisPaydasGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(421, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAYVAN BARINAĞI YÖNETİM SİSTEMİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.BackColor = System.Drawing.Color.Teal;
            this.btnPersonelGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGiris.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPersonelGiris.Location = new System.Drawing.Point(292, 392);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(250, 50);
            this.btnPersonelGiris.TabIndex = 2;
            this.btnPersonelGiris.Text = "PERSONEL GİRİŞİ";
            this.btnPersonelGiris.UseVisualStyleBackColor = false;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // btnDisPaydasGiris
            // 
            this.btnDisPaydasGiris.BackColor = System.Drawing.Color.Teal;
            this.btnDisPaydasGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisPaydasGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisPaydasGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisPaydasGiris.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDisPaydasGiris.Location = new System.Drawing.Point(686, 392);
            this.btnDisPaydasGiris.Name = "btnDisPaydasGiris";
            this.btnDisPaydasGiris.Size = new System.Drawing.Size(250, 50);
            this.btnDisPaydasGiris.TabIndex = 3;
            this.btnDisPaydasGiris.Text = "DIŞ PAYDAŞ GİRİŞİ";
            this.btnDisPaydasGiris.UseVisualStyleBackColor = false;
            this.btnDisPaydasGiris.Click += new System.EventHandler(this.btnDisPaydasGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(507, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Developed by Elif and Zeynep - 2025";
            // 
            // FrmGirisSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1217, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisPaydasGiris);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGirisSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hayvan Barınağı Yönetim Sistemi";
            this.Load += new System.EventHandler(this.FrmGirisSecim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.Button btnDisPaydasGiris;
        private System.Windows.Forms.Label label2;
    }
}

