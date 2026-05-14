using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace YorubaCatholicHymn.Converters
{
    public class FirstLineConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = value as string;
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            // Normalize line endings and split
            var lines = text.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n');
            // Return first non-empty trimmed line
            foreach (var line in lines)
            {
                var trimmed = line.Trim();
                if (!string.IsNullOrEmpty(trimmed))
                    return trimmed;
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
