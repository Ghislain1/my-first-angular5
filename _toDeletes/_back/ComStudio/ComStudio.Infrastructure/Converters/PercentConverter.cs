﻿using System.Globalization;
using System.Windows.Data;

namespace ComStudio.Infrastructure.Converters
{
    public class PercentConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            var result = value as decimal?;
            if (result == null)
                result = 0;

            return System.String.Format(CultureInfo.CurrentUICulture, "{0:F1}%", result.Value);
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}