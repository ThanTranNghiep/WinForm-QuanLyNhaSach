using DevExpress.XtraEditors;
using Microsoft.TeamFoundation.Client;
using QuanLyNhaSach.DataConnection;
using QuanLyNhaSach.UI.UIControl;
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

namespace QuanLyNhaSach.UI
{
    public partial class FrmSach : DevExpress.XtraEditors.XtraForm
    {
        public FrmSach()
        {
            InitializeComponent();
        }
        private bool edit = false;
        private void FrmSach_Load(object sender, EventArgs e)
        {
            this.sachBindingSource.SuspendBinding();
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.qLNhaSachDataSet.TheLoai);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.NhaXuatBan' table. You can move, or remove it, as needed.
            this.nhaXuatBanTableAdapter.Fill(this.qLNhaSachDataSet.NhaXuatBan);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.qLNhaSachDataSet.TacGia);
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLNhaSachDataSet.Sach);
                    // tắt tạm tính năng binding
            btnLuuChinhSua.Hide();
            dataGridViewFind.AllowUserToAddRows = false; 
            dataGridViewFind.AllowUserToDeleteRows = false;
            dataGridViewFind.ClearSelection();
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            Control_FrmThemTacGia themTacGia = new Control_FrmThemTacGia();
            addForm(themTacGia);

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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sachTableAdapter.Update(this.qLNhaSachDataSet.Sach);
            dataGridViewFind.ClearSelection();
        }

        private void ThemSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim().CompareTo("") != 0)
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        String Query = "select * from Sach where Sach.MaSach = '" + txtMaSach.Text + "'";
                        SqlCommand cmd = new SqlCommand(Query, connection);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            NotifyIcon notifyIcon1 = new NotifyIcon();
                            notifyIcon1.Icon = SystemIcons.WinLogo;
                            //Biểu tượng xuất hiện trên thông báo
                            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

                            notifyIcon1.BalloonTipText = "Mã sách: " + txtMaSach.Text + "đã tồn tại!";
                            notifyIcon1.BalloonTipTitle = "Thông báo!";
                            notifyIcon1.Visible = true;
                            notifyIcon1.ShowBalloonTip(1000);
                        }
                        else
                        {
                            //txtTenSach.Text = cmbTacGia.SelectedValue.ToString();
                            sachTableAdapter.InsertQuerySach(txtMaSach.Text.Trim(), txtTenSach.Text.Trim(), cmbMaTL.SelectedValue.ToString().Trim(), cmbTacGia.SelectedValue.ToString().Trim(), cmbNhaXuatBan.SelectedValue.ToString().Trim(),int.Parse( nudNamXB.Value.ToString()), double.Parse(txtTrongLuong.Text), txtKichThuocBaoBi.Text,int.Parse( nudSoTrang.Value.ToString()), decimal.Parse(nudGiaBan.Value.ToString()),0, txtMoTa.Text);
                            MessageBox.Show("Đã thêm sách" + txtTenSach.Text);
                            dataGridViewFind.Refresh();
                        }

                        //


                        //



                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
                btnThemSach.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dataGridViewFind.ClearSelection();
            this.sachBindingSource.ResumeBinding();
            //this.dataGridViewFind.Enabled = true;
            btnThemSach.Enabled = false;
            dataGridViewFind.ReadOnly = false;
            btnHuyCapNhat.BringToFront();
            this.edit = true;                   // cờ hiệu
            this.dataGridViewFind.Columns[10].ReadOnly = true;
            // cho phép thêm hoặc xóa trên datagridview
            dataGridViewFind.AllowUserToAddRows = true;
            dataGridViewFind.AllowUserToDeleteRows = true;
        }

        private void btnHuyCapNhat_Click(object sender, EventArgs e)
        {
            btnCapNhat.BringToFront();
            this.sachBindingSource.SuspendBinding();
            btnThemSach.Enabled = false;
            dataGridViewFind.ReadOnly = true;
            this.edit = false;
            dataGridViewFind.AllowUserToAddRows = false;
            dataGridViewFind.AllowUserToDeleteRows = false;
            dataGridViewFind.ClearSelection();
        }

        private void FindBooks(object sender, EventArgs e)
        {
            if (rdbtnTimTheoMa.Checked)
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        String sqlQuery = @"SELECT * FROM Sach WHERE MaSach LIKE '%" + txtFind.Text + "%'";
                        this.qLNhaSachDataSet.Sach.Clear();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                        dataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                        dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;
                        dataGridViewFind.Refresh();
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            if (rdbtnTimTheoTen.Checked)
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        String sqlQuery = @"SELECT * FROM Sach WHERE Sach.TenSach LIKE N'%" + txtFind.Text + "%'";
                        this.qLNhaSachDataSet.Sach.Clear();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                        dataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                        dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;
                        dataGridViewFind.Refresh();
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            if (rdbtnTimTheoLoai.Checked)
            {
                using (SqlConnection connection = new SqlConnection(DataConnectionString.ConnectionString))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        String sqlQuery = @"SELECT MaSach, TenSach, Sach.MaTL, MaTG, MaNXB, NamXB, 
                                                    TrongLuong, KichThuocBaoBi, SoTrang, GiaBan, SoLuong, MoTa 
                                                    FROM dbo.Sach, dbo.TheLoai
                                                    where Sach.MaTL = TheLoai.MaTL
                                                    and ( Sach.MaTL like '%" + txtFind.Text + "%' " +
                                                    "or TheLoai.TenTL like N'%" + txtFind.Text + "%' )";
                        this.qLNhaSachDataSet.Sach.Clear();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                        dataAdapter.Fill(this.qLNhaSachDataSet.Sach);
                        dataGridViewFind.DataSource = this.qLNhaSachDataSet.Sach;
                        dataGridViewFind.Refresh();
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnThemNhaXuatBan_Click(object sender, EventArgs e)
        {
            Control_FrmThemNhaXuatBan themNhaXuatBan = new Control_FrmThemNhaXuatBan();
            addForm(themNhaXuatBan);
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            Control_FrmThemNhaCungCap themNhaCungCap = new Control_FrmThemNhaCungCap();
            addForm(themNhaCungCap);
        }

        private void UpdateValueSach(object sender, DataGridViewCellEventArgs e) // phát hiện thay đổi trên data gridview
        {
            if(this.edit == true)
            {
                btnLuuChinhSua.Show();
                MessageBox.Show("Ấn nút Lưu chỉnh sửa để cập nhật dữ liệu");
            }    
            
        }

        private void LuuChinhSua_Click(object sender, EventArgs e)
        {
            sachTableAdapter.Update(this.qLNhaSachDataSet.Sach);
            MessageBox.Show("Đã lưu chỉnh sửa");
            btnLuuChinhSua.Hide();
            dataGridViewFind.Refresh();
        }

        private void CheckMaSach_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim().CompareTo("") != 0 && this.edit == false)
            {
                btnThemSach.Enabled = true;
            }
            else
                btnThemSach.Enabled = false;
        }

        private void CellClick_dataGridViewFind(object sender, DataGridViewCellEventArgs e)
        {
            String MaTG = dataGridViewFind.CurrentRow.Cells[3].Value.ToString();
            String Loai = dataGridViewFind.CurrentRow.Cells[2].Value.ToString();
            String NhaXB = dataGridViewFind.CurrentRow.Cells[4].Value.ToString();
            cmbTacGia.SelectedValue = MaTG;
            cmbMaTL.SelectedValue = Loai;
            cmbNhaXuatBan.SelectedValue = NhaXB;
        }
    }
}