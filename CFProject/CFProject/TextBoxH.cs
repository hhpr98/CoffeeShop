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
    public partial class TextBoxH : TextBox
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

        public TextBoxH()
        {
            this.AutoSize = false; // có thể tùy chỉnh độ rộng
            //this.BackColor = Color.LightGray;
            //this.Text = "";
        }
    }
}
