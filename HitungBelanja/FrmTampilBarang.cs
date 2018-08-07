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
        List<Order> listOrder = null;
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
                if (dao.GetAllDataBarang(brg).Capacity > 0)
                {
                    this.dgvDataBarang.DataSource = null;
                    this.dgvDataBarang.DataSource = dao.GetAllDataBarang(brg);
                    this.dgvDataBarang.Columns[0].DataPropertyName = "kode";
                    this.dgvDataBarang.Columns[1].DataPropertyName = "nama";
                    this.dgvDataBarang.Columns[2].DataPropertyName = "jumlah";
                    this.dgvDataBarang.Columns[3].DataPropertyName = "harga";             
                }
            }

            if (listOrder == null) { this.listOrder = new List<Order>(); }

            else
            {
                this.dgvDataOrder.Rows.Clear();
                foreach (Order ord in listOrder)
                {
                    this.dgvDataOrder.Rows.Add(new string[] {
                    ord.DataBarang.Kode, ord.DataBarang.Nama, ord.JumlahBeli.ToString(),
                    ord.DataBarang.Harga.ToString(), ord.Pajak.ToString(), ord.SubTotal.ToString()});
                }
           } 

            this.lblTotal.Text = temp.ToString();
        }
        private void dgvDataBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(this.dgvDataBarang.SelectedRows.Count.ToString());
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
                    this.txtStock.Text = brg.Jumlah.ToString();
                }
                else
                {
                    this.txtKode.Text = "";
                    this.txtHarga.Text = "";
                    this.txtJumlah.Text = "";
                    this.txtNama.Text = "";
                    this.txtPajak.Text = "";
                    this.txtStock.Text = "";
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
                else if (int.Parse(this.txtJumlah.Text) <= 0) throw new Exception("Jumlah tidak boleh nol");
                else if (this.txtPajak.Text.Equals("")) throw new Exception("Pajak tidak boleh kosong...");
                else
                {
                    decimal pajak = int.Parse(this.txtJumlah.Text) * (Convert.ToDecimal(this.txtHarga.Text) * (Convert.ToDecimal(this.txtPajak.Text) / 100));
                    decimal subTotal = (int.Parse(this.txtJumlah.Text) * Convert.ToDecimal(this.txtHarga.Text)) + pajak;

                    listOrder.Add(new Order
                    {
                        DataBarang = brg,
                        JumlahBeli = int.Parse(this.txtJumlah.Text),
                        NoNota = "A0001",
                        NoOrder = "0001",
                        SubTotal = subTotal,
                        Pajak = pajak
                    });

                    temp += subTotal;
                    FrmTampilBarang_Load(null, null);
                    this.txtKode.Text = "";
                    this.txtNama.Text = "";
                    this.txtJumlah.Text = "";
                    this.txtStock.Text = "";
                    this.txtHarga.Text = "";
                    this.txtPajak.Text = "";
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            int temp = 0;
            
            if (this.txtJumlah.Text != "")
            {
                temp = int.Parse(this.txtJumlah.Text);
                if (int.Parse(this.txtJumlah.Text) > int.Parse(txtStock.Text))
                {
                    this.txtJumlah.Text = txtStock.Text;
                }
                else
                {
                    this.txtJumlah.Text = temp.ToString();
                }
                this.txtJumlah.SelectionStart = this.txtJumlah.Text.Length;
            }
            else
            {
                this.txtJumlah.Text = "";
            }
        }

        private void txtAngkaHuruf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReceipt frm1 = new FrmReceipt();
            frm1.Run(listOrder);
            this.Show();
        }
    }
}


