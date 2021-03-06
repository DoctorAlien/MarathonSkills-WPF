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
    /// Interaction logic for SponsorRunner.xaml
    /// </summary>
    public partial class SponsorRunner : Master
    {
        public SponsorRunner()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var form = new CharityModal();
            form.ShowDialog();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtDonate.Text)>=10)
            {
                txtDonate.Text = (int.Parse(txtDonate.Text) - 10).ToString();
            }
            
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            txtDonate.Text = (int.Parse(txtDonate.Text) + 10).ToString();
        }
    }
}
