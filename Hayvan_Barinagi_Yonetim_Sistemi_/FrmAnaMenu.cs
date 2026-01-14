using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    public partial class FrmAnaMenu : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridHayvanlar.SelectedRows.Count > 0)
            {
                
                DialogResult cevap = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        baglanti.Open();
                        int id = Convert.ToInt32(gridHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);

                        SqlCommand komut = new SqlCommand("DELETE FROM Hayvanlar WHERE HayvanID=@id", baglanti);
                        komut.Parameters.AddWithValue("@id", id);

                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        Listele(); 
                        Temizle();
                        MessageBox.Show("Kayıt silindi.");
                    }
                    catch (Exception hata)
                    {
                        baglanti.Close();
                        MessageBox.Show("Hata: Bu hayvanın tıbbi kayıtları veya sahiplendirme geçmişi olabilir. Önce onları silmelisiniz.\n" + hata.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                
                string sorgu = @"INSERT INTO Hayvanlar 
                        (Ad, Tur, Irk, Cinsiyet, DogumTarihi, 
                         MikrocipNumarasi, BarinakGirisTarihi, Agirlik, TahminiYas, Rengi, KisirlastirmaDurumu, MevcutDurum, PersonelID) 
                        VALUES 
                        (@ad, @tur, @irk, @cins, @dogum, 
                         @cip, @giris, @kilo, @yas, @renk, @kisir, @durum, @personelID)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@tur", cmbTur.Text); 
                komut.Parameters.AddWithValue("@irk", txtIrk.Text);
                komut.Parameters.AddWithValue("@cins", cmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@dogum", dtpDogumTarihi.Value);

                
                komut.Parameters.AddWithValue("@cip", txtMikrocip.Text);
                komut.Parameters.AddWithValue("@giris", dtpGirisTarihi.Value);

                
                komut.Parameters.AddWithValue("@kilo", Convert.ToDecimal(txtAgirlik.Text));
                komut.Parameters.AddWithValue("@yas", Convert.ToInt32(txtYas.Text));

                komut.Parameters.AddWithValue("@renk", labelRenk.Text);
                komut.Parameters.AddWithValue("@kisir", chkKisir.Checked); 
                komut.Parameters.AddWithValue("@durum", cmbDurum.Text);

                
                komut.Parameters.AddWithValue("@personelID", Oturum.PersonelID);

                komut.ExecuteNonQuery(); 
                baglanti.Close();

                MessageBox.Show("Hayvan başarıyla kaydedildi! Kaydeden: " + Oturum.PersonelAdi);

                Listele(); 
                Temizle(); 
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Hata oluştu! Lütfen sayısal alanlara (Kilo, Yaş) dikkat edin.\n\nHata Detayı: " + hata.Message);
            }
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Barınak Yönetim Paneli - Aktif Personel: " + Oturum.PersonelAdi;

           
            gridHayvanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Listele();
        }

        void Listele()
        {
            baglanti.Open();
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hayvanlar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridHayvanlar.DataSource = dt;
            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        void Temizle()
        {
            txtAd.Clear();
            cmbTur.Text = "";       
            txtIrk.Clear();
            cmbCinsiyet.Text = "";
            txtMikrocip.Clear();
            txtAgirlik.Clear();
            txtYas.Clear();
            txtRenk.Clear();
            cmbDurum.Text = "";     
            chkKisir.Checked = false;
            dtpDogumTarihi.Value = DateTime.Now;
            dtpGirisTarihi.Value = DateTime.Now;
        }

        private void gridHayvanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = gridHayvanlar.SelectedCells[0].RowIndex;

            

            txtAd.Text = gridHayvanlar.Rows[secilen].Cells["Ad"].Value.ToString();
            cmbTur.Text = gridHayvanlar.Rows[secilen].Cells["Tur"].Value.ToString();
            txtIrk.Text = gridHayvanlar.Rows[secilen].Cells["Irk"].Value.ToString();
            cmbCinsiyet.Text = gridHayvanlar.Rows[secilen].Cells["Cinsiyet"].Value.ToString();

            
            dtpDogumTarihi.Value = Convert.ToDateTime(gridHayvanlar.Rows[secilen].Cells["DogumTarihi"].Value);
            dtpGirisTarihi.Value = Convert.ToDateTime(gridHayvanlar.Rows[secilen].Cells["BarinakGirisTarihi"].Value);

            txtMikrocip.Text = gridHayvanlar.Rows[secilen].Cells["MikrocipNumarasi"].Value.ToString();
            txtAgirlik.Text = gridHayvanlar.Rows[secilen].Cells["Agirlik"].Value.ToString();
            txtYas.Text = gridHayvanlar.Rows[secilen].Cells["TahminiYas"].Value.ToString();
            txtRenk.Text = gridHayvanlar.Rows[secilen].Cells["Rengi"].Value.ToString();
            cmbDurum.Text = gridHayvanlar.Rows[secilen].Cells["MevcutDurum"].Value.ToString();

            
            if (gridHayvanlar.Rows[secilen].Cells["KisirlastirmaDurumu"].Value.ToString() == "True")
            {
                chkKisir.Checked = true;
            }
            else
            {
                chkKisir.Checked = false;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (gridHayvanlar.SelectedRows.Count > 0)
                {
                    baglanti.Open();

                   
                    int id = Convert.ToInt32(gridHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);

                    string sorgu = @"UPDATE Hayvanlar SET 
                            Ad=@ad, Tur=@tur, Irk=@irk, Cinsiyet=@cins, 
                            DogumTarihi=@dogum, MikrocipNumarasi=@cip, BarinakGirisTarihi=@giris,
                            Agirlik=@kilo, TahminiYas=@yas, Rengi=@renk, 
                            KisirlastirmaDurumu=@kisir, MevcutDurum=@durum 
                            WHERE HayvanID=@id";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    
                    komut.Parameters.AddWithValue("@ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@tur", cmbTur.Text);
                    komut.Parameters.AddWithValue("@irk", txtIrk.Text);
                    komut.Parameters.AddWithValue("@cins", cmbCinsiyet.Text);
                    komut.Parameters.AddWithValue("@dogum", dtpDogumTarihi.Value);
                    komut.Parameters.AddWithValue("@cip", txtMikrocip.Text);
                    komut.Parameters.AddWithValue("@giris", dtpGirisTarihi.Value);
                    komut.Parameters.AddWithValue("@kilo", Convert.ToDecimal(txtAgirlik.Text));
                    komut.Parameters.AddWithValue("@yas", Convert.ToInt32(txtYas.Text));
                    komut.Parameters.AddWithValue("@renk", txtRenk.Text);
                    komut.Parameters.AddWithValue("@kisir", chkKisir.Checked);
                    komut.Parameters.AddWithValue("@durum", cmbDurum.Text);

                    
                    komut.Parameters.AddWithValue("@id", id);

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Bilgiler güncellendi.");
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Lütfen listeden güncellenecek hayvanı seçin.");
                }
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Hata: " + hata.Message);
            }
        }

        private void FrmAnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
           FrmGirisSecim girisEkrani = new FrmGirisSecim();

            
           girisEkrani.Show();

            
            this.Hide();
        }
    }
}
