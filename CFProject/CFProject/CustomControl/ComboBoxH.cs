using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFProject
{
    public partial class ComboBoxH : ComboBox
    {
        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }
            set
            {
                base.AutoSize = value;
            }
        }

        public ComboBoxH()
        {
            this.AutoSize = false; // có thể tùy chỉnh độ rộng
            this.BackColor = Color.LightCyan;
            this.ItemHeight = 33;
        }
    }
}
