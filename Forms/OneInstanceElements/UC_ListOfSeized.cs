﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public void AddItemToList(string box, string initialLocation, int minutes)
        {
            lastNumber++;

            DateTime started = DateTime.Now;
            //this.flowLayout.Controls.Add(new SeizedElement(num, box, started.ToString(), initialLocation, minutes));
            Control newElement = new SeizedElement(lastNumber, box, started, initialLocation, minutes, this);
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
