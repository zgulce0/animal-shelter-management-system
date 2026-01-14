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
    public partial class FrmTalepYonetimi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmTalepYonetimi()
        {
            InitializeComponent();
        }

        private void FrmTalepYonetimi_Load(object sender, EventArgs e)
        {
            TalepleriListele();
        }
        void TalepleriListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                
                string sorgu = @"
                    SELECT 
                        t.TalepID,
                        h.HayvanID,  -- Onaylarken lazım olacak
                        h.Ad AS [Hayvan Adı],
                        d.KisiID,    -- Onaylarken lazım olacak
                        d.Ad + ' ' + d.Soyad AS [Talep Eden Kişi],
                        d.Telefon,
                        t.TalepTarihi,
                        t.Durum
                    FROM SahiplenmeTalepleri t
                    JOIN Hayvanlar h ON t.HayvanID = h.HayvanID
                    JOIN Dis_Paydaslar d ON t.KisiID = d.KisiID
                    WHERE t.Durum = 'Beklemede'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridTalepler.DataSource = dt;

                
                gridTalepler.Columns["HayvanID"].Visible = false; 
                gridTalepler.Columns["KisiID"].Visible = false;
                gridTalepler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Liste hatası: " + hata.Message);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (gridTalepler.SelectedRows.Count > 0)
            {
                DialogResult cevap = MessageBox.Show("Bu sahiplenme talebini onaylıyor musunuz?\nHayvan 'Sahiplendirildi' olarak işaretlenecek.", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        baglanti.Open();

                        
                        int talepID = Convert.ToInt32(gridTalepler.SelectedRows[0].Cells["TalepID"].Value);
                        int hayvanID = Convert.ToInt32(gridTalepler.SelectedRows[0].Cells["HayvanID"].Value);
                        int kisiID = Convert.ToInt32(gridTalepler.SelectedRows[0].Cells["KisiID"].Value);

                        
                        SqlCommand cmdTalep = new SqlCommand("UPDATE SahiplenmeTalepleri SET Durum='Onaylandı' WHERE TalepID=@tid", baglanti);
                        cmdTalep.Parameters.AddWithValue("@tid", talepID);
                        cmdTalep.ExecuteNonQuery();

                        
                        SqlCommand cmdHayvan = new SqlCommand("UPDATE Hayvanlar SET MevcutDurum='Sahiplendirildi' WHERE HayvanID=@hid", baglanti);
                        cmdHayvan.Parameters.AddWithValue("@hid", hayvanID);
                        cmdHayvan.ExecuteNonQuery();

                        
                        SqlCommand cmdSozlesme = new SqlCommand("INSERT INTO Sahiplendirme (HayvanID, KisiID, SahiplendirmeTarihi, TakipDurumu) VALUES (@hid, @kid, @tarih, 'Takipte')", baglanti);
                        cmdSozlesme.Parameters.AddWithValue("@hid", hayvanID);
                        cmdSozlesme.Parameters.AddWithValue("@kid", kisiID);
                        cmdSozlesme.Parameters.AddWithValue("@tarih", DateTime.Now);
                        cmdSozlesme.ExecuteNonQuery();

                        baglanti.Close();
                        MessageBox.Show("Talep onaylandı ve sahiplendirme işlemi tamamlandı!");

                        TalepleriListele(); 
                    }
                    catch (Exception hata)
                    {
                        baglanti.Close();
                        MessageBox.Show("Hata: " + hata.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen onaylanacak talebi seçiniz.");
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {

            if (gridTalepler.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Talebi reddetmek istediğinize emin misiniz?", "Red", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    baglanti.Open();
                    int talepID = Convert.ToInt32(gridTalepler.SelectedRows[0].Cells["TalepID"].Value);

                   
                    SqlCommand cmd = new SqlCommand("UPDATE SahiplenmeTalepleri SET Durum='Reddedildi' WHERE TalepID=@id", baglanti);
                    cmd.Parameters.AddWithValue("@id", talepID);
                    cmd.ExecuteNonQuery();

                    baglanti.Close();
                    TalepleriListele();
                }
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            
        }
    }
}
