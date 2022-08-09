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

namespace QuanLyNhaSach.UI.UIControl
{
    public partial class Control_FrmThemNhaXuatBan : DevExpress.XtraEditors.XtraForm
    {
        public Control_FrmThemNhaXuatBan()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    String insertTacGia = "insert into NhaXuatBan (MaNXB,TenNXB) values(@maNhaXB, @tenNhaXB)";
                    SqlCommand command = new SqlCommand(insertTacGia, connection);
                    command.Parameters.AddWithValue("@maNhaXB",txtMaNXB.Text);
                    command.Parameters.AddWithValue("@tenNhaXB",txtTenNhaXB.Text);
                    int rowInsert = command.ExecuteNonQuery();
                    if (rowInsert > 0)
                    {
                        MessageBox.Show("Đã thêm Nhà xuất bản Mã:" + txtMaNXB.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void InsertMaNXB(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                    }
                    if (txtMaNXB.Text.Trim().Length > 0)
                    {
                        String Query = "select * from NhaXuatBan where NhaXuatBan.MaNXB = @maNhaXB";
                        SqlCommand cmd = new SqlCommand(Query, connection);
                        cmd.Parameters.AddWithValue("@maNhaXB", txtMaNXB.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Mã nhà xuất bản vừa nhập đã tồn tại\nVui lòng nhập lại Mã nhà xuất bản Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnLuu.Enabled = false;
                        }
                        else
                            btnLuu.Enabled = true;
                    }
                    else
                        btnLuu.Enabled = false;


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