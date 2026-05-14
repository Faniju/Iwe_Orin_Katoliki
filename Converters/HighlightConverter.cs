using System;
using Microsoft.Maui.Controls;
using YorubaCatholicHymn.ViewModels;

namespace YorubaCatholicHymn.Converters
{
    public class HighlightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var text = value as string;
            var searchTerm = parameter as string;

            if (string.IsNullOrEmpty(text))
                return new FormattedString { Spans = { new Span { Text = "" } } };

            var vm = Application.Current.MainPage.BindingContext as MainPageViewModel;
            return  new FormattedString { Spans = { new Span { Text = text } } };
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
