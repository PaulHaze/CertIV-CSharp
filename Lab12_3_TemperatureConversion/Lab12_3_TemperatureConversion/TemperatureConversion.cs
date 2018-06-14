using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_3_TemperatureConversion
{
    public class TemperatureConversion
    {
        //private double tempCelsius;
        //private double tempFarenheit;

        //public double TempCelsius { get => tempCelsius; set => tempCelsius = value; }
        //public double TempFarenheit { get => tempFarenheit; set => tempFarenheit = value; }




        // conversion methods
        public static double ConvertToFarenheit(string tempCelsius)
        {
            double celsius = double.Parse(tempCelsius);
            return (celsius * 9 / 5) + 32;
        }

        public static double ConvertToCelsius(string tempFarenheit)
        {
            double farenheit = double.Parse(tempFarenheit);
            return (farenheit - 32) * 5 / 9;
        }
    }
}
