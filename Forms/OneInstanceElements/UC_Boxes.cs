using Common;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhereIsMyBox.Classes.Models;
using WhereIsMyBox.Forms.OneInstanceElements;

namespace WhereIsMyBox.Forms
{
    // [Docking(DockingBehavior.Ask)]
    public partial class UC_Boxes : UserControl
    {
        ModelBoxes foundBox = new ModelBoxes();
        //private string foundedBox;
        public UC_Boxes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Focus();
            //this.inputSeize.KeyDown += new KeyEventHandler(inputSeize_KeyDown);
        }
        #region Validate Input Functions
        private bool BoxNumberValidateFormat(string number)
        {
            return Regex.IsMatch(number, @"^[a-zA-Z]\w*[0-9]$");
        }
        private bool BoxNumberValidateLength(string number)
        {
            return number.Length > 5;
        }
        #endregion

        #region Common Methods
        private void SeizeBox(string number, int period, bool safety=true)
        {
            using (ModelUsing use = new ModelUsing())
            {
                use.box = number;
                use.place = CommonData.place;
                use.customer = CommonData.login;
                try
                {
                    string loc = "";
                    if (safety)
                    {
                        using (ModelBoxes mb = new ModelBoxes())
                        {
                            if (mb.GetBoxByNumber(number))  // если короб есть
                            {
                                loc = mb.location;
                                if (!mb.SwitchAccessOnStatus())
                                {
                                    MessageBox.Show($"Короб находится в статусе \"{mb.GetStringNameOfStatus()}\".", "Ошибка"); 
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Короб не найден или удален.", "Короб не найден");
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (!foundBox.SwitchAccessOnStatus())
                        {
                            MessageBox.Show($"Короб находится в статусе \"{foundBox.GetStringNameOfStatus()}\".", "Ошибка");
                            return;
                        }
                        loc = foundBox.location;
                    }
                    use.AddBoxIntoUsing(period);
                    this.ListOfSeized.AddItemToList(use, loc, period);
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно добавить несуществующий короб.", "Ошибка");
                    return;
                }
            }
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
            CloseFindPanel();
            this.inputFind.Text = this.inputFind.Text.ToUpper();
            this.HelpTextFind.Text = $"Поиск короба №{this.inputFind.Text}...";
            //ModelBoxes foundBox = new ModelBoxes();
            foundBox.Clear();
            Loading loadform = new Loading(this.HelpTextFind.Text);
            loadform.Show();
            if (foundBox.GetBoxByNumber(this.inputFind.Text))
            {
                this.BoxInfoPanel.ChangeData(foundBox);
                this.tableMicroActions.Visible = true;
                this.BoxInfoPanel.Visible = true;
                this.HelpTextFind.Visible = false;
            }
            else
            {
                this.HelpTextFind.Text = $"Короб №{this.inputFind.Text} не найден!";
                this.HelpTextFind.Visible = true;
            }
            loadform.Close();
        }

        private void CloseFindPanel()
        {
            this.tableMicroActions.Visible = false;
            this.BoxInfoPanel.Visible = false;
        }

        private void buttonCancelFind_Click(object sender, EventArgs e)
        {
            this.inputFind.Text = "";
            this.buttonFind.Enabled = false;
            this.HelpTextFind.Visible = true;
            this.HelpTextFind.Text = "Вы и сами знаете, что делать.";
            CloseFindPanel();
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
            CloseFindPanel();
            string num = this.foundBox.number;
            this.inputFind.Text = "";
            SeizeBox(num, 60, false); 
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

        private async void buttonMarkAsNotFound_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                using (ModelBoxes mb = new ModelBoxes())
                {
                    mb.number = this.BoxInfoPanel.GetNumber();
                    mb.UpdateStatus(BoxStatus.Lost);
                }
            });
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
            this.inputSeize.Text = this.inputSeize.Text.ToUpper();
            SeizeBox(this.inputSeize.Text, 2);
        }
        #endregion

        private void inputSeize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddToSeized_Click(sender, e);
            }
        }

        private void inputFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddBox_Click(sender, e);
            }
        }
    }
}
