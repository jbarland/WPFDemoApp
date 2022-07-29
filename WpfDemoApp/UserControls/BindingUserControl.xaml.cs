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
    /// Interaction logic for BindingUserControl.xaml
    /// </summary>
    public partial class BindingUserControl : UserControl
    {
        public BindingUserControl()
        {
            InitializeComponent();
            DataContext = new BindingViewModel();

            myBtn.Width = myTextBlock.Width = myTextBox.Width = myComboList.Width = 300;
            myBtn.Margin = myTextBlock.Margin = myTextBox.Margin = myComboList.Margin = new Thickness(0,6,0,6);
            btnAdd.Margin = btnDeleteFirst.Margin = btnAddMsg.Margin = btnDeleteSelectedMsg.Margin = new Thickness(6);
            btnUpdateFirst.Margin = new Thickness(0, 6, 0, 6);
            btnUpdateFirstMsg.Margin = new Thickness(0, 6, 3, 6);
            btnDeleteFirstMsg.Margin = new Thickness(3, 6, 0, 6);


            intLabel.HorizontalContentAlignment = HorizontalAlignment.Right;
            intLabel.FontSize = 16;

            intRandom.FontWeight = FontWeights.Bold;
            intRandom.FontSize = 16;
            intRandom.HorizontalContentAlignment = HorizontalAlignment.Left;

            if (((BindingViewModel)(this.DataContext)).MyStringList.Count() == 0)
            {
                btnDeleteFirst.IsEnabled = false;
            }
        }
    }
}
