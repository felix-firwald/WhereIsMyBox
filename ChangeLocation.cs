using Appearance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsMyBox
{
    public partial class ChangeLocation : Form
    {
        public ChangeLocation()
        {
            InitializeComponent();
            SetStyle();
        }

        private void SetStyle()
        {
            this.BackColor = ColorTheme.MainBackground;
            this.panelBottom.BackColor = ColorTheme.PanelBackground;
            //this.buttonOk.BackColor = ColorTheme.Button;
            //this.buttonOk.FlatAppearance.MouseOverBackColor = ColorTheme.ButtonHovered;
            //this.buttonOk.FlatAppearance.MouseDownBackColor = ColorTheme.ButtonPressed;
            //this.buttonOk.FlatAppearance.BorderColor = ColorTheme.ButtonBorder;
        }

        private string ConcatenateResult()
        {
            string result = inputPrefix.Text + inputPostfix.Text;
            this.resultLocation.Text = result;
            return result;
        }

        private void ValidateResult()
        {
            if (this.resultLocation.Text.Length > 1) { 
                this.buttonOk.Enabled = true;
            }
            else
            {
                this.buttonOk.Enabled = false;
            }
        }

        private void ChangeLocation_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputPrefix_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(inputPrefix.Text, @"^[1-9]")) // только буквы
            {
                inputPrefix.Text = "A";
                MessageBox.Show("Префикс может состоять только из буквенных символов", "Ошибка");
            }
            else
            {
                inputPrefix.Text = inputPrefix.Text.ToUpper();
                this.inputPostfix.Focus();
            }
            ConcatenateResult();
            ValidateResult();
        }

        private void inputPostfix_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(inputPostfix.Text, @"^[a-zA-Z]")) // только цифры
            {
                inputPostfix.Text = "1";
                MessageBox.Show("Префикс может состоять только из численных символов", "Ошибка");
            }
            else
            {
                if (inputPostfix.Text.Length > 1)
                {
                    this.buttonOk.Focus();
                }
            }
            ConcatenateResult();
            ValidateResult();
        }
    }
}
