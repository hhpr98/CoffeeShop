using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFProject
{
    public partial class Main : Form
    {
        private TaiKhoan tk;
        public Main()
        {
            InitializeComponent();
        }

        public Main(TaiKhoan t)
        {
            InitializeComponent();
            this.tk = t;
            lblNameAcc.Text = t.TenDangNhap;
        }

        #region MenuStrip
        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quản lí quán cafe v1.0\n1612203 - 1612209\nKhoa CNTT - ĐH KHTN - ĐHQGTPHCM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control frmControl = new Control();
            this.Hide();
            frmControl.ShowDialog();
            this.Show();
        }
        #endregion

        #region Table
        #endregion

        #region Checkout
        private void Main_Load(object sender, EventArgs e)
        {
            using (var db = new QLCafeEntities())
            {
                var lc = db.NhomSanPhams.Where(c => c.isDeleted == 0).ToList();
                var lcData = lc.Select(c => c.TenNhom).ToList();
                cbCategory.DataSource = lcData;
                //var lp = db.SanPhams.Where(p => p.isDeleted == 0).Select(p => p.TenSanPham).ToList();
                //cbProduct.DataSource = lp;
                int cid = lc[0].MaNhom;
                var lp = db.SanPhams.Where(p => p.isDeleted == 0 && p.MaNhom == cid).Select(p => p.TenSanPham).ToList();
                cbProduct.DataSource = lp;
            }
        }

        private void cbCatogory_TextChanged(object sender, EventArgs e)
        {
            using (var db = new QLCafeEntities())
            {
                var lc = db.NhomSanPhams.Where(c => c.isDeleted == 0).ToList();
                int selIndex = cbCategory.SelectedIndex;
                int cid = lc[selIndex].MaNhom;
                var lp = db.SanPhams.Where(p => p.isDeleted == 0 && p.MaNhom == cid).Select(p => p.TenSanPham).ToList();
                cbProduct.DataSource = lp;
            }
        }
        #endregion


    }
}
