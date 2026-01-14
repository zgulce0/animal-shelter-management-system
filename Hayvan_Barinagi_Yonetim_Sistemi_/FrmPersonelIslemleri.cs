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
    public partial class FrmPersonelIslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmPersonelIslemleri()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }
        void PersonelListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

               
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPersonel.DataSource = dt;

                
                if (dgvPersonel.Columns["Parola"] != null)
                    dgvPersonel.Columns["Parola"].Visible = false;

                dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Liste hatası: " + hata.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                
                SqlCommand komut = new SqlCommand("INSERT INTO Personel (Ad, Soyad, Pozisyon, KullaniciAdi, Parola) VALUES (@p1, @p2, @p3, @p4, @p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", cmbPozisyon.Text);
                komut.Parameters.AddWithValue("@p4", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p5", txtParola.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Personel eklendi.");
                PersonelListele(); 
                Temizle();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Ekleme hatası: " + hata.Message);
                baglanti.Close();
            }

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtKullaniciAdi.Text == "" || txtTC.Text == "")
            {
                MessageBox.Show("Lütfen Ad, Soyad, TC ve Kullanıcı Adı alanlarını doldurunuz.");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                
                string sql = @"INSERT INTO Personel 
                             (Ad, Soyad, TCKimlikNo, Pozisyon, TelefonNo, Eposta, Adres, Maas, IseGirisTarihi, CalismaDurumu, KullaniciAdi, Parola) 
                             VALUES 
                             (@ad, @soyad, @tc, @poz, @tel, @mail, @adres, @maas, @tarih, @durum, @kadi, @parola)";

                SqlCommand komut = new SqlCommand(sql, baglanti);

                
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@poz", cmbPozisyon.Text);
                komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
                komut.Parameters.AddWithValue("@mail", txtEposta.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text); 

                
                decimal maas = 0;
                if (!string.IsNullOrEmpty(txtMaas.Text)) maas = Convert.ToDecimal(txtMaas.Text);
                komut.Parameters.AddWithValue("@maas", maas);

                
                komut.Parameters.AddWithValue("@tarih", dtpIseGiris.Value.Date);
                komut.Parameters.AddWithValue("@durum", cmbCalismaDurumu.Text); 

                komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@parola", txtParola.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Personel başarıyla eklendi.");
                PersonelListele();
                Temizle();
            }
            catch (Exception hata)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Ekleme hatası: " + hata.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (dgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek personeli seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show("Bu personeli silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    int secilenID = Convert.ToInt32(dgvPersonel.CurrentRow.Cells["PersonelID"].Value);

                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                    SqlCommand komut = new SqlCommand("DELETE FROM Personel WHERE PersonelID=@id", baglanti);
                    komut.Parameters.AddWithValue("@id", secilenID);

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Personel silindi.");
                    PersonelListele();
                    Temizle();
                }
                catch (Exception hata)
                {
                    if (baglanti.State == ConnectionState.Open) baglanti.Close();
                    MessageBox.Show("Silme hatası: " + hata.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (dgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek personeli seçiniz.");
                return;
            }

            try
            {
                int secilenID = Convert.ToInt32(dgvPersonel.CurrentRow.Cells["PersonelID"].Value);

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sql = @"UPDATE Personel SET 
                             Ad=@ad, Soyad=@soyad, TCKimlikNo=@tc, Pozisyon=@poz, 
                             TelefonNo=@tel, Eposta=@mail, Adres=@adres, Maas=@maas, 
                             IseGirisTarihi=@tarih, CalismaDurumu=@durum, 
                             KullaniciAdi=@kadi, Parola=@parola 
                             WHERE PersonelID=@id";

                SqlCommand komut = new SqlCommand(sql, baglanti);

                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@poz", cmbPozisyon.Text);
                komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
                komut.Parameters.AddWithValue("@mail", txtEposta.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text); 

                decimal maas = 0;
                if (!string.IsNullOrEmpty(txtMaas.Text)) maas = Convert.ToDecimal(txtMaas.Text);
                komut.Parameters.AddWithValue("@maas", maas);

                komut.Parameters.AddWithValue("@tarih", dtpIseGiris.Value.Date); 
                komut.Parameters.AddWithValue("@durum", cmbCalismaDurumu.Text);  

                komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@parola", txtParola.Text);
                komut.Parameters.AddWithValue("@id", secilenID);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Personel bilgileri güncellendi.");
                PersonelListele();
                Temizle();
            }
            catch (Exception hata)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Güncelleme hatası: " + hata.Message);
            }
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dgvPersonel.Rows[e.RowIndex];

                txtAd.Text = satir.Cells["Ad"].Value.ToString();
                txtSoyad.Text = satir.Cells["Soyad"].Value.ToString();
                txtTC.Text = satir.Cells["TCKimlikNo"].Value.ToString();
                cmbPozisyon.Text = satir.Cells["Pozisyon"].Value.ToString();
                txtTelefon.Text = satir.Cells["TelefonNo"].Value.ToString();
                txtEposta.Text = satir.Cells["Eposta"].Value.ToString();
                txtAdres.Text = satir.Cells["Adres"].Value.ToString();
                txtMaas.Text = satir.Cells["Maas"].Value.ToString();

                
                if (satir.Cells["IseGirisTarihi"].Value != DBNull.Value)
                {
                    dtpIseGiris.Value = Convert.ToDateTime(satir.Cells["IseGirisTarihi"].Value);
                }

                
                cmbCalismaDurumu.Text = satir.Cells["CalismaDurumu"].Value.ToString();

                txtKullaniciAdi.Text = satir.Cells["KullaniciAdi"].Value.ToString();
                txtParola.Text = satir.Cells["Parola"].Value.ToString();
            }
        }
        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTC.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
            txtAdres.Clear();
            txtMaas.Clear();
            txtKullaniciAdi.Clear();
            txtParola.Clear();
            cmbPozisyon.SelectedIndex = -1;
            cmbCalismaDurumu.SelectedIndex = -1;
            dtpIseGiris.Value = DateTime.Now;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
