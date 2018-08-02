using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace HitungBelanja
{
    public partial class FrmTampilBarang : Form
    {
        Barang brg = null;

        string sqlString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HitungBelanja; Integrated Security = True;";

        public FrmTampilBarang()
        {
            InitializeComponent();
            this.dgvDataBarang.AutoGenerateColumns = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmTambahBarang frm = new FrmTambahBarang();
            frm.ShowDialog();
            this.FrmTampilBarang_Load(null, null);
        }

        private void FrmTampilBarang_Load(object sender, EventArgs e)
        {
            using (var dao = new BarangDAO(sqlString))
            {
                if (dao.GetAllDataBarang().Capacity > 0)
                {
                    this.dgvDataBarang.DataSource = null;
                    this.dgvDataBarang.DataSource = dao.GetAllDataBarang();
                    this.dgvDataBarang.Columns[0].DataPropertyName = "kode";
                    this.dgvDataBarang.Columns[1].DataPropertyName = "nama";
                    this.dgvDataBarang.Columns[2].DataPropertyName = "harga";
                    this.dgvDataBarang.Columns[3].DataPropertyName = "jumlah";
                }
            }
        }

        private void txtKode_Leave(object sender, EventArgs e)
        {
            using (var dao = new BarangDAO(sqlString))
            { 
                if ((brg = dao.GetDataBarangByKode(this.txtKode.Text)) != null )
                {
                    this.txtNama.Text = brg.Nama;
                    this.txtHarga.Text = brg.Harga.ToString();
                }
            }
        }
    }
}

