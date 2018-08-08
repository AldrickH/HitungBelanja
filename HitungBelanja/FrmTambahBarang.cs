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
    public partial class FrmTambahBarang : Form
    {
        string sqlString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HitungBelanja; Integrated Security = True;";
        Barang brg = null;

        public FrmTambahBarang()
        {
            InitializeComponent();
        }

        public void Run(Barang temp = null)
        {
            brg = temp;
            this.ShowDialog();
        }

        private void textAngka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textAngkaHuruf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (this.txtKodeBarang.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, kode barang tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtKodeBarang.Focus();
            }
            else if (this.txtNamaBarang.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, nama barang tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNamaBarang.Focus();
            }
            else if (this.txtJumlahBarang.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, jumlah tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtJumlahBarang.Focus();
            }
            else if (this.txtHargaBarang.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, harga tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHargaBarang.Focus();
            }
            else
            {
                try
                {
                    using (var dao = new BarangDAO(sqlString))
                    { 

                        Barang barang = new Barang
                        {
                            Kode = this.txtKodeBarang.Text.Trim(),
                            Nama = this.txtNamaBarang.Text.Trim(),
                            Jumlah = int.Parse(this.txtJumlahBarang.Text.Trim()),
                            Harga = Convert.ToDecimal(this.txtHargaBarang.Text.Trim()),
                           Pajak = int.Parse(this.txtPajak.Text.Trim())
                        };

                        if (brg != null)
                            dao.UpdateBarang(barang);
                        else
                            dao.AddBarang(barang);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmTambahBarang_Load(object sender, EventArgs e)
        {
            if (brg != null)
            {
                this.txtKodeBarang.Text = brg.Kode;
                this.txtKodeBarang.Enabled = false;
                this.txtNamaBarang.Text = brg.Nama;
                this.txtJumlahBarang.Text = Convert.ToInt32(brg.Jumlah).ToString();
                this.txtHargaBarang.Text = Convert.ToDecimal(brg.Harga).ToString();
            }
            else
            {
                var dao = new BarangDAO(sqlString);
                this.txtKodeBarang.Text = dao.GetKodeBarangBerikutnya();
                this.txtKodeBarang.Enabled = false;
                this.btnHapus.Visible = false;

            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            using (var dao = new BarangDAO(sqlString))
            {
                dao.DeleteBarang(brg.Kode);
            }
            MessageBox.Show("Barang sudah terhapus", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
    

