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
            #region TabFood
            using (var db = new QLCafeEntities())
            {
                var l = db.SanPhams.Select(x => new { x.MaSanPham, x.TenSanPham, x.MoTa, x.GiaBan, x.SoLuong }).ToList();
                grvFood.DataSource = l;
            }
            grvFood.Columns[0].HeaderText = "Mã";
            grvFood.Columns[1].HeaderText = "Tên SP";
            grvFood.Columns[2].HeaderText = "Mô tả";
            grvFood.Columns[3].HeaderText = "Giá bán";
            grvFood.Columns[4].HeaderText = "Số lượng";
            grvFood.Columns[0].Width = 50;
            grvFood.Columns[1].Width = 150;
            grvFood.Columns[2].Width = 200;
            grvFood.Columns[3].Width = 100;
            grvFood.Columns[4].Width = 100;
            #endregion

        }

        #region FoodEvent
        int selIndex = -1;
        String tempImage = "";

        private void Food_TextChanged(object sender, EventArgs e)
        {
            using (var db = new QLCafeEntities())
            {
                var content = txtSearch.Text.ToLower();
                if (content == "")
                {
                    var l = db.SanPhams.Where(p => p.isDeleted == 0).Select(x => new { x.MaSanPham, x.TenSanPham, x.MoTa, x.GiaBan, x.SoLuong }).ToList();
                    grvFood.DataSource = l;
                }
                else
                {
                    var l = db.SanPhams.Where(p => p.TenSanPham.Contains(content) && p.isDeleted == 0).Select(x => new { x.MaSanPham, x.TenSanPham, x.MoTa, x.GiaBan, x.SoLuong }).ToList();
                    grvFood.DataSource = l;
                }
            }
        }

        private void grvFood_SelectionChanged(object sender, EventArgs e)
        {
            var id = int.Parse(grvFood.CurrentRow.Cells[0].Value.ToString());
            if (id == selIndex) return;
            selIndex = id;
            //MessageBox.Show(selIndex.ToString());
            SanPham itemSelected;
            List<NhomSanPham> lc;
            using (var db = new QLCafeEntities())
            {
                itemSelected = db.SanPhams.Find(selIndex);
                lc = db.NhomSanPhams.ToList();
            }
            txtName.Text = itemSelected.TenSanPham;
            txtDescription.Text = itemSelected.MoTa;
            txtCost.Text = itemSelected.GiaBan.ToString();
            txtStatus.Text = itemSelected.TinhTrang;
            txtNumber.Text = itemSelected.SoLuong.ToString();
            cbCategory.DataSource = lc.Select(x=>x.TenNhom).ToList();
            var i = -1;
            foreach (var index in lc)
            {
                i++;
                if (index.TenNhom==itemSelected.NhomSanPham.TenNhom)
                {
                    break;
                }
            }
            cbCategory.SelectedIndex = i;
            tempImage = itemSelected.HinhAnh;
            try
            {
                pbImage.Image = new Bitmap(tempImage);
            }
            catch (Exception ex)
            {
                pbImage.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\git\CoffeeShop\HinhAnh";
            dlg.Filter = "JPG Image files (*.jpg)|*.jpg|PNG Image files (*.png)|*.png|BMP Image files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tempImage = dlg.FileName;
                //FileNameLabel.Content = selectedFileName;
                try
                {
                    pbImage.Image = new Bitmap(tempImage);
                }
                catch (Exception ex)
                {
                    pbImage.Image = null;
                }
            }
        }
        #endregion


    }
}
