using MetroFramework.Drawing.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhereIsMyBox.Classes.Models;
using WhereIsMyBox.Forms.ReusableElements;

namespace WhereIsMyBox.Forms.OneInstanceElements
{
    public partial class UC_ListOfSeized : UserControl
    {
        private int lastNumber = 0;
        public UC_ListOfSeized()
        {
            InitializeComponent();
        }
        public void AddItemToList(ModelUsing use, string location, int minutes)
        {
            lastNumber++;

            DateTime started = DateTime.Now;
            Control newElement = new SeizedElement(lastNumber, use.box, started, location, minutes, this);
            newElement.Dock = DockStyle.Fill;
            this.tableMain.Controls.Add(newElement);
        }
        public void UnfocusElementsExceptFor(SeizedElement element)
        {
            string typeName = element.GetType().Name;
            foreach (Control control in this.tableMain.Controls)
            {
                if (control.GetType().Name == typeName)
                {
                    SeizedElement se = (SeizedElement)control;
                    if (se.focused == true && se != element)
                    {
                        se.RemoveFromFocus();
                    }
                }
            }
        }
    }
}
