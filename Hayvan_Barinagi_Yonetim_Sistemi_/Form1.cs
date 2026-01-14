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
    public partial class FrmGirisSecim : Form
    {
        public FrmGirisSecim()
        {
            InitializeComponent();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            FrmPersonelGiris personelFormu = new FrmPersonelGiris();
            personelFormu.Show(); 
            this.Hide(); 
        }

        private void btnDisPaydasGiris_Click(object sender, EventArgs e)
        {
            FrmDisPaydasGiris vatandasFormu = new FrmDisPaydasGiris();
            vatandasFormu.Show();
            this.Hide();
        }

        private void FrmGirisSecim_Load(object sender, EventArgs e)
        {

        }
    }
}
