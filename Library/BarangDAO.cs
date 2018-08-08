using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                using (SqlCommand cmd = new SqlCommand(@"insert into barang values (@kode, @nama, @jumlah, @harga, @pajak)", _conn, _trans))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", barang.Kode);
                    cmd.Parameters.AddWithValue("@nama", barang.Nama);
                    cmd.Parameters.AddWithValue("@jumlah", barang.Jumlah);
                    cmd.Parameters.AddWithValue("@harga", barang.Harga);
                    cmd.Parameters.AddWithValue("@pajak", barang.Pajak);
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

        public void UpdateBarang(Barang barang)
        {
            try
            {
                _trans = _conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = _trans;
                    cmd.CommandText = @"update barang set nama = @nama, jumlah = @jumlah , harga = @harga, pajak = @pajak where kode = @kode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", barang.Kode);
                    cmd.Parameters.AddWithValue("@nama", barang.Nama);
                    cmd.Parameters.AddWithValue("@jumlah", barang.Jumlah);
                    cmd.Parameters.AddWithValue("@harga", barang.Harga);
                    cmd.Parameters.AddWithValue("@pajak", barang.Pajak);
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

        public void DeleteBarang(string kode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"delete barang where kode = @kode", _conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", kode);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Barang> GetAllDataBarang(Barang barang)
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
                                    Jumlah = int.Parse(reader["Jumlah"].ToString()),
                                    Pajak = int.Parse(reader["Pajak"].ToString())
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
                                    Jumlah = int.Parse(reader["Jumlah"].ToString()),
                                    Pajak = int.Parse(reader["Pajak"].ToString())
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

        public string GetKodeBarangBerikutnya()
        {
            string result = "";
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"Select top 1 Kode from barang order by kode desc", _conn))
                {
                    cmd.Parameters.Clear();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = reader["Kode"].ToString();
                            }
                        }
                    }
                }

                if (result.Equals(""))
                {
                    result = "0001";
                }
                else
                {
                    result = $"{(int.Parse(result) + 1).ToString("0000")}";
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
