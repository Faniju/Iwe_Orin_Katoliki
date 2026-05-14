using Microsoft.Maui.Controls;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
namespace YorubaCatholicHymn.Converters
{
    public class PrayerTextFormatterConverter : IValueConverter
    {
        private static readonly Regex TagRegex = new Regex(@"\[/?(?:red|i|b)\]", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = value as string;
            if (string.IsNullOrWhiteSpace(text))
            {
                return new FormattedString();
            }
            var formatted = new FormattedString();
            var redDepth = 0;
            var italicDepth = 0;
            var boldDepth = 0;
            var lastIndex = 0;
            foreach (Match match in TagRegex.Matches(text))
            {
                if (match.Index > lastIndex)
                {
                    AppendStyledSpan(
                        formatted,
                        text.Substring(lastIndex, match.Index - lastIndex),
                        redDepth > 0,
                        italicDepth > 0,
                        boldDepth > 0);
                }
                var tag = match.Value.ToLowerInvariant();
                switch (tag)
                {
                    case "[red]":
                        redDepth++;
                        break;
                    case "[/red]":
                        redDepth = Math.Max(0, redDepth - 1);
                        break;
                    case "[i]":
                        italicDepth++;
                        break;
                    case "[/i]":
                        italicDepth = Math.Max(0, italicDepth - 1);
                        break;
                    case "[b]":
                        boldDepth++;
                        break;
                    case "[/b]":
                        boldDepth = Math.Max(0, boldDepth - 1);
                        break;
                }
                
                lastIndex = match.Index + match.Length;
            }
            if (lastIndex < text.Length)
{
                AppendStyledSpan(
                                 formatted,
                                 text.Substring(lastIndex),
                                 redDepth > 0,
                                 italicDepth > 0,
                                 boldDepth > 0);
            }
            return formatted;
        }
        private static void AppendStyledSpan(FormattedString formatted, string content, bool red, bool italic, bool bold)
        {
            if (string.IsNullOrEmpty(content))
            {
                return;
            }
            var attributes = FontAttributes.None;
            if (italic)
            {
                attributes |= FontAttributes.Italic;
            }
            if (bold)
            {
                attributes |= FontAttributes.Bold;
            }
            formatted.Spans.Add(new Span
            {
                Text = content,
                TextColor = red ? Colors.Red : Colors.Black,
                FontAttributes = attributes
            });
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

