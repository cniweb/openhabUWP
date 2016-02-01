﻿using System;
using Windows.UI.Xaml.Data;
using openhabUWP.Models;
using openhabUWP.Remote.Models;

namespace openhabUWP.Converters
{
    public class WidgetClickableConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var item = value as Widget;
            if (item != null)
            {
                if (item.LinkedPage != null)
                {
                    return true;
                }

                if (item.Type == "Switch")
                {
                    return true;
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
