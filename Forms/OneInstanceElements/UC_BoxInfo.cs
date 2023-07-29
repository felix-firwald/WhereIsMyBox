using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsMyBox.Forms.Elements
{
    public partial class UC_BoxInfo : UserControl
    {
        public UC_BoxInfo()
        {
            InitializeComponent();

        }
        public void changeData(
            string prefix,
            string postfix,
            string initLocation,
            string currLocation,
            string type,
            string status,
            string comment,
            string user,
            DateTime willBeFree // добавить остальное
        )
        {
            this.labelPrefix.Text = prefix;
            this.labelPostfix.Text = postfix;
            this.initialLocation.Text = initLocation;
            this.type.Text = type;
            this.status.Text = status;
            this.note.Text = comment;
            if (status == "Доступен")
            {
                this.currentLocation.Text = initLocation;
                this.user.Text = "-";
                this.willFree.Text = "СЕЙЧАС";
            }
            else
            {
                this.currentLocation.Text = currLocation;
                this.user.Text = user;
                this.willFree.Text = willBeFree.ToString();
            }
        }
    }
}
