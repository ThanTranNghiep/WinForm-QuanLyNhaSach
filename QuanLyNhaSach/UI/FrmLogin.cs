using QuanLyNhaSach.DataConnection;
using QuanLyNhaSach.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static String MaNV = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                pictureBoxHide.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            if(txtPass.PasswordChar != '*')
            {
                pictureBoxShow.BringToFront();
                txtPass.PasswordChar = '*';
            }    
                
        }

        private void buttonSigin_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
            {
                try
                {
                    
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                    }
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select * from Account where @id = Account.TenDangNhap and @password = Account.MatKhau ";
                    command.Parameters.AddWithValue("@id", txtUser.Text);
                    command.Parameters.AddWithValue("@password", txtPass.Text);
                    IDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Lay MaNV
                        MaNV = reader["MaNV"].ToString();

                        // Mở Form Main
                        txtUser.Text = "";
                        txtPass.Text = "";
                        MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng\n\tVui lòng nhập lại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    



        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
