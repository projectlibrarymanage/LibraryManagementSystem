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
            query += "INSERT INTO Sach ([MaSach], [MaDauSach], [TinhTrang], [ngaynhap]) ";
            query += "VALUES (@MaSach,@MaDauSach,@TinhTrang,@ngaynhap)";
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
                    cmd.Parameters.AddWithValue("@ngaynhap", add.Ngaynhap);
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
        public void GetListSach(DataGridView  datagridview)
        {
            string query = string.Empty;
            query = "select Sach.MaSach , DauSach.NhaXB , DauSach.NamXB, DauSach.TriGia ," +
                " TuaSach.TuaSach , TheLoai.TenTheLoai, TacGia.TenTacGia " +
                " FROM Sach, DauSach, TuaSach, TheLoai, TacGia " +
                "WHERE Sach.MaDauSach = DauSach.MaDauSach AND DauSach.MaTuaSach = TuaSach.MaTuaSach " +
                "AND TuaSach.MaTheLoai = TheLoai.MaTheLoai AND TuaSach.MaTacGia = TacGia.MaTacGia ";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = con;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = query;
                    try
                    {
                        con.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)//con dong du lieu thi doc tiep
                        {
                            if (reader.Read() == false) return;//doc ko duoc thi return
                                                                     //xu ly khi da doc du lieu len
                            datagridview.Rows.Add(reader.GetString(0), reader.GetString(4),
                                                    reader.GetString(5), reader.GetString(6),
                                                    reader.GetString(1), reader.GetString(2),
                                                    reader.GetString(6), reader.GetDateTime(3));

                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (SqlException)
                    {
                        con.Close();
                        return;
                    }
                }
            }
            return;
        }
        public int soluongsach()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from Sach";
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
            int soluongsach = dataTable.Rows.Count;
            return soluongsach;
        }    
    }
}
