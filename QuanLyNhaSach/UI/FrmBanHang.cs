using QuanLyNhaSach.DataConnection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhaSach.UI
{
    public partial class FrmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmBanHang()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                    }
                    String sqlQuery = @"select * from Sach where Sach.MaSach like 'SachG%'";
                    this.qLNhaSachDataSet.Sach.Clear();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                    sqlDataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                    dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;
                    dataGridViewFind.Refresh();
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLNhaSachDataSet.Sach);
            // random Ma Hoa Don Ban Hang 
            Random random = new Random();
            String MaHDB = "HDB" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + random.Next(100, 999).ToString();
            txtMaHDB.Text = MaHDB;
            txtMaNV.Text = FrmLogin.MaNV;
            dateTimeONgayBan.DateTimeOffset = DateTime.Now;
            int sum = 0;
            for (int i = 0; i < lvHoaDonBanSach.Items.Count; i++)
            {
                ListViewItem lv = lvHoaDonBanSach.Items[i];
                sum += int.Parse(lv.SubItems[5].Text);
            }
            txtTongTien.Text = sum + " VNĐ";
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim() != "")
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        if (checkMaSachListView() == true)
                        {
                            String sql = "select * from Sach where Sach.MaSach = '" + txtMaSach.Text.Trim() + "'";
                            this.qLNhaSachDataSet.Sach.Clear();
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
                            sqlDataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                            dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;

                            ListViewItem lv = new ListViewItem(txtMaSach.Text);
                            lv.SubItems.Add(qLNhaSachDataSet.Sach.Rows[0][1].ToString());
                            lv.SubItems.Add(qLNhaSachDataSet.Sach.Rows[0][2].ToString());
                            lv.SubItems.Add(qLNhaSachDataSet.Sach.Rows[0][9].ToString().Replace(".0000", string.Empty));
                            lv.SubItems.Add(numericUpDownSoLuong.Value.ToString());
                            var thanhTien = int.Parse(numericUpDownSoLuong.Value.ToString()) * int.Parse(qLNhaSachDataSet.Sach.Rows[0][9].ToString().Replace(".0000", string.Empty));
                            lv.SubItems.Add(thanhTien.ToString());
                            lvHoaDonBanSach.Items.Add(lv);
                            dataGridViewFind.Refresh();
                        }    
                        else
                            MessageBox.Show("\tSách này đã được thêm vào danh sách\nVui lòng chọn sách khác hoặc thay đổi số lượng sách đã thêm","Thông báo",MessageBoxButtons.OK);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
                MessageBox.Show("Mã Sách Đang Rỗng");
            TongTien();
        }

        private bool checkMaSachListView() // Kiểm tra trong list view đã tồn tại loại sách đang thêm chưa
        {
            for (int i = 0; i < lvHoaDonBanSach.Items.Count; i++)
            {
                ListViewItem lv = lvHoaDonBanSach.Items[i];
                if(txtMaSach.Text.Trim().CompareTo(lv.SubItems[0].Text.Trim()) == 0)
                    return false;
            }
            return true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                    }
                    String sqlQuery = @"select * from Sach";
                    //if (txtFind.Text != null)
                    //    sqlQuery = @"select * from Sach ";

                    this.qLNhaSachDataSet.Sach.Clear();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                    sqlDataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                    dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;
                    dataGridViewFind.Refresh();
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvHoaDonBanSach.SelectedItems.Count > 0)
            {
                lvHoaDonBanSach.Items.Remove(lvHoaDonBanSach.SelectedItems[0]);
            }
            else
                MessageBox.Show("Vui lòng chọn 1 hàng trong danh sách sản phẩm cần xóa", "Thông Báo", MessageBoxButtons.OK);
            TongTien();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvHoaDonBanSach.SelectedItems.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        String sql = "select * from Sach where Sach.MaSach = '" + txtMaSach.Text.Trim() + "'";
                        this.qLNhaSachDataSet.Sach.Clear();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
                        sqlDataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                        dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;

                        ListViewItem lvi = lvHoaDonBanSach.SelectedItems[0];
                        lvi.SubItems[0].Text = txtMaSach.Text;
                        lvi.SubItems[1].Text = qLNhaSachDataSet.Sach.Rows[0][1].ToString();
                        lvi.SubItems[2].Text = qLNhaSachDataSet.Sach.Rows[0][2].ToString();
                        lvi.SubItems[3].Text = qLNhaSachDataSet.Sach.Rows[0][9].ToString().Replace(".0000", string.Empty);
                        lvi.SubItems[4].Text = numericUpDownSoLuong.Value.ToString();
                        var thanhTien = int.Parse(numericUpDownSoLuong.Value.ToString()) * int.Parse(qLNhaSachDataSet.Sach.Rows[0][9].ToString().Replace(".0000", string.Empty));
                        lvi.SubItems[5].Text = thanhTien.ToString();


                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                TongTien();
            }
            else
                MessageBox.Show("Vui lòng chọn 1 hàng trong danh sách sản phẩm cần chỉnh sửa", "Thông Báo", MessageBoxButtons.OK);

        }

        private void lvHoaDonBanSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDonBanSach.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvHoaDonBanSach.SelectedItems[0];
                txtMaSach.Text = lvi.SubItems[0].Text;
                numericUpDownSoLuong.Value = int.Parse(lvi.SubItems[4].Text);
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lvHoaDonBanSach.Items.Clear();
            TongTien();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(lvHoaDonBanSach.Items.Count > 0)
            {
                SaveHoaDon();
                saveCTHoaDonBan();
            }
            else
                MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn bán", "Thông Báo", MessageBoxButtons.OK);

        }
        private void SaveHoaDon()
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    String NgayBan = dateTimeONgayBan.DateTimeOffset.Year.ToString() + "-" + dateTimeONgayBan.DateTimeOffset.Month.ToString() + "-" + dateTimeONgayBan.DateTimeOffset.Day.ToString();
                    String insertQuerySql = "insert into HoaDonBan (MaHDB,MaNV,NgayBan) values('" +
                                                txtMaHDB.Text.Trim() + "','" + txtMaNV.Text + "','" + NgayBan + "')";
                    SqlCommand cmd = new SqlCommand(insertQuerySql, connection);
                    int rowInsert = cmd.ExecuteNonQuery();
                    if (rowInsert > 0)
                    {
                        MessageBox.Show("Đã thêm hóa đơn bán Mã:" + txtMaHDB.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void saveCTHoaDonBan()
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    for (int i = 0; i < lvHoaDonBanSach.Items.Count; i++)
                    {
                        ListViewItem lv = lvHoaDonBanSach.Items[i];
                        String MaSach = lv.SubItems[0].Text.Trim();
                        String SoLuong = lv.SubItems[4].Text;
                        String insertQuerySql = "insert into CTHoaDonBan (MaHDB,MaSach,SoLuong) values('" + txtMaHDB.Text + "','" + MaSach + "'," + SoLuong + ")";
                        SqlCommand cmd = new SqlCommand(insertQuerySql, connection);
                        updateSoLuongSach(MaSach, int.Parse(SoLuong));
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void updateSoLuongSach(String maSach, int SoLuong)
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    String NgayBan = dateTimeONgayBan.DateTimeOffset.Year.ToString() + "-" + dateTimeONgayBan.DateTimeOffset.Month.ToString() + "-" + dateTimeONgayBan.DateTimeOffset.Day.ToString();
                    String insertQuerySql = "update Sach set Sach.SoLuong = Sach.SoLuong - " + SoLuong + " where Sach.MaSach = '" + maSach + "'";
                    SqlCommand cmd = new SqlCommand(insertQuerySql, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void SetSoLuongSach(object sender, EventArgs e) //  Trả về số lượng sách còn lại 
        {                                                       //  không cho bán nhìu  hơn số lượng tồn
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    String insertQuerySql = "select dbo.SoLuongCuaSach ('" + txtMaSach.Text.Trim() + "')";
                    SqlCommand cmd = new SqlCommand(insertQuerySql, connection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    numericUpDownSoLuong.Maximum = int.Parse(dt.Rows[0][0].ToString());
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TongTien()
        {
            int sum = 0;
            for (int i = 0; i < lvHoaDonBanSach.Items.Count; i++)
            {
                ListViewItem lv = lvHoaDonBanSach.Items[i];
                sum += int.Parse(lv.SubItems[5].Text);
            }
            txtTongTien.Text = sum + " VNĐ";
        }

        private void FindBooks(object sender, EventArgs e)
        {
            if (rdbtnTimTheoMa.Checked)
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                    
                        String sqlQuery = @"SELECT * FROM Sach WHERE MaSach LIKE '%" + txtFind.Text + "%'";
                        this.qLNhaSachDataSet.Sach.Clear();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                        dataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                        dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;
                        dataGridViewFind.Refresh();
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            if (rdbtnTimTheoTen.Checked)
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        String sqlQuery = @"SELECT * FROM Sach WHERE Sach.TenSach LIKE N'%" + txtFind.Text + "%'";
                        this.qLNhaSachDataSet.Sach.Clear();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                        dataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                        dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;
                        dataGridViewFind.Refresh();
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            if (rdbtnTimTheoLoai.Checked)
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        String sqlQuery = @"SELECT MaSach, TenSach, Sach.MaTL, MaTG, MaNXB, NamXB, 
                                                    TrongLuong, KichThuocBaoBi, SoTrang, GiaBan, SoLuong, MoTa 
                                                    FROM dbo.Sach, dbo.TheLoai
                                                    where Sach.MaTL = TheLoai.MaTL
                                                    and ( Sach.MaTL like '%" + txtFind.Text + "%' " +
                                                    "or TheLoai.TenTL like N'%" + txtFind.Text + "%' )";
                        this.qLNhaSachDataSet.Sach.Clear();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                        dataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                        dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;
                        dataGridViewFind.Refresh();
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}

