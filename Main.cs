using Appearance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsMyBox
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SetMainStyle();
        }
        private void SetMainStyle()
        {
            Size maxSize = new Size(
                Convert.ToInt16(System.Windows.SystemParameters.PrimaryScreenWidth / 2),
                Convert.ToInt16(System.Windows.SystemParameters.PrimaryScreenHeight - 100)
            );
            SpecialButton yb = new SpecialButton();
            this.MaximumSize = maxSize;
            this.BackColor = ColorTheme.MainBackground;
            this.panelBottom.BackColor = ColorTheme.PanelBackground;
            //this.panelLeft.BackColor = ColorTheme.PanelBackground;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LocationOfUser_MouseEnter(object sender, EventArgs e)
        {
            this.LocationOfUser.ForeColor = ColorTheme.TextHovered;
        }

        private void LocationOfUser_Click(object sender, EventArgs e)
        {
            ChangeLocation locationForm = new ChangeLocation();
            locationForm.ShowDialog();
        }

        private void LocationOfUser_MouseLeave(object sender, EventArgs e)
        {
            this.LocationOfUser.ForeColor = SystemColors.ControlText;
        }
    }
}
