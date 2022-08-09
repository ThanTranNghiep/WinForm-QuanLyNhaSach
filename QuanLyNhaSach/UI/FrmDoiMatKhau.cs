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

namespace QuanLyNhaSach.UI
{
    public partial class FrmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.qLNhaSachDataSet.Account);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNhaSachDataSet.NhanVien);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtTenNV.EditValue = nhanVienTableAdapter.ScalarQueryNhanVienByHoTen(FrmLogin.MaNV);
            txtMaNV.Text = FrmLogin.MaNV;
            txtTenDangNhap.Text = accountTableAdapter.ScalarQueryAcountByTenDangNhap(FrmLogin.MaNV).ToString();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            if(txtPass.UseSystemPasswordChar == false)
            {
                pictureBoxShow.BringToFront();
                txtPass.UseSystemPasswordChar = true;
            }    
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                pictureBoxHide.BringToFront();
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void TextChanged_MatKhauMoi(object sender, EventArgs e)
        {
            lblError.Text = "    ";
            String matKhau = accountTableAdapter.ScalarQueryAccountByMatKhau(FrmLogin.MaNV);
            if (txtPass.Text.Trim().CompareTo("") != 0 && txtPassMoi.Text.Trim().CompareTo("") != 0 && txtXacNhanPass.Text.Trim().CompareTo("") != 0)
            {
                if (matKhau.CompareTo(txtPass.Text) == 0) // khớp mật khẩu
                    btnLuu.Enabled = true;
                else  
                    btnLuu.Enabled = false;
            }
            else
                btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtPassMoi.Text.Trim().CompareTo(txtXacNhanPass.Text.Trim()) == 0)
            {
                accountTableAdapter.UpdateQueryAccountByMatKhau(txtPassMoi.Text.Trim(), FrmLogin.MaNV);
                MessageBox.Show("Đã cập nhật mật khẩu");
                btnCancel_Click(sender,e);
            }    
            else
                lblError.Text = "Mật khẩu mới và Mật Khẩu xác nhận không khớp";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}