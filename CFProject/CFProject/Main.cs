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
            if (tk.TenDangNhap!="admin")
            {
                MessageBox.Show("Chỉ admin mới vào quản lí được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Control frmControl = new Control();
            this.Hide();
            frmControl.ShowDialog();
            this.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn đã đăng nhập rồi! Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngKsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register frm = new Register(tk);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        #endregion

        #region Table

        int tableIndex = 1;
        public void LoadDataTable()
        {
            pnTable.Controls.Clear();
            int xLocation = 10;
            int yLocation = 30;
            List<BanAn> lt;
            using (var db = new QLCafeEntities())
            {
                lt = db.BanAns.ToList();
            }

            foreach (var table in lt)
            {
                Button btn = new Button();
                btn.Name = string.Format("Button{0}", table.MaBan);
                btn.Text = table.TenBan+"\n\n"+table.TinhTrang;
                btn.Location = new System.Drawing.Point(xLocation, yLocation);
                btn.Size = new System.Drawing.Size(100, 100);
                if (table.TinhTrang=="Trống")
                {
                    btn.BackColor = Color.Brown;
                }
                else
                {
                    btn.BackColor = Color.Yellow;
                }
                pnTable.Controls.Add(btn);
                btn.Click += Click_Event;
                xLocation += 120;
                if (xLocation >= 400)
                {
                    xLocation = 5;
                    yLocation += 130;
                }
            }
        }

        private void Click_Event(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //MessageBox.Show(btn.Name.ToString());
            var name = btn.Name;
            int len = name.Length;
            var idx = name.IndexOf('n');
            tableIndex = int.Parse(name.Substring(idx + 1, len - 1 - idx));
            //MessageBox.Show(tableIndex.ToString());
            RefreshTableDetail();
        }

        private void RefreshTableDetail()
        {
            lblTableSelected.Text = "Bàn " + tableIndex.ToString();
            using (var db = new QLCafeEntities())
            {
                var lt = db.ChiTietBanAns.Where(t => t.MaBan == tableIndex).Select(t => new { t.MaSanPham, t.SanPham.TenSanPham, t.SoLuong, t.DonGia }).ToList();
                float TongTien = 0;
                foreach (var index in lt)
                {
                    TongTien += (float)index.DonGia * (float)index.SoLuong;
                }
                lblThanhToan.Text = TongTien.ToString() + " VNĐ";
                grvListTable.DataSource = lt;
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int idTableSwitch = int.Parse(cbSwitch.Text);
            if (idTableSwitch==tableIndex)
            {
                MessageBox.Show("Bàn chuyển đến không thể là bàn đang chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                using (var db = new QLCafeEntities())
                {
                    var table = db.BanAns.Find(idTableSwitch);
                    var t = db.BanAns.Find(tableIndex);
                    if (table.TinhTrang=="Có người")
                    {
                        MessageBox.Show("Bàn muốn chuyển đến đã có người ngồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    // Ngược lại
                    table.TinhTrang = "Có người"; // cập nhật bàn mới có người
                    t.TinhTrang = "Trống"; // cập nhật bàn cũ trống
                    foreach (var index in db.ChiTietBanAns) // chuyển món ăn bàn cũ sang bàn mới
                    {
                        if (index.MaBan==tableIndex)
                        {
                            index.MaBan = idTableSwitch;
                        }
                    }
                    db.SaveChanges();
                    // load lại dữ liệu
                    tableIndex = idTableSwitch;
                    LoadDataTable();
                    RefreshTableDetail();
                    MessageBox.Show("Đã chuyển đến bàn " + tableIndex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
        #endregion

        #region Checkout
        private void Main_Load(object sender, EventArgs e)
        {
            // load table
            LoadDataTable();

            // load menu món
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

            // load detail table
            RefreshTableDetail();
            lblTableSelected.Text = "Bàn " + tableIndex.ToString();
            grvListTable.Columns[0].HeaderText = "Mã";
            grvListTable.Columns[1].HeaderText = "Tên món";
            grvListTable.Columns[2].HeaderText = "Số lượng";
            grvListTable.Columns[3].HeaderText = "Đơn giá";
            grvListTable.Columns[0].Width = 50;
            grvListTable.Columns[1].Width = 250;
            grvListTable.Columns[2].Width = 100;
            grvListTable.Columns[3].Width = 120;
            grvListTable.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            grvListTable.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            grvListTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grvListTable.EnableHeadersVisualStyles = false;

            // load other data
            cbSwitch.DataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nameProduct = cbProduct.Text;
            var numProduct = txtNumber.Value;
            SanPham product;
            using (var db = new QLCafeEntities())
            {
                var lp = db.SanPhams.Where(p => p.TenSanPham == nameProduct).ToList();
                product = lp[0];
                //MessageBox.Show(product.TenSanPham);
                var table = db.BanAns.Find(tableIndex);
                table.TinhTrang = "Có người";
                db.ChiTietBanAns.Add(new ChiTietBanAn() { MaBan = tableIndex, MaSanPham = product.MaSanPham, SoLuong = (int?)numProduct, DonGia = product.GiaBan });
                db.SaveChanges();
            }
            RefreshTableDetail();
            LoadDataTable();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            using (var db = new QLCafeEntities())
            {
                // kiểm tra bàn?
                var tableSel = db.BanAns.Find(tableIndex);
                if (tableSel.TinhTrang=="Trống")
                {
                    MessageBox.Show("Bàn đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Tạo hóa đơn mới
                var bill = new HoaDon();
                bill.MaTaiKhoan = tk.MaTaiKhoan;
                var d = DateTime.Now;
                //MessageBox.Show(d.ToShortDateString());
                bill.NgayLapHoaDon = d;
                var len = lblThanhToan.Text.Length;
                var money = lblThanhToan.Text.Remove(len - 3, 3);
                //MessageBox.Show(money);
                bill.TongTien = float.Parse(money);
                db.HoaDons.Add(bill);
                db.SaveChanges();
                //MessageBox.Show(bill.MaHoaDon.ToString());

                // Tạo các chi tiết hóa đơn mới
                var tableDetail = db.ChiTietBanAns.Where(t => t.MaBan == tableIndex).ToList();
                foreach (var index in tableDetail)
                {
                    db.ChiTietHoaDons.Add(new ChiTietHoaDon() { MaSanPham = index.MaSanPham, MaHoaDon = bill.MaHoaDon,SoLuong=index.SoLuong,DonGia=index.DonGia });
                }
                db.SaveChanges();

                // Cập nhật lại bàn
                tableSel.TinhTrang = "Trống";
                var lt = db.ChiTietBanAns.Where(t => t.MaBan == tableIndex).ToList();
                foreach (var index in lt)
                {
                    var dt = db.ChiTietBanAns.Find(index.MaChiTietBanAn);
                    db.ChiTietBanAns.Remove(dt);
                }
                db.SaveChanges();
                LoadDataTable();
                RefreshTableDetail();
                MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        #endregion

        
    }
}
