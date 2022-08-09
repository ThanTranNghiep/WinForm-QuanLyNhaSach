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
    public partial class Control_FrmThemNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public Control_FrmThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertMaNCC(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                    }
                    if (txtMaNhaCC.Text.Trim().Length > 0)
                    {
                        String Query = "select * from NhaCungCap where NhaCungCap.MaNCC = @maNhaCC";
                        SqlCommand cmd = new SqlCommand(Query, connection);
                        cmd.Parameters.AddWithValue("@maNhaCC", txtMaNhaCC.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Mã nhà cung cấp vừa nhập đã tồn tại\nVui lòng nhập lại Mã nhà cung cấp Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    String insertTacGia = "insert into NhaCungCap (MaNCC,TenNCC,DiaChi,SDT) values( @maNhaCC,@tenNCC,@diaChi,@soDT)";
                    SqlCommand command = new SqlCommand(insertTacGia, connection);
                    command.Parameters.AddWithValue("@maNhaCC",txtMaNhaCC.Text);
                    command.Parameters.AddWithValue("@tenNCC",txtTenNhaCC.Text);
                    command.Parameters.AddWithValue("@diaChi",txtDiaChi.Text);
                    command.Parameters.AddWithValue("@soDT",txtSDT.Text);
                    int rowInsert = command.ExecuteNonQuery();
                    if (rowInsert > 0)
                    {
                        MessageBox.Show("Đã thêm Nhà cung cấp Mã:" + txtMaNhaCC.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}