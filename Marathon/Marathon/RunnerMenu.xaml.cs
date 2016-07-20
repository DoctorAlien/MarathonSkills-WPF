using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Marathon
{
    /// <summary>
    /// Interaction logic for RunnerMenu.xaml
    /// </summary>
    public partial class RunnerMenu : Master
    {
        public RunnerMenu()
        {
            InitializeComponent();
            IsShowLogoutBtn = true;
        }

        private void btnRegisterEvent_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EventRegister());
        }

        private void btnRunnerProfile_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RunnerProfile());
        }
    }
}
