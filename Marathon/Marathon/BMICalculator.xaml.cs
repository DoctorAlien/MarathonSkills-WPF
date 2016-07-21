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
using System.Collections.ObjectModel;

namespace Marathon
{
    public class BmiInfo
    {
        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value / 100; }
        }
        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        private double _left;

        public double Left
        {
            get { return _left; }
            set { _left = value; }
        }
        private double _bmi;

        public double Bmi
        {
            get { return _bmi; }
            set { _bmi = value; }
        }

    }
    /// <summary>
    /// Interaction logic for BMICalculator.xaml
    /// </summary>
    public partial class BMICalculator : Master
    {
        public BMICalculator()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            var bmiInfo = new BmiInfo();
            bmiInfo.Height = double.Parse(txtHeight.Text);
            bmiInfo.Weight = double.Parse(txtWeight.Text);
            bmiInfo.Bmi = Math.Round(bmiInfo.Weight / bmiInfo.Height / bmiInfo.Height, 1);
            moveLeft(bmiInfo,75,18.5,25,30,100);
            this.DataContext = bmiInfo;  
        }

        private static void moveLeft(BmiInfo bmiInfo,double width,double underWeight,double healthy,double overWeight,double obese)
        {
            if (bmiInfo.Bmi <= underWeight)
            {
                bmiInfo.Left = bmiInfo.Bmi * width / underWeight;
            }
            else if (bmiInfo.Bmi > underWeight && bmiInfo.Bmi <= healthy)
            {
                bmiInfo.Left = (bmiInfo.Bmi - underWeight) * width / (healthy - underWeight) + width;
            }
            else if (bmiInfo.Bmi > healthy && bmiInfo.Bmi <= overWeight)
            {
                bmiInfo.Left = (bmiInfo.Bmi - healthy) * width / (overWeight - healthy) + width*2;
            }
            else if (bmiInfo.Bmi > overWeight && bmiInfo.Bmi <= obese)
            {
                bmiInfo.Left = (bmiInfo.Bmi - overWeight) * width / (obese - overWeight) + width*3;
            }
            else
            {
                bmiInfo.Left = 15;
            }
            bmiInfo.Left = bmiInfo.Left - 15;
        }
    }
}
