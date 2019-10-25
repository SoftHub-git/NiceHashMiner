﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using NHMCore.Mining.Plugins;

namespace NHM.Wpf.Views.PluginsNew.PluginItem.Converters
{
    public class CompatibleVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is PluginPackageInfoCR pluginCR)
            {
                if (!pluginCR.CompatibleNHPluginVersion) return Visibility.Hidden;
                if (!pluginCR.Supported) return Visibility.Hidden;
                return Visibility.Visible;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
