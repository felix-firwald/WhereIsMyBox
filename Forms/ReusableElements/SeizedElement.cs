using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhereIsMyBox.Classes.Models;
using WhereIsMyBox.Forms.OneInstanceElements;

namespace WhereIsMyBox.Forms.ReusableElements
{
    public partial class SeizedElement : UserControl
    {
        private bool canceled = false;
        public bool focused = false;
        public string num {
            get {return this.number.Text; }
            set {this.number.Text = value ; }
        }
        private UC_ListOfSeized listOfSeized;
        public DateTime start;
        private int seconds;
        public SeizedElement(int num, string box, DateTime timeStarted, string location, int minutes, UC_ListOfSeized list)
        {
            InitializeComponent();
            this.number.Text = num.ToString();
            this.box.Text = box;
            this.start = timeStarted;
            this.dateStart.Text = timeStarted.ToString();
            this.location.Text = location;
            this.seconds = minutes * 60;
            this.listOfSeized = list;
            SetSeconds(this.seconds);
            DecrementTime();

        }
        private string FormatTime(int i)
        {
            if (i < 10)
            {
                return "0"+ i.ToString();
            }
            return i.ToString();
        }
        private void SetSeconds(int secs) 
        {
            int hours = secs / 3600;
            int mins = (secs % 3600) / 60;
            secs = secs % 60;
            this.remains.Text = $"{FormatTime(hours)}:{FormatTime(mins)}:{FormatTime(secs)}";
        }

        async void DecrementTime()
        {
            while (seconds != 0)
            {
                await Task.Delay(1000);
                seconds--;
                SetSeconds(seconds);
                if (canceled)
                {
                    return;
                }
            }
            this.tableMain.BackColor = Color.FromArgb(91, 48, 51);
            ShowNotification();
        }
        private void ShowNotification()
        {
            this.BringToFront();
            string text = $"Время для удержания короба под номером {this.box.Text} истекло." +
                $"Отнесите его на его место ({this.location.Text}) или пролонгируйте использование!";
            MessageBox.Show(text, "Верните короб!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ModelUsing use = new ModelUsing();
            use.timeStarted = start;
            use.box = this.box.Text;
            use.ReturnSeizing();
            this.canceled = true;
            this.Visible = false;

        }
        public void SetInFocus()
        {
            this.focused = true;
            ModelUsing model = new ModelUsing();
            model.inFocus = true;
            model.box = this.box.Text;
            model.timeStarted = start;
            this.setFocus.Visible = false;
            this.box.ForeColor = Color.LightGreen;
            this.dateStart.ForeColor = Color.LightGreen;
            this.remains.ForeColor = Color.LightGreen;
            this.location.ForeColor = Color.LightGreen;
            model.UpdateFocus();
            listOfSeized.UnfocusElementsExceptFor(this);

        }
        public void RemoveFromFocus()
        {
            this.focused = false;
            ModelUsing model = new ModelUsing();
            model.inFocus = false;
            model.box = this.box.Text;
            model.timeStarted = start;
            Color whiteColor = Color.FromArgb(211, 215, 235);
            this.setFocus.Visible = true;
            this.box.ForeColor = whiteColor;
            this.dateStart.ForeColor = whiteColor;
            this.remains.ForeColor = whiteColor;
            this.location.ForeColor = whiteColor;
            model.UpdateFocus();
        }

        private void setFocus_Click(object sender, EventArgs e)
        {
            SetInFocus();

        }
    }
}
