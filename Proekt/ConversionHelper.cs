using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    public static class ConversionHelper
    {
        public static double ConvertValue(int category, bool metricToImperial, double value)
        {
            switch (category)
            {
                case 0:
                    return metricToImperial ?
                        value * 3.280839895013123 :
                        value / 3.280839895013123;
                case 1:
                    return metricToImperial ?
                        value * 2.2046226218487757 :
                        value / 2.2046226218487757;
                case 2:
                    return metricToImperial ?
                        value * 3.785411784 :
                        value / 3.785411784;
                case 3:
                    return metricToImperial ?
                        value * 9.0 / 5.0 + 32 :
                        (value - 32) * 5.0 / 9.0;
                default:
                    throw new ArgumentException("Nevalidna kategoriq");
            }
        }

        public static string GetUnit(int category, bool metric)
        {
            switch (category)
            {
                case 0:
                    return metric ? "m" : "ft";
                case 1:
                    return metric ? "kg" : "lbs";
                case 2:
                    return metric ? "L" : "gallons";
                case 3:
                    return metric ? " C" : " F";
                default:
                    return "";
            }
        }
            
    }
}
