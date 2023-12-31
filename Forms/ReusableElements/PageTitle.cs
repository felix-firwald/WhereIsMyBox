﻿using FontAwesome.Sharp;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WhereIsMyBox.Forms.ReusableElements
{
    public partial class PageTitle : UserControl
    {
        public PageTitle()
        {
            InitializeComponent();
        }
        [Description("Наименование"), Category("Главное")]
        public string Title { get => mainLabel.Text; set => mainLabel.Text = value; }

        [Description("Описание"), Category("Главное")]
        public string Description { get => descriptionLabel.Text; set => descriptionLabel.Text = value; }

        [Description("Иконка"), Category("Главное")]
        public IconChar Icon { get => iconPicture.IconChar; set => iconPicture.IconChar = value; }
    }
}
