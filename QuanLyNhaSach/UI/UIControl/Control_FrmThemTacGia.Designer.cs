namespace QuanLyNhaSach.UI.UIControl
{
    partial class Control_FrmThemTacGia
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
            this.groupControlThemTacGia = new DevExpress.XtraEditors.GroupControl();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tableLayoutPanelTacGia = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.lblTenTG = new System.Windows.Forms.Label();
            this.txtTenTG = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTG = new DevExpress.XtraEditors.TextEdit();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThemTacGia)).BeginInit();
            this.groupControlThemTacGia.SuspendLayout();
            this.tableLayoutPanelTacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlThemTacGia
            // 
            this.groupControlThemTacGia.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlThemTacGia.AppearanceCaption.Options.UseFont = true;
            this.groupControlThemTacGia.AutoSize = true;
            this.groupControlThemTacGia.Controls.Add(this.tableLayoutPanelTacGia);
            this.groupControlThemTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlThemTacGia.Location = new System.Drawing.Point(0, 0);
            this.groupControlThemTacGia.Name = "groupControlThemTacGia";
            this.groupControlThemTacGia.Size = new System.Drawing.Size(1223, 85);
            this.groupControlThemTacGia.TabIndex = 0;
            this.groupControlThemTacGia.Text = "Thêm Tác Giả";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(1073, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 42);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tableLayoutPanelTacGia
            // 
            this.tableLayoutPanelTacGia.ColumnCount = 7;
            this.tableLayoutPanelTacGia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTacGia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTacGia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTacGia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTacGia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTacGia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTacGia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTacGia.Controls.Add(this.btnLuu, 6, 0);
            this.tableLayoutPanelTacGia.Controls.Add(this.lblMaTacGia, 0, 0);
            this.tableLayoutPanelTacGia.Controls.Add(this.lblTenTG, 2, 0);
            this.tableLayoutPanelTacGia.Controls.Add(this.txtTenTG, 3, 0);
            this.tableLayoutPanelTacGia.Controls.Add(this.txtMaTG, 1, 0);
            this.tableLayoutPanelTacGia.Controls.Add(this.btnHuy, 5, 0);
            this.tableLayoutPanelTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTacGia.Location = new System.Drawing.Point(2, 28);
            this.tableLayoutPanelTacGia.Name = "tableLayoutPanelTacGia";
            this.tableLayoutPanelTacGia.RowCount = 1;
            this.tableLayoutPanelTacGia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTacGia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTacGia.Size = new System.Drawing.Size(1219, 55);
            this.tableLayoutPanelTacGia.TabIndex = 1;
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTacGia.Location = new System.Drawing.Point(23, 15);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(127, 24);
            this.lblMaTacGia.TabIndex = 1;
            this.lblMaTacGia.Text = "Mã Tác Giả:";
            // 
            // lblTenTG
            // 
            this.lblTenTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenTG.AutoSize = true;
            this.lblTenTG.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTG.Location = new System.Drawing.Point(368, 15);
            this.lblTenTG.Name = "lblTenTG";
            this.lblTenTG.Size = new System.Drawing.Size(134, 24);
            this.lblTenTG.TabIndex = 1;
            this.lblTenTG.Text = "Tên Tác Giả:";
            // 
            // txtTenTG
            // 
            this.txtTenTG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenTG.Location = new System.Drawing.Point(525, 12);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Properties.Appearance.Options.UseFont = true;
            this.txtTenTG.Size = new System.Drawing.Size(161, 30);
            this.txtTenTG.TabIndex = 2;
            // 
            // txtMaTG
            // 
            this.txtMaTG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaTG.EditValue = "TG_";
            this.txtMaTG.Location = new System.Drawing.Point(177, 12);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Properties.Appearance.Options.UseFont = true;
            this.txtMaTG.Size = new System.Drawing.Size(161, 30);
            this.txtMaTG.TabIndex = 2;
            this.txtMaTG.TextChanged += new System.EventHandler(this.InsertMaTG);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(899, 6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 42);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // Control_FrmThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1223, 85);
            this.Controls.Add(this.groupControlThemTacGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Control_FrmThemTacGia";
            this.Text = "Control_FrmThemTacGia";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThemTacGia)).EndInit();
            this.groupControlThemTacGia.ResumeLayout(false);
            this.tableLayoutPanelTacGia.ResumeLayout(false);
            this.tableLayoutPanelTacGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTG.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlThemTacGia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTacGia;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblMaTacGia;
        private System.Windows.Forms.Label lblTenTG;
        private DevExpress.XtraEditors.TextEdit txtTenTG;
        private DevExpress.XtraEditors.TextEdit txtMaTG;
        private System.Windows.Forms.Button btnHuy;
    }
}