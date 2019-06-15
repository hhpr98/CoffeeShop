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
        public void LoadDataTable()
        {
            int xLocation = 5;
            int yLocation = 30;
            for (int i = 0; i < 12; i++)
            {
                Button btn = new Button();
                btn.Name = string.Format("Button{0}", i);
                btn.Text = string.Format("Bàn {0}\n\nTrống", i+1);
                btn.Location = new System.Drawing.Point(xLocation, yLocation);
                btn.Size = new System.Drawing.Size(100, 100);
                btn.BackColor = Color.Brown;
                pnTable.Controls.Add(btn);
                btn.Click += Click_Event;
                xLocation += 120;
                if (xLocation >= 400)
                {
                    xLocation = 5;
                    yLocation += 120;
                }
            }
        }

        private void Click_Event(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name.ToString());
        }
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

            LoadDataTable();
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
