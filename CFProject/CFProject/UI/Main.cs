using CFProject.DTO;
using CFProject.BUS;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selSkin = (int)comboBox1.SelectedIndex;
            switch (selSkin)
            {
                case 0:
                    this.BackColor = SystemColors.Control;
                    Color_Empty = Color.Brown;
                    Color_Full = Color.Yellow;
                    LoadDataTable();
                    break;
                case 1:
                    this.BackColor = Color.SkyBlue;
                    Color_Empty = Color.DarkSalmon;
                    Color_Full = Color.OrangeRed;
                    LoadDataTable();
                    break;
                case 2:
                    this.BackColor = SystemColors.ControlDark;
                    Color_Empty = Color.White;
                    Color_Full = Color.Pink;
                    LoadDataTable();
                    break;
                case 3:
                    this.BackColor = Color.IndianRed;
                    Color_Empty = Color.White;
                    Color_Full = Color.SkyBlue;
                    LoadDataTable();
                    break;
                case 4:
                    this.BackColor = Color.OrangeRed;
                    Color_Empty = Color.Violet;
                    Color_Full = Color.White;
                    LoadDataTable();
                    break;
                case 5:
                    this.BackColor = Color.Yellow;
                    Color_Empty = Color.Green;
                    Color_Full = Color.Blue;
                    LoadDataTable();
                    break;
            }
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

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account frm = new Account(tk);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        #endregion

        #region Table
        Color Color_Empty = Color.Brown;
        Color Color_Full = Color.Yellow;

        int tableIndex = 1;
        public void LoadDataTable()
        {
            pnTable.Controls.Clear(); // clear
            int xLocation = 10;
            int yLocation = 30;
            var lt = new MainBUS().getAllTable(); // get all table

            foreach (var table in lt)
            {
                Button btn = new Button();
                btn.Name = string.Format("Button{0}", table.MaBan);
                btn.Text = table.TenBan+"\n\n"+table.TinhTrang;
                btn.Location = new System.Drawing.Point(xLocation, yLocation);
                btn.Size = new System.Drawing.Size(100, 100);
                if (table.TinhTrang=="Trống")
                {
                    btn.BackColor = Color_Empty;
                }
                else
                {
                    btn.BackColor = Color_Full;
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
            var lt = new MainBUS().getTableDetailByID(tableIndex);
            float TongTien = 0;
            foreach (var index in lt)
            {
                TongTien += (float)index.DonGia * (float)index.SoLuong;
            }
            lblThanhToan.Text = TongTien.ToString() + " VNĐ";
            grvListTable.DataSource = lt;
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
                // Chuyển bàn
                var res = new MainBUS().switchTable(tableIndex,idTableSwitch);
                if (res == 1)
                {
                    MessageBox.Show("Bàn muốn chuyển đến đã có người ngồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                // load lại dữ liệu
                tableIndex = idTableSwitch;
                LoadDataTable();
                RefreshTableDetail();
                MessageBox.Show("Đã chuyển đến bàn " + tableIndex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Checkout
        private void Main_Load(object sender, EventArgs e)
        {
            // load table
            LoadDataTable();

            // load menu món
            var lc = new MainBUS().loadCategoryName();
            cbCategory.DataSource = lc;
            var cname = lc[0];
            var lp = new MainBUS().loadProductName(cname);
            cbProduct.DataSource = lp;

            // load detail table
            RefreshTableDetail();
            lblTableSelected.Text = "Bàn " + tableIndex.ToString();
            grvListTable.Columns[0].HeaderText = "Mã SP";
            grvListTable.Columns[1].HeaderText = "Tên món";
            grvListTable.Columns[2].HeaderText = "Số lượng";
            grvListTable.Columns[3].HeaderText = "Đơn giá";
            grvListTable.Columns[0].Width = 80;
            grvListTable.Columns[1].Width = 220;
            grvListTable.Columns[2].Width = 100;
            grvListTable.Columns[3].Width = 120;
            grvListTable.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            grvListTable.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            grvListTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grvListTable.EnableHeadersVisualStyles = false;

            // load id talbe of switch combobox
            var lt = new MainBUS().getAllIdTable();
            cbSwitch.DataSource = lt;

            // load skin background
            var l = new List<string>() { "Chuẩn", "Xanh", "Xám" ,"Hồng","Cam","Vàng"};
            comboBox1.DataSource = l;
            comboBox1.SelectedIndex = 0;
        }

        private void cbCatogory_TextChanged(object sender, EventArgs e)
        {
            var lp = new MainBUS().loadProductName(cbCategory.Text);
            cbProduct.DataSource = lp;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nameProduct = cbProduct.Text;
            var numProduct = txtNumber.Value;
            new MainBUS().updateTableDetail(tableIndex, nameProduct, (int)numProduct);
            RefreshTableDetail();
            LoadDataTable();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            using (var db = new QLCafeEntities())
            {
                // kiểm tra bàn?
                var check = new MainBUS().checkTableStatus(tableIndex);
                if (check==0)
                {
                    MessageBox.Show("Bàn đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Tạo hóa đơn mới & trả về mã hóa đơn
                var billToAdd = new HoaDon();
                billToAdd.MaTaiKhoan = tk.MaTaiKhoan;
                var d = DateTime.Now;
                //MessageBox.Show(d.ToShortDateString());
                billToAdd.NgayLapHoaDon = d;
                var txt = lblThanhToan.Text;
                var len = txt.Length;
                var money = txt.Remove(len - 3, 3);
                //MessageBox.Show(money);
                billToAdd.TongTien = float.Parse(money);
                var billId = new MainBUS().addBill(billToAdd);

                // Tạo các chi tiết hóa đơn mới
                new MainBUS().createBillDetail(tableIndex, billId);

                // Cập nhật lại bàn
                new MainBUS().updateTable(tableIndex, "Trống");

                // Xóa các chi tiết bàn ăn đã thanh toán
                new MainBUS().RemoveTableDetail(tableIndex);

                // Refresh data
                LoadDataTable();
                RefreshTableDetail();

                // Show bill
                MessageBox.Show("Tổng tiền bàn này là : " + txt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Detail frm = new Detail(billId);
                frm.ShowDialog();
            }
        }
        #endregion

        
    }
}
