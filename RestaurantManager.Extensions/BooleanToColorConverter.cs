using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace RestaurantManager.Extensions
{
    public sealed class BooleanToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Color returnValue = Colors.Transparent;
            if(value is bool)
            {
                if((bool)value) returnValue = Colors.Red;
            }
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            bool returnValue = false;
            if(value is Color)
            {
                if ((Color)value == Colors.Red) returnValue = true;
            }
            return returnValue;
        }
    }
}
