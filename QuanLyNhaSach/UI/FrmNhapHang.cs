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
    public partial class FrmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhapHang()
        {
            InitializeComponent();
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.qLNhaSachDataSet.NhaCungCap);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.CTHoaDonNhap' table. You can move, or remove it, as needed.
            this.cTHoaDonNhapTableAdapter.Fill(this.qLNhaSachDataSet.CTHoaDonNhap);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.HoaDonNhap' table. You can move, or remove it, as needed.
            this.hoaDonNhapTableAdapter.Fill(this.qLNhaSachDataSet.HoaDonNhap);

        }

        //private void btnThemSach_Click(object sender, EventArgs e)
        //{

        //    ListViewItem lv = new ListViewItem(txtMaSach.Text);
        //    lv.SubItems.Add(txtTenSach.Text);
        //    lv.SubItems.Add(cmbChonLoaiSach.SelectedItem.ToString());
        //    lv.SubItems.Add(cmbTacGia.SelectedItem.ToString());
        //    lv.SubItems.Add(cmbNhaXuatBan.SelectedItem.ToString());
        //    lv.SubItems.Add(nudNamXB.Value.ToString());
        //    lv.SubItems.Add(txtTrongLuong.Text);
        //    lv.SubItems.Add(txtKichThuocBaoBi.Text);
        //    lv.SubItems.Add(nudSoTrang.Value.ToString());
        //    lv.SubItems.Add(txtGiaBan.Text);
        //    lv.SubItems.Add(nudSoLuong.Value.ToString());
        //    lv.SubItems.Add(txtMoTa.Text);
        //    lvHoaDonNhapSach.Items.Add(lv);
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    if(lvHoaDonNhapSach.SelectedItems.Count > 0)
        //    {
        //        lvHoaDonNhapSach.Items.Remove(lvHoaDonNhapSach.SelectedItems[0]);
        //    }  
        //}

        //private void btnXoaTatCa_Click(object sender, EventArgs e)
        //{
        //    lvHoaDonNhapSach.Items.Clear();
        //}

        //private void btnSuaSach_Click(object sender, EventArgs e)
        //{
        //    if (lvHoaDonNhapSach.SelectedItems.Count > 0)
        //    {
        //        ListViewItem lvi = lvHoaDonNhapSach.SelectedItems[0];
        //        lvi.SubItems[0].Text = txtMaSach.Text;
        //        lvi.SubItems[1].Text = txtTenSach.Text;
        //        lvi.SubItems[2].Text = cmbChonLoaiSach.SelectedItem.ToString();
        //        lvi.SubItems[3].Text = cmbTacGia.SelectedItem.ToString();
        //        lvi.SubItems[4].Text = cmbNhaXuatBan.SelectedItem.ToString();
        //        lvi.SubItems[5].Text = nudNamXB.Value.ToString();
        //        lvi.SubItems[6].Text = txtTrongLuong.Text;
        //        lvi.SubItems[7].Text = txtKichThuocBaoBi.Text;
        //        lvi.SubItems[8].Text = nudSoTrang.Value.ToString();
        //        lvi.SubItems[9].Text = txtGiaBan.Text;
        //        lvi.SubItems[10].Text = nudSoLuong.Value.ToString();
        //        lvi.SubItems[11].Text = txtMoTa.Text;
        //    }
        //    else
        //        MessageBox.Show("Vui lòng chọn 1 hàng trong danh sách sản phẩm cần chỉnh sửa", "Thông Báo", MessageBoxButtons.OK);
        //}

        //private void lvHoaDonNhapSach_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(lvHoaDonNhapSach.SelectedItems.Count > 0)
        //    {
        //        ListViewItem lvi = lvHoaDonNhapSach.SelectedItems[0];
        //        txtMaSach.Text = lvi.SubItems[0].Text;
        //        txtTenSach.Text = lvi.SubItems[1].Text;
        //        cmbChonLoaiSach.Text = lvi.SubItems[2].Text;
        //        cmbTacGia.Text = lvi.SubItems[3].Text;
        //        cmbNhaXuatBan.Text = lvi.SubItems[4].Text;
        //        nudNamXB.Value = int.Parse( lvi.SubItems[5].Text);
        //        txtTrongLuong.Text = lvi.SubItems[6].Text;
        //        txtKichThuocBaoBi.Text = lvi.SubItems[7].Text;
        //        nudSoTrang.Value = int.Parse(lvi.SubItems[8].Text);
        //        txtGiaBan.Text = lvi.SubItems[9].Text;
        //        nudSoLuong.Value = int.Parse(lvi.SubItems[10].Text);
        //        txtMoTa.Text = lvi.SubItems[11].Text;
        //    }    
        //}

        //private void btnFind_Click(object sender, EventArgs e)
        //{

        //}

        //private void pnlBottom_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}