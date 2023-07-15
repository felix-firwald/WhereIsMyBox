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
    public partial class Loading : Form
    {
        public void ChangeProcessName(string processName)
        {
            this.textProcess.Text = processName;
        }
        public Loading(String processName="Выполняется загрузка данных...")
        {
            InitializeComponent();
            Appearance.ColorTheme theme = new Appearance.ColorTheme();
            this.BackColor = theme.GetMain();
            ChangeProcessName(processName);
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
