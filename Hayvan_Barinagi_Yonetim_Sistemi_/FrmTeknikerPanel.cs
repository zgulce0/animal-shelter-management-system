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
    public partial class FrmTeknikerPanel : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmTeknikerPanel()
        {
            InitializeComponent();
        }
        private void FrmTeknikerPanel_Load(object sender, EventArgs e)
        {
            StokListele();
            BeslenmeComboboxlariDoldur();

            
            BeslenmeListele();
            BeslenmeHatirlatici();
        }

        #region Stok Yonetimi (TabPage1)

        void StokListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Stok ORDER BY Kategori, UrunAdi", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridStok.DataSource = dt;

                
                if (gridStok.Columns["MevcutMiktar"] != null)
                    gridStok.Columns["MevcutMiktar"].DefaultCellStyle.Format = "N2";

                gridStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                baglanti.Close();
            }
            catch (Exception hata)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Stok listesi hatası: " + hata.Message);
            }
        }

        void StokTemizle()
        {
            
            txtAd.Clear();
            txtMiktar.Clear();
            txtKritik.Clear();
            txtTedarikci.Clear();
            if (cmbBirim != null) { cmbBirim.SelectedIndex = -1; cmbBirim.Text = ""; }
            if (cmbKategori != null) { cmbKategori.SelectedIndex = -1; cmbKategori.Text = ""; }
            dtpSKT.Value = DateTime.Now;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = @"INSERT INTO Stok (UrunAdi, Kategori, MevcutMiktar, Birim, KritikSeviye, SonKullanmaTarihi, Tedarikci) 
                                VALUES (@ad, @kat, @mik, @birim, @kritik, @skt, @ted)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@kat", cmbKategori.Text);
                komut.Parameters.AddWithValue("@mik", Convert.ToDecimal(txtMiktar.Text)); 
                komut.Parameters.AddWithValue("@birim", cmbBirim.Text);
                komut.Parameters.AddWithValue("@kritik", Convert.ToInt32(txtKritik.Text));
                komut.Parameters.AddWithValue("@skt", dtpSKT.Value);
                komut.Parameters.AddWithValue("@ted", txtTedarikci.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün stoka eklendi.");
                StokListele();
                StokTemizle();
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Ekleme Hatası: " + hata.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridStok.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        baglanti.Open();
                        int id = Convert.ToInt32(gridStok.SelectedRows[0].Cells["StokID"].Value);
                        SqlCommand komut = new SqlCommand("DELETE FROM Stok WHERE StokID=@id", baglanti);
                        komut.Parameters.AddWithValue("@id", id);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        StokListele();
                    }
                    catch
                    {
                        baglanti.Close();
                        MessageBox.Show("Bu ürün kullanımda olduğu için silinemez.");
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (gridStok.SelectedRows.Count > 0)
            {
                try
                {
                    baglanti.Open();
                    int id = Convert.ToInt32(gridStok.SelectedRows[0].Cells["StokID"].Value);
                    string sorgu = @"UPDATE Stok SET UrunAdi=@ad, Kategori=@kat, MevcutMiktar=@mik, Birim=@birim, 
                                     KritikSeviye=@kritik, SonKullanmaTarihi=@skt, Tedarikci=@ted WHERE StokID=@id";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@kat", cmbKategori.Text);
                    komut.Parameters.AddWithValue("@mik", Convert.ToDecimal(txtMiktar.Text));
                    komut.Parameters.AddWithValue("@birim", cmbBirim.Text);
                    komut.Parameters.AddWithValue("@kritik", Convert.ToInt32(txtKritik.Text));
                    komut.Parameters.AddWithValue("@skt", dtpSKT.Value);
                    komut.Parameters.AddWithValue("@ted", txtTedarikci.Text);
                    komut.Parameters.AddWithValue("@id", id);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Stok güncellendi.");
                    StokListele();
                }
                catch (Exception hata)
                {
                    baglanti.Close();
                    MessageBox.Show("Güncelleme Hatası: " + hata.Message);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            StokTemizle();
        }

        private void gridStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilen = gridStok.SelectedCells[0].RowIndex;
                txtAd.Text = gridStok.Rows[secilen].Cells["UrunAdi"].Value.ToString();
                cmbKategori.Text = gridStok.Rows[secilen].Cells["Kategori"].Value.ToString();
                txtMiktar.Text = gridStok.Rows[secilen].Cells["MevcutMiktar"].Value.ToString();
                cmbBirim.Text = gridStok.Rows[secilen].Cells["Birim"].Value.ToString();
                txtKritik.Text = gridStok.Rows[secilen].Cells["KritikSeviye"].Value.ToString();
                txtTedarikci.Text = gridStok.Rows[secilen].Cells["Tedarikci"].Value.ToString();

                if (gridStok.Rows[secilen].Cells["SonKullanmaTarihi"].Value != DBNull.Value)
                    dtpSKT.Value = Convert.ToDateTime(gridStok.Rows[secilen].Cells["SonKullanmaTarihi"].Value);
            }
        }

        #endregion

        #region Beslenme (TabPage2)

        void BeslenmeComboboxlariDoldur()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                
                string hayvanSorgu = "SELECT HayvanID, Ad FROM Hayvanlar WHERE MevcutDurum = 'Barınakta'";
                SqlDataAdapter daHayvan = new SqlDataAdapter(hayvanSorgu, baglanti);
                DataTable dtHayvan = new DataTable();
                daHayvan.Fill(dtHayvan);

                cmbBeslenmeHayvan.DisplayMember = "Ad";
                cmbBeslenmeHayvan.ValueMember = "HayvanID";
                cmbBeslenmeHayvan.DataSource = dtHayvan;
                cmbBeslenmeHayvan.SelectedIndex = -1; 

                
                string stokSorgu = "SELECT StokID, UrunAdi FROM Stok WHERE Kategori LIKE '%Mama%' OR UrunAdi LIKE '%Mama%'";
                SqlDataAdapter daStok = new SqlDataAdapter(stokSorgu, baglanti);
                DataTable dtStok = new DataTable();
                daStok.Fill(dtStok);

                cmbBeslenmeStok.DisplayMember = "UrunAdi";
                cmbBeslenmeStok.ValueMember = "StokID";
                cmbBeslenmeStok.DataSource = dtStok;
                cmbBeslenmeStok.SelectedIndex = -1; 

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Veri çekme hatası: " + hata.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        void BeslenmeListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = @"
                    SELECT 
                        b.BeslenmeID,
                        h.Ad AS [Hayvan Adı],
                        s.UrunAdi AS [Verilen Mama],
                        b.OgunAdi,
                        b.Miktar,
                        b.MiktarBirim,
                        b.BeslenmeTarihi,
                        b.BeslenmeSaati
                    FROM Beslenme b
                    INNER JOIN Hayvanlar h ON b.HayvanID = h.HayvanID
                    INNER JOIN Stok s ON b.StokID = s.StokID
                    ORDER BY b.BeslenmeTarihi DESC, b.BeslenmeSaati DESC";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridBeslenme.DataSource = dt;
                gridBeslenme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beslenme listesi hatası: " + hata.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }
        
        void BeslenmeHatirlatici()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string bugun = DateTime.Now.ToString("yyyy-MM-dd");
                int suankiSaat = DateTime.Now.Hour;

                
                string sorgu = @"
                    SELECT h.Ad, b.BeslenmeSaati, b.OgunAdi 
                    FROM Beslenme b
                    JOIN Hayvanlar h ON b.HayvanID = h.HayvanID
                    WHERE b.BeslenmeTarihi = @tarih 
                    AND DATEPART(HOUR, b.BeslenmeSaati) = @saat";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tarih", bugun);
                komut.Parameters.AddWithValue("@saat", suankiSaat);

                SqlDataReader oku = komut.ExecuteReader();
                string uyariMesaji = "";
                bool kayitVar = false;

                while (oku.Read())
                {
                    kayitVar = true;
                    string ad = oku["Ad"].ToString();
                    string saat = oku["BeslenmeSaati"].ToString();
                    string ogun = oku["OgunAdi"].ToString();
                    uyariMesaji += $"- {ad} ({saat}) - {ogun}\n";
                }
                oku.Close();
                baglanti.Close();

                if (kayitVar)
                {
                    MessageBox.Show("BESLENME SAATİ HATIRLATMASI!\n\n" + uyariMesaji, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }


        #endregion
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBeslenmeBirim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBeslenmeEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBeslenmeMiktar.Text) || cmbBeslenmeStok.SelectedIndex == -1 || cmbBeslenmeHayvan.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Hayvan, Mama ve Miktar seçimi yapınız.");
                return;
            }

            SqlTransaction islem = null;

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                islem = baglanti.BeginTransaction();

                
                SqlCommand stokBirimKomut = new SqlCommand("SELECT Birim FROM Stok WHERE StokID = @sID", baglanti, islem);
                stokBirimKomut.Parameters.AddWithValue("@sID", cmbBeslenmeStok.SelectedValue);
                string stokBirim = stokBirimKomut.ExecuteScalar()?.ToString();

                
                decimal girilenMiktar = Convert.ToDecimal(txtBeslenmeMiktar.Text);
                string girilenBirim = cmbBeslenmeBirim.Text;
                decimal dusulecekMiktar = girilenMiktar;

                if ((stokBirim == "Kg" || stokBirim == "Lt") && (girilenBirim == "Gr" || girilenBirim == "Ml"))
                {
                    dusulecekMiktar = girilenMiktar / 1000;
                }

                
                string ekleSql = @"INSERT INTO Beslenme 
                                 (HayvanID, StokID, BeslenmeSaati, BeslenmeTarihi, Miktar, MiktarBirim, OgunAdi)
                                 VALUES 
                                 (@hID, @sID, @saat, @tarih, @miktar, @birim, @ogun)";

                SqlCommand komutEkle = new SqlCommand(ekleSql, baglanti, islem);
                komutEkle.Parameters.AddWithValue("@hID", cmbBeslenmeHayvan.SelectedValue);
                komutEkle.Parameters.AddWithValue("@sID", cmbBeslenmeStok.SelectedValue);
                komutEkle.Parameters.AddWithValue("@saat", dtpBeslenmeSaat.Value.ToString("HH:mm")); 
                komutEkle.Parameters.AddWithValue("@tarih", dtpBeslenmeTarih.Value.Date);           
                komutEkle.Parameters.AddWithValue("@miktar", girilenMiktar);
                komutEkle.Parameters.AddWithValue("@birim", girilenBirim);
                komutEkle.Parameters.AddWithValue("@ogun", cmbOgun.Text);
                komutEkle.ExecuteNonQuery();

                
                string stokDusSql = "UPDATE Stok SET MevcutMiktar = MevcutMiktar - @dus WHERE StokID = @sID";
                SqlCommand komutDus = new SqlCommand(stokDusSql, baglanti, islem);
                komutDus.Parameters.AddWithValue("@dus", dusulecekMiktar);
                komutDus.Parameters.AddWithValue("@sID", cmbBeslenmeStok.SelectedValue);
                komutDus.ExecuteNonQuery();

                islem.Commit();
                baglanti.Close();

                MessageBox.Show($"Beslenme kaydedildi.\nStoktan düşülen: {dusulecekMiktar} {stokBirim}");
                BeslenmeListele();
                StokListele(); 
            }
            catch (Exception hata)
            {
                if (islem != null) islem.Rollback();
                baglanti.Close();
                MessageBox.Show("İşlem iptal edildi. Hata: " + hata.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedTab.Text == "Beslenme" || tabControl1.SelectedTab.Name == "tabPage2")
            {
                BeslenmeComboboxlariDoldur();
                BeslenmeListele();
            }
            else if (tabControl1.SelectedTab.Text == "Stok İşlemleri" || tabControl1.SelectedTab.Name == "tabPage1")
            {
                StokListele();
            }
        }

        private void cmbBeslenmeHayvan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBeslenmeSil_Click(object sender, EventArgs e)
        {
            if (gridBeslenme.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bu beslenme kaydını silmek istiyor musunuz? (Stok geri yüklenmez)", "Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                        int id = Convert.ToInt32(gridBeslenme.SelectedRows[0].Cells["BeslenmeID"].Value);

                        SqlCommand komut = new SqlCommand("DELETE FROM Beslenme WHERE BeslenmeID = @id", baglanti);
                        komut.Parameters.AddWithValue("@id", id);
                        komut.ExecuteNonQuery();

                        baglanti.Close();
                        MessageBox.Show("Kayıt silindi.");
                        BeslenmeListele();
                    }
                    catch (Exception ex)
                    {
                        if (baglanti.State == ConnectionState.Open) baglanti.Close();
                        MessageBox.Show("Silme hatası: " + ex.Message);
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
            FrmGirisSecim girisEkrani = new FrmGirisSecim();

            
            girisEkrani.Show();

            
            this.Hide();
        }
    }
}
