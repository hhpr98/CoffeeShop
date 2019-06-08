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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabReven = new System.Windows.Forms.TabPage();
            this.tabStatis = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFood);
            this.tabControl.Controls.Add(this.tabCategory);
            this.tabControl.Controls.Add(this.tabAccount);
            this.tabControl.Controls.Add(this.tabReven);
            this.tabControl.Controls.Add(this.tabStatis);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(911, 466);
            this.tabControl.TabIndex = 0;
            // 
            // tabFood
            // 
            this.tabFood.Location = new System.Drawing.Point(4, 22);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(903, 440);
            this.tabFood.TabIndex = 0;
            this.tabFood.Text = "Món ăn";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // tabCategory
            // 
            this.tabCategory.Location = new System.Drawing.Point(4, 22);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(903, 440);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Phân loại";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(903, 440);
            this.tabAccount.TabIndex = 2;
            this.tabAccount.Text = "Tài khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // tabReven
            // 
            this.tabReven.Location = new System.Drawing.Point(4, 22);
            this.tabReven.Name = "tabReven";
            this.tabReven.Padding = new System.Windows.Forms.Padding(3);
            this.tabReven.Size = new System.Drawing.Size(903, 440);
            this.tabReven.TabIndex = 3;
            this.tabReven.Text = "Doanh thu";
            this.tabReven.UseVisualStyleBackColor = true;
            // 
            // tabStatis
            // 
            this.tabStatis.Location = new System.Drawing.Point(4, 22);
            this.tabStatis.Name = "tabStatis";
            this.tabStatis.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatis.Size = new System.Drawing.Size(903, 440);
            this.tabStatis.TabIndex = 4;
            this.tabStatis.Text = "Thống kê";
            this.tabStatis.UseVisualStyleBackColor = true;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 463);
            this.Controls.Add(this.tabControl);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabReven;
        private System.Windows.Forms.TabPage tabStatis;
    }
}