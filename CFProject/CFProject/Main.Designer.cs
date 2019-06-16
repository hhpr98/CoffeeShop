namespace CFProject
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTable = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.NumericUpDown();
            this.grvListTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNameAcc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.lblTableSelected = new System.Windows.Forms.Label();
            this.cbSwitch = new CFProject.ComboBoxH();
            this.btnBill = new CFProject.ButtonH();
            this.btnAdd = new CFProject.ButtonH();
            this.cbProduct = new CFProject.ComboBoxH();
            this.cbCategory = new CFProject.ComboBoxH();
            this.btnSwitch = new CFProject.ButtonH();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            this.quảnLíToolStripMenuItem.Click += new System.EventHandler(this.quảnLíToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngKsToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngKsToolStripMenuItem
            // 
            this.đăngKsToolStripMenuItem.Name = "đăngKsToolStripMenuItem";
            this.đăngKsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.đăngKsToolStripMenuItem.Text = "Đăng kí";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thôngTinToolStripMenuItem.Text = "Tùy chọn";
            // 
            // thôngTinToolStripMenuItem1
            // 
            this.thôngTinToolStripMenuItem1.Name = "thôngTinToolStripMenuItem1";
            this.thôngTinToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.thôngTinToolStripMenuItem1.Text = "Thông tin";
            this.thôngTinToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinToolStripMenuItem1_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // pnTable
            // 
            this.pnTable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnTable.Location = new System.Drawing.Point(11, 73);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(486, 434);
            this.pnTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên món :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(896, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng :";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.LightCyan;
            this.txtNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(977, 75);
            this.txtNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(52, 26);
            this.txtNumber.TabIndex = 9;
            this.txtNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grvListTable
            // 
            this.grvListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvListTable.Location = new System.Drawing.Point(557, 132);
            this.grvListTable.Name = "grvListTable";
            this.grvListTable.Size = new System.Drawing.Size(562, 375);
            this.grvListTable.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Xin chào,";
            // 
            // lblNameAcc
            // 
            this.lblNameAcc.AutoSize = true;
            this.lblNameAcc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAcc.ForeColor = System.Drawing.Color.Red;
            this.lblNameAcc.Location = new System.Drawing.Point(99, 37);
            this.lblNameAcc.Name = "lblNameAcc";
            this.lblNameAcc.Size = new System.Drawing.Size(130, 16);
            this.lblNameAcc.TabIndex = 18;
            this.lblNameAcc.Text = "<Chưa đăng nhập>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(786, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng cộng : ";
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.ForeColor = System.Drawing.Color.Red;
            this.lblThanhToan.Location = new System.Drawing.Point(884, 533);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(46, 16);
            this.lblThanhToan.TabIndex = 20;
            this.lblThanhToan.Text = "0 VNĐ";
            // 
            // lblTableSelected
            // 
            this.lblTableSelected.AutoSize = true;
            this.lblTableSelected.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableSelected.ForeColor = System.Drawing.Color.Blue;
            this.lblTableSelected.Location = new System.Drawing.Point(12, 527);
            this.lblTableSelected.Name = "lblTableSelected";
            this.lblTableSelected.Size = new System.Drawing.Size(44, 16);
            this.lblTableSelected.TabIndex = 21;
            this.lblTableSelected.Text = "Bàn 0";
            // 
            // cbSwitch
            // 
            this.cbSwitch.BackColor = System.Drawing.Color.LightCyan;
            this.cbSwitch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSwitch.FormattingEnabled = true;
            this.cbSwitch.ItemHeight = 20;
            this.cbSwitch.Location = new System.Drawing.Point(341, 521);
            this.cbSwitch.Name = "cbSwitch";
            this.cbSwitch.Size = new System.Drawing.Size(45, 28);
            this.cbSwitch.TabIndex = 15;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BorderColor = System.Drawing.Color.Transparent;
            this.btnBill.BorderWidth = 2;
            this.btnBill.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
            this.btnBill.ButtonText = "";
            this.btnBill.EndColor = System.Drawing.Color.Orange;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.GradientAngle = 90;
            this.btnBill.Location = new System.Drawing.Point(1027, 527);
            this.btnBill.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnBill.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnBill.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnBill.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnBill.Name = "btnBill";
            this.btnBill.ShowButtontext = true;
            this.btnBill.Size = new System.Drawing.Size(92, 28);
            this.btnBill.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBill.TabIndex = 12;
            this.btnBill.Text = "Thanh toán";
            this.btnBill.TextLocation_X = 29;
            this.btnBill.TextLocation_Y = 14;
            this.btnBill.Transparent1 = 75;
            this.btnBill.Transparent2 = 50;
            this.btnBill.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderWidth = 2;
            this.btnAdd.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
            this.btnAdd.ButtonText = "";
            this.btnAdd.EndColor = System.Drawing.Color.Orange;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.GradientAngle = 90;
            this.btnAdd.Location = new System.Drawing.Point(1052, 73);
            this.btnAdd.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnAdd.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnAdd.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnAdd.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShowButtontext = true;
            this.btnAdd.Size = new System.Drawing.Size(67, 28);
            this.btnAdd.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextLocation_X = 21;
            this.btnAdd.TextLocation_Y = 14;
            this.btnAdd.Transparent1 = 75;
            this.btnAdd.Transparent2 = 50;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbProduct
            // 
            this.cbProduct.BackColor = System.Drawing.Color.LightCyan;
            this.cbProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.ItemHeight = 18;
            this.cbProduct.Location = new System.Drawing.Point(769, 73);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(121, 26);
            this.cbProduct.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.LightCyan;
            this.cbCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 18;
            this.cbCategory.Location = new System.Drawing.Point(555, 73);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 26);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.TextChanged += new System.EventHandler(this.cbCatogory_TextChanged);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSwitch.BorderWidth = 2;
            this.btnSwitch.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
            this.btnSwitch.ButtonText = "";
            this.btnSwitch.EndColor = System.Drawing.Color.Orange;
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.GradientAngle = 90;
            this.btnSwitch.Location = new System.Drawing.Point(405, 521);
            this.btnSwitch.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnSwitch.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnSwitch.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnSwitch.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.ShowButtontext = true;
            this.btnSwitch.Size = new System.Drawing.Size(92, 28);
            this.btnSwitch.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSwitch.TabIndex = 22;
            this.btnSwitch.Text = "Chuyển bàn";
            this.btnSwitch.TextLocation_X = 29;
            this.btnSwitch.TextLocation_Y = 14;
            this.btnSwitch.Transparent1 = 75;
            this.btnSwitch.Transparent2 = 50;
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 563);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.lblTableSelected);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNameAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSwitch);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.grvListTable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.pnTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cafe Management v1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel pnTable;
        private ComboBoxH cbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComboBoxH cbProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtNumber;
        private ButtonH btnAdd;
        private System.Windows.Forms.DataGridView grvListTable;
        private ButtonH btnBill;
        private ComboBoxH cbSwitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNameAcc;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label lblTableSelected;
        private ButtonH btnSwitch;
    }
}

