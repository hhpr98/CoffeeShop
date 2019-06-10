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
			this.grvData = new System.Windows.Forms.DataGridView();
			this.pnTable = new System.Windows.Forms.Panel();
			this.pnDetail = new System.Windows.Forms.Panel();
			this.pnControl = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			this.pnTable.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grvData
			// 
			this.grvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvData.Location = new System.Drawing.Point(256, 44);
			this.grvData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.grvData.Name = "grvData";
			this.grvData.Size = new System.Drawing.Size(522, 592);
			this.grvData.TabIndex = 0;
			// 
			// pnTable
			// 
			this.pnTable.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnTable.Controls.Add(this.grvData);
			this.pnTable.Location = new System.Drawing.Point(0, 60);
			this.pnTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.pnTable.Name = "pnTable";
			this.pnTable.Size = new System.Drawing.Size(1200, 948);
			this.pnTable.TabIndex = 1;
			// 
			// pnDetail
			// 
			this.pnDetail.BackColor = System.Drawing.Color.Maroon;
			this.pnDetail.Location = new System.Drawing.Point(1234, 60);
			this.pnDetail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.pnDetail.Name = "pnDetail";
			this.pnDetail.Size = new System.Drawing.Size(562, 765);
			this.pnDetail.TabIndex = 0;
			// 
			// pnControl
			// 
			this.pnControl.BackColor = System.Drawing.Color.DarkOrange;
			this.pnControl.Location = new System.Drawing.Point(1234, 856);
			this.pnControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.pnControl.Name = "pnControl";
			this.pnControl.Size = new System.Drawing.Size(562, 129);
			this.pnControl.TabIndex = 1;
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
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
			this.menuStrip1.Size = new System.Drawing.Size(1820, 44);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// quảnLíToolStripMenuItem
			// 
			this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
			this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
			this.quảnLíToolStripMenuItem.Text = "Quản lí";
			this.quảnLíToolStripMenuItem.Click += new System.EventHandler(this.quảnLíToolStripMenuItem_Click);
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(142, 36);
			this.chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// thôngTinToolStripMenuItem
			// 
			this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem1,
            this.thoátToolStripMenuItem});
			this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
			this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
			this.thôngTinToolStripMenuItem.Text = "Tùy chọn";
			// 
			// thôngTinToolStripMenuItem1
			// 
			this.thôngTinToolStripMenuItem1.Name = "thôngTinToolStripMenuItem1";
			this.thôngTinToolStripMenuItem1.Size = new System.Drawing.Size(218, 38);
			this.thôngTinToolStripMenuItem1.Text = "Thông tin";
			this.thôngTinToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinToolStripMenuItem1_Click);
			// 
			// thoátToolStripMenuItem
			// 
			this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			this.thoátToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
			this.thoátToolStripMenuItem.Text = "Thoát";
			this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1820, 1008);
			this.Controls.Add(this.pnControl);
			this.Controls.Add(this.pnDetail);
			this.Controls.Add(this.pnTable);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "cafe Management v1.0";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			this.pnTable.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvData;
        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.Panel pnDetail;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

