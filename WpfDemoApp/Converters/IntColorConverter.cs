using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfDemoApp.Converters
{
    internal class IntColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int myInt = (int)value;

            if (myInt % 10 == 0)
            {
                return new SolidColorBrush(Colors.Blue);
            }
            else if (myInt > 10)
            {
                return new SolidColorBrush(Colors.Green);
            }          
            else
            {
                return new SolidColorBrush(Colors.Red);
            }                
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
