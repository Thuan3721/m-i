using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace baidaynay
{
    public partial class FormChiTietHoaDonNhap : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        string connectionString = @"Data Source=.;Initial Catalog=QuanLyHT;Integrated Security=True";

        public FormChiTietHoaDonNhap()
        {
            InitializeComponent();
        }

        private void FormChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM ChiTietHoaDonNhap";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvChitiethoadonnhap.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }


        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    int maHDN = Convert.ToInt32(txtMaHDN.Text);

                    // Kiểm tra MaHDN có tồn tại không
                    string checkQuery = "SELECT COUNT(*) FROM HoaDonNhap WHERE MaHDN = @MaHDN";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaHDN", maHDN);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Mã Hóa Đơn Nhập không tồn tại. Hãy tạo hóa đơn trước!");
                        return;
                    }

                    string query = @"INSERT INTO ChiTietHoaDonNhap (MaHDN, IDThuoc, SoLuong, DonGiaNhap, GhiChu) 
                             VALUES (@MaHDN, @IDThuoc, @SoLuong, @DonGiaNhap, @GhiChu)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHDN", maHDN);
                    command.Parameters.AddWithValue("@IDThuoc", txtIDThuoc.Text);
                    command.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    command.Parameters.AddWithValue("@DonGiaNhap", txtDonGiaNhap.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm : " + ex.Message);
            }
        }



        private void bttSua_Click(object sender, EventArgs e)
        {
            if (dgvChitiethoadonnhap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một chi tiết hóa đơn nhập để sửa!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE ChiTietHoaDonNhap
                            SET SoLuong = @SoLuong, DonGiaNhap = @DonGiaNhap, GhiChu = @GhiChu
                            WHERE MaHDN = @MaHDN AND IDThuoc = @IDThuoc";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHDN", txtMaHDN.Text);
                    command.Parameters.AddWithValue("@IDThuoc", txtIDThuoc.Text);
                    command.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    command.Parameters.AddWithValue("@DonGiaNhap", txtDonGiaNhap.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadData();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chi tiết hóa đơn để cập nhật!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void bttXoa_Click(object sender, EventArgs e)
        {
            string maHDN = txtMaHDN.Text.ToString();  // Ép kiểu sang string
            string idThuoc = txtIDThuoc.Text.Trim();

            if (string.IsNullOrWhiteSpace(maHDN) || string.IsNullOrWhiteSpace(idThuoc))
            {
                MessageBox.Show("Vui lòng chọn chi tiết hóa đơn nhập cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM ChiTietHoaDonNhap WHERE MaHDN = @MaHDN AND IDThuoc = @IDThuoc";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MaHDN", maHDN);
                        command.Parameters.AddWithValue("@IDThuoc", idThuoc);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            LoadData();
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }


        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvChitiethoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChitiethoadonnhap.Rows[e.RowIndex];

                txtMaHDN.Text = row.Cells["MaHDN"].Value.ToString();
                txtIDThuoc.Text = row.Cells["IDThuoc"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGiaNhap.Text = row.Cells["DonGiaNhap"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }


        private void ClearInputs()
        {
            txtMaHDN.Clear();
            txtIDThuoc.Clear();
            txtSoLuong.Clear();
            txtDonGiaNhap.Clear();
            txtThanhTien.Clear();
            txtGhiChu.Clear();
        }

        private void cbbMaHDN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}