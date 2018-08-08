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
            listBrg.Add(barang);
        }

        public void DeleteBarang(Barang barang)
        {
            Barang dataToDelete = null;
            for (int i = 0; i < listBrg.Count; i++)
            {
                dataToDelete = listBrg[i];
                if (dataToDelete.Nama.Equals(barang.Nama))
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
                if (data.Nama.Equals(lama.Nama))
                {
                    listBrg[i] = baru;
                    break;
                }
            }
        }
    }
}
