namespace QuanLyNhaSach.UI
{
    partial class FrmNhanVien
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.xtraTabControlNhanVien = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageDanhSachNV = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageUpdateNhanVien = new DevExpress.XtraTab.XtraTabPage();
            this.textEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlNhanVien)).BeginInit();
            this.xtraTabControlNhanVien.SuspendLayout();
            this.xtraTabPageDanhSachNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.AutoScroll = true;
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.lblQuanLyNhanVien);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1225, 78);
            this.panelTop.TabIndex = 0;
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(467, 9);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(283, 34);
            this.lblQuanLyNhanVien.TabIndex = 0;
            this.lblQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.lblQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.AutoScroll = true;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 513);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1225, 236);
            this.panelBottom.TabIndex = 1;
            // 
            // panelCenter
            // 
            this.panelCenter.AutoScroll = true;
            this.panelCenter.AutoSize = true;
            this.panelCenter.Controls.Add(this.dataGridViewNhanVien);
            this.panelCenter.Controls.Add(this.xtraTabControlNhanVien);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 78);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1225, 435);
            this.panelCenter.TabIndex = 2;
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.AllowUserToOrderColumns = true;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNhanVien.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(635, 0);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.RowHeadersWidth = 51;
            this.dataGridViewNhanVien.RowTemplate.Height = 24;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(590, 435);
            this.dataGridViewNhanVien.TabIndex = 1;
            // 
            // xtraTabControlNhanVien
            // 
            this.xtraTabControlNhanVien.Appearance.BackColor = System.Drawing.Color.Gray;
            this.xtraTabControlNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControlNhanVien.Appearance.Options.UseBackColor = true;
            this.xtraTabControlNhanVien.Appearance.Options.UseFont = true;
            this.xtraTabControlNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabControlNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlNhanVien.Name = "xtraTabControlNhanVien";
            this.xtraTabControlNhanVien.SelectedTabPage = this.xtraTabPageDanhSachNV;
            this.xtraTabControlNhanVien.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControlNhanVien.Size = new System.Drawing.Size(635, 435);
            this.xtraTabControlNhanVien.TabIndex = 0;
            this.xtraTabControlNhanVien.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageDanhSachNV,
            this.xtraTabPageUpdateNhanVien});
            // 
            // xtraTabPageDanhSachNV
            // 
            this.xtraTabPageDanhSachNV.Controls.Add(this.textEdit1);
            this.xtraTabPageDanhSachNV.Name = "xtraTabPageDanhSachNV";
            this.xtraTabPageDanhSachNV.Size = new System.Drawing.Size(633, 405);
            this.xtraTabPageDanhSachNV.Text = "Danh Sách Nhân Viên";
            // 
            // xtraTabPageUpdateNhanVien
            // 
            this.xtraTabPageUpdateNhanVien.Name = "xtraTabPageUpdateNhanVien";
            this.xtraTabPageUpdateNhanVien.Size = new System.Drawing.Size(633, 405);
            this.xtraTabPageUpdateNhanVien.Text = "Thông Tin Nhân Viên";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = null;
            this.textEdit1.Location = new System.Drawing.Point(362, 19);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.textEdit1.Properties.DisplayFormat.FormatString = "";
            this.textEdit1.Properties.EditFormat.FormatString = "";
            this.textEdit1.Properties.Mask.EditMask = "";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 3;
            // 
            // FrmNhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1225, 749);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlNhanVien)).EndInit();
            this.xtraTabControlNhanVien.ResumeLayout(false);
            this.xtraTabPageDanhSachNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlNhanVien;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDanhSachNV;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageUpdateNhanVien;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private DevExpress.XtraEditors.DateEdit textEdit1;
    }
}