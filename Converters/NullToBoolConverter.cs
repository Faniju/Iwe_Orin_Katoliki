using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace YorubaCatholicHymn.Converters
{
    public class NullToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return false;
            var str = value.ToString();
            return !string.IsNullOrWhiteSpace(str);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}


