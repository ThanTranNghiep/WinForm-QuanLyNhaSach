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
    public partial class FrmQuanLyNhaSach : DevExpress.XtraEditors.XtraForm
    {
        public FrmQuanLyNhaSach()
        {
            InitializeComponent();
        }

        private void thoatExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanHang banHang = new FrmBanHang();
            addForm(banHang);
        }
        private void addForm(Form f)
        {
            pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void nhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhapHang nhapHang = new FrmNhapHang();
            addForm(nhapHang);
        }

        private void dangXuatSignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            FrmLogin.login = false;
        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSach sach = new FrmSach();
            addForm(sach);
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien nhanVien = new FrmNhanVien();
            addForm(nhanVien);
        }

        private void thongTinTàiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            addForm(nv);
        }

        private void FrmQuanLyNhaSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.qLNhaSachDataSet.Account);
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            if(FrmLogin.login == true)
                  this.Show();
            FrmHome home = new FrmHome();
            addForm(home);

            bool? checkAdmin = accountTableAdapter.ScalarQueryCheckAdmin(FrmLogin.MaNV);
            if (checkAdmin == false)
            {
                nhanVienToolStripMenuItem.Visible = false;
                nhapHangToolStripMenuItem.Visible = false;
                sachToolStripMenuItem.Visible = false;
                //nhapHangToolStripMenuItem.HideDropDown();
                //nhanVienToolStripMenuItem.HideDropDown();
                //sachToolStripMenuItem.HideDropDown();
               
            }
        }

        private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            addForm(home);
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frm = new FrmDoiMatKhau();
            frm.ShowDialog();
        }
    }
}