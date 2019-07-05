using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DauSachDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public DauSachDAL()
        {
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
        }
        public bool ADD(DauSachDTO dauSach)
        {
            string query = string.Empty;
            query += "INSERT [dbo].[DauSach] ([MaDauSach], [MaTuaSach], [NhaXB], [NamXB], [TriGia]) " +
                "VALUES (@madausach, @matuasach, @nhaxb, @namxb, @trigia)";
         
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madausach", dauSach.Madausach);
                    cmd.Parameters.AddWithValue("@matuasach", dauSach.Matuasach);
                    cmd.Parameters.AddWithValue("@nhaxb", dauSach.Nxb);
                    cmd.Parameters.AddWithValue("@namxb", dauSach.Namxb);
                    cmd.Parameters.AddWithValue("@trigia", dauSach.Trigia);
                    
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
        public bool DELETE(DauSachDTO dauSach)
        {
            string query = string.Empty;
            query += "DELETE FROM DocGia WHERE [MaDauSach] = @madausach";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madausach", dauSach.Madausach);
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
        public bool ALTER(DauSachDTO dauSach)
        {
            string query = string.Empty;
            query += "UPDATE [dbo].[DauSach] SET [MaDauSach] = @madausach, [MaTuaSach] = @matuasach , [NhaXB] = @nhaxb, [NamXB] = @namxb, [TriGia] =@trigia ";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madausach", dauSach.Madausach);
                    cmd.Parameters.AddWithValue("@matuasach", dauSach.Matuasach);
                    cmd.Parameters.AddWithValue("@nhaxb", dauSach.Nxb);
                    cmd.Parameters.AddWithValue("@namxb", dauSach.Namxb);
                    cmd.Parameters.AddWithValue("@trigia", dauSach.Trigia);

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
