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

        }
        private void SetStyleOfForm()
        {
            this.BackColor = ColorTheme.MainBackground;
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}
