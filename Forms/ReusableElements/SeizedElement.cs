using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhereIsMyBox.Classes.Models;

namespace WhereIsMyBox.Forms.ReusableElements
{
    public partial class SeizedElement : UserControl
    {
        private bool canceled = false;
        public string num {
            get {return this.number.Text; }
            set {this.number.Text = value ; }
        }
        public DateTime start;
        private int seconds;
        public SeizedElement(int num, string box, DateTime timeStarted, string location, int minutes)
        {
            InitializeComponent();
            this.number.Text = num.ToString();
            this.box.Text = box;
            this.start = timeStarted;
            this.dateStart.Text = timeStarted.ToString();
            this.initialLocation.Text = location;
            this.seconds = minutes * 60;
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
            NotifyIcon notif = new NotifyIcon();
            string text = $"Время для удержания короба под номером {this.box} истекло." +
                $"Отнесите его на его место или пролонгируйте использование!";
            notif.ShowBalloonTip(2000, "Верните короб!", text, ToolTipIcon.Warning);
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
    }
}
