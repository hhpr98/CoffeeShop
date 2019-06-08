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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<A> data = new List<A>() { new A() { name = "A", cost = 1 }, new A() { name = "B", cost = 2 } };
            grvData.DataSource = data;
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quản lí quán cafe v1.0\n1612203 - 1612209\nKhoa CNTT - ĐH KHTN - ĐHQGTPHCM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control frmControl = new Control();
            this.Hide();
            frmControl.ShowDialog();
            this.Show();
        }
    }

    class A
    {
        public String name { get; set; }
        public int cost { get; set; }
    }
}
