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
    public class MuonDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public MuonDAL()
        {

            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        }
        //public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Them(MuonDTO add)
        {
            string query = string.Empty;
            query += "INSERT INTO DocGia ([MaSach], [MaDauSach], [MaDocGia], [NgayMuon], [NgayHetHan])";
            query += "VALUES (@MaSach,@,MaDauSach,@MaDocGia,@NgayMuon,@NgayHetHan)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSach", add.Masach);
                    cmd.Parameters.AddWithValue("@MaDauSach", add.Madausach);
                    cmd.Parameters.AddWithValue("@MaDocGia", add.Madocgia);
                    cmd.Parameters.AddWithValue("@NgayMuon", add.Ngaymuon);
                    cmd.Parameters.AddWithValue("@Email", add.Ngayhethan);                 
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

        public bool Xoa(MuonDTO del)
        {
            string query = string.Empty;
            query += "DELETE FROM DocGia WHERE [MaDocGia] = @MaDocGia AND [MaSach] = @MaSach " ;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaDocGia", del.Madocgia);
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

        
    }
}
