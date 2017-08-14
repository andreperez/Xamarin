using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto04.Model;
using Xamarin.Forms;

namespace Projeto04.Converter
{
    public class FinalizadoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (bool) value;

            if (valor == false)
            {
                return "Aberta";
            }
            else
            {
                return "Finalizada";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
