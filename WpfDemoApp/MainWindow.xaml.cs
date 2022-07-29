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
using WpfDemoApp.UserControls;

namespace WpfDemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuExo1_Click(object sender, RoutedEventArgs e)
        {
            var exo1UC = new Exo1UserControl();

            containerUC.Content = exo1UC;
        }

        private void MenuExo2_Click(object sender, RoutedEventArgs e)
        {
            var exo2UC = new Exo2UserControl();

            containerUC.Content = exo2UC;

        }

        private void MenuExo3a_Click(object sender, RoutedEventArgs e)
        {
            var exo3aUC = new Exo3aUserControl();

            containerUC.Content = exo3aUC;

        }

        private void MenuExo4_Click(object sender, RoutedEventArgs e)
        {
            var exo4UC = new Exo4UserControl();

            containerUC.Content = exo4UC;

        }

        private void MenuExo5_Click(object sender, RoutedEventArgs e)
        {
            var exo5UC = new Exo5UserControl();

            containerUC.Content = exo5UC;

        }

        private void MenuExo6_Click(object sender, RoutedEventArgs e)
        {
            var exo6UC = new Exo6UserControl();

            containerUC.Content = exo6UC;

        }

        private void MenuExo7_Click(object sender, RoutedEventArgs e)
        {
            var exo7UC = new Exo7UserControl();

            containerUC.Content = exo7UC;

        }

        private void MenuExo8_Click(object sender, RoutedEventArgs e)
        {
            var exo8UC = new Exo8UserControl();

            containerUC.Content = exo8UC;

        }

        private void MenuExo9_Click(object sender, RoutedEventArgs e)
        {
            var exo9UC = new Exo9UserControl();

            containerUC.Content = exo9UC;

        }

        private void MenuExo10_Click(object sender, RoutedEventArgs e)
        {
            var exo10UC = new Exo10UserControl();

            containerUC.Content = exo10UC;

        }

        private void MenuBinding_Click(object sender, RoutedEventArgs e)
        {
            var demoBinding = new BindingUserControl();

            containerUC.Content = demoBinding;

        }
    }
}
