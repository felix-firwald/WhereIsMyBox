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

    /// <summary>
    /// SignUp: зарегистрироваться, SignIn: войти
    /// </summary>
    public enum TypeOfAuth
    {
        SignUp,
        SignIn
    }
    public partial class AuthForm : Form
    {
        private TypeOfAuth typeAuth;
        public AuthForm(TypeOfAuth type)
        {
            InitializeComponent();
            typeAuth = type;
            SetStyleOfForm();     
            this.comboUsers.Items.Add(Environment.UserName);
            this.comboUsers.Text = Environment.UserName;
            switch (typeAuth)
            {
                case TypeOfAuth.SignIn:
                    break; 
                case TypeOfAuth.SignUp:
                    this.buttonOk.Text= "Зарегистрироваться";
                    this.Text = "Регистрация";
                    break;
            }

        }
        private void SetStyleOfForm()
        {
            this.BackColor = ColorTheme.MainBackground;
            this.panelControls.BackColor = ColorTheme.PanelBackground;
            this.buttonOk.BackColor = ColorTheme.Button;
            this.buttonOk.FlatAppearance.MouseOverBackColor = ColorTheme.ButtonHovered;
            this.buttonOk.FlatAppearance.MouseDownBackColor = ColorTheme.ButtonPressed;
            this.buttonOk.FlatAppearance.BorderColor = Color.FromArgb(100, 0, 0, 0);
            this.buttonClose.FlatAppearance.BorderColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkVisible_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkVisible.Checked)
            {
                this.inputPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.inputPassword.UseSystemPasswordChar = true;
            }
        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.inputPassword.Text.Length > 3)
            {
                this.buttonOk.Enabled = true;
            }
            else
            {
                this.buttonOk.Enabled = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
