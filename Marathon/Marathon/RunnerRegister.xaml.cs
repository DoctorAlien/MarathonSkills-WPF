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
    /// Interaction logic for RunnerRegister.xaml
    /// </summary>
    public partial class RunnerRegister : Master
    {
        SqlHelper db = new SqlHelper();
        public RunnerRegister()
        {
            InitializeComponent();
            string sqlStringGetGender = "select * from [Gender]";
            string sqlStringGetCountry = "select * from [Country]";
            var dsGender = db.GetDataSet(sqlStringGetGender);
            var dsCountry = db.GetDataSet(sqlStringGetCountry);
            cmbGender.ItemsSource = dsGender.Tables[0].DefaultView;
            cmbGender.DisplayMemberPath = "Gender";
            cmbGender.SelectedValuePath = "Gender";
            cmbGender.SelectedIndex = 0;
            cmbCountry.ItemsSource = dsCountry.Tables[0].DefaultView;
            cmbCountry.DisplayMemberPath = "CountryName";
            cmbCountry.SelectedValuePath = "CountryCode";
            cmbCountry.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var sqlStringUser = "insert into [User](Email,Password,FirstName,LastName,RoleId) values(@email,@password,@firstName,@lastName,'R')";
            var sqlStringRunner = "insert into [Runner](Email,Gender,DateOfBirth,CountryCode) values(@email,@gender,@dateOfBirth,@countryCode)";
            var userValues = new SqlParameter[] {
                new SqlParameter("@email",txtEmail.Text.Trim()),
                new SqlParameter("@password",txtPassword.Text.Trim()),
                new SqlParameter("@firstName",txtFirstName.Text.Trim()),
                new SqlParameter("@lastName",txtLastName.Text.Trim())
            };
            var runnerValues = new SqlParameter[] {
                new SqlParameter("@email",txtEmail.Text.Trim()),
                new SqlParameter("@gender",cmbGender.SelectedValue.ToString()),
                new SqlParameter("@dateOfBirth",dpBirth.SelectedDate.ToString()),
                new SqlParameter("@countryCode",cmbCountry.SelectedValue.ToString())
            };
            if (db.UpdateDataRows(sqlStringUser, userValues) >0)
            {
                if (db.UpdateDataRows(sqlStringRunner, runnerValues) >0)
                {
                    this.NavigationService.Navigate(new RunnerRegistrationConfirm());
                }
            }
        }
    }
}
