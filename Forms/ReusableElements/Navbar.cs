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
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();
            if (!isChecked)
            {
                DeselectItem();
            }
        }
        [Description("Текст навбара"), Category("Главное")]
        public string buttonText { get => this.label.Text; set => this.label.Text = value; }

        [Description("Выбран"), Category("Главное")]
        public bool isChecked { get; set; }

        public void DeselectItem()
        {
            this.bluePanel.Visible = false;
            this.label.ForeColor = Color.DimGray;
            this.icon.ForeColor = Color.FromArgb(45, 45, 45);
        }
        public void SelectItem()
        {
            this.isChecked = !this.isChecked;
            if (!this.isChecked)
            {
                this.bluePanel.Visible = true;
                this.label.ForeColor = Color.FromArgb(211, 215, 235);
                this.icon.ForeColor = Color.DimGray;
            }
        }
        private void SetInMouseFocuse()
        {
            this.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void RemoveFromMouseFocuse()
        {
            this.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void MainPanel_MouseEnter(object sender, EventArgs e)
        {
            SetInMouseFocuse();
        }

        private void MainPanel_MouseLeave(object sender, EventArgs e)
        {
            RemoveFromMouseFocuse();
        }

        private void MainPanel_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            SetInMouseFocuse();
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            RemoveFromMouseFocuse();
        }

        private void label_Click(object sender, EventArgs e)
        {
            SelectItem();
        }
    }
}
