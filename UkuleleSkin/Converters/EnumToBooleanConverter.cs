﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace UkuleleSkin.Converters
{
    public class EnumToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value.ToString() != parameter.ToString())
            {
                return false;
            }
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && value.Equals(true) ? parameter : Binding.DoNothing;
        }
    }
}
