using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvan_Barinagi_Yonetim_Sistemi_
{
    public partial class FrmYoneticiPaneli : Form
    {
        public FrmYoneticiPaneli()
        {
            InitializeComponent();
        }

        private void FrmYoneticiPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            FrmPersonelIslemleri frm = new FrmPersonelIslemleri();
            frm.ShowDialog(); 
        }

        private void btnBasvurular_Click(object sender, EventArgs e)
        {
            FrmTalepYonetimi fr = new FrmTalepYonetimi();
            fr.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmPersonelGiris giris = new FrmPersonelGiris();
            giris.Show();

            
            this.Hide();
        }

        private void btnBagisListesi_Click(object sender, EventArgs e)
        {

            FrmBagisListesi frm = new FrmBagisListesi();
            frm.ShowDialog(); 
        }

        private void btnDisPaydasListesi_Click(object sender, EventArgs e)
        {
            FrmDisPaydasListesi frm = new FrmDisPaydasListesi();
            frm.ShowDialog();
        }
    }
}
