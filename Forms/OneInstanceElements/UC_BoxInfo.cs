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
            string status   // добавить остальное
        )
        {
            this.labelPrefix.Text = prefix;
            this.labelPostfix.Text = postfix;
            this.initialLocation.Text = initLocation;
            this.currentLocation.Text = currLocation;
            this.status.Text = status;
        }
    }
}
