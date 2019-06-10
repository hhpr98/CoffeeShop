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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void Control_Load(object sender, EventArgs e)
        {
            using (var db = new QLCafeEntities())
            {
                var l = db.SanPhams.Select(x => new { x.MaSanPham, x.TenSanPham, x.MoTa, x.GiaBan, x.TinhTrang, x.SoLuong, x.HinhAnh, x.MaNhom }).ToList();
                grvFood.DataSource = l;
            }
            grvFood.Columns[0].HeaderText = "Mã";
            grvFood.Columns[1].HeaderText = "Tên SP";
            grvFood.Columns[2].HeaderText = "Mô tả";
            grvFood.Columns[3].HeaderText = "Giá bán";
            grvFood.Columns[4].HeaderText = "Tình trạng";
            grvFood.Columns[5].HeaderText = "Số lượng";
            grvFood.Columns[6].HeaderText = "Hình ảnh";
            grvFood.Columns[7].HeaderText = "Mã nhóm";
            grvFood.Columns[0].Width = 30;
            grvFood.Columns[1].Width = 100;
            grvFood.Columns[2].Width = 100;
            grvFood.Columns[3].Width = 80;
            grvFood.Columns[4].Width = 100;
            grvFood.Columns[5].Width = 100;
            grvFood.Columns[6].Width = 100;
            grvFood.Columns[7].Width = 100;
        }

    }
}
