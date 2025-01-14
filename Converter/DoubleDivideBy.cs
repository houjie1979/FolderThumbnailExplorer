﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace FolderThumbnailExplorer.Converter
{
	public class DoubleDivideBy : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (double)value / double.Parse((string)parameter);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
