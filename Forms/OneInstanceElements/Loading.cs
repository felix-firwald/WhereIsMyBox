using Common;
using System;
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
            this.BackColor = ColorTheme.MainBackground;
            ChangeProcessName(processName);
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
