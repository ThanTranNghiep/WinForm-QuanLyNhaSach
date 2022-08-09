namespace QuanLyNhaSach.UI
{
    partial class FrmNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cTHoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaSachDataSet = new QuanLyNhaSach.QLNhaSachDataSet();
            this.hoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.dateTimeONgayNhap = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.cmbMaNCC = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.lblMaHDN = new System.Windows.Forms.Label();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lvHoaDonNhapSach = new System.Windows.Forms.ListView();
            this.MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaTL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.groupControlThongTinNhapSach = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanelChucNang = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.hoaDonNhapTableAdapter = new QuanLyNhaSach.QLNhaSachDataSetTableAdapters.HoaDonNhapTableAdapter();
            this.cTHoaDonNhapTableAdapter = new QuanLyNhaSach.QLNhaSachDataSetTableAdapters.CTHoaDonNhapTableAdapter();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tabPaneChucNang = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageDSHoaDon = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dateEditTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.groupControlBoLoc = new DevExpress.XtraEditors.GroupControl();
            this.cmbMaHDN = new System.Windows.Forms.ComboBox();
            this.cmbNgayNhap = new System.Windows.Forms.ComboBox();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCTHDNH = new System.Windows.Forms.GroupBox();
            this.dataGridViewCTHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxHDNH = new System.Windows.Forms.GroupBox();
            this.dataGridViewHoaDonNhapHang = new System.Windows.Forms.DataGridView();
            this.maHDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTienHoaDonNhap = new System.Windows.Forms.TextBox();
            this.lblTongTienHD = new System.Windows.Forms.Label();
            this.tabNavigationPageTimKiem = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dataGridViewFind = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trongLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kichThuocBaoBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.rdbtnTimTheoLoai = new System.Windows.Forms.RadioButton();
            this.rdbtnTimTheoMa = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.rdbtnTimTheoTen = new System.Windows.Forms.RadioButton();
            this.nhaCungCapTableAdapter = new QuanLyNhaSach.QLNhaSachDataSetTableAdapters.NhaCungCapTableAdapter();
            this.sachTableAdapter = new QuanLyNhaSach.QLNhaSachDataSetTableAdapters.SachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaSachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeONgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinNhapSach)).BeginInit();
            this.groupControlThongTinNhapSach.SuspendLayout();
            this.tableLayoutPanelChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneChucNang)).BeginInit();
            this.tabPaneChucNang.SuspendLayout();
            this.tabNavigationPageDSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBoLoc)).BeginInit();
            this.groupControlBoLoc.SuspendLayout();
            this.groupBoxCTHDNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHoaDonNhap)).BeginInit();
            this.groupBoxHDNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDonNhapHang)).BeginInit();
            this.tabNavigationPageTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            this.groupBoxFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // cTHoaDonNhapBindingSource
            // 
            this.cTHoaDonNhapBindingSource.DataMember = "CTHoaDonNhap";
            this.cTHoaDonNhapBindingSource.DataSource = this.qLNhaSachDataSet;
            // 
            // qLNhaSachDataSet
            // 
            this.qLNhaSachDataSet.DataSetName = "QLNhaSachDataSet";
            this.qLNhaSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonNhapBindingSource
            // 
            this.hoaDonNhapBindingSource.DataMember = "HoaDonNhap";
            this.hoaDonNhapBindingSource.DataSource = this.qLNhaSachDataSet;
            // 
            // pnlTop
            // 
            this.pnlTop.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlTop.Appearance.Options.UseBackColor = true;
            this.pnlTop.AutoSize = true;
            this.pnlTop.Controls.Add(this.dateTimeONgayNhap);
            this.pnlTop.Controls.Add(this.cmbMaNCC);
            this.pnlTop.Controls.Add(this.lblNgay);
            this.pnlTop.Controls.Add(this.lblMaNCC);
            this.pnlTop.Controls.Add(this.txtMaHDN);
            this.pnlTop.Controls.Add(this.lblMaHDN);
            this.pnlTop.Controls.Add(this.btnXoaTatCa);
            this.pnlTop.Controls.Add(this.btnLuu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1248, 63);
            this.pnlTop.TabIndex = 4;
            // 
            // dateTimeONgayNhap
            // 
            this.dateTimeONgayNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeONgayNhap.EditValue = null;
            this.dateTimeONgayNhap.Location = new System.Drawing.Point(778, 21);
            this.dateTimeONgayNhap.Name = "dateTimeONgayNhap";
            this.dateTimeONgayNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeONgayNhap.Properties.Appearance.Options.UseFont = true;
            this.dateTimeONgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeONgayNhap.Properties.MaskSettings.Set("mask", "d");
            this.dateTimeONgayNhap.Size = new System.Drawing.Size(184, 28);
            this.dateTimeONgayNhap.TabIndex = 9;
            // 
            // cmbMaNCC
            // 
            this.cmbMaNCC.DataSource = this.nhaCungCapBindingSource;
            this.cmbMaNCC.DisplayMember = "TenNCC";
            this.cmbMaNCC.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaNCC.FormattingEnabled = true;
            this.cmbMaNCC.Location = new System.Drawing.Point(456, 20);
            this.cmbMaNCC.Name = "cmbMaNCC";
            this.cmbMaNCC.Size = new System.Drawing.Size(232, 29);
            this.cmbMaNCC.TabIndex = 7;
            this.cmbMaNCC.ValueMember = "MaNCC";
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.qLNhaSachDataSet;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblNgay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(706, 21);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(62, 24);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngay:";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(307, 21);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(143, 24);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Nhà Cung Cấp:";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaHDN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDN.Location = new System.Drawing.Point(101, 18);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(187, 32);
            this.txtMaHDN.TabIndex = 1;
            // 
            // lblMaHDN
            // 
            this.lblMaHDN.AutoSize = true;
            this.lblMaHDN.BackColor = System.Drawing.Color.Transparent;
            this.lblMaHDN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDN.Location = new System.Drawing.Point(13, 21);
            this.lblMaHDN.Name = "lblMaHDN";
            this.lblMaHDN.Size = new System.Drawing.Size(84, 24);
            this.lblMaHDN.TabIndex = 0;
            this.lblMaHDN.Text = "MaHDN:";
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTatCa.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTatCa.Location = new System.Drawing.Point(1114, 11);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(86, 45);
            this.btnXoaTatCa.TabIndex = 5;
            this.btnXoaTatCa.Text = "Xóa Tất Cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(991, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 45);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCenter.Controls.Add(this.lvHoaDonNhapSach);
            this.pnlCenter.Controls.Add(this.tableLayoutPanel1);
            this.pnlCenter.Controls.Add(this.groupControlThongTinNhapSach);
            this.pnlCenter.Controls.Add(this.lblDanhSachSanPham);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1248, 755);
            this.pnlCenter.TabIndex = 5;
            // 
            // lvHoaDonNhapSach
            // 
            this.lvHoaDonNhapSach.AllowDrop = true;
            this.lvHoaDonNhapSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHoaDonNhapSach.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvHoaDonNhapSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSach,
            this.TenSach,
            this.MaTL,
            this.GiaNhap,
            this.SoLuong,
            this.ThanhTien});
            this.lvHoaDonNhapSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvHoaDonNhapSach.FullRowSelect = true;
            this.lvHoaDonNhapSach.GridLines = true;
            this.lvHoaDonNhapSach.HideSelection = false;
            this.lvHoaDonNhapSach.Location = new System.Drawing.Point(356, 81);
            this.lvHoaDonNhapSach.MaximumSize = new System.Drawing.Size(1427, 1089);
            this.lvHoaDonNhapSach.Name = "lvHoaDonNhapSach";
            this.lvHoaDonNhapSach.Size = new System.Drawing.Size(880, 308);
            this.lvHoaDonNhapSach.TabIndex = 13;
            this.lvHoaDonNhapSach.UseCompatibleStateImageBehavior = false;
            this.lvHoaDonNhapSach.View = System.Windows.Forms.View.Details;
            this.lvHoaDonNhapSach.SelectedIndexChanged += new System.EventHandler(this.lvHoaDonNhapSach_SelectedIndexChanged);
            // 
            // MaSach
            // 
            this.MaSach.Text = "MaSach";
            this.MaSach.Width = 120;
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên Sách";
            this.TenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenSach.Width = 171;
            // 
            // MaTL
            // 
            this.MaTL.Text = "Mã thể loại";
            this.MaTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaTL.Width = 144;
            // 
            // GiaNhap
            // 
            this.GiaNhap.Text = "Giá Nhập";
            this.GiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaNhap.Width = 146;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuong.Width = 147;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành Tiền";
            this.ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThanhTien.Width = 148;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnCapNhat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThemSach, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 341);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 52);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(119, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(86, 45);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(227, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 45);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSach.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.Location = new System.Drawing.Point(11, 3);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(86, 45);
            this.btnThemSach.TabIndex = 10;
            this.btnThemSach.Text = "Thêm Sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // groupControlThongTinNhapSach
            // 
            this.groupControlThongTinNhapSach.Controls.Add(this.tableLayoutPanelChucNang);
            this.groupControlThongTinNhapSach.Location = new System.Drawing.Point(7, 81);
            this.groupControlThongTinNhapSach.Name = "groupControlThongTinNhapSach";
            this.groupControlThongTinNhapSach.Size = new System.Drawing.Size(325, 254);
            this.groupControlThongTinNhapSach.TabIndex = 9;
            this.groupControlThongTinNhapSach.Text = "Nhập Sách Cần Thêm";
            // 
            // tableLayoutPanelChucNang
            // 
            this.tableLayoutPanelChucNang.ColumnCount = 2;
            this.tableLayoutPanelChucNang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChucNang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChucNang.Controls.Add(this.lblMaSach, 0, 0);
            this.tableLayoutPanelChucNang.Controls.Add(this.txtMaSach, 1, 0);
            this.tableLayoutPanelChucNang.Controls.Add(this.lblSoLuong, 0, 1);
            this.tableLayoutPanelChucNang.Controls.Add(this.numericUpDownSoLuong, 1, 1);
            this.tableLayoutPanelChucNang.Controls.Add(this.lblTongTien, 0, 3);
            this.tableLayoutPanelChucNang.Controls.Add(this.txtTongTien, 1, 3);
            this.tableLayoutPanelChucNang.Controls.Add(this.lblDonGia, 0, 2);
            this.tableLayoutPanelChucNang.Controls.Add(this.nudDonGia, 1, 2);
            this.tableLayoutPanelChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChucNang.Location = new System.Drawing.Point(2, 28);
            this.tableLayoutPanelChucNang.Name = "tableLayoutPanelChucNang";
            this.tableLayoutPanelChucNang.RowCount = 4;
            this.tableLayoutPanelChucNang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanelChucNang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanelChucNang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanelChucNang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanelChucNang.Size = new System.Drawing.Size(321, 224);
            this.tableLayoutPanelChucNang.TabIndex = 5;
            // 
            // lblMaSach
            // 
            this.lblMaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.BackColor = System.Drawing.Color.Transparent;
            this.lblMaSach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(37, 16);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(85, 24);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "MaSach:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaSach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(163, 12);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(155, 32);
            this.txtMaSach.TabIndex = 1;
            this.txtMaSach.TextChanged += new System.EventHandler(this.CheckMaSach);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(30, 72);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(100, 24);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSoLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(163, 70);
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(155, 28);
            this.numericUpDownSoLuong.TabIndex = 2;
            this.numericUpDownSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(22, 184);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(116, 24);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(163, 180);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(155, 32);
            this.txtTongTien.TabIndex = 1;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.BackColor = System.Drawing.Color.Transparent;
            this.lblDonGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(39, 128);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(81, 24);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // nudDonGia
            // 
            this.nudDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDonGia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDonGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDonGia.Location = new System.Drawing.Point(163, 126);
            this.nudDonGia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDonGia.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(155, 28);
            this.nudDonGia.TabIndex = 2;
            this.nudDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDonGia.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(675, 11);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(225, 24);
            this.lblDanhSachSanPham.TabIndex = 7;
            this.lblDanhSachSanPham.Text = "Danh Sách Sản Phẩm";
            this.lblDanhSachSanPham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hoaDonNhapTableAdapter
            // 
            this.hoaDonNhapTableAdapter.ClearBeforeFill = true;
            // 
            // cTHoaDonNhapTableAdapter
            // 
            this.cTHoaDonNhapTableAdapter.ClearBeforeFill = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBottom.Controls.Add(this.tabPaneChucNang);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 400);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1248, 355);
            this.pnlBottom.TabIndex = 6;
            // 
            // tabPaneChucNang
            // 
            this.tabPaneChucNang.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPaneChucNang.Appearance.Options.UseFont = true;
            this.tabPaneChucNang.Controls.Add(this.tabNavigationPageDSHoaDon);
            this.tabPaneChucNang.Controls.Add(this.tabNavigationPageTimKiem);
            this.tabPaneChucNang.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPaneChucNang.Location = new System.Drawing.Point(0, 0);
            this.tabPaneChucNang.Name = "tabPaneChucNang";
            this.tabPaneChucNang.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageDSHoaDon,
            this.tabNavigationPageTimKiem});
            this.tabPaneChucNang.RegularSize = new System.Drawing.Size(1248, 355);
            this.tabPaneChucNang.SelectedPage = this.tabNavigationPageDSHoaDon;
            this.tabPaneChucNang.Size = new System.Drawing.Size(1248, 355);
            this.tabPaneChucNang.TabIndex = 0;
            // 
            // tabNavigationPageDSHoaDon
            // 
            this.tabNavigationPageDSHoaDon.Caption = "Hóa Đơn Nhập Hàng";
            this.tabNavigationPageDSHoaDon.Controls.Add(this.groupControlBoLoc);
            this.tabNavigationPageDSHoaDon.Controls.Add(this.groupBoxCTHDNH);
            this.tabNavigationPageDSHoaDon.Controls.Add(this.groupBoxHDNH);
            this.tabNavigationPageDSHoaDon.Controls.Add(this.txtTongTienHoaDonNhap);
            this.tabNavigationPageDSHoaDon.Controls.Add(this.lblTongTienHD);
            this.tabNavigationPageDSHoaDon.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPageDSHoaDon.Name = "tabNavigationPageDSHoaDon";
            this.tabNavigationPageDSHoaDon.Size = new System.Drawing.Size(1248, 314);
            // 
            // dateEditTuNgay
            // 
            this.dateEditTuNgay.EditValue = new System.DateTime(2022, 8, 8, 23, 48, 16, 0);
            this.dateEditTuNgay.Location = new System.Drawing.Point(396, 71);
            this.dateEditTuNgay.Name = "dateEditTuNgay";
            this.dateEditTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditTuNgay.Properties.Appearance.Options.UseFont = true;
            this.dateEditTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown)});
            this.dateEditTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTuNgay.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateEditTuNgay.Properties.EditFormat.FormatString = "dd/mm/yyyy";
            this.dateEditTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditTuNgay.Properties.MaskSettings.Set("mask", "d");
            this.dateEditTuNgay.Properties.MaxValue = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dateEditTuNgay.Properties.MinValue = new System.DateTime(2021, 2, 1, 0, 0, 0, 0);
            this.dateEditTuNgay.Properties.NullDate = new System.DateTime(2022, 8, 9, 20, 20, 17, 617);
            this.dateEditTuNgay.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditTuNgay.Size = new System.Drawing.Size(170, 28);
            this.dateEditTuNgay.TabIndex = 22;
            this.dateEditTuNgay.EditValueChanged += new System.EventHandler(this.editDate);
            // 
            // groupControlBoLoc
            // 
            this.groupControlBoLoc.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlBoLoc.AppearanceCaption.Options.UseFont = true;
            this.groupControlBoLoc.Controls.Add(this.dateEditTuNgay);
            this.groupControlBoLoc.Controls.Add(this.cmbMaHDN);
            this.groupControlBoLoc.Controls.Add(this.cmbNgayNhap);
            this.groupControlBoLoc.Controls.Add(this.cmbNhaCungCap);
            this.groupControlBoLoc.Controls.Add(this.label3);
            this.groupControlBoLoc.Controls.Add(this.label2);
            this.groupControlBoLoc.Controls.Add(this.lblTuNgay);
            this.groupControlBoLoc.Controls.Add(this.label1);
            this.groupControlBoLoc.Location = new System.Drawing.Point(7, 4);
            this.groupControlBoLoc.Name = "groupControlBoLoc";
            this.groupControlBoLoc.Size = new System.Drawing.Size(571, 105);
            this.groupControlBoLoc.TabIndex = 20;
            this.groupControlBoLoc.Text = "Bộ Lọc";
            // 
            // cmbMaHDN
            // 
            this.cmbMaHDN.DataSource = this.hoaDonNhapBindingSource;
            this.cmbMaHDN.DisplayMember = "MaHDN";
            this.cmbMaHDN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaHDN.FormattingEnabled = true;
            this.cmbMaHDN.Location = new System.Drawing.Point(101, 28);
            this.cmbMaHDN.Name = "cmbMaHDN";
            this.cmbMaHDN.Size = new System.Drawing.Size(145, 29);
            this.cmbMaHDN.TabIndex = 7;
            this.cmbMaHDN.ValueMember = "MaHDN";
            // 
            // cmbNgayNhap
            // 
            this.cmbNgayNhap.DataSource = this.hoaDonNhapBindingSource;
            this.cmbNgayNhap.DisplayMember = "NgayNhap";
            this.cmbNgayNhap.Enabled = false;
            this.cmbNgayNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNgayNhap.FormattingEnabled = true;
            this.cmbNgayNhap.Location = new System.Drawing.Point(111, 70);
            this.cmbNgayNhap.Name = "cmbNgayNhap";
            this.cmbNgayNhap.Size = new System.Drawing.Size(148, 29);
            this.cmbNgayNhap.TabIndex = 7;
            this.cmbNgayNhap.ValueMember = "NgayNhap";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.DataSource = this.hoaDonNhapBindingSource;
            this.cmbNhaCungCap.DisplayMember = "MaNCC";
            this.cmbNhaCungCap.Enabled = false;
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(396, 28);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(170, 29);
            this.cmbNhaCungCap.TabIndex = 7;
            this.cmbNhaCungCap.ValueMember = "MaNCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "MaHDN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà Cung Cấp:";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblTuNgay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(300, 70);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(92, 24);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày nhập:";
            // 
            // groupBoxCTHDNH
            // 
            this.groupBoxCTHDNH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCTHDNH.BackColor = System.Drawing.Color.DarkGray;
            this.groupBoxCTHDNH.Controls.Add(this.dataGridViewCTHoaDonNhap);
            this.groupBoxCTHDNH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCTHDNH.Location = new System.Drawing.Point(624, 99);
            this.groupBoxCTHDNH.Name = "groupBoxCTHDNH";
            this.groupBoxCTHDNH.Size = new System.Drawing.Size(612, 208);
            this.groupBoxCTHDNH.TabIndex = 18;
            this.groupBoxCTHDNH.TabStop = false;
            this.groupBoxCTHDNH.Text = "Danh Sách Chi Tiết Hóa Đơn Nhập Hàng";
            // 
            // dataGridViewCTHoaDonNhap
            // 
            this.dataGridViewCTHoaDonNhap.AutoGenerateColumns = false;
            this.dataGridViewCTHoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn1,
            this.maHDNDataGridViewTextBoxColumn1,
            this.soLuongDataGridViewTextBoxColumn1,
            this.donGiaDataGridViewTextBoxColumn});
            this.dataGridViewCTHoaDonNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewCTHoaDonNhap.DataSource = this.cTHoaDonNhapBindingSource;
            this.dataGridViewCTHoaDonNhap.Location = new System.Drawing.Point(3, 24);
            this.dataGridViewCTHoaDonNhap.MaximumSize = new System.Drawing.Size(961, 447);
            this.dataGridViewCTHoaDonNhap.Name = "dataGridViewCTHoaDonNhap";
            this.dataGridViewCTHoaDonNhap.RowHeadersWidth = 51;
            this.dataGridViewCTHoaDonNhap.RowTemplate.Height = 24;
            this.dataGridViewCTHoaDonNhap.Size = new System.Drawing.Size(606, 181);
            this.dataGridViewCTHoaDonNhap.TabIndex = 7;
            // 
            // maSachDataGridViewTextBoxColumn1
            // 
            this.maSachDataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn1.HeaderText = "MaSach";
            this.maSachDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maSachDataGridViewTextBoxColumn1.Name = "maSachDataGridViewTextBoxColumn1";
            // 
            // maHDNDataGridViewTextBoxColumn1
            // 
            this.maHDNDataGridViewTextBoxColumn1.DataPropertyName = "MaHDN";
            this.maHDNDataGridViewTextBoxColumn1.HeaderText = "MaHDN";
            this.maHDNDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maHDNDataGridViewTextBoxColumn1.Name = "maHDNDataGridViewTextBoxColumn1";
            // 
            // soLuongDataGridViewTextBoxColumn1
            // 
            this.soLuongDataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn1.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn1.Name = "soLuongDataGridViewTextBoxColumn1";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // groupBoxHDNH
            // 
            this.groupBoxHDNH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHDNH.BackColor = System.Drawing.Color.DarkGray;
            this.groupBoxHDNH.Controls.Add(this.dataGridViewHoaDonNhapHang);
            this.groupBoxHDNH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHDNH.Location = new System.Drawing.Point(7, 111);
            this.groupBoxHDNH.Name = "groupBoxHDNH";
            this.groupBoxHDNH.Size = new System.Drawing.Size(572, 196);
            this.groupBoxHDNH.TabIndex = 19;
            this.groupBoxHDNH.TabStop = false;
            this.groupBoxHDNH.Text = "Danh Sách Hóa Đơn Nhập Hàng";
            // 
            // dataGridViewHoaDonNhapHang
            // 
            this.dataGridViewHoaDonNhapHang.AutoGenerateColumns = false;
            this.dataGridViewHoaDonNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDonNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDonNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDNDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn});
            this.dataGridViewHoaDonNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewHoaDonNhapHang.DataSource = this.hoaDonNhapBindingSource;
            this.dataGridViewHoaDonNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHoaDonNhapHang.Location = new System.Drawing.Point(3, 24);
            this.dataGridViewHoaDonNhapHang.MaximumSize = new System.Drawing.Size(561, 1000);
            this.dataGridViewHoaDonNhapHang.Name = "dataGridViewHoaDonNhapHang";
            this.dataGridViewHoaDonNhapHang.RowHeadersWidth = 51;
            this.dataGridViewHoaDonNhapHang.RowTemplate.Height = 24;
            this.dataGridViewHoaDonNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoaDonNhapHang.Size = new System.Drawing.Size(561, 169);
            this.dataGridViewHoaDonNhapHang.TabIndex = 7;
            this.dataGridViewHoaDonNhapHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDonNhapHang_CellContentClick);
            this.dataGridViewHoaDonNhapHang.SelectionChanged += new System.EventHandler(this.SelectionChanged_RowHoaDonNhap);
            // 
            // maHDNDataGridViewTextBoxColumn
            // 
            this.maHDNDataGridViewTextBoxColumn.DataPropertyName = "MaHDN";
            this.maHDNDataGridViewTextBoxColumn.HeaderText = "MaHDN";
            this.maHDNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDNDataGridViewTextBoxColumn.Name = "maHDNDataGridViewTextBoxColumn";
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            // 
            // txtTongTienHoaDonNhap
            // 
            this.txtTongTienHoaDonNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongTienHoaDonNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienHoaDonNhap.ForeColor = System.Drawing.Color.Red;
            this.txtTongTienHoaDonNhap.Location = new System.Drawing.Point(1030, 50);
            this.txtTongTienHoaDonNhap.Name = "txtTongTienHoaDonNhap";
            this.txtTongTienHoaDonNhap.ReadOnly = true;
            this.txtTongTienHoaDonNhap.Size = new System.Drawing.Size(187, 32);
            this.txtTongTienHoaDonNhap.TabIndex = 1;
            this.txtTongTienHoaDonNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTongTienHD
            // 
            this.lblTongTienHD.AutoSize = true;
            this.lblTongTienHD.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTienHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienHD.Location = new System.Drawing.Point(771, 50);
            this.lblTongTienHD.Name = "lblTongTienHD";
            this.lblTongTienHD.Size = new System.Drawing.Size(191, 24);
            this.lblTongTienHD.TabIndex = 0;
            this.lblTongTienHD.Text = "Tổng Tiền Hóa Đơn:";
            // 
            // tabNavigationPageTimKiem
            // 
            this.tabNavigationPageTimKiem.Caption = "Tìm kiếm Sách";
            this.tabNavigationPageTimKiem.Controls.Add(this.dataGridViewFind);
            this.tabNavigationPageTimKiem.Controls.Add(this.groupBoxFind);
            this.tabNavigationPageTimKiem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPageTimKiem.Name = "tabNavigationPageTimKiem";
            this.tabNavigationPageTimKiem.Size = new System.Drawing.Size(1248, 314);
            // 
            // dataGridViewFind
            // 
            this.dataGridViewFind.AutoGenerateColumns = false;
            this.dataGridViewFind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.maTLDataGridViewTextBoxColumn,
            this.maTGDataGridViewTextBoxColumn,
            this.maNXBDataGridViewTextBoxColumn,
            this.namXBDataGridViewTextBoxColumn,
            this.trongLuongDataGridViewTextBoxColumn,
            this.kichThuocBaoBiDataGridViewTextBoxColumn,
            this.soTrangDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn});
            this.dataGridViewFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewFind.DataSource = this.sachBindingSource;
            this.dataGridViewFind.Location = new System.Drawing.Point(10, 85);
            this.dataGridViewFind.Name = "dataGridViewFind";
            this.dataGridViewFind.ReadOnly = true;
            this.dataGridViewFind.RowHeadersWidth = 51;
            this.dataGridViewFind.RowTemplate.Height = 24;
            this.dataGridViewFind.Size = new System.Drawing.Size(1221, 217);
            this.dataGridViewFind.TabIndex = 21;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "MaSach";
            this.maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTLDataGridViewTextBoxColumn
            // 
            this.maTLDataGridViewTextBoxColumn.DataPropertyName = "MaTL";
            this.maTLDataGridViewTextBoxColumn.HeaderText = "MaTL";
            this.maTLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTLDataGridViewTextBoxColumn.Name = "maTLDataGridViewTextBoxColumn";
            this.maTLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTGDataGridViewTextBoxColumn
            // 
            this.maTGDataGridViewTextBoxColumn.DataPropertyName = "MaTG";
            this.maTGDataGridViewTextBoxColumn.HeaderText = "MaTG";
            this.maTGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTGDataGridViewTextBoxColumn.Name = "maTGDataGridViewTextBoxColumn";
            this.maTGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNXBDataGridViewTextBoxColumn
            // 
            this.maNXBDataGridViewTextBoxColumn.DataPropertyName = "MaNXB";
            this.maNXBDataGridViewTextBoxColumn.HeaderText = "MaNXB";
            this.maNXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNXBDataGridViewTextBoxColumn.Name = "maNXBDataGridViewTextBoxColumn";
            this.maNXBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namXBDataGridViewTextBoxColumn
            // 
            this.namXBDataGridViewTextBoxColumn.DataPropertyName = "NamXB";
            this.namXBDataGridViewTextBoxColumn.HeaderText = "NamXB";
            this.namXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namXBDataGridViewTextBoxColumn.Name = "namXBDataGridViewTextBoxColumn";
            this.namXBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trongLuongDataGridViewTextBoxColumn
            // 
            this.trongLuongDataGridViewTextBoxColumn.DataPropertyName = "TrongLuong";
            this.trongLuongDataGridViewTextBoxColumn.HeaderText = "TrongLuong";
            this.trongLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trongLuongDataGridViewTextBoxColumn.Name = "trongLuongDataGridViewTextBoxColumn";
            this.trongLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kichThuocBaoBiDataGridViewTextBoxColumn
            // 
            this.kichThuocBaoBiDataGridViewTextBoxColumn.DataPropertyName = "KichThuocBaoBi";
            this.kichThuocBaoBiDataGridViewTextBoxColumn.HeaderText = "KichThuocBaoBi";
            this.kichThuocBaoBiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kichThuocBaoBiDataGridViewTextBoxColumn.Name = "kichThuocBaoBiDataGridViewTextBoxColumn";
            this.kichThuocBaoBiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soTrangDataGridViewTextBoxColumn
            // 
            this.soTrangDataGridViewTextBoxColumn.DataPropertyName = "SoTrang";
            this.soTrangDataGridViewTextBoxColumn.HeaderText = "SoTrang";
            this.soTrangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTrangDataGridViewTextBoxColumn.Name = "soTrangDataGridViewTextBoxColumn";
            this.soTrangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "MoTa";
            this.moTaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qLNhaSachDataSet;
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxFind.BackColor = System.Drawing.Color.Silver;
            this.groupBoxFind.Controls.Add(this.rdbtnTimTheoLoai);
            this.groupBoxFind.Controls.Add(this.rdbtnTimTheoMa);
            this.groupBoxFind.Controls.Add(this.btnFind);
            this.groupBoxFind.Controls.Add(this.txtFind);
            this.groupBoxFind.Controls.Add(this.rdbtnTimTheoTen);
            this.groupBoxFind.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFind.Location = new System.Drawing.Point(10, 15);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(1221, 64);
            this.groupBoxFind.TabIndex = 20;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Text = "Chức Năng Tìm Kiếm";
            // 
            // rdbtnTimTheoLoai
            // 
            this.rdbtnTimTheoLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnTimTheoLoai.AutoSize = true;
            this.rdbtnTimTheoLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnTimTheoLoai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTimTheoLoai.Location = new System.Drawing.Point(419, 28);
            this.rdbtnTimTheoLoai.Name = "rdbtnTimTheoLoai";
            this.rdbtnTimTheoLoai.Size = new System.Drawing.Size(176, 25);
            this.rdbtnTimTheoLoai.TabIndex = 3;
            this.rdbtnTimTheoLoai.TabStop = true;
            this.rdbtnTimTheoLoai.Text = "Tìm Theo Loại Sách";
            this.rdbtnTimTheoLoai.UseVisualStyleBackColor = true;
            // 
            // rdbtnTimTheoMa
            // 
            this.rdbtnTimTheoMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnTimTheoMa.AutoSize = true;
            this.rdbtnTimTheoMa.Checked = true;
            this.rdbtnTimTheoMa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnTimTheoMa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTimTheoMa.Location = new System.Drawing.Point(45, 28);
            this.rdbtnTimTheoMa.Name = "rdbtnTimTheoMa";
            this.rdbtnTimTheoMa.Size = new System.Drawing.Size(168, 25);
            this.rdbtnTimTheoMa.TabIndex = 3;
            this.rdbtnTimTheoMa.TabStop = true;
            this.rdbtnTimTheoMa.Text = "Tìm Theo Mã Sách";
            this.rdbtnTimTheoMa.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(1019, 18);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 29);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Tìm Sách";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFind.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(690, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(308, 28);
            this.txtFind.TabIndex = 2;
            this.txtFind.TextChanged += new System.EventHandler(this.TextChanged_Find);
            // 
            // rdbtnTimTheoTen
            // 
            this.rdbtnTimTheoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnTimTheoTen.AutoSize = true;
            this.rdbtnTimTheoTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnTimTheoTen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTimTheoTen.Location = new System.Drawing.Point(233, 28);
            this.rdbtnTimTheoTen.Name = "rdbtnTimTheoTen";
            this.rdbtnTimTheoTen.Size = new System.Drawing.Size(174, 25);
            this.rdbtnTimTheoTen.TabIndex = 3;
            this.rdbtnTimTheoTen.TabStop = true;
            this.rdbtnTimTheoTen.Text = "Tìm Theo Tên Sách";
            this.rdbtnTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1248, 755);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhapHang";
            this.Text = "FrmNhapHang";
            this.Load += new System.EventHandler(this.FrmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaSachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeONgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinNhapSach)).EndInit();
            this.groupControlThongTinNhapSach.ResumeLayout(false);
            this.tableLayoutPanelChucNang.ResumeLayout(false);
            this.tableLayoutPanelChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneChucNang)).EndInit();
            this.tabPaneChucNang.ResumeLayout(false);
            this.tabNavigationPageDSHoaDon.ResumeLayout(false);
            this.tabNavigationPageDSHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBoLoc)).EndInit();
            this.groupControlBoLoc.ResumeLayout(false);
            this.groupControlBoLoc.PerformLayout();
            this.groupBoxCTHDNH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHoaDonNhap)).EndInit();
            this.groupBoxHDNH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDonNhapHang)).EndInit();
            this.tabNavigationPageTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnlTop;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label lblMaHDN;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.ComboBox cmbMaNCC;
        private QLNhaSachDataSet qLNhaSachDataSet;
        private System.Windows.Forms.BindingSource hoaDonNhapBindingSource;
        private QLNhaSachDataSetTableAdapters.HoaDonNhapTableAdapter hoaDonNhapTableAdapter;
        private System.Windows.Forms.BindingSource cTHoaDonNhapBindingSource;
        private QLNhaSachDataSetTableAdapters.CTHoaDonNhapTableAdapter cTHoaDonNhapTableAdapter;
        private System.Windows.Forms.Panel pnlBottom;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeONgayNhap;
        private DevExpress.XtraEditors.GroupControl groupControlThongTinNhapSach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChucNang;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QLNhaSachDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private DevExpress.XtraBars.Navigation.TabPane tabPaneChucNang;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageDSHoaDon;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageTimKiem;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.RadioButton rdbtnTimTheoLoai;
        private System.Windows.Forms.RadioButton rdbtnTimTheoMa;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.RadioButton rdbtnTimTheoTen;
        private System.Windows.Forms.GroupBox groupBoxCTHDNH;
        private System.Windows.Forms.DataGridView dataGridViewCTHoaDonNhap;
        private System.Windows.Forms.GroupBox groupBoxHDNH;
        private System.Windows.Forms.DataGridView dataGridViewHoaDonNhapHang;
        private System.Windows.Forms.DataGridView dataGridViewFind;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLNhaSachDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trongLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kichThuocBaoBiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.GroupControl groupControlBoLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTienHoaDonNhap;
        private System.Windows.Forms.Label lblTongTienHD;
        private System.Windows.Forms.ComboBox cmbMaHDN;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNgayNhap;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.ListView lvHoaDonNhapSach;
        private System.Windows.Forms.ColumnHeader MaSach;
        private System.Windows.Forms.ColumnHeader TenSach;
        private System.Windows.Forms.ColumnHeader MaTL;
        private System.Windows.Forms.ColumnHeader GiaNhap;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.Label lblTuNgay;
        private DevExpress.XtraEditors.DateEdit dateEditTuNgay;
    }
}