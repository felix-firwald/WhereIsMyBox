using MySqlX.XDevAPI.Common;
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

namespace WhereIsMyBox.Forms.Elements
{
    public partial class UC_BoxInfo : UserControl
    {
        private ModelBox instance;
        public UC_BoxInfo()
        {
            InitializeComponent();

        }
        public void ChangeData(ModelBox box)
        {
            string[] result = ModelBox.GetSplitedNumber(box.number);
            this.labelPrefix.Text = result[0];
            this.labelPostfix.Text = result[1];
            this.type.Text = box.type;
            this.status.Text = box.GetStringNameOfStatus();
            this.note.Text = box.note;
            this.instance = box;

            if (box.status == BoxStatus.Seized || box.status == BoxStatus.Focused)
            {
                using (ModelUsing use = new ModelUsing())
                {
                    if (use.GetUsingByBox(box.number))
                    {
                        this.currentLocation.Text = use.place;
                        this.user.Text = use.customer;
                        this.willFree.Text = use.timeFinished.ToString();
                    }
                    else
                    {
                        this.currentLocation.Text = "Неизвестно (ошибка)";
                        this.user.Text = "Неизвестно (ошибка)";
                        this.willFree.Text = "Неизвестно (ошибка)";
                    }
                }
                
            }
            else if (box.status == BoxStatus.Available) // если доступен
            {
                this.initialLocation.Text = box.location;
                this.currentLocation.Text = this.initialLocation.Text;
                this.user.Text = "-";
                this.willFree.Text = "сейчас";
            }
            else // если утерян
            {
                this.initialLocation.Text = box.location;
                this.currentLocation.Text = "Неизвестно";
                this.user.Text = "-";
                this.willFree.Text = "∞";
            }
        }
        public void UpdateData()
        {
            using (ModelBox mb = new ModelBox())
            {
                if (mb.GetBoxByNumber(this.instance.number))
                {
                    ChangeData(mb);
                }
            }
        }

        public ModelBox GetData()
        {
            return this.instance;
        }
    }
}
