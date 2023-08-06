using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WhereIsMyBox.Classes;
using WhereIsMyBox.Forms;
using WhereIsMyBox.Forms.ReusableElements;

namespace WhereIsMyBox
{
    public partial class Main : Form
    {
        public PermissionGroup userStatus;
        public bool locked = false;
        public Main()
        {
            InitializeComponent();
            ApplyUserData(); 
            SetUserControl(new UC_Boxes());
            NavbarSwitch();
            //ModelBoxes mod = new ModelBoxes();
            //mod.AddBox();
        }

        public void ApplyUserData()
        {
            ConfigInfo config = new ConfigInfo().ReadConfig();
            this.LocationOfUser.Text = config.location;
            CommonData.place = config.location;
            this.Login.Text = config.login;
            CommonData.login = config.login;
            this.UserStatusLabel.Text = config.status;
            Permission.SetPermissionGroup(Permission.GetGroupByVisibleName(config.status));
            setLabelStatus();
        }
        private void setLabelStatus()
        {
            if (userStatus == PermissionGroup.Admin)
            {
                this.UserStatusLabel.ForeColor = Color.Purple;
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
            this.LocationOfUser.ForeColor = Color.FromArgb(211, 215, 235);
        }

        //private void buttonLock_MouseEnter(object sender, EventArgs e)
       // {
         //   this.buttonLock.IconColor = ColorTheme.TextHovered;
       // }

        //private void buttonLock_MouseLeave(object sender, EventArgs e)
        //{
          //  this.buttonLock.IconColor = Color.DimGray;
        //}

       // private void buttonLock_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
         //   AuthForm auth = new AuthForm(TypeOfAuth.Unlock);
         //   auth.ShowDialog();
          //  this.Show();
        //}

        private void NavbarSwitch()
        {
            List<Navbar> navbarList = new List<Navbar> { 
                navbarAdmin, navbarBoxManager, navbarMain,
            };
            foreach(Navbar item in navbarList)
            {
                if (!item.isChecked)
                {
                    item.DeselectItem();
                }
                else
                {
                    item.SelectItem();
                }
            }
        }
    }
}
