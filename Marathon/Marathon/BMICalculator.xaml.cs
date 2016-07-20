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
    /// Interaction logic for BMICalculator.xaml
    /// </summary>
    public partial class BMICalculator : Master
    {
        public BMICalculator()
        {
            InitializeComponent();
        }
        public double _height;
        private double _weight;
        public double height {
            get { return _height; }
            set { _height = value/100; }
        }
        public double weight {
            get { return _weight; }
            set { _weight = value; }
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            height = double.Parse(txtHeight.Text);
            weight = double.Parse(txtWeight.Text);
            double bmi = weight / height / height;
            MessageBox.Show(bmi.ToString());
        }

        //public double moveBmi(double bmi) {
        //    double move;
        //    if (bmi<18.5||bmi==18.5)
        //    {
        //        move = bmi * 18 / 76-15;
        //    }
        //    else if (bmi>18.5&&bmi<25)
        //    {
        //        move = bmi * 6.5 / 76 - 15 + 76;
        //    }
        //    else if (bmi)
        //    {

        //    }
        }
    }
}
