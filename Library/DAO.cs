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


        // method untuk menanmbahkan barang baru
        public void AddBarang(Barang barang)
        {
            if (barang.Harga <= 0) throw new ArgumentException();
            else if (barang.Jumlah <= 0) throw new ArgumentException();
            else if (barang.Pajak < 0 || barang.Pajak > 100) throw new ArgumentException();
            else
                listBrg.Add(barang);
        }

        // method untuk delete barang
        public void DeleteBarang(Barang barang)
        {
            Barang dataToDelete = null;

            if (CheckItemExist(barang))
            {
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
            else
            {
                throw new ArgumentException("Data tersebut tidak ada");
            }
        }

        // method untuk edit barang
        public void EditBarang(Barang baru, Barang lama)
        {
            if (CheckItemExist(lama)) {
                if (baru.Jumlah <= 0) throw new ArgumentException();
                else if (baru.Harga <= 0) throw new ArgumentException();
                else if (baru.Pajak < 0 || baru.Pajak > 100) throw new ArgumentException();
                else
                {
                    for (int i = 0; i < listBrg.Count; i++)
                    {
                        Barang data = listBrg[i];
                        if (data.Kode.Equals(lama.Kode))
                        {
                            listBrg[i] = baru;
                            break;
                        }
                    }
                }
            }
        }

        // method untuk cek apakah barang tersebut adas
        private bool CheckItemExist(Barang brg)
        {
            if (listBrg?.Count > 0)
            {
                foreach (Barang data in listBrg)
                {
                    if (data.Kode.Equals(brg.Kode))
                        return true;
                }
            }
            return false;
        }
    }
}
