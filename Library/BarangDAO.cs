using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BarangDAO : IDisposable
    {
        SqlConnection _conn = null;
        SqlTransaction _trans = null;

        public BarangDAO(string connectionString)
        {
            try
            {
                _conn = new SqlConnection(connectionString);
                _conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddBarang(Barang barang)
        {
            try
            {
                _trans = _conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand(@"insert into barang values (@kode, @nama, @jumlah, @harga)", _conn, _trans))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", barang.Kode);
                    cmd.Parameters.AddWithValue("@nama", barang.Nama);
                    cmd.Parameters.AddWithValue("@jumlah", barang.Jumlah);
                    cmd.Parameters.AddWithValue("@harga", barang.Harga);
                    cmd.ExecuteNonQuery();
                }
                _trans.Commit();
            }
            catch (Exception ex)
            {
                if (_trans != null) _trans.Rollback();
                throw ex;
            }
            finally
            {
                if (_trans != null) _trans.Dispose();
            }
        }

        public List<Barang> GetAllDataBarang()
        {
            List<Barang> listData = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"select * from barang order by kode", _conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listData = new List<Barang>();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listData.Add(new Barang
                                {
                                    Kode = reader["Kode"].ToString(),
                                    Nama = reader["Nama"].ToString(),
                                    Harga = Convert.ToDecimal(reader["Harga"]),
                                    Jumlah = int.Parse(reader["Jumlah"].ToString())
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listData;
        }

        public Barang GetDataBarangByKode(string kode)
        {
            Barang result = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"select * from barang where kode = @kode", _conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Kode", kode);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = new Barang
                                {
                                    Kode = reader["Kode"].ToString(),
                                    Nama = reader["Nama"].ToString(),
                                    Harga = Convert.ToDecimal(reader["Harga"]),
                                    Jumlah = int.Parse(reader["Jumlah"].ToString())
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }
    }
}
