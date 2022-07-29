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

namespace WpfDemoApp.UserControls
{
    /// <summary>
    /// Interaction logic for Exo1UserControl.xaml
    /// </summary>
    public partial class Exo1UserControl : UserControl
    {
        public Exo1UserControl()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("World");
        }
    }
}
