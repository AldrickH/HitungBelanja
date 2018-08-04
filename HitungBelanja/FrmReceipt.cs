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

        public FrmReceipt()
        {
            InitializeComponent();
        }

        public void Run(List<Order> temp)
        {
            this.listOrder = temp;
            this.ShowDialog();

        }

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            foreach(Order ord in listOrder)
            {
                ListViewItem item = new ListViewItem(ord.DataBarang.Nama);
                item.SubItems.Add(ord.DataBarang.Harga.ToString());
                item.SubItems.Add(ord.JumlahBeli.ToString());
                item.SubItems.Add(ord.SubTotal.ToString());
                listView1.Items.Add(item);

            }
        }

    }
}
