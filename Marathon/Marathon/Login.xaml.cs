using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        SqlHelper db = new SqlHelper();

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string role="";
            string sqlString = "select * from [User] where Email =@email and Password=@password";
            SqlParameter[] values = new SqlParameter[]{
            new SqlParameter("@email",txtEmail.Text.Trim()),
            new SqlParameter("@password",txtPassword.Text.Trim())
            };
            if (db.IsExist(sqlString, values))
            {
                //string sqlStringGetRole = "select RoleId from [User] Email =@email and Password=@password";
                SqlParameter[] values1 = new SqlParameter[]{
                new SqlParameter("@email",txtEmail.Text.Trim()),
                new SqlParameter("@password",txtPassword.Text.Trim())
                };
                var sdr=db.GetDataReader(sqlString, values1);
                if (sdr.HasRows)
                {
                    if (sdr.Read())
                    {
                        role = sdr["RoleId"].ToString();   
                    }
                } sdr.Close();
                switch (role)
                {
                    case "R": this.NavigationService.Navigate(new RunnerMenu()); break;
                    case "C": this.NavigationService.Navigate(new CoordinatorMenu()); break;
                    case "A": this.NavigationService.Navigate(new AdministratorMenu()); break;
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
            //if (txtEmail.Text=="runner")
            //{
            //    this.NavigationService.Navigate(new RunnerMenu());
            //}
            //else if (txtEmail.Text=="coordinator")
            //{
            //    this.NavigationService.Navigate(new CoordinatorMenu());
            //}
            //else if (txtEmail.Text=="admin")
            //{
            //    this.NavigationService.Navigate(new AdministratorMenu());
            //}
            
        }
    }
}
