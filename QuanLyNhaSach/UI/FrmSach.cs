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
    public partial class FrmSach : DevExpress.XtraEditors.XtraForm
    {
        public FrmSach()
        {
            InitializeComponent();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.qLNhaSachDataSet.TheLoai);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.NhaXuatBan' table. You can move, or remove it, as needed.
            this.nhaXuatBanTableAdapter.Fill(this.qLNhaSachDataSet.NhaXuatBan);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.qLNhaSachDataSet.TacGia);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLNhaSachDataSet.Sach);

        }
    }
}