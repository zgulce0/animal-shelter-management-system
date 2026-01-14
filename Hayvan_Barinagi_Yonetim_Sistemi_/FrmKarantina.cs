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
    public partial class FrmKarantina : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmKarantina()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNedeni_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmKarantina_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (Oturum.SecilenHayvanID == 0)
            {
                MessageBox.Show("Lütfen önce hayvan seçiniz.");
                this.Close();
                return;
            }

            
            GecmisGetir();
        }

        void GecmisGetir()
        {
            try
            {
                baglanti.Open();
                
                string sorgu = "SELECT GirisTarihi, CikisTarihi, GirisNedeni, CikisSonucu, Gozlemler FROM KarantinaTakibi WHERE HayvanID=@id ORDER BY GirisTarihi DESC";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@id", Oturum.SecilenHayvanID);

                DataTable dt = new DataTable();
                da.Fill(dt);
                gridKarantinaGecmis.DataSource = dt;
                gridKarantinaGecmis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 

                baglanti.Close();
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Hata: " + hata.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtNedeni.Text == "")
            {
                MessageBox.Show("Lütfen karantina nedenini yazınız.");
                return;
            }

            try
            {
                
                baglanti.Open();

                
                string sorgu = @"INSERT INTO KarantinaTakibi 
                       (PersonelID, HayvanID, GirisTarihi, CikisTarihi, GirisNedeni, CikisSonucu, Gozlemler) 
                       VALUES 
                       (@pID, @hID, @giris, @cikis, @neden, @sonuc, @gozlem)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

               
                komut.Parameters.AddWithValue("@pID", Oturum.PersonelID);
                komut.Parameters.AddWithValue("@hID", Oturum.SecilenHayvanID);
                komut.Parameters.AddWithValue("@giris", dtpGiris.Value);
                komut.Parameters.AddWithValue("@cikis", dtpCikis.Value);
                komut.Parameters.AddWithValue("@neden", txtNedeni.Text);
                komut.Parameters.AddWithValue("@sonuc", txtSonuc.Text);
                komut.Parameters.AddWithValue("@gozlem", txtGozlem.Text);

                
                komut.ExecuteNonQuery();
                baglanti.Close();

                
                MessageBox.Show("Karantina kaydı başarıyla oluşturuldu!", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                GecmisGetir();

               
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt sırasında hata oluştu: " + hata.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
