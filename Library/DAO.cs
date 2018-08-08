using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DAO
    {
        public List<Barang> listBrg = new List<Barang>();

        public void AddBarang(Barang barang)
        {
            if (barang.Harga <= 0) throw new ArgumentException();
            else if (barang.Jumlah <= 0) throw new ArgumentException();
            else if (barang.Pajak < 0 || barang.Pajak > 100) throw new ArgumentException();
            else
                listBrg.Add(barang);
        }

        public void DeleteBarang(Barang barang)
        {
            Barang dataToDelete = null;
            for (int i = 0; i < listBrg.Count; i++)
            {
                dataToDelete = listBrg[i];
                if (dataToDelete.Kode.Equals(barang.Kode))
                {
                    break;
                }
            }
            if (dataToDelete != null) listBrg.Remove(dataToDelete);
        }

        public void EditBarang(Barang baru, Barang lama)
        {
            for (int i = 0; i < listBrg.Count; i++)
            {
                Barang data = listBrg[i];
                if (data.Kode.Equals(lama.Kode))
                {
                    if (baru.Jumlah <= 0) throw new ArgumentException();
                    else if (baru.Harga <= 0) throw new ArgumentException();
                    else if (baru.Pajak < 0 || baru.Pajak > 100) throw new ArgumentException();
                    else
                    listBrg[i] = baru;
                    break;
                }
            }
        }
    }
}
