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
    /// Interaction logic for EventRegister.xaml
    /// </summary>
    public partial class EventRegister : Master
    {
        public EventRegister()
        {
            InitializeComponent();
            //tbTotal.DataContext = total;
        }
        //public class RaceKitOption {
        //    public string raceKitOptionId { get; set; }
        //    public string raceKitOption { get; set; }
        //    public float cost { get; set; }
        //}
        public class TotalMoney {
            public double sum { get;set;}
        }
        private void btnModal_Click(object sender, RoutedEventArgs e)
        {
            var from = new CharityModal();
            from.ShowDialog();
        }
        SqlHelper db = new SqlHelper();
        TotalMoney total = new TotalMoney();
        private void Master_Loaded(object sender, RoutedEventArgs e)
        {
            var sqlString = "select * from [RaceKitOption]";
            lbxRaceKitOption.ItemsSource = db.GetDataSet(sqlString).Tables[0].DefaultView;
        }
        public double temp1=0;
        public double temp2=0;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            temp1 = double.Parse((sender as RadioButton).Tag.ToString());
            if (temp1!=null)
            {
                total.sum = total.sum - temp2;
                total.sum += temp1;
            }
            temp2 = double.Parse((sender as RadioButton).Tag.ToString());
            //tbTotal.DataContext = total;
        }

        private void cbFullMarathon_Click(object sender, RoutedEventArgs e)
        {
            if (cbFullMarathon.IsChecked==true)
            {
                total.sum += double.Parse((sender as CheckBox).Tag.ToString());
                tbTotal.DataContext = total;
                //MessageBox.Show(total.sum.ToString());
            }
            else {
                total.sum = total.sum - double.Parse((sender as CheckBox).Tag.ToString());
                tbTotal.DataContext = total;
                //MessageBox.Show(total.sum.ToString());
            }
        }

        private void cbHalfMarathon_Click(object sender, RoutedEventArgs e)
        {
            if (cbHalfMarathon.IsChecked == true)
            {
                total.sum += double.Parse((sender as CheckBox).Tag.ToString());
                tbTotal.DataContext = total;
                //MessageBox.Show(total.sum.ToString());
            }
            else
            {
                total.sum = total.sum - double.Parse((sender as CheckBox).Tag.ToString());
                tbTotal.DataContext = total;
                //MessageBox.Show(total.sum.ToString());
            }
        }

        private void cbFunRun_Click(object sender, RoutedEventArgs e)
        {
            if (cbFunRun.IsChecked == true)
            {
                total.sum += double.Parse((sender as CheckBox).Tag.ToString());
                tbTotal.DataContext = total;
                //MessageBox.Show(total.sum.ToString());
            }
            else
            {
                total.sum = total.sum - double.Parse((sender as CheckBox).Tag.ToString());
                tbTotal.DataContext = total;
                //MessageBox.Show(total.sum.ToString());
            }
        }
    }
}
