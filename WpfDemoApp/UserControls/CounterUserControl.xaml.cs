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
using WpfDemoApp.ViewModels;

namespace WpfDemoApp.UserControls
{
    /// <summary>
    /// Interaction logic for CounterControl.xaml
    /// </summary>
    public partial class CounterUserControl : UserControl
    {
        public CounterUserControl()
        {
            InitializeComponent();
            DataContext = new CounterViewModel();
        }
    }
}
