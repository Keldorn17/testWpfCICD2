﻿using System.Globalization;
using System.Windows.Data;

namespace TODO.Utils
{
    public class PriorityLevelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int intValue)
            {
                return PriorityLevel.GetByIndex(intValue);
            }
            return PriorityLevel.Normal;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is PriorityLevel priorityLevel)
            {
                return priorityLevel.Index;
            }
            return 2;
        }
    }
}
