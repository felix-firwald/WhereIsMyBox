using Common;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WhereIsMyBox.Forms
{
    // [Docking(DockingBehavior.Ask)]
    public partial class UC_Boxes : UserControl
    {
        public UC_Boxes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Focus();
        }

        private void CopyAllToolStrip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sender.ToString());
        }

        private void buttonFind_MouseEnter(object sender, EventArgs e)
        {
            this.buttonFind.IconColor = ColorTheme.TextHovered;
        }

        private void buttonFind_MouseLeave(object sender, EventArgs e)
        {
            this.buttonFind.IconColor = Color.DimGray;
        }

        private void inputFind_TextChanged(object sender, EventArgs e)
        {
            bool regex = Regex.IsMatch(this.inputFind.Text, @"^[a-zA-Z]\w*[1-9]$");
            bool length = this.inputFind.Text.Length > 5;
            
            if (regex && length)
            {
                this.inputFind.ForeColor = Color.LightGreen;
                this.buttonFind.Enabled = true;
            }
            else if (regex)
            {
                this.inputFind.ForeColor = ColorTheme.TextHovered;
                this.buttonFind.Enabled = false;
            }
            else
            {
                this.inputFind.ForeColor = Color.IndianRed;
                this.buttonFind.Enabled = false;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            this.inputFind.Text = this.inputFind.Text.ToUpper();
            this.HelpTextFind.Text = $"Поиск короба №{this.inputFind.Text}...";
            this.tableMicroActions.Visible = true;
            this.BoxInfoPanel.Visible = true;
        }

        private void inputFind_Enter(object sender, EventArgs e)
        {
           
        }

        private void buttonCancelFind_Click(object sender, EventArgs e)
        {
            this.inputFind.Text = "";
            this.buttonFind.Enabled = false;
            this.HelpTextFind.Text = "Вы уже знаете, что делать";
            this.tableMicroActions.Visible = false;
            this.BoxInfoPanel.Visible = false;
        }

        private void buttonCancelFind_MouseEnter(object sender, EventArgs e)
        {
            this.buttonCancelFind.IconColor = ColorTheme.TextHovered;
        }

        private void buttonCancelFind_MouseLeave(object sender, EventArgs e)
        {
            this.buttonCancelFind.IconColor = Color.DimGray;
        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
