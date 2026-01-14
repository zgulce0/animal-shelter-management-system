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
    public partial class FrmDisPaydasKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmDisPaydasKayit()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmDisPaydasKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtTC.Text) || string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen zorunlu alanları (Ad, Soyad, TC, Telefon) doldurunuz.");
                return;
            }

            try
            {
                baglanti.Open();

                
                SqlCommand kontrol = new SqlCommand("SELECT Count(*) FROM Dis_Paydaslar WHERE TCKimlikNo=@tc", baglanti);
                kontrol.Parameters.AddWithValue("@tc", txtTC.Text);
                int varMi = Convert.ToInt32(kontrol.ExecuteScalar());

                if (varMi > 0)
                {
                    MessageBox.Show("Bu T.C. Kimlik numarası ile zaten bir kayıt var.");
                    baglanti.Close();
                    return;
                }

               
                string sorgu = @"INSERT INTO Dis_Paydaslar 
                                (Ad, Soyad, TCKimlikNo, Telefon, Eposta, Adres, IletisimTercihi, SahiplendirmeyeUygunluk, DogrulamaDurumu) 
                                VALUES 
                                (@ad, @soyad, @tc, @tel, @mail, @adres, @iletisim, 1, 1)";

               

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
                komut.Parameters.AddWithValue("@mail", txtMail.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@iletisim", cmbIletisim.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kaydınız başarıyla oluşturuldu! Giriş yapabilirsiniz.");

                
                this.Close();
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt hatası: " + hata.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }
    }

}

