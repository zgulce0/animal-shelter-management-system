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
    public partial class FrmBagisListesi : Form
    {
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GHRJMAO\\SQLEXPRESS;Initial Catalog=BarinakYonetim;Integrated Security=True");
        public FrmBagisListesi()
        {
            InitializeComponent();
        }

        private void FrmBagisListesi_Load(object sender, EventArgs e)
        {
            BagislariListele();
        }
        void BagislariListele()
        {
            try
            {
                baglanti.Open();

                

                string sql = @"
                SELECT 
                    B.BagisID,
                    (K.Ad + ' ' + K.Soyad) AS [Bağış Yapan],
                    B.BagisTarihi,
                    B.BagisTuru,
                    B.Miktar,
                    B.ParaBirimi,
                    B.Aciklama,
                    (P.Ad + ' ' + P.Soyad) AS [Kaydeden Personel]
                FROM Bagis B
                INNER JOIN Dis_Paydaslar K ON B.KisiID = K.KisiID
                LEFT JOIN Personel P ON B.PersonelID = P.PersonelID
                ORDER BY B.BagisTarihi DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBagislar.DataSource = dt;

                
                CalculateTotalCash(dt);

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste yüklenirken hata oluştu: " + ex.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }
        void CalculateTotalCash(DataTable dt)
        {
            
            decimal toplam = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["ParaBirimi"].ToString() == "TRY")
                {
                    toplam += Convert.ToDecimal(row["Miktar"]);
                }
            }
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
