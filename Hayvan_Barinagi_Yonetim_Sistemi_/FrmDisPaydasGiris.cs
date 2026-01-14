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
    public partial class FrmDisPaydasGiris : Form
    {
        public FrmDisPaydasGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string adres = "Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(adres);

            
            if (string.IsNullOrEmpty(txtTC.Text) || string.IsNullOrEmpty(txtEposta.Text))
            {
                MessageBox.Show("Lütfen TC ve Telefon bilgilerini giriniz.");
                return;
            }

            try
            {
                baglanti.Open();

                
                string sql = "SELECT KisiID, Ad, Soyad FROM Dis_Paydaslar WHERE TCKimlikNo=@tc AND Eposta=@mail";

                SqlCommand komut = new SqlCommand(sql, baglanti);

                
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@mail", txtEposta.Text);

                SqlDataReader okuyucu = komut.ExecuteReader();

                if (okuyucu.Read())
                {
                    
                    int gelenID = Convert.ToInt32(okuyucu["KisiID"]);
                    string ad = okuyucu["Ad"].ToString();
                    string soyad = okuyucu["Soyad"].ToString();
                    string tamAd = ad + " " + soyad;

                    MessageBox.Show("Hoşgeldiniz Sayın " + tamAd);

                    
                    FrmDisPaydasPanel panel = new FrmDisPaydasPanel();

                    
                    panel.aktifKisiID = gelenID;

                    
                    panel.Text = "Vatandaş Paneli - " + tamAd;

                    panel.Show();
                    this.Hide();
                }
                else
                {
                    
                    okuyucu.Close(); 

                    DialogResult cevap = MessageBox.Show("Girdiğiniz bilgilerle kayıt bulunamadı.\n\nSisteme kayıt olmak ister misiniz?", "Kayıt Yok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        
                        FrmDisPaydasKayit kayit = new FrmDisPaydasKayit();
                        kayit.ShowDialog();
                    }
                }

                baglanti.Close();
            }
            catch (Exception hata)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + hata.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            
            FrmGirisSecim secimEkrani = new FrmGirisSecim();

            
            secimEkrani.Show();

            
            this.Close();
        }

        private void FrmDisPaydasGiris_Load(object sender, EventArgs e)
        {

        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDisPaydasKayit frm = new FrmDisPaydasKayit();
            frm.Show();
        }
    }
}
