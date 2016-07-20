﻿using System;
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
    /// Interaction logic for FindMore.xaml
    /// </summary>
    public partial class FindMore : Master
    {
        public FindMore()
        {
            InitializeComponent();
        }

        private void btnBMICalculator_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BMICalculator());
        }
    }
}
