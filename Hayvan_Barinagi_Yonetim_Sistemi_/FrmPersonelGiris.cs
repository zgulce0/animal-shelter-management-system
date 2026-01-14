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
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FrmGirisSecim secimEkrani = new FrmGirisSecim();

            
            secimEkrani.Show();

            
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            string adres = "Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True";

            
            SqlConnection baglanti = new SqlConnection(adres);

            try
            {
                
                baglanti.Open();

                
                string sql = "SELECT * FROM Personel WHERE KullaniciAdi=@kadi AND Parola=@sifre";

                SqlCommand komut = new SqlCommand(sql, baglanti);

                
                komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtParola.Text);

                
                SqlDataReader okuyucu = komut.ExecuteReader();

                if (okuyucu.Read()) 
                {
                    Oturum.PersonelID = Convert.ToInt32(okuyucu["PersonelID"]);
                    Oturum.PersonelAdi = okuyucu["Ad"].ToString() + " " + okuyucu["Soyad"].ToString();

                    
                    string gelenPozisyon = okuyucu["Pozisyon"].ToString().Trim();
                    Oturum.Pozisyon = gelenPozisyon;

                    MessageBox.Show("Giriş Başarılı! Hoş geldin " + Oturum.PersonelAdi + "\nPozisyon: " + gelenPozisyon);

                   

                    if (gelenPozisyon == "Veteriner Hekim" || gelenPozisyon == "Veteriner")
                    {
                        FrmVeterinerPanel vetForm = new FrmVeterinerPanel();
                        vetForm.Show();
                    }
                    else if (gelenPozisyon == "Tekniker")
                    {
                        FrmTeknikerPanel tekForm = new FrmTeknikerPanel();
                        tekForm.Show();
                    }
                    else if (gelenPozisyon == "Veteriner Asistanı" || gelenPozisyon == "Yönetici")
                    {
                        
                        FrmAnaMenu anaForm = new FrmAnaMenu();
                        anaForm.Show();
                    }
                    else if (gelenPozisyon == "Yönetici" || gelenPozisyon == "Admin")
                    {
                        FrmYoneticiPaneli adminForm = new FrmYoneticiPaneli();
                        adminForm.Show();
                    }
                    else
                    {
                        
                        MessageBox.Show("Pozisyonunuza özel bir panel bulunamadı, Genel Panele yönlendiriliyorsunuz.");
                        FrmAnaMenu anaForm = new FrmAnaMenu();
                        anaForm.Show();
                    }

                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Parola!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                baglanti.Close();
            }
            catch (Exception hata)
            {
                
                MessageBox.Show("Veritabanına bağlanılamadı: " + hata.Message);
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
