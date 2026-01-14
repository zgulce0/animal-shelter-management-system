using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    public partial class FrmVeterinerPanel : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmVeterinerPanel()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtMikrocip.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen bir mikroçip numarası giriniz.");
                return;
            }

            try
            {
                baglanti.Open();

                
                
                string sorgu = "SELECT * FROM Hayvanlar WHERE MikrocipNumarasi=@cip";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@cip", txtMikrocip.Text.Trim());

                DataTable dt = new DataTable();
                da.Fill(dt); 

                
                if (dt.Rows.Count > 0)
                {
                    
                    gridHastaBilgi.DataSource = dt;

                    
                    gridHastaBilgi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    

                    gridHastaBilgi.Columns["HayvanID"].Visible = false;
                    gridHastaBilgi.Columns["PersonelID"].Visible = false;

                    
                    Oturum.SecilenHayvanID = Convert.ToInt32(dt.Rows[0]["HayvanID"]);
                }
                else
                {
                    
                    gridHastaBilgi.DataSource = null; 
                    Oturum.SecilenHayvanID = 0;       
                    MessageBox.Show("Bu mikroçip numarasına ait kayıt bulunamadı!", "Arama Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglanti.Close();
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Hata: " + hata.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnIslemler, 0, btnIslemler.Height);
        }
        
        bool KontrolEt()
        {
            if (Oturum.SecilenHayvanID == 0)
            {
                MessageBox.Show("⚠️ Lütfen önce yukarıdan bir hayvan arayıp BUL butonuna basınız.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void menuTibbi_Click(object sender, EventArgs e)
        {
            if (KontrolEt()) 
            {
                FrmTibbiKayit frm = new FrmTibbiKayit();
                frm.ShowDialog();
            }
        }

        private void menuKarantina_Click(object sender, EventArgs e)
        {
            if (KontrolEt())
            {
                FrmKarantina frm = new FrmKarantina();
                frm.ShowDialog();
            }
        }

        private void menuAsi_Click(object sender, EventArgs e)
        {
            if (KontrolEt())
            {
                FrmAsi frm = new FrmAsi();
                frm.ShowDialog();
            }
        }

        private void FrmVeterinerPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGirisSecim girisEkrani = new FrmGirisSecim();

            
            girisEkrani.Show();

            
            this.Hide();
            
        }
    }
}
