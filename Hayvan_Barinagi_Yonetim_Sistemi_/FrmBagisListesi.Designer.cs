namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    partial class FrmBagisListesi
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
            this.dgvBagislar = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBagislar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBagislar
            // 
            this.dgvBagislar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBagislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBagislar.Location = new System.Drawing.Point(-1, 42);
            this.dgvBagislar.Name = "dgvBagislar";
            this.dgvBagislar.RowHeadersWidth = 51;
            this.dgvBagislar.RowTemplate.Height = 24;
            this.dgvBagislar.Size = new System.Drawing.Size(1215, 457);
            this.dgvBagislar.TabIndex = 0;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(-1, 0);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(106, 43);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmBagisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1216, 497);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dgvBagislar);
            this.MaximizeBox = false;
            this.Name = "FrmBagisListesi";
            this.Text = "FrmBagisListesi";
            this.Load += new System.EventHandler(this.FrmBagisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBagislar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBagislar;
        private System.Windows.Forms.Button btnGeri;
    }
}