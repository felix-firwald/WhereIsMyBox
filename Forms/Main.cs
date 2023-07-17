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
    public enum Status
    {
        Operator,
        Moderator,
        Administrator
    }
    public partial class Main : Form
    {
        public Status userStatus;
        public bool locked = false;
        public Main()
        {
            InitializeComponent();
            SetUserControl(new UC_Boxes());
            //SetUserControl(new UC_Blocked());
            ApplyUserData();
            
            
        }

        public void ApplyUserData()
        {
            ConfigInfo config = new ConfigInfo().ReadConfig();
            this.LocationOfUser.Text = config.location;
            this.Login.Text = config.login;
            this.UserStatusLabel.Text = config.status;
            switch (config.status)
            {
                case "Администратор":
                    userStatus = Status.Administrator;
                    break;
                case "Модератор":
                    userStatus = Status.Moderator;
                    break;
                case "Оператор":
                    userStatus = Status.Operator;
                    break;
            }
            setLabelStatus();
        }
        private void setLabelStatus()
        {
            switch(userStatus)
            {
                case Status.Operator:
                    this.UserStatusLabel.Text = "Оператор";
                    break;
                case Status.Moderator:
                    this.UserStatusLabel.Text = "Модератор";
                    break;
                case Status.Administrator:
                    this.UserStatusLabel.Text = "Администратор";
                    this.UserStatusLabel.ForeColor = Color.Purple;
                    break;
            }
            this.Text = $"Where Is My Box ({this.UserStatusLabel.Text})";
        }
        private void SetUserControl(UserControl uc)
        {
            this.panelContent.Controls.Clear();
            //this.tableLayoutMain.Controls.Add(uc);
            //this.panelMain.Size;
            this.panelContent.Controls.Add(uc);
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
            ChangeLocation locationForm = new ChangeLocation(TypeOfForm.Change);
            locationForm.ShowDialog();
        }

        private void LocationOfUser_MouseLeave(object sender, EventArgs e)
        {
            this.LocationOfUser.ForeColor = SystemColors.ControlText;
        }

        private void buttonLock_MouseEnter(object sender, EventArgs e)
        {
            this.buttonLock.IconColor = ColorTheme.TextHovered;
        }

        private void buttonLock_MouseLeave(object sender, EventArgs e)
        {
            this.buttonLock.IconColor = Color.DimGray;
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthForm auth = new AuthForm(TypeOfAuth.Unlock);
            auth.ShowDialog();
            this.Show();
        }
    }
}
