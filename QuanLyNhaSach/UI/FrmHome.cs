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
    public partial class FrmHome : DevExpress.XtraEditors.XtraForm
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaSachDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLNhaSachDataSet.Sach);

        }
    }
}