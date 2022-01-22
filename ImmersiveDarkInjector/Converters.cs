using System;
using System.Globalization;
using System.Windows.Data;

namespace ImmersiveDarkInjector
{
	[ValueConversion(typeof(int), typeof(bool))]
	public class Int2BooleanConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			=> (int)value == 0 ? false : true;

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
			=> throw new NotImplementedException();
	}

	[ValueConversion(typeof(bool), typeof(bool))]
	public class InvertedBooleanConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			=> (bool)value ? false : true;

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
			=> !(bool)value ? true : false;
	}
}
