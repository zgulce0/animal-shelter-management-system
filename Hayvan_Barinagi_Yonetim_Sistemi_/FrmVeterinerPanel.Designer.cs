namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    partial class FrmVeterinerPanel
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtMikrocip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridHastaBilgi = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuTibbi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKarantina = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAsi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIslemler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHastaBilgi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBul);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMikrocip);
            this.groupBox1.Location = new System.Drawing.Point(205, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kabul / Arama";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBul.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBul.Location = new System.Drawing.Point(387, 43);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(128, 31);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtMikrocip
            // 
            this.txtMikrocip.Location = new System.Drawing.Point(181, 49);
            this.txtMikrocip.Name = "txtMikrocip";
            this.txtMikrocip.Size = new System.Drawing.Size(169, 22);
            this.txtMikrocip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mikroçip No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridHastaBilgi);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1214, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Bilgileri";
            // 
            // gridHastaBilgi
            // 
            this.gridHastaBilgi.AllowUserToAddRows = false;
            this.gridHastaBilgi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridHastaBilgi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridHastaBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHastaBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHastaBilgi.Location = new System.Drawing.Point(3, 18);
            this.gridHastaBilgi.Name = "gridHastaBilgi";
            this.gridHastaBilgi.ReadOnly = true;
            this.gridHastaBilgi.RowHeadersWidth = 51;
            this.gridHastaBilgi.RowTemplate.Height = 24;
            this.gridHastaBilgi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHastaBilgi.Size = new System.Drawing.Size(1208, 379);
            this.gridHastaBilgi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTibbi,
            this.menuKarantina,
            this.menuAsi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 196);
            this.contextMenuStrip1.Text = "İŞLEMLER";
            // 
            // menuTibbi
            // 
            this.menuTibbi.Name = "menuTibbi";
            this.menuTibbi.Size = new System.Drawing.Size(217, 64);
            this.menuTibbi.Text = "Tıbbi Kayıt & Muayene\n\n";
            this.menuTibbi.Click += new System.EventHandler(this.menuTibbi_Click);
            // 
            // menuKarantina
            // 
            this.menuKarantina.Name = "menuKarantina";
            this.menuKarantina.Size = new System.Drawing.Size(217, 64);
            this.menuKarantina.Text = "Karantina Takibi\n";
            this.menuKarantina.Click += new System.EventHandler(this.menuKarantina_Click);
            // 
            // menuAsi
            // 
            this.menuAsi.Name = "menuAsi";
            this.menuAsi.Size = new System.Drawing.Size(217, 64);
            this.menuAsi.Text = "\n\nAşı Programı";
            this.menuAsi.Click += new System.EventHandler(this.menuAsi_Click);
            // 
            // btnIslemler
            // 
            this.btnIslemler.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIslemler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIslemler.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemler.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnIslemler.Location = new System.Drawing.Point(-1, -2);
            this.btnIslemler.Name = "btnIslemler";
            this.btnIslemler.Size = new System.Drawing.Size(200, 50);
            this.btnIslemler.TabIndex = 3;
            this.btnIslemler.Text = "İŞLEM SEÇENEKLERİ";
            this.btnIslemler.UseVisualStyleBackColor = false;
            this.btnIslemler.Click += new System.EventHandler(this.btnIslemler_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(1135, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVeterinerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1238, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIslemler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVeterinerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVeterinerPanel";
            this.Load += new System.EventHandler(this.FrmVeterinerPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHastaBilgi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMikrocip;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridHastaBilgi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTibbi;
        private System.Windows.Forms.ToolStripMenuItem menuKarantina;
        private System.Windows.Forms.ToolStripMenuItem menuAsi;
        private System.Windows.Forms.Button btnIslemler;
        private System.Windows.Forms.Button button1;
    }
}