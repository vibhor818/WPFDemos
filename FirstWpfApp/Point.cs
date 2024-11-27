using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FirstWpfApp
{
    [TypeConverter(typeof(PointTypeConvertor))]
   public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public override string ToString()
        {
            return $"X:  {X},  Y: {Y}";
        }
    }
    public class  PointTypeConvertor:TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
        {
            return sourceType == typeof(string)|| base.CanConvertFrom(context,sourceType);
        }
        public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
        {
            if(value is string stringValue)
            {
                var parts=stringValue.Split(',');
                if(parts.Length == 2&& double.TryParse(parts[0],out double x)&&
                    parts.Length == 2 && double.TryParse(parts[1], out double y))
                { 
                    return new Point { X = x, Y = y };
                }
            }
            throw new FormatException("Invalid Point Format");
        }
        public override bool CanConvertTo(ITypeDescriptorContext? context, [NotNullWhen(true)] Type? destinationType)
        {
            return destinationType == typeof(string) || base.CanConvertFrom(context, destinationType);
        }
        public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
        {
            if (destinationType ==typeof(string)&& value is Point point)
            {
                return $"{point.X},{point.Y}";
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
