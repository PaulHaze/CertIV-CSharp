using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_8_Constants
{
    public class ConvertFromKm
    {
        // fields
        private double unitInKm;
        public double UnitInKm { get => unitInKm; set => unitInKm = value; }

        public const double KM_TO_M = 1000;
        public const double KM_TO_CM = 100000;

        // constructors

        public ConvertFromKm(double kilometres)
        {
            UnitInKm = kilometres;
        }

        // methods

        public double ConvertKiloToMeters()
        {
            return unitInKm * KM_TO_M;
        }
        public double ConvertKiloToCM()
        {
            return unitInKm * KM_TO_CM;
        }
    }
}
