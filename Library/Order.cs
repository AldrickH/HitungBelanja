using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Order
    {
        public string NoNota { get; set; }
        public string NoOrder { get; set; }
        public Barang DataBarang { get; set; }
        //public Akun DataAkun { get; set; }
        public int JumlahBeli { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Pajak { get; set; }
    }
}
