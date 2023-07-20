using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsMyBox.Forms.ReusableElements
{
    public partial class YellowButton : Button
    {
        public YellowButton()
        {
            this.BackColor = Color.FromArgb(252, 163, 17);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.Black;
            this.FlatAppearance.BorderSize = 0;
            //this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 176, 46);
            //this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 194, 97);
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
