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
        string sqlString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HitungBelanja; Integrated Security = True;";

        public FrmTampilBarang()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmTambahBarang frm = new FrmTambahBarang();
            frm.ShowDialog();
        }

        private void FrmTampilBarang_Load(object sender, EventArgs e)
        {
            using (var dao = new BarangDAO(sqlString))
            {
                if (dao.GetAllDataBarang().Capacity > 0)
                {
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = dao.GetAllDataBarang();
                    this.dataGridView1.Columns[0].DataPropertyName = "kode";
                    this.dataGridView1.Columns[1].DataPropertyName = "nama";
                    this.dataGridView1.Columns[2].DataPropertyName = "harga";
                    this.dataGridView1.Columns[3].DataPropertyName = "jumlah";
                }
            }
        }
    }
}

