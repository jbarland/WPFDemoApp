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
    /// Interaction logic for Exo6UserControl.xaml
    /// </summary>
    public partial class Exo6UserControl : UserControl
    {
        public Exo6UserControl()
        {
            InitializeComponent();
            StackPanel stackPanel = new StackPanel();
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Hello";
            stackPanel.Children.Add(textBlock);
            Button button = new Button();
            button.Width = 80;
            button.Content = "Valider";
            button.Click += btnClick;
            stackPanel.Children.Add(button);
            GridExo6.Children.Add(stackPanel);
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("World");
        }


    }
}
