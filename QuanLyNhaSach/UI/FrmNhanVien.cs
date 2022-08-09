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
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private bool edit = false;
        private bool add = false;
        private bool editTK = false;
        private bool addTK = false;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.HoaDonBan' table. You can move, or remove it, as needed.
            this.hoaDonBanTableAdapter.Fill(this.qLNhaSachDataSet.HoaDonBan);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.qLNhaSachDataSet.Account);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNhaSachDataSet.NhanVien);
            ChucNang(false);
        }

        private void ChucNang(bool chucNang)
        {
            txtTenNV.Enabled = chucNang;
            txtCCCD.Enabled = chucNang;
            txtSDT.Enabled = chucNang;
            txtEmail.Enabled = chucNang;
        }

        private void setTextNull()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int temp = random.Next(1000, 9999);
            txtMaNV.Text = "NV" + temp.ToString();
            this.add = true;
            ChucNang(true);
            btnThemNV.Enabled = false;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = false;
            btnThemNV.BackColor = Color.White;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dataGridViewDanhSachNV.ClearSelection();
            if(this.add == true)
            {
                this.add = false;
                ChucNang(false);
                setTextNull();
                btnHuy.Enabled = false;
                btnThemNV.Enabled = true;
                btnCapNhat.Enabled = true;
                btnLuu.Enabled = false;
                btnThemNV.BackColor = Color.DarkGray;
                
            }  
            if(this.edit == true)
            {
                this.edit = false;
                ChucNang(true);
                setTextNull();
                btnHuy.Enabled = false;
                btnThemNV.Enabled = true;
                btnCapNhat.Enabled = true;
                btnLuu.Enabled = false;
                btnCapNhat.BackColor = Color.DarkGray;
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.add == true)
            {
                nhanVienTableAdapter.InsertQueryNhanVienByMaNV(txtMaNV.Text.Trim().ToString(), txtCCCD.Text, txtTenNV.Text, txtSDT.Text, txtEmail.Text);
                MessageBox.Show("Đã thêm nhân viên " + txtTenNV.Text);
                setTextNull();
                load_Data();
            }
            if(this.edit == true)
            {
                nhanVienTableAdapter.UpdateQueryNhanVien(txtMaNV.Text.Trim().ToString(), txtCCCD.Text, txtTenNV.Text, txtSDT.Text, txtEmail.Text);
                MessageBox.Show("Đã cập nhật nhân viên " + txtTenNV.Text);
                setTextNull();
                load_Data();
            }
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThemNV.Enabled = true;
            btnCapNhat.Enabled = true;
            dataGridViewDanhSachNV.ClearSelection();
            btnHuy_Click(sender, e);
        }

        private void TextChanged_TenNV(object sender, EventArgs e)
        {
            if (txtTenNV.Text.Trim().CompareTo("") != 0 && txtCCCD.Text.Trim().CompareTo("") != 0)
                btnLuu.Enabled = true;
            else
                btnLuu.Enabled = false;
        }

        private void TextChanged_CheckSDT(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length <= 11)
            {
                lblError.Text = "     ";
            }
            else
            {
                lblError.Text = "Số điện thoại phải nhỏ hơn 12 số";
            }
        }
        private void load_Data()
        {
            nhanVienTableAdapter.Fill(this.qLNhaSachDataSet.NhanVien);
            accountTableAdapter.Fill(this.qLNhaSachDataSet.Account);
        }

        private void CellClick_DataGridViewNhanVien(object sender, DataGridViewCellEventArgs e)
        {
            String MaNV = dataGridViewDanhSachNV.CurrentRow.Cells[0].Value.ToString();
            accountTableAdapter.FillByMaNV(this.qLNhaSachDataSet.Account,MaNV);
            hoaDonBanTableAdapter.FillByMaNV(this.qLNhaSachDataSet.HoaDonBan,MaNV);
            if(this.edit == true)
            {
                txtMaNV.Text = dataGridViewDanhSachNV.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dataGridViewDanhSachNV.CurrentRow.Cells[2].Value.ToString();
                txtCCCD.Text = dataGridViewDanhSachNV.CurrentRow.Cells[1].Value.ToString();
                txtSDT.Text = dataGridViewDanhSachNV.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dataGridViewDanhSachNV.CurrentRow.Cells[4].Value.ToString();
            }    
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            this.edit = true;
            ChucNang(true);
            btnCapNhat.Enabled = false;
            btnHuy.Enabled = true;
            btnThemNV.Enabled = false;
            btnCapNhat.BackColor = Color.White;
        }

        private void TextChanged_TenDangNhap_MatKhau(object sender, EventArgs e)
        {
            if(btnThemTaiKhoan.Enabled == false)
            {
                if (txtTenDangNhap.Text.Trim().CompareTo("") != 0 && txtMatKhau.Text.Trim().CompareTo("") != 0)
                {
                    if (txtMatKhau.Text.Length < 8)
                    {
                        lblErrorMatKhau.Text = "Mật khẩu phải ít nhất 8 kí tự";
                    }
                    else
                    {
                        btnLuu.Enabled = true;
                        lblErrorMatKhau.Text = "     ";
                    }
                }
                else
                    btnLuu.Enabled = false;
            }    
            
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            this.addTK = true;
            btnHuyChinhSua.Enabled = true;
            btnSuaTaiKhoan.Enabled = false;
            btnThemTaiKhoan.Enabled = false;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            btnThemTaiKhoan.BackColor = Color.White;
        }

        private void btnHuyChinhSua_Click(object sender, EventArgs e)
        {
            if(this.addTK == true)
            {
                this.addTK = false;
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                btnThemTaiKhoan.Enabled = true;
                btnSuaTaiKhoan.Enabled = true;
                txtTenDangNhap.Enabled = false;
                txtMatKhau.Enabled = false;
                btnHuyChinhSua.Enabled = false;
                btnThemTaiKhoan.BackColor = Color.DarkGray;
                lblErrorMatKhau.Text = "    ";
            }
            if(this.editTK == true)
            {
                this.editTK = false;
                btnHuyChinhSua.Enabled = false;
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                btnThemTaiKhoan.Enabled = true;
                btnSuaTaiKhoan.Enabled = true;
                btnXoaTaiKhoan.Enabled = false;
                btnSuaTaiKhoan.BackColor = Color.DarkGray;
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            editTK = true;
            btnSuaTaiKhoan.Enabled = false;
            btnThemTaiKhoan.Enabled = false;
            btnXoaTaiKhoan.Enabled = true;
            btnHuyChinhSua.Enabled = true;
            btnSuaTaiKhoan.BackColor = Color.White;
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa tài khoản của nhân viên " + cmbMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String MaNV = accountTableAdapter.ScalarQueryMaNV(cmbMaNV.SelectedValue.ToString());
                bool? checkAdmin = accountTableAdapter.ScalarQueryCheckAdmin(cmbMaNV.SelectedValue.ToString());
                if (checkAdmin == true)
                {
                    MessageBox.Show("Không thể xóa admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (MaNV == null)
                    {
                        MessageBox.Show("Nhân Viên không có tài khoản để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        accountTableAdapter.DeleteQueryAccountNhanVienByMaNV(MaNV);
                        MessageBox.Show("Đã xóa tài khoản của nhân viên " + cmbMaNV.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        accountTableAdapter.Fill(this.qLNhaSachDataSet.Account);
                    }
                }
            }    
            
            btnHuyChinhSua_Click(sender, e);
        }

        private void btnLuuTaiKhoan_Click(object sender, EventArgs e)
        {
            String MaNV = accountTableAdapter.ScalarQueryMaNV(cmbMaNV.SelectedValue.ToString());
            if (MaNV.Length > 0)
            {
                MessageBox.Show("Nhân viên đã có tài khoản\n   Không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                accountTableAdapter.InsertQueryAccount(txtTenDangNhap.Text, txtMatKhau.Text, cmbMaNV.SelectedValue.ToString(), false);
                MessageBox.Show("Đã thêm tài khoản cho nhân viên "+ cmbMaNV.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }    
                
        }
    }
}