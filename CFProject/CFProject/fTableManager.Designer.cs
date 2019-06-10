namespace CFProject
{
	partial class fTableManager
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
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1286, 40);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
			this.adminToolStripMenuItem.Text = "Admin";
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
			this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 79);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(662, 618);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.listView1);
			this.panel2.Location = new System.Drawing.Point(689, 79);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(571, 513);
			this.panel2.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(689, 609);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(571, 88);
			this.panel3.TabIndex = 3;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(4, 4);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(567, 506);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// fTableManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1286, 722);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "fTableManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "fTableManager";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Panel panel3;
	}
}