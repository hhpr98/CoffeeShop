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

    }

    class A
    {
        public String name { get; set; }
        public int cost { get; set; }
    }
}
