using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library
{
    public class AkunDAO : IDisposable
    {
        SqlConnection _conn = null;

        public AkunDAO(string connectionString)
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

        public Akun GetDataCustomerByUsername(string username)
        {
            Akun result = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"select * from akun Where username = @username", _conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = new Akun
                                {
                                    Username = reader["username"].ToString(),
                                    Password = reader["Password"].ToString()
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

        public bool CheckAkunByUsername(string username)
        {
            bool result = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"select username from akun Where username = @username", _conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = true;
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
