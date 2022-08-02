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
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }
    }
}