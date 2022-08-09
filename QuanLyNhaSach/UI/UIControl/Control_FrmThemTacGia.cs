using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhaSach.DataConnection;

namespace QuanLyNhaSach.UI.UIControl
{
    public partial class Control_FrmThemTacGia : DevExpress.XtraEditors.XtraForm
    {
        public Control_FrmThemTacGia()
        {
            InitializeComponent();
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
                    String insertTacGia = "insert into TacGia (MaTG,TenTG) values('" + txtMaTG.Text + "',N'" + txtTenTG.Text + "')";
                    SqlCommand command = new SqlCommand(insertTacGia, connection);
                    int rowInsert = command.ExecuteNonQuery();
                    if (rowInsert > 0)
                    {
                        MessageBox.Show("Đã thêm tác giả Mã:" + txtMaTG.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void InsertMaTG(object sender, EventArgs e)     // kiểm tra mã tác giả vừa nhập có tồn tại chưa
        {
            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                    }
                    if (txtMaTG.Text.Trim().Length > 0)
                    {
                        String Query = "select * from TacGia where TacGia.MaTG = '" + txtMaTG.Text + "'";
                        SqlCommand cmd = new SqlCommand(Query, connection);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Mã Tác Giả vừa nhập đã tồn tại\nVui lòng nhập lại Mã Tác Giả Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnLuu.Enabled = false;
                        }
                        else
                            btnLuu.Enabled = true;
                    }
                    else
                        btnLuu.Enabled=false;
                        
                        
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}