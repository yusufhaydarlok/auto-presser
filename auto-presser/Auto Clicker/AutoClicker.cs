using auto_presser.Auto_Clicker.User32ApiUtils;
using auto_presser.Auto_Clicker.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_presser
{
    public partial class AutoClicker : UserControl
    {
        public double intervals = 0.100;
        public bool click = false;
        AutoClickerSettings autoClickerSettings = new AutoClickerSettings();
            
        public AutoClicker()
        {
            InitializeComponent();
        }
        private void AutoClicker_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClickerr);
            AC.Start();
        }

        public void AutoClickerr ()
        {
            while (true)
            {
                if (click == true)
                {
                    User32ApiUtils.ExecuteMouseEvent(dwFlags: Constants.MOUSEEVENT_LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);
                    User32ApiUtils.ExecuteMouseEvent(dwFlags: Constants.MOUSEEVENT_LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(autoClickerSettings.Hours + autoClickerSettings.Minutes + autoClickerSettings.Seconds + autoClickerSettings.Milliseconds);
                }
                Thread.Sleep(2);
            }
        }

        //Start & Stop Button
        static public bool isStart = false;
        private void start_Click(object sender, EventArgs e)
        {
            isStart = true;
        }
        private void stop_Click(object sender, EventArgs e)
        {
            isStart = false;
        }

        //Click Intervals
        public void hours_TextChanged(object sender, EventArgs e)
        {
            autoClickerSettings.Hours = int.Parse(hours.Text)*3600;
            hours.Text = "0";
        }

        public void minutes_TextChanged(object sender, EventArgs e)
        {
            autoClickerSettings.Minutes = int.Parse(minutes.Text)*60;
            hours.Text = "0";
        }

        public void seconds_TextChanged(object sender, EventArgs e)
        {
            autoClickerSettings.Seconds = int.Parse(seconds.Text);
            hours.Text = "0";
        }

        public void milliseconds_TextChanged(object sender, EventArgs e)
        {
            autoClickerSettings.Milliseconds = int.Parse(milliseconds.Text)/60;
            hours.Text = "0.100";
        }
        //Cursort Pointor
        private void pickLocation_Click(object sender, EventArgs e)
        {
            User32ApiUtils.SetCursorPosition
        }
    }
}
