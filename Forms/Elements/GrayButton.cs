using Appearance;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WhereIsMyBox.Forms.Elements
{
    public partial class GrayButton : FontAwesome.Sharp.IconButton
    {
        
        private Color enteredColor = ColorTheme.TextHovered;
        public GrayButton()
        {
            this.Text = "";
            InitializeComponent();
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(0,0,0,0);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            this.FlatAppearance.BorderSize = 0;
            this.IconSize = 20;
            this.IconColor = Color.DimGray;
            this.Text = null;
            this.EnteredColor = ColorTheme.TextHovered;
            this.Cursor = System.Windows.Forms.Cursors.Hand;

        }
        [Description("Цвет при наведении"), Category("Оформление действий")]
        public Color EnteredColor { get => enteredColor; set => enteredColor = value; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void GrayButton_MouseEnter(object sender, EventArgs e)
        {
            this.IconColor = enteredColor;
        }

        private void GrayButton_MouseLeave(object sender, EventArgs e)
        {
            this.IconColor = Color.DimGray;
        }

        private void GrayButton_Click(object sender, EventArgs e)
        {
            this.IconColor = Color.White;
        }

        private void GrayButton_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.IconColor = enteredColor;
        }
    }
}
