using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitungBelanja
{
    public partial class FrmTampilBarang : Form
    {
        public FrmTampilBarang()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmTambahBarang frm = new FrmTambahBarang();
            frm.ShowDialog();
        }

        private void dgvDataOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
