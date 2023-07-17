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
using WhereIsMyBox.Classes;
using WhereIsMyBox.Forms;

namespace WhereIsMyBox
{

    /// <summary>
    /// SignUp: зарегистрироваться, SignIn: войти
    /// </summary>
    public enum TypeOfAuth
    {
        SignUp,
        SignIn,
        Unlock
    }
    public partial class AuthForm : Form
    {
        private TypeOfAuth typeAuth;
        private ConfigInfo config;
        public AuthForm(TypeOfAuth type)
        {
            InitializeComponent();
            typeAuth = type;
            SetStyleOfForm();     
            this.comboUsers.Items.Add(Environment.UserName);
            switch (typeAuth)
            {
                case TypeOfAuth.SignIn:
                    config = new ConfigInfo().ReadConfig();
                    this.comboUsers.Text = new ConfigInfo().ReadConfig().login;
                    break; 
                case TypeOfAuth.SignUp:
                    this.buttonOk.Text= "Зарегистрироваться";
                    this.Text = "Регистрация";
                    this.comboUsers.DropDownStyle = ComboBoxStyle.DropDown;
                    this.comboUsers.Text = Environment.UserName;
                    break;
                case TypeOfAuth.Unlock:
                    config = new ConfigInfo().ReadConfig();
                    this.comboUsers.Text = new ConfigInfo().ReadConfig().login;
                    this.comboUsers.Visible = false;
                    this.buttonOk.Text = "Разблокировать";
                    this.Text = "Программа заблокирована";
                    this.labelUser.Text = $"Пользователь ({this.comboUsers.Text})";
                    break;
                default:
                    throw (new Exception("Не передан параметр типа авторизации"));
            }
            this.inputPassword.Focus();
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

        private void ShowPasswordError()
        {
            Rejected formError = new Rejected(
                            "Данные введены неверно",
                            "Имя пользователя или пароль введены неверно. Попробуйте снова или обратитесь к администратору для сброса пароля."
                        );
            formError.ShowDialog();
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
            switch(typeAuth)
            {
                case TypeOfAuth.SignIn:
                case TypeOfAuth.Unlock:
                    if (config.IsPasswordRight(this.inputPassword.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        ShowPasswordError();
                        this.inputPassword.Text = "";
                        this.inputPassword.Focus();
                    }
                    break;
                case TypeOfAuth.SignUp:
                    ChangeLocation locationForm = new ChangeLocation(TypeOfForm.Set);
                    locationForm.ShowDialog();
                    _ = new ConfigInfo(
                        login: this.comboUsers.Text,
                        location: locationForm.GetLocation(),
                        password: this.inputPassword.Text,
                        status: "Оператор"
                    ).WriteConfig();
                    this.Close();
                    break;     
            }
            
        }
    }
}
