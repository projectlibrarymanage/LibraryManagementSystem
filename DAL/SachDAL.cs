using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public SachDAL()
        {
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
        }
        public bool Them(SachDTO add)
        {
            string query = string.Empty;
            query += "INSERT INTO DocGia ([MaSach], [MaDauSach], [TinhTrang])";
            query += "VALUES (@MaSach,@MaDauSach,@TinhTrang)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSach", add.Masach);
                    cmd.Parameters.AddWithValue("@MaDauSach", add.Madausach);
                    cmd.Parameters.AddWithValue("@TinhTrang", add.Tinhtrang);                 
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public bool Xoa(SachDTO del)
        {
            string query = string.Empty;
            query += "DELETE FROM Sach WHERE [MaSach] = @Masach";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSach", del.Masach);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public bool Sua(SachDTO edit)
        {
            string query = string.Empty;
            query += "UPDATE DocGia SET [MaSach] = @MaSach, [MaDauSach] = @MaDauSach, [TinhTrang] = @TinhTrang";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSach", edit.Masach);
                    cmd.Parameters.AddWithValue("@MaDauSach", edit.Madausach);
                    cmd.Parameters.AddWithValue("@TinhTrang", edit.Tinhtrang);    
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
