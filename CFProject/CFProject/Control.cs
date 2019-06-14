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
            tabManagement.SelectedIndex = 0;

            #region TabFoodProperties
            RefreshFoodData();
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

            #region TabCategoryProperties
            RefreshCategoryData();
            grvCategory.Columns[0].HeaderText = "Mã nhóm";
            grvCategory.Columns[1].HeaderText = "Tên nhóm sản phẩm";
            grvCategory.Columns[0].Width = 100;
            grvCategory.Columns[1].Width = 207;
			#endregion


			#region TabAccountProperties
			RefreshAccountData();
			
			grvAccount.Columns[0].HeaderText = "Mã tài khoản";
			grvAccount.Columns[1].HeaderText = "Tên đăng nhập";

			grvAccount.Columns[2].HeaderText = "Mật khẩu";
			//grvAccount.Columns[3].HeaderText = "Mã NQL";
			grvAccount.Columns[3].HeaderText = "Họ tên NQL";
			grvAccount.Columns[4].HeaderText = "CMND";
			grvAccount.Columns[5].HeaderText = "Địa chỉ";
			grvAccount.Columns[6].HeaderText = "SĐT";
			grvAccount.Columns[0].Width = 100;
			grvAccount.Columns[1].Width = 100;
			grvAccount.Columns[2].Width = 100;
			grvAccount.Columns[3].Width = 120;
			grvAccount.Columns[4].Width = 80;
			grvAccount.Columns[5].Width = 80;
			grvAccount.Columns[6].Width = 80;
			#endregion




		}

		#region FoodEvent
		int selIndex = -1;
        String tempImage = "";

        private void RefreshFoodData()
        {
            using (var db = new QLCafeEntities())
            {
                var l = db.SanPhams.Where(p => p.isDeleted == 0).Select(x => new { x.MaSanPham, x.TenSanPham, x.MoTa, x.GiaBan, x.SoLuong }).ToList();
                grvFood.DataSource = l;
            }
        }

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
                lc = db.NhomSanPhams.Where(p=>p.isDeleted==0).ToList();
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
			//dlg.DefaultExt = "png";
			dlg.Filter = "Image File(*.jpg *.png *.bmp *.gif *.ico)|*.jpg;*.png;*.bmp;*.gif;*.ico|JPG Image files (*.jpg)|*.jpg|PNG Image files (*.png)|*.png|BMP Image files (*.bmp)|*.bmp|All Files (*.*)|*.*";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(grvFood.CurrentRow.Cells[0].Value.ToString());
            var res = MessageBox.Show(String.Format("Bạn chắc chắn muốn xóa sản phẩm id = {0} ?", id),"Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res==DialogResult.OK)
            {
                using (var db = new QLCafeEntities())
                {
                    var product = db.SanPhams.Find(id);
                    product.isDeleted = 1;
                    db.SaveChanges();
                }
                RefreshFoodData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = int.Parse(grvFood.CurrentRow.Cells[0].Value.ToString());
            using (var db = new QLCafeEntities())
            {
                var product = db.SanPhams.Find(id);
                product.TenSanPham = txtName.Text;
                product.MoTa = txtDescription.Text;
                product.GiaBan = int.Parse(txtCost.Text);
                product.TinhTrang = txtStatus.Text;
                product.SoLuong = int.Parse(txtNumber.Text);
                product.HinhAnh = tempImage;
                var lc = db.NhomSanPhams.Where(p => p.isDeleted == 0).ToList();
                var i = cbCategory.SelectedIndex;
                product.NhomSanPham = lc[i];
                db.SaveChanges();
            }
            MessageBox.Show(String.Format("Chỉnh sửa thành công sản phẩm id = {0} !", id), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshFoodData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new QLCafeEntities())
            {
                // check tên sản phẩm đã tồn tại?
                var name = txtName.Text;
                var listName = db.SanPhams.Where(p => p.isDeleted == 0).Select(p => p.TenSanPham).ToList();
                if (listName.Contains(name))
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // thêm sản phẩm mới
                SanPham product = new SanPham();
                product.TenSanPham = txtName.Text;
                product.MoTa = txtDescription.Text;
                product.GiaBan = int.Parse(txtCost.Text);
                product.TinhTrang = txtStatus.Text;
                product.SoLuong = int.Parse(txtNumber.Text);
                product.HinhAnh = tempImage;
                var lc = db.NhomSanPhams.Where(p => p.isDeleted == 0).ToList();
                var i = cbCategory.SelectedIndex;
                product.NhomSanPham = lc[i];
                product.isDeleted = 0;
                db.SanPhams.Add(product);
                db.SaveChanges();
            }
            MessageBox.Show(String.Format("Thêm thành công sản phẩm \"{0}\" !", txtName.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshFoodData();
        }

		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		#endregion

		#region CategoryEvent
		int catID = -1;
        private void RefreshCategoryData()
        {
            using (var db = new QLCafeEntities())
            {
                var l = db.NhomSanPhams.Where(c => c.isDeleted == 0).Select(c => new { c.MaNhom, c.TenNhom }).ToList();
                grvCategory.DataSource = l;
            }
        }

        private void grvCategory_SelectionChanged(object sender, EventArgs e)
        {
            var id = int.Parse(grvCategory.CurrentRow.Cells[0].Value.ToString());
            if (id == catID) return;
            catID = id;
            using (var db = new QLCafeEntities())
            {
                txtCat.Text = db.NhomSanPhams.Find(catID).TenNhom;
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var nameCat = txtCat.Text;
            using (var db = new QLCafeEntities())
            {
                var lc = db.NhomSanPhams.Select(c => c.TenNhom).ToList();
                if (lc.Contains(nameCat))
                {
                    MessageBox.Show("Tên nhóm sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.NhomSanPhams.Add(new NhomSanPham() { TenNhom = nameCat, isDeleted = 0 });
                db.SaveChanges();
            }
            MessageBox.Show(String.Format("Thêm thành công loại sản phẩm \"{0}\" !", txtCat.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshCategoryData();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            var id = int.Parse(grvCategory.CurrentRow.Cells[0].Value.ToString());
            using (var db = new QLCafeEntities())
            {
                var catItem = db.NhomSanPhams.Find(id);
                catItem.TenNhom = txtCat.Text;
                db.SaveChanges();
            }
            MessageBox.Show(String.Format("Chỉnh sửa thành công nhóm sản phẩm id = {0} !", id), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshCategoryData();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var id = int.Parse(grvCategory.CurrentRow.Cells[0].Value.ToString());
            var res = MessageBox.Show(String.Format("Bạn chắc chắn muốn xóa nhóm sản phẩm id = {0} ?", id), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                using (var db = new QLCafeEntities())
                {
                    var catItem = db.NhomSanPhams.Find(id);
                    catItem.isDeleted = 1;
                    db.SaveChanges();
                }
                RefreshCategoryData();
            }
        }
		#endregion

		#region AccountEvent
		private void RefreshAccountData()
		{
			using (var db = new QLCafeEntities())
			{
				var nql = db.NguoiQuanLis.ToList();
				foreach(var item in nql)
				{
					var l = db.TaiKhoans.Where(c => c.isDeleted == 0 && c.MaNQL==item.MaNQL ).Select(c => new { c.MaTaiKhoan, c.TenDangNhap, c.MatKhau, item.HoTen,item.CMND
						,item.DiaChi,item.SoDienThoai }).ToList();
					grvAccount.DataSource = l;
				}

				
			}
		
		}

		private void grvAccount_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex == 2 && e.Value != null)
			{
				e.Value = new String('*', e.Value.ToString().Length);
			}
		}


		private void grvAccount_SelectionChanged(object sender, EventArgs e)
		{
			var id = int.Parse(grvAccount.CurrentRow.Cells[0].Value.ToString());
			if(id==selIndex)return;
			selIndex = id;
			TaiKhoan taikhoanSelected;
			List<NguoiQuanLi> nql;
			using (var db = new QLCafeEntities())
			{
				taikhoanSelected = db.TaiKhoans.Find(selIndex);
				nql = db.NguoiQuanLis.ToList();

			}
			txtUser.Text = taikhoanSelected.TenDangNhap;
			txtPassword.Text = taikhoanSelected.MatKhau;
			cmbMaNQL.DataSource = nql.Select(x => x.MaNQL).ToList();
			var k = -1;
			foreach(var index in nql)
			{
				k++;
				if (index.MaNQL == taikhoanSelected.MaNQL)
				{
					break;
				}
			}
			cmbMaNQL.SelectedIndex = k;
		}
		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			using (var db= new QLCafeEntities())
			{
				//kiem tra xem tai khoan da ton tai
				var user = txtUser.Text;
				var listUser = db.TaiKhoans.Where(p => p.isDeleted == 0).Select(p => p.TenDangNhap).ToList();
				if (listUser.Contains(user))
				{
					MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				//thêm tai khoan moi
				TaiKhoan tk = new TaiKhoan();
				tk.TenDangNhap = txtUser.Text;
				tk.MatKhau = txtPassword.Text;
				var li = db.NguoiQuanLis.Where(p=>p.HoTen!=null).ToList();
				var t = cmbMaNQL.SelectedIndex;
				tk.MaNQL = li[t].MaNQL;
				tk.isDeleted = 0;
				db.TaiKhoans.Add(tk);
				db.SaveChanges();
				
			}
			MessageBox.Show(String.Format("Thêm thành công tài khoản \"{0}\"!", txtUser.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			RefreshAccountData();
		}
		private void btnEditAccount_Click(object sender, EventArgs e)
		{
			var id = int.Parse(grvAccount.CurrentRow.Cells[0].Value.ToString());
			using (var db = new QLCafeEntities())
			{
				var tkhoan = db.TaiKhoans.Find(id);
				tkhoan.TenDangNhap = txtUser.Text;
				tkhoan.MatKhau = txtPassword.Text;
				var li = db.NguoiQuanLis.Where(p => p.HoTen != null).ToList();
				var t = cmbMaNQL.SelectedIndex;
				tkhoan.MaNQL = li[t].MaNQL;
				db.SaveChanges();

			}
			MessageBox.Show(String.Format("Chỉnh sửa thành công tài khoản id = {0} !", id), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			RefreshAccountData();
		}
		#endregion

		#region RevenEvent
		#endregion

		#region StatisEvent
		#endregion

		private void tabManagement_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
