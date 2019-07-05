using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class TuaSachDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public TuaSachDAL()
        {
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
        }
        //public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Them(TuaSachDTO add)
        {
            string query = string.Empty;
            query += "INSERT INTO TuaSach ([Matuasach], [Tuasach], [Matheloai], [Matacgia])";
            query += "VALUES (@Matuasach,@Tuasach,@Matheloai,@Matacgia)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Matuasach", add.Matuasach);
                    cmd.Parameters.AddWithValue("@Tuasach", add.Tuasach);
                    cmd.Parameters.AddWithValue("@Matheloai", add.Matheloai);
                    cmd.Parameters.AddWithValue("@Matacgia", add.Matacgia);
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

        public bool Xoa(TuaSachDTO del)
        {
            string query = string.Empty;
            query += "DELETE FROM TuaSach WHERE [Matuasach] = @Matuasach";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Matuasach", del.Matuasach);
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

        public bool Sua(TuaSachDTO edit)
        {
            string query = string.Empty;
            query += "UPDATE TuaSach SET [Matuasach] = @Matuasach, [Tuasach] = @Tuasach, [Matheloai] = @Matheloai, [Matacgia] = @Matacgia,";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Matuasach", edit.Matuasach);
                    cmd.Parameters.AddWithValue("@Tuasach", edit.Tuasach);
                    cmd.Parameters.AddWithValue("@Matheloai",edit.Matheloai);
                    cmd.Parameters.AddWithValue("@Matacgia", edit.Matacgia);
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

        public bool kiemtra(string tuasach)
        {
            DataTable dataTable = new DataTable();
            string query = "select * from TuaSach.TuaSach = @tuasach";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tuasach", tuasach);                    
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        // this will query your database and return the result to your datatable
                        da.Fill(dataTable);
                        con.Close();
                        con.Dispose();
                    } 
                    catch (Exception ex)
                    {
                        con.Close();                       
                    }
                }
            }
            if (dataTable.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }
        public int soluongtuasach()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from TuaSach";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;                    
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        // this will query your database and return the result to your datatable
                        da.Fill(dataTable);
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                    }
                }
            }
            int soluongtuasach = dataTable.Rows.Count;
            return soluongtuasach;
        }
       
        
    }
}
