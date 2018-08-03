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
        decimal temp = 0;

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
                    this.dgvDataBarang.Columns[2].DataPropertyName = "jumlah";
                    this.dgvDataBarang.Columns[3].DataPropertyName = "harga";             
                }
            }

            this.lblTotal.Text = temp.ToString();
        }

        private void dgvDataBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDataBarang.SelectedRows.Count > 0)
            {
                FrmTambahBarang frm = new FrmTambahBarang();
                frm.Run(new BarangDAO(sqlString).GetDataBarangByKode(this.dgvDataBarang.CurrentRow.Cells[0].Value.ToString()));
            }
            FrmTampilBarang_Load(null, null);
        }

        private void dgvDataBarang_Resize(object sender, EventArgs e)
        {
            this.dgvDataBarang.Columns[0].Width = 25 * this.dgvDataBarang.Width / 100;
            this.dgvDataBarang.Columns[1].Width = 25 * this.dgvDataBarang.Width / 100;
            this.dgvDataBarang.Columns[2].Width = 25 * this.dgvDataBarang.Width / 100;
            this.dgvDataBarang.Columns[3].Width = 25 * this.dgvDataBarang.Width / 100;
        }

        private void dgvDataOrder_Resize(object sender, EventArgs e)
        {
            this.dgvDataOrder.Columns[0].Width = 10 * this.dgvDataOrder.Width / 100;
            this.dgvDataOrder.Columns[1].Width = 25 * this.dgvDataOrder.Width / 100;
            this.dgvDataOrder.Columns[2].Width = 10 * this.dgvDataOrder.Width / 100;
            this.dgvDataOrder.Columns[3].Width = 20 * this.dgvDataOrder.Width / 100;
            this.dgvDataOrder.Columns[4].Width = 20 * this.dgvDataOrder.Width / 100;
            this.dgvDataOrder.Columns[5].Width = 14 * this.dgvDataOrder.Width / 100;
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
                else
                {
                    this.txtKode.Text = "";
                    this.txtHarga.Text = "";
                    this.txtJumlah.Text = "";
                    this.txtNama.Text = "";
                    this.txtPajak.Text = "";
                    this.txtKode.Focus();
                    this.label3.Visible = true;
                }
            }
        }

        private void txtAngka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtKode.Text.Equals("")) throw new Exception("Kode tidak boleh kosong...");
                else if (this.txtJumlah.Text.Equals("")) throw new Exception("Jumlah tidak boleh kosong...");
                else if (this.txtPajak.Text.Equals("")) throw new Exception("Pajak tidak boleh kosong...");
                else
                {
                    decimal pajak = int.Parse(this.txtJumlah.Text) * (Convert.ToDecimal(this.txtHarga.Text) * (Convert.ToDecimal(this.txtPajak.Text) / 100));


                    decimal subTotal = (int.Parse(this.txtJumlah.Text.ToString()) * Convert.ToDecimal(this.txtHarga.Text.ToString())) + pajak;

                    this.dgvDataOrder.DataSource = null;
                    this.dgvDataOrder.Rows.Add(new string[]
                    {
                        this.txtKode.Text.ToString(), this.txtNama.Text.ToString(), this.txtJumlah.Text.ToString(),
                        this.txtHarga.Text.ToString(), pajak.ToString(), subTotal.ToString()
                    });

                    temp += subTotal;
                    FrmTampilBarang_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtPajak_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPajak.Text != "")
            {
                decimal pjk = Convert.ToDecimal(this.txtPajak.Text);
                if (pjk > 100)
                {
                    this.txtPajak.Text = "100";
                }
                else
                {
                    this.txtPajak.Text = pjk.ToString();
                }
                this.txtPajak.SelectionStart = this.txtPajak.Text.Length;
            }
        }
    }
}


