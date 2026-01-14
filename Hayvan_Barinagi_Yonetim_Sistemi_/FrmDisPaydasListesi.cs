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
    public partial class FrmDisPaydasListesi : Form
    {
        public FrmDisPaydasListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");

        int secilenKisiID = 0;
        private void FrmDisPaydasListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                
                string sorgu = "SELECT * FROM Dis_Paydaslar";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDisPaydaslar.DataSource = dt;

                dgvDisPaydaslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                
                if (dgvDisPaydaslar.Columns["KisiID"] != null)
                    dgvDisPaydaslar.Columns["KisiID"].Visible = false;

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Liste yüklenirken hata oluştu: " + hata.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvDisPaydaslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                secilenKisiID = Convert.ToInt32(dgvDisPaydaslar.Rows[e.RowIndex].Cells["KisiID"].Value);
                string ad = dgvDisPaydaslar.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                string soyad = dgvDisPaydaslar.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();

                lblSecilenKisi.Text = "Seçilen Kişi: " + ad + " " + soyad;

                
               
                var uygunluk = dgvDisPaydaslar.Rows[e.RowIndex].Cells["SahiplendirmeyeUygunluk"].Value;
                var dogrulama = dgvDisPaydaslar.Rows[e.RowIndex].Cells["DogrulamaDurumu"].Value;

                chkUygunluk.Checked = (uygunluk != DBNull.Value) && Convert.ToBoolean(uygunluk);
                chkDogrulama.Checked = (dogrulama != DBNull.Value) && Convert.ToBoolean(dogrulama);
            }
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenKisiID == 0)
            {
                MessageBox.Show("Lütfen listeden bir kişi seçiniz.");
                return;
            }

            try
            {
                baglanti.Open();

               
                string sql = "UPDATE Dis_Paydaslar SET SahiplendirmeyeUygunluk=@p1, DogrulamaDurumu=@p2 WHERE KisiID=@id";
                SqlCommand komut = new SqlCommand(sql, baglanti);

                
                komut.Parameters.AddWithValue("@p1", chkUygunluk.Checked);
                komut.Parameters.AddWithValue("@p2", chkDogrulama.Checked);
                komut.Parameters.AddWithValue("@id", secilenKisiID);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kişinin onay durumları güncellendi.");
                Listele(); 
            }
            catch (Exception hata)
            {
                baglanti.Close();
                MessageBox.Show("Hata: " + hata.Message);
            }
        
    }
    }
}
