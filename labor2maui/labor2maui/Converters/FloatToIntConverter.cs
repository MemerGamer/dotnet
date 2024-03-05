using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bozsi.Converters
{
    public class FloatToIntConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            float multipli;
            if(!float.TryParse(parameter as string, out multipli))
            {
                multipli = 1;
            }
            return (int)Math.Round(multipli * (float)value);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            float dev;
            if (!float.TryParse(parameter as string, out dev))
            {
                dev = 1;
            }
            return (int)value/ dev;
        }
    }
}
