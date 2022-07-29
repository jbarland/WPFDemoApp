using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WpfDemoApp.Models;

namespace WpfDemoApp.Converters
{
    //Conversion inutile car par défaut prend le tostring mais fonctionnel
    internal class MessageToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<Message> MyMessagesList = (ObservableCollection<Message>)value;
            List<string> mls = new List<string>();
            foreach (var m in MyMessagesList)
            {
                mls.Add(m.ToString());
            }
            return mls;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
