using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Marathon
{
    public class Master:Page
    {
        public Master()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            var tblCountdown = this.Template.FindName("tblCountdown", this) as TextBlock;
            if (tblCountdown != null)
            {
                var toDate = DateTime.Parse("2016/09/05 06:00");
                var fromDate = DateTime.Now;
                System.TimeSpan ts = toDate - fromDate;
                tblCountdown.Text = string.Format("{0} days {1} hours and {2} minutes {3} seconds until the race starts！", ts.Days.ToString(), ts.Hours.ToString(), ts.Minutes.ToString(), ts.Seconds.ToString());
            }
            //throw new NotImplementedException();
        }
        public bool IsShowLogoutBtn { get; set; }
        public override void OnApplyTemplate()
        {
            InitEvent();
        }

        private void InitEvent()
        {
            var btnBack = this.Template.FindName("btnBack", this) as Button;
            if (btnBack !=null)
            {
                btnBack.Click += btnBack_Click;
            }
            var btnLogout = this.Template.FindName("btnLogout", this) as Button;
            if (btnLogout!=null)
            {
                if (IsShowLogoutBtn)
                {
                    btnLogout.Visibility = System.Windows.Visibility.Visible;
                }
                else
                {
                    btnLogout.Visibility = System.Windows.Visibility.Hidden;
                }
                btnLogout.Click += btnLogout_Click;
            }
            
            //throw new NotImplementedException();
        }

        void btnLogout_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Main());
            //throw new NotImplementedException();
        }

        void btnBack_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
            //throw new NotImplementedException();
        }
    }
}
