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
    public partial class FrmReceipt : Form
    {
        List<Order> listOrder = null;
        decimal total = 0;

        public FrmReceipt()
        {
            InitializeComponent();
        }

        public void Run(List<Order> temp, decimal _total)
        {
            this.listOrder = temp;
            this.total = _total;
            this.ShowDialog();

        }

        private void textAngka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            this.label2.Text = total.ToString("c");

            foreach (Order ord in listOrder)
            {
                ListViewItem item = new ListViewItem(ord.DataBarang.Nama);
                item.SubItems.Add(ord.DataBarang.Harga.ToString("c"));
                item.SubItems.Add(ord.JumlahBeli.ToString());
                item.SubItems.Add($"{ord.Pajak.ToString()} %");
                item.SubItems.Add(ord.SubTotal.ToString("c"));
                listView1.Items.Add(item);
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
