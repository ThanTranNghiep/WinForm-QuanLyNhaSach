using DevExpress.XtraEditors;
using QuanLyNhaSach.DataConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.UI
{
    public partial class FrmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhapHang()
        {
            InitializeComponent();
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLNhaSachDataSet.Sach);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.CTHoaDonNhap' table. You can move, or remove it, as needed.
            this.cTHoaDonNhapTableAdapter.Fill(this.qLNhaSachDataSet.CTHoaDonNhap);
            this.nhaCungCapTableAdapter.Fill(this.qLNhaSachDataSet.NhaCungCap);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.HoaDonNhap' table. You can move, or remove it, as needed.
            this.hoaDonNhapTableAdapter.Fill(this.qLNhaSachDataSet.HoaDonNhap);
            Load_MaHDN();
            //dateTimeOffsetEditTuNgay.DateTimeOffset = DateTimeOffset.Now;
            dateTimeONgayNhap.DateTimeOffset = DateTimeOffset.Now;
        }

        private void Load_MaHDN()
        {
            Random random = new Random();
            String MaHDN = "HDN" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + random.Next(100, 999).ToString();
            txtMaHDN.Text = MaHDN;
        }

        private void dataGridViewHoaDonNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridViewHoaDonNhapHang.Rows
        }
        private void CheckMaSach(object sender, EventArgs e)
        {
            if(txtMaSach.Text.CompareTo("") != 0)
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        String QuerySql = "select * from Sach where Sach.MaSach = @maSach";
                        SqlCommand cmd = new SqlCommand(QuerySql, connection);
                        cmd.Parameters.AddWithValue("@maSach", txtMaSach.Text.Trim());
                        SqlDataReader reader = cmd.ExecuteReader();
                        //rowInsert = cmd.ExecuteNonQuery();
                        if (!reader.Read())
                        {
                            MessageBox.Show("Mã sách bạn vừa nhập không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }    
        }

        private bool checkMaSachListView() // Kiểm tra trong list view đã tồn tại loại sách đang thêm chưa
        {
            for (int i = 0; i < lvHoaDonNhapSach.Items.Count; i++)
            {
                ListViewItem lv = lvHoaDonNhapSach.Items[i];
                if (txtMaSach.Text.Trim().CompareTo(lv.SubItems[0].Text.Trim()) == 0)
                    return false;
            }
            return true;
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
                            lv.SubItems.Add(nudDonGia.Value.ToString());
                            lv.SubItems.Add(numericUpDownSoLuong.Value.ToString());
                            var thanhTien = int.Parse(numericUpDownSoLuong.Value.ToString()) * int.Parse( nudDonGia.Value.ToString());
                            lv.SubItems.Add(thanhTien.ToString());
                            lvHoaDonNhapSach.Items.Add(lv);
                            dataGridViewFind.Refresh();
                        }
                        else
                            MessageBox.Show("\tSách này đã được thêm vào danh sách\nVui lòng chọn sách khác hoặc thay đổi số lượng sách đã thêm", "Thông báo", MessageBoxButtons.OK);
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

        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvHoaDonNhapSach.SelectedItems.Count > 0)
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

                        ListViewItem lvi = lvHoaDonNhapSach.SelectedItems[0];
                        lvi.SubItems[0].Text = txtMaSach.Text;
                        lvi.SubItems[1].Text = qLNhaSachDataSet.Sach.Rows[0][1].ToString();
                        lvi.SubItems[2].Text = qLNhaSachDataSet.Sach.Rows[0][2].ToString();
                        lvi.SubItems[3].Text = nudDonGia.Value.ToString();
                        lvi.SubItems[4].Text = numericUpDownSoLuong.Value.ToString();
                        var thanhTien = int.Parse(numericUpDownSoLuong.Value.ToString()) * int.Parse(nudDonGia.Value.ToString());
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

        //Chức năng save hóa đơn nhập

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
                    String NgayNhap = dateTimeONgayNhap.DateTimeOffset.Year.ToString() + "-" + dateTimeONgayNhap.DateTimeOffset.Month.ToString() + "-" + dateTimeONgayNhap.DateTimeOffset.Day.ToString();
                    String insertQuerySql = "insert into HoaDonNhap(MaHDN,MaNCC,NgayNhap) values (@maHDN,@maNCC,@ngayNhap)";
                    SqlCommand cmd = new SqlCommand(insertQuerySql, connection);
                    cmd.Parameters.AddWithValue("@maHDN", txtMaHDN.Text);
                    cmd.Parameters.AddWithValue("@maNCC", cmbMaNCC.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ngayNhap", NgayNhap);
                    int rowInsert = cmd.ExecuteNonQuery();
                    if (rowInsert > 0)
                    {
                        MessageBox.Show("Đã thêm hóa đơn nhập Mã:" + txtMaHDN.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("lỗi chỗ save");
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void saveCTHoaDonNhap()
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    for (int i = 0; i < lvHoaDonNhapSach.Items.Count; i++)
                    {
                        ListViewItem lv = lvHoaDonNhapSach.Items[i];
                        String MaSach = lv.SubItems[0].Text.Trim();
                        int SoLuong = int.Parse(lv.SubItems[4].Text);
                        decimal DonGia = decimal.Parse(lv.SubItems[3].Text);
                        //String insertQuerySql = "insert into CTHoaDonNhap (MaSach,MaHDN,SoLuong,DonGia) values(@maSach,@maHDN,@soLuong,@donGia)";
                        //SqlCommand cmd = new SqlCommand(insertQuerySql, connection);
                        //cmd.Parameters.AddWithValue("@maHDN",txtMaHDN.Text);
                        //cmd.Parameters.AddWithValue("@maSach", MaSach);
                        //cmd.Parameters.AddWithValue("@soLuong", SoLuong);
                        //cmd.Parameters.AddWithValue("@donGia", DonGia);
                        //cmd.ExecuteNonQuery();
                        cTHoaDonNhapTableAdapter.InsertQueryCTHDN(MaSach,txtMaHDN.Text.Trim(),SoLuong,DonGia);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("lỗi chỗ save CT");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lvHoaDonNhapSach.Items.Count > 0)
            {
                SaveHoaDon();
                saveCTHoaDonNhap();
                Load_MaHDN();
                btnXoaTatCa_Click(sender, e);
            }
            else
                MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn bán", "Thông Báo", MessageBoxButtons.OK);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvHoaDonNhapSach.SelectedItems.Count > 0)
            {
                lvHoaDonNhapSach.Items.Remove(lvHoaDonNhapSach.SelectedItems[0]);
            }
            else
                MessageBox.Show("Vui lòng chọn 1 hàng trong danh sách sản phẩm cần xóa", "Thông Báo", MessageBoxButtons.OK);
            TongTien();
        }
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lvHoaDonNhapSach.Items.Clear();
            TongTien();
        }

        private void lvHoaDonNhapSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDonNhapSach.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvHoaDonNhapSach.SelectedItems[0];
                txtMaSach.Text = lvi.SubItems[0].Text;
                nudDonGia.Text = lvi.SubItems[3].Text;
                numericUpDownSoLuong.Value = int.Parse(lvi.SubItems[4].Text);
            }
        }
        // tính tổng tiền hóa đơn
        private void SelectionChanged_RowHoaDonNhap(object sender, EventArgs e)
        {

            int pos = dataGridViewHoaDonNhapHang.CurrentCell.RowIndex;
            String MaHDN = dataGridViewHoaDonNhapHang.Rows[pos].Cells[0].Value.ToString();
            cTHoaDonNhapTableAdapter.FillByMaHoaDon(this.qLNhaSachDataSet.CTHoaDonNhap, MaHDN);
            cTHoaDonNhapTableAdapter.ScalarQueryTongTienHoaDonNhap(MaHDN);
            Nullable<decimal> @decimal = cTHoaDonNhapTableAdapter.ScalarQueryTongTienHoaDonNhap(MaHDN);
            txtTongTienHoaDonNhap.Text = @decimal.ToString().Replace(".0000", "");

        }
        private void TongTien()
        {
            int sum = 0;
            for (int i = 0; i < lvHoaDonNhapSach.Items.Count; i++)
            {
                ListViewItem lv = lvHoaDonNhapSach.Items[i];
                sum += int.Parse(lv.SubItems[5].Text);
            }
            txtTongTien.Text = sum + " VNĐ";
        }

        // chức năng tìm kiếm
        private void TextChanged_Find(object sender, EventArgs e)
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

     

        private void editDate(object sender, EventArgs e)
        {
            var date = dateEditTuNgay.DateTime.ToString().Substring(0,10).Trim();
            //MessageBox.Show(date);
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    String sqlQuery = @"SELECT * FROM HoaDonNhap WHERE  (HoaDonNhap.NgayNhap >= '" +date+"')";
                    this.qLNhaSachDataSet.HoaDonNhap.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery,connection);
                    adapter.Fill(this.qLNhaSachDataSet.HoaDonNhap);
                    dataGridViewHoaDonNhapHang.DataSource = this.qLNhaSachDataSet.HoaDonNhap;
                    dataGridViewHoaDonNhapHang.Refresh();
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