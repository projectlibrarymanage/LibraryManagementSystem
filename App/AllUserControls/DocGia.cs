using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using DAL;
using BUS;
using System.Data.SqlClient;

namespace App
{
    public partial class DocGia : UserControl
    {
        private DocGiaBUS DgBUS;
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TUJ6O4P\SQLEXPRESS;Initial Catalog=QLTV2;Integrated Security=True");

        public DocGia()
        {
            InitializeComponent();
            panel2.Hide();

            SaveAddBt.Hide();
            CancelAddBt.Hide();
            SaveEditButton.Hide();
            CancelEdit.Hide();

            textBox4.TextChanged += TextBox4_TextChanged;
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox2_TextChanged;
            textBox3.TextChanged += TextBox3_TextChanged;

            textBox6.TextChanged += TextBox6_TextChanged;
            textBox9.TextChanged += TextBox9_TextChanged;
            textBox8.TextChanged += TextBox8_TextChanged;
            textBox7.TextChanged += TextBox7_TextChanged;
        }



        private void DocGia_Load(object sender, EventArgs e)
        {
            DgBUS = new DocGiaBUS();
            DgBUS.Getlistreader(dataGridView1);
        }

        
        // Kiểm tra điền textbox     
        
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }   

        //        
        //Dịch lên xuống panel
        private void DetailBt_Click(object sender, EventArgs e)
        {           
            panel2.Left = panel1.Left;
            panel2.Top = panel1.Top + panel1.Width + delta;
            timer1.Interval = 5;
            panel2.Show();
            min = panel1.Top;
            timer1.Start();
        }

        int delta = 9, min, max;
        private void BackBt_Click(object sender, EventArgs e)
        {
            timer2.Interval = 5;
            panel1.Show();
            max = panel2.Top;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Top += delta;
            panel2.Top += delta;
            if (panel1.Top >= max)
            {
                panel1.Top = max;
                panel2.Hide();
                timer2.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Top -= delta;
            panel2.Top -= delta;
            if (panel2.Top <= min)
            {
                panel2.Top = min;
                panel1.Hide();
                timer1.Stop();
            }
        }
        //

        // Button thêm,sửa, xóa, hủy (Hiển thị thôi chứ chưa lưu dữ liệu)
        // Button thêm
        private void AddBt_Click(object sender, EventArgs e)
        {
            AddBt.Hide();
            EditButton.Hide();
            DeleteButton.Hide();
            SaveAddBt.Show();
            CancelAddBt.Show();
            SaveEditButton.Hide();
            CancelEdit.Hide();
            textBox6.Enabled = true;
            textBox9.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            dateTimePicker4.Enabled = true;
            dateTimePicker5.Enabled = true;
            dateTimePicker6.Enabled = true;
        }

        // Button hủy thêm
        private void CancelAddBt_Click(object sender, EventArgs e)
        {
            SaveAddBt.Hide();
            CancelAddBt.Hide();
            SaveEditButton.Hide();
            CancelEdit.Hide();
            AddBt.Show();
            EditButton.Show();
            DeleteButton.Show();

            textBox6.Enabled = false;
            textBox9.Enabled = false;
            textBox8.Enabled = false;
            textBox7.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = false;
        }

        // Button sửa
        private void EditButton_Click(object sender, EventArgs e)
        {
            AddBt.Hide();
            EditButton.Hide();
            DeleteButton.Hide();
            SaveAddBt.Hide();
            CancelAddBt.Hide();
            SaveEditButton.Show();
            CancelEdit.Show();
            textBox6.Enabled = true;
            textBox9.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            dateTimePicker4.Enabled = true;
            dateTimePicker5.Enabled = true;
            dateTimePicker6.Enabled = true;
        }

        // Button hủy sửa
        private void CancelEdit_Click(object sender, EventArgs e)
        {
            SaveAddBt.Hide();
            CancelAddBt.Hide();
            SaveEditButton.Hide();
            CancelEdit.Hide();
            AddBt.Show();
            EditButton.Show();
            DeleteButton.Show();
            textBox6.Enabled = false;
            textBox9.Enabled = false;
            textBox8.Enabled = false;
            textBox7.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = false;
        }


        // Các button thêm, lưu xóa,lưu sửa dữ liệu
        // Button thêm Form độc giả
        private void AddReaderBt_Click(object sender, EventArgs e)
        {
            //try
            //{
            Con.Open();            
            //}
            //catch
            //{
            if (textBox4.Text.Length == 0)
            {
                errorProvider1.SetError(textBox4, "không được để trống");
                textBox4.Focus();
                Con.Close();
            }
            else if (textBox4.Text.Length > 0 && textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "không được để trống");
                textBox1.Focus();
                Con.Close();
            }
            else if (textBox4.Text.Length > 0 && textBox1.Text.Length > 0 && textBox2.Text.Length == 0)
            {
                errorProvider1.SetError(textBox2, "không được để trống");
                textBox2.Focus();
                Con.Close();
            }
            else if (textBox4.Text.Length > 0 && textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length == 0)
            {
                errorProvider1.SetError(textBox3, "không được để trống");
                textBox3.Focus();
                Con.Close();
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn Loại độc giả !", "Lưu ý !!");
                Con.Close();
            }
            //}
            //finally
            //{
            else
            {
                DocGiaDTO DgDTO = new DocGiaDTO();
                if (radioButton1.Checked == true)
                {
                    DgDTO.Madocgia = textBox4.Text;
                    DgDTO.Hoten = textBox1.Text;
                    DgDTO.Ngaysinh = dateTimePicker1.Value;
                    DgDTO.Diachi = textBox2.Text;
                    DgDTO.Email = textBox3.Text;
                    DgDTO.Loaidocgia = radioButton1.Text;
                    DgDTO.Ngaylapthe = dateTimePicker2.Value;
                    DgDTO.Cogiatri = dateTimePicker3.Value;
                }
                else
                {
                    DgDTO.Madocgia = textBox4.Text;
                    DgDTO.Hoten = textBox1.Text;
                    DgDTO.Ngaysinh = dateTimePicker1.Value;
                    DgDTO.Diachi = textBox2.Text;
                    DgDTO.Email = textBox3.Text;
                    DgDTO.Loaidocgia = radioButton2.Text;
                    DgDTO.Ngaylapthe = dateTimePicker2.Value;
                    DgDTO.Cogiatri = dateTimePicker3.Value;
                }

                bool ketqua = DgBUS.Them(DgDTO);
                if (ketqua == false)
                {
                    MessageBox.Show("Thêm độc giả thất bại. Vui lòng kiểm tra lại dữ liệu");
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thành công");

                    string DocgiaDgv = "select * from DocGia";
                    SqlCommand commandDocGia = new SqlCommand(DocgiaDgv, Con);
                    SqlDataAdapter adapterDocGia = new SqlDataAdapter(commandDocGia);
                    DataTable table = new DataTable();
                    adapterDocGia.Fill(table);
                    dataGridView1.DataSource = table;
                    Con.Close();
                }
            }
            //}
        }

        // Button thêm Form chi tiết độc giả
        private void SaveAddBt_Click(object sender, EventArgs e)
        {
            try
            {               
                Con.Open();                
            }
            catch
            {
                if (textBox6.Text.Length == 0)
                {
                    errorProvider1.SetError(textBox6, "không được để trống");
                    textBox6.Focus();
                    Con.Close();
                }
                else if (textBox6.Text.Length > 0 && textBox9.Text.Length == 0)
                {
                    errorProvider1.SetError(textBox9, "không được để trống");
                    textBox9.Focus();
                    Con.Close();
                }
                else if (textBox6.Text.Length > 0 && textBox9.Text.Length > 0 && textBox8.Text.Length == 0)
                {
                    errorProvider1.SetError(textBox8, "không được để trống");
                    textBox8.Focus();
                    Con.Close();
                }
                else if (textBox6.Text.Length > 0 && textBox9.Text.Length > 0 && textBox8.Text.Length > 0 && textBox7.Text.Length == 0)
                {
                    errorProvider1.SetError(textBox7, "không được để trống");
                    textBox7.Focus();
                    Con.Close();
                }
                else if (radioButton5.Checked == false && radioButton6.Checked == false)
                {
                    MessageBox.Show("Bạn chưa chọn Loại độc giả !", "Lưu ý !!");
                    Con.Close();
                }
            }
            finally
            {
                DocGiaDTO DgDTO = new DocGiaDTO();
                if (radioButton5.Checked == true)
                {
                    DgDTO.Madocgia = textBox6.Text;
                    DgDTO.Hoten = textBox9.Text;
                    DgDTO.Ngaysinh = dateTimePicker4.Value;
                    DgDTO.Diachi = textBox8.Text;
                    DgDTO.Email = textBox7.Text;
                    DgDTO.Loaidocgia = radioButton5.Text;
                    DgDTO.Ngaylapthe = dateTimePicker5.Value;
                    DgDTO.Cogiatri = dateTimePicker3.Value;
                }
                else
                {
                    DgDTO.Madocgia = textBox6.Text;
                    DgDTO.Hoten = textBox9.Text;
                    DgDTO.Ngaysinh = dateTimePicker4.Value;
                    DgDTO.Diachi = textBox8.Text;
                    DgDTO.Email = textBox7.Text;
                    DgDTO.Loaidocgia = radioButton6.Text;
                    DgDTO.Ngaylapthe = dateTimePicker5.Value;
                    DgDTO.Cogiatri = dateTimePicker3.Value;
                }

                bool ketqua = DgBUS.Them(DgDTO);
                if (ketqua == false)
                {
                    MessageBox.Show("Thêm độc giả thất bại. Vui lòng kiểm tra lại dữ liệu");
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thành công");                   
                    
                    string DocgiaDgv = "select * from DocGia";
                    SqlCommand commandDocGia = new SqlCommand(DocgiaDgv, Con);
                    SqlDataAdapter adapterDocGia = new SqlDataAdapter(commandDocGia);
                    DataTable table = new DataTable();
                    adapterDocGia.Fill(table);
                   
                    dataGridView1.DataSource = table;
                    Con.Close();

                }

                SaveAddBt.Hide();
                CancelAddBt.Hide();
                AddBt.Show();
                EditButton.Show();
                DeleteButton.Show();

                textBox6.Enabled = false;
                textBox9.Enabled = false;
                textBox8.Enabled = false;
                textBox7.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker5.Enabled = false;
                dateTimePicker6.Enabled = false;

                //DgBUS = new DocGiaBUS();
                //string query = "select * from DocGia";
                //dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query, new object[] { });
            }

        }
        


        // Lưu chỉnh sửa độc giả
        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            DocGiaDTO DgDTO = new DocGiaDTO();
            if (radioButton5.Checked == true)
            {
                DgDTO.Madocgia = textBox6.Text;
                DgDTO.Hoten = textBox9.Text;
                DgDTO.Ngaysinh = dateTimePicker4.Value;
                DgDTO.Diachi = textBox8.Text;
                DgDTO.Email = textBox7.Text;
                DgDTO.Loaidocgia = radioButton5.Text;
                DgDTO.Ngaylapthe = dateTimePicker5.Value;
                DgDTO.Cogiatri = dateTimePicker3.Value;
            }
            else
            {
                DgDTO.Madocgia = textBox6.Text;
                DgDTO.Hoten = textBox9.Text;
                DgDTO.Ngaysinh = dateTimePicker4.Value;
                DgDTO.Diachi = textBox8.Text;
                DgDTO.Email = textBox7.Text;
                DgDTO.Loaidocgia = radioButton6.Text;
                DgDTO.Ngaylapthe = dateTimePicker5.Value;
                DgDTO.Cogiatri = dateTimePicker3.Value;
            }

            bool kq = DgBUS.Sua(DgDTO);
            if (kq == false)
            {
                MessageBox.Show("Sửa độc giả thất bại. Vui lòng kiểm tra lại dũ liệu");
                Con.Close();
            }
            else
            {
                MessageBox.Show("Sửa độc giả thành công");
                Con.Open();
                string DocgiaDgv = "select * from DocGia";
                SqlCommand commandDocGia = new SqlCommand(DocgiaDgv, Con);
                SqlDataAdapter adapterDocGia = new SqlDataAdapter(commandDocGia);
                DataTable table = new DataTable();
                adapterDocGia.Fill(table);
                dataGridView1.DataSource = table;
                Con.Close();
            }

            
            SaveEditButton.Hide();
            CancelEdit.Hide();
            AddBt.Show();
            EditButton.Show();
            DeleteButton.Show();

            textBox6.Enabled = false;
            textBox9.Enabled = false;
            textBox8.Enabled = false;
            textBox7.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = false;
        }

        // Button xóa
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                DocGiaDTO DgDTO = new DocGiaDTO();
                DgDTO.Madocgia = textBox6.Text;
                bool ketqua = DgBUS.Xoa(DgDTO);
                if (ketqua == false)
                {
                    MessageBox.Show("Xóa độc giả thất bại. Vui lòng kiểm tra lại dữ liệu");
                }
                else
                {
                    MessageBox.Show("Xóa độc giả thành công");
                    Con.Open();
                    string DocgiaDgv = "select * from DocGia";
                    SqlCommand commandDocGia = new SqlCommand(DocgiaDgv, Con);
                    SqlDataAdapter adapterDocGia = new SqlDataAdapter(commandDocGia);
                    DataTable table = new DataTable();
                    adapterDocGia.Fill(table);
                    dataGridView1.DataSource = table;
                    Con.Close();
                }
            }
        }

        //Binding datagrid
        int index;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            LoadGridByKeyword();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            textBox6.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox9.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            dateTimePicker4.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox8.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            dateTimePicker5.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            dateTimePicker6.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            if (dataGridView1.Rows[index].Cells[5].Value.ToString() == "Sinh Viên")
            {
                radioButton5.Checked = true;
            }
            else if (dataGridView1.Rows[index].Cells[5].Value.ToString() == "Công Chức")
            {
                radioButton6.Checked = true;
            }
        }    

        //Tìm thông tin
        private void LoadGridByKeyword()
        {
            Con.Open();
            if (radioButton3.Checked)
            {
                string MaDocgiaDgv = "select * from DocGia where Madocgia like '%" + textBox5.Text + "%'";
                SqlCommand commandDocGia = new SqlCommand(MaDocgiaDgv, Con);
                SqlDataAdapter adapterDocGia = new SqlDataAdapter(commandDocGia);
                DataTable table = new DataTable();
                adapterDocGia.Fill(table);
                dataGridView1.DataSource = table;
                Con.Close();
            }
            else
            {
                string TenDocgiaDgv = "select * from DocGia where Hoten like '%" + textBox5.Text + "%'";
                SqlCommand commandDocGia = new SqlCommand(TenDocgiaDgv, Con);
                SqlDataAdapter adapterDocGia = new SqlDataAdapter(commandDocGia);
                DataTable table = new DataTable();
                adapterDocGia.Fill(table);
                dataGridView1.DataSource = table;
                Con.Close();
            }
        }

        private void ChoseBackBt_Click(object sender, EventArgs e)
        {
            panel8.Show();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            label39.Hide();
            radioButton2.Hide();

            
            label15.Show();
            radioButton1.Show();           
        }        

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            label15.Hide();            
            radioButton1.Hide();            

            label39.Show();            
            radioButton2.Show();           
        }

        // Giới hạn tuổi độc giả từ 18 đến 55
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int year = int.Parse(DateTime.Now.Year.ToString());
            int dtp1 = int.Parse(dateTimePicker1.Value.Year.ToString());
            int age = (year - dtp1);
            textBox10.Text = (year - dtp1).ToString();
            if (age < 18 )
            {
                MessageBox.Show("Bạn chưa đủ 18 tuổi để làm thẻ thư viện", "Lưu ý", MessageBoxButtons.OKCancel);
            }
            else if (age > 55)
            {
                MessageBox.Show("Bạn đã quá tuổi (55 tuổi) để làm thẻ thư viện", "Lưu ý", MessageBoxButtons.OKCancel);
            }
        }
        //

        // Hạn sử dụng thẻ: 6 tháng
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime gioihangiatri = dateTimePicker2.Value.AddMonths(6);

            dateTimePicker3.Value = new DateTime(gioihangiatri.Year,gioihangiatri.Month,gioihangiatri.Day);
        }
        //
    }
}
