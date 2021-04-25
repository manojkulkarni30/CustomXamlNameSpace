using System;
using System.Globalization;
using Humanizer;
using Xamarin.Forms;

namespace SharedLibrary.Converters
{
    public class NumberToWordConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var number = (long)parameter;
            return number.ToWords().ToUpper();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
