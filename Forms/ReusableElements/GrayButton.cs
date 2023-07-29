using Common;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WhereIsMyBox.Classes;

namespace WhereIsMyBox.Forms.Elements
{
    public partial class GrayButton : FontAwesome.Sharp.IconButton
    {
        
        private Color enteredColor = ColorTheme.TextHovered;
        private PermissionGroup requiredPermission;
        private PermissionMode permissionMode;

        public GrayButton()
        {
            this.Text = "";
            InitializeComponent();
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(0,0,0,0);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            this.FlatAppearance.BorderSize = 0;
            this.IconSize = 20;
            this.IconColor = Color.DimGray;
            this.EnteredColor = ColorTheme.TextHovered;
            this.Cursor = System.Windows.Forms.Cursors.Hand;

        }
        [Description("Цвет при наведении"), Category("Главное")]
        public Color EnteredColor { get => enteredColor; set => enteredColor = value; }

        [Description("Группа прав"), Category("Главное")]
        public PermissionGroup RequiredPermission { get => requiredPermission; set => requiredPermission = value; }

        [Description("Режим прав"), Category("Главное")]
        public PermissionMode PermissionMode { get => permissionMode; set => permissionMode = value; }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void GrayButton_MouseEnter(object sender, EventArgs e)
        {
            SetEnteredColor();
        }
        private void SetEnteredColor()
        {
            this.IconColor = enteredColor;
        }

        private void GrayButton_MouseLeave(object sender, EventArgs e)
        {
            SetStandartColor();
        }
        private void SetStandartColor()
        {
            this.IconColor = Color.DimGray;
        }

        private void GrayButton_Click(object sender, EventArgs e)
        {
            bool permissionResult = Permission.IsUserHavePermission(this.requiredPermission, permissionMode);
            this.IconColor = Color.White;
            if (!permissionResult)
            {
                Permission.RaisePermissionError(this.requiredPermission);
                this.Enabled = false;
                SetStandartColor();
            }
        }

        private void GrayButton_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.IconColor = enteredColor;
        }
    }
}
