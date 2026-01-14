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
    public partial class FrmTibbiKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");

        bool karantinaFormuAcildiMi = false;
        public FrmTibbiKayit()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmTibbiKayit_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;               
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            
            if (Oturum.SecilenHayvanID == 0)
            {
                MessageBox.Show("Hata: Hayvan seçilmedi!");
                this.Close();
                return;
            }

            HayvanBilgisiGetir();
            StokDoldur();
            GecmisGetir();

            dtpIslemTarihi.Value = DateTime.Now;
            dtpRandevu.Enabled = false;
        }
        void StokDoldur()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT StokID, UrunAdi FROM Stok WHERE MevcutMiktar > 0", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                cmbStok.DisplayMember = "UrunAdi"; 
                cmbStok.ValueMember = "StokID";    
                cmbStok.DataSource = dt;
                cmbStok.SelectedIndex = -1;        
            }
            catch (Exception) {  }
        }
        void HayvanBilgisiGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Ad, Tur FROM Hayvanlar WHERE HayvanID=@id", baglanti);
            komut.Parameters.AddWithValue("@id", Oturum.SecilenHayvanID);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblHayvanBilgi.Text = "SEÇİLEN HASTA: " + oku["Ad"].ToString().ToUpper() + " (" + oku["Tur"].ToString() + ")";
            }
            baglanti.Close();
        }
        void GecmisGetir()
        {
            baglanti.Open();
            string sorgu = @"
        SELECT T.IslemTarihi, T.IslemTuru, T.Aciklama, T.Sonuc, S.UrunAdi as 'Kullanılan İlaç', T.RandevuTarihi 
        FROM Tibbi_Kayitlar T
        LEFT JOIN Stok S ON T.StokID = S.StokID
        WHERE T.HayvanID = @id
        ORDER BY T.IslemTarihi DESC";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@id", Oturum.SecilenHayvanID);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gridTibbiGecmis.DataSource = dt;

            
            gridTibbiGecmis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (baglanti.State == ConnectionState.Open) baglanti.Close();

            try
            {
                baglanti.Open();

                
                string sorgu = @"INSERT INTO Tibbi_Kayitlar 
                        (HayvanID, PersonelID, StokID, IslemTuru, IslemTarihi, Aciklama, Sonuc, RandevuTarihi) 
                        VALUES 
                        (@hID, @pID, @sID, @tur, @tarih, @aciklama, @sonuc, @randevu)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@hID", Oturum.SecilenHayvanID);
                komut.Parameters.AddWithValue("@pID", Oturum.PersonelID);
                komut.Parameters.AddWithValue("@tur", cmbIslemTuru.Text);
                komut.Parameters.AddWithValue("@tarih", dtpIslemTarihi.Value);
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                komut.Parameters.AddWithValue("@sonuc", txtSonuc.Text);

               
                if (cmbStok.SelectedIndex != -1)
                    komut.Parameters.AddWithValue("@sID", cmbStok.SelectedValue);
                else
                    komut.Parameters.AddWithValue("@sID", DBNull.Value);

                
                if (chkRandevu.Checked)
                    komut.Parameters.AddWithValue("@randevu", dtpRandevu.Value);
                else
                    komut.Parameters.AddWithValue("@randevu", DBNull.Value);

                
                komut.ExecuteNonQuery();

                
                if (cmbStok.SelectedIndex != -1)
                {
                    
                    int secilenStokID = Convert.ToInt32(cmbStok.SelectedValue);

                    
                    string stokDusurmeSorgusu = "UPDATE Stok SET MevcutMiktar = MevcutMiktar - 1 WHERE StokID = @id";

                    SqlCommand komutStok = new SqlCommand(stokDusurmeSorgusu, baglanti);
                    komutStok.Parameters.AddWithValue("@id", secilenStokID);

                    komutStok.ExecuteNonQuery(); 
                }
               

                baglanti.Close();

                MessageBox.Show("Tıbbi kayıt başarıyla oluşturuldu ve stok güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                string girilenAciklama = txtAciklama.Text.ToLower();
                if (girilenAciklama.Contains("karantina"))
                {
                    DialogResult cevap = MessageBox.Show("Açıklamada 'Karantina' ifadesi geçti. Karantina formuna gitmek ister misiniz?",
                                                         "Yönlendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        FrmKarantina frm = new FrmKarantina();
                        frm.ShowDialog();
                    }
                }

                
                txtAciklama.Clear();
                txtSonuc.Clear();
                cmbStok.SelectedIndex = -1;
                chkRandevu.Checked = false;
                GecmisGetir(); 
            }
            catch (Exception hata)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata oluştu: " + hata.Message);
            }
        }
        private void chkRandevu_CheckedChanged(object sender, EventArgs e)
        {
            
            dtpRandevu.Enabled = chkRandevu.Checked;
        }

        private void chkRandevu_CheckedChanged_1(object sender, EventArgs e)
        {
            dtpRandevu.Enabled = chkRandevu.Checked;
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
