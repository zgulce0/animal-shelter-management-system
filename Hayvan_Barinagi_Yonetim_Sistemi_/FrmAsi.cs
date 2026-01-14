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
    public partial class FrmAsi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmAsi()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Asi_Programi (StokID, UygulananTur, AsiAdi, UygulamaAraligi, IlkUygulamaYasi, AktifDurum) VALUES (@sID, @tur, @ad, @aralik, @yas, @aktif)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@sID", cmbStok.SelectedValue ?? DBNull.Value);
                komut.Parameters.AddWithValue("@tur", cmbTur.Text);
                komut.Parameters.AddWithValue("@ad", txtAsiAdi.Text);
                komut.Parameters.AddWithValue("@aralik", txtAralik.Text);
                komut.Parameters.AddWithValue("@yas", Convert.ToInt32(txtYas.Text));
                komut.Parameters.AddWithValue("@aktif", chkAktif.Checked);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni aşı kuralı eklendi.");
                Listele();
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Hata: " + hata.Message);
            }
        }
        

        private void FrmAsi_Load(object sender, EventArgs e)
        {
           
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            
            StoklariDoldur();

           
            if (cmbTur.Items.Count == 0)
            {
                cmbTur.Items.Add("Kedi");
                cmbTur.Items.Add("Köpek");
                cmbTur.Items.Add("Kuş");
                cmbTur.Items.Add("Diğer");
            }

           
            if (Oturum.SecilenHayvanID > 0)
            {
                TurBilgisiniGetirVeSec();
            }
            else
            {
                
                Listele();
            }

        }
        void TurBilgisiniGetirVeSec()
        {
            try
            {
                baglanti.Open();
                
                SqlCommand komut = new SqlCommand("SELECT Tur FROM Hayvanlar WHERE HayvanID=@id", baglanti);
                komut.Parameters.AddWithValue("@id", Oturum.SecilenHayvanID);

                object sonuc = komut.ExecuteScalar(); 
                baglanti.Close();

                if (sonuc != null)
                {
                    string gelenTur = sonuc.ToString();

                    
                    cmbTur.Text = gelenTur;

                    
                    Listele();
                }
            }
            catch (Exception hata)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Tür bilgisi alınırken hata: " + hata.Message);
            }
        }
        
        void StoklariDoldur()
        {
            try
            {
                baglanti.Open();

                

                string sorgu = @"SELECT StokID, UrunAdi 
                         FROM Stok 
                         WHERE (Kategori = 'Aşı' OR Kategori= 'Asi' OR UrunAdi LIKE '%Aşı%' OR UrunAdi LIKE '%Asi%') 
                         AND MevcutMiktar > 0";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

               
                cmbStok.DataSource = null;

                if (dt.Rows.Count > 0)
                {
                    
                    cmbStok.DisplayMember = "UrunAdi"; 
                    cmbStok.ValueMember = "StokID";    
                    cmbStok.DataSource = dt;
                    cmbStok.SelectedIndex = -1;        
                }
                else
                {
                    
                }

                baglanti.Close();
            }
            catch (Exception hata)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Stoklar yüklenirken hata: " + hata.Message);
            }
        }
       
        void TurBilgisiniGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Tur FROM Hayvanlar WHERE HayvanID=@id", baglanti);
            komut.Parameters.AddWithValue("@id", Oturum.SecilenHayvanID);
            object sonuc = komut.ExecuteScalar();
            baglanti.Close();

            if (sonuc != null)
            {
                cmbTur.Text = sonuc.ToString(); 
                
               
            }
        }
        void Listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = "";

                if (string.IsNullOrEmpty(cmbTur.Text))
                {
                    sorgu = @"SELECT A.AsiProgramID, A.UygulananTur, A.AsiAdi, S.UrunAdi as 'Stoktaki Aşı', 
                              A.UygulamaAraligi, A.IlkUygulamaYasi, A.AktifDurum 
                              FROM Asi_Programi A
                              LEFT JOIN Stok S ON A.StokID = S.StokID";
                }
                else
                {
                    sorgu = @"SELECT A.AsiProgramID, A.UygulananTur, A.AsiAdi, S.UrunAdi as 'Stoktaki Aşı', 
                              A.UygulamaAraligi, A.IlkUygulamaYasi, A.AktifDurum 
                              FROM Asi_Programi A
                              LEFT JOIN Stok S ON A.StokID = S.StokID
                              WHERE A.UygulananTur = @tur";
                }

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                if (!string.IsNullOrEmpty(cmbTur.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@tur", cmbTur.Text);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                gridAsiListesi.DataSource = dt;

                
                gridAsiListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                gridAsiListesi.Columns["AsiProgramID"].Visible = false;

                baglanti.Close();
            }
            catch (Exception)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           
            if (gridAsiListesi.SelectedRows.Count > 0)
            {
                DialogResult cevap = MessageBox.Show("Bu aşı programını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        baglanti.Open();
                        
                        int id = Convert.ToInt32(gridAsiListesi.SelectedRows[0].Cells["AsiProgramID"].Value);

                        SqlCommand komut = new SqlCommand("DELETE FROM Asi_Programi WHERE AsiProgramID=@id", baglanti);
                        komut.Parameters.AddWithValue("@id", id);

                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        Listele(); 
                        MessageBox.Show("Kayıt silindi.");
                    }
                    catch (Exception hata)
                    {
                        baglanti.Close();
                        MessageBox.Show("Silme Hatası: " + hata.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz.");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void gridAsiListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridAsiListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek satırı seçiniz.");
                return;
            }

            try
            {
                // 2. ID'yi Al
                int id = Convert.ToInt32(gridAsiListesi.SelectedRows[0].Cells["AsiProgramID"].Value);

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // 3. SQL Update Sorgusu
                string sorgu = @"UPDATE Asi_Programi SET 
                         StokID=@sID, 
                         UygulananTur=@tur, 
                         AsiAdi=@ad, 
                         UygulamaAraligi=@aralik, 
                         IlkUygulamaYasi=@yas, 
                         AktifDurum=@aktif 
                         WHERE AsiProgramID=@id";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                // 4. Parametreler
                komut.Parameters.AddWithValue("@sID", cmbStok.SelectedValue ?? DBNull.Value);
                komut.Parameters.AddWithValue("@tur", cmbTur.Text);
                komut.Parameters.AddWithValue("@ad", txtAsiAdi.Text);
                komut.Parameters.AddWithValue("@aralik", txtAralik.Text);
                // Sayı hatası olmaması için güvenli çevirim
                int yas = 0;
                int.TryParse(txtYas.Text, out yas);
                komut.Parameters.AddWithValue("@yas", yas);

                komut.Parameters.AddWithValue("@aktif", chkAktif.Checked);
                komut.Parameters.AddWithValue("@id", id); // Hangi kaydı güncelleyeceğimizi belirten ID

                // 5. İşlemi Yap
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Aşı programı güncellendi.");
                Listele(); // Listeyi yenile

                // Temizlik (İsteğe bağlı)
                txtAsiAdi.Clear();
                txtAralik.Clear();
                txtYas.Clear();
            }
            catch (Exception hata)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Güncelleme Hatası: " + hata.Message);
            }
        }
    }
    }

