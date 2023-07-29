using Common;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WhereIsMyBox.Classes.Models;
using WhereIsMyBox.Forms.OneInstanceElements;

namespace WhereIsMyBox.Forms
{
    // [Docking(DockingBehavior.Ask)]
    public partial class UC_Boxes : UserControl
    {
        ModelBoxes foundBox = new ModelBoxes();
        string login;
        //private string foundedBox;
        public UC_Boxes(string username)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Focus();
            this.login = username;
            this.inputSeize.KeyDown += new KeyEventHandler(inputSeize_KeyDown);
        }
        #region Validate Input Functions
        private bool BoxNumberValidateFormat(string number)
        {
            return Regex.IsMatch(number, @"^[a-zA-Z]\w*[1-9]$");
        }
        private bool BoxNumberValidateLength(string number)
        {
            return number.Length > 5;
        }
        #endregion

        
        #region FindPanel Main

        private void buttonFind_MouseEnter(object sender, EventArgs e)
        {
            this.buttonFind.IconColor = ColorTheme.TextHovered;
        }

        private void buttonFind_MouseLeave(object sender, EventArgs e)
        {
            this.buttonFind.IconColor = Color.DimGray;
        }

        private void InputFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            this.inputFind.Text = this.inputFind.Text.ToUpper();
            this.HelpTextFind.Text = $"Поиск короба №{this.inputFind.Text}...";
            //ModelBoxes foundBox = new ModelBoxes();
            foundBox.Clear();
            Loading loadform = new Loading(this.HelpTextFind.Text);
            loadform.Show();
            if (foundBox.GetBoxByNumber(this.inputFind.Text))
            {
                string [] result = foundBox.GetSplitedNumber();
                this.BoxInfoPanel.changeData(
                    prefix: result[0],
                    postfix: result[1],
                    initLocation: foundBox.initialLocation,
                    currLocation: foundBox.currentPlace,
                    type: foundBox.type,
                    status: foundBox.status,
                    comment: foundBox.note,
                    user: this.login,
                    willBeFree: foundBox.willFree
                );
                this.tableMicroActions.Visible = true;
                this.BoxInfoPanel.Visible = true;
                this.HelpTextFind.Visible = false;
            }
            else
            {
                this.HelpTextFind.Text = $"Короб №{this.inputFind.Text} не найден!";
            }
            loadform.Close();
        }


        private void buttonCancelFind_Click(object sender, EventArgs e)
        {
            this.inputFind.Text = "";
            this.buttonFind.Enabled = false;
            this.HelpTextFind.Visible = true;
            this.HelpTextFind.Text = "Вы и сами знаете, что делать.";
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

        private void inputFind_TextChanged(object sender, EventArgs e)
        {
            bool regex = BoxNumberValidateFormat(this.inputFind.Text);
            bool length = BoxNumberValidateLength(this.inputFind.Text);

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
        


        private void inputFind_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.inputFind.SelectAll();
                Clipboard.SetText(this.inputFind.Text);
            }
        }
        #endregion

        #region FindPanel LittleButtons
        private void buttonAddBox_Click(object sender, EventArgs e)
        {
            ModelUsing use = new ModelUsing();
            use.box = foundBox;
            use.customer = this.login;
            use.AddBoxIntoUsing(120);
        }

        private void buttonShowMap_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowQRCode_Click(object sender, EventArgs e)
        {
            Barcode qrWindow = new Barcode(foundBox.number);
            qrWindow.Show();
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {

        }

        private void buttonMarkAsNotFound_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region SeizePanel Top
        private void inputSeize_TextChanged(object sender, EventArgs e)
        {
            bool regex = BoxNumberValidateFormat(this.inputSeize.Text);
            bool length = BoxNumberValidateLength(this.inputSeize.Text);
            if (regex && length)
            {
                this.inputSeize.ForeColor = Color.LightGreen;
                this.buttonAddToSeized.Enabled = true;
            }
            else if (regex)
            {
                this.inputSeize.ForeColor = ColorTheme.TextHovered;
                this.buttonAddToSeized.Enabled = false;
            }
            else
            {
                this.inputSeize.ForeColor = Color.IndianRed;
                this.buttonAddToSeized.Enabled = false;
            }
        }

        private void buttonClearSeizingBox_Click(object sender, EventArgs e)
        {
            this.inputSeize.Text = "";
        }


        private void buttonSettingsForSeize_Click(object sender, EventArgs e)
        {

        }
        private void buttonAddToSeized_Click(object sender, EventArgs e)
        {
            this.inputSeize.Text.ToUpper();
        }
        #endregion

        private void inputSeize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddToSeized_Click(sender, e);
            }
        }

        
    }
}
