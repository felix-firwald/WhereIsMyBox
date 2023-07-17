using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace WhereIsMyBox.Forms
{
    public partial class Rejected : Form
    {
        public Rejected(string title, string text)
        {
            InitializeComponent();
            this.title.Text = title;
            this.text.Text = text;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
