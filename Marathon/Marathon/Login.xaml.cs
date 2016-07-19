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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Master
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text=="runner")
            {
                this.NavigationService.Navigate(new RunnerMenu());
            }
            else if (txtEmail.Text=="coordinator")
            {
                this.NavigationService.Navigate(new CoordinatorMenu());
            }
            else if (txtEmail.Text=="admin")
            {
                this.NavigationService.Navigate(new AdministratorMenu());
            }
            
        }
    }
}
