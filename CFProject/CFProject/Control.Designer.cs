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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.tabManagement = new TabControlH.TabControlH();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumber = new CFProject.TextBoxH();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStatus = new CFProject.TextBoxH();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCost = new CFProject.TextBoxH();
            this.label5 = new System.Windows.Forms.Label();
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
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.txtCat = new CFProject.TextBoxH();
            this.btnDeleteCategory = new CFProject.ButtonH();
            this.btnEditCategory = new CFProject.ButtonH();
            this.btnAddCategory = new CFProject.ButtonH();
            this.grvCategory = new System.Windows.Forms.DataGridView();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabReven = new System.Windows.Forms.TabPage();
            this.tabStatis = new System.Windows.Forms.TabPage();
            this.tabManagement.SuspendLayout();
            this.tabFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFood)).BeginInit();
            this.tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCategory)).BeginInit();
            this.SuspendLayout();
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
            this.tabManagement.Location = new System.Drawing.Point(1, 2);
            this.tabManagement.Name = "tabManagement";
            this.tabManagement.NonActiveTabEndColor = System.Drawing.Color.DodgerBlue;
            this.tabManagement.NonActiveTabStartColor = System.Drawing.Color.AntiqueWhite;
            this.tabManagement.Padding = new System.Drawing.Point(22, 4);
            this.tabManagement.SelectedIndex = 0;
            this.tabManagement.Size = new System.Drawing.Size(1044, 571);
            this.tabManagement.TabIndex = 0;
            this.tabManagement.TextColor = System.Drawing.Color.Black;
            this.tabManagement.Transparent1 = 255;
            this.tabManagement.Transparent2 = 255;
            // 
            // tabFood
            // 
            this.tabFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabFood.Controls.Add(this.button1);
            this.tabFood.Controls.Add(this.txtNumber);
            this.tabFood.Controls.Add(this.label7);
            this.tabFood.Controls.Add(this.txtStatus);
            this.tabFood.Controls.Add(this.label6);
            this.tabFood.Controls.Add(this.txtCost);
            this.tabFood.Controls.Add(this.label5);
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
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(1036, 538);
            this.tabFood.TabIndex = 0;
            this.tabFood.Text = "Món ăn";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(675, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(780, 298);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(212, 28);
            this.txtNumber.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(666, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Số lượng";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(780, 249);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(212, 28);
            this.txtStatus.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(666, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tình trạng";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(780, 198);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(212, 28);
            this.txtCost.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giá bán";
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
            this.btnSearch.Location = new System.Drawing.Point(925, 16);
            this.btnSearch.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnSearch.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnSearch.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnSearch.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShowButtontext = true;
            this.btnSearch.Size = new System.Drawing.Size(67, 33);
            this.btnSearch.StartColor = System.Drawing.Color.Blue;
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextLocation_X = 21;
            this.btnSearch.TextLocation_Y = 16;
            this.btnSearch.Transparent1 = 75;
            this.btnSearch.Transparent2 = 50;
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.btnDelete.Location = new System.Drawing.Point(397, 16);
            this.btnDelete.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnDelete.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnDelete.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnDelete.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShowButtontext = true;
            this.btnDelete.Size = new System.Drawing.Size(84, 33);
            this.btnDelete.StartColor = System.Drawing.Color.Blue;
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextLocation_X = 27;
            this.btnDelete.TextLocation_Y = 16;
            this.btnDelete.Transparent1 = 75;
            this.btnDelete.Transparent2 = 50;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(218, 16);
            this.btnEdit.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnEdit.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnEdit.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnEdit.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShowButtontext = true;
            this.btnEdit.Size = new System.Drawing.Size(84, 33);
            this.btnEdit.StartColor = System.Drawing.Color.Blue;
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextLocation_X = 27;
            this.btnEdit.TextLocation_Y = 16;
            this.btnEdit.Transparent1 = 75;
            this.btnEdit.Transparent2 = 50;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(59, 16);
            this.btnAdd.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnAdd.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnAdd.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnAdd.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShowButtontext = true;
            this.btnAdd.Size = new System.Drawing.Size(84, 33);
            this.btnAdd.StartColor = System.Drawing.Color.Blue;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextLocation_X = 27;
            this.btnAdd.TextLocation_Y = 16;
            this.btnAdd.Transparent1 = 75;
            this.btnAdd.Transparent2 = 50;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.LightCyan;
            this.cbCategory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 17;
            this.cbCategory.Items.AddRange(new object[] {
            "S",
            "1"});
            this.cbCategory.Location = new System.Drawing.Point(780, 346);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(212, 25);
            this.cbCategory.TabIndex = 14;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(780, 395);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(212, 133);
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(666, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hình ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(666, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phân loại";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(780, 147);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(212, 28);
            this.txtDescription.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mô tả";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(780, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 28);
            this.txtName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên sản phẩm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(663, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 33);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.Food_TextChanged);
            // 
            // grvFood
            // 
            this.grvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvFood.Location = new System.Drawing.Point(6, 65);
            this.grvFood.Name = "grvFood";
            this.grvFood.Size = new System.Drawing.Size(628, 465);
            this.grvFood.TabIndex = 3;
            this.grvFood.SelectionChanged += new System.EventHandler(this.grvFood_SelectionChanged);
            // 
            // tabCategory
            // 
            this.tabCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCategory.Controls.Add(this.txtCat);
            this.tabCategory.Controls.Add(this.btnDeleteCategory);
            this.tabCategory.Controls.Add(this.btnEditCategory);
            this.tabCategory.Controls.Add(this.btnAddCategory);
            this.tabCategory.Controls.Add(this.grvCategory);
            this.tabCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabCategory.Location = new System.Drawing.Point(4, 29);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(1036, 538);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Phân loại";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // txtCat
            // 
            this.txtCat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.Location = new System.Drawing.Point(448, 118);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(425, 40);
            this.txtCat.TabIndex = 4;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.BorderWidth = 2;
            this.btnDeleteCategory.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
            this.btnDeleteCategory.ButtonText = "";
            this.btnDeleteCategory.EndColor = System.Drawing.Color.Blue;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.GradientAngle = 90;
            this.btnDeleteCategory.Location = new System.Drawing.Point(783, 45);
            this.btnDeleteCategory.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnDeleteCategory.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnDeleteCategory.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnDeleteCategory.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.ShowButtontext = true;
            this.btnDeleteCategory.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteCategory.StartColor = System.Drawing.Color.Blue;
            this.btnDeleteCategory.TabIndex = 3;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.TextLocation_X = 29;
            this.btnDeleteCategory.TextLocation_Y = 17;
            this.btnDeleteCategory.Transparent1 = 75;
            this.btnDeleteCategory.Transparent2 = 50;
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnEditCategory.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditCategory.BorderWidth = 2;
            this.btnEditCategory.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
            this.btnEditCategory.ButtonText = "";
            this.btnEditCategory.EndColor = System.Drawing.Color.Blue;
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.GradientAngle = 90;
            this.btnEditCategory.Location = new System.Drawing.Point(609, 45);
            this.btnEditCategory.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnEditCategory.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnEditCategory.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnEditCategory.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.ShowButtontext = true;
            this.btnEditCategory.Size = new System.Drawing.Size(90, 36);
            this.btnEditCategory.StartColor = System.Drawing.Color.Blue;
            this.btnEditCategory.TabIndex = 2;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.TextLocation_X = 29;
            this.btnEditCategory.TextLocation_Y = 17;
            this.btnEditCategory.Transparent1 = 75;
            this.btnEditCategory.Transparent2 = 50;
            this.btnEditCategory.UseVisualStyleBackColor = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BorderWidth = 2;
            this.btnAddCategory.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
            this.btnAddCategory.ButtonText = "";
            this.btnAddCategory.EndColor = System.Drawing.Color.Blue;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.GradientAngle = 90;
            this.btnAddCategory.Location = new System.Drawing.Point(448, 45);
            this.btnAddCategory.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnAddCategory.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnAddCategory.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnAddCategory.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.ShowButtontext = true;
            this.btnAddCategory.Size = new System.Drawing.Size(90, 36);
            this.btnAddCategory.StartColor = System.Drawing.Color.Blue;
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.TextLocation_X = 29;
            this.btnAddCategory.TextLocation_Y = 17;
            this.btnAddCategory.Transparent1 = 75;
            this.btnAddCategory.Transparent2 = 50;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // grvCategory
            // 
            this.grvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCategory.Location = new System.Drawing.Point(25, 40);
            this.grvCategory.Name = "grvCategory";
            this.grvCategory.Size = new System.Drawing.Size(350, 469);
            this.grvCategory.TabIndex = 0;
            this.grvCategory.SelectionChanged += new System.EventHandler(this.grvCategory_SelectionChanged);
            // 
            // tabAccount
            // 
            this.tabAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabAccount.Location = new System.Drawing.Point(4, 29);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(1036, 538);
            this.tabAccount.TabIndex = 2;
            this.tabAccount.Text = "Tài khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // tabReven
            // 
            this.tabReven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabReven.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabReven.Location = new System.Drawing.Point(4, 29);
            this.tabReven.Name = "tabReven";
            this.tabReven.Padding = new System.Windows.Forms.Padding(3);
            this.tabReven.Size = new System.Drawing.Size(1036, 538);
            this.tabReven.TabIndex = 3;
            this.tabReven.Text = "Doanh thu";
            this.tabReven.UseVisualStyleBackColor = true;
            // 
            // tabStatis
            // 
            this.tabStatis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabStatis.Location = new System.Drawing.Point(4, 29);
            this.tabStatis.Name = "tabStatis";
            this.tabStatis.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatis.Size = new System.Drawing.Size(1036, 538);
            this.tabStatis.TabIndex = 4;
            this.tabStatis.Text = "Thống kê";
            this.tabStatis.UseVisualStyleBackColor = true;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 581);
            this.Controls.Add(this.tabManagement);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            this.tabManagement.ResumeLayout(false);
            this.tabFood.ResumeLayout(false);
            this.tabFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFood)).EndInit();
            this.tabCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCategory)).EndInit();
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
        private TextBoxH txtNumber;
        private System.Windows.Forms.Label label7;
        private TextBoxH txtStatus;
        private System.Windows.Forms.Label label6;
        private TextBoxH txtCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grvCategory;
        private ButtonH btnAddCategory;
        private ButtonH btnDeleteCategory;
        private ButtonH btnEditCategory;
        private TextBoxH txtCat;
    }
}