using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    /// <summary>
    /// Class untuk Unit Testing DAO
    /// </summary>

    [TestClass()]
    public class DAOTests
    {
        /*
         Constructor untuk menginisialisasi objek dao
        */

        private DAO dao = null;

        public DAOTests()
        {
            dao = new DAO();
        }

        /// <summary>
        /// Pengecekan Unit Testing pada penambahan barang
        /// </summary>

        [TestMethod()]
        public void AddTest()
        {
            List<Barang> listBarang = new List<Barang>
            {
                new Barang { Nama = "Caramel", Kode = "0001", Jumlah = 100, Harga = 10000, Pajak = 10 },
                new Barang { Nama = "Coffee", Kode = "0002", Jumlah = 10, Harga = 20000, Pajak = 10 },
                new Barang { Nama = "Tea", Kode = "0003", Jumlah = 50, Harga = 40000, Pajak = 10 }
            };

            // Untuk setiap barang pada listBarang, akan dilakukan AddBarang
            foreach (Barang brg in listBarang)
            {
                dao.AddBarang(brg);
            }

            // Pengecekan jumlah barang apakah sama atau tidak
            Assert.AreEqual(listBarang.Count, dao.listBrg.Count);
        }

        /// <summary>
        /// Pengecekan Unit Testing untuk penghapusan barang
        /// </summary>

        [TestMethod()]
        public void DeleteTest()
        {
            List<Barang> listBarang = new List<Barang>
            {
                new Barang { Nama = "Caramel", Kode = "0001", Jumlah = 100, Harga = 10000, Pajak = 10 },
                new Barang { Nama = "Coffee", Kode = "0002", Jumlah = 10, Harga = 20000, Pajak = 10 },
                new Barang { Nama = "Tea", Kode = "0003", Jumlah = 50, Harga = 40000, Pajak = 10 }
            };

            foreach (Barang brg in listBarang)
            {
                dao.listBrg.Add(brg);
            }

            // Penggunaan method DeleteBarang untuk menghapus barang dimana Kode Barang harus sesuai 
            dao.DeleteBarang(new Barang { Nama = "Caramel", Kode = "0003", Jumlah = 50, Harga = 40000, Pajak = 10 });

            // Pengecekan jumlah barang apakah sama atau tidak
            Assert.AreEqual(listBarang.Count - 1, dao.listBrg.Count);
        }

        /// <summary>
        /// Pengecekan Unit Testing untuk pengeditan barang
        /// </summary>

        [TestMethod()]
        public void EditTest()
        {
            List<Barang> listBarang = new List<Barang>
            {
                new Barang { Nama = "Caramel", Kode = "0001", Jumlah = 100, Harga = 10000, Pajak = 10 },
                new Barang { Nama = "Coffee", Kode = "0002", Jumlah = 10, Harga = 20000, Pajak = 10 },
                new Barang { Nama = "Tea", Kode = "0003", Jumlah = 50, Harga = 40000, Pajak = 10 }
            };

            foreach (Barang brg in listBarang)
            {
                dao.listBrg.Add(brg);
            }

            // Penggunaan method EditBarang untuk melakukan pengeditan dimana Kode Barang harus sesuai
            dao.EditBarang(new Barang { Nama = "Tea A", Kode = "0003", Jumlah = 50, Harga = 40000, Pajak = 10 }, new Barang { Nama = "Tea", Kode = "0003", Jumlah = 50, Harga = 40000, Pajak = 10 });

            // Pengecekan Unit Testing untuk meyakinkan bahwa ada dua barang yang berbeda ( dimana kode sama dan properti lainnya berbeda )
            CollectionAssert.AreNotEqual(listBarang, dao.listBrg);
        }

        /// <summary>
        /// Pengecekan Unit Testing untuk invalid data
        /// Harga, Jumlah dan Pajak tidak boleh lebih kecil sama dengan 0
        /// Throw exception jika terjadi inputan invalid
        /// </summary>

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AddTest_Invalid()
        {
            List<Barang> listBarang = new List<Barang>
            {
                new Barang { Nama = "Caramel", Kode = "0001", Jumlah = 100, Harga = -10000, Pajak = 0 },
                new Barang { Nama = "Coffee", Kode = "0002", Jumlah = 10, Harga = 20000, Pajak = 150 },
                new Barang { Nama = "Tea", Kode = "0003", Jumlah = -50, Harga = 40000, Pajak = -15 }
            };

            foreach (Barang brg in listBarang)
            {
                dao.AddBarang(brg);
            }
        }

        /// <summary>
        /// Pengecekan Unit Testing untuk invalid data
        /// Harga, Jumlah dan Pajak tidak boleh lebih kecil sama dengan 0
        /// Throw exception jika terjadi inputan invalid
        /// </summary>

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void EditTest_Invalid()
        {
            List<Barang> listBarang = new List<Barang>
            {
                new Barang { Nama = "Caramel", Kode = "0001", Jumlah = 100, Harga = 10000, Pajak = 10 },
                new Barang { Nama = "Coffee", Kode = "0002", Jumlah = 10, Harga = 20000, Pajak = 10 },
                new Barang { Nama = "Tea", Kode = "0003", Jumlah = 50, Harga = 40000, Pajak = 10 }
            };

            foreach (Barang brg in listBarang)
            {
                dao.listBrg.Add(brg);
            }

            dao.EditBarang(new Barang { Nama = "Tea A", Kode = "0004", Jumlah = -50, Harga = -40000, Pajak = -15 }, new Barang { Nama = "Tea", Kode = "0003", Jumlah = 50, Harga = 40000, Pajak = 10 });
        }

        /// <summary>
        /// Pengecekan Unit Testing untuk invalid data
        /// Harga, Jumlah dan Pajak tidak boleh lebih kecil sama dengan 0
        /// Throw exception jika terjadi inputan invalid
        /// </summary>

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteTest_Invalid()
        {
            List<Barang> listBarang = new List<Barang>
            {
                new Barang { Nama = "Caramel", Kode = "0001", Jumlah = 100, Harga = 10000, Pajak = 10 },
                new Barang { Nama = "Coffee", Kode = "0002", Jumlah = 10, Harga = 20000, Pajak = 10 },
                new Barang { Nama = "Tea", Kode = "0003", Jumlah = 50, Harga = 40000, Pajak = 10 }
            };

            foreach (Barang brg in listBarang)
            {
                dao.listBrg.Add(brg);
            }

            // Penggunaan method DeleteBarang untuk menghapus barang dimana Kode Barang harus sesuai 
            dao.DeleteBarang(new Barang { Nama = "Caramel", Kode = "0004", Jumlah = 50, Harga = 40000, Pajak = 10 });

            // Pengecekan jumlah barang apakah sama atau tidak
            Assert.AreEqual(listBarang.Count - 1, dao.listBrg.Count);
        }
    }
}
