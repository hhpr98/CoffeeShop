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
            this.tabManagement = new TabControlH.TabControlH();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabReven = new System.Windows.Forms.TabPage();
            this.tabStatis = new System.Windows.Forms.TabPage();
            this.tabManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCategory
            // 
            this.tabCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabCategory.Location = new System.Drawing.Point(4, 29);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(495, 330);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Phân loại";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // tabFood
            // 
            this.tabFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabFood.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabFood.Location = new System.Drawing.Point(4, 29);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(495, 330);
            this.tabFood.TabIndex = 0;
            this.tabFood.Text = "Món ăn";
            this.tabFood.UseVisualStyleBackColor = true;
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
            this.tabManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManagement.GradientAngle = 90;
            this.tabManagement.ItemSize = new System.Drawing.Size(80, 25);
            this.tabManagement.Location = new System.Drawing.Point(1, 2);
            this.tabManagement.Name = "tabManagement";
            this.tabManagement.NonActiveTabEndColor = System.Drawing.Color.Blue;
            this.tabManagement.NonActiveTabStartColor = System.Drawing.Color.AntiqueWhite;
            this.tabManagement.Padding = new System.Drawing.Point(22, 4);
            this.tabManagement.SelectedIndex = 0;
            this.tabManagement.Size = new System.Drawing.Size(910, 469);
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
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(495, 330);
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
            this.tabReven.Size = new System.Drawing.Size(495, 330);
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
            this.tabStatis.Size = new System.Drawing.Size(902, 436);
            this.tabStatis.TabIndex = 4;
            this.tabStatis.Text = "Thống kê";
            this.tabStatis.UseVisualStyleBackColor = true;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 463);
            this.Controls.Add(this.tabManagement);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
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
    }
}