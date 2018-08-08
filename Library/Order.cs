using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Order
    {
        public Barang DataBarang { get; set; }
        public int JumlahBeli { get; set; }
        public decimal SubTotal { get; set; }
        public int Pajak { get; set; }
    }
}
