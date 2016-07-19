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
using System.Windows.Shapes;

namespace Marathon
{
    /// <summary>
    /// Interaction logic for CharityModal.xaml
    /// </summary>
    public partial class CharityModal : Window
    {
        public CharityModal()
        {
            InitializeComponent();
            this.Owner = App.Current.MainWindow;
        }
    }
}
