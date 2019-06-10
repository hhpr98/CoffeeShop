namespace CFProject
{
    partial class Control
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
			this.tabCategory = new System.Windows.Forms.TabPage();
			this.tabFood = new System.Windows.Forms.TabPage();
			this.btnSearch = new CFProject.ButtonH();
			this.btnDelete = new CFProject.ButtonH();
			this.btnEdit = new CFProject.ButtonH();
			this.btnAdd = new CFProject.ButtonH();
			this.cbCategory = new CFProject.ComboBoxH();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescription = new CFProject.TextBoxH();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new CFProject.TextBoxH();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new CFProject.TextBoxH();
			this.grvFood = new System.Windows.Forms.DataGridView();
			this.tabManagement = new TabControlH.TabControlH();
			this.tabAccount = new System.Windows.Forms.TabPage();
			this.tabReven = new System.Windows.Forms.TabPage();
			this.tabStatis = new System.Windows.Forms.TabPage();
			this.tabFood.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvFood)).BeginInit();
			this.tabManagement.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCategory
			// 
			this.tabCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabCategory.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabCategory.Location = new System.Drawing.Point(4, 29);
			this.tabCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabCategory.Name = "tabCategory";
			this.tabCategory.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabCategory.Size = new System.Drawing.Size(2080, 1065);
			this.tabCategory.TabIndex = 1;
			this.tabCategory.Text = "Phân loại";
			this.tabCategory.UseVisualStyleBackColor = true;
			// 
			// tabFood
			// 
			this.tabFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabFood.Controls.Add(this.btnSearch);
			this.tabFood.Controls.Add(this.btnDelete);
			this.tabFood.Controls.Add(this.btnEdit);
			this.tabFood.Controls.Add(this.btnAdd);
			this.tabFood.Controls.Add(this.cbCategory);
			this.tabFood.Controls.Add(this.pbImage);
			this.tabFood.Controls.Add(this.label4);
			this.tabFood.Controls.Add(this.label3);
			this.tabFood.Controls.Add(this.txtDescription);
			this.tabFood.Controls.Add(this.label2);
			this.tabFood.Controls.Add(this.txtName);
			this.tabFood.Controls.Add(this.label1);
			this.tabFood.Controls.Add(this.txtSearch);
			this.tabFood.Controls.Add(this.grvFood);
			this.tabFood.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabFood.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabFood.Location = new System.Drawing.Point(4, 29);
			this.tabFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabFood.Name = "tabFood";
			this.tabFood.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabFood.Size = new System.Drawing.Size(2080, 1065);
			this.tabFood.TabIndex = 0;
			this.tabFood.Text = "Món ăn";
			this.tabFood.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Transparent;
			this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
			this.btnSearch.BorderWidth = 2;
			this.btnSearch.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
			this.btnSearch.ButtonText = "";
			this.btnSearch.EndColor = System.Drawing.Color.Blue;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.GradientAngle = 90;
			this.btnSearch.Location = new System.Drawing.Point(1850, 31);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnSearch.MouseClickColor1 = System.Drawing.Color.Yellow;
			this.btnSearch.MouseClickColor2 = System.Drawing.Color.Red;
			this.btnSearch.MouseHoverColor1 = System.Drawing.Color.Turquoise;
			this.btnSearch.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.ShowButtontext = true;
			this.btnSearch.Size = new System.Drawing.Size(134, 63);
			this.btnSearch.StartColor = System.Drawing.Color.Blue;
			this.btnSearch.TabIndex = 18;
			this.btnSearch.Text = "Tìm";
			this.btnSearch.TextLocation_X = 43;
			this.btnSearch.TextLocation_Y = 26;
			this.btnSearch.Transparent1 = 75;
			this.btnSearch.Transparent2 = 50;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
			this.btnDelete.BorderWidth = 2;
			this.btnDelete.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
			this.btnDelete.ButtonText = "";
			this.btnDelete.EndColor = System.Drawing.Color.Blue;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.GradientAngle = 90;
			this.btnDelete.Location = new System.Drawing.Point(768, 31);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnDelete.MouseClickColor1 = System.Drawing.Color.Yellow;
			this.btnDelete.MouseClickColor2 = System.Drawing.Color.Red;
			this.btnDelete.MouseHoverColor1 = System.Drawing.Color.Turquoise;
			this.btnDelete.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.ShowButtontext = true;
			this.btnDelete.Size = new System.Drawing.Size(168, 63);
			this.btnDelete.StartColor = System.Drawing.Color.Blue;
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.TextLocation_X = 55;
			this.btnDelete.TextLocation_Y = 26;
			this.btnDelete.Transparent1 = 75;
			this.btnDelete.Transparent2 = 50;
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Transparent;
			this.btnEdit.BorderColor = System.Drawing.Color.Transparent;
			this.btnEdit.BorderWidth = 2;
			this.btnEdit.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
			this.btnEdit.ButtonText = "";
			this.btnEdit.EndColor = System.Drawing.Color.Blue;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.GradientAngle = 90;
			this.btnEdit.Location = new System.Drawing.Point(426, 31);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnEdit.MouseClickColor1 = System.Drawing.Color.Yellow;
			this.btnEdit.MouseClickColor2 = System.Drawing.Color.Red;
			this.btnEdit.MouseHoverColor1 = System.Drawing.Color.Turquoise;
			this.btnEdit.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.ShowButtontext = true;
			this.btnEdit.Size = new System.Drawing.Size(168, 63);
			this.btnEdit.StartColor = System.Drawing.Color.Blue;
			this.btnEdit.TabIndex = 16;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextLocation_X = 55;
			this.btnEdit.TextLocation_Y = 26;
			this.btnEdit.Transparent1 = 75;
			this.btnEdit.Transparent2 = 50;
			this.btnEdit.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Transparent;
			this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
			this.btnAdd.BorderWidth = 2;
			this.btnAdd.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
			this.btnAdd.ButtonText = "";
			this.btnAdd.EndColor = System.Drawing.Color.Blue;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.GradientAngle = 90;
			this.btnAdd.Location = new System.Drawing.Point(118, 31);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnAdd.MouseClickColor1 = System.Drawing.Color.Yellow;
			this.btnAdd.MouseClickColor2 = System.Drawing.Color.Red;
			this.btnAdd.MouseHoverColor1 = System.Drawing.Color.Turquoise;
			this.btnAdd.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.ShowButtontext = true;
			this.btnAdd.Size = new System.Drawing.Size(168, 63);
			this.btnAdd.StartColor = System.Drawing.Color.Blue;
			this.btnAdd.TabIndex = 15;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.TextLocation_X = 55;
			this.btnAdd.TextLocation_Y = 26;
			this.btnAdd.Transparent1 = 75;
			this.btnAdd.Transparent2 = 50;
			this.btnAdd.UseVisualStyleBackColor = false;
			// 
			// cbCategory
			// 
			this.cbCategory.BackColor = System.Drawing.Color.LightCyan;
			this.cbCategory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCategory.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.ItemHeight = 35;
			this.cbCategory.Items.AddRange(new object[] {
            "S",
            "1"});
			this.cbCategory.Location = new System.Drawing.Point(1560, 379);
			this.cbCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(420, 43);
			this.cbCategory.TabIndex = 14;
			// 
			// pbImage
			// 
			this.pbImage.Location = new System.Drawing.Point(1560, 485);
			this.pbImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(424, 256);
			this.pbImage.TabIndex = 13;
			this.pbImage.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(1332, 485);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 30);
			this.label4.TabIndex = 12;
			this.label4.Text = "Hình ảnh";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1332, 390);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 30);
			this.label3.TabIndex = 10;
			this.label3.Text = "Phân loại";
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(1560, 283);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(420, 50);
			this.txtDescription.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1332, 294);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 30);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mô tả";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(1560, 188);
			this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(420, 50);
			this.txtName.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1332, 198);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tên món";
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(1326, 31);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(478, 60);
			this.txtSearch.TabIndex = 4;
			// 
			// grvFood
			// 
			this.grvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvFood.Location = new System.Drawing.Point(12, 125);
			this.grvFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.grvFood.Name = "grvFood";
			this.grvFood.Size = new System.Drawing.Size(1256, 894);
			this.grvFood.TabIndex = 3;
			// 
			// tabManagement
			// 
			this.tabManagement.ActiveTabEndColor = System.Drawing.Color.DarkOrange;
			this.tabManagement.ActiveTabStartColor = System.Drawing.Color.Yellow;
			this.tabManagement.CloseButtonColor = System.Drawing.Color.Red;
			this.tabManagement.Controls.Add(this.tabFood);
			this.tabManagement.Controls.Add(this.tabCategory);
			this.tabManagement.Controls.Add(this.tabAccount);
			this.tabManagement.Controls.Add(this.tabReven);
			this.tabManagement.Controls.Add(this.tabStatis);
			this.tabManagement.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabManagement.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabManagement.GradientAngle = 90;
			this.tabManagement.ItemSize = new System.Drawing.Size(80, 25);
			this.tabManagement.Location = new System.Drawing.Point(2, 4);
			this.tabManagement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabManagement.Name = "tabManagement";
			this.tabManagement.NonActiveTabEndColor = System.Drawing.Color.Blue;
			this.tabManagement.NonActiveTabStartColor = System.Drawing.Color.AntiqueWhite;
			this.tabManagement.Padding = new System.Drawing.Point(22, 4);
			this.tabManagement.SelectedIndex = 0;
			this.tabManagement.Size = new System.Drawing.Size(2088, 1098);
			this.tabManagement.TabIndex = 0;
			this.tabManagement.TextColor = System.Drawing.Color.Black;
			this.tabManagement.Transparent1 = 255;
			this.tabManagement.Transparent2 = 255;
			// 
			// tabAccount
			// 
			this.tabAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabAccount.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabAccount.Location = new System.Drawing.Point(4, 29);
			this.tabAccount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabAccount.Name = "tabAccount";
			this.tabAccount.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabAccount.Size = new System.Drawing.Size(2080, 1065);
			this.tabAccount.TabIndex = 2;
			this.tabAccount.Text = "Tài khoản";
			this.tabAccount.UseVisualStyleBackColor = true;
			// 
			// tabReven
			// 
			this.tabReven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabReven.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabReven.Location = new System.Drawing.Point(4, 29);
			this.tabReven.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabReven.Name = "tabReven";
			this.tabReven.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabReven.Size = new System.Drawing.Size(2080, 1065);
			this.tabReven.TabIndex = 3;
			this.tabReven.Text = "Doanh thu";
			this.tabReven.UseVisualStyleBackColor = true;
			// 
			// tabStatis
			// 
			this.tabStatis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabStatis.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabStatis.Location = new System.Drawing.Point(4, 29);
			this.tabStatis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabStatis.Name = "tabStatis";
			this.tabStatis.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.tabStatis.Size = new System.Drawing.Size(2080, 1065);
			this.tabStatis.TabIndex = 4;
			this.tabStatis.Text = "Thống kê";
			this.tabStatis.UseVisualStyleBackColor = true;
			// 
			// Control
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2114, 1125);
			this.Controls.Add(this.tabManagement);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Control";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control";
			this.Load += new System.EventHandler(this.Control_Load);
			this.tabFood.ResumeLayout(false);
			this.tabFood.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvFood)).EndInit();
			this.tabManagement.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.TabPage tabFood;
        private TabControlH.TabControlH tabManagement;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabReven;
        private System.Windows.Forms.TabPage tabStatis;
        private System.Windows.Forms.DataGridView grvFood;
        private TextBoxH txtSearch;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private TextBoxH txtDescription;
        private System.Windows.Forms.Label label2;
        private TextBoxH txtName;
        private System.Windows.Forms.Label label1;
        private ComboBoxH cbCategory;
        private ButtonH btnSearch;
        private ButtonH btnDelete;
        private ButtonH btnEdit;
        private ButtonH btnAdd;
    }
}