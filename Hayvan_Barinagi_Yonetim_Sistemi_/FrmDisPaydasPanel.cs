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
    public partial class FrmDisPaydasPanel : Form
    {
        public int aktifKisiID = 0;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmDisPaydasPanel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDisPaydasPanel_Load(object sender, EventArgs e)
        {
            HayvanlariListele();
            GecmisiListele();
            GecmisiListele();
            ProfilBilgileriGetir();
            BagisGecmisiListele();
            if (cmbBagisTuru.Items.Count == 0)
            {
                cmbBagisTuru.Items.Add("Nakit");
                cmbBagisTuru.Items.Add("Mama");
                cmbBagisTuru.Items.Add("İlaç/Tıbbi Malzeme");
                cmbBagisTuru.Items.Add("Diğer");
            }
            
        }

        void HayvanlariListele()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT  HayvanID,Ad, Tur, Cinsiyet, TahminiYas, Irk FROM Hayvanlar WHERE MevcutDurum='Barınakta' OR MevcutDurum='Tedavide'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridHayvanlar.DataSource = dt;
        }

        void GecmisiListele()
        {
            
            string sorgu = @"
                SELECT h.Ad AS [Hayvan Adı], h.Tur, s.SahiplendirmeTarihi, s.SozlesmeNo, s.TakipDurumu
                FROM Sahiplendirme s
                JOIN Hayvanlar h ON s.HayvanID = h.HayvanID
                WHERE s.KisiID = @id";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@id", aktifKisiID);

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridGecmis.DataSource = dt;
        }
        
        private void btnSahiplenmeTalebi_Click(object sender, EventArgs e)
        {
            if (gridHayvanlar.SelectedRows.Count > 0)
            {
                try
                {
                    baglanti.Open();

                    
                    int secilenHayvanID = Convert.ToInt32(gridHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);
                    string hayvanAd = gridHayvanlar.SelectedRows[0].Cells["Ad"].Value.ToString();

                    
                    SqlCommand yetkiKomut = new SqlCommand("SELECT SahiplendirmeyeUygunluk, DogrulamaDurumu FROM Dis_Paydaslar WHERE KisiID=@kID", baglanti);
                    yetkiKomut.Parameters.AddWithValue("@kID", aktifKisiID);

                    SqlDataReader oku = yetkiKomut.ExecuteReader();

                    bool uygunMu = false;
                    bool dogrulanmisMi = false;

                    if (oku.Read())
                    {
                        
                        if (oku["SahiplendirmeyeUygunluk"] != DBNull.Value)
                            uygunMu = Convert.ToBoolean(oku["SahiplendirmeyeUygunluk"]);

                        if (oku["DogrulamaDurumu"] != DBNull.Value)
                            dogrulanmisMi = Convert.ToBoolean(oku["DogrulamaDurumu"]);
                    }
                    oku.Close(); 

                    
                    if (uygunMu == false || dogrulanmisMi == false)
                    {
                        string hataMesaji = "Sahiplenme talebi oluşturabilmek için profilinizin Yönetici tarafından onaylanması gerekmektedir.\n\nEksik Onaylar:";

                        if (uygunMu == false) hataMesaji += "\n- Sahiplendirmeye Uygunluk Onayı Yok";
                        if (dogrulanmisMi == false) hataMesaji += "\n- Kimlik/Bilgi Doğrulaması Yapılmamış";

                        MessageBox.Show(hataMesaji, "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        baglanti.Close();
                        return; 
                    }

                    

                    SqlCommand kontrol = new SqlCommand("SELECT Count(*) FROM SahiplenmeTalepleri WHERE HayvanID=@hID AND KisiID=@kID AND Durum='Beklemede'", baglanti);
                    kontrol.Parameters.AddWithValue("@hID", secilenHayvanID);
                    kontrol.Parameters.AddWithValue("@kID", aktifKisiID);

                    int varMi = Convert.ToInt32(kontrol.ExecuteScalar());

                    if (varMi > 0)
                    {
                        MessageBox.Show("Bu hayvan için zaten bekleyen bir talebiniz var.");
                    }
                    else
                    {
                        
                        string sorgu = "INSERT INTO SahiplenmeTalepleri (HayvanID, KisiID, Durum) VALUES (@hID, @kID, 'Beklemede')";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@hID", secilenHayvanID);
                        komut.Parameters.AddWithValue("@kID", aktifKisiID);

                        komut.ExecuteNonQuery();

                        MessageBox.Show($"'{hayvanAd}' için sahiplenme talebiniz yetkililere iletildi.\nDurumu 'Sahiplendiklerim' kısmından takip edebilirsiniz.");
                    }

                    baglanti.Close();
                }
                catch (Exception hata)
                {
                    if (baglanti.State == ConnectionState.Open) baglanti.Close();
                    MessageBox.Show("Hata: " + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir hayvan seçiniz.");
            }
        }

        void BagisGecmisiListele()
        {
            try
            {
                
                string sql = "SELECT BagisTarihi, BagisTuru, Miktar, ParaBirimi, Aciklama FROM Bagis WHERE KisiID=@id ORDER BY BagisTarihi DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@id", aktifKisiID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                
                if (dgvBagisGecmisi != null)
                    dgvBagisGecmisi.DataSource = dt;
            }
            catch (Exception)
            {
                
            }
        }
        private void btnBagisYap_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtBagisMiktar.Text) || cmbBagisTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen miktar ve tür seçiniz.");
                return;
            }

            try
            {
                
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                
                string paraBirimi = "TRY";
                if (cmbBagisTuru.Text != "Nakit")
                {
                    
                    paraBirimi = "Adet/Kg";
                }

                string insertSorgu = "INSERT INTO Bagis (KisiID, PersonelID, BagisTarihi, BagisTuru, Miktar, ParaBirimi, Aciklama) " +
                                     "VALUES (@kisi, @personel, @tarih, @tur, @miktar, @birim, @aciklama)";

                SqlCommand komutBagis = new SqlCommand(insertSorgu, baglanti);

                
                komutBagis.Parameters.AddWithValue("@kisi", aktifKisiID);

                
                if (Oturum.PersonelID != 0)
                    komutBagis.Parameters.AddWithValue("@personel", Oturum.PersonelID);
                else
                    komutBagis.Parameters.AddWithValue("@personel", DBNull.Value);

                komutBagis.Parameters.AddWithValue("@tarih", DateTime.Now);
                komutBagis.Parameters.AddWithValue("@tur", cmbBagisTuru.Text); 

                
                decimal bagisMiktari = Convert.ToDecimal(txtBagisMiktar.Text);
                komutBagis.Parameters.AddWithValue("@miktar", bagisMiktari);

                komutBagis.Parameters.AddWithValue("@birim", paraBirimi);
                komutBagis.Parameters.AddWithValue("@aciklama", txtAciklama.Text);

                komutBagis.ExecuteNonQuery(); 

               

                
                if (cmbBagisTuru.Text != "Nakit")
                {
                    
                    string stokUpdateSorgu = "UPDATE Stok SET MevcutMiktar = MevcutMiktar + @gelenMiktar WHERE UrunAdi = @urunAdi";

                    SqlCommand komutStok = new SqlCommand(stokUpdateSorgu, baglanti);

                    
                    int stokMiktariInt = Convert.ToInt32(bagisMiktari);

                    komutStok.Parameters.AddWithValue("@gelenMiktar", stokMiktariInt);
                    komutStok.Parameters.AddWithValue("@urunAdi", cmbBagisTuru.Text); 

                    
                    int etkilenen = komutStok.ExecuteNonQuery();

                    
                    if (etkilenen == 0)
                    {
                        
                        MessageBox.Show("Bağış kaydedildi ancak 'Stok' tablosunda '" + cmbBagisTuru.Text + "' adında bir ürün bulunamadığı için stok miktarı artırılamadı.");
                    }
                }

                baglanti.Close();
                MessageBox.Show("Bağış başarıyla alındı ve kayıt edildi.");

                // Temizlik
                txtBagisMiktar.Clear();
                txtAciklama.Clear();
            }
            catch (Exception hata)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("Hata oluştu: " + hata.Message);
            }
        }

        void ProfilBilgileriGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                
                SqlCommand komut = new SqlCommand("SELECT * FROM Dis_Paydaslar WHERE KisiID=@id", baglanti);
                komut.Parameters.AddWithValue("@id", aktifKisiID);

                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    
                    if (txtProfilAd != null) txtProfilAd.Text = oku["Ad"].ToString();
                    if (txtProfilSoyad != null) txtProfilSoyad.Text = oku["Soyad"].ToString();
                    if (txtProfilTC != null) txtProfilTC.Text = oku["TCKimlikNo"].ToString();
                    if (txtProfilTel != null) txtProfilTel.Text = oku["Telefon"].ToString();
                    if (txtProfilEposta != null) txtProfilEposta.Text = oku["Eposta"].ToString();
                    if (txtProfilAdres != null) txtProfilAdres.Text = oku["Adres"].ToString();
                    if (cmbIletisimTercihi != null) cmbIletisimTercihi.Text = oku["IletisimTercihi"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmDisPaydasGiris girisEkrani = new FrmDisPaydasGiris();
            girisEkrani.Show();

            
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnProfilGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sql = @"UPDATE Dis_Paydaslar SET 
                               Ad=@ad, 
                               Soyad=@soyad, 
                               TCKimlikNo=@tc, 
                               Telefon=@tel, 
                               Eposta=@mail, 
                               Adres=@adres, 
                               IletisimTercihi=@iletisim 
                               WHERE KisiID=@id";

                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@ad", txtProfilAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtProfilSoyad.Text);
                komut.Parameters.AddWithValue("@tc", txtProfilTC.Text);
                komut.Parameters.AddWithValue("@tel", txtProfilTel.Text);
                komut.Parameters.AddWithValue("@mail", txtProfilEposta.Text);
                komut.Parameters.AddWithValue("@adres", txtProfilAdres.Text);
                komut.Parameters.AddWithValue("@iletisim", cmbIletisimTercihi.Text);
                komut.Parameters.AddWithValue("@id", aktifKisiID);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Profil bilgileriniz başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        private void gridHayvanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
