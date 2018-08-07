using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    [TestClass()]
    public class DAOTests
    {
        private DAO dao = null;

        public DAOTests()
        {
            dao = new DAO();
        }

        [TestMethod()]
        public void AddTest()
        {
            List<Barang> listBarang = new List<Barang>
            {
                new Barang { Nama = "Aldrick", Kode = "0001", Jumlah = 100, Harga = 10000 },
                new Barang { Nama = "Griselda", Kode = "0002", Jumlah = 10, Harga = 20000 },
                new Barang { Nama = "Aldrickx", Kode = "0003", Jumlah = 50, Harga = 40000 }
            };

            foreach (Barang brg in listBarang)
            {
                dao.AddBarang(brg);
            }

            Assert.AreEqual(listBarang.Count, dao.listBrg.Count);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            List<Barang> listBarang = new List<Barang>
            {
                new Barang { Nama = "Aldrick", Kode = "0001", Jumlah = 100, Harga = 10000 },
                new Barang { Nama = "Griselda", Kode = "0002", Jumlah = 10, Harga = 20000 },
                new Barang { Nama = "Aldrickx", Kode = "0003", Jumlah = 50, Harga = 40000 }
            };

            foreach (Barang brg in listBarang)
            {
                dao.listBrg.Add(brg);
            }

            dao.DeleteBarang(new Barang { Nama = "Aldrickx", Kode = "0003", Jumlah = 50, Harga = 40000 });

            Assert.AreEqual(listBarang.Count - 1, dao.listBrg.Count);
        }

        [TestMethod()]
        public void EditTest()
        {
            List<Barang> listBarang = new List<Barang>
            {
                new Barang { Nama = "Aldrick", Kode = "0001", Jumlah = 100, Harga = 10000 },
                new Barang { Nama = "Griselda", Kode = "0002", Jumlah = 10, Harga = 20000 },
                new Barang { Nama = "Aldrickx", Kode = "0003", Jumlah = 50, Harga = 40000 }
            };

            foreach (Barang brg in listBarang)
            {
                dao.listBrg.Add(brg);
            }

            dao.EditBarang(new Barang { Nama = "Griseldaaaa", Kode = "0003", Jumlah = 50, Harga = 40000 }, new Barang { Nama = "Aldrickx", Kode = "0003", Jumlah = 50, Harga = 40000 });

            CollectionAssert.AreNotEqual(listBarang, dao.listBrg);
        }

    }
}